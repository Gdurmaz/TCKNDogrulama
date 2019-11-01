namespace Project.UI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKontrolEt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDogum = new System.Windows.Forms.TextBox();
            this.tbSoyad = new System.Windows.Forms.TextBox();
            this.tbAd = new System.Windows.Forms.TextBox();
            this.tbTCKN = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnKontrolEt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbDogum);
            this.panel1.Controls.Add(this.tbSoyad);
            this.panel1.Controls.Add(this.tbAd);
            this.panel1.Controls.Add(this.tbTCKN);
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 212);
            this.panel1.TabIndex = 0;
            // 
            // btnKontrolEt
            // 
            this.btnKontrolEt.Location = new System.Drawing.Point(87, 158);
            this.btnKontrolEt.Name = "btnKontrolEt";
            this.btnKontrolEt.Size = new System.Drawing.Size(105, 23);
            this.btnKontrolEt.TabIndex = 0;
            this.btnKontrolEt.Text = "Kontrol Et";
            this.btnKontrolEt.UseVisualStyleBackColor = true;
            this.btnKontrolEt.Click += new System.EventHandler(this.btnKontrolEt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Doğum Yılı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "TCKN";
            // 
            // tbDogum
            // 
            this.tbDogum.Location = new System.Drawing.Point(87, 123);
            this.tbDogum.MaxLength = 4;
            this.tbDogum.Name = "tbDogum";
            this.tbDogum.Size = new System.Drawing.Size(105, 20);
            this.tbDogum.TabIndex = 0;
            this.tbDogum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTCKN_KeyPress);
            // 
            // tbSoyad
            // 
            this.tbSoyad.Location = new System.Drawing.Point(87, 90);
            this.tbSoyad.Name = "tbSoyad";
            this.tbSoyad.Size = new System.Drawing.Size(105, 20);
            this.tbSoyad.TabIndex = 0;
            this.tbSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAd_KeyPress);
            // 
            // tbAd
            // 
            this.tbAd.Location = new System.Drawing.Point(87, 53);
            this.tbAd.Name = "tbAd";
            this.tbAd.Size = new System.Drawing.Size(105, 20);
            this.tbAd.TabIndex = 0;
            this.tbAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAd_KeyPress);
            // 
            // tbTCKN
            // 
            this.tbTCKN.Location = new System.Drawing.Point(87, 17);
            this.tbTCKN.MaxLength = 11;
            this.tbTCKN.Name = "tbTCKN";
            this.tbTCKN.Size = new System.Drawing.Size(105, 20);
            this.tbTCKN.TabIndex = 0;
            this.tbTCKN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTCKN_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 218);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "T.C. Kimlik Kontrol";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKontrolEt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDogum;
        private System.Windows.Forms.TextBox tbSoyad;
        private System.Windows.Forms.TextBox tbAd;
        private System.Windows.Forms.TextBox tbTCKN;
    }
}

