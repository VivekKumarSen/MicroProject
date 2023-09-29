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
using System.Runtime.InteropServices.ComTypes;

namespace MicroProject
{
    public partial class DeleteItems : Form
    {

        String SqlCon = "Server=DESKTOP-VOSACND;User Id=sa;Password=vivekkumarsain;DataBase=MicroProject";
        SqlConnection Con;
        SqlCommand Cmd;
        SqlDataAdapter DA;
        DataSet DS;
        DataGridViewRow DV;
        DataRow DR;
        SqlCommandBuilder CB;
        String Query;

        public DeleteItems()
        {
            InitializeComponent();
        }

        private void DeleteItems_Load(object sender, EventArgs e)
        {
            Con = new SqlConnection(SqlCon);
            Con.Open();
            DA = new SqlDataAdapter("Select*From Items", Con);
            DS = new DataSet();
            DA.Fill(DS, "vivek");
            DA.FillSchema(DS, SchemaType.Source, "vivek");
            CB = new SqlCommandBuilder(DA);
            GVDelete.DataSource = DS.Tables[0];
            Con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
            if (GVDelete.SelectedRows!=null)
            {
                DV = GVDelete.CurrentRow;
                DataRowView Rv= DV.DataBoundItem as DataRowView;
                DR = Rv.Row;
                DR.Delete();

                MessageBox.Show("Record Delete Successfully In Our Data Set. ");
            }
            else
                MessageBox.Show("No Modification in Tables");

           
        }

        private void GVDelete_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (DS.HasChanges())
            {
                int Rows = DA.Update(DS.Tables[0]);
                MessageBox.Show(Rows + "Items(s) Updated Successfully in DataBase");
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

    }
}
