using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using System.Configuration;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.InteropServices;

namespace Inv
{
    public partial class Main : Form
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        public Main()
        {
            InitializeComponent();
        }
        public void uploadAdd()
        {
            string sql = "SELECT * FROM GetAdd";
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }
        public void uploadSub()
        {
            string sql = "SELECT * FROM GetSub";
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];
            }
        }
        public void uploadCur()
        {
            string sql = "SELECT * FROM GetCur WHERE [Кол-во] > 0";
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView3.DataSource = ds.Tables[0];
            }
        }
        private void clearAddPanel()
        {
            textBoxName0.Text = "";
            textBoxCode0.Text = "";
            textBoxInv0.Text = "";
            dateTimePicker0.Value = DateTime.Now;
            numericUpDown0.Value = 1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                string name = textBoxName0.Text;
                string code = textBoxCode0.Text;
                string inv = textBoxInv0.Text;
                string date = dateTimePicker0.Value.ToLongDateString() + " " + dateTimePicker0.Value.ToLongTimeString();
                int count = (int)numericUpDown0.Value;
                if (db.Items.Where(x => x.name == name && x.code == code && x.inv == inv).ToArray().Length > 0)
                {
                    MessageBox.Show("Поступление с подобными параметрами уже существует");
                    clearAddPanel();
                    return;
                }
                Item item = new Item { name = name, code = code, inv = inv };
                db.Items.Add(item);
                AddItem oper = new AddItem { date = date, count = count, item = item };
                db.AddItems.Add(oper);
                db.SaveChanges();
            }
            clearAddPanel();
            updateFromBase();
        }

        private void withdrawItem()
        {
            SubModal sb = new SubModal();
            sb.textBoxName0.Text = dataGridView3.SelectedRows[0].Cells[0].Value.ToString();
            sb.textBoxCode0.Text = dataGridView3.SelectedRows[0].Cells[1].Value.ToString();
            sb.textBoxInv0.Text = dataGridView3.SelectedRows[0].Cells[2].Value.ToString();
            sb.textBox1.Text = dataGridView3.SelectedRows[0].Cells[3].Value.ToString();
            sb.numericUpDown0.Value = int.Parse(dataGridView3.SelectedRows[0].Cells[5].Value.ToString());
            sb.ShowDialog();
            if (sb.DialogResult == DialogResult.Yes) uploadCur();
            updateFromBase();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            withdrawItem();
        }
        private void updateFromBase()
        {
            uploadCur();
            uploadAdd();
            uploadSub();
            label6.Text = "Последнее обновление: " + DateTime.Now;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            SearchTextBox.Text = "";
            ApplicationData.timer.Stop();
            ApplicationData.timer.Interval = ApplicationData.autoref;
            ApplicationData.timer.Start();
            updateFromBase();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            updateFromBase();
            ApplicationData.autoref = int.MaxValue;
            ApplicationData.timer.Tick += (sender, args) =>
            {
                ApplicationData.timer.Stop();
                if (!ApplicationData.isSearching) updateFromBase();
                ApplicationData.timer.Interval = ApplicationData.autoref;
                ApplicationData.timer.Start();
            };
            ApplicationData.timer.Start();
        }
        private void dataGridView3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hit = dataGridView3.HitTest(e.X, e.Y);
                if (hit.RowIndex >= 0)
                {
                    dataGridView3.ClearSelection();
                    dataGridView3.Rows[hit.RowIndex].Selected = true;
                    contextMenuStrip1.Show(dataGridView3, e.Location);
                }
            }
        }

        private void расходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            withdrawItem();
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            ApplicationData.isSearching = true;
            var value = SearchTextBox.Text;

            if (tabControl1.SelectedIndex == 0)
            {
                string sql = $"SELECT * FROM GetCur WHERE ([Наименование] LIKE N'%{value}%'" +
                    $"OR [Артикул] LIKE N'%{value}%' OR [Инв. №] LIKE N'%{value}%') AND [Кол-во] > 0";
                if (value.Length == 0)
                {
                    sql = "SELECT * FROM GetCur WHERE [Кол-во] > 0";
                    ApplicationData.isSearching = false;
                }

                using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView3.DataSource = ds.Tables[0];
                }
            }
            if (tabControl1.SelectedIndex == 1)
            {
                string sql = $"SELECT * FROM GetAdd WHERE ([Наименование] LIKE N'%{value}%'" +
                    $"OR [Артикул] LIKE N'%{value}%' OR [Инв. №] LIKE N'%{value}%')";
                if (value.Length == 0)
                {
                    sql = "SELECT * FROM GetAdd";
                    ApplicationData.isSearching = false;
                }

                using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                }
            }
            if (tabControl1.SelectedIndex == 2)
            {
                string sql = $"SELECT * FROM GetSub WHERE ([Наименование] LIKE N'%{value}%'" +
                    $"OR [Артикул] LIKE N'%{value}%' OR [Инв. №] LIKE N'%{value}%')";
                if (value.Length == 0)
                {
                    sql = "SELECT * FROM GetSub";
                    ApplicationData.isSearching = false;
                }
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView2.DataSource = ds.Tables[0];
                }
            }
        }

        private void contextMenuStrip1_Opened(object sender, EventArgs e)
        {
            ApplicationData.isSearching = true;
        }

        private void contextMenuStrip1_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            ApplicationData.isSearching = false;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchTextBox.Clear();
            SearchTextBox_TextChanged(sender, e);
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.ShowDialog();
            if (settings.DialogResult == DialogResult.OK) updateFromBase();
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hit = dataGridView1.HitTest(e.X, e.Y);
                if (hit.RowIndex >= 0)
                {
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[hit.RowIndex].Selected = true;
                    contextMenuStrip2.Show(dataGridView1, e.Location);
                }
            }
        }

        private void удалитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить запись о поступлении?", "Подтверждение", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    Item[] items = db.Items.Where(x => x.name == dataGridView1.SelectedRows[0].Cells[0].Value.ToString() &&
                                                    x.code == dataGridView1.SelectedRows[0].Cells[1].Value.ToString() &&
                                                    x.inv == dataGridView1.SelectedRows[0].Cells[2].Value.ToString()
                                              ).ToArray();
                    if (items.Length == 0)
                        MessageBox.Show("Запись не найдена", "Ошибка");
                    else
                    {
                        db.Items.Remove(items[0]);
                        db.SaveChanges();
                    }
                }
                updateFromBase();
            }
        }

        private void contextMenuStrip2_Opened(object sender, EventArgs e)
        {
            ApplicationData.isSearching = true;
        }

        private void contextMenuStrip2_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            ApplicationData.isSearching = false;
        }

        private void dataGridView2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hit = dataGridView2.HitTest(e.X, e.Y);
                if (hit.RowIndex >= 0)
                {
                    dataGridView2.ClearSelection();
                    dataGridView2.Rows[hit.RowIndex].Selected = true;
                    contextMenuStrip3.Show(dataGridView2, e.Location);
                }
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить запись о расходе?", "Подтверждение", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    Item item = db.Items.Where(x => x.name == dataGridView2.SelectedRows[0].Cells[0].Value.ToString() &&
                                                    x.code == dataGridView2.SelectedRows[0].Cells[1].Value.ToString() &&
                                                    x.inv == dataGridView2.SelectedRows[0].Cells[2].Value.ToString()
                                              ).ToArray()[0];
                    SubItem[] t = db.SubItems.Where(x => x.date == dataGridView2.SelectedRows[0].Cells[3].Value.ToString()).ToArray();
                    if (t.Length == 0)
                        MessageBox.Show("Запись не найдена", "Ошибка");
                    else
                    {
                        db.SubItems.Remove(t[0]);
                        db.SaveChanges();
                    }
                }
                updateFromBase();
            }
        }
    }
    class ApplicationData
    {
        public static int autoref;
        public static System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer { Interval = 1 };
        public static bool isSearching;
    }
}