namespace MicroProject
{
    partial class ChangePassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnOPass = new System.Windows.Forms.RadioButton();
            this.rbtnHQuestion = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClo = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.txtRePassword = new System.Windows.Forms.TextBox();
            this.txtNPassword1 = new System.Windows.Forms.TextBox();
            this.txtOPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtRPassword = new System.Windows.Forms.TextBox();
            this.txtNPassword = new System.Windows.Forms.TextBox();
            this.txtHAnswer = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Change Password ";
            // 
            // rbtnOPass
            // 
            this.rbtnOPass.AutoSize = true;
            this.rbtnOPass.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnOPass.Location = new System.Drawing.Point(41, 118);
            this.rbtnOPass.Name = "rbtnOPass";
            this.rbtnOPass.Size = new System.Drawing.Size(199, 25);
            this.rbtnOPass.TabIndex = 1;
            this.rbtnOPass.TabStop = true;
            this.rbtnOPass.Text = "Using Old Password ";
            this.rbtnOPass.UseVisualStyleBackColor = true;
            this.rbtnOPass.CheckedChanged += new System.EventHandler(this.rbtnOPass_CheckedChanged);
            // 
            // rbtnHQuestion
            // 
            this.rbtnHQuestion.AutoSize = true;
            this.rbtnHQuestion.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnHQuestion.Location = new System.Drawing.Point(322, 118);
            this.rbtnHQuestion.Name = "rbtnHQuestion";
            this.rbtnHQuestion.Size = new System.Drawing.Size(202, 25);
            this.rbtnHQuestion.TabIndex = 2;
            this.rbtnHQuestion.TabStop = true;
            this.rbtnHQuestion.Text = "Using Hint Question ";
            this.rbtnHQuestion.UseVisualStyleBackColor = true;
            this.rbtnHQuestion.CheckedChanged += new System.EventHandler(this.rbtnHQuestion_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select Hint Question :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Enter Hint Answer :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Enter New Password :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Enter Re-Password :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.txtRPassword);
            this.panel1.Controls.Add(this.txtNPassword);
            this.panel1.Controls.Add(this.txtHAnswer);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(38, 173);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 338);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnClo);
            this.panel2.Controls.Add(this.btnSub);
            this.panel2.Controls.Add(this.txtRePassword);
            this.panel2.Controls.Add(this.txtNPassword1);
            this.panel2.Controls.Add(this.txtOPassword);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(38, 173);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(497, 338);
            this.panel2.TabIndex = 4;
            // 
            // btnClo
            // 
            this.btnClo.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClo.Location = new System.Drawing.Point(262, 209);
            this.btnClo.Name = "btnClo";
            this.btnClo.Size = new System.Drawing.Size(114, 37);
            this.btnClo.TabIndex = 11;
            this.btnClo.Text = "Close";
            this.btnClo.UseVisualStyleBackColor = true;
            this.btnClo.Click += new System.EventHandler(this.btnClo_Click);
            // 
            // btnSub
            // 
            this.btnSub.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.Location = new System.Drawing.Point(71, 209);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(114, 37);
            this.btnSub.TabIndex = 10;
            this.btnSub.Text = "Submit";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // txtRePassword
            // 
            this.txtRePassword.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRePassword.Location = new System.Drawing.Point(229, 119);
            this.txtRePassword.Name = "txtRePassword";
            this.txtRePassword.PasswordChar = '*';
            this.txtRePassword.Size = new System.Drawing.Size(257, 29);
            this.txtRePassword.TabIndex = 9;
            this.txtRePassword.Leave += new System.EventHandler(this.txtRePassword_Leave);
            // 
            // txtNPassword1
            // 
            this.txtNPassword1.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNPassword1.Location = new System.Drawing.Point(229, 70);
            this.txtNPassword1.Name = "txtNPassword1";
            this.txtNPassword1.PasswordChar = '*';
            this.txtNPassword1.Size = new System.Drawing.Size(257, 29);
            this.txtNPassword1.TabIndex = 8;
            this.txtNPassword1.Leave += new System.EventHandler(this.txtNPassword1_Leave);
            // 
            // txtOPassword
            // 
            this.txtOPassword.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOPassword.Location = new System.Drawing.Point(229, 16);
            this.txtOPassword.Name = "txtOPassword";
            this.txtOPassword.PasswordChar = '*';
            this.txtOPassword.Size = new System.Drawing.Size(257, 29);
            this.txtOPassword.TabIndex = 7;
            this.txtOPassword.Leave += new System.EventHandler(this.txtOPassword_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 23);
            this.label8.TabIndex = 6;
            this.label8.Text = "Enter Old Password :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Enter Re-Password :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(209, 23);
            this.label7.TabIndex = 4;
            this.label7.Text = "Enter New Password :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "--Select--",
            "What is your Nick Name ?",
            "Enter Your School Name ?",
            "Enter Your Permanent Body Mark  ?",
            "What is Your University Name ?",
            "Enter  Your High School Marks ?"});
            this.comboBox1.Location = new System.Drawing.Point(240, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(232, 24);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(256, 252);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(114, 37);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(65, 252);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(114, 37);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtRPassword
            // 
            this.txtRPassword.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRPassword.Location = new System.Drawing.Point(240, 172);
            this.txtRPassword.Name = "txtRPassword";
            this.txtRPassword.Size = new System.Drawing.Size(232, 29);
            this.txtRPassword.TabIndex = 7;
            this.txtRPassword.TextChanged += new System.EventHandler(this.txtRPassword_TextChanged);
            // 
            // txtNPassword
            // 
            this.txtNPassword.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNPassword.Location = new System.Drawing.Point(240, 115);
            this.txtNPassword.Name = "txtNPassword";
            this.txtNPassword.Size = new System.Drawing.Size(232, 29);
            this.txtNPassword.TabIndex = 6;
            this.txtNPassword.TextChanged += new System.EventHandler(this.txtNPassword_TextChanged);
            // 
            // txtHAnswer
            // 
            this.txtHAnswer.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHAnswer.Location = new System.Drawing.Point(240, 66);
            this.txtHAnswer.Name = "txtHAnswer";
            this.txtHAnswer.Size = new System.Drawing.Size(232, 29);
            this.txtHAnswer.TabIndex = 5;
            this.txtHAnswer.TextChanged += new System.EventHandler(this.txtHAnswer_TextChanged);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 523);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rbtnHQuestion);
            this.Controls.Add(this.rbtnOPass);
            this.Controls.Add(this.label1);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnOPass;
        private System.Windows.Forms.RadioButton rbtnHQuestion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtRPassword;
        private System.Windows.Forms.TextBox txtNPassword;
        private System.Windows.Forms.TextBox txtHAnswer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClo;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.TextBox txtRePassword;
        private System.Windows.Forms.TextBox txtNPassword1;
        private System.Windows.Forms.TextBox txtOPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}