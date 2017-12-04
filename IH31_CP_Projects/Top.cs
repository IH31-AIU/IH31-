﻿using System;
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
    public partial class Top : Form
    {
        Loginstr login;
        public Top(Loginstr login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void BtMemoInput_Click(object sender, EventArgs e)
        {
            MemoInput memoinput = new MemoInput();
            memoinput.ShowDialog();

        }

        private void PurchaseCreateBt_Click(object sender, EventArgs e)
        {
            PurchaseOrder po = new PurchaseOrder();
            po.ShowDialog();
        }
    }
}
