namespace IH31_CP_Projects
{
    partial class MemoAll
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
            this.DvMemo = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TbCustomerName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DvMemo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(41, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "メモ一覧";
            // 
            // DvMemo
            // 
            this.DvMemo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.DvMemo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DvMemo.Location = new System.Drawing.Point(94, 224);
            this.DvMemo.Margin = new System.Windows.Forms.Padding(2);
            this.DvMemo.Name = "DvMemo";
            this.DvMemo.ReadOnly = true;
            this.DvMemo.RowTemplate.Height = 27;
            this.DvMemo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DvMemo.Size = new System.Drawing.Size(854, 352);
            this.DvMemo.TabIndex = 5;
            this.DvMemo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cell_doubleclick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtSubmit);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TbCustomerName);
            this.groupBox1.Location = new System.Drawing.Point(94, 86);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(845, 103);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            // 
            // BtSubmit
            // 
            this.BtSubmit.Location = new System.Drawing.Point(306, 41);
            this.BtSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.BtSubmit.Name = "BtSubmit";
            this.BtSubmit.Size = new System.Drawing.Size(118, 30);
            this.BtSubmit.TabIndex = 58;
            this.BtSubmit.Text = "検索";
            this.BtSubmit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 53;
            this.label1.Text = "顧客名";
            // 
            // TbCustomerName
            // 
            this.TbCustomerName.Location = new System.Drawing.Point(130, 44);
            this.TbCustomerName.Margin = new System.Windows.Forms.Padding(2);
            this.TbCustomerName.Name = "TbCustomerName";
            this.TbCustomerName.ReadOnly = true;
            this.TbCustomerName.Size = new System.Drawing.Size(102, 25);
            this.TbCustomerName.TabIndex = 54;
            // 
            // MemoAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 544);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DvMemo);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MemoAll";
            this.Text = "メモ一覧検索画面";
            ((System.ComponentModel.ISupportInitialize)(this.DvMemo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DvMemo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbCustomerName;
    }
}