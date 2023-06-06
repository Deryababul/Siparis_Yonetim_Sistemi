
namespace Proje2
{
    partial class KullanıcıGirisi
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GirisButton = new System.Windows.Forms.Button();
            this.txtboxSifre = new System.Windows.Forms.TextBox();
            this.txtboxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.musterirbutton = new System.Windows.Forms.RadioButton();
            this.yöneticirbutton = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kayıt_ol = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GirisButton
            // 
            this.GirisButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GirisButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GirisButton.Location = new System.Drawing.Point(22, 368);
            this.GirisButton.Margin = new System.Windows.Forms.Padding(2);
            this.GirisButton.Name = "GirisButton";
            this.GirisButton.Size = new System.Drawing.Size(105, 31);
            this.GirisButton.TabIndex = 17;
            this.GirisButton.Text = "Giriş";
            this.GirisButton.UseVisualStyleBackColor = false;
            this.GirisButton.Click += new System.EventHandler(this.GirisButton_Click);
            // 
            // txtboxSifre
            // 
            this.txtboxSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtboxSifre.Location = new System.Drawing.Point(22, 332);
            this.txtboxSifre.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxSifre.Name = "txtboxSifre";
            this.txtboxSifre.Size = new System.Drawing.Size(265, 32);
            this.txtboxSifre.TabIndex = 16;
            // 
            // txtboxKullaniciAdi
            // 
            this.txtboxKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtboxKullaniciAdi.Location = new System.Drawing.Point(22, 272);
            this.txtboxKullaniciAdi.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxKullaniciAdi.Name = "txtboxKullaniciAdi";
            this.txtboxKullaniciAdi.Size = new System.Drawing.Size(265, 32);
            this.txtboxKullaniciAdi.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(18, 306);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(18, 250);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // musterirbutton
            // 
            this.musterirbutton.AutoSize = true;
            this.musterirbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musterirbutton.Location = new System.Drawing.Point(246, 160);
            this.musterirbutton.Margin = new System.Windows.Forms.Padding(2);
            this.musterirbutton.Name = "musterirbutton";
            this.musterirbutton.Size = new System.Drawing.Size(118, 24);
            this.musterirbutton.TabIndex = 12;
            this.musterirbutton.TabStop = true;
            this.musterirbutton.Text = "Müşteri Girişi";
            this.musterirbutton.UseVisualStyleBackColor = true;
            // 
            // yöneticirbutton
            // 
            this.yöneticirbutton.AutoSize = true;
            this.yöneticirbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yöneticirbutton.Location = new System.Drawing.Point(55, 160);
            this.yöneticirbutton.Margin = new System.Windows.Forms.Padding(2);
            this.yöneticirbutton.Name = "yöneticirbutton";
            this.yöneticirbutton.Size = new System.Drawing.Size(123, 24);
            this.yöneticirbutton.TabIndex = 11;
            this.yöneticirbutton.TabStop = true;
            this.yöneticirbutton.Text = "Yönetici Girişi";
            this.yöneticirbutton.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proje2.Properties.Resources._49b3c4394e57c25e159065ea90f1c498;
            this.pictureBox2.Location = new System.Drawing.Point(247, 46);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(108, 101);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proje2.Properties.Resources.bbe94fb0da988c31d4a2f2d58bc10fa1;
            this.pictureBox1.Location = new System.Drawing.Point(55, 46);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // kayıt_ol
            // 
            this.kayıt_ol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kayıt_ol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayıt_ol.Location = new System.Drawing.Point(161, 368);
            this.kayıt_ol.Margin = new System.Windows.Forms.Padding(2);
            this.kayıt_ol.Name = "kayıt_ol";
            this.kayıt_ol.Size = new System.Drawing.Size(126, 31);
            this.kayıt_ol.TabIndex = 18;
            this.kayıt_ol.Text = "Kayıt Ol";
            this.kayıt_ol.UseVisualStyleBackColor = false;
            this.kayıt_ol.Click += new System.EventHandler(this.KullaniciKayit);
            // 
            // KullanıcıGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 452);
            this.Controls.Add(this.kayıt_ol);
            this.Controls.Add(this.GirisButton);
            this.Controls.Add(this.txtboxSifre);
            this.Controls.Add(this.txtboxKullaniciAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.musterirbutton);
            this.Controls.Add(this.yöneticirbutton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "KullanıcıGirisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.KullanıcıGirisi_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GirisButton;
        private System.Windows.Forms.TextBox txtboxSifre;
        private System.Windows.Forms.TextBox txtboxKullaniciAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton musterirbutton;
        private System.Windows.Forms.RadioButton yöneticirbutton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button kayıt_ol;
    }
}

