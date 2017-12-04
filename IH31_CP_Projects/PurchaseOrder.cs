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
    public partial class PurchaseOrder : Form
    {
        PurchaseKanri pk = new PurchaseKanri();
        public PurchaseOrder()
        {
            InitializeComponent();
            MySqlDataAdapter da = pk.purchaseSearch();
            DataTable dt = new DataTable();
            da.Fill(dt);
            auctionList.AllowUserToAddRows = false;
            for ( int i= 0; i< dt.Rows.Count; i++)
            {
                auctionList.Rows.Add();
                auctionList.Rows[i].Cells[0].Value = false;
                auctionList.Rows[i].Cells[1].Value = dt.Rows[i]["name"];
                auctionList.Rows[i].Cells[2].Value = dt.Rows[i]["number"];
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = 0;
            if (auctionList.Rows.Count == 0)
            {
                MessageBox.Show("オークション会場が選択されていません。", "確認", MessageBoxButtons.OK);
                return;
            }
            for (int i= 0; i < auctionList.Rows.Count; i++)
            {
                if (Convert.ToBoolean(auctionList.Rows[i].Cells[0].Value))
                {
                    MySqlDataAdapter da = pk.purchaseOrderInfoGet(auctionList.Rows[i].Cells[1].Value.ToString());
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (i == 0)
                    {
                        pk.insertPurchase();
                        id = pk.maxPurchaseIdGet();
                    }
                    this.pdfCreate(dt , id);
                    MessageBox.Show("発注書が作成されました", "確認", MessageBoxButtons.OK);
                }
            }
        }

        private void pdfCreate(DataTable dt,int id)
        {
            Dictionary<string, string> replaceKeywordDic = new Dictionary<string, string>();
            Dictionary<string, bool> areacutKeywordDic = new Dictionary<string, bool>();
            replaceKeywordDic.Add("auctionName", dt.Rows[0]["auction"].ToString());
            replaceKeywordDic.Add("purchaseOrderId", id.ToString());
            replaceKeywordDic.Add("date", dt.Rows[0]["auction_date"].ToString().Substring(0,10));
            int lastI = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                pk.updatePurchaseIdRceOrderDetail(dt.Rows[i]["rce_order_id"].ToString(), Convert.ToInt32(dt.Rows[i]["rce_order_detail_id"].ToString()),id);
                replaceKeywordDic.Add("auctionNo"+i, dt.Rows[i]["auction_no"].ToString());
                replaceKeywordDic.Add("carName" + i, dt.Rows[i]["car_name"].ToString());
                replaceKeywordDic.Add("model_year" + i, dt.Rows[i]["model_year"].ToString());
                replaceKeywordDic.Add("quote_price" + i, String.Format("{0:#,0}", Convert.ToInt32(dt. Rows[i]["quote_price"])) +"円");
                lastI = i + 1;
            }
            for(;lastI < 27; lastI++)
            {
                replaceKeywordDic.Add("auctionNo" + lastI, "");
                replaceKeywordDic.Add("carName" + lastI, "");
                replaceKeywordDic.Add("model_year" + lastI, "");
                replaceKeywordDic.Add("quote_price" + lastI, "");
            }
            areacutKeywordDic.Add("USE_X86", true);
            areacutKeywordDic.Add("USE_SPARC", false);
            EditWord editWord = new EditWord();
            editWord.DocFile = Path.araki + "\\発注\\word\\"+ dt.Rows[0]["auction"].ToString() +id+ "発注書.doc";
            String pdfPath =  Path.araki + "\\発注\\pdf\\" + dt.Rows[0]["auction"].ToString() + id + "発注書.pdf";
            editWord.TmpFile = Path.araki + "\\発注\\発注書.doc";//テンプレファイル
            editWord.Edit(replaceKeywordDic, areacutKeywordDic);

            editWord.pdf(editWord.DocFile, pdfPath);
        }
    }
}
