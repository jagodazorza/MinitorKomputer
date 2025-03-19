using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace MinitorKomputer
{
    public partial class Form2 : Form
    {
        public Form1 parent;
        public int procesor = 0;
        public int dysk = 0;
        public int reszta = 1000;
        public string rodzajProc = "";

        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Form1 form1)
        {
            parent = form1;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parent.cenaK = procesor + dysk + reszta;
            this.Close();
            parent.oblicz();
        }

        private void cenaProcesora_TextChanged(object sender, EventArgs e)
        {
            procesor = Int32.Parse(cenaProcesora.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                cenaDysku.Text = "500";
                dysk = 500;
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                cenaDysku.Text = "600";
                dysk = 600;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                dysk = 800;
                cenaDysku.Text = "800";

            }

        }

        private void cenaDysku_TextChanged(object sender, EventArgs e)
        {
            dysk = Int32.Parse(cenaDysku.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            rodzajProc = comboBox1.Text;
            if (rodzajProc == "Procesor tani")
            {
                cenaProcesora.Text = "50";
                procesor = 50;
            }

            else if (rodzajProc == "Procesor średni")
            {
                cenaProcesora.Text = "300";
                procesor = 300;
            }

            else if (rodzajProc == "Procesor drogi")
            {
                cenaProcesora.Text = "800";
                procesor = 800;
            }

            else if (rodzajProc == "Procesor ultra ultra drogi")
            {
                cenaProcesora.Text = "2137420";
                procesor = 2137420;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                cenaDysku.Text = "600";
                dysk = 600;
            }
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                cenaDysku.Text = "900";
                dysk = 900;
            }
        }
    }
}
