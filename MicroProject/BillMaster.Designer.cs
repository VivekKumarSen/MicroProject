namespace MicroProject
{
    partial class BillMaster
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBillNo = new System.Windows.Forms.TextBox();
            this.txtBillDate = new System.Windows.Forms.TextBox();
            this.txtBillAmut = new System.Windows.Forms.TextBox();
            this.txtStateTax = new System.Windows.Forms.TextBox();
            this.txtCentralTax = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtTotBill = new System.Windows.Forms.TextBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Bill Number :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bill Date is :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bill Amount is :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(79, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "State Tax is :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Central Tax is :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Enter Discount :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(97, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Total Bill :";
            // 
            // txtBillNo
            // 
            this.txtBillNo.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillNo.Location = new System.Drawing.Point(199, 43);
            this.txtBillNo.Name = "txtBillNo";
            this.txtBillNo.Size = new System.Drawing.Size(148, 29);
            this.txtBillNo.TabIndex = 7;
            this.txtBillNo.TextChanged += new System.EventHandler(this.txtBillNo_TextChanged);
            // 
            // txtBillDate
            // 
            this.txtBillDate.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillDate.Location = new System.Drawing.Point(199, 87);
            this.txtBillDate.Name = "txtBillDate";
            this.txtBillDate.ReadOnly = true;
            this.txtBillDate.Size = new System.Drawing.Size(148, 29);
            this.txtBillDate.TabIndex = 8;
            this.txtBillDate.TextChanged += new System.EventHandler(this.txtBillDate_TextChanged);
            // 
            // txtBillAmut
            // 
            this.txtBillAmut.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillAmut.Location = new System.Drawing.Point(199, 132);
            this.txtBillAmut.Name = "txtBillAmut";
            this.txtBillAmut.ReadOnly = true;
            this.txtBillAmut.Size = new System.Drawing.Size(148, 29);
            this.txtBillAmut.TabIndex = 9;
            // 
            // txtStateTax
            // 
            this.txtStateTax.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStateTax.Location = new System.Drawing.Point(199, 180);
            this.txtStateTax.Name = "txtStateTax";
            this.txtStateTax.ReadOnly = true;
            this.txtStateTax.Size = new System.Drawing.Size(148, 29);
            this.txtStateTax.TabIndex = 10;
            // 
            // txtCentralTax
            // 
            this.txtCentralTax.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCentralTax.Location = new System.Drawing.Point(199, 227);
            this.txtCentralTax.Name = "txtCentralTax";
            this.txtCentralTax.ReadOnly = true;
            this.txtCentralTax.Size = new System.Drawing.Size(148, 29);
            this.txtCentralTax.TabIndex = 11;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(199, 272);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(148, 29);
            this.txtDiscount.TabIndex = 12;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            // 
            // txtTotBill
            // 
            this.txtTotBill.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotBill.Location = new System.Drawing.Point(199, 318);
            this.txtTotBill.Name = "txtTotBill";
            this.txtTotBill.ReadOnly = true;
            this.txtTotBill.Size = new System.Drawing.Size(148, 29);
            this.txtTotBill.TabIndex = 13;
            this.txtTotBill.TextChanged += new System.EventHandler(this.txtTotBill_TextChanged);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.Location = new System.Drawing.Point(384, 43);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(116, 31);
            this.btnAddItem.TabIndex = 14;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(92, 383);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 33);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(218, 383);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 33);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(345, 383);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(87, 33);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // BillMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.txtTotBill);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtCentralTax);
            this.Controls.Add(this.txtStateTax);
            this.Controls.Add(this.txtBillAmut);
            this.Controls.Add(this.txtBillDate);
            this.Controls.Add(this.txtBillNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BillMaster";
            this.Text = " ";
            this.Load += new System.EventHandler(this.BillMaster_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBillNo;
        private System.Windows.Forms.TextBox txtBillDate;
        private System.Windows.Forms.TextBox txtBillAmut;
        private System.Windows.Forms.TextBox txtStateTax;
        private System.Windows.Forms.TextBox txtCentralTax;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtTotBill;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
    }
}