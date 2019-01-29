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
    public partial class CreateWidget : Form
    {
        private ZuwiDBEntities _db = new ZuwiDBEntities();

        public CreateWidget()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PartialName.Text == "") return;

            Widget w = new Widget();
            w.PartialName = PartialName.Text;

            foreach (DataGridViewRow row in Keys.Rows)
            {
                DataGridViewCell cell = row.Cells[0];
                if (cell.Value != null)
                {
                    w.RequiredWidgetKeys.Add(new RequiredWidgetKey() {Key = cell.Value.ToString() });
                }
            }

            _db.Widgets.Add(w);
            _db.SaveChanges();

            PartialName.Text = "";
            Keys.Rows.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "zuwiDBDataSet.WidgetData". Sie können sie bei Bedarf verschieben oder entfernen.

        }
    }
}
