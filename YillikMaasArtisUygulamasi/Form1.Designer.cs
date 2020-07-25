namespace YillikMaasArtisUygulamasi
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
            this.dudMaas = new System.Windows.Forms.DomainUpDown();
            this.dudYillikArtis = new System.Windows.Forms.DomainUpDown();
            this.dudVadesi = new System.Windows.Forms.DomainUpDown();
            this.lblMaas = new System.Windows.Forms.Label();
            this.lblYillikArtis = new System.Windows.Forms.Label();
            this.lblVadesi = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dudMaas
            // 
            this.dudMaas.Location = new System.Drawing.Point(164, 57);
            this.dudMaas.Name = "dudMaas";
            this.dudMaas.Size = new System.Drawing.Size(120, 22);
            this.dudMaas.TabIndex = 0;
            this.dudMaas.SelectedItemChanged += new System.EventHandler(this.dudMaas_SelectedItemChanged);
            // 
            // dudYillikArtis
            // 
            this.dudYillikArtis.Location = new System.Drawing.Point(164, 124);
            this.dudYillikArtis.Name = "dudYillikArtis";
            this.dudYillikArtis.Size = new System.Drawing.Size(120, 22);
            this.dudYillikArtis.TabIndex = 1;
            // 
            // dudVadesi
            // 
            this.dudVadesi.Location = new System.Drawing.Point(164, 189);
            this.dudVadesi.Name = "dudVadesi";
            this.dudVadesi.Size = new System.Drawing.Size(120, 22);
            this.dudVadesi.TabIndex = 2;
            // 
            // lblMaas
            // 
            this.lblMaas.AutoSize = true;
            this.lblMaas.Location = new System.Drawing.Point(49, 62);
            this.lblMaas.Name = "lblMaas";
            this.lblMaas.Size = new System.Drawing.Size(83, 17);
            this.lblMaas.TabIndex = 3;
            this.lblMaas.Text = "Maaş Tutarı";
            // 
            // lblYillikArtis
            // 
            this.lblYillikArtis.AutoSize = true;
            this.lblYillikArtis.Location = new System.Drawing.Point(49, 129);
            this.lblYillikArtis.Name = "lblYillikArtis";
            this.lblYillikArtis.Size = new System.Drawing.Size(107, 17);
            this.lblYillikArtis.TabIndex = 4;
            this.lblYillikArtis.Text = "Yıllık Artış Oranı";
            // 
            // lblVadesi
            // 
            this.lblVadesi.AutoSize = true;
            this.lblVadesi.Location = new System.Drawing.Point(49, 191);
            this.lblVadesi.Name = "lblVadesi";
            this.lblVadesi.Size = new System.Drawing.Size(103, 17);
            this.lblVadesi.TabIndex = 5;
            this.lblVadesi.Text = "Kaç Yıl Sonrası";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(178, 260);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 23);
            this.btnHesapla.TabIndex = 6;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 384);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.lblVadesi);
            this.Controls.Add(this.lblYillikArtis);
            this.Controls.Add(this.lblMaas);
            this.Controls.Add(this.dudVadesi);
            this.Controls.Add(this.dudYillikArtis);
            this.Controls.Add(this.dudMaas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DomainUpDown dudMaas;
        private System.Windows.Forms.DomainUpDown dudYillikArtis;
        private System.Windows.Forms.DomainUpDown dudVadesi;
        private System.Windows.Forms.Label lblMaas;
        private System.Windows.Forms.Label lblYillikArtis;
        private System.Windows.Forms.Label lblVadesi;
        private System.Windows.Forms.Button btnHesapla;
    }
}

