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
        private string ids = "";
        public EstimateSharch()
        {
            InitializeComponent();
            DataGridViewTextBoxColumn addName = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn();

            addName.DataPropertyName = "abb_name";
            id.DataPropertyName = "quote_id";
            addName.HeaderText = "略名";
            id.HeaderText = "見積ID"; 

            string employeeid = "1";
            Received recevied = new Received();
            MySqlDataAdapter da = recevied.EstimateSearch(employeeid);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DvEstimate.Columns.Insert(0,addName);
            DvEstimate.Columns.Insert(1, id);

            DvEstimate.DataSource = dt;
            DvEstimate.AllowUserToAddRows = false;

        }

        private void btSelect_Click(object sender, EventArgs e)
        {

        }
        public string Ids
        {
            get
            {
                return ids;
            }
        }

        private void DvEstimate_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string memoid = DvEstimate.Rows[e.RowIndex].Cells[0].Value.ToString();
            ids = memoid;

            this.Close();
        }
    }
}
