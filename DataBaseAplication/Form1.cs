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
    public partial class Form1 : Form
    {
        public static Form1 Form1Instance;


        public Form1()
        {
            Form1Instance = this;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.WindowFrame;
        }

        private void login_button_Click(object sender, EventArgs e)
        {


            login();
        }
    
        
        public void login() 
        {
            string connetionString = null;
            SqlConnection conn;
            connetionString = "Data Source=" + server_name.Text + ";Initial Catalog=" + database_name.Text + ";User ID=" + user.Text + ";Password=" + password.Text;
            conn = new SqlConnection(connetionString);
                


            //string connetionString = null;
            //SqlConnection cnn;
            //connetionString = "Data Source=ServerName;Initial Catalog=DatabaseName;User ID=UserName;Password=Password"
            //cnn = new SqlConnection(connetionString);

            try 
            {
                conn.Open();
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Can not open connection ! ");
            }
            
            Form2 f2 = new Form2();
            f2.Connect = connetionString;            
            f2.ServerName = server_name.Text;
            f2.UserName = user.Text;
            this.Hide();
            f2.ShowDialog();
            this.Close();



        }



        private void server_name_TextChanged(object sender, EventArgs e)
        {

        }

        public void user_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void database_name_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
