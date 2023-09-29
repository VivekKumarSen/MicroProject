namespace MicroProject
{
    partial class DeleteUser
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
            this.GVDeleteView = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GVDeleteView)).BeginInit();
            this.SuspendLayout();
            // 
            // GVDeleteView
            // 
            this.GVDeleteView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVDeleteView.Location = new System.Drawing.Point(2, 1);
            this.GVDeleteView.Name = "GVDeleteView";
            this.GVDeleteView.RowHeadersWidth = 51;
            this.GVDeleteView.RowTemplate.Height = 24;
            this.GVDeleteView.Size = new System.Drawing.Size(488, 249);
            this.GVDeleteView.TabIndex = 0;
            this.GVDeleteView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GVDeleteView_CellContentClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(114, 296);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 31);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(260, 296);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 31);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // DeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 362);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.GVDeleteView);
            this.Name = "DeleteUser";
            this.Text = "DeleteUser";
            this.Load += new System.EventHandler(this.DeleteUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GVDeleteView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GVDeleteView;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
    }
}