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
    public partial class adminform : Form
    {
        public adminform()
        {
            InitializeComponent();
        }

        MySqlCommand komut = new MySqlCommand();
        veritabanibag baglanti = new veritabanibag();
        DataTable tablo = new DataTable();
        DataTable tablo2 = new DataTable();
        string girisyapilanrutbe;
        GlobalClass globalclass = new GlobalClass();

        private void adminform_Load(object sender, EventArgs e)
        {
            cmboxRutbe.SelectedIndex = 0;
            komut.CommandText = "SELECT * FROM sayfayonetimi";
            komut.Connection = baglanti.baglan();
            MySqlDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
                if(oku["Kadi"].ToString() == GlobalClass.kullanici[1].ToString())
                {
                    girisyapilanrutbe = oku["rutbe"].ToString();
                }
            }
            komut.Connection.Close();
            lblrutbe.Text = girisyapilanrutbe.ToString();
            if (girisyapilanrutbe == "Destek Ekibi") grboxYonetim.Hide();
            else if (girisyapilanrutbe == "Yonetici")
            {
                btnYetkiVer.Enabled = false;
                cmboxRutbe.Enabled = false;
                btnYetkiAl.Enabled = false;
            }
            guncelle();
            kullaniciliste();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult s = MessageBox.Show("Giriş Ekranına Yönlendirilmek için 'EVET' i, Uygulamayı kapatmak için 'HAYIR' a basınız.", "kitapçım.com.tr", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if(s == DialogResult.Yes)
            {
                Form1 sa = new Form1();
                sa.Show();
                this.Hide();
            }
            else
            {
                Application.Exit();
            }
        }

        private void btnTalepGoster_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(destekTalepleri.CurrentRow.Cells[3].Value.ToString(), "Talep ID = " + destekTalepleri.CurrentRow.Cells[0].Value.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch { MessageBox.Show("Lütfen Seçim Yapınız.", "kitapçım.com", MessageBoxButtons.OK, MessageBoxIcon.Error); }
       }

        private void btnTalepSil_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult areusure = MessageBox.Show("Seçilen talebi iptal etmek istediğine emin misin? ", "kitapçım.com.tr", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (areusure == DialogResult.Yes)
                {
                    komut.Connection = baglanti.baglan();
                    komut.CommandText = "DELETE FROM talepler WHERE talepid = '" + destekTalepleri.CurrentRow.Cells[0].Value.ToString() + "'";
                    komut.ExecuteNonQuery();
                    komut.Connection.Close();
                    MessageBox.Show("Başarıyla talep iptal edildi!", "kitapçım.com", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    guncelle();
                }
                else { }
            }
            catch 
            {
                MessageBox.Show("Bağlantı Hatası! lütfen tekrar deneyiniz veya internet bağlantınızı kontrol ediniz.", "kitapçım.com", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void guncelle()
        {
            tablo.Columns.Clear();
            tablo.Clear();
            tablo.Columns.Add("Talep ID", typeof(int));
            tablo.Columns.Add("Kullanıcı Adı", typeof(string));
            tablo.Columns.Add("Konu", typeof(string));
            tablo.Columns.Add("Talebi", typeof(string));
            destekTalepleri.DataSource = tablo;
            komut.CommandText = "SELECT * FROM talepler";
            komut.Connection = baglanti.baglan();
            MySqlDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
                if(oku["konu"].ToString().Contains(" -CEVAPLANDI")) { }
                else
                {
                    tablo.Rows.Add(oku["talepid"].ToString(), oku["Kadi"].ToString(), oku["konu"], oku["talebi"].ToString());
                }
            }
            komut.Connection.Close();
            destekTalepleri.DataSource = tablo;
        }

        private void kullaniciliste()
        {
            tablo2.Columns.Clear();
            tablo2.Clear();
            MySqlDataAdapter datadapter = new MySqlDataAdapter("SELECT * FROM hesaplar", baglanti.baglan());
            datadapter.Fill(tablo2);
            kullanicilistesi.DataSource = tablo2;
            kullanicilistesi.Columns["Kadi"].HeaderText = "Kullanıcı Adı";
            kullanicilistesi.Columns["sifre"].HeaderText = "Şifre";
            kullanicilistesi.Columns["eposta"].HeaderText = "Eposta";
        }
        private void btnCevapVer_Click(object sender, EventArgs e)
        {
            if (txtCevapYazi.Text == "" || txtCevapYazi.TextLength < 10) MessageBox.Show("Girdiğiniz metin 10 harften daha kısa. Lütfen yanıtınızı uzun ve açıklayıcı bir şekilde yazınız.", "kitapçım.com", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    komut = new MySqlCommand("UPDATE talepler SET konu = @konu, talebi = @talebi WHERE talepid = @talepid", baglanti.baglan());
                    komut.Parameters.AddWithValue("@talepid", destekTalepleri.CurrentRow.Cells[0].Value.ToString());
                    komut.Parameters.AddWithValue("@konu", destekTalepleri.CurrentRow.Cells[2].Value.ToString() + " -CEVAPLANDI");
                    komut.Parameters.AddWithValue("@talebi", "Cevap Veren Yetkili: "+ GlobalClass.kullanici[1].ToString() + "     Cevap;"+ txtCevapYazi.Text.ToString());
                    komut.Connection = baglanti.baglan();
                    komut.ExecuteNonQuery();
                    komut.Connection.Close();
                    MessageBox.Show("Başarıyla seçilen talebi Cevapladınız!", "kitapçım.com.tr");
                    guncelle();
                }
                catch
                {
                    MessageBox.Show("Hata! Lütfen listeden cevaplayacağınız talebi seçiniz.", "kitapçım.com", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSifreDegistir_Click(object sender, EventArgs e)
        {
            try
            {
                komut = new MySqlCommand("UPDATE hesaplar SET Kadi = @kadi, sifre = @sifre WHERE Kadi = @kadi", baglanti.baglan());
                komut.Parameters.AddWithValue("@Kadi", kullanicilistesi.CurrentRow.Cells[0].Value.ToString());
                komut.Parameters.AddWithValue("@sifre", txtSifre.Text.ToString());
                komut.Connection = baglanti.baglan();
                komut.ExecuteNonQuery();
                komut.Connection.Close();
                MessageBox.Show("Başarıyla kullanıcı adını yazdığınız kişinin şifresi değiştirildi!", "kitapçım.com.tr", MessageBoxButtons.OK, MessageBoxIcon.Information);
                kullaniciliste();
            }
            catch
            {
                MessageBox.Show("Hata! Lütfen tekrar deneyiniz.", "kitapçım.com", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEpostadegistir_Click(object sender, EventArgs e)
        {
            Boolean sa = false;
            if (txtEposta.Text.Contains("@") && txtEposta.Text.Contains(".com"))
            {
                komut.CommandText = "SELECT * FROM hesaplar";
                komut.Connection = baglanti.baglan();
                MySqlDataReader ok = komut.ExecuteReader();
                while (ok.Read())
                {
                    if (ok["eposta"].ToString() == txtEposta.Text)
                    {
                        sa = true;
                    }
                }
                komut.Connection.Close();
                if (sa == true) MessageBox.Show("Bu eposta zaten kullanılıyor.", "kitapçım.com", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    komut = new MySqlCommand("UPDATE hesaplar SET eposta = @eposta WHERE Kadi = '" + kullanicilistesi.CurrentRow.Cells[0].Value.ToString() + "'", baglanti.baglan());
                    komut.Parameters.AddWithValue("@eposta", txtEposta.Text.ToString());
                    komut.Connection = baglanti.baglan();
                    komut.ExecuteNonQuery();
                    komut.Connection.Close();
                    MessageBox.Show("Başarıyla Epostanız Güncellendi!", "kitapçım.com", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    kullaniciliste();
                }
            }
            else { MessageBox.Show("Lütfen geçerli bir eposta adresi giriniz.", "kitapçım.com.tr"); }
        }

        private void txtKadi_TextChanged(object sender, EventArgs e)
        {
            DataTable sa = new DataTable();
            sa = tablo2.Copy();
            DataView goster = sa.DefaultView;
            goster.RowFilter = "Kadi LIKE '%" + txtKadi.Text.ToString() + "%'";
            kullanicilistesi.DataSource = goster;
        }

        private void btnYetkiAl_Click(object sender, EventArgs e)
        {
            try
            {
                komut.Connection = baglanti.baglan();
                komut.CommandText = "DELETE FROM sayfayonetimi WHERE Kadi = '" + kullanicilistesi.CurrentRow.Cells[0].Value.ToString() + "'";
                komut.ExecuteNonQuery();
                komut.Connection.Close();
                MessageBox.Show("Başarıyla Kullanıcının yetkisi alındı.");
            }
            catch 
            {
                MessageBox.Show("Hata! Seçtiğiniz kişinin zaten yetkisi yok veya bağlantı hatası.", "kitapçım.com", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnYasakla_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult areusure = MessageBox.Show("Seçilen kişiyi gerçekten yasaklayacak mısınız? /n UYARI: Bu işlem geri döndürülemez.", "kitapçım.com.tr", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(areusure == DialogResult.Yes)
                {
                SortedList sa = new SortedList();
                SortedList ass = new SortedList();
                int index = 0;
                int index2 = 0;
                komut.Connection = baglanti.baglan();
                komut.CommandText = "SELECT * FROM siparisler";
                MySqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    if (oku["kullaniciadi"].ToString() == kullanicilistesi.CurrentRow.Cells[0].Value.ToString())
                    {
                        sa.Add(index, oku["siparisid"].ToString());
                        index++;
                    }
                }
                komut.Connection.Close();

                komut.Connection = baglanti.baglan();
                komut.CommandText = "SELECT * FROM talepler";
                MySqlDataReader oku2 = komut.ExecuteReader();
                while (oku2.Read())
                {
                    if (oku2["Kadi"].ToString() == kullanicilistesi.CurrentRow.Cells[0].Value.ToString())
                    {
                        ass.Add(index2, oku2["talepid"].ToString());
                        index2++;
                    }
                }
                komut.Connection.Close();
                for (int i = 0; i < sa.Count; i++)
                {
                    komut.Connection = baglanti.baglan();
                    komut.CommandText = "DELETE FROM siparisler WHERE siparisid = '" + sa[i].ToString() + "'";
                    komut.ExecuteNonQuery();
                    komut.Connection.Close();

                    komut.Connection = baglanti.baglan();
                    komut.CommandText = "DELETE FROM talepler WHERE talepid = '" + ass[i].ToString() + "'";
                    komut.ExecuteNonQuery();
                    komut.Connection.Close();
                }

                komut.Connection = baglanti.baglan();
                    komut.CommandText = "DELETE FROM hesaplar WHERE Kadi = '" + kullanicilistesi.CurrentRow.Cells[0].Value.ToString() + "'";
                    komut.ExecuteNonQuery();
                    komut.Connection.Close();
                    MessageBox.Show("Kullanıcı yasaklandı! Artık hesabına hiçbir şekilde erişemeyecektir.", "kitapçım.com.tr",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
           catch
            {
               MessageBox.Show("Sistemsel bir hata! Lütfen tekrar deneyin.", "kitapçım.com", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnYetkiVer_Click(object sender, EventArgs e)
        {
            if (cmboxRutbe.SelectedIndex > 0)
            {

                try
                {
                    komut = new MySqlCommand("INSERT INTO sayfayonetimi(Kadi, rutbe) VALUES (@Kadi, @rutbe)", baglanti.baglan());
                    komut.Parameters.AddWithValue("@Kadi", kullanicilistesi.CurrentRow.Cells[0].Value.ToString());
                    komut.Parameters.AddWithValue("@rutbe", cmboxRutbe.SelectedItem.ToString());
                    komut.Connection = baglanti.baglan();
                    komut.ExecuteNonQuery();
                    komut.Connection.Close();
                    MessageBox.Show("Başarıyla yetki verildi!", "kitapçım.com", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Hata! Lütfen tekrar deneyiniz.", "kitapçım.com.tr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Lütfen vereceğiniz yetkiyi sağ taraftan seçiniz.", "kitapçım.com", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
