using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace tryprojectpoffor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        veritabanibag baglanti = new veritabanibag();
        MySqlCommand komut = new MySqlCommand();
        GlobalClass sinif = new GlobalClass();
        private void Form1_Load(object sender, EventArgs e)
        {
            KayitSayfasigrbox.Hide();
            HesapKurtarmagrbox.Hide();
            GirisSayfasigrbox.Show();
            komut.CommandText = "SELECT * FROM hesaplar";
            komut.Connection = baglanti.baglan();
            MySqlDataReader okuyucu = komut.ExecuteReader();
            while(okuyucu.Read())
            {
                sinif.hesaplar.Add(okuyucu["Kadi"], okuyucu["sifre"]);
               sinif.eposta.Add(okuyucu["Kadi"], okuyucu["eposta"]);
            }
            komut.Connection.Close();
        }
        private void KayitOlbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (KayitKaditxt.Text == "" || KayitSifretxt.Text == "" || KayitSifreTekraritxt.Text == "" | KayitPostatxt.Text == "") MessageBox.Show("Boş yer bırakılmamalı.");
                else
                {
                    if (sinif.hesaplar.ContainsKey(KayitKaditxt.Text)) MessageBox.Show("Zaten bu kullanıcı adı kullanılıyor.");
                    else if (sinif.eposta.ContainsValue(KayitPostatxt.Text)) MessageBox.Show("Zaten bu posta kullanılıyor.");
                    else
                    {
                        if (KayitPostatxt.Text.Contains("@") && KayitPostatxt.Text.Contains(".com"))
                        {
                            Boolean sa = false;
                                komut.CommandText = "SELECT * FROM hesaplar";
                                komut.Connection = baglanti.baglan();
                                MySqlDataReader ok = komut.ExecuteReader();
                                while (ok.Read())
                                {
                                    if (ok["eposta"].ToString() == KayitPostatxt.Text)
                                    {
                                        sa = true;
                                    }
                                }
                                komut.Connection.Close();
                                if (sa == true) MessageBox.Show("Bu eposta zaten kullanılıyor.", "kitapçım.com", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                else
                                {
                                    komut = new MySqlCommand("INSERT INTO hesaplar(Kadi, sifre, eposta) VALUES (@Kadi, @sifre, @eposta)");
                                    komut.Parameters.AddWithValue("@Kadi", KayitKaditxt.Text);
                                    komut.Parameters.AddWithValue("@sifre", KayitSifretxt.Text);
                                    komut.Parameters.AddWithValue("@eposta", KayitPostatxt.Text);
                                    komut.Connection = baglanti.baglan();
                                    komut.ExecuteNonQuery();
                                    komut.Connection.Close();
                                    sinif.hesaplar.Add(KayitKaditxt.Text, KayitSifretxt.Text);
                                    sinif.eposta.Add(KayitKaditxt.Text, KayitPostatxt.Text);
                                    MessageBox.Show("Başarıyla Kayıt Oluşturuldu!", "kitapçım.com", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    KayitSayfasigrbox.Hide();
                                    GirisSayfasigrbox.Show();
                                    KayitPostatxt.Text = "";
                                    KayitSifreTekraritxt.Text = "";
                                    KayitSifretxt.Text = "";
                                    KayitKaditxt.Text = "";
                                }
                            }
                        else MessageBox.Show("Geçersiz E-Posta","kitapçım.com",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {

                MessageBox.Show("Hata! Lütfen tekrar deneyiniz./n İpucu: Eğer bu hatayı bir çok kez aldıysanız, bağlantı sorununuz var demektir..", "kitapçım.com", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Girisbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (sinif.hesaplar[GirisKaditxt.Text].ToString() == GirisSifretxt.Text)
                {
                    Boolean sa = false;
                    komut.CommandText = "SELECT * FROM sayfayonetimi";
                    komut.Connection = baglanti.baglan();
                    MySqlDataReader oku = komut.ExecuteReader();
                    while(oku.Read())
                    {
                        if (oku["Kadi"].ToString() == GirisKaditxt.Text)
                        {
                            sa = true;
                        }
                    }
                    if(sa == true)
                    {
                        DialogResult areusure = MessageBox.Show("Merhaba! Yetkili olduğunuzu fark ettik, Yönetim Paneline Geçmek İster Misiniz?", "kitapçım.com || Evete basarsanız, Yönetim Paneli Açılır, Hayır 'a basarsanız mağazaya yönlendirir.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (areusure == DialogResult.Yes)
                        {
                            try
                            { GlobalClass.kullanici.Add(1, GirisKaditxt.Text); }
                            catch { GlobalClass.kullanici[1] = GirisKaditxt.Text.ToString(); }
                            adminform s = new adminform();
                            s.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Başarıyla Giriş Yaptınız!", "kitapçım.com", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            try
                            { GlobalClass.kullanici.Add(1, GirisKaditxt.Text); }
                            catch { GlobalClass.kullanici[1] = GirisKaditxt.Text.ToString(); }
                            GirisKaditxt.Text = "";
                            GirisSifretxt.Text = "";
                            Form2 s = new Form2();
                            s.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Başarıyla Giriş Yaptınız!", "kitapçım.com", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        try
                        { GlobalClass.kullanici.Add(1, GirisKaditxt.Text); }
                        catch { GlobalClass.kullanici[1] = GirisKaditxt.Text.ToString(); }
                        GirisKaditxt.Text = "";
                        GirisSifretxt.Text = "";
                        Form2 s = new Form2();
                        s.Show();
                        this.Hide();
                    }
                }
                else if (sinif.hesaplar[GirisSifretxt.Text].ToString() == GirisKaditxt.Text) MessageBox.Show("Şifre yanlış!", "kitapçım.com", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Hesap bulunamadı. Lütfen tekrar deneyiniz.", "kitapçım.com", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            catch
            { MessageBox.Show("Hata! Lütfen tekrar deneyiniz.", "kitapçım.com",MessageBoxButtons.OK,MessageBoxIcon.Error); }
        }

        private void HesapSaveKurtar_Click(object sender, EventArgs e)
        {
            try
            {
                if (sinif.eposta.ContainsKey(HesapSavekaditxt.Text) && sinif.eposta.ContainsValue(HesapSavepostatxt.Text))
                {
                    if (sinif.eposta[HesapSavekaditxt.Text].ToString() == HesapSavepostatxt.Text)
                    {
                        HesapSavelabel.Text = "Şifre: " + sinif.hesaplar[HesapSavekaditxt.Text].ToString() + "";
                        HesapSavekaditxt.Text = "";
                        HesapSavepostatxt.Text = "";
                    }
                    else MessageBox.Show("E-Posta ile şifre eşleşmiyor.");
                }
                else
                {
                    MessageBox.Show("hesabınız bulunamadı!");
                }
            }
            catch
            {
                MessageBox.Show("Hata! Hesabınız bulunamadı!");
            }
        }

        private void GirisHesabimYkbtn_Click(object sender, EventArgs e)
        {
            GirisSayfasigrbox.Hide();
            KayitSayfasigrbox.Show();
        }

        private void GirisSifreUnuttimbtn_Click(object sender, EventArgs e)
        {
            GirisSayfasigrbox.Hide();
            HesapKurtarmagrbox.Show();
        }

        private void HesapSaveGeri_Click(object sender, EventArgs e)
        {
            HesapKurtarmagrbox.Hide();
            GirisSayfasigrbox.Show();
        }

        private void Kayitztnhesabinvarbtn_Click(object sender, EventArgs e)
        {
            KayitSayfasigrbox.Hide();
            GirisSayfasigrbox.Show();
        }

        private void KayitYardimbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kayıt olmak için, Kullanıcı adı yazan yerin karşısındaki beyaz yere koymak istediğiniz kullanıcı adınızı, altındaki şifre yazan yerin karşısına şifrenizi, ardından şifre tekrarını ve e postanızı yazmanız yeterli olacaktır.", "kitapçım.com");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
    public class GlobalClass
    {
        public SortedList hesaplar = new SortedList();
        public static SortedList kullanici = new SortedList();
        public SortedList eposta = new SortedList();
    }
}