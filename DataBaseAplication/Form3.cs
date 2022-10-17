using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseAplication
{
    public partial class Form3 : Form
    {
        public string Connect { get; set; }
        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }


        public void AddCustomer() 
        {
            using (SqlConnection conn = new SqlConnection(Connect))
            {
                conn.Open();
                string customer = " '" + IDCustomer.Text + "', " + " '" + SurnameCustomer.Text + " ', " + " '" + NameCustomer.Text + " ', " + " '" + CityCustomer.Text + " ' ";
                SqlCommand query = new SqlCommand("INSERT INTO Odbiorcy (ID_odbiorcy, Nazwisko, Imie, Miasto) VALUES(" + customer + "); ",conn);
                if (query.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Successful operation!");
                    conn.Close();
                    this.Hide();
                    this.Close();
                    
                }
                else 
                {
                    MessageBox.Show("Error");
                }
                


            }
        }
        

        private void IDCustomer_TextChanged(object sender, EventArgs e)
        {

        }

        private void SurnameCustomer_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameCustomer_TextChanged(object sender, EventArgs e)
        {

        }

        private void CityCustomer_TextChanged(object sender, EventArgs e)
        {

        }

        private void addCustomerBtn_Click(object sender, EventArgs e)
        {
            AddCustomer();
            
        }
    }
}
