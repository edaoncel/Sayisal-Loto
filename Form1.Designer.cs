namespace sayısal_loto
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblsayi1 = new System.Windows.Forms.Label();
            this.lblsayi2 = new System.Windows.Forms.Label();
            this.lblsayi3 = new System.Windows.Forms.Label();
            this.lblsayi4 = new System.Windows.Forms.Label();
            this.lblsayi5 = new System.Windows.Forms.Label();
            this.lblsayi6 = new System.Windows.Forms.Label();
            this.btnsonuc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblsayi1
            // 
            this.lblsayi1.AutoSize = true;
            this.lblsayi1.Location = new System.Drawing.Point(67, 109);
            this.lblsayi1.Name = "lblsayi1";
            this.lblsayi1.Size = new System.Drawing.Size(45, 20);
            this.lblsayi1.TabIndex = 0;
            this.lblsayi1.Text = "sayi1";
            // 
            // lblsayi2
            // 
            this.lblsayi2.AutoSize = true;
            this.lblsayi2.Location = new System.Drawing.Point(185, 109);
            this.lblsayi2.Name = "lblsayi2";
            this.lblsayi2.Size = new System.Drawing.Size(45, 20);
            this.lblsayi2.TabIndex = 1;
            this.lblsayi2.Text = "sayi2";
            // 
            // lblsayi3
            // 
            this.lblsayi3.AutoSize = true;
            this.lblsayi3.Location = new System.Drawing.Point(301, 109);
            this.lblsayi3.Name = "lblsayi3";
            this.lblsayi3.Size = new System.Drawing.Size(45, 20);
            this.lblsayi3.TabIndex = 2;
            this.lblsayi3.Text = "sayi3";
            // 
            // lblsayi4
            // 
            this.lblsayi4.AutoSize = true;
            this.lblsayi4.Location = new System.Drawing.Point(443, 109);
            this.lblsayi4.Name = "lblsayi4";
            this.lblsayi4.Size = new System.Drawing.Size(45, 20);
            this.lblsayi4.TabIndex = 3;
            this.lblsayi4.Text = "sayi4";
            // 
            // lblsayi5
            // 
            this.lblsayi5.AutoSize = true;
            this.lblsayi5.Location = new System.Drawing.Point(568, 109);
            this.lblsayi5.Name = "lblsayi5";
            this.lblsayi5.Size = new System.Drawing.Size(45, 20);
            this.lblsayi5.TabIndex = 4;
            this.lblsayi5.Text = "sayi6";
            // 
            // lblsayi6
            // 
            this.lblsayi6.AutoSize = true;
            this.lblsayi6.Location = new System.Drawing.Point(672, 109);
            this.lblsayi6.Name = "lblsayi6";
            this.lblsayi6.Size = new System.Drawing.Size(45, 20);
            this.lblsayi6.TabIndex = 5;
            this.lblsayi6.Text = "sayi6";
            // 
            // btnsonuc
            // 
            this.btnsonuc.Location = new System.Drawing.Point(332, 223);
            this.btnsonuc.Name = "btnsonuc";
            this.btnsonuc.Size = new System.Drawing.Size(90, 38);
            this.btnsonuc.TabIndex = 6;
            this.btnsonuc.Text = "sonuc";
            this.btnsonuc.UseVisualStyleBackColor = true;
            this.btnsonuc.Click += new System.EventHandler(this.btnsonuc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsonuc);
            this.Controls.Add(this.lblsayi6);
            this.Controls.Add(this.lblsayi5);
            this.Controls.Add(this.lblsayi4);
            this.Controls.Add(this.lblsayi3);
            this.Controls.Add(this.lblsayi2);
            this.Controls.Add(this.lblsayi1);
            this.Name = "Form1";
            this.Text = "form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsayi1;
        private System.Windows.Forms.Label lblsayi2;
        private System.Windows.Forms.Label lblsayi3;
        private System.Windows.Forms.Label lblsayi4;
        private System.Windows.Forms.Label lblsayi5;
        private System.Windows.Forms.Label lblsayi6;
        private System.Windows.Forms.Button btnsonuc;
    }
}

