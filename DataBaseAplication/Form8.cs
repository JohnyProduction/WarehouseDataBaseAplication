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
    public partial class Form8 : Form
    {
        public string Connect { get; set; }

        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Connect))
            {
                string sqlQuery = null;
                conn.Open();
                sqlQuery = "SELECT * FROM Pracownicy;";
                SqlDataAdapter dscmd = new SqlDataAdapter(sqlQuery, conn);
                DataTable dtData = new DataTable();
                dscmd.Fill(dtData);
                dataGridView1.DataSource = dtData;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
