namespace IH31_CP_Projects
{
    partial class AuctionStatement
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
            this.DvAuction = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Datetime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.CbAuctionName = new System.Windows.Forms.ComboBox();
            this.BtSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DvAuction)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(7, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "オークション計算書入力画面";
            // 
            // DvAuction
            // 
            this.DvAuction.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu;
            this.DvAuction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DvAuction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DvAuction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.DvAuction.Location = new System.Drawing.Point(12, 153);
            this.DvAuction.Name = "DvAuction";
            this.DvAuction.RowTemplate.Height = 21;
            this.DvAuction.Size = new System.Drawing.Size(862, 356);
            this.DvAuction.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "明細ID";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "オークションNO";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "車名";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "年式";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "モデル";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "グレード";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "売買";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "金額";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "手数料";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "諸費用";
            this.Column11.Name = "Column11";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Datetime);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CbAuctionName);
            this.groupBox1.Controls.Add(this.BtSearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 76);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // Datetime
            // 
            this.Datetime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Datetime.Location = new System.Drawing.Point(114, 53);
            this.Datetime.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Datetime.Name = "Datetime";
            this.Datetime.Size = new System.Drawing.Size(122, 19);
            this.Datetime.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "日付";
            // 
            // CbAuctionName
            // 
            this.CbAuctionName.FormattingEnabled = true;
            this.CbAuctionName.Items.AddRange(new object[] {
            "オークション会場A",
            "オークション会場B",
            "オークション会場C"});
            this.CbAuctionName.Location = new System.Drawing.Point(114, 21);
            this.CbAuctionName.Name = "CbAuctionName";
            this.CbAuctionName.Size = new System.Drawing.Size(121, 20);
            this.CbAuctionName.TabIndex = 3;
            // 
            // BtSearch
            // 
            this.BtSearch.Location = new System.Drawing.Point(268, 48);
            this.BtSearch.Name = "BtSearch";
            this.BtSearch.Size = new System.Drawing.Size(75, 23);
            this.BtSearch.TabIndex = 2;
            this.BtSearch.Text = "検索";
            this.BtSearch.UseVisualStyleBackColor = true;
            this.BtSearch.Click += new System.EventHandler(this.BtSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "オークション会場";
            // 
            // BtSubmit
            // 
            this.BtSubmit.Location = new System.Drawing.Point(776, 513);
            this.BtSubmit.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.BtSubmit.Name = "BtSubmit";
            this.BtSubmit.Size = new System.Drawing.Size(98, 39);
            this.BtSubmit.TabIndex = 7;
            this.BtSubmit.Text = "登録";
            this.BtSubmit.UseVisualStyleBackColor = true;
            this.BtSubmit.Click += new System.EventHandler(this.BtSubmit_Click);
            // 
            // AuctionStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.BtSubmit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DvAuction);
            this.Controls.Add(this.groupBox1);
            this.Name = "AuctionStatement";
            this.Text = "オークション計算書入力画面";
            ((System.ComponentModel.ISupportInitialize)(this.DvAuction)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DvAuction;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbAuctionName;
        private System.Windows.Forms.DateTimePicker Datetime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtSubmit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
    }
}