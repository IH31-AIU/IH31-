namespace IH31_CP_Projects
{
    partial class OrderForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.search = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btCreate = new System.Windows.Forms.Button();
            this.DvItem = new System.Windows.Forms.DataGridView();
            this.LbPrice = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DvItem)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.search);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(11, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 52);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(149, 17);
            this.search.Margin = new System.Windows.Forms.Padding(2);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(70, 20);
            this.search.TabIndex = 52;
            this.search.Text = "検索画面へ";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 24);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 49;
            this.label6.Text = "見積番号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 12);
            this.label3.TabIndex = 50;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(76, 19);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(62, 19);
            this.textBox1.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(5, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 33);
            this.label5.TabIndex = 64;
            this.label5.Text = "受注書作成";
            // 
            // btCreate
            // 
            this.btCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCreate.Location = new System.Drawing.Point(448, 358);
            this.btCreate.Margin = new System.Windows.Forms.Padding(2);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(70, 20);
            this.btCreate.TabIndex = 57;
            this.btCreate.Text = "作成";
            this.btCreate.UseVisualStyleBackColor = true;
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // DvItem
            // 
            this.DvItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DvItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DvItem.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.DvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DvItem.Location = new System.Drawing.Point(11, 104);
            this.DvItem.Name = "DvItem";
            this.DvItem.RowTemplate.Height = 21;
            this.DvItem.Size = new System.Drawing.Size(507, 224);
            this.DvItem.TabIndex = 65;
            this.DvItem.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.DvItem_CellStateChanged);
            this.DvItem.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DvItem_CellValueChanged);
            this.DvItem.CurrentCellDirtyStateChanged += new System.EventHandler(this.DvItem_CurrentCellDirtyStateChanged);
            // 
            // LbPrice
            // 
            this.LbPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LbPrice.AutoSize = true;
            this.LbPrice.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LbPrice.Location = new System.Drawing.Point(227, 349);
            this.LbPrice.Name = "LbPrice";
            this.LbPrice.Size = new System.Drawing.Size(107, 27);
            this.LbPrice.TabIndex = 66;
            this.LbPrice.Text = "合計0円";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 390);
            this.Controls.Add(this.LbPrice);
            this.Controls.Add(this.DvItem);
            this.Controls.Add(this.btCreate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DvItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btCreate;
        private System.Windows.Forms.DataGridView DvItem;
        private System.Windows.Forms.Label LbPrice;
    }
}