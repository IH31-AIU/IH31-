namespace IH31_CP_Projects
{
    partial class InvoiceClearingCSV
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
            this.btFileDialog = new System.Windows.Forms.Button();
            this.dvCustomer = new System.Windows.Forms.DataGridView();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_verid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mail_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formal_company_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abb_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kana_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.credit_limit_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.financial_facility_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branch_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deposit_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bank_account_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.account_holder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbFilePass = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // btFileDialog
            // 
            this.btFileDialog.Location = new System.Drawing.Point(257, 66);
            this.btFileDialog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btFileDialog.Name = "btFileDialog";
            this.btFileDialog.Size = new System.Drawing.Size(70, 20);
            this.btFileDialog.TabIndex = 59;
            this.btFileDialog.Text = "ファイルパス";
            this.btFileDialog.UseVisualStyleBackColor = true;
            this.btFileDialog.Click += new System.EventHandler(this.btFileDialog_Click);
            // 
            // dvCustomer
            // 
            this.dvCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.price,
            this.customer_id,
            this.customer_verid,
            this.mail_address,
            this.formal_company_name,
            this.abb_name,
            this.kana_name,
            this.Phone_number,
            this.address,
            this.credit_limit_price,
            this.financial_facility_name,
            this.branch_name,
            this.deposit_type,
            this.bank_account_number,
            this.account_holder});
            this.dvCustomer.Location = new System.Drawing.Point(10, 91);
            this.dvCustomer.Name = "dvCustomer";
            this.dvCustomer.RowTemplate.Height = 21;
            this.dvCustomer.Size = new System.Drawing.Size(862, 412);
            this.dvCustomer.TabIndex = 65;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "振り込み金額";
            this.price.Name = "price";
            // 
            // customer_id
            // 
            this.customer_id.DataPropertyName = "customer_id";
            this.customer_id.HeaderText = "顧客ID";
            this.customer_id.Name = "customer_id";
            // 
            // customer_verid
            // 
            this.customer_verid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.customer_verid.DataPropertyName = "customer_verid";
            this.customer_verid.HeaderText = "顧客verID";
            this.customer_verid.Name = "customer_verid";
            // 
            // mail_address
            // 
            this.mail_address.DataPropertyName = "mail_address";
            this.mail_address.HeaderText = "メール";
            this.mail_address.Name = "mail_address";
            // 
            // formal_company_name
            // 
            this.formal_company_name.DataPropertyName = "formal_company_name";
            this.formal_company_name.HeaderText = "正式会社名";
            this.formal_company_name.Name = "formal_company_name";
            // 
            // abb_name
            // 
            this.abb_name.DataPropertyName = "abb_name";
            this.abb_name.HeaderText = "略名";
            this.abb_name.Name = "abb_name";
            // 
            // kana_name
            // 
            this.kana_name.DataPropertyName = "kana_name";
            this.kana_name.HeaderText = "カナ会社名";
            this.kana_name.Name = "kana_name";
            // 
            // Phone_number
            // 
            this.Phone_number.DataPropertyName = "Phone_number";
            this.Phone_number.HeaderText = "電話番号";
            this.Phone_number.Name = "Phone_number";
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "住所";
            this.address.Name = "address";
            // 
            // credit_limit_price
            // 
            this.credit_limit_price.DataPropertyName = "credit_limit_price";
            this.credit_limit_price.HeaderText = "与信上限金額";
            this.credit_limit_price.Name = "credit_limit_price";
            // 
            // financial_facility_name
            // 
            this.financial_facility_name.DataPropertyName = "financial_facility_name";
            this.financial_facility_name.HeaderText = "支店名";
            this.financial_facility_name.Name = "financial_facility_name";
            // 
            // branch_name
            // 
            this.branch_name.DataPropertyName = "branch_name";
            this.branch_name.HeaderText = "銀行名";
            this.branch_name.Name = "branch_name";
            // 
            // deposit_type
            // 
            this.deposit_type.DataPropertyName = "deposit_type";
            this.deposit_type.HeaderText = "口座タイプ";
            this.deposit_type.Name = "deposit_type";
            // 
            // bank_account_number
            // 
            this.bank_account_number.DataPropertyName = "bank_account_number";
            this.bank_account_number.HeaderText = "口座番号";
            this.bank_account_number.Name = "bank_account_number";
            // 
            // account_holder
            // 
            this.account_holder.DataPropertyName = "account_holder";
            this.account_holder.HeaderText = "あああ";
            this.account_holder.Name = "account_holder";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(677, 510);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 41);
            this.button1.TabIndex = 66;
            this.button1.Text = "消込完了";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(8, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 33);
            this.label5.TabIndex = 67;
            this.label5.Text = "請求消込画面";
            // 
            // tbFilePass
            // 
            this.tbFilePass.Location = new System.Drawing.Point(14, 67);
            this.tbFilePass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbFilePass.Name = "tbFilePass";
            this.tbFilePass.Size = new System.Drawing.Size(239, 19);
            this.tbFilePass.TabIndex = 58;
            // 
            // InvoiceClearingCSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dvCustomer);
            this.Controls.Add(this.btFileDialog);
            this.Controls.Add(this.tbFilePass);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "InvoiceClearingCSV";
            this.Text = "請求消込画面";
            ((System.ComponentModel.ISupportInitialize)(this.dvCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btFileDialog;
        private System.Windows.Forms.DataGridView dvCustomer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbFilePass;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_verid;
        private System.Windows.Forms.DataGridViewTextBoxColumn mail_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn formal_company_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn abb_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn kana_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn credit_limit_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn financial_facility_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn branch_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn deposit_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn bank_account_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn account_holder;
    }
}