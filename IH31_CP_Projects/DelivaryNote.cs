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
using testEW;

namespace IH31_CP_Projects
{
    public partial class DelivaryNote : Form
    {
        DataTable dt;
        MySqlDataAdapter da;
        DeliveryKanri dk = new DeliveryKanri();
        public DelivaryNote()
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
            String customername = customer.CustomerNameGet();
            TbCustomerCode.Text = customercode;
            TbCustomerName.Text = customername;
            carListSet(customercode);

        }

        private void carListSet(String customerCode)
        {
            dt = new DataTable();
            da = dk.deloveryInfoGet(customerCode);
            da.Fill(dt);
            carList.Rows.Clear();
            carList.AllowUserToAddRows = false;
            Console.WriteLine(dt.Rows.Count);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                
                carList.Rows.Add();
                carList.Rows[i].Cells[0].Value = dt.Rows[i]["car_name"];
                carList.Rows[i].Cells[1].Value = dt.Rows[i]["sales_stocking_price"];
                carList.Rows[i].Cells[2].Value = dt.Rows[i]["fee"];
                carList.Rows[i].Cells[3].Value = dt.Rows[i]["expenses_charge"];
                int subtotal = Convert.ToInt32(dt.Rows[i]["sales_stocking_price"]) + Convert.ToInt32(dt.Rows[i]["fee"]) + Convert.ToInt32(dt.Rows[i]["expenses_charge"]);
                carList.Rows[i].Cells[4].Value = subtotal;
            }
        }

        private void deliveryCreateBt_Click(object sender, EventArgs e)
        {
            Quote q = new Quote();
            int total = 0;
            Dictionary<string, string> replaceKeywordDic = new Dictionary<string, string>();
            Dictionary<string, bool> areacutKeywordDic = new Dictionary<string, bool>();
            replaceKeywordDic.Add("companyName", q.customerNameSelect(TbCustomerName.Text));
            int lastI = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                replaceKeywordDic.Add("carName" + i, carList.Rows[i].Cells[0].Value.ToString());
                replaceKeywordDic.Add("ss_price" + i, String.Format("{0:#,0}", Convert.ToInt32(carList.Rows[i].Cells[1].Value)) + "円");
                replaceKeywordDic.Add("fee" + i, String.Format("{0:#,0}", Convert.ToInt32(carList.Rows[i].Cells[2].Value)) + "円");
                replaceKeywordDic.Add("ec" + i, String.Format("{0:#,0}", Convert.ToInt32(carList.Rows[i].Cells[3].Value)) + "円");
                replaceKeywordDic.Add("subtotal" + i, String.Format("{0:#,0}", Convert.ToInt32(carList.Rows[i].Cells[4].Value)) + "円");
                total += Convert.ToInt32(carList.Rows[i].Cells[4].Value);
                lastI = i + 1;
            }
            for (; lastI < 11; lastI++)
            {
                replaceKeywordDic.Add("carName" + lastI, "");
                replaceKeywordDic.Add("ss_price" + lastI, "");
                replaceKeywordDic.Add("fee" + lastI, "");
                replaceKeywordDic.Add("ec" + lastI, "");
                replaceKeywordDic.Add("subtotal" + lastI, "");

            }
            replaceKeywordDic.Add("total", String.Format("{0:#,0}", total) + "円");
            areacutKeywordDic.Add("USE_X86", true);
            areacutKeywordDic.Add("USE_SPARC", false);
            EditWord editWord = new EditWord();
            String time = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
            Console.WriteLine(time);
            editWord.DocFile = Path.path + "\\word\\納品書\\"+ time + "納品書.doc";
            String pdfPath = Path.path + "\\pdf\\納品書\\"+ time + "納品書.pdf";
            editWord.TmpFile = Path.path + "\\tmp\\納品書.doc";//テンプレファイル
            editWord.Edit(replaceKeywordDic, areacutKeywordDic);

            editWord.pdf(editWord.DocFile, pdfPath);
            MessageBox.Show("納品書が作成されました", "確認", MessageBoxButtons.OK);
            dk.buyFlagUpdate(TbCustomerCode.Text);
            carListSet(TbCustomerCode.Text);

        }
    }
}
