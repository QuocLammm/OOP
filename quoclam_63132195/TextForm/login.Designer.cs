using System;

namespace TextForm
{
    partial class login
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
            this.btnDangnhap = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblten = new System.Windows.Forms.Label();
            this.lblmatkhau = new System.Windows.Forms.Label();
            this.txtten = new System.Windows.Forms.TextBox();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.Location = new System.Drawing.Point(208, 192);
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.Size = new System.Drawing.Size(153, 53);
            this.btnDangnhap.TabIndex = 0;
            this.btnDangnhap.Text = "Đăng nhập";
            this.btnDangnhap.UseVisualStyleBackColor = true;
            this.btnDangnhap.Click += new System.EventHandler(this.btnDangnhap_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(418, 192);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(146, 53);
            this.btnDong.TabIndex = 1;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Đăng nhập";
            this.label1.Click += new System.EventHandler(this.lblten_Click);
            // 
            // lblten
            // 
            this.lblten.AutoSize = true;
            this.lblten.Location = new System.Drawing.Point(218, 73);
            this.lblten.Name = "lblten";
            this.lblten.Size = new System.Drawing.Size(31, 16);
            this.lblten.TabIndex = 3;
            this.lblten.Text = "Tên";
            // 
            // lblmatkhau
            // 
            this.lblmatkhau.AutoSize = true;
            this.lblmatkhau.Location = new System.Drawing.Point(205, 123);
            this.lblmatkhau.Name = "lblmatkhau";
            this.lblmatkhau.Size = new System.Drawing.Size(61, 16);
            this.lblmatkhau.TabIndex = 4;
            this.lblmatkhau.Text = "Mật khẩu";
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(309, 70);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(167, 22);
            this.txtten.TabIndex = 5;
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(309, 120);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new System.Drawing.Size(167, 22);
            this.txtmatkhau.TabIndex = 6;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtmatkhau);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.lblmatkhau);
            this.Controls.Add(this.lblten);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnDangnhap);
            this.Name = "login";
            this.Text = "login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDangnhap;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblten;
        private System.Windows.Forms.Label lblmatkhau;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.TextBox txtmatkhau;
        private EventHandler lblten_Click;
    }
}