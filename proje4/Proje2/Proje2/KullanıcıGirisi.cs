using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proje2
{
    public partial class KullanıcıGirisi : Form
    {
        public static string kullanıcı;

        public KullanıcıGirisi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=SiparisOtomasyonu;Integrated Security=True");
       

        private void GirisButton_Click(object sender, EventArgs e)
        {

            if (yöneticirbutton.Checked)
            {
                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("Select * From Tbl_Yetkili where YetkiliAd=@p1 and YetkiliSifre=@p2", baglanti);
                komut3.Parameters.AddWithValue("@p1", txtboxKullaniciAdi.Text);
                komut3.Parameters.AddWithValue("@p2", txtboxSifre.Text);
                SqlDataReader dr2 = komut3.ExecuteReader();
                if (dr2.Read())
                {
                    yetkilimenu yetkili = new yetkilimenu();
                    yetkili.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı yetkili adı veya şifre");

                }
                baglanti.Close();
            }
            else if (musterirbutton.Checked)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * From Tbl_Musteri where MusteriAd=@p1 and MusteriSifre=@p2", baglanti);
                komut.Parameters.AddWithValue("@p1", txtboxKullaniciAdi.Text);
                komut.Parameters.AddWithValue("@p2", txtboxSifre.Text);
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    kullanıcı = txtboxKullaniciAdi.Text;
                    Musterimenu musteri = new Musterimenu();
                    musteri.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı musteri adı veya şifre");

                }
                baglanti.Close();


          
            }
        }

        private void KullanıcıGirisi_Load(object sender, EventArgs e)
        {

        }
    }
}
