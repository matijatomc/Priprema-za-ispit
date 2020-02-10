using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tomcMatijaZadatak4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnZbroj_Click(object sender, EventArgs e)
        {
            try
            {
                double A = Convert.ToDouble(txtA.Text);
                double B = Convert.ToDouble(txtB.Text);
                double rjesenje = A+ B;
                MessageBox.Show("Zbroj je: " + rjesenje);
                txtA.Clear();
                txtB.Clear();
            }
            catch
            {
                MessageBox.Show("Unijeli ste krivu vrijednost");
                txtA.Clear();
                txtB.Clear();
            }
        }

        private void btnUmnozak_Click(object sender, EventArgs e)
        {
            try
            {
                double A = Convert.ToDouble(txtA.Text);
                double B = Convert.ToDouble(txtB.Text);
                double rjesenje = A * B;
                MessageBox.Show("Umnožak je: " + rjesenje);
                txtA.Clear();
                txtB.Clear();
            }
            catch
            {
                MessageBox.Show("Unijeli ste krivu vrijednost");
                txtA.Clear();
                txtB.Clear();
            }
        }

        private void btnRazlika_Click(object sender, EventArgs e)
        {
            try
            {
                double A = Convert.ToDouble(txtA.Text);
                double B = Convert.ToDouble(txtB.Text);
                double rjesenje = A - B;
                MessageBox.Show("Razlika je: " + rjesenje);
                txtA.Clear();
                txtB.Clear();
            }
            catch
            {
                MessageBox.Show("Unijeli ste krivu vrijednost");
                txtA.Clear();
                txtB.Clear();
            }
        }

        private void btnKvocijent_Click(object sender, EventArgs e)
        {
            try
            {
                double A = Convert.ToDouble(txtA.Text);
                double B = Convert.ToDouble(txtB.Text);
                double rjesenje = A / B;
                MessageBox.Show("Kvocijent je: " + rjesenje);
                txtA.Clear();
                txtB.Clear();
            }
            catch
            {
                MessageBox.Show("Unijeli ste krivu vrijednost");
                txtA.Clear();
                txtB.Clear();
            }
        }
    }
}
