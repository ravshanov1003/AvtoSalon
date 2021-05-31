using MySql.Data.MySqlClient;
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
    public partial class Avtomobillar : Form
    {
        public Avtomobillar()
        {
            InitializeComponent();
            newCars.Text = "Equinox, Tahoe, Malibu2, Traiblazer";
        }

        private void Avtomobillar_Load(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            if (avtoName.Text == "gentra" && avtoColor.Text == "qora")
            {
                searchCar gentra = new searchCar();
                gentra.Show();
            }

            if (avtoName.Text == "captiva" && avtoColor.Text == "qora")
            {
                searchCar2cs captiva = new searchCar2cs();
                captiva.Show();
            }
            if (avtoName.Text == "tahoe" && avtoColor.Text == "oq")
            {
                searchCar3 tahoe2 = new searchCar3();
                tahoe2.Show();
            }
            if (avtoName.Text == "equinox" && avtoColor.Text == "qora")
            {
                searchCar4 equinox = new searchCar4();
                equinox.Show();
            }

        }

        private void newCars_Enter(object sender, EventArgs e)
        {
            if (newCars.Text == "Equinox, Tahoe, Malibu2, Traiblazer")
                newCars.Text = "";
        }

        private void newCars_Leave(object sender, EventArgs e)
        {
            if (newCars.Text == "")
                newCars.Text = "Equinox, Tahoe, Malibu2, Traiblazer";
        }

        private void newcarSearch_Click(object sender, EventArgs e)
        {
            if (newCars.Text == "Equinox" || newCars.Text == "Tahoe" || newCars.Text == "Malibu2"
                || newCars.Text == "Traiblazer")
            {
                newCars yangi = new newCars();
                yangi.Show();
            }
            else MessageBox.Show("Kiritilgan avtomobil nomi 01.01.2020 yilda chiqmagan");
        }

        private void tahoe_Click(object sender, EventArgs e)
        {
            searchCar3 tahoe2 = new searchCar3();
            tahoe2.Show();
        }
    }
}
