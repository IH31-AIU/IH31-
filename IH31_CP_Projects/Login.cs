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
     public partial class Login : Form
    {



         Quote quote = new Quote();
        public Login()
        {
            InitializeComponent();
        }

        private void BtSubmit_Click(object sender, EventArgs e)
        {
           
            String mailaddress = Tbid.Text;
            String pass = Tbpass.Text;
            MySqlDataAdapter da = quote.login(mailaddress,pass);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count>=1)
            {
                
                Loginstr login = new Loginstr();
                
                login.employeeIdSet(dt.Rows[0][0].ToString());
                login.employeeNameSet(dt.Rows[0][1].ToString());
                Top top = new Top(login);
     
                this.Hide();
                top.ShowDialog();
                top.Dispose();
               
               
                
                
            }
            else
            {
                MessageBox.Show("IDまたはパスワードが異なります", "エラー", MessageBoxButtons.OK);
                return;
            }

        }
    }
}
