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

    public partial class Form5 : Form
    {
        public string Connect { get; set; }

        public Form5()
        {
            InitializeComponent();
        }

        

        
        private void Form5_Load(object sender, EventArgs e)
        {

        }

        public void AddSale()
        {
            using (SqlConnection conn = new SqlConnection(Connect))
            {
                
                conn.Open();
                string sale = " ' " + IDSale.Text + " ', " + " ' " + IDCustomer.Text + " ', " + " ' " + IDCommodity.Text + " ', "  + " ' " + priceBox.Text + " ', " + " ' " + Payment.Text + " ' ";
                SqlCommand query = new SqlCommand("INSERT INTO Sprzedaż (ID_sprzedaży,ID_odbiorcy,ID_towaru,Wartość_sprzedaży,Zapłacono) VALUES(" + sale + "); ", conn);
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

        private void priceBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void IDSale_TextChanged(object sender, EventArgs e)
        {

        }

        private void IDCustomer_TextChanged(object sender, EventArgs e)
        {

        }

        private void Payment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void IDCommodity_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddSale();

        }
    }
}
