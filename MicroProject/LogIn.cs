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
    public partial class LogIn : Form
    {
        String SqlCon = "Server=DESKTOP-VOSACND;user id=sa;password=vivekkumarsain;database=MicroProject";

        SqlConnection Con; SqlCommand Cmd; SqlParameter P1; SqlDataReader DR;
        int Rows;
        MDIParent1 Obj1;
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            Con=new SqlConnection(SqlCon);
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if(txtUName.Text.Length <= 0 || txtPassword.Text.Length <= 0)
            {
                MessageBox.Show("Enter  Your UserName / Password ");
                txtUName.Focus();
                return;
            }
            Con.Open();
            Cmd=new SqlCommand("LogIn", Con);
            Cmd.CommandType = CommandType.StoredProcedure;

            P1 = new SqlParameter("@P1UName", SqlDbType.VarChar, 40);
            P1.Value = txtUName.Text;
            Cmd.Parameters.Add(P1);

            P1 = new SqlParameter("@P2Password", SqlDbType.VarChar, 20);
            P1.Value = txtPassword.Text;
            Cmd.Parameters.Add(P1); 

            DR=Cmd.ExecuteReader();
            if(DR.Read())
            {
                //MessageBox.Show("LogIn Successfully");
                //if(Obj1 == null)
                //{
                //   Obj1= new MDIParent1();
                //   Obj1.LogIn = this;
                //    Obj1.Show();

                //}
                GlobalData.UserName = txtUName.Text;
                GlobalData.Password= txtPassword.Text;

                Obj1 = new MDIParent1();

                this.Hide(); 
                Obj1.ShowDialog();
                this.Close();

                MessageBox.Show("LogIn Successfully");

            }
            else
            {
                MessageBox.Show("UserName / Password  is Incorrect");
                foreach(Control C in this.Controls)
                {
                    if(C is TextBox)
                    {
                        C.Text = "";
                        txtUName.Focus();
                    }
                }
            }
            Con.Close();

        }
    }
}
