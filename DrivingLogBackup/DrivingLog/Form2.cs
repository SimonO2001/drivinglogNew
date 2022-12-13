using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrivingLog
{
    public partial class Form2 : Form
    {
        SqlConnection sqlConn = new SqlConnection();
        SqlCommand sqlCmd = new SqlCommand();
        DataTable sqlDT = new DataTable();
        String sqlQuerry;
        SqlDataAdapter DtA = new SqlDataAdapter();

        DataSet DS = new DataSet();

        

        string sqlConnS = ("Server=tcp:simon140401.database.windows.net,1433;Initial Catalog=DrivingLogDB;Persist Security Info=False;User ID=AdminSimon;Password=Passw0rd;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        public Form2()
        {
            InitializeComponent();
        }

        private void uploadData()
        {
            
                    


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                foreach(Control c in panel1.Controls)
                {
                    if (c is TextBox)
                    {
                        ((TextBox)c).Clear();
                    }
                    
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
