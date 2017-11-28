namespace IH31_CP_Projects
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DtMemo = new System.Windows.Forms.DateTimePicker();
            this.TbCustomerCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TbCustomerName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtCustomerSeach = new System.Windows.Forms.Button();
            this.TbMemoDetail = new System.Windows.Forms.RichTextBox();
            this.BtSubmit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.GbTradeFlg = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "日付";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "顧客コード";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 18);
            this.label3.TabIndex = 2;
            // 
            // DtMemo
            // 
            this.DtMemo.Location = new System.Drawing.Point(122, 30);
            this.DtMemo.Name = "DtMemo";
            this.DtMemo.Size = new System.Drawing.Size(201, 25);
            this.DtMemo.TabIndex = 3;
            // 
            // TbCustomerCode
            // 
            this.TbCustomerCode.Location = new System.Drawing.Point(122, 68);
            this.TbCustomerCode.Name = "TbCustomerCode";
            this.TbCustomerCode.Size = new System.Drawing.Size(101, 25);
            this.TbCustomerCode.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "顧客名";
            // 
            // TbCustomerName
            // 
            this.TbCustomerName.Location = new System.Drawing.Point(122, 108);
            this.TbCustomerName.Name = "TbCustomerName";
            this.TbCustomerName.Size = new System.Drawing.Size(101, 25);
            this.TbCustomerName.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(23, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 48);
            this.label5.TabIndex = 7;
            this.label5.Text = "メモ登録";
            // 
            // BtCustomerSeach
            // 
            this.BtCustomerSeach.Location = new System.Drawing.Point(245, 64);
            this.BtCustomerSeach.Name = "BtCustomerSeach";
            this.BtCustomerSeach.Size = new System.Drawing.Size(77, 30);
            this.BtCustomerSeach.TabIndex = 8;
            this.BtCustomerSeach.Text = "検索";
            this.BtCustomerSeach.UseVisualStyleBackColor = true;
            this.BtCustomerSeach.Click += new System.EventHandler(this.BtCustomerSeach_Click);
            // 
            // TbMemoDetail
            // 
            this.TbMemoDetail.Location = new System.Drawing.Point(38, 268);
            this.TbMemoDetail.Name = "TbMemoDetail";
            this.TbMemoDetail.Size = new System.Drawing.Size(882, 274);
            this.TbMemoDetail.TabIndex = 9;
            this.TbMemoDetail.Text = "";
            // 
            // BtSubmit
            // 
            this.BtSubmit.Location = new System.Drawing.Point(808, 549);
            this.BtSubmit.Name = "BtSubmit";
            this.BtSubmit.Size = new System.Drawing.Size(112, 58);
            this.BtSubmit.TabIndex = 10;
            this.BtSubmit.Text = "登録";
            this.BtSubmit.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "メモ詳細";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.DtMemo);
            this.groupBox1.Controls.Add(this.BtCustomerSeach);
            this.groupBox1.Controls.Add(this.TbCustomerCode);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TbCustomerName);
            this.groupBox1.Controls.Add(this.GbTradeFlg);
            this.groupBox1.Location = new System.Drawing.Point(33, 74);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(795, 150);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(460, 108);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(87, 22);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "売注文";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(352, 108);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(87, 22);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "買注文";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // GbTradeFlg
            // 
            this.GbTradeFlg.Location = new System.Drawing.Point(352, 68);
            this.GbTradeFlg.Name = "GbTradeFlg";
            this.GbTradeFlg.Size = new System.Drawing.Size(195, 75);
            this.GbTradeFlg.TabIndex = 11;
            this.GbTradeFlg.TabStop = false;
            this.GbTradeFlg.Text = "売買選択";
            // 
            // MemoInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 618);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtSubmit);
            this.Controls.Add(this.TbMemoDetail);
            this.Controls.Add(this.label5);
            this.Name = "MemoInput";
            this.Text = "MemoInput";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DtMemo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbCustomerName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtCustomerSeach;
        private System.Windows.Forms.RichTextBox TbMemoDetail;
        private System.Windows.Forms.Button BtSubmit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox GbTradeFlg;
        private System.Windows.Forms.TextBox TbCustomerCode;
    }
}