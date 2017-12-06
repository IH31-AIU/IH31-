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
            this.btFileDialog.Margin = new System.Windows.Forms.Padding(2);
            this.btFileDialog.Name = "btFileDialog";
            this.btFileDialog.Size = new System.Drawing.Size(70, 20);
            this.btFileDialog.TabIndex = 59;
            this.btFileDialog.Text = "ファイルパス";
            this.btFileDialog.UseVisualStyleBackColor = true;
            this.btFileDialog.Click += new System.EventHandler(this.btFileDialog_Click);
            // 
            // dvCustomer
            // 
            this.dvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvCustomer.Location = new System.Drawing.Point(10, 91);
            this.dvCustomer.Name = "dvCustomer";
            this.dvCustomer.RowTemplate.Height = 21;
            this.dvCustomer.Size = new System.Drawing.Size(572, 208);
            this.dvCustomer.TabIndex = 65;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(387, 306);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
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
            this.tbFilePass.Margin = new System.Windows.Forms.Padding(2);
            this.tbFilePass.Name = "tbFilePass";
            this.tbFilePass.Size = new System.Drawing.Size(239, 19);
            this.tbFilePass.TabIndex = 58;
            // 
            // InvoiceClearingCSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 358);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dvCustomer);
            this.Controls.Add(this.btFileDialog);
            this.Controls.Add(this.tbFilePass);
            this.Margin = new System.Windows.Forms.Padding(2);
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
    }
}