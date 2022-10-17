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
    public partial class Form4 : Form
    {
        public string Connect { get; set; }

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        public void AddCargo()
        {
            using (SqlConnection conn = new SqlConnection(Connect))
            {
                conn.Open();
                string cargo = " ' " + cargoName.Text + " ', " + " ' " + cargoDescription.Text +  " ' " ;
                SqlCommand query = new SqlCommand("INSERT INTO Oferta (Nazwa_towaru, Opis) VALUES(" + cargo + "); ", conn);
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

        private void button1_Click(object sender, EventArgs e)
        {
            AddCargo();
        }

        private void cargoID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
