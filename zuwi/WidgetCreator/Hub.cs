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
    public partial class Hub : Form
    {
        public Hub()
        {
            InitializeComponent();
        }

        private void Hub_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "zuwiDBWidgetsDataSet.Widgets". Sie können sie bei Bedarf verschieben oder entfernen.
            this.widgetsTableAdapter.Fill(this.zuwiDBWidgetsDataSet.Widgets);
            // TODO: Diese Codezeile lädt Daten in die Tabelle "zuwiDBSitesDataSet.Sites". Sie können sie bei Bedarf verschieben oder entfernen.
            this.sitesTableAdapter.Fill(this.zuwiDBSitesDataSet.Sites);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new CreateSite().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new CreateWidget().ShowDialog();
        }
    }
}
