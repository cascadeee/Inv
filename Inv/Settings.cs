using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Inv
{

    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;
            TabPage _tabPage = tabControl1.TabPages[e.Index];
            Rectangle _tabBounds = tabControl1.GetTabRect(e.Index);
            if (e.State == DrawItemState.Selected)
                _textBrush = new SolidBrush(Color.Gray);
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }
            Font _tabFont = new Font("Segoe UI", 12.0f, FontStyle.Regular, GraphicsUnit.Pixel);
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "Я хочу удалить все записи из базы данных") button1.Enabled = true;
            else button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.AddItems.RemoveRange(db.AddItems);
                db.SubItems.RemoveRange(db.SubItems);
                db.Items.RemoveRange(db.Items);
                db.SaveChanges();
            }
            DialogResult = DialogResult.OK;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            switch (Trash.autoref)
            {
                case 10000:
                    comboBox1.SelectedIndex = 1;
                    break;
                case 30000:
                    comboBox1.SelectedIndex = 2;
                    break;
                case 100000:
                    comboBox1.SelectedIndex = 3;
                    break;
                case 300000:
                    comboBox1.SelectedIndex = 4;
                    break;
                case 1200000:
                    comboBox1.SelectedIndex = 5;
                    break;
                default:
                    comboBox1.SelectedIndex = 0;
                    break;
            }
            using (SqlConnection connection = new SqlConnection("Data Source=WIN-UAQ8QUDRBSS\\INVENTORY;Initial Catalog=Inv;User ID=root;Password=aezakmi89;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT TOP 1(SIZE * 8) / 1024 SizeMB FROM sys.master_files WHERE DB_NAME(database_id) = 'Inv'", connection);
                using (var reader = command.ExecuteReader())
                {
                    List<string> ValuesFromDB = new List<string>();
                    while (reader.Read())
                    {
                        for (int i = 0; i <= reader.FieldCount - 1; i++)
                        {
                            ValuesFromDB.Add(reader[i].ToString());
                        }
                    }
                    connection.Close();
                    label3.Text = "Размер файла базы данных: " + String.Join(", ", ValuesFromDB) +" МБ";
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int temp = 10000;
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    temp = int.MaxValue;
                    break;
                case 1:
                    temp = 10000;
                    break;
                case 2:
                    temp = 30000;
                    break;
                case 3:
                    temp = 100000;
                    break;
                case 4:
                    temp = 300000;
                    break;
                case 5:
                    temp = 1200000;
                    break;
            }
            Trash.autoref = temp;
            Trash.timer.Interval = Trash.autoref;
        }
    }
}
