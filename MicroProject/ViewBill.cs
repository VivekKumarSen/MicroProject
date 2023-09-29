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
    public partial class ViewBill : Form
    {
        String SqlCon = "Server=DESKTOP-VOSACND;User Id=sa;Password=vivekkumarsain;DataBase=MicroProject";
        SqlConnection Con;
        SqlCommand Cmd;
        SqlDataAdapter DA;
        DataSet DS;
        SqlDataReader DR1;
        SqlCommandBuilder CB;
        
        public ViewBill()
        {
            InitializeComponent();
        }

        private void ViewBill_Load(object sender, EventArgs e)
        {
            Con = new SqlConnection(SqlCon);
            Cmd = new SqlCommand("select BillNumber from BillMaster", Con);
            Cmd.CommandType = CommandType.Text;
            Con.Open();
            DR1 = Cmd.ExecuteReader();
            while (DR1.Read())
            {
                cmbSelectBillNo.Items.Add(DR1[0]);
            }
            Con.Close();
        }

        private void cmbSelectBillNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cmd = new SqlCommand("Select * From BillMaster Where BillNumber=@PBillNumber;Select * From BillTrans Where BillNumber=@PBillNumber", Con);
            Cmd.CommandType = CommandType.Text;
            Cmd.Parameters.AddWithValue("@PBillNumber", cmbSelectBillNo.SelectedItem);
            Con.Open();
            DA = new SqlDataAdapter(Cmd);
            DS = new DataSet();
            DA.Fill(DS, "BillMaster");
            DA.Fill(DS, "BillTrans");
            dataGridView1.DataSource = DS.Tables[0];
            dataGridView2.DataSource = DS.Tables[1];
            Con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
