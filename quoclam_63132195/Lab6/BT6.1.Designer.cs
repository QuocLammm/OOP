namespace Lab6
{
    partial class Form1
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
            this.lba = new System.Windows.Forms.Label();
            this.lbb = new System.Windows.Forms.Label();
            this.lbkq = new System.Windows.Forms.Label();
            this.btnS = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnM = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btncl = new System.Windows.Forms.Button();
            this.txta = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(213, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Các phép toán số học";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lba
            // 
            this.lba.AutoSize = true;
            this.lba.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lba.ForeColor = System.Drawing.Color.Blue;
            this.lba.Location = new System.Drawing.Point(127, 78);
            this.lba.Name = "lba";
            this.lba.Size = new System.Drawing.Size(85, 20);
            this.lba.TabIndex = 1;
            this.lba.Text = "Nhập số a";
            // 
            // lbb
            // 
            this.lbb.AutoSize = true;
            this.lbb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbb.ForeColor = System.Drawing.Color.Blue;
            this.lbb.Location = new System.Drawing.Point(130, 133);
            this.lbb.Name = "lbb";
            this.lbb.Size = new System.Drawing.Size(85, 20);
            this.lbb.TabIndex = 2;
            this.lbb.Text = "Nhập số b";
            // 
            // lbkq
            // 
            this.lbkq.AutoSize = true;
            this.lbkq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbkq.ForeColor = System.Drawing.Color.Blue;
            this.lbkq.Location = new System.Drawing.Point(133, 188);
            this.lbkq.Name = "lbkq";
            this.lbkq.Size = new System.Drawing.Size(66, 20);
            this.lbkq.TabIndex = 3;
            this.lbkq.Text = "Kết quả";
            // 
            // btnS
            // 
            this.btnS.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnS.ForeColor = System.Drawing.Color.Purple;
            this.btnS.Location = new System.Drawing.Point(41, 249);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(94, 50);
            this.btnS.TabIndex = 4;
            this.btnS.Text = "+";
            this.btnS.UseVisualStyleBackColor = false;
            this.btnS.Click += new System.EventHandler(this.btnS_Click_1);
            // 
            // btnD
            // 
            this.btnD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnD.ForeColor = System.Drawing.Color.Purple;
            this.btnD.Location = new System.Drawing.Point(155, 249);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(86, 49);
            this.btnD.TabIndex = 5;
            this.btnD.Text = "-";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnM
            // 
            this.btnM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnM.ForeColor = System.Drawing.Color.Purple;
            this.btnM.Location = new System.Drawing.Point(274, 249);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(82, 49);
            this.btnM.TabIndex = 6;
            this.btnM.Text = "*";
            this.btnM.UseVisualStyleBackColor = true;
            this.btnM.Click += new System.EventHandler(this.btnM_Click);
            // 
            // btnA
            // 
            this.btnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA.ForeColor = System.Drawing.Color.Purple;
            this.btnA.Location = new System.Drawing.Point(376, 249);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(82, 49);
            this.btnA.TabIndex = 7;
            this.btnA.Text = "/";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Purple;
            this.btnXoa.Location = new System.Drawing.Point(488, 249);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(78, 49);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "C";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btncl
            // 
            this.btncl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncl.ForeColor = System.Drawing.Color.Purple;
            this.btncl.Location = new System.Drawing.Point(589, 249);
            this.btncl.Name = "btncl";
            this.btncl.Size = new System.Drawing.Size(87, 49);
            this.btncl.TabIndex = 9;
            this.btncl.Text = "Close";
            this.btncl.UseVisualStyleBackColor = true;
            this.btncl.Click += new System.EventHandler(this.btncl_Click);
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(274, 71);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(208, 22);
            this.txta.TabIndex = 10;
            this.txta.TextChanged += new System.EventHandler(this.txta_TextChanged);
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(274, 126);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(208, 22);
            this.txtb.TabIndex = 11;
            // 
            // txtkq
            // 
            this.txtkq.Location = new System.Drawing.Point(274, 188);
            this.txtkq.Name = "txtkq";
            this.txtkq.ReadOnly = true;
            this.txtkq.Size = new System.Drawing.Size(208, 22);
            this.txtkq.TabIndex = 12;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(699, 381);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.btncl);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.btnM);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.lbkq);
            this.Controls.Add(this.lbb);
            this.Controls.Add(this.lba);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbla;
        private System.Windows.Forms.Label lblb;
        private System.Windows.Forms.Label lblc;
        private System.Windows.Forms.Button btnc;
        private System.Windows.Forms.Button btnt;
        private System.Windows.Forms.Button btnn;
        private System.Windows.Forms.Button btnchia;
        private System.Windows.Forms.Button btnx;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lba;
        private System.Windows.Forms.Label lbb;
        private System.Windows.Forms.Label lbkq;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnM;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btncl;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.TextBox txtkq;
    }
}

