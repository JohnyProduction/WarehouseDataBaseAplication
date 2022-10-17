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
    public partial class Form2 : Form
    {
        public string Connect { get; set; }
        public string ServerName { get; set; }
        public string UserName { get; set; }
        public Form2()
        {
            InitializeComponent();
            


        }

        public void Form2_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Connect))
            {
                conn.Open();
                using (SqlCommand com = new SqlCommand("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES", conn))
                {
                    using (SqlDataReader reader = com.ExecuteReader())
                    {
                        tableName.Items.Clear();
                        while (reader.Read())
                        {
                            tableName.Items.Add((string)reader["TABLE_NAME"]);
                        }
                    }
                }
                conn.Close();
            }
            server.Text = ServerName;
            user.Text = UserName;
           
        }
        private void inquiry_TextChanged(object sender, EventArgs e)
        {

        }

        private void show_btn_Click(object sender, EventArgs e)
        {

            using (SqlConnection conn = new SqlConnection(Connect))
            {
                conn.Open();
                String query = "SELECT * FROM Klienci";
                SqlDataAdapter SDA = new SqlDataAdapter(query,conn);
                DataTable dt = new DataTable();
                SDA.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableName_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void księgowośćToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dodajOdbiorcęToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Connect = Connect;
            f3.ShowDialog();
        }

        private void dodajTowarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Connect = Connect;
            f4.ShowDialog();
        }

        private void kwerendyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dodajSprzedażToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Connect = Connect;
            f5.ShowDialog();
        }

        private void doZapłatyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Connect = Connect;
            f6.ShowDialog();
        }

        private void showTable_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Connect))
            {
                string sqlQuery = null;
                conn.Open();
                sqlQuery = "SELECT * FROM " + tableName.Text + ";";
                SqlDataAdapter dscmd = new SqlDataAdapter(sqlQuery, conn);
                DataTable dtData = new DataTable();
                dscmd.Fill(dtData);
                dataGridView1.DataSource = dtData;
            }
        }

        private void sqlCommand_TextChanged(object sender, EventArgs e)
        {

        }

        private void showSql_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Connect))
            {
                string sqlQuery = null;
                conn.Open();
                sqlQuery = sqlCommand.Text + ";";
                SqlDataAdapter dscmd = new SqlDataAdapter(sqlQuery, conn);
                DataTable dtData = new DataTable();
                dscmd.Fill(dtData);
                dataGridView1.DataSource = dtData;
            }
        }

        private void sprzedażToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Connect = Connect;
            f7.ShowDialog();
        }

        private void pracownicyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Connect = Connect;
            f8.ShowDialog();
        }

        private void stanMagazynuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Connect = Connect;
            f9.ShowDialog();
        }

        private void produktyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            f10.Connect = Connect;
            f10.ShowDialog();
        }

        private void wypłatyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 f11 = new Form11();
            f11.Connect = Connect;
            f11.ShowDialog();
        }
    }
}
