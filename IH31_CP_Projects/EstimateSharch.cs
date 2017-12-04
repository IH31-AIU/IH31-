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


namespace IH31_CP_Projects
{
    public partial class EstimateSharch : Form
    {
        private List<string[]> ids = new List<string[]>();
        public EstimateSharch()
        {
            InitializeComponent();
            string employeeid = "1";
            Received recevied = new Received();
            MySqlDataAdapter da = recevied.EstimateSearch(employeeid);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DvEstimate.DataSource = dt;
            DvEstimate.AllowUserToAddRows = false;

        }

        private void btSelect_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < DvEstimate.RowCount; i++)
            {
                if(DvEstimate[0, i].Value == null)
                {
                    continue;
                }
                if ((bool)DvEstimate[0, i].Value)
                {
                    string[] memoid = new string[2];
                    memoid[0] = DvEstimate[1, i].Value.ToString();
                    memoid[1] = DvEstimate[2, i].Value.ToString();
                    ids.Add(memoid);
                }
            }
            this.Close();
        }
        public List<string[]> Ids
        {
            get
            {
                return ids;
            }
        }
    }
}
