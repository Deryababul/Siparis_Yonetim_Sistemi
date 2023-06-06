
namespace Proje2
{
    partial class yetkilimenu
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
            this.ürüneklebutton = new System.Windows.Forms.Button();
            this.ürüncıkarbutton = new System.Windows.Forms.Button();
            this.güncellebutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.KargoTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtboxUrunId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtboxUrunAciklama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxUrunF = new System.Windows.Forms.TextBox();
            this.txtboxUrunA = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxKargoDurum = new System.Windows.Forms.TextBox();
            this.textBoxSiparisId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.KargoTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ürüneklebutton
            // 
            this.ürüneklebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ürüneklebutton.Location = new System.Drawing.Point(14, 490);
            this.ürüneklebutton.Margin = new System.Windows.Forms.Padding(5);
            this.ürüneklebutton.Name = "ürüneklebutton";
            this.ürüneklebutton.Size = new System.Drawing.Size(181, 54);
            this.ürüneklebutton.TabIndex = 0;
            this.ürüneklebutton.Text = "Ürün Ekle";
            this.ürüneklebutton.UseVisualStyleBackColor = false;
            this.ürüneklebutton.Click += new System.EventHandler(this.ürüneklebutton_Click);
            // 
            // ürüncıkarbutton
            // 
            this.ürüncıkarbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ürüncıkarbutton.Location = new System.Drawing.Point(223, 434);
            this.ürüncıkarbutton.Name = "ürüncıkarbutton";
            this.ürüncıkarbutton.Size = new System.Drawing.Size(159, 54);
            this.ürüncıkarbutton.TabIndex = 1;
            this.ürüncıkarbutton.Text = "Ürün Çıkar";
            this.ürüncıkarbutton.UseVisualStyleBackColor = false;
            this.ürüncıkarbutton.Click += new System.EventHandler(this.ürüncıkarbutton_Click);
            // 
            // güncellebutton
            // 
            this.güncellebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.güncellebutton.Location = new System.Drawing.Point(16, 434);
            this.güncellebutton.Name = "güncellebutton";
            this.güncellebutton.Size = new System.Drawing.Size(179, 54);
            this.güncellebutton.TabIndex = 2;
            this.güncellebutton.Text = "Ürün Güncelle";
            this.güncellebutton.UseVisualStyleBackColor = false;
            this.güncellebutton.Click += new System.EventHandler(this.güncellebutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(980, 328);
            this.dataGridView1.TabIndex = 4;
            // 
            // KargoTab
            // 
            this.KargoTab.Controls.Add(this.tabPage1);
            this.KargoTab.Controls.Add(this.tabPage2);
            this.KargoTab.Controls.Add(this.tabPage3);
            this.KargoTab.Location = new System.Drawing.Point(12, 54);
            this.KargoTab.Name = "KargoTab";
            this.KargoTab.SelectedIndex = 0;
            this.KargoTab.Size = new System.Drawing.Size(994, 372);
            this.KargoTab.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtboxUrunId);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtboxUrunAciklama);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtboxUrunF);
            this.tabPage1.Controls.Add(this.txtboxUrunA);
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(986, 334);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ürün Güncelle";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // txtboxUrunId
            // 
            this.txtboxUrunId.Enabled = false;
            this.txtboxUrunId.Location = new System.Drawing.Point(849, 18);
            this.txtboxUrunId.Name = "txtboxUrunId";
            this.txtboxUrunId.Size = new System.Drawing.Size(120, 33);
            this.txtboxUrunId.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(668, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ürün No :";
            // 
            // txtboxUrunAciklama
            // 
            this.txtboxUrunAciklama.Location = new System.Drawing.Point(674, 201);
            this.txtboxUrunAciklama.Multiline = true;
            this.txtboxUrunAciklama.Name = "txtboxUrunAciklama";
            this.txtboxUrunAciklama.Size = new System.Drawing.Size(295, 109);
            this.txtboxUrunAciklama.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(667, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ürün Açıklama :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(666, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ürün Ağırlığı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(666, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ürün Fiyatı :";
            // 
            // txtboxUrunF
            // 
            this.txtboxUrunF.Location = new System.Drawing.Point(849, 64);
            this.txtboxUrunF.Name = "txtboxUrunF";
            this.txtboxUrunF.Size = new System.Drawing.Size(120, 33);
            this.txtboxUrunF.TabIndex = 2;
            // 
            // txtboxUrunA
            // 
            this.txtboxUrunA.Location = new System.Drawing.Point(849, 109);
            this.txtboxUrunA.Name = "txtboxUrunA";
            this.txtboxUrunA.Size = new System.Drawing.Size(120, 33);
            this.txtboxUrunA.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(656, 310);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellEnter);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(986, 334);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Müşteri Takip";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Location = new System.Drawing.Point(799, 492);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 54);
            this.button1.TabIndex = 7;
            this.button1.Text = "Müşteri menü kontrol";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.Location = new System.Drawing.Point(407, 434);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 54);
            this.button2.TabIndex = 8;
            this.button2.Text = "Ürün Çıkar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBoxSiparisId);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.textBoxKargoDurum);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(986, 334);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Kargo Takip";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button3.Location = new System.Drawing.Point(744, 434);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(258, 54);
            this.button3.TabIndex = 9;
            this.button3.Text = "Kargo Durumu Güncelle";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.KargoGuncelle);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Sipariş Id:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Kargo Durumu:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBoxKargoDurum
            // 
            this.textBoxKargoDurum.Location = new System.Drawing.Point(211, 69);
            this.textBoxKargoDurum.Name = "textBoxKargoDurum";
            this.textBoxKargoDurum.Size = new System.Drawing.Size(120, 33);
            this.textBoxKargoDurum.TabIndex = 10;
            this.textBoxKargoDurum.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxSiparisId
            // 
            this.textBoxSiparisId.Location = new System.Drawing.Point(211, 30);
            this.textBoxSiparisId.Name = "textBoxSiparisId";
            this.textBoxSiparisId.Size = new System.Drawing.Size(120, 33);
            this.textBoxSiparisId.TabIndex = 13;
            // 
            // yetkilimenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1018, 558);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.KargoTab);
            this.Controls.Add(this.güncellebutton);
            this.Controls.Add(this.ürüncıkarbutton);
            this.Controls.Add(this.ürüneklebutton);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "yetkilimenu";
            this.Text = "Yetkili Menü";
            this.Load += new System.EventHandler(this.yetkilimenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.KargoTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ürüneklebutton;
        private System.Windows.Forms.Button ürüncıkarbutton;
        private System.Windows.Forms.Button güncellebutton;
        private System.Windows.Forms.TabControl KargoTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txtboxUrunF;
        private System.Windows.Forms.TextBox txtboxUrunA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxUrunAciklama;
        private System.Windows.Forms.TextBox txtboxUrunId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxKargoDurum;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBoxSiparisId;
    }
}