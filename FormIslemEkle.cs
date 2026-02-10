using System;
using System.Globalization;
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
using System.Xml;

namespace KasaDefteriApp
{
    public partial class FormIslemEkle : Form
    {
        private int _kasaID;
        private IslemType _islemType;
        private bool isFormatting = false;

        private readonly KasaDbContext _context = new KasaDbContext();
        public FormIslemEkle(int kasaID, IslemType islemType)
        {
            InitializeComponent();

            _kasaID = kasaID;
            _islemType = islemType;



            if (_islemType == IslemType.Giren)
            {
                this.Text = "Yeni GİREN Kaydı";
                textBoxMiktar.ForeColor = Color.Green;
            }
            else
            {
                this.Text = "Yeni ÇIKAN Kaydı";
                textBoxMiktar.ForeColor = Color.Red;
            }

        }

        private void buttonIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTamam_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxIslem.Text))
            {
                MessageBox.Show("Açıklama alanı boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxIslem.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxMiktar.Text))
            {
                MessageBox.Show("Lütfen geçerli bir miktar giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxMiktar.Focus();
                return;
            }

            string cleanAmount = textBoxMiktar.Text
                .Replace("₺", "")
                .Replace(".", "")
                .Replace(" ", "")
                .Trim();

            // Virgülü noktaya çevir
            cleanAmount = cleanAmount.Replace(",", ".");
            if (decimal.TryParse(cleanAmount, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal miktar))
            {
                if (miktar == 0)
                {
                    MessageBox.Show("Lütfen geçerli bir miktar giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxMiktar.Focus();
                    return;
                }
                //decimal.TryParse(textBoxMiktar.Text, out decimal miktar);

                Islem yeniIslem = new Islem
                {
                    KasaID = _kasaID,
                    IslemType = _islemType,
                    IslemName = textBoxIslem.Text.Trim(),
                    IslemAmount = miktar,
                    IslemDate = DateTime.Now

                };

                _context.Islemler.Add(yeniIslem);
                _context.SaveChanges();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void textBoxIslem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxMiktar.Focus(); // pass to the miktar textbox

                e.SuppressKeyPress = true; // to prevent the windows default action when enter is pressed
            }
        }

        private void textBoxMiktar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                buttonTamam.Focus();
            }
        }

        private void textBoxMiktar_Enter(object sender, EventArgs e)
        {
            /*if (!string.IsNullOrWhiteSpace(textBoxMiktar.Text))
            {
                string text = textBoxMiktar.Text.Replace("₺", "").Replace(" ", "").Trim();
                if (decimal.TryParse(text, NumberStyles.Any, new CultureInfo("tr-TR"), out decimal value))
                {
                    textBoxMiktar.Text = value.ToString("0.##");
                    textBoxMiktar.SelectAll();
                }
            }*/
            // TextBox'a girince formatı temizle
            string text = textBoxMiktar.Text.Replace("₺", "").Replace(" ", "").Trim();

            // Eğer 0,00 ise tamamen temizle, kullanıcı yeni değer girsin
            if (text == "0,00")
            {
                textBoxMiktar.Text = "";
                return;
            }

            if (decimal.TryParse(text, NumberStyles.Any, new CultureInfo("tr-TR"), out decimal value))
            {
                // Ondalıklı kısmı olmadan göster (kullanıcı yeni değer girecek)
                textBoxMiktar.Text = value.ToString("0");
                textBoxMiktar.SelectAll();
            }
        }

        private void textBoxMiktar_Leave(object sender, EventArgs e)
        {
            /* if (!string.IsNullOrWhiteSpace(textBoxMiktar.Text))
             {
                 string text = textBoxMiktar.Text.Replace("₺", "").Replace(" ", "").Trim();
                 if (decimal.TryParse(text, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal value))
                 {
                     textBoxMiktar.Text = value.ToString("N2", new CultureInfo("tr-TR")) + " ₺";
                 }
             }*/

            // TextBox'tan çıkınca formatla
            if (string.IsNullOrWhiteSpace(textBoxMiktar.Text))
            {
                // Boşsa 0,00 ₺ göster
                textBoxMiktar.Text = "0,00 ₺";
                return;
            }

            string text = textBoxMiktar.Text.Replace("₺", "").Replace(" ", "").Trim();

            if (decimal.TryParse(text, NumberStyles.Any, new CultureInfo("tr-TR"), out decimal value))
            {
                // Formatla ve ₺ işaretini ekle
                textBoxMiktar.Text = value.ToString("N2", new CultureInfo("tr-TR")) + " ₺";
            }
            else
            {
                // Geçersizse 0,00 ₺ göster
                textBoxMiktar.Text = "0,00 ₺";
            }
        }

        private void FormIslemEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
