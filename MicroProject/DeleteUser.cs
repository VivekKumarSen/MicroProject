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
using System.Data.SqlClient;

namespace MicroProject
{
    public partial class DeleteUser : Form
    {
        String SqlCon = "Server=DESKTOP-VOSACND;User Id=sa;Password=vivekkumarsain;DataBase=MicroProject";
        SqlConnection Con;
        SqlCommand Cmd;
        SqlDataAdapter DA;
        DataSet DS;
        SqlParameter P1;
        DataGridViewRow DV;
        DataRow DR;
        SqlCommandBuilder CB;
        int Rows;
        String Query, Item, Price;

        public DeleteUser()
        {
            InitializeComponent();
        }

        private void DeleteUser_Load(object sender, EventArgs e)
        {
            Con = new SqlConnection(SqlCon);
            Con.Open();
            DA = new SqlDataAdapter("Select UserName,FirstName,LastName From Users", Con);
            DS = new DataSet();
            DA.Fill(DS, "vivek");
            DA.FillSchema(DS, SchemaType.Source, "vivek");
            CB = new SqlCommandBuilder(DA);
            GVDeleteView.DataSource = DS.Tables[0];
            Con.Close();
        }

        private void GVDeleteView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (GVDeleteView.SelectedRows != null)
            {
                DV = GVDeleteView.CurrentRow;
                DataRowView Rv = DV.DataBoundItem as DataRowView;
                DR = Rv.Row;
                DR.Delete();

                MessageBox.Show("Record Delete Successfully");
            }
            else
                MessageBox.Show("No Modification in Tables");

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
    }
}
