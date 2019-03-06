using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;




namespace TestGrila
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        public int nrI = 0;
        public int corecte = 0;
        public int nr = 1;
       
        private void incarcaI(int i)
        {
            lblIntrebare.Text = lstIntrebare.Items[i].ToString();
            A.Text = lstA.Items[i].ToString();
            B.Text = lstB.Items[i].ToString();
            C.Text = lstC.Items[i].ToString();
            lblNr.Text = (nrI + 1).ToString();
            A.Checked = false;
            B.Checked = false;
            C.Checked = false;
        }
        private void btnTestNou_Click(object sender, EventArgs e)
        {
            incarcaI(nrI);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnInainte_Click(object sender, EventArgs e)
        {
            nrI++;
            if (nrI + 1 > lstIntrebare.Items.Count)
            {
                nrI--;
                return;
            }
            else
            {
                incarcaI(nrI);
            }
        }

        private void lblIntrebare_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            nr = Convert.ToInt32(numConfirma.Value);
        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            nrI--;
            if (nrI  < 0)
            {
                nrI = 0;
                return;
            }
            else
            {
                incarcaI(nrI);
            }
        }

        private void lblNr_Click(object sender, EventArgs e)
        {
            lblNr.Text = (nrI + 1).ToString();
        }
    }
}
