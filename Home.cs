using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLB
{
    public partial class Home : Form
    {
        vitamin vitamin = new vitamin();
        obat obat = new obat();
        suplemen suplemen = new suplemen();

        public Home()
        {
            InitializeComponent();
        }

        private void homeClick(object sender, EventArgs e)
        {
            panelVitamin.Show();
            panelObat.Show();
            panelSuplemen.Show();

            this.Controls.Remove(vitamin);
            this.Controls.Remove(obat);
            this.Controls.Remove(suplemen);

        }

        private void vitaminClick(object sender, EventArgs e)
        {
            this.Controls.Add(vitamin);

            panelVitamin.Hide();
            panelObat.Hide();
            panelSuplemen.Hide();
        }

        private void obatClick(object sender, EventArgs e)
        {
            this.Controls.Add(obat);

            panelVitamin.Hide();
            panelObat.Hide();
            panelSuplemen.Hide();
        }

        private void suplemenClick(object sender, EventArgs e)
        {
            this.Controls.Add(suplemen);

            panelVitamin.Hide();
            panelObat.Hide();
            panelSuplemen.Hide();
        }
    }
}

