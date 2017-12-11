namespace IH31_CP_Projects
{
    partial class Listing
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
            this.ListingCreateBt = new System.Windows.Forms.Button();
            this.auctionList = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.auctionList)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(7, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "出品票作成";
            // 
            // ListingCreateBt
            // 
            this.ListingCreateBt.Location = new System.Drawing.Point(797, 527);
            this.ListingCreateBt.Name = "ListingCreateBt";
            this.ListingCreateBt.Size = new System.Drawing.Size(75, 23);
            this.ListingCreateBt.TabIndex = 7;
            this.ListingCreateBt.Text = "作成";
            this.ListingCreateBt.UseVisualStyleBackColor = true;
            this.ListingCreateBt.Click += new System.EventHandler(this.ListingCreateBt_Click);
            // 
            // auctionList
            // 
            this.auctionList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.auctionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.auctionList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Column2});
            this.auctionList.Location = new System.Drawing.Point(10, 40);
            this.auctionList.Name = "auctionList";
            this.auctionList.RowTemplate.Height = 21;
            this.auctionList.Size = new System.Drawing.Size(862, 481);
            this.auctionList.TabIndex = 70;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "選択";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "オークション会場";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "件数";
            this.Column2.Name = "Column2";
            // 
            // Listing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.auctionList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ListingCreateBt);
            this.Name = "Listing";
            this.Text = "出品票作成画面";
            ((System.ComponentModel.ISupportInitialize)(this.auctionList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ListingCreateBt;
        private System.Windows.Forms.DataGridView auctionList;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}