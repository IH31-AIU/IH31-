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
using System.Data;
using testEW;

namespace IH31_CP_Projects
{
    public partial class InvoiceCrete : Form
    {
        Invoice invoice = new Invoice();
        DataTable dt = new DataTable();
       
        
        
        int sum=0;
        int num = 0;
        
        public InvoiceCrete()
        {
            InitializeComponent();
            Datetime.CustomFormat = "yyyy-MM";
        }



        private void BtSearch_Click(object sender, EventArgs e)
        {
            String date = Datetime.Text;
            date = date + "-25";
            MySqlDataAdapter da = invoice.invoiceSelect(date);
           
            da.Fill(dt);
            CreateNum.Text = dt.Rows.Count.ToString();
            for(int i=0;i<dt.Rows.Count;i++)
            {
                sum=sum+Convert.ToInt32(dt.Rows[i][2]);
            }
            price.Text = sum.ToString()+"円";

        }

        private void BtSubmit_Click(object sender, EventArgs e)
        {
            String date=Datetime.Text;
            int sum=0;
            date=date+"-25";

                for (int i = 0; i <Convert.ToInt32(CreateNum.Text); i++)
                {
                    MySqlDataAdapter da = invoice.invoiceSelectOne(date, dt.Rows[i][0].ToString());
                    DataTable dt2 = new DataTable();
                    da.Fill(dt2);
                    num = 0;
                    for(int k=0;k<dt2.Rows.Count;k++)
                    {
                        num = num + Convert.ToInt32(dt2.Rows[k][4]);
                    }
                    if (num > 0)
                    {
                        this.pdfCreate(dt2, dt.Rows[i][1].ToString());
                    }
                    else
                    {
                        this.pdfCreate2(dt2, dt.Rows[i][1].ToString());
                    }
                   

                }
            

            DialogResult Res;
            Res = MessageBox.Show("処理が完了しました", "確認", MessageBoxButtons.OK);
            if (Res == DialogResult.OK)
            {
                this.Close();
            }

            
        }

        private void pdfCreate(DataTable dt2, String customername)
        {
            Dictionary<string, string> replaceKeywordDic = new Dictionary<string, string>();
            Dictionary<string, bool> areacutKeywordDic = new Dictionary<string, bool>();
            int cnt = 0;
            replaceKeywordDic.Add("companyName", customername);
            replaceKeywordDic.Add("date", Datetime.Text+"請求分");

            for (int l = 1; l <= dt2.Rows.Count; l++)
            {
                replaceKeywordDic.Add("carName" + l, dt2.Rows[l - 1][0].ToString());
                replaceKeywordDic.Add("ss_price" + l, dt2.Rows[l - 1][1].ToString() + "円");
                replaceKeywordDic.Add("fee" + l, dt2.Rows[l - 1][2].ToString() + "円");
                replaceKeywordDic.Add("ec" + l, dt2.Rows[l - 1][3].ToString() + "円");
                replaceKeywordDic.Add("subtotal" + l, dt2.Rows[l - 1][4].ToString() + "円");
                if (dt2.Rows[l - 1][5].ToString().Equals("0"))
                {
                    replaceKeywordDic.Add("clearprice" + l, Datetime.Text+"請求分");
                }
                else
                {
                    
                    replaceKeywordDic.Add("clearprice" + l, "(前月支払額:" + dt2.Rows[l - 1][5].ToString() + "円)");
                }
               
                cnt = l;

            }
            for (int j = cnt + 1; j < 12; j++)
            {
                replaceKeywordDic.Add("carName" + j, "" );
                replaceKeywordDic.Add("ss_price" + j, " ");
                replaceKeywordDic.Add("fee" + j, " ");
                replaceKeywordDic.Add("ec" + j, " ");
                replaceKeywordDic.Add("subtotal"+j ," ");
                replaceKeywordDic.Add("clearprice" + j, " ");
            }
                replaceKeywordDic.Add("total", num.ToString() + "円");

            EditWord editWord = new EditWord();
            editWord.DocFile = Path.araki + "\\word\\" + Datetime.Text + customername + ".doc";
            String pdfPath = Path.araki + "\\pdf\\" + Datetime.Text + customername + ".pdf";
            editWord.TmpFile = Path.araki+"\\tmp\\請求書.doc";//テンプレファイル
            editWord.Edit(replaceKeywordDic, areacutKeywordDic);
            editWord.pdf(editWord.DocFile, pdfPath);

        }

        private void pdfCreate2(DataTable dt2, String customername)
        {
            Dictionary<string, string> replaceKeywordDic = new Dictionary<string, string>();
            Dictionary<string, bool> areacutKeywordDic = new Dictionary<string, bool>();
            int cnt = 0;
            replaceKeywordDic.Add("companyName", customername);
            replaceKeywordDic.Add("date", Datetime.Text + "支払分");

            for (int l = 1; l <= dt2.Rows.Count; l++)
            {
                replaceKeywordDic.Add("carName" + l, dt2.Rows[l - 1][0].ToString());
                replaceKeywordDic.Add("ss_price" + l, Convert.ToString(Convert.ToInt32(dt2.Rows[l - 1][1])*-1)+ "円");
                replaceKeywordDic.Add("fee" + l, dt2.Rows[l - 1][2].ToString() + "円");
                replaceKeywordDic.Add("ec" + l, dt2.Rows[l - 1][3].ToString() + "円");
                replaceKeywordDic.Add("subtotal" + l, Convert.ToString(Convert.ToInt32(dt2.Rows[l - 1][4]) * -1) + "円");
                cnt = l;
            }
            for (int j = cnt + 1; j < 12; j++)
            {
                replaceKeywordDic.Add("carName" + j, "");
                replaceKeywordDic.Add("ss_price" + j, " ");
                replaceKeywordDic.Add("fee" + j, " ");
                replaceKeywordDic.Add("ec" + j, " ");
                replaceKeywordDic.Add("subtotal" + j, " ");
            }
            replaceKeywordDic.Add("total", Convert.ToString(Convert.ToInt32(num) * -1) + "円");
            EditWord editWord = new EditWord();
            editWord.DocFile = Path.araki + "\\word\\支払書\\支払書" + Datetime.Text + customername + ".doc";
            String pdfPath = Path.araki + "\\pdf\\支払書\\支払書" + Datetime.Text + customername + ".pdf";
            editWord.TmpFile = Path.araki + "\\tmp\\支払書.doc";//テンプレファイル
            editWord.Edit(replaceKeywordDic, areacutKeywordDic);
            editWord.pdf(editWord.DocFile, pdfPath);
        }
    }
}
