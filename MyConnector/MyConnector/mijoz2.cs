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
    public partial class mijoz2 : Form
    {
        public mijoz2()
        {
            InitializeComponent();
            ismi.Text = "Farrux (830-19 MTF student)";
            familyasi.Text = "Xolmatov";
            eslatma.Text = "Ushbu avtomobil 01.01.2020 sanada chiqqan. Narxi = 80 000$. " +
                "Rangi = oq. Xarid uchun yaroqli!";
        }

        private void mijoz2_Load(object sender, EventArgs e)
        {

        }


        private void tahoe2_Click_1(object sender, EventArgs e)
        {
            searchCar3 tahoe2 = new searchCar3();
            tahoe2.Show();
        }
    }
}
