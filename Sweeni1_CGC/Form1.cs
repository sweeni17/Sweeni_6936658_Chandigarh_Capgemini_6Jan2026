using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace Sweeni1_CGC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCon_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source = DESKTOP-1IH1IR8\\SQLEXPRESS; Initial Catalog = EMPLOYEEDB; TrustServerCertificate = True; Integrated Security = True";

            try
            {
                using var connection = new SqlConnection(connectionString);
                connection.Open();

                MessageBox.Show("Connection Successful!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Failed!" + ex.Message);
            }
        }
    }
}
