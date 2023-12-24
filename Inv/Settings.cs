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
using System.Configuration;
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
            TabPage _tabPage = settingsTabControl.TabPages[e.Index];
            Rectangle _tabBounds = settingsTabControl.GetTabRect(e.Index);
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
            if (confirmClearDBTextBox.Text == "Я хочу удалить все записи из базы данных") ClearDBButton.Enabled = true;
            else ClearDBButton.Enabled = false;
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
            switch (ApplicationData.autoref)
            {
                case 10000:
                    updateCooldownComboBox.SelectedIndex = 1;
                    break;
                case 30000:
                    updateCooldownComboBox.SelectedIndex = 2;
                    break;
                case 100000:
                    updateCooldownComboBox.SelectedIndex = 3;
                    break;
                case 300000:
                    updateCooldownComboBox.SelectedIndex = 4;
                    break;
                case 1200000:
                    updateCooldownComboBox.SelectedIndex = 5;
                    break;
                default:
                    updateCooldownComboBox.SelectedIndex = 0;
                    break;
            }
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
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
                    infoLabel2.Text = "Размер файла базы данных: " + String.Join(", ", ValuesFromDB) + " МБ";
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int temp = 10000;
            switch (updateCooldownComboBox.SelectedIndex)
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
            ApplicationData.autoref = temp;
            ApplicationData.timer.Interval = ApplicationData.autoref;
        }
    }
}
