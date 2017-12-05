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
    public partial class Listing : Form
    {
        ListingKanri lk = new ListingKanri();
        public Listing()
        {
            InitializeComponent();
            MySqlDataAdapter da = lk.listingSearch();
            DataTable dt = new DataTable();
            da.Fill(dt);
            auctionList.AllowUserToAddRows = false;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                auctionList.Rows.Add();
                auctionList.Rows[i].Cells[0].Value = false;
                auctionList.Rows[i].Cells[1].Value = dt.Rows[i]["name"];
                auctionList.Rows[i].Cells[2].Value = dt.Rows[i]["number"];
            }
        }

        private void pdfCreate(DataRow row, int id)
        {
            Dictionary<string, string> replaceKeywordDic = new Dictionary<string, string>();
            Dictionary<string, bool> areacutKeywordDic = new Dictionary<string, bool>();
            lk.updatePurchaseIdRceOrderDetail(row["rce_order_id"].ToString(), Convert.ToInt32(row["rce_order_detail_id"].ToString()), id);
            replaceKeywordDic.Add("modelYear", row["model_year"].ToString());
            replaceKeywordDic.Add("carName", row["car_name"].ToString());
            replaceKeywordDic.Add("grade", row["grade"].ToString());
            replaceKeywordDic.Add("model", row["model"].ToString());
            replaceKeywordDic.Add("quatePrice", String.Format("{0:#,0}", Convert.ToInt32(row["quote_price"])) + "円");
            areacutKeywordDic.Add("USE_X86", true);
            areacutKeywordDic.Add("USE_SPARC", false);
            EditWord editWord = new EditWord();
            editWord.DocFile = Path.araki + "\\出品\\word\\出品ID" + id + "出品票.doc";
            String pdfPath = Path.araki + "\\出品\\pdf\\出品ID" + id + "出品票.pdf";
            editWord.TmpFile = Path.araki + "\\出品\\出品票.doc";//テンプレファイル
            editWord.Edit(replaceKeywordDic, areacutKeywordDic);
            editWord.pdf(editWord.DocFile, pdfPath);
        }

        private void ListingCreateBt_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter da;
            DataTable dt;
            for (int i = 0; i < auctionList.Rows.Count; i++)
            {
                if (Convert.ToBoolean(auctionList.Rows[i].Cells[0].Value))
                {
                    da = lk.listingInfoGet(auctionList.Rows[i].Cells[1].Value.ToString());
                    dt = new DataTable();
                    da.Fill(dt);
                    lk.insertListing();
                    int id = lk.maxListingIdGet();
                    for (int j = 0; j < dt.Rows.Count; j++)
                    {
                        this.pdfCreate(dt.Rows[j], id);
                    }
                    
                }
            }
            MessageBox.Show("出品票が作成されました", "確認", MessageBoxButtons.OK);
            auctionList.Rows.Clear();
            da = lk.listingSearch();
          　dt = new DataTable();
            da.Fill(dt);
            auctionList.AllowUserToAddRows = false;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                auctionList.Rows.Add();
                auctionList.Rows[i].Cells[0].Value = false;
                auctionList.Rows[i].Cells[1].Value = dt.Rows[i]["name"];
                auctionList.Rows[i].Cells[2].Value = dt.Rows[i]["number"];
            }

        }
    }
}
