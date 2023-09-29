using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MicroProject
{
    public partial class MDIParent1 : Form
    {
        CreateUser CU;
        private int childFormNumber = 0;
        EditItem EI;
        AddItems ADDI;
        ChangePassword CP;
        DeleteItems DI;
        DeleteUser DU;
        ChangePassword CP1;
        ViewUser VU;
        BillMaster BM;
        ViewBill VB;


        public MDIParent1()
        {
            InitializeComponent();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(CU==null)
            {
                CU = new CreateUser();
                CU.MdiParent = this;
                CU.Show();
                
            }
           
        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {

        }

        private void addItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ADDI == null)
            {
                ADDI = new AddItems();
                ADDI.MdiParent = this;
                ADDI.Show();
                
            }
           
        }

        private void editItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (EI == null)
            {
                EI = new EditItem();
                EI.MdiParent = this;
                EI.Show();
                
            }
           
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(CP==null)
            { 
                CP = new ChangePassword();
                CP.MdiParent = this;
                CP.Show();
                
            }
           
        }

        private void deleteItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(DI==null)
            {
                DI=new DeleteItems();
                DI.MdiParent = this;
                DI.Show();
               
            }
           
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void newBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(BM == null)
            {
                BM=new BillMaster();
                BM.MdiParent = this;
                BM.Show();
               
            }
            
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(DU == null)
            {
                DU=new DeleteUser();
                DU.MdiParent = this;
                DU.Show();
              
            }
            
        }

        private void viewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(VU == null)
            {
                VU=new ViewUser();
                VU.MdiParent= this;
                VU.Show();
                
            }
            
        }

        private void viewBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(VB==null)
            {
                VB=new ViewBill();
                VB.MdiParent = this;
                VB.Show();
            }
            
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
      
      
}
