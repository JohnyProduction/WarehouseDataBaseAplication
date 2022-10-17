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
    public partial class Form10 : Form
    {
        public string Connect { get; set; }
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Connect))
            {
                string sqlQuery = null;
                conn.Open();
                sqlQuery = "SELECT * FROM Oferta;";
                SqlDataAdapter dscmd = new SqlDataAdapter(sqlQuery, conn);
                DataTable dtData = new DataTable();
                dscmd.Fill(dtData);
                dataGridView1.DataSource = dtData;
            }
        }
    }
}
