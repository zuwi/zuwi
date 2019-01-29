using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WidgetCreator
{
    public partial class CreateSite : Form
    {
        private ZuwiDBEntities _db = new ZuwiDBEntities();


        public CreateSite()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SiteName.Text == "") return;
            Site s = new Site() {Name = SiteName.Text};
            List<Widget> ws = new List<Widget>();
            

            _db.Sites.Add(s);
            _db.SaveChanges();

            int sid = _db.Sites.Where(si => si.Name == SiteName.Text).First().Id;

            foreach (string w in Widgets.CheckedItems)
            {
                Widget widget = _db.Widgets.Where(a => a.PartialName == w).First();
                _db.Database.ExecuteSqlCommand($"insert into SiteWidget(Sites_Id, Widgets_Id) values ({sid}, {widget.Id})");
                foreach (DataGridViewRow row in DataView.Rows)
                {
                    if (Convert.ToInt32(row.Cells[0].Value) == widget.Id)
                    {
                        _db.Database.ExecuteSqlCommand($"insert into WidgetData(Sites_Id, Widgets_Id, [Key], [Value]) values ({sid}, {widget.Id}, '{row.Cells[1].Value.ToString()}', '{row.Cells[2].Value.ToString()}')");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataView.Rows.Clear();
            foreach (string w in Widgets.CheckedItems)
            {
                foreach (RequiredWidgetKey rwk in _db.Widgets.Where(a => a.PartialName == w).First().RequiredWidgetKeys)
                {
                    DataView.Rows.Add(rwk.Widgets_Id, rwk.Key, "");
                }
            }
            
        }

        private void CreateSite_Load(object sender, EventArgs e)
        {
            DataView.Columns.Add("Widget Id", "Widget Id");
            DataView.Columns.Add("Key", "Key");
            DataView.Columns.Add("Value", "Value");
            DataView.Columns[0].ReadOnly = true;
            DataView.Columns[1].ReadOnly = true;

            foreach (Widget widget in _db.Widgets)
            {
                Widgets.Items.Add(widget.PartialName);
            }
        }
    }
}
