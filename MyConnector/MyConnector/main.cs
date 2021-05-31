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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            ismi.Text = "Ismingizni kiritng";
            familyasi.Text = "Familyangizni kiritng";
        }
        private void Enter_Click(object sender, EventArgs e)
        {
            Avtomobillar cars = new Avtomobillar();
            cars.Show();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void kirish_Click(object sender, EventArgs e)
        {
            String Ismi = ismi.Text;
            String Familyasi = familyasi.Text;
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `mijozlar` WHERE `ismi` = @name and `familyasi` = @surname", db.getConnection());
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = Ismi;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = Familyasi;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0) 
            { 
                Mijozlar mijoz1 = new Mijozlar();
                mijoz1.Show();
            }

        }

        private void familyasi_TextChanged(object sender, EventArgs e)
        {

        }

        private void ismi_TextChanged(object sender, EventArgs e)
        {

        }
        private void ismi_Enter(object sender, EventArgs e)
        {
            if(ismi.Text == "Ismingizni kiritng")
                ismi.Text = "";
        }

        private void familyasi_Enter(object sender, EventArgs e)
        {
            if(familyasi.Text == "Familyangizni kiritng")
                familyasi.Text = "";
        }

        private void ismi_Leave(object sender, EventArgs e)
        {
            if (ismi.Text == "")
                ismi.Text = "Ismingizni kiritng";
        }

        private void familyasi_Leave(object sender, EventArgs e)
        {
            if (familyasi.Text == "")
                familyasi.Text = "Familyangizni kiritng";
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void kirish_Click_1(object sender, EventArgs e)
        {
            if(familyasi.Text == "Ravshanov" && ismi.Text == "Diyorbek")
            {
                Mijozlar mijozlar = new Mijozlar();
                mijozlar.Show();
            }
          
            if (familyasi.Text == "Xolmatov" && ismi.Text == "Farrux")
            {
                mijoz2 mijozlar = new mijoz2();
                mijozlar.Show();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
