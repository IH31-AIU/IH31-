﻿namespace IH31_CP_Projects
{
    partial class Top
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BtEstimateInput = new System.Windows.Forms.Button();
            this.BtMemoReceive = new System.Windows.Forms.Button();
            this.BtMemoInput = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(127, 120);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(856, 480);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BtEstimateInput);
            this.tabPage1.Controls.Add(this.BtMemoReceive);
            this.tabPage1.Controls.Add(this.BtMemoInput);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(848, 448);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "見積";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BtEstimateInput
            // 
            this.BtEstimateInput.Location = new System.Drawing.Point(33, 309);
            this.BtEstimateInput.Name = "BtEstimateInput";
            this.BtEstimateInput.Size = new System.Drawing.Size(232, 75);
            this.BtEstimateInput.TabIndex = 2;
            this.BtEstimateInput.Text = "見積書作成";
            this.BtEstimateInput.UseVisualStyleBackColor = true;
            // 
            // BtMemoReceive
            // 
            this.BtMemoReceive.Location = new System.Drawing.Point(33, 188);
            this.BtMemoReceive.Name = "BtMemoReceive";
            this.BtMemoReceive.Size = new System.Drawing.Size(232, 75);
            this.BtMemoReceive.TabIndex = 1;
            this.BtMemoReceive.Text = "メモ担当決定";
            this.BtMemoReceive.UseVisualStyleBackColor = true;
            // 
            // BtMemoInput
            // 
            this.BtMemoInput.Location = new System.Drawing.Point(33, 60);
            this.BtMemoInput.Name = "BtMemoInput";
            this.BtMemoInput.Size = new System.Drawing.Size(232, 75);
            this.BtMemoInput.TabIndex = 0;
            this.BtMemoInput.Text = "メモ登録";
            this.BtMemoInput.UseVisualStyleBackColor = true;
            this.BtMemoInput.Click += new System.EventHandler(this.BtMemoInput_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(848, 448);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "受注";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(35, 58);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(232, 75);
            this.button4.TabIndex = 1;
            this.button4.Text = "受注書作成";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button7);
            this.tabPage3.Controls.Add(this.button6);
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(848, 448);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "売買";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(35, 335);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(232, 75);
            this.button7.TabIndex = 6;
            this.button7.Text = "納品書作成";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(35, 200);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(232, 75);
            this.button6.TabIndex = 5;
            this.button6.Text = "出品票作成";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(35, 62);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(232, 75);
            this.button5.TabIndex = 3;
            this.button5.Text = "発注書作成";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(848, 448);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "請求";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 28);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(848, 448);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "回収";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 72);
            this.label1.TabIndex = 1;
            this.label1.Text = "スグクルシステム";
            // 
            // Top
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 640);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Top";
            this.Text = "Top";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtEstimateInput;
        private System.Windows.Forms.Button BtMemoReceive;
        private System.Windows.Forms.Button BtMemoInput;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TabPage tabPage5;
    }
}