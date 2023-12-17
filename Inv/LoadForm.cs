using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inv
{
    public partial class LoadForm : Form
    {
        Configuration config;
        public LoadForm()
        {
            InitializeComponent();
        }
        //Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False
        private void LoadForm_Load(object sender, EventArgs e)
        {
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            string[] configKeys = config.AppSettings.Settings.AllKeys;
            if (configKeys.Contains("ConnectionString"))
            {
                string autoFiller = ConfigurationManager.AppSettings["ConnectionString"];
                textBox1.Text = autoFiller.Substring(autoFiller.IndexOf('=') + 1, autoFiller.IndexOf(';') - 1 - autoFiller.IndexOf('=')).Trim();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            config.AppSettings.Settings.Remove("ConnectionString");
            config.AppSettings.Settings.Add("ConnectionString",
                    $"Data Source = {textBox1.Text}; " +
                    $"Initial Catalog = {textBox2.Text}; " +
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

        private void LoadForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult != DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
