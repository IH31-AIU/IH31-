﻿namespace IH31_CP_Projects
{
    partial class MemoInput
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TbCustomerCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TbCustomerName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtCustomerSeach = new System.Windows.Forms.Button();
            this.TbMemoDetail = new System.Windows.Forms.RichTextBox();
            this.BtSubmit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sflg = new System.Windows.Forms.RadioButton();
            this.pflg = new System.Windows.Forms.RadioButton();
            this.GbTradeFlg = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "顧客コード";
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
            // TbCustomerCode
            // 
            this.TbCustomerCode.Location = new System.Drawing.Point(77, 17);
            this.TbCustomerCode.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.TbCustomerCode.Name = "TbCustomerCode";
            this.TbCustomerCode.ReadOnly = true;
            this.TbCustomerCode.Size = new System.Drawing.Size(63, 19);
            this.TbCustomerCode.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 45);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "顧客名";
            // 
            // TbCustomerName
            // 
            this.TbCustomerName.Location = new System.Drawing.Point(77, 43);
            this.TbCustomerName.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.TbCustomerName.Name = "TbCustomerName";
            this.TbCustomerName.ReadOnly = true;
            this.TbCustomerName.Size = new System.Drawing.Size(63, 19);
            this.TbCustomerName.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(13, 13);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 33);
            this.label5.TabIndex = 7;
            this.label5.Text = "メモ登録";
            // 
            // BtCustomerSeach
            // 
            this.BtCustomerSeach.Location = new System.Drawing.Point(151, 13);
            this.BtCustomerSeach.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.BtCustomerSeach.Name = "BtCustomerSeach";
            this.BtCustomerSeach.Size = new System.Drawing.Size(47, 20);
            this.BtCustomerSeach.TabIndex = 8;
            this.BtCustomerSeach.Text = "検索";
            this.BtCustomerSeach.UseVisualStyleBackColor = true;
            this.BtCustomerSeach.Click += new System.EventHandler(this.BtCustomerSeach_Click);
            // 
            // TbMemoDetail
            // 
            this.TbMemoDetail.Location = new System.Drawing.Point(23, 179);
            this.TbMemoDetail.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.TbMemoDetail.Name = "TbMemoDetail";
            this.TbMemoDetail.Size = new System.Drawing.Size(851, 332);
            this.TbMemoDetail.TabIndex = 9;
            this.TbMemoDetail.Text = "";
            // 
            // BtSubmit
            // 
            this.BtSubmit.Location = new System.Drawing.Point(807, 513);
            this.BtSubmit.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.BtSubmit.Name = "BtSubmit";
            this.BtSubmit.Size = new System.Drawing.Size(67, 39);
            this.BtSubmit.TabIndex = 10;
            this.BtSubmit.Text = "登録";
            this.BtSubmit.UseVisualStyleBackColor = true;
            this.BtSubmit.Click += new System.EventHandler(this.BtSubmit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 159);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "メモ詳細";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sflg);
            this.groupBox1.Controls.Add(this.pflg);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.BtCustomerSeach);
            this.groupBox1.Controls.Add(this.TbCustomerCode);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TbCustomerName);
            this.groupBox1.Controls.Add(this.GbTradeFlg);
            this.groupBox1.Location = new System.Drawing.Point(23, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 84);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // sflg
            // 
            this.sflg.AutoSize = true;
            this.sflg.Location = new System.Drawing.Point(281, 43);
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
            this.pflg.Location = new System.Drawing.Point(215, 43);
            this.pflg.Name = "pflg";
            this.pflg.Size = new System.Drawing.Size(59, 16);
            this.pflg.TabIndex = 9;
            this.pflg.TabStop = true;
            this.pflg.Text = "買注文";
            this.pflg.UseVisualStyleBackColor = true;
            // 
            // GbTradeFlg
            // 
            this.GbTradeFlg.Location = new System.Drawing.Point(215, 17);
            this.GbTradeFlg.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.GbTradeFlg.Name = "GbTradeFlg";
            this.GbTradeFlg.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.GbTradeFlg.Size = new System.Drawing.Size(117, 49);
            this.GbTradeFlg.TabIndex = 11;
            this.GbTradeFlg.TabStop = false;
            this.GbTradeFlg.Text = "売買選択";
            // 
            // MemoInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtSubmit);
            this.Controls.Add(this.TbMemoDetail);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "MemoInput";
            this.Text = "メモ登録画面";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbCustomerName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtCustomerSeach;
        private System.Windows.Forms.RichTextBox TbMemoDetail;
        private System.Windows.Forms.Button BtSubmit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton sflg;
        private System.Windows.Forms.RadioButton pflg;
        private System.Windows.Forms.GroupBox GbTradeFlg;
        private System.Windows.Forms.TextBox TbCustomerCode;
    }
}