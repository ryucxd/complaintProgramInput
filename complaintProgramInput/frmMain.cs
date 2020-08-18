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


namespace complaintProgramInput
{
    public partial class frmMain : Form
    {
        public int login_id { get; set; }
        public frmMain(int id)
        {
            InitializeComponent();
            login_id = id;
            // fill the combobox here
            cmbCustSupplier.Items.Add("Customer");
            cmbCustSupplier.Items.Add("Supplier");
            cmbCustSupplier.Enabled = false;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
                Environment.Exit(1);
        }

        private void chkTraditonal_CheckedChanged(object sender, EventArgs e)
        {
            chkSlimline.Checked = !chkTraditonal.Checked;
            cmbCustSupplier.Enabled = true;
            txtDoorNum.Enabled = true;
            txtAttention.Text = "Geraint/Damian";
        }

        private void chkSlimline_CheckedChanged(object sender, EventArgs e)
        {
            chkTraditonal.Checked = !chkSlimline.Checked;
            cmbCustSupplier.Enabled = true;
            txtAttention.Text = "Scott Davies";
            txtDoorNum.Enabled = true;
        }

        private void cmbCustSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            //when this is changed populate the acc ref below
            if (cmbCustSupplier.Text == "Customer")
            {
                grpCustSupplier.Text = "Customer";
                unhide();
                //make everything customer related
                lblAccRef.Text = "Customer";
                lblContact.Text = "Customer Contact";
                lblTel.Text = "Customer Tel";
                fillCombo();
            }
            else if (cmbCustSupplier.Text == "Supplier")
            {
                grpCustSupplier.Text = "Supplier";
                unhide();
                //make everything supplier related
                lblAccRef.Text = "Supplier";
                lblContact.Text = "Supplier Contact";
                lblTel.Text = "Supplier Tel";
                fillCombo();
            }

        }


        private void fillCombo()
        {
            //start connection 
            using (SqlConnection conn = new SqlConnection(CONNECT.ConnectionString))
            {
                //here we are going to fire the sql to populate the combobox
                string sql = "";
                if (cmbCustSupplier.Text == "Customer")
                {
                    cmbAccRef.Items.Clear();
                    sql = "SELECT [NAME] FROM dbo.SALES_LEDGER WHERE ACCOUNT_REF is not null";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        conn.Open();
                        using (SqlDataReader rdr = cmd.ExecuteReader())
                        {
                            while (rdr.Read())
                            {
                                cmbAccRef.Items.Add(rdr[0].ToString());
                            }
                        }

                        conn.Close();
                    }
                }
                else //has to be supplier
                {

                    if (cmbCustSupplier.Text == "Supplier")
                    {
                        cmbAccRef.Items.Clear();
                        sql = "SELECT [NAME] FROM dbo.supplier WHERE ACCOUNT_REF is not null";
                        using (SqlCommand cmd = new SqlCommand(sql, conn))
                        {
                            conn.Open();
                            using (SqlDataReader rdr = cmd.ExecuteReader())
                            {
                                while (rdr.Read())
                                {
                                    cmbAccRef.Items.Add(rdr[0].ToString());
                                }
                            }

                            conn.Close();
                        }
                    }
                }
            }

        }
        private void unhide() //unhiding everything to do with customer/.supplier
        {
            //labels
            lblContact.Visible = true;
            lblTel.Visible = true;
            lblAccRef.Visible = true;
            lblDescription.Visible = true;
            //txtbox
            txtTel.Visible = true;
            txtContact.Visible = true;
            cmbAccRef.Visible = true;
            txtDescription.Visible = true;
            panelCust.Visible = true;
            panelDescription.Visible = true;


        }

        private void cmbCustSupplier_TextChanged(object sender, EventArgs e)
        {
            if (cmbCustSupplier.Text != "Supplier" || cmbCustSupplier.Text != "Customer") //if we are here then they deleted cust/supplier and now we gotta lock everything down until one is selected again
            {
                lblContact.Visible = false;
                lblTel.Visible = false;
                lblAccRef.Visible = false;
                //txtbox
                txtTel.Visible = false;
                txtContact.Visible = false;
                cmbAccRef.Visible = false;
                panelCust.Visible = false;

            }
        }

        private void txtDoorNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void frmMain_Paint(object sender, PaintEventArgs e)
        {
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // need some validation here to make sure that the data that is 100% needed has been entered
            //chkboxes
            if (chkTraditonal.Checked == false && chkSlimline.Checked == false)
            {
                MessageBox.Show("Please select either Traditional or Slimline");
                return;
            }
            //custaccref
            if (String.IsNullOrEmpty(cmbAccRef.Text))
            {
                MessageBox.Show("Please select a Customer/Supplier");
                return;
            }
            //description
            if (string.IsNullOrEmpty(txtDescription.Text))
            {
                MessageBox.Show("Please enter a brief description of the complaint");
                return;
            }
           DialogResult result =  MessageBox.Show("Are you sure you want to create this complaint?", "Create Complaint!",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                //call the procedure here and gogo
                using (SqlConnection conn = new SqlConnection(CONNECT.ConnectionString))
                {
                    //some quick variable swapping before we fire procedure
                    int slimline;
                    if (chkTraditonal.Checked == true)
                        slimline = 0; //not slimline
                    else
                        slimline = -1; //is slimline
                    int supplier;
                    if (cmbCustSupplier.Text == "Supplier")
                        supplier = -1; //is supplier;
                    else
                        supplier = 0;
                            
                    using (SqlCommand cmd = new SqlCommand("usp_complaint_creation_external", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@slimline_y_n", SqlDbType.VarChar).Value = slimline;  //HERE I
                        cmd.Parameters.Add("@supplier", SqlDbType.VarChar).Value = supplier;
                        cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = cmbAccRef.Text;
                        cmd.Parameters.Add("@contact", SqlDbType.VarChar).Value = txtContact.Text;
                        cmd.Parameters.Add("@tel", SqlDbType.VarChar).Value = txtTel.Text;
                        cmd.Parameters.Add("@description", SqlDbType.VarChar).Value = txtDescription.Text;
                        cmd.Parameters.Add("@login_user", SqlDbType.VarChar).Value = login_id;
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        //close it down
                    }
                    //grab the max id fast
                    //we have commited this here now SO we can fire the batchfile to move the attachments (if there are any  wrote all of this down on my paper!
                    //need to wase about 5 minutes now tho hehe xd lego 8D

                }
            }
            //anything else does nothing
        }

        private void exec_batch()
        {
            //fire everything here
        }

    }
}
