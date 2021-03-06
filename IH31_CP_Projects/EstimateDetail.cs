﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace IH31_CP_Projects
{
    public partial class EstimateDetail : Form
    {
        String memoid;
        String tradeFlag;
        Quote quote = new Quote();

        public EstimateDetail(String memoid,String tradeFlag)
        {
            InitializeComponent();
            this.memoid = memoid;
            this.tradeFlag = tradeFlag;
        }

        private void BtSubmit_Click(object sender, EventArgs e)
        {
            String year = TbYear.Text;
            String carname = TbCarName.Text;
            String model = TbModel.Text;
            String grade = TbGrade.Text;
            String other = TbOther.Text;
            String price = TbPrice.Text;
            if (price.Equals(""))
            {
                return;
            }
            
            MySqlDataAdapter da = quote.quoteDetailIdMax(memoid);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int detailid=0;
            try
            {
                
                detailid = Convert.ToInt32(dt.Rows[0][0]) + 1;
            }
            catch
            {

                detailid = 1;
                   
                
            }
            int newPrice = Convert.ToInt32(price);
            if (tradeFlag =="U")
            {
                newPrice = newPrice * -1;
            }

            quote.quote_ItemInsert(memoid, detailid, year, carname, model, grade, other, newPrice);
            this.Close();

        }
    }
}
