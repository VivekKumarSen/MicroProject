using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MicroProject
{
    public partial class BillMaster : Form
    {
        String SqlCon = "Server=DESKTOP-VOSACND;User Id=sa;Password=vivekkumarsain;DataBase=MicroProject";
        SqlConnection Con;
        SqlDataAdapter DA;
        DataSet DS;
        DataRow DR;
        SqlDataReader DR1;
        SqlCommandBuilder CB;
        SqlCommand Cmd;
        SqlParameter P1;

        public BillMaster()
        {
            InitializeComponent();
            

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
           
                if (txtBillNo.Text.Length > 0)
                {
                    GlobalData.BillNo = txtBillNo.Text;
                    BillTrans BT = new BillTrans();
                    BT.ShowDialog();
                txtBillAmut.Text = GlobalData.TotPrice;
                if (txtBillAmut.Text.Length > 0)
                    txtBillAmut.Text = GlobalData.TotPrice.ToString();
                else MessageBox.Show("Items Not Selected");
                }
            
            else
            {
                MessageBox.Show("Plz...!\nEnter Bill Number ");
            }

        }

        private void txtBillDate_TextChanged(object sender, EventArgs e)
        {

            txtBillDate.Text = System.DateTime.Now.ToString();
           
        }

        private void txtTotBill_TextChanged(object sender, EventArgs e)
        {
               
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Con = new SqlConnection(SqlCon);
            Con.Open();
            Cmd= new SqlCommand("Insert Into BillMaster Values(@P1BillNumber,@P2BillDate,@P3BillAmount,@P4StateTax,@P5CentralTax,@P6Discount,@P7TotalBill,@P8UserName)", Con);
            Cmd.CommandType = CommandType.Text;
            Cmd.Parameters.AddWithValue("@P1BillNumber", txtBillNo.Text);
            Cmd.Parameters.AddWithValue("@P2BillDate", txtBillDate.Text);
            Cmd.Parameters.AddWithValue("@P3BillAmount", txtBillAmut.Text);
            Cmd.Parameters.AddWithValue("@P4StateTax", txtStateTax.Text);
            Cmd.Parameters.AddWithValue("@P5CentralTax", txtCentralTax.Text);
            Cmd.Parameters.AddWithValue("@P6Discount", txtDiscount.Text);
            Cmd.Parameters.AddWithValue("@P7TotalBill", txtTotBill.Text);
            Cmd.Parameters.AddWithValue("@P8UserName", GlobalData.UserName);
            int Row= Cmd.ExecuteNonQuery(); 
            Cmd = new SqlCommand("Insert Into BillTrans Values(@P1BillNumber,@P2ItemName,@P3Price,@P4,@P5CentralTax,@P6Discount,@P7TotalBill,@P8UserName)", Con);
            Cmd.CommandType = CommandType.Text;
            Con.Close();

            if (GlobalData.DS.HasChanges())
            {
                int Rows = GlobalData.DA.Update(GlobalData.DS.Tables[0]);
                MessageBox.Show(Rows + "Record's Updated Successfully");
            }
            else
            {
                MessageBox.Show("Not Modification in Item Table  Data Base ");
            }         

        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control C in this.Controls)
            {
                if (C is TextBox)
                {
                    C.Text = "";
                }
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            Double TotAmount, SGST, CGST, Discount, TotBill;
            if (txtBillAmut.Text.Length > 0)
            {
                txtBillAmut.Text = GlobalData.TotPrice;
                TotAmount = Convert.ToDouble(txtBillAmut.Text);
                CGST = TotAmount * (Convert.ToDouble(txtCentralTax.Text) / 100);
                SGST = TotAmount * (Convert.ToDouble(txtStateTax.Text) / 100);
                Discount = TotAmount  * (Convert.ToDouble(txtDiscount.Text) / 100);
                TotBill = TotAmount + CGST + SGST - Discount;
                txtTotBill.Text = TotBill.ToString();

            }
            else txtTotBill.Clear();
        }

        private void BillMaster_Load(object sender, EventArgs e)
        {
            Con = new SqlConnection(SqlCon);
            Con.Open();
            String Query = "Select * From Tax";
            Cmd=new SqlCommand(Query, Con);
            Cmd.CommandType= CommandType.Text;
            
            DR1 = Cmd.ExecuteReader();
            while (DR1.Read())
            {
                txtStateTax.Text = DR1[0].ToString();
                txtCentralTax.Text = DR1[1].ToString();
            }
            Con.Close();
            txtBillDate.Text = DateTime.Now.ToString();
        }

        private void txtBillNo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
