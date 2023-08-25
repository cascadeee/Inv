using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inv
{
    public class Item
    {
        public int id { get; set; }
        public string name { get; set; }
        public string code { get; set; }
        public string inv { get; set; }
    }
    public class AddItem
    {
        public int id { get; set; }
        public int itemId { get; set; }
        [ForeignKey("itemId")]
        public Item item { get; set; }
        public string date { get; set; }
        public int count { get; set; }
    }
    public class SubItem
    {
        public int id { get; set; }
        public int itemId { get; set; }
        [ForeignKey("itemId")]
        public Item item { get; set; }
        public string date { get; set; }
        public int count { get; set; }
        public string recipient { get; set; }
    }

}
