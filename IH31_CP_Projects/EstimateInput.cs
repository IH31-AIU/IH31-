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
    public partial class EstimateInput : Form
    {
        Memo memo = new Memo();
        Quote quote = new Quote();
        DataTable dt2= new DataTable();
        Waiting wait = new Waiting();
        

        public EstimateInput()
        {
            InitializeComponent();

        }

        private void BtMemoSearch_Click(object sender, EventArgs e)
        {
            MemoAll memoall = new MemoAll(memo);
            memoall.ShowDialog();
            this.Show();
            TbMemo.Text = memo.memoIdGet();
            TbCusName.Text = memo.customerNameGet();
            TbEmpName.Text = memo.employeeNameGet();


        }

        private void BtAddEst_Click(object sender, EventArgs e)
        {
           
            if (TbMemo.Text.Equals(""))
            {
                return;
            }

            EstimateDetail estdetail = new EstimateDetail(TbMemo.Text,memo.tradeFlagGet());
            MemoDetail memodetail = new MemoDetail(TbMemo.Text);
            memodetail.Show();
            estdetail.ShowDialog();
            memodetail.Close();
            this.Show();

            MySqlDataAdapter da = quote.quoteDetailSeleceOne(TbMemo.Text);
            DataTable dt = new DataTable();
            dt2 = dt;
            
           
            da.Fill(dt);
           

            DvEst.DataSource = dt;
            
           
            DvEst.Columns[0].HeaderText = "見積ID";
            DvEst.Columns[1].HeaderText = "見積明細ID";
            DvEst.Columns[2].HeaderText = "年式";
            DvEst.Columns[3].HeaderText = "車名";
            DvEst.Columns[4].HeaderText = "モデル";
            DvEst.Columns[5].HeaderText = "グレード";
            DvEst.Columns[6].HeaderText = "見積金額";
            
          







        }

        private void BtSubmit_Click(object sender, EventArgs e)
        {


            wait.Show();
            Application.DoEvents();
            int cnt = 0;
            int sum=0;
            Dictionary<string, string> replaceKeywordDic = new Dictionary<string, string>();
            Dictionary<string, bool> areacutKeywordDic = new Dictionary<string, bool>();

            DateTime dtToday = DateTime.Today;
            String formal_name = quote.customerNameSelect(TbCusName.Text);


            replaceKeywordDic.Add("date", dtToday.ToString("yyyy/MM/dd"));
            replaceKeywordDic.Add("customername", formal_name);
            replaceKeywordDic.Add("id", TbMemo.Text);

            for (int i = 1; i <= dt2.Rows.Count; i++)
            {
                
                replaceKeywordDic.Add("carname"+i, dt2.Rows[i-1][3].ToString());
                replaceKeywordDic.Add("year" + i, dt2.Rows[i - 1][2].ToString());
                replaceKeywordDic.Add("model" + i, dt2.Rows[i - 1][4].ToString());
                replaceKeywordDic.Add("grade" + i, dt2.Rows[i - 1][5].ToString());
                replaceKeywordDic.Add("price" + i, String.Format("{0:#,0}", Convert.ToInt32(dt2.Rows[i - 1][6]))+ "円");
                                                   
                
                cnt = i;
                sum=sum+Convert.ToInt32(dt2.Rows[i - 1][6]);
                

            }
            replaceKeywordDic.Add("sum", String.Format("{0:#,0}",sum)+ "円");

            for (int i = cnt+1; i <= 18; i++)
            {
               
                replaceKeywordDic.Add("carname"+i," ");
                replaceKeywordDic.Add("year"+i," ");
                replaceKeywordDic.Add("model"+i," ");
                replaceKeywordDic.Add("grade"+i," ");
                replaceKeywordDic.Add("price"+i," ");
            }




           

            EditWord editWord = new EditWord();
            editWord.DocFile =Path.path+ "\\word\\見積書\\見積書"+TbMemo.Text+TbCusName.Text+".doc";
            String pdfPath = Path.path + "\\pdf\\見積書\\見積書" + TbMemo.Text+TbCusName.Text+".pdf";
            editWord.TmpFile = Path.path + "\\tmp\\見積書.doc";//テンプレファイル
            editWord.Edit(replaceKeywordDic, areacutKeywordDic);

            editWord.pdf(editWord.DocFile, pdfPath);


            quote.quoteInsert(TbMemo.Text);
            wait.Close();
            DialogResult Res;
            Res = MessageBox.Show("処理が完了しました", "確認", MessageBoxButtons.OK);
            if (Res == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
