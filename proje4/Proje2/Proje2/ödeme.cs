using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proje2
{
    public partial class ödeme : Form
    {
        double aratoplam;
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=SiparisOtomasyonu;Integrated Security=True");
        public ödeme()
        {
            InitializeComponent();
        }
       
        public void ödeme_Load(object sender, EventArgs e)
        {
            

            double KargoAgirligi;
            KargoAgirligi=(Convert.ToDouble(label2.Text) / 1000) * 5;
            double vrg=0.18;
            aratoplam = Convert.ToDouble(label6.Text) * vrg;
            label4.Text = (KargoAgirligi+aratoplam + Convert.ToDouble(label6.Text)).ToString();
            nakitbilgileri2lbl.Text = label4.Text;
            grpboxCekBilgi.Visible = false;
            grpboxKartBilgi.Visible = false;
            grpboxNakitBilgi.Visible = false;
           
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void türcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (türcombobox.SelectedItem.ToString().Trim())
            {
                case "çek":
                    grpboxNakitBilgi.Visible = false;
                    grpboxCekBilgi.Visible = true;
                    grpboxKartBilgi.Visible = false;
                    break;
                case "nakit":
                    grpboxCekBilgi.Visible = false;
                    grpboxNakitBilgi.Visible =true;
                    grpboxKartBilgi.Visible = false;
                    break;
                case "kredikartı":
                    grpboxKartBilgi.Visible = true;
                    grpboxCekBilgi.Visible = false;
                    grpboxNakitBilgi.Visible = false;
                    break;
                    
            }
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void onaylabutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Siparişiniz onaylandı");
        }

        private void ödemeyapbutton_Click(object sender, EventArgs e)
        {
            
            SqlCommand c = new SqlCommand("Update SiparişKaydı SET Adres=@Adres where id=(Select (MAX(id)) From SiparişKaydı)", con);
            c.Parameters.AddWithValue("@Adres", txtboxAdres.Text);
            con.Open();
            c.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Ödemeniz yapılmıstır");
            MessageBox.Show("Siparişiniz Hazırlanıyor");
        }

        private void grpboxNakitBilgi_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
