using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KasaDefteriApp;
using KasaDefteriApp.Data;
using KasaDefteriApp.Models;

namespace KasaDefteriApp
{
    public partial class FormGiris : Form
    {

        public static string password = "2365"; // default password

        public FormGiris()
        {
            InitializeComponent();
            this.Text = "Kasa Defteri";
            //passwordBox.Focus(); // focus the cursor onto the password box

            try
            {
                using (var context = new KasaDbContext())
                {
                    //  KRİTİK ADIM: Eğer tablo yoksa (boş DB), şemayı oluşturur.
                    context.Database.EnsureCreated();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı başlangıcında hata oluştu: " + ex.Message, "Kritik Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonGiris_Click(object sender, EventArgs e)
        {
            if (passwordBox.Text == password)
            {
                // Başarılı giriş
                //MessageBox.Show("Doğru şifre.");
                FormKasaYonetimi kasaForm = new FormKasaYonetimi();
                kasaForm.Show();
                this.Hide(); //////////
               
            }
            else
            {
                MessageBox.Show("Yanlış şifre!", "Tekrar deneyin.");
                passwordBox.Clear();
                passwordBox.Focus();
            }

        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormGiris_Load(object sender, EventArgs e)
        {
        }

        private void FormGiris_Shown(object sender, EventArgs e)
        {
            passwordBox.Focus();
        }
    }
}
