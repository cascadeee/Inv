using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Inv
{
    public partial class ConnectionForm : Form
    {
        public ConnectionForm() => InitializeComponent();
        private Configuration? config;
        private KeyValueConfigurationCollection? settings;
        private string[] checkList = { "Items", "SubItems", "AddItems", "GetCur", "GetSub", "GetAdd" };
        private void Validator(object sender, EventArgs e)
        {
            if (databaseTextBox.Text.Length != 0 && catalogComboBox.SelectedIndex != -1)
                confirmButton.Enabled = true;
        }

        private void ConnectionForm_Load(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (config == null)
            {
                MessageBox.Show("Ошибка при открытии конфигурационного файла");
                Application.Exit();
            }
            settings = config.AppSettings.Settings;
            if (settings == null)
            {
                MessageBox.Show("Ошибка при получении конфигурационных настроек");
                Application.Exit();
            }

            if (settings.AllKeys.Contains("DataSource"))
                databaseTextBox.Text = ConfigurationManager.AppSettings["DataSource"];
        }
        private void createConnectionString(bool isInitialCatalogIncluded)
        {
            settings.Remove("ConnectionString");
            settings.Add("ConnectionString",
                    $"Data Source = {databaseTextBox.Text}; " +
                    (isInitialCatalogIncluded ? $"Initial Catalog = {catalogComboBox.SelectedItem.ToString()}; " : "") +
                    "Integrated Security = True; " +
                    "Connect Timeout = 3; " +
                    "Encrypt = False; " +
                    "Trust Server Certificate = False; " +
                    "Application Intent = ReadWrite; " +
                    "Multi Subnet Failover = False"
                    );
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }
        private void confirmButton_Click(object sender, EventArgs e)
        {
            settings.Remove("DataSource");
            settings.Add("DataSource", databaseTextBox.Text);

            createConnectionString(isInitialCatalogIncluded: true);

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
            {
                connection.Open();
                DataTable t = connection.GetSchema("Tables");
                List<string> catalogTables = new List<string>();
                foreach (DataRow item in t.Rows)
                    catalogTables.Add(item[2].ToString());
                if (!checkList.All(s => catalogTables.Contains(s)))
                {
                    if (MessageBox.Show("Данный каталог не настроен для работы с программой\nВы хотите настроить данный каталог для работы?",
                        "Подтверждение", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        List<string> scripts = new List<string>();
                        foreach (string item in File.ReadAllText(@"sql/makeTables.sql").Split("GO", StringSplitOptions.RemoveEmptyEntries))
                            scripts.Add(item);
                        scripts.Add(File.ReadAllText(@"sql/GetCurView.sql"));
                        scripts.Add(File.ReadAllText(@"sql/GetAddView.sql"));
                        scripts.Add(File.ReadAllText(@"sql/GetSubView.sql"));
                        foreach (string commandString in scripts)
                            if (!string.IsNullOrWhiteSpace(commandString.Trim()))
                                using (var command = new SqlCommand(commandString, connection))
                                {
                                    command.ExecuteNonQuery();
                                }
                    }
                    connection.Close();
                    return;
                }

            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void tryToConnectButton_Click(object sender, EventArgs e)
        {
            createConnectionString(isInitialCatalogIncluded: false);
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
            {
                try
                {
                    connection.Open();
                }
                catch (Exception ex)
                {
                    switch (ex.HResult)
                    {
                        case -2146232060:
                            MessageBox.Show("Указанной базы данных не существует");
                            break;
                        default:
                            MessageBox.Show("Неизвестная ошибка");
                            break;
                    }
                    return;
                }

                DataTable t = connection.GetSchema("Databases");
                catalogComboBox.Items.Clear();
                foreach (DataRow item in t.Rows)
                    catalogComboBox.Items.Add(item[0]);
                catalogComboBox.Enabled = catalogComboBox.Items.Count != 0;
                catalogComboBox.SelectedIndex = 0;
            }
        }

        private void databaseTextBox_TextChanged(object sender, EventArgs e)
        {
            tryToConnectButton.Enabled = databaseTextBox.Text.Length > 0;
            catalogComboBox.Items.Clear();
            catalogComboBox.SelectedIndex = -1;
            catalogComboBox.Text = "";
            catalogComboBox.Enabled = false;
            confirmButton.Enabled = false;
        }

        private void ConnectionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.DialogResult != DialogResult.OK)
                System.Environment.Exit(0);
        }
    }
}
