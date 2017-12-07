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
using System.Text.RegularExpressions;
using testEW;

namespace IH31_CP_Projects
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void search_Click(object sender, EventArgs e)
        {
            EstimateSharch estimate = new EstimateSharch();
            estimate.ShowDialog();
            List<string[]> ids = estimate.Ids;
            Received receive = new Received();
            MySqlDataAdapter item = receive.QuiteItem(ids);
            if (item != null)
            {
                DataTable dt = new DataTable();
                item.Fill(dt);
                DvItem.DataSource = dt;
            }
            DvItem.AllowUserToAddRows = false;

            int price = 0;

            for (int i = 0; i < DvItem.RowCount; i++)
            {
                if (DvItem[7, i].Value == null){continue;}
                price += int.Parse(DvItem[7, i].Value.ToString()); 
            }
            LbPrice.Text = "合計"+price +"円";
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (DvItem.Rows[0].Cells[0].Value != null)
                {
                    List<string[]> rceDetail = new List<string[]>();
                    string id = DvItem.Rows[0].Cells[0].Value.ToString();
                    id = id.Substring(0, 3);
                    Received received = new Received();
                    DataTable dt = new DataTable();
                    DataTable companydt = new DataTable();
                    MySqlDataAdapter da = received.limitPrice(id);
                    MySqlDataAdapter company = received.componyName((DvItem.Rows[0].Cells[0]).Value.ToString());
                    company.Fill(companydt);
                    String companyName = companydt.Rows[0][0].ToString();
                    da.Fill(dt);
                    string lbprice = LbPrice.Text.ToString();
                    Regex re = new Regex(@"[^0-9]");
                    string price = re.Replace(lbprice, "");
                    if (int.Parse(price) < int.Parse(dt.Rows[0][0].ToString()))
                    {
                        Dictionary<string, string> replaceKeywordDic = new Dictionary<string, string>();
                        Dictionary<string, bool> areacutKeywordDic = new Dictionary<string, bool>();

                        DateTime now = DateTime.Now;
                        int month = now.Month;
                        int day = now.Day;
                        int year = now.Year;
                        replaceKeywordDic.Add("total", "\\"+price);
                        replaceKeywordDic.Add("COMPANY_NAME", companyName);
                        replaceKeywordDic.Add("MONTH", month.ToString());
                        replaceKeywordDic.Add("YEAR", year.ToString());
                        replaceKeywordDic.Add("DAY", day.ToString());
                        replaceKeywordDic.Add("ODERID", (DvItem.Rows[0].Cells[0]).Value.ToString());
                        for (int i = 0; i < 10; i++)
                        {
                            for (; i < DvItem.Rows.Count; i++)
                            {
                                string[] rce = new string[7];
                                rce[0] = DvItem.Rows[i].Cells[1].Value.ToString();
                                rce[1] = DvItem.Rows[i].Cells[2].Value.ToString();
                                rce[2] = DvItem.Rows[i].Cells[3].Value.ToString();
                                rce[3] = DvItem.Rows[i].Cells[4].Value.ToString();
                                rce[4] = DvItem.Rows[i].Cells[5].Value.ToString();
                                rce[5] = DvItem.Rows[i].Cells[6].Value.ToString();
                                rce[6] = DvItem.Rows[i].Cells[7].Value.ToString();
                                rceDetail.Add(rce);
                                replaceKeywordDic.Add("CAR" + i, DvItem.Rows[i].Cells[3].Value.ToString());
                                replaceKeywordDic.Add("year" + i, DvItem.Rows[i].Cells[2].Value.ToString());
                                replaceKeywordDic.Add("medel" + i, DvItem.Rows[i].Cells[4].Value.ToString());
                                replaceKeywordDic.Add("grade" + i, DvItem.Rows[i].Cells[5].Value.ToString());
                                replaceKeywordDic.Add("price" + i, DvItem.Rows[i].Cells[7].Value.ToString());
                            }
                            replaceKeywordDic.Add("CAR" + i,"");
                            replaceKeywordDic.Add("year" + i, "");
                            replaceKeywordDic.Add("medel" + i, "");
                            replaceKeywordDic.Add("grade" + i, "");
                            replaceKeywordDic.Add("price" + i, "");
                        }

                        areacutKeywordDic.Add("USE_X86", true);
                        areacutKeywordDic.Add("USE_SPARC", false);

                        EditWord editWord = new EditWord();
                        editWord.DocFile =@"C:\Users\yuuya\Desktop\IH\word\受注書\"+(DvItem.Rows[0].Cells[0]).Value.ToString()+"oder.doc";
                        String pdfPath =@"C:\Users\yuuya\Desktop\IH\pdf\受注書\"+(DvItem.Rows[0].Cells[0]).Value.ToString()+ "oder.pdf";
                        editWord.TmpFile = @"C:\Users\yuuya\Desktop\IH\tmp\order.doc";//テンプレファイル
                        editWord.Edit(replaceKeywordDic, areacutKeywordDic);

                        editWord.pdf(editWord.DocFile, pdfPath);

                        received.rceInsert((DvItem.Rows[0].Cells[0]).Value.ToString(), pdfPath, rceDetail);
                        MessageBox.Show("見積書が作成されました", "確認", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("売掛金が不足しています。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch(Exception ex)
            {

            }
        }
    }
}
