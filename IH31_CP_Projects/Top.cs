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
            String empname = login.employeeNameGet();
            LName.Text = "ようこそ"+empname+"さん";
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

        private void BtMemoReceive_Click(object sender, EventArgs e)
        {
            MemoRecieveOrder memorecieve = new MemoRecieveOrder();
            memorecieve.ShowDialog();
        }

        private void BtEstimateInput_Click(object sender, EventArgs e)
        {
            EstimateInput estinput = new EstimateInput();
            estinput.ShowDialog();
        }

        private void ListingCreateBt_Click(object sender, EventArgs e)
        {
            Listing ls = new Listing();
            ls.ShowDialog();
        }

        private void BtAuctionInsert_Click(object sender, EventArgs e)
        {
            AuctionStatement auction = new AuctionStatement();
            auction.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DelivaryNote dn = new DelivaryNote();
            dn.ShowDialog();
        }

        private void BtInvoice_Click(object sender, EventArgs e)
        {
            InvoiceCrete invoice = new InvoiceCrete();
            invoice.ShowDialog();
        }

        private void btOder_Click(object sender, EventArgs e)
        {
            OrderForm oder = new OrderForm();
            oder.ShowDialog();
        }

        private void auctionSelect_Click(object sender, EventArgs e)
        {
            AuctionSelectSell auction = new AuctionSelectSell();
            auction.ShowDialog();
        }

        private void csvClearing_Click(object sender, EventArgs e)
        {
            InvoiceClearingCSV invoice = new InvoiceClearingCSV();
            invoice.ShowDialog();
        }
    }
}
