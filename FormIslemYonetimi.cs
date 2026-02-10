using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KasaDefteriApp.Models;
using KasaDefteriApp.Enums;
using KasaDefteriApp.Data; 

namespace KasaDefteriApp
{
    public partial class FormIslemYonetimi : Form
    {
        private Kasa acilanKasa = new Kasa();
        private KasaDbContext context = new KasaDbContext();

        private bool geriDonus = false; // seperate closing and returning back to the KasaYonetimi

        public FormIslemYonetimi(int kasaId, string kasaAdi)
        {
            InitializeComponent();

            acilanKasa.KasaID = kasaId;
            acilanKasa.KasaName = kasaAdi;

            this.Text = $"{acilanKasa.KasaName} Kasa İşlemleri";
            labelKasaAdi.Text = acilanKasa.KasaName;


        }

        private void FormIslemYonetimi_Load(object sender, EventArgs e)
        {
            // Form artık tamamen oluşturuldu. Veriyi yükle ve en alttaki satırı seç.
            LoadIslemler();
            cmbIslemTipi.SelectedIndex = 0;
        }

        private void LoadIslemler() // fetch data from database and put them into data grid view
        {
            // Temel Sorgu: Sadece aktif kasaya ait işlemleri çek.
            IQueryable<Islem> sorgu = context.Islemler.Where(islem => islem.KasaID == acilanKasa.KasaID);

            DateTime baslangicTarihi = dtpBaslangic.Value.Date;
            DateTime bitisTarihi = dtpBitis.Value.Date.AddDays(1).AddSeconds(-1);

            sorgu = sorgu.Where(islem => islem.IslemDate >= baslangicTarihi && islem.IslemDate <= bitisTarihi);
            // ilk sorguya ekleme yaptık


            // ARAMA ÇUBUĞU 

            string aramaMetni = textbBoxArama.Text.Trim();
            if (!string.IsNullOrEmpty(aramaMetni))
            {
                sorgu = sorgu.Where(islem => islem.IslemName.StartsWith(aramaMetni));
            }

            string seciliTip = cmbIslemTipi.SelectedItem?.ToString();
            if (seciliTip == "Giren")
            {
                sorgu = sorgu.Where(islem => islem.IslemType == IslemType.Giren);
            }
            else if (seciliTip == "Çıkan")
            {
                sorgu = sorgu.Where(islem => islem.IslemType == IslemType.Cikan);
            }

            ///////////////////////////////// sütunlara değer atama
            var islemListesi = sorgu
            .AsEnumerable()
            .OrderBy(islem => islem.IslemDate)
            .Select(islem => new
            {
                ID = islem.IslemID,
                Tarih = islem.IslemDate.ToString("dd.MM.yyyy HH:mm:ss"),
                Tür = islem.IslemType == IslemType.Giren ? "Giren" : "Çıkan",
                Açıklama = islem.IslemName,

                Giren = islem.IslemType == IslemType.Giren ? islem.IslemAmount : (decimal?)null,
                Çıkan = islem.IslemType == IslemType.Cikan ? -(islem.IslemAmount) : (decimal?)null

            })
                .ToList();


            dgvIslemler.DataSource = islemListesi;

            foreach (DataGridViewColumn col in dgvIslemler.Columns)
            {
                // Header tam ortalansın
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                // Sıralama oku için ayrılan gizli boşluğu tamamen kaldır
                col.SortMode = DataGridViewColumnSortMode.NotSortable;

                // Sağa-sola gizli padding kalmasın
                col.HeaderCell.Style.Padding = new Padding(0);
            }


            dgvIslemler.Columns["ID"].Visible = false;
            // FORMATTING  ( C => currency, 2 => show 2 digits after comma)
            dgvIslemler.Columns["Giren"].DefaultCellStyle.Format = "C2";
            dgvIslemler.Columns["Çıkan"].DefaultCellStyle.Format = "C2";

            dgvIslemler.Columns["Giren"].DefaultCellStyle.ForeColor = Color.Green;
            dgvIslemler.Columns["Çıkan"].DefaultCellStyle.ForeColor = Color.Red;

            // "Giren" "Çıkan" Sütununu Sağa Dayama
            dgvIslemler.Columns["Giren"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvIslemler.Columns["Çıkan"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvIslemler.Columns["Tür"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvIslemler.Columns["Tarih"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //dgvIslemler.Columns["Tür"].FillWeight = 40;
            //dgvIslemler.Columns["Açıklama"].FillWeight = 200;

            dgvIslemler.Columns["Tarih"].FillWeight = 18;
            dgvIslemler.Columns["Tür"].FillWeight = 8;
            dgvIslemler.Columns["Açıklama"].FillWeight = 38;
            dgvIslemler.Columns["Giren"].FillWeight = 18;
            dgvIslemler.Columns["Çıkan"].FillWeight = 18;


            //decimal totalBakiye = (decimal)islemListesi.Sum(i => i.Tür == "Giren" ? i.Giren : -i.Çıkan);

            //decimal totalBakiye = islemListesi.Sum(i => (i.Giren ?? 0) + (i.Çıkan ?? 0));

            decimal totalBakiye = context.Islemler
                .Where(i => i.KasaID == acilanKasa.KasaID)
                .AsEnumerable()
                .Sum(i => i.IslemType == IslemType.Giren ? i.IslemAmount : -i.IslemAmount);

            textBoxBakiye.ReadOnly = true;
            textBoxBakiye.BackColor = Color.White;

            textBoxBakiye.Text = totalBakiye.ToString("C2");

            if (totalBakiye < 0)
            {
                // Negatif bakiye: Kırmızı (Uyarı)
                textBoxBakiye.ForeColor = Color.Red;
            }
            else if (totalBakiye > 0)
            {
                // Pozitif bakiye: Yeşil (Başarılı)
                textBoxBakiye.ForeColor = Color.Green;
            }
            else // toplamBakiye == 0
            {
                textBoxBakiye.ForeColor = Color.Black;
            }

            if (dgvIslemler.Rows.Count > 0)
            {
                // Önceki seçimi temizle
                dgvIslemler.ClearSelection();

                // En alttaki satırın indeksini hesapla
                int sonSatirIndex = dgvIslemler.Rows.Count - 1;

                // Satırı seç
                dgvIslemler.Rows[sonSatirIndex].Selected = true;

                // Seçilen satıra kaydır (Görünür hale getir)
                dgvIslemler.FirstDisplayedScrollingRowIndex = sonSatirIndex;
            }

        }

        private void DeleteIslem(int _islemID)
        {
            using (var context = new KasaDbContext())
            {
                var silinecekIslem = context.Islemler.Find(_islemID);

                if (silinecekIslem == null)
                {
                    MessageBox.Show("Silinecek işlem veritabanında bulunamadı.", "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    context.Islemler.Remove(silinecekIslem);
                    context.SaveChanges();

                    LoadIslemler();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Silme işlemi sırasında bir hata oluştu: " + ex.Message, "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void labelKasaAdi_Click(object sender, EventArgs e)
        {

        }

        private void buttonGeri_Click(object sender, EventArgs e)
        {
            //FormKasaYonetimi formKasa = new FormKasaYonetimi();


            FormKasaYonetimi formKasa = Application.OpenForms.OfType<FormKasaYonetimi>().FirstOrDefault();
            if (formKasa != null)
            {
                // 2. Eğer form bulunduysa (ki bu form Gizli durumdadır):
                geriDonus = true;
                // Formu tekrar görünür yap
                formKasa.Show();

                // Eğer FormKasaYonetimi'nde veriyi yenileme metodu varsa, onu burada çağırın:
                formKasa.LoadKasalar(); // Eğer bu metot public ise

                // 3. Mevcut Formu (FormIslemYonetimi) Kapat
                this.Close();
            }
            else
            {
                // Nadiren olsa da form bulunamazsa (uygulama kapatılmışsa vb.)
                MessageBox.Show("Kasa Yönetimi formu bulunamadı. Uygulama başlatılıyor...", "Hata");
                // Yeni bir form açmak yerine, programın ana girişine dönmek daha güvenlidir.
                this.Close();
            }


        }



        private void buttonSil_Click(object sender, EventArgs e)
        {
            if (dgvIslemler.SelectedRows.Count == 0) // if no row is selected ...
            {
                MessageBox.Show("Lütfen silmek istediğiniz bir işlem seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int silinecekIslemID = (int)dgvIslemler.SelectedRows[0].Cells["ID"].Value;
            string silinecekIslemAdi = (string)dgvIslemler.SelectedRows[0].Cells["Açıklama"].Value;

            var onay = MessageBox.Show(
                $"'{silinecekIslemAdi}' işlemini silmek istediğinizden emin misiniz? Bu işlem geri alınamaz.",
                "Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (onay == DialogResult.Yes)
            {
                try
                {
                    DeleteIslem(silinecekIslemID);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Silme işlemi sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }



        private void buttonGiren_Click(object sender, EventArgs e) // add Giren type Islem
        {
            FormIslemEkle formIslem = new FormIslemEkle(acilanKasa.KasaID, IslemType.Giren);

            DialogResult result = formIslem.ShowDialog();

            if (result == DialogResult.OK)
            {
                LoadIslemler();
            }
        }

        private void buttonCikan_Click(object sender, EventArgs e) // add Çıkan type Islem
        {
            FormIslemEkle formIslem = new FormIslemEkle(acilanKasa.KasaID, IslemType.Cikan);

            DialogResult result = formIslem.ShowDialog();

            if (result == DialogResult.OK)
            {
                LoadIslemler();

            }
        }



        private void textbBoxArama_TextChanged(object sender, EventArgs e)
        {
            LoadIslemler();
        }

        private void dtpBaslangic_ValueChanged(object sender, EventArgs e)
        {
            LoadIslemler();
        }

        private void dtpBitis_ValueChanged(object sender, EventArgs e)
        {
            LoadIslemler();
        }

        private void FormIslemYonetimi_FormClosing(object sender, FormClosingEventArgs e)
        {

            // Formun kapatılması tetiklendiğinde tüm uygulamayı sonlandır.
            if (!geriDonus)
            {
                Application.Exit();
            }

        }

        private void cmbIslemTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadIslemler();
        }

        private void buttonRapor_Click(object sender, EventArgs e)
        {
            DateTime baslangic = dtpBaslangic.Value.Date;
            DateTime bitis = dtpBitis.Value.Date.AddDays(1).AddSeconds(-1);
            int kasaID = acilanKasa.KasaID;
            FormToplaYazdir formToplaYazdir = new FormToplaYazdir(baslangic, bitis, kasaID);
            formToplaYazdir.ShowDialog();
            
        }
    }
}
