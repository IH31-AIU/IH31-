namespace IH31_CP_Projects
{
    partial class InvoiceCrete
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
            this.BtSubmit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Datetime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.BtSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CreateNum = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtSubmit
            // 
            this.BtSubmit.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtSubmit.Location = new System.Drawing.Point(858, 554);
            this.BtSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.BtSubmit.Name = "BtSubmit";
            this.BtSubmit.Size = new System.Drawing.Size(328, 61);
            this.BtSubmit.TabIndex = 62;
            this.BtSubmit.Text = "請求書作成";
            this.BtSubmit.UseVisualStyleBackColor = true;
            this.BtSubmit.Click += new System.EventHandler(this.BtSubmit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(29, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(428, 48);
            this.label5.TabIndex = 68;
            this.label5.Text = "請求書/支払書作成";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Datetime);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BtSearch);
            this.groupBox1.Location = new System.Drawing.Point(37, 94);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(672, 114);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            // 
            // Datetime
            // 
            this.Datetime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Datetime.Location = new System.Drawing.Point(97, 25);
            this.Datetime.Name = "Datetime";
            this.Datetime.Size = new System.Drawing.Size(200, 25);
            this.Datetime.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "日付";
            // 
            // BtSearch
            // 
            this.BtSearch.Location = new System.Drawing.Point(347, 22);
            this.BtSearch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BtSearch.Name = "BtSearch";
            this.BtSearch.Size = new System.Drawing.Size(125, 34);
            this.BtSearch.TabIndex = 2;
            this.BtSearch.Text = "検索";
            this.BtSearch.UseVisualStyleBackColor = true;
            this.BtSearch.Click += new System.EventHandler(this.BtSearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 70;
            this.label4.Text = "企業数";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 71;
            this.label6.Text = "請求金額";
            // 
            // CreateNum
            // 
            this.CreateNum.AutoSize = true;
            this.CreateNum.Location = new System.Drawing.Point(280, 257);
            this.CreateNum.Name = "CreateNum";
            this.CreateNum.Size = new System.Drawing.Size(0, 18);
            this.CreateNum.TabIndex = 72;
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(280, 318);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(0, 18);
            this.price.TabIndex = 73;
            // 
            // InvoiceCrete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 544);
            this.Controls.Add(this.price);
            this.Controls.Add(this.CreateNum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtSubmit);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InvoiceCrete";
            this.Text = "請求書部分作成";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtSubmit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker Datetime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label CreateNum;
        private System.Windows.Forms.Label price;
    }
}