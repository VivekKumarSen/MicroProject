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
using System.Collections;

namespace MicroProject
{
    public partial class ChangePassword : Form
    {
        String SqlCon = "Server=DESKTOP-VOSACND;User Id=sa;Password=vivekkumarsain;DataBase=MicroProject";
        SqlConnection Con;
        SqlCommand Cmd;
        DataSet DS;
        SqlDataAdapter DA;
        SqlDataReader DR;
        SqlParameter P1;
        SqlCommandBuilder CB;
        int Rows;
        String Query;

        public ChangePassword()
        {
            InitializeComponent();
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            rbtnOPass.Checked = true;

            //String Constring="Server=DESKTOP-VOSACND;User Id=sa;Password=vivekkumarsain;DataBase=MicroProject";
            //Con = new SqlConnection(Constring);
            
            //Cmd = new SqlCommand("Select * from Users", Con);
            //Cmd.CommandType = CommandType.Text;

            //Con.Open();

            //DR = Cmd.ExecuteReader();

            //while (DR.Read())
            ////CmbQuest.Items.Add(DR[0]);

            //Con.Close();

        }

        private void rbtnOPass_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnOPass.Checked) 
            {
              panel2.Visible = true;
              panel1.Visible = false;
            }
            else if(rbtnHQuestion.Checked==true)
            {
                panel1.Visible=true;
                panel2.Visible=false;
            }

        }

        private void rbtnHQuestion_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnOPass.Checked)
            {
                panel2.Visible = true;
                panel1.Visible = false;
            }
            else if (rbtnHQuestion.Checked == true)
            {
                panel1.Visible = true;
                panel2.Visible = false;
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
           
            Con = new SqlConnection(SqlCon);
            Cmd = new SqlCommand("FindPassword", Con);
            Cmd.CommandType = CommandType.StoredProcedure;

            P1 = new SqlParameter("@P1UName", SqlDbType.VarChar, 20);
            P1.Value = GlobalData.UserName;
            Cmd.Parameters.Add(P1);

            P1 = new SqlParameter("@P2UPassword", SqlDbType.VarChar, 20);
            P1.Direction = ParameterDirection.Output;
            Cmd.Parameters.Add(P1);

            Con.Open();
            Cmd.ExecuteNonQuery();
            Con.Close();

            string OldPassword = Cmd.Parameters["@P2UPassword"].Value.ToString();
            if (OldPassword == txtOPassword.Text)
            {
               
                Con = new SqlConnection(SqlCon);

                Query = "Update Users set Password=@P1 where UserName='" + GlobalData.UserName + "'";

                Cmd = new SqlCommand(Query, Con);
                Cmd.CommandType = CommandType.Text;
                Cmd.Parameters.AddWithValue("@P1", txtNPassword1.Text);
                Con.Open();
                Rows = Cmd.ExecuteNonQuery();
                Con.Close();
                if (Rows > 0)
                    MessageBox.Show("Password Updated");
            }
            else MessageBox.Show("Error");

            foreach (Control C in this.Controls)
            {
                if (C is TextBox)
                {
                    C.Text = "";
                }

            }

        }

        private void txtOPassword_Leave(object sender, EventArgs e)
        {
            if (txtOPassword.Text.Length <= 0 )
            {
                MessageBox.Show("Enter Old Password ");
                txtOPassword.Focus();
                
            }
        }

        private void txtNPassword1_Leave(object sender, EventArgs e)
        {
            if(txtNPassword1.Text.Length <=0)
            {
                MessageBox.Show("Enter New Password ");
                txtOPassword.Focus();
                
            }
        }

        private void txtRePassword_Leave(object sender, EventArgs e)
        {
            if (txtNPassword1.Text != txtRePassword.Text)
            {
                MessageBox.Show("Your New Password is Not Matched !");
                txtRePassword.Focus();
            }
        }

        private void btnClo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtHAnswer_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            
            Con = new SqlConnection(SqlCon);

            Cmd = new SqlCommand("FindHintPassword", Con);
            Cmd.CommandType = CommandType.StoredProcedure;

            P1 = new SqlParameter("@P1UName", SqlDbType.VarChar, 20);
            P1.Value = GlobalData.UserName;
            Cmd.Parameters.Add(P1);

            P1 = new SqlParameter("@P2HintQuestion", SqlDbType.VarChar, 20);
            P1.Direction = ParameterDirection.Output;
            Cmd.Parameters.Add(P1);

            P1 = new SqlParameter("@P3HintAnswer", SqlDbType.VarChar, 20);
            P1.Direction = ParameterDirection.Output;
            Cmd.Parameters.Add(P1);

            Con.Open();
            Cmd.ExecuteNonQuery();
            Con.Close();

            string HQPassword = Cmd.Parameters["@P2HintQuestion"].Value.ToString();
            string HAPassword = Cmd.Parameters["@P3HintAnswer"].Value.ToString();
            comboBox1.Text = Cmd.Parameters["@P2HintQuestion"].Value.ToString();

            if (HQPassword == comboBox1.Text && HAPassword == txtHAnswer.Text)
            {
                Con = new SqlConnection(SqlCon);

                Con.Open();

                Query = "Update Users set Password=@P1 where UserName='" + GlobalData.UserName+"'";
                Cmd = new SqlCommand(Query, Con);

                Cmd.Parameters.AddWithValue("@P1", txtNPassword1.Text);

                Rows = Cmd.ExecuteNonQuery();
                Con.Close();

                if (Rows > 0)
                {
                    MessageBox.Show("Password Updated");
                }
                else MessageBox.Show("Error");
            }
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
    }
}
