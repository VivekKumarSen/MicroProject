namespace MicroProject
{
    partial class BillTrans
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbSelectItem = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtTotPrice = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.GVShowData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GVShowData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Item :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price is :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Quantity :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total Price is :";
            // 
            // cmbSelectItem
            // 
            this.cmbSelectItem.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelectItem.FormattingEnabled = true;
            this.cmbSelectItem.Location = new System.Drawing.Point(162, 43);
            this.cmbSelectItem.Name = "cmbSelectItem";
            this.cmbSelectItem.Size = new System.Drawing.Size(151, 29);
            this.cmbSelectItem.TabIndex = 4;
            this.cmbSelectItem.SelectedIndexChanged += new System.EventHandler(this.cmbSelectItem_SelectedIndexChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(162, 91);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(151, 29);
            this.txtPrice.TabIndex = 5;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(162, 132);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(151, 29);
            this.txtQuantity.TabIndex = 6;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // txtTotPrice
            // 
            this.txtTotPrice.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotPrice.Location = new System.Drawing.Point(162, 173);
            this.txtTotPrice.Name = "txtTotPrice";
            this.txtTotPrice.ReadOnly = true;
            this.txtTotPrice.Size = new System.Drawing.Size(151, 29);
            this.txtTotPrice.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(92, 238);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 32);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(214, 238);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(87, 32);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // GVShowData
            // 
            this.GVShowData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVShowData.Location = new System.Drawing.Point(334, 12);
            this.GVShowData.Name = "GVShowData";
            this.GVShowData.RowHeadersWidth = 51;
            this.GVShowData.RowTemplate.Height = 24;
            this.GVShowData.Size = new System.Drawing.Size(728, 258);
            this.GVShowData.TabIndex = 10;
            // 
            // BillTrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 284);
            this.Controls.Add(this.GVShowData);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtTotPrice);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.cmbSelectItem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BillTrans";
            this.Text = "BillTrans";
            this.Load += new System.EventHandler(this.BillTrans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GVShowData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbSelectItem;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtTotPrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DataGridView GVShowData;
    }
}