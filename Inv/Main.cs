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
                addDataGridView.DataSource = ds.Tables[0];
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
                subDataGridView.DataSource = ds.Tables[0];
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
                currentDataGridView.DataSource = ds.Tables[0];
            }
        }
        private void clearAddPanel()
        {
            itemNameTextBox.Text = "";
            itemCodeTextBox.Text = "";
            itemInvTextBox.Text = "";
            itemArrivalDateTimePicker.Value = DateTime.Now;
            itemCountNumericUpDown.Value = 1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                string name = itemNameTextBox.Text;
                string code = itemCodeTextBox.Text;
                string inv = itemInvTextBox.Text;
                string date = itemArrivalDateTimePicker.Value.ToLongDateString() + " " + itemArrivalDateTimePicker.Value.ToLongTimeString();
                int count = (int)itemCountNumericUpDown.Value;
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
            sb.itemNameTextBox.Text = currentDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            sb.itemCodeTextBox.Text = currentDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            sb.itemInvTextBox.Text = currentDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            sb.itemArrivalDateTextBox.Text = currentDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            sb.itemCountNumericUpDown.Value = int.Parse(currentDataGridView.SelectedRows[0].Cells[5].Value.ToString());
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
            lastUpdateTimeLabel.Text = "Последнее обновление: " + DateTime.Now;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            searchTextBox.Text = "";
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
                var hit = currentDataGridView.HitTest(e.X, e.Y);
                if (hit.RowIndex >= 0)
                {
                    currentDataGridView.ClearSelection();
                    currentDataGridView.Rows[hit.RowIndex].Selected = true;
                    subItemContextMenuStrip.Show(currentDataGridView, e.Location);
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
            var value = searchTextBox.Text;

            if (MainTabControl.SelectedIndex == 0)
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
                    currentDataGridView.DataSource = ds.Tables[0];
                }
            }
            if (MainTabControl.SelectedIndex == 1)
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
                    addDataGridView.DataSource = ds.Tables[0];
                }
            }
            if (MainTabControl.SelectedIndex == 2)
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
                    subDataGridView.DataSource = ds.Tables[0];
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
            searchTextBox.Clear();
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
                var hit = addDataGridView.HitTest(e.X, e.Y);
                if (hit.RowIndex >= 0)
                {
                    addDataGridView.ClearSelection();
                    addDataGridView.Rows[hit.RowIndex].Selected = true;
                    removeAddRecordContextMenuStrip.Show(addDataGridView, e.Location);
                }
            }
        }

        private void удалитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить запись о поступлении?", "Подтверждение", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    Item[] items = db.Items.Where(x => x.name == addDataGridView.SelectedRows[0].Cells[0].Value.ToString() &&
                                                    x.code == addDataGridView.SelectedRows[0].Cells[1].Value.ToString() &&
                                                    x.inv == addDataGridView.SelectedRows[0].Cells[2].Value.ToString()
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
                var hit = subDataGridView.HitTest(e.X, e.Y);
                if (hit.RowIndex >= 0)
                {
                    subDataGridView.ClearSelection();
                    subDataGridView.Rows[hit.RowIndex].Selected = true;
                    removeSubRecordContextMenuStrip.Show(subDataGridView, e.Location);
                }
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить запись о расходе?", "Подтверждение", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    Item item = db.Items.Where(x => x.name == subDataGridView.SelectedRows[0].Cells[0].Value.ToString() &&
                                                    x.code == subDataGridView.SelectedRows[0].Cells[1].Value.ToString() &&
                                                    x.inv == subDataGridView.SelectedRows[0].Cells[2].Value.ToString()
                                              ).ToArray()[0];
                    SubItem[] t = db.SubItems.Where(x => x.date == subDataGridView.SelectedRows[0].Cells[3].Value.ToString()).ToArray();
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