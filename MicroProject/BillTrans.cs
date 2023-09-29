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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace MicroProject
{
    public partial class BillTrans : Form
    {
        String SqlCon = "Server=DESKTOP-VOSACND;User Id=sa;Password=vivekkumarsain;DataBase=MicroProject";

        SqlConnection Con;
        SqlDataReader DR;
        SqlCommand Cmd;
        SqlDataAdapter DA;
        DataSet DS;
        SqlCommandBuilder CB;
        DataRow Dr;
        bool Avail = false;
        
        Double P;

        public BillTrans()
        {
            InitializeComponent();
        }

        private void BillTrans_Load(object sender, EventArgs e)
        {
            Con = new SqlConnection(SqlCon);
            Con.Open();
            GlobalData.DA = new SqlDataAdapter("Select * from BillTrans where BillNumber='"+GlobalData.BillNo+"'", Con);
            GlobalData.DS = new DataSet();
            GlobalData.DA.Fill(GlobalData.DS, "vivek");
            GlobalData.DA.FillSchema(GlobalData.DS, SchemaType.Source, "vivek");
            GlobalData.CB = new SqlCommandBuilder(GlobalData.DA);
            GVShowData.DataSource = GlobalData.DS.Tables[0];
            
            Cmd = new SqlCommand("Select Items from Items", Con);
            Cmd.CommandType = CommandType.Text;
            GlobalData.DR = Cmd.ExecuteReader();
            while(GlobalData.DR.Read())
            {
                cmbSelectItem.Items.Add(GlobalData.DR[0].ToString());
            }
            Con.Close();
        }

        private void cmbSelectItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
                string selectedItem = cmbSelectItem.SelectedItem.ToString();
                string Query = "SELECT * FROM Items WHERE Items = '" + selectedItem + "';";
                Con = new SqlConnection(SqlCon);
                Con.Open();
                //String Query = "Select * from Items Where Items='"+cmbSelectItem.Select.Items+"';";
                Cmd = new SqlCommand(Query, Con);
                Cmd.Parameters.AddWithValue("@SelectedItem", selectedItem);

                DR = Cmd.ExecuteReader();

                if (DR.Read())
                {
                    txtPrice.Text = DR[1].ToString();
                }
                else
                {
                    MessageBox.Show("Items Not  found");
                }
            Con.Close();
            
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
           
            if (txtQuantity.Text.Length > 0)
            {
                P = Convert.ToDouble(txtPrice.Text)*Convert.ToDouble(txtQuantity.Text);
                txtTotPrice.Text = P.ToString();
            }
            else
            {
                txtTotPrice.Clear();
            }
        }

        private void txtTotPrice_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (cmbSelectItem.Text.Length <= 0)
            {
                cmbSelectItem.Focus();
                MessageBox.Show("Enter Your item/Price");
                return;
            }
            if (cmbSelectItem.Text.Length <= 0 || txtPrice.Text.Length <= 0 || txtQuantity.Text.Length <= 0 || txtTotPrice.Text.Length <= 0)
            {
                for (int i = 0; i < GVShowData.Rows.Count; i++)
                {
                    GVShowData.Rows[i].Cells[3].Value = txtQuantity.Text;
                    GVShowData.Rows[i].Cells[4].Value = txtTotPrice.Text;
                    Avail = true;
                }
            }
            if(Avail==false)
            {

                GlobalData.Dr = GlobalData.DS.Tables[0].NewRow();
                GlobalData.Dr[0] = GlobalData.BillNo;
                GlobalData.Dr[1] = cmbSelectItem.SelectedItem;
                GlobalData.Dr[2] = txtPrice.Text;
                GlobalData.Dr[3] = txtQuantity.Text;
                GlobalData.Dr[4] = txtTotPrice.Text;
                GlobalData.DS.Tables[0].Rows.Add(GlobalData.Dr);
            }
            else
            {
                MessageBox.Show("Plz....!\nEnter Quantity");
            }
           
            foreach (Control C in this.Controls)
            {
                if (C is TextBox)
                {
                    C.Text = "";
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            double sum=0;
            for(int i = 0; i<GVShowData.Rows.Count;i++)
            {
               sum+=Convert.ToDouble(GVShowData.Rows[i].Cells[4].Value);
            }
            GlobalData.TotPrice = sum.ToString();
            this.Close();
        }
    }
}
