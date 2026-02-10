using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KasaDefteriApp.Data;
using KasaDefteriApp.Models;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;


namespace KasaDefteriApp
{
    public partial class FormKasaEkle : Form
    {
        private KasaDbContext context = new KasaDbContext();
        public FormKasaEkle()
        {
            InitializeComponent();
            txtYeniKasaAdi.Focus();
        }

        private void FormKasaEkle_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string yeniKasaAdi = txtYeniKasaAdi.Text.Trim();

            if (string.IsNullOrEmpty(yeniKasaAdi))
            {
                MessageBox.Show("Lütfen geçerli bir kasa adı giriniz.", "Uyarı");
                return;
            }

            Kasa yeniKasa = new Kasa
            {
                KasaName=yeniKasaAdi,
                CreationTime=DateTime.Now
            };
           
           // yeniKasa.KasaName = yeniKasaAdi;
           // yeniKasa.CreationTime = DateTime.Now;

            context.Kasalar.Add(yeniKasa);
            context.SaveChanges();

            MessageBox.Show($"'{yeniKasaAdi}' kasası başarıyla kaydedildi.", "Başarılı");

            // Formu kapatırken burayı çağıran forma başarılı olduğunu belirtmek için DialogResult.OK kullanırız
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

