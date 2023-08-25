using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inv
{
    public partial class SubModal : Form
    {
        public SubModal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                int count = (int)numericUpDown0.Value;
                Item item = db.Items.Where(x => x.name == textBoxName0.Text && x.code == textBoxCode0.Text && x.inv == textBoxInv0.Text).ToArray()[0];
                SubItem oper = new SubItem { date = dateTimePicker1.Value.ToLongDateString() + " " + dateTimePicker1.Value.ToLongTimeString(), count = (int)numericUpDown1.Value, item = item, recipient = textBox2.Text };
                db.SubItems.Add(oper);
                db.SaveChanges();
            }
            this.Close();
        }

        private void SubModal_Load(object sender, EventArgs e)
        {
            numericUpDown1.Maximum = numericUpDown0.Value;
        }
    }
}
