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
    public partial class CustomerSearch : Form
    {
       Customer customer;
       Quote quote = new Quote();
        

        

        public CustomerSearch(Customer customer)
        {
            InitializeComponent();
            this.customer = customer;

        }

        private void BtSearch_Click(object sender, EventArgs e)
        {
            
            String customername = TbCustomerName.Text;
            MySqlDataAdapter da =quote.CustomertSearch(customername);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DvCustomer.DataSource = dt;
            DvCustomer.Columns[0].HeaderText = "顧客ID";
            DvCustomer.Columns[1].HeaderText = "顧客verID";
            DvCustomer.Columns[2].HeaderText = "メールアドレス";
            DvCustomer.Columns[3].HeaderText = "正式社名";
            DvCustomer.Columns[4].HeaderText = "略称名";
            DvCustomer.Columns[5].HeaderText = "電話番号";
            DvCustomer.Columns[6].HeaderText = "住所";

        }

        private void DvCustomer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String customerid = DvCustomer.CurrentRow.Cells["customer_id"].Value.ToString();
            String customername= DvCustomer.CurrentRow.Cells["abb_name"].Value.ToString();
            customer.CustomerCodeSet(customerid);
            customer.CustomerNameSet(customername);
            this.Close();
        }


    }
}
