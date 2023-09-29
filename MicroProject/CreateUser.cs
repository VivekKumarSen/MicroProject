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
    public partial class CreateUser : Form
    {
        String SqlCon = "Server=DESKTOP-VOSACND;user id=sa;password=vivekkumarsain;database=MicroProject";

        SqlConnection Con; SqlCommand Cmd; SqlParameter P1;
        int Rows;

        public CreateUser()
        {
            InitializeComponent();
        }

        private void CreateUser_Load(object sender, EventArgs e)
        {
            Con = new SqlConnection(SqlCon);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Con.Open();
            Cmd = new SqlCommand("InsertCreateUser", Con);
            Cmd.CommandType = CommandType.StoredProcedure;

            if (txtFName.Text.Length <= 0 || txtLName.Text.Length <= 0 || txtUName.Text.Length<=0||txtPassword.Text.Length<=0||cmbHQuestion.Text.Length<=0||txtHAnswer.Text.Length<=0)
            {
                MessageBox.Show("Enter Your Details");
                txtFName.Focus();
                return;
            }

            P1 = new SqlParameter("@P1FName", SqlDbType.VarChar, 20);
            P1.Value = txtFName.Text;
            Cmd.Parameters.Add(P1);

            P1 = new SqlParameter("@P2LName", SqlDbType.VarChar, 20);
            P1.Value = txtLName.Text;
            Cmd.Parameters.Add(P1);

            P1 = new SqlParameter("@P3UName", SqlDbType.VarChar,40);
            P1.Value = txtUName.Text;
            Cmd.Parameters.Add(P1);

            P1 = new SqlParameter("@P4Password", SqlDbType.VarChar, 10);
            P1.Value = txtPassword.Text;
            Cmd.Parameters.Add(P1);

            P1 = new SqlParameter("@P5HQuestion", SqlDbType.VarChar, 100);
            P1.Value = cmbHQuestion.Text;
            Cmd.Parameters.Add(P1);

            P1 = new SqlParameter("@P6HAnswer", SqlDbType.VarChar, 50);
            P1.Value = txtHAnswer.Text;
            Cmd.Parameters.Add(P1);

            Rows=Cmd.ExecuteNonQuery();
            Con.Close();
            MessageBox.Show(Rows + " User Record's Are Inserted Successfully");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach(Control C in this.Controls)
            {
               if(C is TextBox)
                {
                    C.Text = "";
                }
            }
            foreach (Control C in this.Controls)
            {
                if (C is ComboBox)
                {
                    C.Text = "";
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCPassword_Leave(object sender, EventArgs e)
        {
            if(txtPassword != txtCPassword)
            {
                MessageBox.Show("Password Not Matched");
            }
        }

        private void txtCPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Text.Length > 0)
            {

            }
            else
                MessageBox.Show("Enter Your Password");
        }

        private void cmbHQuestion_Leave(object sender, EventArgs e)
        {
            if (cmbHQuestion.Text.Length < 0)
            {
                MessageBox.Show("First Select Hint Questions ");
            }
        }
    }
}
