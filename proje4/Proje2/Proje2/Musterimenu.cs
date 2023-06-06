using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;

namespace Proje2
{
    public partial class Musterimenu : Form
    {
        
        public static List<Button> butonlar2 = new List<Button>();
        public static Musteri m =new Musteri();
        

        public Musterimenu()
        {
            InitializeComponent();
        }
        

        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=SiparisOtomasyonu;Integrated Security=True");
        private void Musterimenu_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sql = new SqlCommand("Select UrunFiyati,UrunAgirligi from Tbl_Urunler where id=1", baglanti);
            SqlDataReader da = sql.ExecuteReader();
            while(da.Read() || da.Read())
            {
                macbookFiyat.Text = da[0].ToString();
                macbookAgirlik.Text = da[1].ToString();
            }
            baglanti.Close();
            baglanti.Open();
            SqlCommand sql2 = new SqlCommand("Select UrunFiyati,UrunAgirligi from Tbl_Urunler where id=2", baglanti);
            SqlDataReader da2 = sql2.ExecuteReader();
            while (da2.Read() || da2.Read())
            {
                telefonFiyati.Text = da2[0].ToString();
                telefonAgirlik.Text = da2[1].ToString();
            }
            baglanti.Close();
            baglanti.Open();
            SqlCommand sql3 = new SqlCommand("Select UrunFiyati,UrunAgirligi from Tbl_Urunler where id=3", baglanti);
            SqlDataReader da3 = sql3.ExecuteReader();
            while (da3.Read() || da3.Read())
            {
                airpodsFiyati.Text = da3[0].ToString();
                airpodsAgirlik.Text = da3[1].ToString();
            }
            baglanti.Close();
            baglanti.Open();
            SqlCommand sql4 = new SqlCommand("Select UrunFiyati,UrunAgirligi from Tbl_Urunler where id=4", baglanti);
            SqlDataReader da4 = sql4.ExecuteReader();
            while (da4.Read() || da4.Read())
            {
                tabletFiyati.Text = da4[0].ToString();
                tabletAgirlik.Text = da4[1].ToString();
            }
            baglanti.Close();
            baglanti.Open();
            SqlCommand sql5 = new SqlCommand("Select UrunFiyati,UrunAgirligi from Tbl_Urunler where id=5", baglanti);
            SqlDataReader da5 = sql5.ExecuteReader();
            while (da5.Read() || da5.Read())
            {
                droneFiyati.Text = da5[0].ToString();
                droneAgirlik.Text = da5[1].ToString();
            }
            baglanti.Close();
            baglanti.Open();
            SqlCommand sql6 = new SqlCommand("Select UrunFiyati,UrunAgirligi from Tbl_Urunler where id=6", baglanti);
            SqlDataReader da6 = sql6.ExecuteReader();
            while (da6.Read() || da6.Read())
            {
                ps5Fiyati.Text = da6[0].ToString();
                ps5Agirlik.Text = da6[1].ToString();
            }
            baglanti.Close();
            
        }
       
       
        public void macbookbutton_Click(object sender, EventArgs e)
        {
           
            if (macbook.BackColor==Color.White)
            {
                macbook.BackColor = Color.Turquoise;
            }else 
            {
                macbook.BackColor = Color.White;
            }

            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select UrunAciklama From Tbl_Urunler where id=1", baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lblUrunAciklama.Text = dr1[0].ToString();
            }
          baglanti.Close();
        }

        public void telefonbutton_Click(object sender, EventArgs e)
        {
            
            if (telefon.BackColor == Color.White)
            {
                telefon.BackColor = Color.Turquoise;
            }
            else
            {
                telefon.BackColor = Color.White;
            }
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select UrunAciklama From Tbl_Urunler where id=2", baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lblUrunAciklama.Text = dr1[0].ToString();
            }
            baglanti.Close();
        }

        private void airpodsbutton_Click(object sender, EventArgs e)
        {
            
            if (airpods.BackColor == Color.White)
            {
                airpods.BackColor = Color.Turquoise;
            }
            else
            {
                airpods.BackColor = Color.White;
            }
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select UrunAciklama From Tbl_Urunler where id=3", baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lblUrunAciklama.Text = dr1[0].ToString();
            }
            baglanti.Close();
        }

        private void tabletbutton_Click(object sender, EventArgs e)
        {
           
            if (tablet.BackColor == Color.White)
            {
                tablet.BackColor = Color.Turquoise;
            }
            else
            {
                tablet.BackColor = Color.White;
            }
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select UrunAciklama From Tbl_Urunler where id=4", baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lblUrunAciklama.Text = dr1[0].ToString();
            }
            baglanti.Close();
        }

        private void dronebutton_Click(object sender, EventArgs e)
        {
            
            if (drone.BackColor == Color.White)
            {
                drone.BackColor = Color.Turquoise;
            }
            else
            {
                drone.BackColor = Color.White;
            }
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select UrunAciklama From Tbl_Urunler where id=5", baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lblUrunAciklama.Text = dr1[0].ToString();
            }
            baglanti.Close();
        }

        private void ps5button_Click(object sender, EventArgs e)
        {
            
            if (ps5.BackColor == Color.White)
            {
                ps5.BackColor = Color.Turquoise;
            }
            else
            {
                ps5.BackColor = Color.White;
            }
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select UrunAciklama From Tbl_Urunler where id=6", baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lblUrunAciklama.Text = dr1[0].ToString();
            }
            baglanti.Close();
        }

        public void ürüneklebutton_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=SiparisOtomasyonu;Integrated Security=True");
            con.Open();
            
            butonlar2.Add(macbook);
            butonlar2.Add(telefon);
            butonlar2.Add(airpods);
            butonlar2.Add(tablet);
            butonlar2.Add(drone);
            butonlar2.Add(ps5);

            foreach (Button b in butonlar2)
            {
                System.Console.WriteLine(musterimenutextbox.Text);

                if (b.BackColor == Color.Turquoise)
                {
                   
                    switch (b.Name)
                    {
                        case "macbook":
                            System.Console.WriteLine("case1");
                            string adres;
                            SqlCommand cmd = new SqlCommand("Select MusteriAdres From Tbl_Musteri where MusteriAd=@MusteriAd", con);
                            cmd.Parameters.AddWithValue("@MusteriAd", KullanıcıGirisi.kullanıcı);
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            adres = dt.Rows[0]["MusteriAdres"].ToString();
                            SqlCommand com = new SqlCommand("Insert into Sepet (UrunAdi,UrunFiyati,UrunAgirligi,UrunAdedi) values (@a,@b,@c,@d)", con);
                            //Urun urun = new Urun { Fiyat = Convert.ToInt32(Convert.ToInt32(macbookFiyat.Text) * Convert.ToInt32(musterimenutextbox.Text)), Agirlik = Convert.ToInt32(Convert.ToInt32(macbookAgirlik.Text) * Convert.ToInt32(musterimenutextbox.Text)), UrunAdi = "macbook", UrunAdedi = Convert.ToInt32(musterimenutextbox.Text) };
                            Urun urun = new Urun();
                            urun.Fiyat = Convert.ToInt32(Convert.ToInt32(macbookFiyat.Text) * Convert.ToInt32(musterimenutextbox.Text));
                            urun.Agirlik = Convert.ToInt32(Convert.ToInt32(macbookAgirlik.Text) * Convert.ToInt32(musterimenutextbox.Text));
                            urun.UrunAdedi = Convert.ToInt32(musterimenutextbox.Text);
                            urun.UrunAdi = "macbook";
                            m.Urunler.Add(urun);
                            com.Parameters.AddWithValue("@k",KullanıcıGirisi.kullanıcı);
                            com.Parameters.AddWithValue("@a", urun.UrunAdi);
                            com.Parameters.AddWithValue("@b", urun.Fiyat);
                            com.Parameters.AddWithValue("@c", urun.Agirlik);
                            com.Parameters.AddWithValue("@d", urun.UrunAdedi);
                            com.ExecuteNonQuery();
                            macbook.BackColor = Color.White;
                            SqlCommand cmnd = new SqlCommand("Insert into SiparişKaydı  (kullanıcıAdi,UrunAdi,UrunFiyat,UrunAgirligi,UrunAdet,Adres) values (@k,@a,@b,@c,@d,@z)", con);
                            cmnd.Parameters.AddWithValue("@k", KullanıcıGirisi.kullanıcı);
                            cmnd.Parameters.AddWithValue("@a", urun.UrunAdi);
                            cmnd.Parameters.AddWithValue("@b", urun.Fiyat);
                            cmnd.Parameters.AddWithValue("@c", urun.Agirlik);
                            cmnd.Parameters.AddWithValue("@d", urun.UrunAdedi);
                            cmnd.Parameters.AddWithValue("@z", adres);
                            cmnd.ExecuteNonQuery();
                            break;
                        case "telefon":
                            System.Console.WriteLine("case2");
                            string adres1;
                            SqlCommand cmd1 = new SqlCommand("Select MusteriAdres From Tbl_Musteri where MusteriAd=@MusteriAd", con);
                            cmd1.Parameters.AddWithValue("@MusteriAd", KullanıcıGirisi.kullanıcı);
                            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                            DataTable dt1 = new DataTable();
                            da1.Fill(dt1);
                            adres1 = dt1.Rows[0]["MusteriAdres"].ToString();
                            SqlCommand com2 = new SqlCommand("Insert into Sepet (UrunAdi,UrunFiyati,UrunAgirligi,UrunAdedi) values (@a,@b,@c,@d)", con);
                            Urun urun1 = new Urun { Fiyat = Convert.ToInt32(telefonFiyati.Text) * Convert.ToInt32(musterimenutextbox.Text), Agirlik = Convert.ToInt32(telefonAgirlik.Text) * Convert.ToInt32(musterimenutextbox.Text), UrunAdi = "telefon", UrunAdedi = Convert.ToInt32(musterimenutextbox.Text) };
                            m.Urunler.Add(urun1);

                            com2.Parameters.AddWithValue("@a", urun1.UrunAdi);
                            com2.Parameters.AddWithValue("@b", urun1.Fiyat);
                            com2.Parameters.AddWithValue("@c", urun1.Agirlik);
                            com2.Parameters.AddWithValue("@d", urun1.UrunAdedi);
                            com2.ExecuteNonQuery(); 
                            SqlCommand cmnd1 = new SqlCommand("Insert into SiparişKaydı  (kullanıcıAdi,UrunAdi,UrunFiyat,UrunAgirligi,UrunAdet,Adres) values (@k,@a,@b,@c,@d,@z)", con);
                            cmnd1.Parameters.AddWithValue("@k", KullanıcıGirisi.kullanıcı);
                            cmnd1.Parameters.AddWithValue("@a", urun1.UrunAdi);
                            cmnd1.Parameters.AddWithValue("@b", urun1.Fiyat);
                            cmnd1.Parameters.AddWithValue("@c", urun1.Agirlik);
                            cmnd1.Parameters.AddWithValue("@d", urun1.UrunAdedi);
                            cmnd1.Parameters.AddWithValue("@z", adres1);
                            cmnd1.ExecuteNonQuery();
                            telefon.BackColor = Color.White;
                            break;
                        case "airpods":
                            System.Console.WriteLine("case3");
                            string adres2;
                            SqlCommand cmd2 = new SqlCommand("Select MusteriAdres From Tbl_Musteri where MusteriAd=@MusteriAd", con);
                            cmd2.Parameters.AddWithValue("@MusteriAd", KullanıcıGirisi.kullanıcı);
                            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                            DataTable dt2 = new DataTable();
                            da2.Fill(dt2);
                            adres2 = dt2.Rows[0]["MusteriAdres"].ToString();
                            SqlCommand com3 = new SqlCommand("Insert into Sepet (UrunAdi,UrunFiyati,UrunAgirligi,UrunAdedi) values (@a,@b,@c,@d)", con);
                            Urun urun2 = new Urun { Fiyat = Convert.ToInt32(airpodsFiyati.Text) * Convert.ToInt32(musterimenutextbox.Text), Agirlik = Convert.ToInt32(airpodsAgirlik.Text) * Convert.ToInt32(musterimenutextbox.Text), UrunAdi = "airpods", UrunAdedi = Convert.ToInt32(musterimenutextbox.Text) };
                            m.Urunler.Add(urun2);
                            com3.Parameters.AddWithValue("@a", urun2.UrunAdi);
                            com3.Parameters.AddWithValue("@b", urun2.Fiyat);
                            com3.Parameters.AddWithValue("@c", urun2.Agirlik);
                            com3.Parameters.AddWithValue("@d", urun2.UrunAdedi);
                            com3.ExecuteNonQuery(); 
                            SqlCommand cmnd2 = new SqlCommand("Insert into SiparişKaydı  (kullanıcıAdi,UrunAdi,UrunFiyat,UrunAgirligi,UrunAdet,Adres) values (@k,@a,@b,@c,@d,@z)", con);
                            cmnd2.Parameters.AddWithValue("@k", KullanıcıGirisi.kullanıcı);
                            cmnd2.Parameters.AddWithValue("@a", urun2.UrunAdi);
                            cmnd2.Parameters.AddWithValue("@b", urun2.Fiyat);
                            cmnd2.Parameters.AddWithValue("@c", urun2.Agirlik);
                            cmnd2.Parameters.AddWithValue("@d", urun2.UrunAdedi);
                            cmnd2.Parameters.AddWithValue("@z", adres2);

                            airpods.BackColor = Color.White;
                            break;
                        case "tablet":
                            System.Console.WriteLine("case4");
                            string adres3;
                            SqlCommand cmd3 = new SqlCommand("Select MusteriAdres From Tbl_Musteri where MusteriAd=@MusteriAd", con);
                            cmd3.Parameters.AddWithValue("@MusteriAd", KullanıcıGirisi.kullanıcı);
                            SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
                            DataTable dt3 = new DataTable();
                            da3.Fill(dt3);
                            adres3 = dt3.Rows[0]["MusteriAdres"].ToString();
                            SqlCommand com4 = new SqlCommand("Insert into Sepet (UrunAdi,UrunFiyati,UrunAgirligi,UrunAdedi) values (@a,@b,@c,@d)", con);
                            Urun urun3 = new Urun { Fiyat = Convert.ToInt32(tabletFiyati.Text) * Convert.ToInt32(musterimenutextbox.Text), Agirlik = Convert.ToInt32(tabletAgirlik.Text) * Convert.ToInt32(musterimenutextbox.Text), UrunAdi = "tablet", UrunAdedi = Convert.ToInt32(musterimenutextbox.Text) };
                            
                            m.Urunler.Add(urun3);
                            com4.Parameters.AddWithValue("@a", urun3.UrunAdi);
                            com4.Parameters.AddWithValue("@b", urun3.Fiyat);
                            com4.Parameters.AddWithValue("@c", urun3.Agirlik);
                            com4.Parameters.AddWithValue("@d", urun3.UrunAdedi);
                            com4.ExecuteNonQuery();
                            SqlCommand cmnd3 = new SqlCommand("Insert into SiparişKaydı  (kullanıcıAdi,UrunAdi,UrunFiyat,UrunAgirligi,UrunAdet,Adres) values (@k,@a,@b,@c,@d,@z)", con);
                            cmnd3.Parameters.AddWithValue("@k", KullanıcıGirisi.kullanıcı);
                            cmnd3.Parameters.AddWithValue("@a", urun3.UrunAdi);
                            cmnd3.Parameters.AddWithValue("@b", urun3.Fiyat);
                            cmnd3.Parameters.AddWithValue("@c", urun3.Agirlik);
                            cmnd3.Parameters.AddWithValue("@d", urun3.UrunAdedi);
                            cmnd3.Parameters.AddWithValue("@z", adres3);
                            cmnd3.ExecuteNonQuery();
                            tablet.BackColor = Color.White;
                            break;
                        case "drone":
                            System.Console.WriteLine("case5");
                            string adres4;
                            SqlCommand cmd4 = new SqlCommand("Select MusteriAdres From Tbl_Musteri where MusteriAd=@MusteriAd", con);
                            cmd4.Parameters.AddWithValue("@MusteriAd", KullanıcıGirisi.kullanıcı);
                            SqlDataAdapter da4 = new SqlDataAdapter(cmd4);
                            DataTable dt4 = new DataTable();
                            da4.Fill(dt4);
                            adres4 = dt4.Rows[0]["MusteriAdres"].ToString();
                            SqlCommand com5 = new SqlCommand("Insert into Sepet (UrunAdi,UrunFiyati,UrunAgirligi,UrunAdedi) values (@a,@b,@c,@d)", con);
                            Urun urun4 = new Urun { Fiyat =Convert.ToInt32(droneFiyati.Text) * Convert.ToInt32(musterimenutextbox.Text), Agirlik = Convert.ToInt32(droneAgirlik.Text) * Convert.ToInt32(musterimenutextbox.Text), UrunAdi = "drone", UrunAdedi = Convert.ToInt32(musterimenutextbox.Text) };
                            m.Urunler.Add(urun4);
                            com5.Parameters.AddWithValue("@a", urun4.UrunAdi);
                            com5.Parameters.AddWithValue("@b", urun4.Fiyat);
                            com5.Parameters.AddWithValue("@c", urun4.Agirlik);
                            com5.Parameters.AddWithValue("@d", urun4.UrunAdedi);
                            com5.ExecuteNonQuery();                          
                            SqlCommand cmnd4 = new SqlCommand("Insert into SiparişKaydı  (kullanıcıAdi,UrunAdi,UrunFiyat,UrunAgirligi,UrunAdet,Adres) values (@k,@a,@b,@c,@d,@z)", con);
                            cmnd4.Parameters.AddWithValue("@k", KullanıcıGirisi.kullanıcı);
                            cmnd4.Parameters.AddWithValue("@a", urun4.UrunAdi);
                            cmnd4.Parameters.AddWithValue("@b", urun4.Fiyat);
                            cmnd4.Parameters.AddWithValue("@c", urun4.Agirlik);
                            cmnd4.Parameters.AddWithValue("@d", urun4.UrunAdedi);
                            cmnd4.Parameters.AddWithValue("@z", adres4);
                            cmnd4.ExecuteNonQuery();
                            drone.BackColor = Color.White;
                            break;
                        case "ps5":
                            System.Console.WriteLine("case6");
                            string adres5;
                            SqlCommand cmd5 = new SqlCommand("Select MusteriAdres From Tbl_Musteri where MusteriAd=@MusteriAd", con);
                            cmd5.Parameters.AddWithValue("@MusteriAd", KullanıcıGirisi.kullanıcı);
                            SqlDataAdapter da5 = new SqlDataAdapter(cmd5);
                            DataTable dt5 = new DataTable();
                            da5.Fill(dt5);
                            adres5 = dt5.Rows[0]["MusteriAdres"].ToString();
                            SqlCommand com6 = new SqlCommand("Insert into Sepet (UrunAdi,UrunFiyati,UrunAgirligi,UrunAdedi) values (@a,@b,@c,@d)", con);
                            Urun urun5 = new Urun { Fiyat = Convert.ToInt32(ps5Fiyati.Text) * Convert.ToInt32(musterimenutextbox.Text), Agirlik = Convert.ToInt32(ps5Agirlik.Text) * Convert.ToInt32(musterimenutextbox.Text), UrunAdi = "ps5", UrunAdedi = Convert.ToInt32(musterimenutextbox.Text) };
                            m.Urunler.Add(urun5);
                            com6.Parameters.AddWithValue("@a", urun5.UrunAdi);
                            com6.Parameters.AddWithValue("@b", urun5.Fiyat);
                            com6.Parameters.AddWithValue("@c", urun5.Agirlik);
                            com6.Parameters.AddWithValue("@d", urun5.UrunAdedi);
                            com6.ExecuteNonQuery();
                            SqlCommand cmnd5 = new SqlCommand("Insert into SiparişKaydı  (kullanıcıAdi,UrunAdi,UrunFiyat,UrunAgirligi,UrunAdet,Adres) values (@k,@a,@b,@c,@d,@z)", con);
                            cmnd5.Parameters.AddWithValue("@k", KullanıcıGirisi.kullanıcı);
                            cmnd5.Parameters.AddWithValue("@a", urun5.UrunAdi);
                            cmnd5.Parameters.AddWithValue("@b", urun5.Fiyat);
                            cmnd5.Parameters.AddWithValue("@c", urun5.Agirlik);
                            cmnd5.Parameters.AddWithValue("@d", urun5.UrunAdedi);
                            cmnd5.Parameters.AddWithValue("@z", adres5);
                            cmnd5.ExecuteNonQuery();
                            ps5.BackColor = Color.White;
                            break;
                    }

                    
                }

            }
            con.Close();
        }

        public void sepetimbutton_Click(object sender, EventArgs e)
        {

            sepetim sepet = new sepetim();
            sepet.Show();
            this.Hide();
           
            
        }

        private void macbookAgirlik_Click(object sender, EventArgs e)
        {

        }

        private void Musterimenu_Load_1(object sender, EventArgs e)
        {

        }
    }
}
