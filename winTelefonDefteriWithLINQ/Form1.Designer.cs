namespace winTelefonDefteriWithLINQ
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstKisiler = new System.Windows.Forms.ListBox();
            this.grpArama = new System.Windows.Forms.GroupBox();
            this.grpGuncelle = new System.Windows.Forms.GroupBox();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.rdbBaslar = new System.Windows.Forms.RadioButton();
            this.rdbIcerir = new System.Windows.Forms.RadioButton();
            this.grpArama.SuspendLayout();
            this.grpGuncelle.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kişiler";
            // 
            // lstKisiler
            // 
            this.lstKisiler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstKisiler.FormattingEnabled = true;
            this.lstKisiler.ItemHeight = 16;
            this.lstKisiler.Location = new System.Drawing.Point(12, 28);
            this.lstKisiler.Name = "lstKisiler";
            this.lstKisiler.Size = new System.Drawing.Size(177, 308);
            this.lstKisiler.TabIndex = 0;
            this.lstKisiler.SelectedIndexChanged += new System.EventHandler(this.lstKisiler_SelectedIndexChanged);
            // 
            // grpArama
            // 
            this.grpArama.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpArama.Controls.Add(this.rdbIcerir);
            this.grpArama.Controls.Add(this.rdbBaslar);
            this.grpArama.Controls.Add(this.txtArama);
            this.grpArama.Controls.Add(this.label2);
            this.grpArama.Location = new System.Drawing.Point(195, 28);
            this.grpArama.Name = "grpArama";
            this.grpArama.Size = new System.Drawing.Size(200, 77);
            this.grpArama.TabIndex = 2;
            this.grpArama.TabStop = false;
            this.grpArama.Text = "Arama";
            // 
            // grpGuncelle
            // 
            this.grpGuncelle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpGuncelle.Controls.Add(this.btnKaydet);
            this.grpGuncelle.Controls.Add(this.btnSil);
            this.grpGuncelle.Controls.Add(this.btnEkle);
            this.grpGuncelle.Controls.Add(this.txtTel);
            this.grpGuncelle.Controls.Add(this.label5);
            this.grpGuncelle.Controls.Add(this.txtSoyad);
            this.grpGuncelle.Controls.Add(this.label4);
            this.grpGuncelle.Controls.Add(this.txtAd);
            this.grpGuncelle.Controls.Add(this.label3);
            this.grpGuncelle.Location = new System.Drawing.Point(195, 111);
            this.grpGuncelle.Name = "grpGuncelle";
            this.grpGuncelle.Size = new System.Drawing.Size(200, 229);
            this.grpGuncelle.TabIndex = 2;
            this.grpGuncelle.TabStop = false;
            this.grpGuncelle.Text = "Yeni Kayıt && Düzenle";
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(55, 48);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(130, 23);
            this.txtArama.TabIndex = 0;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ara :";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(55, 36);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(130, 23);
            this.txtAd.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ad :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Soy. :";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(55, 65);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(130, 23);
            this.txtSoyad.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tel :";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(55, 94);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(130, 23);
            this.txtTel.TabIndex = 2;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(110, 123);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 41);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(29, 123);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 41);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(110, 187);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 36);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // rdbBaslar
            // 
            this.rdbBaslar.AutoSize = true;
            this.rdbBaslar.Location = new System.Drawing.Point(55, 22);
            this.rdbBaslar.Name = "rdbBaslar";
            this.rdbBaslar.Size = new System.Drawing.Size(61, 20);
            this.rdbBaslar.TabIndex = 1;
            this.rdbBaslar.TabStop = true;
            this.rdbBaslar.Text = "Başlar";
            this.rdbBaslar.UseVisualStyleBackColor = true;
            // 
            // rdbIcerir
            // 
            this.rdbIcerir.AutoSize = true;
            this.rdbIcerir.Location = new System.Drawing.Point(124, 22);
            this.rdbIcerir.Name = "rdbIcerir";
            this.rdbIcerir.Size = new System.Drawing.Size(56, 20);
            this.rdbIcerir.TabIndex = 1;
            this.rdbIcerir.TabStop = true;
            this.rdbIcerir.Text = "İçerir";
            this.rdbIcerir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 355);
            this.Controls.Add(this.grpGuncelle);
            this.Controls.Add(this.grpArama);
            this.Controls.Add(this.lstKisiler);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Telefon Defteri With LINQ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpArama.ResumeLayout(false);
            this.grpArama.PerformLayout();
            this.grpGuncelle.ResumeLayout(false);
            this.grpGuncelle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstKisiler;
        private System.Windows.Forms.GroupBox grpArama;
        private System.Windows.Forms.GroupBox grpGuncelle;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.RadioButton rdbIcerir;
        private System.Windows.Forms.RadioButton rdbBaslar;
    }
}

