using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IH31_CP_Projects
{
    public partial class MemoInput : Form
    {
        
        public MemoInput()
        {
            InitializeComponent();
            
        }



        private void BtCustomerSeach_Click(object sender, EventArgs e)
        {

            Customer customer = new Customer();
            CustomerSearch csearch = new CustomerSearch(customer);
            
            csearch.ShowDialog();
            csearch.Dispose();
            this.Show();
            String customercode = customer.CustomerCodeGet();
            String customername=customer.CustomerNameGet();
            TbCustomerCode.Text = customercode;
            TbCustomerName.Text = customername;
       
        }




    }
}
