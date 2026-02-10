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
using KasaDefteriApp.Data;
using KasaDefteriApp.Enums;
using System.Globalization;
using Microsoft.EntityFrameworkCore;

namespace KasaDefteriApp
{
    public partial class FormToplaYazdir : Form
    {
        private DateTime _baslangic;
        private DateTime _bitis;
        private int aktifKasaID;

        public FormToplaYazdir(DateTime baslangic, DateTime bitis, int kasaID)
        {
            InitializeComponent();
            this.Text = "Rapor";

            this._baslangic = baslangic;
            this._bitis = bitis;
            this.aktifKasaID = kasaID;

            string baslangicString = _baslangic.ToString("dd.MM.yyyy");
            string bitisString = _bitis.ToString("dd.MM.yyyy");

            labelTarih.Text = $"{baslangicString} - {bitisString} Tarihleri Arası Rapor";

            LoadRapor();
            printDocument1.BeginPrint += printDocument1_BeginPrint;
            //this.ActiveControl = labelNull;
        }

        // form açıldığında windows'un verdiği fokusu iptal et ve hiçbir yerde fokus alma
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            BeginInvoke(new Action(() =>
            {
                this.ActiveControl = null;
            }));
        } // 

        private void LoadRapor()
        {
            using (var context = new KasaDbContext())
            {
                try
                {
                    var islemSorgu = context.Islemler
                        .Where(islem => islem.KasaID == aktifKasaID)
                        .Where(islem => islem.IslemDate >= _baslangic && islem.IslemDate <= _bitis);

                    var toplamGiren = islemSorgu
                        .Where(islem => islem.IslemType == IslemType.Giren)
                        .AsEnumerable()
                        .Sum(islem => (decimal?)islem.IslemAmount) ?? 0; // if it is null, it is 0, otherwise islem.IslemAmount

                    var toplamCikan = islemSorgu
                        .Where(islem => islem.IslemType == IslemType.Cikan)
                        .AsEnumerable()
                        .Sum(islem => -(decimal?)islem.IslemAmount) ?? 0; // if it is null, it is 0, otherwise islem.IslemAmount

                    decimal toplamBakiye = toplamGiren + toplamCikan;

                    textBoxToplamGiren.Text = toplamGiren.ToString("C2");
                    textBoxToplamCikan.Text = toplamCikan.ToString("C2");

                    textBoxToplamBakiye.Text = toplamBakiye.ToString("C2");
                    if (toplamBakiye < 0)
                    {
                        textBoxToplamBakiye.ForeColor = Color.Red;
                    }
                    else if (toplamBakiye > 0)
                    {
                        textBoxToplamBakiye.ForeColor = Color.Green;
                    }
                    else
                        textBoxToplamBakiye.ForeColor = Color.Black;


                } // try

                catch (Exception ex)
                {
                    MessageBox.Show("Sorgulama yaparken veya toplam hesaplamada bir sorun oluştu: " + ex.Message, "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                } // catch
            }
        }

        private List<Islem> yazdirilacakIslemListesi;
        private void YazdirilacakVeriler()
        {
            using (var context = new KasaDbContext())
            {
                yazdirilacakIslemListesi = context.Islemler
                   .Include(i => i.Kasa)
                   .Where(i => i.KasaID == aktifKasaID)
                   .Where(i => i.IslemDate >= _baslangic && i.IslemDate < _bitis)
                   .OrderBy(i => i.IslemDate)
                   .ToList();
            }
        }

        private int satirIndex = 0;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font baslikFontu = new Font("Arial", 14, FontStyle.Bold);
            Font normalFont = new Font("Arial", 10, FontStyle.Regular);

            // RENK FIRÇALARI
            SolidBrush siyah = new SolidBrush(Color.Black);
            SolidBrush yesil = new SolidBrush(Color.DarkGreen);
            SolidBrush kirmizi = new SolidBrush(Color.DarkRed);

            // Sayfa kenar boşlukları
            int x = e.MarginBounds.Left;
            int y = e.MarginBounds.Top;
            int genislik = e.MarginBounds.Width;
            int satirYuksekligi = 25;
            int yBaslangic = y;

            float[] oranlar = { 0.15f, 0.10f, 0.40f, 0.15f, 0.15f };
            int toplamGenislik = e.MarginBounds.Width;
            int[] sutunGenislikleri = oranlar
                .Select(o => (int)(toplamGenislik * o))
                .ToArray();

            int mevcutX = x;

            if (yazdirilacakIslemListesi == null || yazdirilacakIslemListesi.Count == 0)
            {
                e.HasMorePages = false;
                return;
            }

            // BAŞLIK
            g.DrawString("KASA İŞLEMLERİ DETAY RAPORU", baslikFontu, siyah, x, yBaslangic);
            yBaslangic += 30;

            // Rapor Aralığı
            if (yazdirilacakIslemListesi != null && yazdirilacakIslemListesi.Count > 0 && yazdirilacakIslemListesi.First().Kasa != null)
            {
                string aralik = $"Kasa: {yazdirilacakIslemListesi.First().Kasa.KasaName} | Tarih Aralığı: {_baslangic:dd.MM.yyyy} - {_bitis:dd.MM.yyyy}";
                g.DrawString(aralik, normalFont, siyah, x, yBaslangic);
            }
            yBaslangic += 40;

            // Sütun Başlıkları
            string[] basliklar = { "TARİH", "TÜR", "AÇIKLAMA", "GİREN", "ÇIKAN" };
            mevcutX = x;

            for (int i = 0; i < basliklar.Length; i++)
            {
                g.DrawString(basliklar[i], baslikFontu, siyah, mevcutX, yBaslangic);
                mevcutX += sutunGenislikleri[i];
            }

            yBaslangic += satirYuksekligi;
            g.DrawLine(Pens.Black, x, yBaslangic - 5, x + genislik, yBaslangic - 5);

            // VERİ SATIRLARI
            while (satirIndex < yazdirilacakIslemListesi.Count)
            {
                Islem islem = yazdirilacakIslemListesi[satirIndex];
                mevcutX = x;

                if (yBaslangic + satirYuksekligi > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }

                // SATIR RENGİ SEÇİMİ
                SolidBrush satirRenk = (islem.IslemType == IslemType.Giren) ? yesil : kirmizi;

                // 1. Tarih
                g.DrawString(islem.IslemDate.ToString("dd.MM.yyyy"), normalFont, satirRenk, mevcutX, yBaslangic);
                mevcutX += sutunGenislikleri[0];

                // 2. Tür
                string tur = (islem.IslemType == IslemType.Giren) ? "GİREN" : "ÇIKAN";
                g.DrawString(tur, normalFont, satirRenk, mevcutX, yBaslangic);
                mevcutX += sutunGenislikleri[1];

                // 3. Açıklama
                g.DrawString(islem.IslemName, normalFont, satirRenk, mevcutX, yBaslangic);
                mevcutX += sutunGenislikleri[2];

                // 4. Giren
                int offsetValue = 8;
                string girenMiktar = (islem.IslemType == IslemType.Giren) ? islem.IslemAmount.ToString("N2") : "";
                int girenWidth = TextRenderer.MeasureText(girenMiktar, normalFont).Width;

                g.DrawString(girenMiktar, normalFont, satirRenk,
                    mevcutX + sutunGenislikleri[3] - girenWidth - offsetValue, yBaslangic);
                mevcutX += sutunGenislikleri[3];

                // 5. Çıkan
                string cikanMiktar = (islem.IslemType == IslemType.Cikan) ? (-islem.IslemAmount).ToString("N2") : "";
                int cikanWidth = TextRenderer.MeasureText(cikanMiktar, normalFont).Width;

                g.DrawString(cikanMiktar, normalFont, satirRenk,
                    mevcutX + sutunGenislikleri[4] - cikanWidth - offsetValue, yBaslangic);
                mevcutX += sutunGenislikleri[4];

                yBaslangic += satirYuksekligi;
                satirIndex++;
            }

            // ALT TOPLAM ALANI
            yBaslangic += 70;

            decimal toplamGiren = yazdirilacakIslemListesi.Where(i => i.IslemType == IslemType.Giren).Sum(i => i.IslemAmount);
            decimal toplamCikan = yazdirilacakIslemListesi.Where(i => i.IslemType == IslemType.Cikan).Sum(i => -(i.IslemAmount));
            decimal bakiye = toplamGiren + toplamCikan;

            if (satirIndex >= yazdirilacakIslemListesi.Count)
            {
                string toplamGirenStr = toplamGiren.ToString("C2", CultureInfo.GetCultureInfo("tr-TR"));
                string toplamCikanStr = toplamCikan.ToString("C2", CultureInfo.GetCultureInfo("tr-TR"));
                string bakiyeStr = bakiye.ToString("C2", CultureInfo.GetCultureInfo("tr-TR"));

                int girenWidth = (int)g.MeasureString(toplamGirenStr, baslikFontu).Width;
                int cikanWidth = (int)g.MeasureString(toplamCikanStr, baslikFontu).Width;
                int bakiyeWidth = (int)g.MeasureString(bakiyeStr, baslikFontu).Width;

                int rightPad = 5;
                int sayfaSag = e.MarginBounds.Right;

                int xGiren = sayfaSag - girenWidth - rightPad;
                int xCikan = sayfaSag - cikanWidth - rightPad;
                int xBakiye = sayfaSag - bakiyeWidth - rightPad;

                // LABEL OFFSET → 160 px sola
                int labelOffset = 200;

                // --- TOPLAM GİREN ---
                g.DrawString("TOPLAM GİREN:", baslikFontu, siyah, xGiren - labelOffset, yBaslangic);
                g.DrawString(toplamGirenStr, baslikFontu, yesil, xGiren, yBaslangic);

                yBaslangic += satirYuksekligi;

                // --- TOPLAM ÇIKAN ---
                g.DrawString("TOPLAM ÇIKAN:", baslikFontu, siyah, xCikan - labelOffset+8, yBaslangic);
                g.DrawString(toplamCikanStr, baslikFontu, kirmizi, xCikan, yBaslangic);

                yBaslangic += satirYuksekligi;

                g.DrawLine(Pens.Black, x, yBaslangic - 5, x + genislik, yBaslangic - 5);

                // --- BAKİYE RENGİ ---
                SolidBrush bakiyeRenk =
                    (bakiye > 0) ? yesil :
                    (bakiye < 0) ? kirmizi :
                    siyah;

                // --- GENEL BAKİYE ---
                g.DrawString("GENEL BAKİYE:", baslikFontu, siyah, xBakiye - labelOffset, yBaslangic);
                g.DrawString(bakiyeStr, baslikFontu, bakiyeRenk, xBakiye, yBaslangic);

                e.HasMorePages = false;
            }




        } 


        private void buttonYazdir_Click(object sender, EventArgs e)
        {
            //satirIndex = 0;
            try
            {
                YazdirilacakVeriler();

                if (yazdirilacakIslemListesi == null || yazdirilacakIslemListesi.Count == 0)
                {
                    MessageBox.Show("Yazdırılacak işlem bulunamadı.", "Yazdırma hatası", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.Text = $"{_baslangic.ToString("dd.MM.yyyy")} - {_bitis.ToString("dd.MM.yyyy")} Rapor Önizleme";
                //printPreviewDialog1.ShowDialog();
                

                // preview'de yazdır butonuna basılırsa
                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDialog1.Document = printDocument1;

                    if (printDialog1.ShowDialog() == DialogResult.OK)
                    {
                        printDocument1.Print();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Yazdırma sırasında bir hata oluştu. " + ex.Message, " Hata ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            satirIndex = 0;
        }
        private void buttonGeri1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormToplaYazdir_Load(object sender, EventArgs e)
        {

        }

        
    }

}
