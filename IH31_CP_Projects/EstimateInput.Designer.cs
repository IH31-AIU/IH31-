﻿namespace IH31_CP_Projects
{
    partial class EstimateInput
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
            this.label5 = new System.Windows.Forms.Label();
            this.BtMemoSearch = new System.Windows.Forms.Button();
            this.TbMemo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TbCusName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TbEmpName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtAddEst = new System.Windows.Forms.Button();
            this.BtSubmit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DvEst = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DvEst)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(9, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 40);
            this.label5.TabIndex = 42;
            this.label5.Text = "見積書作成";
            // 
            // BtMemoSearch
            // 
            this.BtMemoSearch.Location = new System.Drawing.Point(303, 36);
            this.BtMemoSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtMemoSearch.Name = "BtMemoSearch";
            this.BtMemoSearch.Size = new System.Drawing.Size(93, 25);
            this.BtMemoSearch.TabIndex = 52;
            this.BtMemoSearch.Text = "検索画面へ";
            this.BtMemoSearch.UseVisualStyleBackColor = true;
            this.BtMemoSearch.Click += new System.EventHandler(this.BtMemoSearch_Click);
            // 
            // TbMemo
            // 
            this.TbMemo.Location = new System.Drawing.Point(161, 39);
            this.TbMemo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TbMemo.Name = "TbMemo";
            this.TbMemo.ReadOnly = true;
            this.TbMemo.Size = new System.Drawing.Size(116, 22);
            this.TbMemo.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 49;
            this.label6.Text = "メモ番号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 53;
            this.label1.Text = "顧客名";
            // 
            // TbCusName
            // 
            this.TbCusName.Location = new System.Drawing.Point(161, 90);
            this.TbCusName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TbCusName.Name = "TbCusName";
            this.TbCusName.ReadOnly = true;
            this.TbCusName.Size = new System.Drawing.Size(116, 22);
            this.TbCusName.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 55;
            this.label2.Text = "担当者名";
            // 
            // TbEmpName
            // 
            this.TbEmpName.Location = new System.Drawing.Point(395, 92);
            this.TbEmpName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TbEmpName.Name = "TbEmpName";
            this.TbEmpName.ReadOnly = true;
            this.TbEmpName.Size = new System.Drawing.Size(100, 22);
            this.TbEmpName.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 57;
            this.label4.Text = "見積明細";
            // 
            // BtAddEst
            // 
            this.BtAddEst.Location = new System.Drawing.Point(161, 131);
            this.BtAddEst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtAddEst.Name = "BtAddEst";
            this.BtAddEst.Size = new System.Drawing.Size(93, 25);
            this.BtAddEst.TabIndex = 58;
            this.BtAddEst.Text = "追加画面へ";
            this.BtAddEst.UseVisualStyleBackColor = true;
            this.BtAddEst.Click += new System.EventHandler(this.BtAddEst_Click);
            // 
            // BtSubmit
            // 
            this.BtSubmit.Location = new System.Drawing.Point(1063, 638);
            this.BtSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtSubmit.Name = "BtSubmit";
            this.BtSubmit.Size = new System.Drawing.Size(101, 51);
            this.BtSubmit.TabIndex = 60;
            this.BtSubmit.Text = "登録";
            this.BtSubmit.UseVisualStyleBackColor = true;
            this.BtSubmit.Click += new System.EventHandler(this.BtSubmit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtMemoSearch);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.BtAddEst);
            this.groupBox1.Controls.Add(this.TbMemo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TbEmpName);
            this.groupBox1.Controls.Add(this.TbCusName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(49, 78);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1113, 169);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            // 
            // DvEst
            // 
            this.DvEst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DvEst.Location = new System.Drawing.Point(49, 252);
            this.DvEst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DvEst.Name = "DvEst";
            this.DvEst.RowTemplate.Height = 27;
            this.DvEst.Size = new System.Drawing.Size(1115, 380);
            this.DvEst.TabIndex = 62;
            // 
            // EstimateInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 702);
            this.Controls.Add(this.DvEst);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtSubmit);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EstimateInput";
            this.Text = "見積書作成画面";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DvEst)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtMemoSearch;
        private System.Windows.Forms.TextBox TbMemo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbCusName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbEmpName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtAddEst;
        private System.Windows.Forms.Button BtSubmit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DvEst;
    }
}