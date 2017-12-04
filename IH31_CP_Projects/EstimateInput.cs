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
        DataTable dt = new DataTable();

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

            EstimateDetail estdetail = new EstimateDetail(TbMemo.Text);
            MemoDetail memodetail = new MemoDetail(TbMemo.Text);
            memodetail.Show();
            estdetail.ShowDialog();
            memodetail.Close();
            this.Show();
            MySqlDataAdapter da = quote.quoteDetailSeleceOne(TbMemo.Text);
           
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
            int cnt = 0;
            Dictionary<string, string> replaceKeywordDic = new Dictionary<string, string>();
            Dictionary<string, bool> areacutKeywordDic = new Dictionary<string, bool>();
            DateTime dtToday = DateTime.Today;
            String formal_name = quote.customerNameSelect(TbCusName.Text);


            replaceKeywordDic.Add("date", dtToday.ToString("yyyy/MM/dd"));
            replaceKeywordDic.Add("customername", formal_name);
            replaceKeywordDic.Add("id", TbMemo.Text);

            for (int i = 0; i < dt.Rows.Count; i++)
            {

            }
                

            



            EditWord editWord = new EditWord();
            editWord.DocFile = @"C:\Users\yuuya\Desktop\IH\word\見積書.doc";
            String pdfPath = @"C:\Users\yuuya\Desktop\IH\pdf\見積書.pdf";
            editWord.TmpFile = @"C:\Users\yuuya\Desktop\IH\見積書.doc";//テンプレファイル
            editWord.Edit(replaceKeywordDic, areacutKeywordDic);

            editWord.pdf(editWord.DocFile, pdfPath);


            //quote.quoteInsert(TbMemo.Text);
            DialogResult Res;
            Res = MessageBox.Show("処理が完了しました", "確認", MessageBoxButtons.OK);
            if (Res == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
