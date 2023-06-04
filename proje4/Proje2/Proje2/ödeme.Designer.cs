
namespace Proje2
{
    partial class ödeme
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
            this.ödemetürülbl = new System.Windows.Forms.Label();
            this.türcombobox = new System.Windows.Forms.ComboBox();
            this.kartbilgielrinolbl = new System.Windows.Forms.Label();
            this.kartbilgileritiplbl = new System.Windows.Forms.Label();
            this.kartbilgileritarihlbl = new System.Windows.Forms.Label();
            this.grpboxKartBilgi = new System.Windows.Forms.GroupBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.kartbilgilericvclbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ödemeyapbutton = new System.Windows.Forms.Button();
            this.onaylabutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.çekisimlabel = new System.Windows.Forms.Label();
            this.çekbankalbl = new System.Windows.Forms.Label();
            this.çektxtbox = new System.Windows.Forms.TextBox();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.grpboxCekBilgi = new System.Windows.Forms.GroupBox();
            this.nakitbilgielri1label = new System.Windows.Forms.Label();
            this.nakitbilgileri2lbl = new System.Windows.Forms.Label();
            this.grpboxNakitBilgi = new System.Windows.Forms.GroupBox();
            this.grpboxKartBilgi.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.grpboxCekBilgi.SuspendLayout();
            this.grpboxNakitBilgi.SuspendLayout();
            this.SuspendLayout();
            // 
            // ödemetürülbl
            // 
            this.ödemetürülbl.AutoSize = true;
            this.ödemetürülbl.Location = new System.Drawing.Point(76, 34);
            this.ödemetürülbl.Name = "ödemetürülbl";
            this.ödemetürülbl.Size = new System.Drawing.Size(127, 25);
            this.ödemetürülbl.TabIndex = 0;
            this.ödemetürülbl.Text = "Ödeme Türü :";
            // 
            // türcombobox
            // 
            this.türcombobox.FormattingEnabled = true;
            this.türcombobox.Items.AddRange(new object[] {
            "nakit\t",
            "kredikartı",
            "çek"});
            this.türcombobox.Location = new System.Drawing.Point(244, 31);
            this.türcombobox.Name = "türcombobox";
            this.türcombobox.Size = new System.Drawing.Size(243, 33);
            this.türcombobox.TabIndex = 0;
            this.türcombobox.SelectedIndexChanged += new System.EventHandler(this.türcombobox_SelectedIndexChanged);
            // 
            // kartbilgielrinolbl
            // 
            this.kartbilgielrinolbl.AutoSize = true;
            this.kartbilgielrinolbl.Location = new System.Drawing.Point(13, 62);
            this.kartbilgielrinolbl.Name = "kartbilgielrinolbl";
            this.kartbilgielrinolbl.Size = new System.Drawing.Size(147, 25);
            this.kartbilgielrinolbl.TabIndex = 2;
            this.kartbilgielrinolbl.Text = "Kart Numarası :";
            // 
            // kartbilgileritiplbl
            // 
            this.kartbilgileritiplbl.AutoSize = true;
            this.kartbilgileritiplbl.Location = new System.Drawing.Point(13, 106);
            this.kartbilgileritiplbl.Name = "kartbilgileritiplbl";
            this.kartbilgileritiplbl.Size = new System.Drawing.Size(95, 25);
            this.kartbilgileritiplbl.TabIndex = 3;
            this.kartbilgileritiplbl.Text = "Kart Tipi :";
            // 
            // kartbilgileritarihlbl
            // 
            this.kartbilgileritarihlbl.AutoSize = true;
            this.kartbilgileritarihlbl.Location = new System.Drawing.Point(13, 151);
            this.kartbilgileritarihlbl.Name = "kartbilgileritarihlbl";
            this.kartbilgileritarihlbl.Size = new System.Drawing.Size(191, 25);
            this.kartbilgileritarihlbl.TabIndex = 4;
            this.kartbilgileritarihlbl.Text = "Son Kullanma Tarihi :";
            // 
            // grpboxKartBilgi
            // 
            this.grpboxKartBilgi.BackColor = System.Drawing.SystemColors.Control;
            this.grpboxKartBilgi.Controls.Add(this.maskedTextBox3);
            this.grpboxKartBilgi.Controls.Add(this.maskedTextBox2);
            this.grpboxKartBilgi.Controls.Add(this.maskedTextBox1);
            this.grpboxKartBilgi.Controls.Add(this.comboBox1);
            this.grpboxKartBilgi.Controls.Add(this.kartbilgilericvclbl);
            this.grpboxKartBilgi.Controls.Add(this.kartbilgielrinolbl);
            this.grpboxKartBilgi.Controls.Add(this.kartbilgileritarihlbl);
            this.grpboxKartBilgi.Controls.Add(this.kartbilgileritiplbl);
            this.grpboxKartBilgi.Location = new System.Drawing.Point(55, 129);
            this.grpboxKartBilgi.Name = "grpboxKartBilgi";
            this.grpboxKartBilgi.Size = new System.Drawing.Size(432, 232);
            this.grpboxKartBilgi.TabIndex = 5;
            this.grpboxKartBilgi.TabStop = false;
            this.grpboxKartBilgi.Text = "Kart Bilgileri :";
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(244, 146);
            this.maskedTextBox3.Mask = "00-00";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(52, 33);
            this.maskedTextBox3.TabIndex = 13;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(244, 54);
            this.maskedTextBox2.Mask = "0000-0000-0000-0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(162, 33);
            this.maskedTextBox2.TabIndex = 12;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(244, 185);
            this.maskedTextBox1.Mask = "000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(52, 33);
            this.maskedTextBox1.TabIndex = 11;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "MASTERCARD",
            "VİSA",
            "AMERİCANEXPRESS"});
            this.comboBox1.Location = new System.Drawing.Point(244, 98);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(162, 33);
            this.comboBox1.TabIndex = 10;
            // 
            // kartbilgilericvclbl
            // 
            this.kartbilgilericvclbl.AutoSize = true;
            this.kartbilgilericvclbl.Location = new System.Drawing.Point(13, 196);
            this.kartbilgilericvclbl.Name = "kartbilgilericvclbl";
            this.kartbilgilericvclbl.Size = new System.Drawing.Size(58, 25);
            this.kartbilgilericvclbl.TabIndex = 5;
            this.kartbilgilericvclbl.Text = "CVC :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tutar :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(270, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "ilk toplam";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // ödemeyapbutton
            // 
            this.ödemeyapbutton.BackColor = System.Drawing.Color.LightSlateGray;
            this.ödemeyapbutton.Location = new System.Drawing.Point(300, 389);
            this.ödemeyapbutton.Name = "ödemeyapbutton";
            this.ödemeyapbutton.Size = new System.Drawing.Size(202, 54);
            this.ödemeyapbutton.TabIndex = 9;
            this.ödemeyapbutton.Text = "Ödeme Yap";
            this.ödemeyapbutton.UseVisualStyleBackColor = false;
            this.ödemeyapbutton.Click += new System.EventHandler(this.ödemeyapbutton_Click);
            // 
            // onaylabutton
            // 
            this.onaylabutton.Location = new System.Drawing.Point(70, 389);
            this.onaylabutton.Name = "onaylabutton";
            this.onaylabutton.Size = new System.Drawing.Size(202, 54);
            this.onaylabutton.TabIndex = 10;
            this.onaylabutton.Text = "Onayla";
            this.onaylabutton.UseVisualStyleBackColor = false;
            this.onaylabutton.Click += new System.EventHandler(this.onaylabutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Toplam Ağırlık :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "ağırlık";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(314, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Toplam Tutar(vergi ve kargo dahil) :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "toplam";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Kargo Bedeli 1 kg=5tl";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(561, 31);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(259, 110);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bilgilendirme :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Vergi: 0.18";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Location = new System.Drawing.Point(561, 191);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(430, 228);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Açıklama :";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // çekisimlabel
            // 
            this.çekisimlabel.AutoSize = true;
            this.çekisimlabel.Location = new System.Drawing.Point(73, 48);
            this.çekisimlabel.Name = "çekisimlabel";
            this.çekisimlabel.Size = new System.Drawing.Size(58, 25);
            this.çekisimlabel.TabIndex = 0;
            this.çekisimlabel.Text = "İsim :";
            // 
            // çekbankalbl
            // 
            this.çekbankalbl.AutoSize = true;
            this.çekbankalbl.Location = new System.Drawing.Point(31, 97);
            this.çekbankalbl.Name = "çekbankalbl";
            this.çekbankalbl.Size = new System.Drawing.Size(94, 25);
            this.çekbankalbl.TabIndex = 1;
            this.çekbankalbl.Text = "Banka ID:";
            // 
            // çektxtbox
            // 
            this.çektxtbox.Location = new System.Drawing.Point(137, 46);
            this.çektxtbox.Name = "çektxtbox";
            this.çektxtbox.Size = new System.Drawing.Size(224, 33);
            this.çektxtbox.TabIndex = 2;
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.Location = new System.Drawing.Point(137, 97);
            this.maskedTextBox4.Mask = "000000000000000";
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(130, 33);
            this.maskedTextBox4.TabIndex = 3;
            this.maskedTextBox4.ValidatingType = typeof(int);
            // 
            // grpboxCekBilgi
            // 
            this.grpboxCekBilgi.BackColor = System.Drawing.SystemColors.Control;
            this.grpboxCekBilgi.Controls.Add(this.maskedTextBox4);
            this.grpboxCekBilgi.Controls.Add(this.çektxtbox);
            this.grpboxCekBilgi.Controls.Add(this.çekbankalbl);
            this.grpboxCekBilgi.Controls.Add(this.çekisimlabel);
            this.grpboxCekBilgi.Location = new System.Drawing.Point(30, 160);
            this.grpboxCekBilgi.Name = "grpboxCekBilgi";
            this.grpboxCekBilgi.Size = new System.Drawing.Size(386, 190);
            this.grpboxCekBilgi.TabIndex = 8;
            this.grpboxCekBilgi.TabStop = false;
            this.grpboxCekBilgi.Text = "Çek Bilgileri :";
            // 
            // nakitbilgielri1label
            // 
            this.nakitbilgielri1label.AutoSize = true;
            this.nakitbilgielri1label.Location = new System.Drawing.Point(6, 65);
            this.nakitbilgielri1label.Name = "nakitbilgielri1label";
            this.nakitbilgielri1label.Size = new System.Drawing.Size(158, 25);
            this.nakitbilgielri1label.TabIndex = 0;
            this.nakitbilgielri1label.Text = "Ödenecek Ücret :";
            // 
            // nakitbilgileri2lbl
            // 
            this.nakitbilgileri2lbl.AutoSize = true;
            this.nakitbilgileri2lbl.Location = new System.Drawing.Point(215, 65);
            this.nakitbilgileri2lbl.Name = "nakitbilgileri2lbl";
            this.nakitbilgileri2lbl.Size = new System.Drawing.Size(59, 25);
            this.nakitbilgileri2lbl.TabIndex = 1;
            this.nakitbilgileri2lbl.Text = "Nakit";
            // 
            // grpboxNakitBilgi
            // 
            this.grpboxNakitBilgi.BackColor = System.Drawing.SystemColors.Control;
            this.grpboxNakitBilgi.Controls.Add(this.nakitbilgileri2lbl);
            this.grpboxNakitBilgi.Controls.Add(this.nakitbilgielri1label);
            this.grpboxNakitBilgi.Location = new System.Drawing.Point(41, 143);
            this.grpboxNakitBilgi.Name = "grpboxNakitBilgi";
            this.grpboxNakitBilgi.Size = new System.Drawing.Size(341, 139);
            this.grpboxNakitBilgi.TabIndex = 8;
            this.grpboxNakitBilgi.TabStop = false;
            this.grpboxNakitBilgi.Text = "Nakit Bilgileri :";
            this.grpboxNakitBilgi.Visible = false;
            this.grpboxNakitBilgi.Enter += new System.EventHandler(this.grpboxNakitBilgi_Enter);
            // 
            // ödeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1021, 484);
            this.Controls.Add(this.grpboxNakitBilgi);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.grpboxCekBilgi);
            this.Controls.Add(this.grpboxKartBilgi);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.onaylabutton);
            this.Controls.Add(this.ödemeyapbutton);
            this.Controls.Add(this.türcombobox);
            this.Controls.Add(this.ödemetürülbl);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ödeme";
            this.Text = "Ödeme Menü";
            this.Load += new System.EventHandler(this.ödeme_Load);
            this.grpboxKartBilgi.ResumeLayout(false);
            this.grpboxKartBilgi.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.grpboxCekBilgi.ResumeLayout(false);
            this.grpboxCekBilgi.PerformLayout();
            this.grpboxNakitBilgi.ResumeLayout(false);
            this.grpboxNakitBilgi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ödemetürülbl;
        private System.Windows.Forms.ComboBox türcombobox;
        private System.Windows.Forms.Label kartbilgielrinolbl;
        private System.Windows.Forms.Label kartbilgileritiplbl;
        private System.Windows.Forms.Label kartbilgileritarihlbl;
        private System.Windows.Forms.GroupBox grpboxKartBilgi;
        private System.Windows.Forms.Label kartbilgilericvclbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ödemeyapbutton;
        private System.Windows.Forms.Button onaylabutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label çekisimlabel;
        private System.Windows.Forms.Label çekbankalbl;
        private System.Windows.Forms.TextBox çektxtbox;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.GroupBox grpboxCekBilgi;
        private System.Windows.Forms.Label nakitbilgielri1label;
        private System.Windows.Forms.Label nakitbilgileri2lbl;
        private System.Windows.Forms.GroupBox grpboxNakitBilgi;
    }
}