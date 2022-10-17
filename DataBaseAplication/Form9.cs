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
    public partial class Form9 : Form
    {
        public string Connect { get; set; }

        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Connect))
            {
                string sqlQuery = null;
                conn.Open();
                sqlQuery = "SELECT z.Ilosc_towaru, o.Nazwa_towaru FROM Oferta as o INNER JOIN Ilość_zapasów as z ON o.ID_towaru=z.ID_towaru;";
                SqlDataAdapter dscmd = new SqlDataAdapter(sqlQuery, conn);
                DataTable dtData = new DataTable();
                dscmd.Fill(dtData);
                dataGridView1.DataSource = dtData;
            }
        }

        
    }
}
