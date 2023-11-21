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
    public partial class japonia : Form
    {
        public japonia()
        {
            InitializeComponent();
        }

        private void label_tokyo_Click(object sender, EventArgs e)
        {
            Tokyo t = new Tokyo();
            this.Hide();
            t.ShowDialog();
            t.Dispose();
            this.Show();
        }

        private void japonia_Load(object sender, EventArgs e)
        {

        }

        private void label_sapporo_Click(object sender, EventArgs e)
        {
            
        }

        private void label_sapporo_Click_1(object sender, EventArgs e)
        {
            Sapporo s = new Sapporo();
            this.Hide();
            s.ShowDialog();
            s.Dispose();
            this.Show();
        }

        private void label_yokohama_Click(object sender, EventArgs e)
        {
            Yokohama y = new Yokohama();
            this.Hide();
            y.ShowDialog();
            y.Dispose();
            this.Show();
        }

        private void label_kyoto_Click(object sender, EventArgs e)
        {
            Kyoto ky = new Kyoto();
            this.Hide();
            ky.ShowDialog();
            ky.Dispose();
            this.Show();
        }

        private void label_kobe_Click(object sender, EventArgs e)
        {
            Kobe ko = new Kobe();
            this.Hide();
            ko.ShowDialog();
            ko.Dispose();
            this.Show();
        }

        private void label_osaka_Click(object sender, EventArgs e)
        {
            Osaka o = new Osaka();
            this.Hide();
            o.ShowDialog();
            o.Dispose();
            this.Show();
        }

        private void label_hiroshima_Click(object sender, EventArgs e)
        {
            Hiroshima h = new Hiroshima();
            this.Hide();
            h.ShowDialog();
            h.Dispose();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            quiz q = new quiz();
            this.Hide();
            q.ShowDialog();
            q.Dispose();
            this.Show();
        }
    }
}
