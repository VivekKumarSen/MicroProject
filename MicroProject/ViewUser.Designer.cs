namespace MicroProject
{
    partial class ViewUser
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
            this.GVViewUser = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GVViewUser)).BeginInit();
            this.SuspendLayout();
            // 
            // GVViewUser
            // 
            this.GVViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVViewUser.Location = new System.Drawing.Point(1, 1);
            this.GVViewUser.Name = "GVViewUser";
            this.GVViewUser.RowHeadersWidth = 51;
            this.GVViewUser.RowTemplate.Height = 24;
            this.GVViewUser.Size = new System.Drawing.Size(461, 277);
            this.GVViewUser.TabIndex = 0;
            this.GVViewUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GVViewUser_CellContentClick);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(181, 316);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(113, 34);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ViewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 397);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.GVViewUser);
            this.Name = "ViewUser";
            this.Text = "ViewUser";
            this.Load += new System.EventHandler(this.ViewUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GVViewUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GVViewUser;
        private System.Windows.Forms.Button btnClose;
    }
}