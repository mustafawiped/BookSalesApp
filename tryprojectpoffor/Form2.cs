using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace tryprojectpoffor
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        GlobalClass globalform1 = new GlobalClass();
        DataTable tablo = new DataTable();
        DataTable tablo2 = new DataTable();
        private void Form2_Load(object sender, EventArgs e)
        {
            urunler2grbox.Hide();
            urunlergrbox.Show();
            odemegrbox.Hide();
            sepetgrbox.Show();
            tablo.Columns.Add("Kitap Adı", typeof(string));
            tablo.Columns.Add("Kitap Yazarı", typeof(string));
            tablo.Columns.Add("Fiyatı", typeof(double));
            dataGridView1.DataSource = tablo;
            btnUrunsil.Enabled = false;
            btnOdemeYap.Enabled = false;
        }
        veritabanibag baglanti = new veritabanibag();
        MySqlCommand komut = new MySqlCommand();
        public double siparistutari = 0;

        private void button3_Click(object sender, EventArgs e)
        {
            siparistutari += 34.99;
            btnUrunsil.Enabled = true;
            btnOdemeYap.Enabled = true;
            lblToplamOdenecek.Text = "";
            lblToplamOdenecek.Text += siparistutari.ToString();
            tablo.Rows.Add("Venüs Projesi", "İlker Korkutlar", 34.99);
            dataGridView1.DataSource = tablo;
            MessageBox.Show("Başarıyla Sipariş Sepetine Eklendi!", "kitapçım.com",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kitap İsmi = Venüs Projesi, Yazar = İlker Korkutlar, Konusu = Yıl 2045, dünyanın bildiğimiz gibi olmadığı zamanlar… Yeryüzünde yalnızca Venüs Topluluğu var. Önceki dünyadan seçilen yüz bin kadın, yapay zekâ Quantus tarafından yönetilen toplulukta uyum içinde yaşarken bir yandan da büyük felaketten sonra hayatta kalanları arıyor. Quantus’un raporlarına göre henüz kimseye rastlanmasa da gerçek bundan ibaret olabilir mi?", "kitapçım.com.tr", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            btnUrunsil.Enabled = true;
            btnOdemeYap.Enabled = true;
            siparistutari += 29.99;
            lblToplamOdenecek.Text = "";
            lblToplamOdenecek.Text += siparistutari.ToString();
            tablo.Rows.Add("Maze Runer", "James Dashner", 29.99);
            dataGridView1.DataSource = tablo;
            MessageBox.Show("Başarıyla Sipariş Sepetinize Eklendi!", "kitapçım.com", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kitap İsmi = Maze Runner, Yazar = James Dashner, Konusu = Thomas bir anda uyanır ve yukarı doğru hareket halindeki bir asansörde olduğunu fark eder. Asansörün kapıları açılır ve karşısında kendi yaşlarında bir grup genci görür. ... Tek bildikleri şey ise her sabah labirente gidilen dev bir kapının açıldığıdır. Güneş batarken ise her akşam kapı kapanır.", "kitapçım.com.tr", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            btnUrunsil.Enabled = true;
            btnOdemeYap.Enabled = true;
            siparistutari += 46.99;
            lblToplamOdenecek.Text = "";
            lblToplamOdenecek.Text += siparistutari.ToString();
            tablo.Rows.Add("Sherlock Holmes", "Arthur Conan Doyle", 46.99);
            dataGridView1.DataSource = tablo;
            MessageBox.Show("Başarıyla Sipariş Sepetinize Eklendi!", "kitapçım.com", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kitap İsmi = Sherlock Holmes, Yazar = Arthur Conan Doyle, Konusu = Bir suçu çözmenin ilk prensiplerinden biri, her ne kadar önemsiz gibi görünse de hiçbir ayrıntıyı atlamamaktır. İnsanın göz ardı ettiği şeyleri görmek, sonuca ulaşmanın ilk kuralıdır. Araştırmanız ayrıntıların gözlemlenmesi üzerine kurulu olduğunda, en doğru sonuca vardığınızı siz de göreceksiniz.", "kitapçım.com.tr", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            btnUrunsil.Enabled = true;
            btnOdemeYap.Enabled = true;
            siparistutari += 24.99;
            lblToplamOdenecek.Text = "";
            lblToplamOdenecek.Text += siparistutari.ToString();
            tablo.Rows.Add("Çalıkuşu", "Reşat Nuri Gültekin", 24.99);
            dataGridView1.DataSource = tablo;
            MessageBox.Show("Başarıyla Sipariş Sepetinize Eklendi!", "kitapçım.com", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kitap İsmi = Çalıkuşu, Yazar = Reşat Nuri Gültekin, Konusu = çalışkan başarılı fakat zaaf gösterenlere karşı acımasız olan Zehra Öğretmen ile babası Mürşit'in bakış açılarından dramatik yaşam öykülerini anlatıyor. Yazar, cumhuriyet öncesinde yeni mezun, idealist genç bir mülkiyelinin iş ve sosyal yaşamdaki çatışmalarını ve uyumsuz ilişkilerini anlatırken, dönemin memuriyet yaşamına, köhne yapısına ait önemli ipuçları da veriyor. Şehirden kasabalara sürüklenirken, ardında birer birer ilkelerini de bırakan genç adam hatalı bir evlilikle korkunç bir sona doğru sürükleniyor. Acı ve sefaletle dolu ortamdan tesadüfle sadece kızı Zehra'yı kurtarabiliyor.", "kitapçım.com.tr", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            btnUrunsil.Enabled = true;
            btnOdemeYap.Enabled = true;
            siparistutari += 59.99;
            lblToplamOdenecek.Text = "";
            lblToplamOdenecek.Text += siparistutari.ToString();
            tablo.Rows.Add("İnsancıklar", "Dosteyevski", 59.99);
            dataGridView1.DataSource = tablo;
            MessageBox.Show("Başarıyla Sipariş Sepetinize Eklendi!", "kitapçım.com", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kitap İsmi = İnsancıklar, Yazar = Dosteyevski, Konusu = Yıl 1846'dır. Genç Dostoyevski, ilk romanı İnsancıklar'ı tamamlar tamamlamaz ev arkadaşı yazar Grigoroviç'e okutur. Grigoroviç o kadar heyecanlanır ki birkaç kez kalkıp Fyodor'un boynuna sarılmak ister; fakat arkadaşının aşırı duygu gösterilerinden hoşlanmadığını bildiği için yapmaz. Grigoroviç ertesi gün romanı yazar ve yayımcı Nekrasov'a götürür; kitaptan çok etkilenen Nekrasov da eleştirmen Belinski'ye... 'Yeni Gogol doğdu!' der, Nekrasov, daha kapı ağzında.", "kitapçım.com.tr", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            btnUrunsil.Enabled = true;
            btnOdemeYap.Enabled = true;
            siparistutari += 64.99;
            lblToplamOdenecek.Text = "";
            lblToplamOdenecek.Text += siparistutari.ToString();
            tablo.Rows.Add("Ölüm Şatosu", "Benoit Becker", 64.99);
            dataGridView1.DataSource = tablo;
            MessageBox.Show("Başarıyla Sipariş Sepetinize Eklendi!", "kitapçım.com", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kitap İsmi = Ölüm Şatosu, Yazar = Benoit Becker, Konusu = Aniden sıçradı... Aşağıda, koridorun sonunda, bir şey kımıldamıştı. Evet bundan emindi; geceliğe benzeyen beyaz bir şeyin; karanlıkta belirip kaybolduğunu gördüğüne emindi. Bütün gücüyle, soğukkanlı olmaya, kendini toparlamaya gayret etti: Yok canım !..Gülünç bir şeydi bu, insan böylesine koyu bir karanlığa bakınca gözlerinin önünden beyaz şekillerin geçtiğini görür gibi olurdu.", "kitapçım.com.tr", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            btnUrunsil.Enabled = true;
            btnOdemeYap.Enabled = true;
            siparistutari += 19.99;
            lblToplamOdenecek.Text = "";
            lblToplamOdenecek.Text += siparistutari.ToString();
            tablo.Rows.Add("Yüzyıllık Yalnızlık", "Gabriel García Márquez", 19.99);
            dataGridView1.DataSource = tablo;
            MessageBox.Show("Başarıyla Sipariş Sepetinize Eklendi!", "kitapçım.com", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kitap İsmi = Yüzyıllık Yalnızlık, Yazar = Gabriel García Márquez, Konusu = Yüzyıllık Yalnızlık'ı yazmaya başladığımda, çocukluğumda beni etkilemiş olan her şeyi edebiyat aracılığıyla aktarabileceğim bir yol bulmak istiyordum. Çok kasvetli kocaman bir evde, toprak yiyen bir kız kardeş, geleceği sezen bir büyükanne ve mutlulukla çılgınlık arasında ayrım gözetmeyen, adları bir örnek bir yığın hısım akraba arasında geçen çocukluk günlerimi sanatsal bir dille ardımda bırakmaktı amacım.", "kitapçım.com.tr", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button17_Click(object sender, EventArgs e)
        {
                        btnUrunsil.Enabled = true;
            btnOdemeYap.Enabled = true;
            siparistutari += 99.99;
            lblToplamOdenecek.Text = "";
            lblToplamOdenecek.Text += siparistutari.ToString();
            tablo.Rows.Add("Kalbi Kırık", "Amelia Kahaney", 99.99);
            dataGridView1.DataSource = tablo;
            MessageBox.Show("Başarıyla Sipari Sepetinize Eklendi!", "kitapçım.com", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kitap İsmi = Kalbi Kırık, Yazar = Amelia Kahaney, Konusu = Bedlam'ın güvenli Kuzey Yakası'nda, bir gökdelenin çatı katında, ailemin belirlediği katı kurallara göre yaşayan 17 yaşında bir kızdım. Bu dünyada beni mutlu eden tek şey baleydi. ta ki tehlikeli Güney Yakası'ndan Gavin adında genç bir ressamla tanışana kadar. Gavin, o güne kadar tanıdığım kimseye benzemiyordu, kısa sürede birbirimizin her şeyi olduk. O korkunç gecede Gavin'ı benden çaldıklarında aklımdaki tek şey onu kurtarmaktı ama gözlerimi açtığımda kanla kaplı bir laboratuardaydım ve göğsümde bir yara izi vardı. Garip bir deneyin sonucu olarak kalbim benden alınmıştı ama karşılığında insanüstü güçlere kavuşmuştum. Artık almam gereken bir intikam ve suçlulardan temizleyeceğim bir şehir vardı", "kitapçım.com.tr", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUrunsil_Click(object sender, EventArgs e)
        {
           try
            {
                string miktar; double miktar2, toplamodenecek, yeni;
                miktar = ""; miktar2 = 0; toplamodenecek = 0; yeni = 0;
                miktar = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                miktar2 = Convert.ToDouble(miktar);
                toplamodenecek = Convert.ToDouble(lblToplamOdenecek.Text);
                yeni = toplamodenecek - miktar2;
                lblToplamOdenecek.Text = "";
                siparistutari = siparistutari - miktar2;
                lblToplamOdenecek.Text = yeni.ToString();
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
           catch { MessageBox.Show("Lütfen Sipariş Seçiniz.","kitapçım.com",MessageBoxButtons.OK,MessageBoxIcon.Error); }
        }

        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            sepetgrbox.Hide();
            odemegrbox.Show();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            odemegrbox.Hide();
            sepetgrbox.Show();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(kredikartiradiobtn.Checked == true)
            {
                cvvtxt.Enabled = true;
                kredikartitxtbox.Enabled = true;
                sktarihitxt.Enabled = true;
            }
            else
            {
                cvvtxt.Enabled = false;
                kredikartitxtbox.Enabled = false;
                sktarihitxt.Enabled = false;
            }
        }

        private void btnSipariset_Click(object sender, EventArgs e)
        {
            string kullanici = GlobalClass.kullanici[1].ToString();
            if (sehirtxt.Text == "" || ilcetxt.Text == "" || mahalletxt.Text == "" || sokaktxt.Text == "" || binanotxt.Text == "" || dairenotxt.Text == "") MessageBox.Show("Lütfen adres bilgilerinizi eksiksiz ve doğru bir şekilde doldurun.", "kitapçım.com", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    if (kapidaodemeradiobtn.Checked == true)
                    {
                        DialogResult eminmisin = MessageBox.Show("Kapıda ödeme yaparsanız eğer, ücrete ekstra +10 TL eklenecektir, Onaylıyor Musunuz?", "kitapçım.com.tr", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (eminmisin == DialogResult.Yes)
                        { }
                    }
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        komut = new MySqlCommand("INSERT INTO siparisler(kullaniciadi, kitapadi, kitapyazari, kitapfiyati) VALUES (@kadi, @kitapadi, @kitapyazari, @kitapfiyati)", baglanti.baglan());
                        komut.Parameters.AddWithValue("@kadi", kullanici.ToString());
                        komut.Parameters.AddWithValue("@kitapadi", dataGridView1.Rows[i].Cells[0].Value.ToString());
                        komut.Parameters.AddWithValue("@kitapyazari", dataGridView1.Rows[i].Cells[1].Value.ToString());
                        komut.Parameters.AddWithValue("@kitapfiyati", (dataGridView1.Rows[i].Cells[2].Value.ToString()));
                        komut.Connection = baglanti.baglan();
                        komut.ExecuteNonQuery();
                        komut.Connection.Close();
                    }
                    odemegrbox.Hide();
                    sepetgrbox.Show();
                    for (int z = 0; z < dataGridView1.Rows.Count; z++)
                    {
                        dataGridView1.Rows.RemoveAt(z);
                    }
                try
                {
                    int selectedIndex = dataGridView1.CurrentCell.RowIndex;
                    dataGridView1.Rows.RemoveAt(selectedIndex);
                }
                catch { }
                    lblToplamOdenecek.Text = "";
                    siparistutari = 0;
                    sehirtxt.Text = ""; ilcetxt.Text = ""; mahalletxt.Text = ""; sokaktxt.Text = ""; binanotxt.Text = ""; dairenotxt.Text = ""; kredikartitxtbox.Text = ""; sktarihitxt.Text = ""; cvvtxt.Text = "";
                    MessageBox.Show("Başarıyla Siparişleriniz bize ulaştı! 1-3 İş Günü aralığında sizlere ulaşacaktır! kitapçım.com 'u tercih ettiğiniz için teşekkürler!", "kitapçım.com.tr", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch { MessageBox.Show("Hata! Lütfen tekrar deneyiniz.", "kitapçım.com", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex == 1)
            {
                tablo2.Clear();
                tablo2.Columns.Clear();
                tablo2.Columns.Add("Sipariş No", typeof(int));
                tablo2.Columns.Add("Kitap Adı", typeof(string));
                tablo2.Columns.Add("Kitap Yazarı", typeof(string));
                tablo2.Columns.Add("Fiyatı", typeof(double));
                listeSiparisler.DataSource = tablo2;
                komut = new MySqlCommand("SELECT * FROM siparisler", baglanti.baglan());
                komut.Connection = baglanti.baglan();
                MySqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    if (oku["kullaniciadi"].ToString() == GlobalClass.kullanici[1].ToString())
                    {
                        tablo2.Rows.Add(oku["siparisid"], oku["kitapadi"].ToString(), oku["kitapyazari"].ToString(), oku["kitapfiyati"].ToString());
                        
                    }
                }
                komut.Connection.Close();
                listeSiparisler.DataSource = tablo2;
            }
            if(tabControl1.SelectedIndex == 2)
            {
                istekcmbox.SelectedIndex = 0;
                komut.CommandText = "SELECT * FROM hesaplar";
                komut.Connection = baglanti.baglan();
                MySqlDataReader oku = komut.ExecuteReader();
                while(oku.Read())
                {
                    if(oku["Kadi"].ToString() == GlobalClass.kullanici[1].ToString())
                    {
                        label30.Text = oku["Kadi"].ToString();
                        label31.Text = oku["sifre"].ToString();
                        label32.Text = oku["eposta"].ToString();
                    }
                }
                komut.Connection.Close();

                // sağ taraf
                talepyenile();
            }
        }

        private void btnSiparisİptal_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult areusure = MessageBox.Show("Seçilen siparişi iptal etmek istediğine emin misin? :/", "kitapçım.com.tr", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (areusure == DialogResult.Yes)
                {
                    komut.Connection = baglanti.baglan();
                    komut.CommandText = "DELETE FROM siparisler WHERE siparisid = '" + listeSiparisler.CurrentRow.Cells[0].Value.ToString() + "'";
                    komut.ExecuteNonQuery();
                    komut.Connection.Close();
                    MessageBox.Show("Başarıyla siparişiniz iptal edildi!", "kitapçım.com", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    guncelle();
                }
                else { }
            }
            catch
            {
                MessageBox.Show("Hata! Lütfen listeden siparişiniz seçtiğinize emin olun!", "kitapçım.com.tr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnListeGuncelle_Click(object sender, EventArgs e)
        {
            guncelle();
        }
        private void guncelle()
        {
            tablo2.Clear();
            tablo2.Columns.Clear();
            tablo2.Columns.Add("Sipariş No", typeof(int));
            tablo2.Columns.Add("Kitap Adı", typeof(string));
            tablo2.Columns.Add("Kitap Yazarı", typeof(string));
            tablo2.Columns.Add("Fiyatı", typeof(double));
            listeSiparisler.DataSource = tablo2;
            komut = new MySqlCommand("SELECT * FROM siparisler", baglanti.baglan());
            komut.Connection = baglanti.baglan();
            MySqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (oku["kullaniciadi"].ToString() == GlobalClass.kullanici[1].ToString())
                {
                    tablo2.Rows.Add(oku["siparisid"], oku["kitapadi"].ToString(), oku["kitapyazari"].ToString(), oku["kitapfiyati"].ToString());

                }
            }
            komut.Connection.Close();
            listeSiparisler.DataSource = tablo2;
            MessageBox.Show("Başarıyla Liste Güncellendi!", "kitapçım.com", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void guncellebtn_Click(object sender, EventArgs e)
        {
            if (sifredegistircheck.Checked == false && epostadegistircheck.Checked == false) MessageBox.Show("Lütfen eposta mı yoksa şifre mi değiştireceğinizi seçiniz.", "kitapçım.com", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    if (sifredegistircheck.Checked == true && epostadegistircheck.Checked == false)
                    {
                        komut = new MySqlCommand("UPDATE hesaplar SET sifre = @sifre WHERE Kadi = '" + GlobalClass.kullanici[1].ToString() + "'", baglanti.baglan());
                        komut.Parameters.AddWithValue("@sifre", sifretxt.Text.ToString());
                        komut.Connection = baglanti.baglan();
                        komut.ExecuteNonQuery();
                        komut.Connection.Close();
                        globalform1.hesaplar[GlobalClass.kullanici[1].ToString()] = sifretxt.Text.ToString();
                        label31.Text = sifretxt.Text.ToString();
                        MessageBox.Show("Başarıyla Şifreniz Güncellendi!", "kitapçım.com", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (epostadegistircheck.Checked == true && sifredegistircheck.Checked == false)
                    {
                        Boolean sa = false;
                        if (epostatxt.Text.Contains("@") && epostatxt.Text.Contains(".com"))
                        {
                            komut.CommandText = "SELECT * FROM hesaplar";
                            komut.Connection = baglanti.baglan();
                            MySqlDataReader ok = komut.ExecuteReader();
                            while (ok.Read())
                            {
                                if (ok["eposta"].ToString() == epostatxt.Text)
                                {
                                    sa = true;
                                }
                            }
                            komut.Connection.Close();
                            if (sa == true) MessageBox.Show("Bu eposta zaten kullanılıyor.", "kitapçım.com", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else
                            {
                                komut = new MySqlCommand("UPDATE hesaplar SET eposta = @eposta WHERE Kadi = '" + GlobalClass.kullanici[1].ToString() + "'", baglanti.baglan());
                                komut.Parameters.AddWithValue("@eposta", epostatxt.Text.ToString());
                                komut.Connection = baglanti.baglan();
                                komut.ExecuteNonQuery();
                                komut.Connection.Close();
                                globalform1.eposta[GlobalClass.kullanici[1].ToString()] = epostatxt.Text.ToString();
                                label32.Text = epostatxt.Text.ToString();
                                MessageBox.Show("Başarıyla Epostanız Güncellendi!", "kitapçım.com", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else { MessageBox.Show("Lütfen geçerli bir eposta adresi giriniz.", "kitapçım.com.tr"); }
                    }
                    else if (epostadegistircheck.Checked == true && sifredegistircheck.Checked == true)
                    {
                        if (epostatxt.Text.Contains("@") && epostatxt.Text.Contains(".com"))
                        {
                            Boolean sa = false;
                            if (epostatxt.Text.Contains("@") && epostatxt.Text.Contains(".com"))
                            {
                                komut.CommandText = "SELECT * FROM hesaplar";
                                komut.Connection = baglanti.baglan();
                                MySqlDataReader ok = komut.ExecuteReader();
                                while (ok.Read())
                                {
                                    if (ok["eposta"].ToString() == epostatxt.Text)
                                    {
                                        sa = true;
                                    }
                                }
                                komut.Connection.Close();
                                if (sa == true) MessageBox.Show("Bu eposta zaten kullanılıyor.", "kitapçım.com", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                else
                                {
                                    komut = new MySqlCommand("UPDATE hesaplar SET sifre = @sifre, eposta = @eposta WHERE Kadi = '" + GlobalClass.kullanici[1].ToString() + "'", baglanti.baglan());
                                    komut.Parameters.AddWithValue("@sifre", sifretxt.Text.ToString());
                                    komut.Parameters.AddWithValue("@eposta", epostatxt.Text.ToString());
                                    komut.Connection = baglanti.baglan();
                                    komut.ExecuteNonQuery();
                                    komut.Connection.Close();
                                    globalform1.hesaplar[GlobalClass.kullanici[1].ToString()] = sifretxt.Text.ToString();
                                    globalform1.eposta[GlobalClass.kullanici[1].ToString()] = epostatxt.Text.ToString();
                                    label31.Text = sifretxt.Text.ToString();
                                    label32.Text = epostatxt.Text.ToString();
                                    MessageBox.Show("Başarıyla Şifreniz ve Epostanız Güncellendi!", "kitapçım.com", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else { MessageBox.Show("Lütfen geçerli bir eposta adresi giriniz.", "kitapçım.com"); }
                        }
                    }
                }
                catch { MessageBox.Show("Hata! Lütfen tekrar deneyiniz.", "kitapçım.com.tr", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
        }

        private void btnTalepGonder_Click(object sender, EventArgs e)
        {
            if (istekcmbox.SelectedIndex == 0 || txtKonu.Text == "" || txtMesaj.Text == "") MessageBox.Show("Lütfen İleti gönderirken boş yer bırakmayın.", "kitapçım.com.tr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (listTalepler.Items.Contains(txtKonu.Text.ToString())) MessageBox.Show("Lütfen Başka bir konu hakkında talep gönderin, zaten böyle bir talep gönderdiniz.", "kitapçım.com.tr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    try
                    {
                        komut = new MySqlCommand("INSERT INTO talepler(Kadi, konu, talebi) VALUES (@kadi, @konu, @talebi)", baglanti.baglan());
                        komut.Parameters.AddWithValue("@kadi", GlobalClass.kullanici[1].ToString());
                        komut.Parameters.AddWithValue("@konu", txtKonu.Text.ToString());
                        komut.Parameters.AddWithValue("@talebi", txtMesaj.Text.ToString());
                        komut.Connection = baglanti.baglan();
                        komut.ExecuteNonQuery();
                        komut.Connection.Close();
                        talepyenile();
                        MessageBox.Show("Başarıyla İletiniz Bizlere ulaştı! bize değer verip ileti gönderdiğiniz için teşekkür ederiz. Sizlere en kısa süre içerisinde mail yoluyla iletişim kuracağaız.", "kitapçım.com", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch { MessageBox.Show("Hata! Lütfen Tekrar Deneyiniz!", "kitapçım.com", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                int konu = listTalepler.SelectedIndex;
                komut.Connection = baglanti.baglan();
                MySqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    if (oku["konu"].ToString() == listTalepler.Items[konu].ToString())
                    {
                        MessageBox.Show(oku["talebi"].ToString());
                    }
                }
                komut.Connection.Close();
            }
            catch { MessageBox.Show("Hata! Lütfen sağdaki listeden talebinizi seçmeyi unutmayın!", "kitapçım.com.tr", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void talepyenile()
        {
            listTalepler.Items.Clear();
            komut.CommandText = "SELECT * FROM talepler";
            komut.Connection = baglanti.baglan();
            MySqlDataReader oku2 = komut.ExecuteReader();
            while (oku2.Read())
            {
                if (oku2["Kadi"].ToString() == GlobalClass.kullanici[1].ToString())
                {
                    listTalepler.Items.Add(oku2["konu"].ToString());
                }
            }
            komut.Connection.Close();
        }
        int id;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int konu = listTalepler.SelectedIndex;
                komut.CommandText = "SELECT * FROM talepler";
                komut.Connection = baglanti.baglan();
                MySqlDataReader oku2 = komut.ExecuteReader();
                while (oku2.Read())
                {
                    if (oku2["Kadi"].ToString() == GlobalClass.kullanici[1].ToString())
                    {
                        if(oku2["konu"].ToString() == listTalepler.Items[konu].ToString())
                        {
                            string sa = oku2["talepid"].ToString();
                            id = Convert.ToInt32(sa);
                        }
                    }
                }
                komut.Connection.Close();

                komut.Connection = baglanti.baglan();  
                komut.CommandText = "DELETE FROM talepler WHERE talepid = '" + id + "'"; 
                komut.ExecuteNonQuery();    
                komut.Connection.Close(); 
                MessageBox.Show("Talebiniz Başarıyla Silindi! ", "kitapçım.com", MessageBoxButtons.OK, MessageBoxIcon.Information);
                talepyenile();
            }
            catch 
            {
                MessageBox.Show("Hata! Lütfen tekrar deneyiniz.", "kitapçım.com", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
                GlobalClass.kullanici[1] = "";
                this.Hide();
                Form1 a = new Form1();
                a.Show();   
        }

        private void button21_Click(object sender, EventArgs e)
        {
            MessageBox.Show("kitapçım.com Ainsoft Corp. Anonim Şirketi tarafından kodlanmıştır. Asıl amacımız basım evleri ile müşterilerimize aracılık etmektir. kitapçım.com 'dan En uygun fiyata kitap satın alabilirsiniz. Marka Geliştiricisi & Kurucusu ve Ainsoft Corp. Şirketinin sahibi Mustafa Gür 'dür.", "kitapçım.com.tr", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bizlere 'Hesap Ayarları' kısmından ister talep gönderin, ister info@kitapcim.com mail adresimiz üzerinden mail gönderin. Müşterilerimize daimi hizmetler vermekten gurur duyuyoruz.", "kitapçım.com", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnYanSayfa_Click(object sender, EventArgs e)
        {
            urunlergrbox.Hide();
            urunler2grbox.Show();
        }

        private void btnOncekiSayfa_Click(object sender, EventArgs e)
        {
            urunler2grbox.Hide();
            urunlergrbox.Show();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            btnUrunsil.Enabled = true;
            btnOdemeYap.Enabled = true;
            siparistutari += 8.50;
            lblToplamOdenecek.Text = "";
            lblToplamOdenecek.Text += siparistutari.ToString();
            tablo.Rows.Add("Hayvan Çiftliği", "George Orwell", 8.50);
            dataGridView1.DataSource = tablo;
            MessageBox.Show("Başarıyla Sipariş Sepetinize Eklendi!", "kitapçım.com", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hayvan Çiftliği`nin başkişileri hayvanlardır. Bir çiftlikte yaşayan hayvanlar, kendilerini sömüren insanlara başkaldırıp çiftliğin yönetimini ele geçirir. Amaçları daha eşitlikçi bir topluluk oluşturmaktır. Aralarında en akıllı olan domuzlar, kısa sürede önder bir takım oluşturur; ama devrimi de yine onlar yolundan saptırır. Ne yazık ki insanlardan daha baskıcı, daha acımasız bir diktatörlük kurulmuştur artık. George Orwell, bu romanında tarihsel bir gerçeği eleştirmektedir. Romandaki önder domuzun, düpedüz Stalin`i simgelediği açıktır. Diğer kahramanlar gerçek kişileri çağrıştırmasalar da, bir diktatörlük ortamında olabilecek kişilerdir.", "kitapçım.com.tr", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            btnUrunsil.Enabled = true;
            btnOdemeYap.Enabled = true;
            siparistutari += 20.99;
            lblToplamOdenecek.Text = "";
            lblToplamOdenecek.Text += siparistutari.ToString();
            tablo.Rows.Add("Kayıp Tanrılar Ülkesi", "Ahmet Ümit", 20.99);
            dataGridView1.DataSource = tablo;
            MessageBox.Show("Başarıyla Sipariş Sepetinize Eklendi!", "kitapçım.com", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Berlin Emniyet Müdürlüğü’nün cevval başkomiseri Yıldız Karasu ve yardımcısı Tobias Becker, göçmenlerin, işgal evlerinin ve sokak sanatçılarının renklendirdiği Berlin sokaklarından Bergama’ya uzanan bir macerada, hayatı ve insanları yok etmeye muktedir sırların peşinde bir seri cinayetler dizisini çözmeye çalışıyor. Soruşturmanın Türkiye ayağında sürpriz bir ismin olaya dahil olmasıyla heyecanın dozu gitgide artıyor.", "kitapçım.com.tr", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            btnUrunsil.Enabled = true;
            btnOdemeYap.Enabled = true;
            siparistutari += 14.99;
            lblToplamOdenecek.Text = "";
            lblToplamOdenecek.Text += siparistutari.ToString();
            tablo.Rows.Add("Kırmızı Pazartesi", "Gabriel García Márquez", 14.99);
            dataGridView1.DataSource = tablo;
            MessageBox.Show("Başarıyla Sipariş Sepetinize Eklendi!", "kitapçım.com", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kolombiyalı büyük yazar Gabriel García Márquez’in 1981’de yayımlanan yedinci romanı Kırmızı Pazartesi, işleneceğini herkesin bildiği, engel olmak için kimsenin bir şey yapmadığı bir namus cinayetinin öyküsü. Hem Kolombiya’da, hem de yayımlandığı dünyanın dört bir yanındaki pek çok ülkede sarsıcı etkileri olmuş bir roman. Usta yazar, çocukluğunu geçirdiği kasabada yıllar önce yaşanmış bir cinayet olayını aktarıyor. Romanın kahramanı Santiago Nasar’ın öldürüleceği daha ilk satırlardan belli, ancaksonun baştan belli olması, kitaba sürükleyiciliğinden bir şey kaybettirmiyor.", "kitapçım.com", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            btnUrunsil.Enabled = true;
            btnOdemeYap.Enabled = true;
            siparistutari += 55.00;
            lblToplamOdenecek.Text = "";
            lblToplamOdenecek.Text += siparistutari.ToString();
            tablo.Rows.Add("Kimse Gerçek Değil", "Zeynep Sey", 55.00);
            dataGridView1.DataSource = tablo;
            MessageBox.Show("Başarıyla Sipariş Sepetinize Eklendi!", "kitapçım.com", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İnsanları “Yaralılar” ve “Şifacılar” olarak iki kategoriye ayıran bir sosyal medya platformundan tanıştığı Oflaz Kantemiz’in, kendisini bu durumdan kurtaracak kahraman olduğunu düşünmektedir. Ancak geçmişi belirsiz, davranışları tutarsız olan bu gizemli adamın, kendi dünyasının yıkılışına şahitlik etmiş yaralı bir şifacı olduğundan bihaberdir.", "kitapçım.com", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            btnUrunsil.Enabled = true;
            btnOdemeYap.Enabled = true;
            siparistutari += 45.15;
            lblToplamOdenecek.Text = "";
            lblToplamOdenecek.Text += siparistutari.ToString();
            tablo.Rows.Add("Yere Yakın Yıldızlara Uzak", "Emine Tavuz", 45.15);
            dataGridView1.DataSource = tablo;
            MessageBox.Show("Başarıyla Sipariş Sepetinize Eklendi!", "kitapçım.com", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bestegül her sabah yaptığı gibi, o sabah da okula gitmek için evden ayrıldığında, kaderinin on üç diğer insanla birleşeceğini henüz bilmiyordu. O sabah metroya bindi ve son durağa kadar seyahat etti fakat son duraktan çıkamadı. Onunla beraber diğer on üç kişide metro istasyonunda mahsur kaldı ve o an ortak hikâyelerinin ilk kalp atışı  kulakları sağır etmeye başladı. Enkaz altında mücadele etmeleri gereken şeyler vardı. Açlık, susuzluk, özlem, keder, hüzün, ölüm...", "kitapçım.com", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            btnUrunsil.Enabled = true;
            btnOdemeYap.Enabled = true;
            siparistutari += 49.60;
            lblToplamOdenecek.Text = "";
            lblToplamOdenecek.Text += siparistutari.ToString();
            tablo.Rows.Add("Tayfların ve Yıkımın Şarkısı", "Roseanne A. Brown", 49.60);
            dataGridView1.DataSource = tablo;
            MessageBox.Show("Başarıyla Sipariş Sepetinize Eklendi!", "kitapçım.com", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Elli yılda bir gerçekleşen Solstasia Festivali, Malik için Ziran şehrinde kız kardeşleriyle yeni bir hayat kurma fırsatıydı. Fakat şehre girebilmek uğruna kindar bir ruhla ölümcül bir anlaşma yapması gerekecekti. Ziran`ın Veliaht Prensesi Karina`yı öldürmek zorunda kalacağı bir anlaşma… Karina’nın da ölümcül planları vardı.Hükümdarlık isyanla yüz yüze gelmenin eşiğindeyken, festival boynuna inmeyi bekleyen bir kılıç gibiydi.Bu kaosu yalnızca tek bir şey sona erdirebilirdi: Tahtın gerçek sahibini geri getirmek.Bunun için de yasaklı bir sihre ve… bir kralın kalbine ihtiyacı vardı.Sıradaki Solstasia Şampiyonu, kanla lekelenecek bir düğüne hazırlanmalıydı.","kitapçım.com",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            btnUrunsil.Enabled = true;
            btnOdemeYap.Enabled = true;
            siparistutari += 24.99;
            lblToplamOdenecek.Text = "";
            lblToplamOdenecek.Text += siparistutari.ToString();
            tablo.Rows.Add("Harry Potter - 1", "J. K. Rowling", 24.99);
            dataGridView1.DataSource = tablo;
            MessageBox.Show("Başarıyla Sipariş Sepetinize Eklendi!", "kitapçım.com", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            MessageBox.Show("“Harry, elleri titreyerek zarfı çevirince mor balmumundan bir mühür gördü; bir arma  koca bir ‘H’ harfinin çevresinde bir aslan, bir kartal, bir porsuk, bir de yılan.”Harry Potter sıradan bir çocuk olduğunu sanırken, bir baykuşun getirdiği mektupla yaşamı değişir: Başvurmadığı halde Hogwarts Cadılık ve Büyücülük Okulu’na kabul edilmiştir. Burada birbirinden ilginç dersler alır, iki arkadaşıyla birlikte maceradan maceraya koşar. Yaşayarak öğrendikleri sayesinde küçük yaşta becerikli bir büyücü olup çıkar.", "kitapçım.com", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            btnUrunsil.Enabled = true;
            btnOdemeYap.Enabled = true;
            siparistutari += 89.99;
            lblToplamOdenecek.Text = "";
            lblToplamOdenecek.Text += siparistutari.ToString();
            tablo.Rows.Add("Sesini Duyur", "M. Rise", 89.99);
            dataGridView1.DataSource = tablo;
            MessageBox.Show("Başarıyla Sipariş Sepetinize Eklendi!", "kitapçım.com", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gözleri artık kapalıydı. Gitarı çalmıyor, âdeta yaşıyordu. Bora Ateş, gözlerini sahneden tam benim olduğum yere dikince o an kalbimin duracağını hissettim. Mahşerî kalabalığın içinden beni bulabilmişti. Şarkıyı söyleyen Uygar’ın sesi ve baterinin başındaki Alar’ın ritimleri çok uzaklardan geliyor gibiydi. Bedenim uyuşmaya başlamıştı. Bora’nın dudakları yavaşça kıvrıldığında, gülüşü bedenime bir gök gürültüsü gibi çarptı.", "kitapçım.com", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          //  DataTable sa = new DataTable();
           // sa = tablo2.Copy();
           // DataView see = sa.DefaultView;
           // see.RowFilter = "Kitap Adı LIKE '%" + txtArama.Text + "%' OR Kitap Yazarı LIKE '%" + txtArama.Text + "%'";
           // listeSiparisler.DataSource = see;
        }
    }
}
