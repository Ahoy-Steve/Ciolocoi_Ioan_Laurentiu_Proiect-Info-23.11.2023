using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_Info_23._11._2023
{
    public partial class quiz : Form
    {
        public quiz()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int punctaj = 0;
            if (rb2.Checked) punctaj++;
            if (rb4.Checked) punctaj++;
            if (rb9.Checked) punctaj++;
            if (rb10.Checked) punctaj++;
            if (punctaj == 0) MessageBox.Show("Ai greșit toate întrebările! Mai încearcă!");
            else if (punctaj == 1) MessageBox.Show("Ai obținut un punct.");
            else MessageBox.Show("Ai obținut " + punctaj + " puncte.");
        }
    }
}
