using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IH31_CP_Projects
{
    public partial class MemoInput : Form
    {
        public MemoInput()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientSearch csearch = new ClientSearch();
            csearch.ShowDialog();
            csearch.Dispose();
            this.Show();
        }
    }
}
