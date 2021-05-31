using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyConnector
{
    public partial class Mijozlar : Form
    {
        public Mijozlar()
        {
            InitializeComponent();
            ismi.Text = "Diyorbek (710-19 AXF student)";
            familyasi.Text = "Ravshanov";
            eslatma.Text = "Ushbu avtomobil 01.01.2020 sanada chiqqan. Narxi = 35 000$. " +
                "Rangi =qora. Xarid uchun yaroqli!";
        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ismi_TextChanged(object sender, EventArgs e)
        {

        }

        private void familyasi_TextChanged(object sender, EventArgs e)
        {

        }
        private void ismi_Enter(object sender, EventArgs e)
        {
            if (ismi.Text == "Diyorbek (710-19 AXF student)")
                ismi.Text = "";
        }

        private void familyasi_Enter(object sender, EventArgs e)
        {
            if (familyasi.Text == "Ravshanov")
                familyasi.Text = "";
        }

        private void ismi_Leave(object sender, EventArgs e)
        {
            if (ismi.Text == "")
                ismi.Text = "Diyorbek (710-19 AXF student)";
        }

        private void familyasi_Leave(object sender, EventArgs e)
        {
            if (familyasi.Text == "")
                familyasi.Text = "Ravshanov";
        }

        private void eslatma_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Mijozlar_Load(object sender, EventArgs e)
        {

        }

        private void equinox_Click(object sender, EventArgs e)
        {
            searchCar4 equinox = new searchCar4();
            equinox.Show();
        }
    }
}
