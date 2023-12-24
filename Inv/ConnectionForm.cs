using System.Configuration;

namespace Inv
{
    public partial class ConnectionForm : Form
    {
        public ConnectionForm() => InitializeComponent();
        private Configuration? config;
        private KeyValueConfigurationCollection? settings;

        private void ConnectionForm_Load(object sender, EventArgs e)
        {
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (config == null)
            {
                MessageBox.Show("Error opening the configuration file");
                Application.Exit();
            }
            settings = config.AppSettings.Settings;
            if (settings == null)
            {
                MessageBox.Show("Error when getting settings from the configuration file");
                Application.Exit();
            }

            if (settings.AllKeys.Contains("DataSource"))
                databaseTextBox.Text = ConfigurationManager.AppSettings["DataSource"];
        }
        private void confirmButton_Click(object sender, EventArgs e)
        {
            settings.Remove("DataSource");
            settings.Add("DataSource", databaseTextBox.Text);

            settings.Remove("ConnectionString");
            settings.Add("ConnectionString",
                    $"Data Source = {databaseTextBox.Text}; " +
                    $"Initial Catalog = {catalogTextBox.Text}; " +
                    "Integrated Security = True; " +
                    "Connect Timeout = 30; " +
                    "Encrypt = False; " +
                    "Trust Server Certificate = False; " +
                    "Application Intent = ReadWrite; " +
                    "Multi Subnet Failover = False"
                    );
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void ConnectionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult != DialogResult.OK)
                Application.Exit();
        }
    }
}
