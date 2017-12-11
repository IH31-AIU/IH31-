namespace IH31_CP_Projects
{
    partial class DelivaryNote
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
            this.deliveryCreateBt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.carList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtCustomerSeach = new System.Windows.Forms.Button();
            this.TbCustomerCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TbCustomerName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.carList)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // deliveryCreateBt
            // 
            this.deliveryCreateBt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deliveryCreateBt.Location = new System.Drawing.Point(798, 537);
            this.deliveryCreateBt.Name = "deliveryCreateBt";
            this.deliveryCreateBt.Size = new System.Drawing.Size(75, 23);
            this.deliveryCreateBt.TabIndex = 17;
            this.deliveryCreateBt.Text = "作成";
            this.deliveryCreateBt.UseVisualStyleBackColor = true;
            this.deliveryCreateBt.Click += new System.EventHandler(this.deliveryCreateBt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(7, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 27);
            this.label2.TabIndex = 16;
            this.label2.Text = "納品書作成";
            // 
            // carList
            // 
            this.carList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.carList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.carList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column5,
            this.Column4,
            this.Column3,
            this.Column2});
            this.carList.Location = new System.Drawing.Point(12, 147);
            this.carList.Name = "carList";
            this.carList.RowTemplate.Height = 21;
            this.carList.Size = new System.Drawing.Size(861, 384);
            this.carList.TabIndex = 15;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "車名";
            this.Column1.Name = "Column1";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "落札価格";
            this.Column5.Name = "Column5";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "手数料";
            this.Column4.Name = "Column4";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "諸費用料金";
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "小計";
            this.Column2.Name = "Column2";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.BtCustomerSeach);
            this.groupBox2.Controls.Add(this.TbCustomerCode);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TbCustomerName);
            this.groupBox2.Location = new System.Drawing.Point(12, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(861, 73);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "顧客コード";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 53);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 12);
            this.label5.TabIndex = 2;
            // 
            // BtCustomerSeach
            // 
            this.BtCustomerSeach.Location = new System.Drawing.Point(151, 13);
            this.BtCustomerSeach.Margin = new System.Windows.Forms.Padding(1);
            this.BtCustomerSeach.Name = "BtCustomerSeach";
            this.BtCustomerSeach.Size = new System.Drawing.Size(47, 20);
            this.BtCustomerSeach.TabIndex = 8;
            this.BtCustomerSeach.Text = "検索";
            this.BtCustomerSeach.UseVisualStyleBackColor = true;
            this.BtCustomerSeach.Click += new System.EventHandler(this.BtCustomerSeach_Click);
            // 
            // TbCustomerCode
            // 
            this.TbCustomerCode.Location = new System.Drawing.Point(77, 17);
            this.TbCustomerCode.Margin = new System.Windows.Forms.Padding(1);
            this.TbCustomerCode.Name = "TbCustomerCode";
            this.TbCustomerCode.ReadOnly = true;
            this.TbCustomerCode.Size = new System.Drawing.Size(63, 19);
            this.TbCustomerCode.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 45);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "顧客名";
            // 
            // TbCustomerName
            // 
            this.TbCustomerName.Location = new System.Drawing.Point(77, 43);
            this.TbCustomerName.Margin = new System.Windows.Forms.Padding(1);
            this.TbCustomerName.Name = "TbCustomerName";
            this.TbCustomerName.ReadOnly = true;
            this.TbCustomerName.Size = new System.Drawing.Size(63, 19);
            this.TbCustomerName.TabIndex = 6;
            // 
            // DelivaryNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deliveryCreateBt);
            this.Controls.Add(this.carList);
            this.Name = "DelivaryNote";
            this.Text = "納品書作成";
            ((System.ComponentModel.ISupportInitialize)(this.carList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button deliveryCreateBt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView carList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtCustomerSeach;
        private System.Windows.Forms.TextBox TbCustomerCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TbCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}