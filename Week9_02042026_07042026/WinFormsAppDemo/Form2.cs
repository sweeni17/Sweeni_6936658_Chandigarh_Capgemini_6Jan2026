using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WinFormsAppDemo
{
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection("Server=DESKTOP-1IH1IR8\\SQLEXPRESS;" + "Database=WindowDB;" + "Integrated Security=True;" + "TrustServerCertificate=True;");
        SqlCommandBuilder Bldr; SqlDataAdapter da; DataRow rec;
        DataSet ds;
        public Form2()
        {
            InitializeComponent();
        }



        private void Form2_Load(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("Select *  from Employeetb", con);
            ds = new DataSet();
            da.Fill(ds, "Employeetb");
            dataGridView1.DataSource = ds.Tables[0];
            da.FillSchema(ds, SchemaType.Source, "Employeetb");
            Bldr = new SqlCommandBuilder(da);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                rec = ds.Tables[0].NewRow();
                rec[0] = txtEmpId.Text;
                rec[1] = txtEmpName.Text;
                rec[2] = txtDesig.Text;
                rec[3] = txtDOJ.Text;
                rec[4] = txtEmpSal.Text;
                rec[5] = txtDeptNo.Text;
                ds.Tables[0].Rows.Add(rec);
                MessageBox.Show("Record is Inserted into dataset Table");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                rec = ds.Tables[0].Select("EmpId=" + txtEmpId.Text)[0];
                txtEmpName.Text = rec[1].ToString();
                txtDesig.Text = rec[2].ToString();
                txtDOJ.Text = rec[3].ToString();
                txtEmpSal.Text = rec[4].ToString();
                txtDeptNo.Text = rec[5].ToString();
                btnUpdate.Enabled = true;
                MessageBox.Show("record find");
            }
            catch
            {
                MessageBox.Show("record Not Found");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if (x is TextBox)
                    x.Text = "";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                rec[1] = txtEmpName.Text;
                rec[2] = txtDesig.Text;
                rec[3] = DateTime.Parse(txtDOJ.Text);
                rec[4] = int.Parse(txtEmpSal.Text);
                rec[5] = txtDeptNo.Text;
                btnUpdate.Enabled = false;
                MessageBox.Show("record is updated into dataset Table");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                rec = ds.Tables[0].Select("EmpId" + txtEmpId.Text)[0];
                rec.Delete();
                MessageBox.Show("Record is deleted from dataset Table");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUdateDB_Click(object sender, EventArgs e)
        {
            try
            {
                if (ds.HasChanges() == true)
                {
                    da.Update(ds, "Employeetb");
                    MessageBox.Show("Dataset data is Upadated into database");
                }
                else
                {
                    MessageBox.Show("No modifiaction in Dataset");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // You can leave this empty if you don't need it
        }
    }
}
