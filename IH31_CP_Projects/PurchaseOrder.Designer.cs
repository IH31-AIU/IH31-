namespace IH31_CP_Projects
{
    partial class PurchaseOrder
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
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.auctionList = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closeBt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.auctionList)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(596, 425);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 32);
            this.button2.TabIndex = 65;
            this.button2.Text = "作成";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(7, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 40);
            this.label5.TabIndex = 68;
            this.label5.Text = "発注書作成";
            // 
            // auctionList
            // 
            this.auctionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.auctionList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Column2});
            this.auctionList.Location = new System.Drawing.Point(15, 46);
            this.auctionList.Margin = new System.Windows.Forms.Padding(4);
            this.auctionList.Name = "auctionList";
            this.auctionList.RowTemplate.Height = 21;
            this.auctionList.Size = new System.Drawing.Size(681, 372);
            this.auctionList.TabIndex = 69;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "選択";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column3.Width = 80;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "オークション会場";
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "件数";
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // closeBt
            // 
            this.closeBt.Location = new System.Drawing.Point(15, 424);
            this.closeBt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closeBt.Name = "closeBt";
            this.closeBt.Size = new System.Drawing.Size(100, 32);
            this.closeBt.TabIndex = 70;
            this.closeBt.Text = "閉じる";
            this.closeBt.UseVisualStyleBackColor = true;
            this.closeBt.Click += new System.EventHandler(this.closeBt_Click);
            // 
            // PurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 471);
            this.Controls.Add(this.closeBt);
            this.Controls.Add(this.auctionList);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PurchaseOrder";
            this.Text = "PurchaseOrder";
            ((System.ComponentModel.ISupportInitialize)(this.auctionList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView auctionList;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button closeBt;
    }
}