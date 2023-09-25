namespace WindowsFormsApp2
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
            this.lbla = new System.Windows.Forms.Label();
            this.lblb = new System.Windows.Forms.Label();
            this.lblkq = new System.Windows.Forms.Label();
            this.Text = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txta = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.txtketqua = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbla
            // 
            this.lbla.AutoSize = true;
            this.lbla.Location = new System.Drawing.Point(220, 80);
            this.lbla.Name = "lbla";
            this.lbla.Size = new System.Drawing.Size(72, 16);
            this.lbla.TabIndex = 0;
            this.lbla.Text = "Nhập số a:";
            // 
            // lblb
            // 
            this.lblb.AutoSize = true;
            this.lblb.Location = new System.Drawing.Point(223, 126);
            this.lblb.Name = "lblb";
            this.lblb.Size = new System.Drawing.Size(72, 16);
            this.lblb.TabIndex = 1;
            this.lblb.Text = "Nhập số b:";
            // 
            // lblkq
            // 
            this.lblkq.AutoSize = true;
            this.lblkq.Location = new System.Drawing.Point(223, 180);
            this.lblkq.Name = "lblkq";
            this.lblkq.Size = new System.Drawing.Size(55, 16);
            this.lblkq.TabIndex = 2;
            this.lblkq.Text = "Kết quả:";
            // 
            // Text
            // 
            this.Text.Location = new System.Drawing.Point(226, 233);
            this.Text.Name = "Text";
            this.Text.Size = new System.Drawing.Size(75, 40);
            this.Text.TabIndex = 3;
            this.Text.Text = "Giải";
            this.Text.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(386, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 40);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(331, 80);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(169, 22);
            this.txta.TabIndex = 5;
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(331, 120);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(169, 22);
            this.txtb.TabIndex = 6;
            // 
            // txtketqua
            // 
            this.txtketqua.Location = new System.Drawing.Point(331, 174);
            this.txtketqua.Name = "txtketqua";
            this.txtketqua.Size = new System.Drawing.Size(169, 22);
            this.txtketqua.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtketqua);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Text);
            this.Controls.Add(this.lblkq);
            this.Controls.Add(this.lblb);
            this.Controls.Add(this.lbla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbla;
        private System.Windows.Forms.Label lblb;
        private System.Windows.Forms.Label lblkq;
        private System.Windows.Forms.Button Text;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.TextBox txtketqua;
    }
}

