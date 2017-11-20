using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testEW;

namespace IH31_CP_Projects
{
    public partial class pdfsample : Form
    {
        public pdfsample()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> replaceKeywordDic = new Dictionary<string, string>();
            Dictionary<string, bool> areacutKeywordDic = new Dictionary<string, bool>();

            replaceKeywordDic.Add("MONTH", "11");
            replaceKeywordDic.Add("YEAR", "2017");
            replaceKeywordDic.Add("DAY", "16");

            areacutKeywordDic.Add("USE_X86", true);
            areacutKeywordDic.Add("USE_SPARC", false);

            EditWord editWord = new EditWord();
            editWord.DocFile = @"C:\Users\yuuya\Desktop\見積書.doc";
            editWord.TmpFile = @"C:\Users\yuuya\Desktop\tmpl.doc";//テンプレファイル
            editWord.Edit(replaceKeywordDic, areacutKeywordDic);

            editWord.pdf(editWord.DocFile);
            

            MessageBox.Show("見積書が作成されました", "確認", MessageBoxButtons.OK);
        }
    }
}
