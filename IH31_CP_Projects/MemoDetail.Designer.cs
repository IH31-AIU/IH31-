﻿namespace IH31_CP_Projects
{
    partial class MemoDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TbCustomerName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TbDate = new System.Windows.Forms.TextBox();
            this.Tbmemo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GbTradeFlg = new System.Windows.Forms.GroupBox();
            this.sflg = new System.Windows.Forms.RadioButton();
            this.pflg = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.TbMemoDetail = new System.Windows.Forms.RichTextBox();
            this.BtSubmit = new System.Windows.Forms.Button();
            this.BtClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.GbTradeFlg.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 12);
            this.label3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "顧客名";
            // 
            // TbCustomerName
            // 
            this.TbCustomerName.Location = new System.Drawing.Point(77, 68);
            this.TbCustomerName.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.TbCustomerName.Name = "TbCustomerName";
            this.TbCustomerName.ReadOnly = true;
            this.TbCustomerName.Size = new System.Drawing.Size(113, 19);
            this.TbCustomerName.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(29, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 33);
            this.label5.TabIndex = 13;
            this.label5.Text = "メモ詳細";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TbDate);
            this.groupBox1.Controls.Add(this.Tbmemo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TbCustomerName);
            this.groupBox1.Controls.Add(this.GbTradeFlg);
            this.groupBox1.Location = new System.Drawing.Point(41, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 97);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // TbDate
            // 
            this.TbDate.Location = new System.Drawing.Point(77, 44);
            this.TbDate.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.TbDate.Name = "TbDate";
            this.TbDate.ReadOnly = true;
            this.TbDate.Size = new System.Drawing.Size(113, 19);
            this.TbDate.TabIndex = 20;
            // 
            // Tbmemo
            // 
            this.Tbmemo.Location = new System.Drawing.Point(77, 19);
            this.Tbmemo.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Tbmemo.Name = "Tbmemo";
            this.Tbmemo.ReadOnly = true;
            this.Tbmemo.Size = new System.Drawing.Size(113, 19);
            this.Tbmemo.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 44);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 18;
            this.label7.Text = "日付";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "メモID";
            // 
            // GbTradeFlg
            // 
            this.GbTradeFlg.Controls.Add(this.sflg);
            this.GbTradeFlg.Controls.Add(this.pflg);
            this.GbTradeFlg.Location = new System.Drawing.Point(241, 21);
            this.GbTradeFlg.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.GbTradeFlg.Name = "GbTradeFlg";
            this.GbTradeFlg.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.GbTradeFlg.Size = new System.Drawing.Size(137, 49);
            this.GbTradeFlg.TabIndex = 11;
            this.GbTradeFlg.TabStop = false;
            this.GbTradeFlg.Text = "売買選択";
            // 
            // sflg
            // 
            this.sflg.AutoSize = true;
            this.sflg.Location = new System.Drawing.Point(69, 31);
            this.sflg.Name = "sflg";
            this.sflg.Size = new System.Drawing.Size(59, 16);
            this.sflg.TabIndex = 10;
            this.sflg.TabStop = true;
            this.sflg.Text = "売注文";
            this.sflg.UseVisualStyleBackColor = true;
            // 
            // pflg
            // 
            this.pflg.AutoSize = true;
            this.pflg.Location = new System.Drawing.Point(5, 31);
            this.pflg.Name = "pflg";
            this.pflg.Size = new System.Drawing.Size(59, 16);
            this.pflg.TabIndex = 9;
            this.pflg.TabStop = true;
            this.pflg.Text = "買注文";
            this.pflg.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 167);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 12);
            this.label6.TabIndex = 16;
            this.label6.Text = "メモ詳細";
            // 
            // TbMemoDetail
            // 
            this.TbMemoDetail.Location = new System.Drawing.Point(37, 187);
            this.TbMemoDetail.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.TbMemoDetail.Name = "TbMemoDetail";
            this.TbMemoDetail.Size = new System.Drawing.Size(837, 324);
            this.TbMemoDetail.TabIndex = 14;
            this.TbMemoDetail.Text = "";
            // 
            // BtSubmit
            // 
            this.BtSubmit.Location = new System.Drawing.Point(807, 513);
            this.BtSubmit.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.BtSubmit.Name = "BtSubmit";
            this.BtSubmit.Size = new System.Drawing.Size(67, 39);
            this.BtSubmit.TabIndex = 15;
            this.BtSubmit.Text = "登録";
            this.BtSubmit.UseVisualStyleBackColor = true;
            this.BtSubmit.Click += new System.EventHandler(this.BtSubmit_Click);
            // 
            // BtClose
            // 
            this.BtClose.Location = new System.Drawing.Point(37, 513);
            this.BtClose.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.BtClose.Name = "BtClose";
            this.BtClose.Size = new System.Drawing.Size(67, 39);
            this.BtClose.TabIndex = 18;
            this.BtClose.Text = "閉じる";
            this.BtClose.UseVisualStyleBackColor = true;
            this.BtClose.Click += new System.EventHandler(this.BtClose_Click);
            // 
            // MemoDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.BtClose);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtSubmit);
            this.Controls.Add(this.TbMemoDetail);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "MemoDetail";
            this.Text = "メモ詳細登録画面";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GbTradeFlg.ResumeLayout(false);
            this.GbTradeFlg.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbCustomerName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton sflg;
        private System.Windows.Forms.RadioButton pflg;
        private System.Windows.Forms.GroupBox GbTradeFlg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox TbMemoDetail;
        private System.Windows.Forms.Button BtSubmit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tbmemo;
        private System.Windows.Forms.TextBox TbDate;
        private System.Windows.Forms.Button BtClose;

    }
}