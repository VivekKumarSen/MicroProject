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
    public partial class EditItem : Form
    {

        String SqlCon = "Server=DESKTOP-VOSACND;User Id=sa;Password=vivekkumarsain;DataBase=MicroProject";
        SqlConnection Con;
        SqlDataAdapter DA;
        DataSet DS;
        DataRow DR;
        SqlCommandBuilder CB;

        public EditItem()
        {
            InitializeComponent();
        }

        private void EditItem_Load(object sender, EventArgs e)
        {
            Con = new SqlConnection(SqlCon);
            Con.Open();
            DA = new SqlDataAdapter("Select*From Items", Con);
            DS = new DataSet();
            DA.Fill(DS, "vivek");
            DA.FillSchema(DS, SchemaType.Source, "vivek");
            CB = new SqlCommandBuilder(DA);
            GVEditItem.DataSource = DS.Tables[0];
            Con.Close();


        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtItem.Text.Length <= 0 || txtPrice.Text.Length <= 0)
            {
                txtItem.Focus();
                MessageBox.Show("Select Your item/Price");
                return;
            }
            else if (!DS.Tables[0].Rows.Contains(txtItem.Text))
            {
                DR = DS.Tables[0].NewRow();
                DR[0] = txtItem.Text;
                DR[1] = txtPrice.Text;
                DS.Tables[0].Rows.Add(DR);

                MessageBox.Show("Record Add Successfully");
            }
            else
                MessageBox.Show("No Modification in Tables");

            foreach (Control C in this.Controls)
            {
                if (C is TextBox)
                {
                    C.Text = "";
                }
            }
        }


        private void GVEditItem_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtItem.Text = GVEditItem.SelectedCells[0].ToString();
            txtPrice.Text = GVEditItem.SelectedCells[1].ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (DS.HasChanges())
            {
                int Rows = DA.Update(DS.Tables[0]);
                MessageBox.Show(Rows + "Record's Updated Successfully");
            }
            else
            {
                MessageBox.Show("Not Modification in Item Table  Data Base ");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            foreach (Control C in this.Controls)
            {
                if (C is TextBox)
                {
                    C.Text = "";
                }
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
