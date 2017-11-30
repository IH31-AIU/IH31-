using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace IH31_CP_Projects
{
    public partial class MemoInput : Form
    {
        Method method = new Method();
        
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

        private void BtSubmit_Click(object sender, EventArgs e)
        {
            String customercode = TbCustomerCode.Text;
            String memoinfo = TbMemoDetail.Text;
            String flg = "";
            String id = "";
            if (pflg.Checked)
            {
                flg="U";
            }
            else{
                flg = "K";
            }

           
            MySqlDataAdapter da = method.memoIDMax(customercode);
             DataTable dt = new DataTable();
            if (da==null)
            {
               id = customercode + "0000001";
            }
            else
            {
                da.Fill(dt);
                int mid=Convert.ToInt32(dt.Rows[0][0]);
                id=customercode+mid.ToString("0000000");
            }

            method.memoInsert(id, memoinfo, flg);
            DialogResult Res;
            Res = MessageBox.Show("処理が完了しました", "確認", MessageBoxButtons.OK);
            if (Res == DialogResult.OK)
            {
                this.Close();
            }

           





        }




    }
}
