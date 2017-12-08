using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using MySql.Data.MySqlClient;

namespace IH31_CP_Projects
{
    public partial class InvoiceClearingCSV : Form
    {
        List<string[]> zen = new List<string[]>();

        public InvoiceClearingCSV()
        {
            InitializeComponent();
        }

        private void btFileDialog_Click(object sender, EventArgs e)
        {
            //ダイアログの表示設定
            openFileDialog.Title = "ファイル選択";
            openFileDialog.Filter = "TEXTファイル|*.txt";
            //ダイアログの表示
            DialogResult rs = openFileDialog.ShowDialog();
            if (rs == DialogResult.OK)
            {
                String open = openFileDialog.FileName;
                tbFilePass.Text = open;
                StreamReader reader = new StreamReader(openFileDialog.FileName, Encoding.GetEncoding("Shift_JIS"));
                string sql = "select * from customer where 1=2";
                while(reader.Peek() >= 0)
                {
                    string line = reader.ReadLine();
                    if (line.Substring(0,1) == "2")
                    {
                        string[] culum = new string[3];
                        string date = "平成"+line.Substring(7, 2)+"年"+line.Substring(9,2)+"月"+line.Substring(11,2)+"日";
                        CultureInfo ci = new CultureInfo("ja-JP");
                        ci.DateTimeFormat.Calendar = new JapaneseCalendar();
                        DateTime datetime = DateTime.ParseExact(date, "ggyy年M月d日", ci);
                        int price = Convert.ToInt32(line.Substring(20, 10));
                        string name = line.Substring(49, 48);
                        culum[0] = datetime.Year + "-" + datetime.Month + "-" + datetime.Day;
                        culum[1] = price.ToString();
                        culum[2] = name.Trim();
                        zen.Add(culum);
                        sql += " or (kana_name='" + culum[2] + "')";
                    }
                }
                Received received = new Received();
                MySqlDataAdapter da = received.customer(sql);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dvCustomer.DataSource = dt;
                dvCustomer.AllowUserToAddRows = false;

                for (int i = 0; i < dvCustomer.RowCount; i++)
                {
                    int zenprice = 0;
                    for (int j = 0; j < zen.Count; j++)
                    {
                        if (dvCustomer.Rows[i].Cells[6].Value.ToString() == zen[j][2])
                        {
                            zenprice += int.Parse(zen[j][1]);
                        }
                    }
                    dvCustomer.Rows[i].Cells[0].Value = zenprice;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dvCustomer.RowCount; i++)
            {
                DataTable dt = new DataTable();
                string customerId = dvCustomer.Rows[i].Cells[1].Value.ToString();
                int price = int.Parse(dvCustomer.Rows[i].Cells[0].Value.ToString());
                Received received = new Received();
                List<string> update = received.updateSales(customerId, price);
                for(int j=0; j < update.Count; j++)
                {
                    MySqlConnection con = DBManager.getConection();
                    con.Open();
                    MySqlCommand com = new MySqlCommand(update[j], con);
                    com.ExecuteNonQuery();
                    con.Close();
                    con.Dispose();
                }
                MessageBox.Show("消込完了しました", "確認", MessageBoxButtons.OK);
            }
        }
    }
}
