using System.Data;

namespace Inv
{
    public partial class SubModal : Form
    {
        public SubModal() => InitializeComponent();
        private void withdrawButton_Click(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                int count = (int)itemCountNumericUpDown.Value;
                Item item = db.Items.Where(x => x.name == itemNameTextBox.Text && x.code == itemCodeTextBox.Text && x.inv == itemInvTextBox.Text).ToArray()[0];
                SubItem oper = new SubItem { date = itemWithdrawDataTimePicker.Value.ToLongDateString() + " " + itemWithdrawDataTimePicker.Value.ToLongTimeString(), count = (int)itemWithdrawCountNumericUpDown.Value, item = item, recipient = itemRecipientTextBox.Text };
                db.SubItems.Add(oper);
                db.SaveChanges();
            }
            this.Close();
        }
        private void SubModal_Load(object sender, EventArgs e)
        {
            itemWithdrawCountNumericUpDown.Maximum = itemCountNumericUpDown.Value;
        }
    }
}
