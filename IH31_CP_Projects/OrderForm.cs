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
            string ids = estimate.Ids;
            Received receive = new Received();
            MySqlDataAdapter item = receive.QuiteItem(ids);
            if (item != null)
            {
                DvItem.Columns.Clear();
                LbPrice.Text = "合計0円";

                DataGridViewCheckBoxColumn check = new DataGridViewCheckBoxColumn();
                DataGridViewTextBoxColumn quote_id = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn quote_detail_id = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn model_year = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn car_name = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn model = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn grade = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn remarks = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn quote_price = new DataGridViewTextBoxColumn();
                quote_id.DataPropertyName = "quote_id";
                quote_detail_id.DataPropertyName = "quote_detail_id";
                model_year.DataPropertyName = "model_year";
                car_name.DataPropertyName = "car_name";
                model.DataPropertyName = "model";
                grade.DataPropertyName = "grade";
                remarks.DataPropertyName = "remarks";
                quote_price.DataPropertyName = "quote_price";
                quote_price.Name = "quote_price";

                quote_price.HeaderText = "見積もり金額";
                remarks.HeaderText = "メモ";
                grade.HeaderText = "グレード";
                model.HeaderText = "モデル";
                car_name.HeaderText = "車名";
                model_year.HeaderText = "型年";
                quote_detail_id.HeaderText = "見積詳細ID";
                quote_id.HeaderText = "見積ID";

                check.DataPropertyName = "select";
                check.HeaderText = "選択";
                DvItem.Columns.Insert(0, check);
                DvItem.Columns.Insert(1, quote_id);
                DvItem.Columns.Insert(2, quote_detail_id);
                DvItem.Columns.Insert(3, quote_price);
                DvItem.Columns.Insert(4, car_name);
                DvItem.Columns.Insert(5, grade);
                DvItem.Columns.Insert(6, model);
                DvItem.Columns.Insert(7, model_year);
                DvItem.Columns.Insert(8, remarks);

                DataTable dt = new DataTable();
                item.Fill(dt);
                DvItem.DataSource = dt;

            }
            DvItem.AllowUserToAddRows = false;
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            try
            {
                    List<string[]> rceDetail = new List<string[]>();
                    string id = DvItem.Rows[0].Cells[1].Value.ToString();
                    id = id.Substring(0, 3);
                    Received received = new Received();
                    DataTable dt = new DataTable();
                    DataTable companydt = new DataTable();
                    MySqlDataAdapter da = received.limitPrice(id);
                    MySqlDataAdapter company = received.componyName((DvItem.Rows[0].Cells[1]).Value.ToString());
                    company.Fill(companydt);
                    String companyName = companydt.Rows[0][0].ToString();
                    da.Fill(dt);
                    string lbprice = LbPrice.Text.ToString();
                    Regex re = new Regex(@"[^\-*0-9]");
                    string price = re.Replace(lbprice, "");
                    Console.WriteLine(price);
                    Console.WriteLine(int.Parse(price));
                    Console.WriteLine(int.Parse(dt.Rows[0][0].ToString()));

                    if (int.Parse(price) < int.Parse(dt.Rows[0][0].ToString()))
                    {
                        Dictionary<string, string> replaceKeywordDic = new Dictionary<string, string>();
                        Dictionary<string, bool> areacutKeywordDic = new Dictionary<string, bool>();

                        DateTime now = DateTime.Now;
                        int month = now.Month;
                        int day = now.Day;
                        int year = now.Year;
                        replaceKeywordDic.Add("total", String.Format("{0:#,0}", int.Parse(price)) + "円");
                        replaceKeywordDic.Add("COMPANY_NAME", companyName);
                        replaceKeywordDic.Add("MONTH", month.ToString());
                        replaceKeywordDic.Add("YEAR", year.ToString());
                        replaceKeywordDic.Add("DAY", day.ToString());
                        replaceKeywordDic.Add("ODERID", (DvItem.Rows[0].Cells[1]).Value.ToString());
                        int j = 0;
                        for (int i = 0; j < 10; j++)
                        {
                            for (; i < DvItem.Rows.Count; i++)
                            {
                                if (DvItem.Rows[i].Cells[0].Value == null)
                                {
                                    continue;
                                }
                                if ((bool)DvItem.Rows[i].Cells[0].Value)
                                {
                                    string[] rce = new string[7];
                                    rce[0] = DvItem.Rows[i].Cells[2].Value.ToString();
                                    rce[1] = DvItem.Rows[i].Cells[3].Value.ToString();
                                    rce[2] = DvItem.Rows[i].Cells[4].Value.ToString();
                                    rce[3] = DvItem.Rows[i].Cells[5].Value.ToString();
                                    rce[4] = DvItem.Rows[i].Cells[6].Value.ToString();
                                    rce[5] = DvItem.Rows[i].Cells[7].Value.ToString();
                                    rce[6] = DvItem.Rows[i].Cells[8].Value.ToString();
                                    rceDetail.Add(rce);
                                    replaceKeywordDic.Add("CAR"   + j, DvItem.Rows[i].Cells[4].Value.ToString());
                                    replaceKeywordDic.Add("year"  + j, DvItem.Rows[i].Cells[3].Value.ToString());
                                    replaceKeywordDic.Add("medel" + j, DvItem.Rows[i].Cells[5].Value.ToString());
                                    replaceKeywordDic.Add("grade" + j, DvItem.Rows[i].Cells[6].Value.ToString());
                                    replaceKeywordDic.Add("price" + j, String.Format("{0:#,0}", System.Math.Abs(Convert.ToInt32(DvItem.Rows[i].Cells[8].Value.ToString()))) + "円");
                                    j++;
                                }
                            }
                            replaceKeywordDic.Add("CAR" + j,"");
                            replaceKeywordDic.Add("year" + j, "");
                            replaceKeywordDic.Add("medel" + j, "");
                            replaceKeywordDic.Add("grade" + j, "");
                            replaceKeywordDic.Add("price" + j, "");
                        }

                        areacutKeywordDic.Add("USE_X86", true);
                        areacutKeywordDic.Add("USE_SPARC", false);

                        EditWord editWord = new EditWord();
                        editWord.DocFile =Path.path+"\\word\\受注書\\"+(DvItem.Rows[0].Cells[1]).Value.ToString()+"oder.doc";
                        String pdfPath = Path.path + "\\pdf\\受注書\\"+(DvItem.Rows[0].Cells[1]).Value.ToString()+ "oder.pdf";
                        editWord.TmpFile = Path.path + "\\tmp\\oder.doc";//テンプレファイル
                        editWord.Edit(replaceKeywordDic, areacutKeywordDic);

                        editWord.pdf(editWord.DocFile, pdfPath);


                        received.rceInsert((DvItem.Rows[0].Cells[1]).Value.ToString(), pdfPath, rceDetail);
                        MessageBox.Show("受注書が作成されました", "確認", MessageBoxButtons.OK);
                        DataTable tb = new DataTable();
                        DvItem.DataSource = tb;
                        DvItem.Columns.Clear();
                    }
                    else
                    {
                        MessageBox.Show("売掛金が不足しています。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


        private void DvItem_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {

        }


        private void DvItem_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            DvItem.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void DvItem_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                int price = 0;
                for (int i = 0; i < DvItem.RowCount; i++)
                {
                    if (DvItem[0, i].Value == null)
                    {
                        continue;
                    }
                    bool select = (bool)DvItem[0, i].EditedFormattedValue;

                    if (select)
                    {
                        price += int.Parse(DvItem["quote_price", i].Value.ToString());
                    }
                }
                LbPrice.Text = "合計"+price.ToString()+"円";
                Application.DoEvents();
            }
        }
    }
}
