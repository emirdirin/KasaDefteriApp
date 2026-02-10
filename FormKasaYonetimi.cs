using KasaDefteriApp.Data;
using KasaDefteriApp.Enums;
using KasaDefteriApp.Models;
using Microsoft.EntityFrameworkCore; // for include method
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace KasaDefteriApp
{
    public partial class FormKasaYonetimi : Form
    {
        //private KasaDbContext context = new KasaDbContext();

        public void LoadKasalar()
        {
            try
            {
                using (var context = new KasaDbContext())
                {
                    var kasaListesi = context.Kasalar // get the list of Kasalar in database
                        .Include(k => k.Islems)
                        .AsEnumerable()
                        .Select(kasa => new     // new instance of kasa to be displayed on dgv
                        {
                            ID = kasa.KasaID,
                            KasaAdý = kasa.KasaName,
                            OluþturmaTarihi = kasa.CreationTime.ToString("dd.MM.yyyy HH:mm:ss"),

                            Bakiye = kasa.Islems.Sum(i => i.IslemType == IslemType.Giren ? i.IslemAmount : -i.IslemAmount)
                        }).ToList();

                    dgvKasalar.DataSource = kasaListesi; // the data source of the dgv is the list we have fetched above
                                                         //columns are automatically added

                    foreach (DataGridViewColumn col in dgvKasalar.Columns)
                    {
                        // Header tam ortalansýn
                        col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                        // Sýralama oku için ayrýlan gizli boþluðu tamamen kaldýr
                        col.SortMode = DataGridViewColumnSortMode.NotSortable;

                        // Saða-sola gizli padding kalmasýn
                        col.HeaderCell.Style.Padding = new Padding(0);
                    }

                    if (dgvKasalar.Columns.Contains("ID"))
                    {
                        dgvKasalar.Columns["ID"].Visible = false;
                    }

                    if (dgvKasalar.Columns.Contains("Bakiye"))
                    {
                        dgvKasalar.Columns["Bakiye"].DefaultCellStyle.Format = "C2"; // C2: Para birimi formatý (TL olarak görünür)
                        dgvKasalar.Columns["Bakiye"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    }
                    dgvKasalar.Columns["KasaAdý"].HeaderText = " Kasa Adý";
                    dgvKasalar.Columns["OluþturmaTarihi"].HeaderText = "Oluþturma Tarihi";

                    dgvKasalar.Columns["OluþturmaTarihi"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    dgvKasalar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dgvKasalar.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kasalar yüklenirken bir hata oluþtu: " + ex.Message, "Veri Hatasý", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void RenkleriUygula()
        {
            if (dgvKasalar.Columns.Contains("Bakiye"))
            {
                foreach (DataGridViewRow row in dgvKasalar.Rows)
                {
                    var bakiyeValue = row.Cells["Bakiye"].Value;

                    if (bakiyeValue != null && decimal.TryParse(bakiyeValue.ToString(), out decimal bakiye))
                    {
                        Color renk;
                        if (bakiye < 0) { renk = Color.Red; }
                        else if (bakiye > 0) { renk = Color.Green; }
                        else { renk = Color.Black; }

                        row.Cells["Bakiye"].Style.ForeColor = renk;
                    }

                } // foreach


            } // if 
        }

        private void DeleteKasa(int _kasaID)
        {
            using (var context = new KasaDbContext())  // ?
            {
                var silinecekKasa = context.Kasalar.Find(_kasaID);

                if (silinecekKasa == null)
                {
                    MessageBox.Show("Silinecek kasa veritabanýnda bulunamadý.", "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    context.Kasalar.Remove(silinecekKasa);
                    context.SaveChanges();
                    LoadKasalar();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Silme iþlemi sýrasýnda bir hata oluþtu: " + ex.Message, "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /*public static string HashSifre(string sifre)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(sifre));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public static bool SifreDogrula(string girilenSifre, string dogruHash)
        {
            string girilenSifreHash = HashSifre(girilenSifre);
            return girilenSifreHash == dogruHash;
        } */
        public FormKasaYonetimi()
        {
            InitializeComponent();

            dgvKasalar.DataBindingComplete += dgvKasalar_DataBindingComplete;

            LoadKasalar(); // load kasalar list from database

            this.Text = "Kasa Ýþlemleri";
        }

        private void dgvKasalar_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // Veri baðlama tamamlandýðýnda renklendirmeyi yap
            RenkleriUygula();
        }

        private void FormKasaYonetimi_Load(object sender, EventArgs e)
        {

        }

        private void buttonEkle_Click(object sender, EventArgs e)  // kasa -> add
        {
            FormKasaEkle ekleForm = new FormKasaEkle();

            DialogResult result = ekleForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                LoadKasalar();
            }
        }

        private void buttonSil_Click(object sender, EventArgs e) // kasa -> delete
        {
            if (dgvKasalar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediðiniz bir kasa seçin.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int secilenKasaID = (int)dgvKasalar.SelectedRows[0].Cells["ID"].Value;
            string secilenKasaAdi = (string)dgvKasalar.SelectedRows[0].Cells["KasaAdý"].Value;
            ////////////////
            var onay = MessageBox.Show(
                $"'{secilenKasaAdi}' kasasýný ve buna ait TÜM ÝÞLEMLERÝ silmek istediðinizden emin misiniz? Bu iþlem geri alýnamaz.",
                "Silme Onayý",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (onay == DialogResult.Yes)
            {
                try
                {
                    DeleteKasa(secilenKasaID);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Silme iþlemi sýrasýnda bir hata oluþtu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        } // 

        private void KasaSecimiYap()
        {
            if (dgvKasalar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen iþlemlerini görmek istediðiniz bir kasa seçin.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int secilenKasaID = (int)dgvKasalar.SelectedRows[0].Cells["ID"].Value;
            string secilenKasaAdi = (string)dgvKasalar.SelectedRows[0].Cells["KasaAdý"].Value;

            FormIslemYonetimi islemForm = new FormIslemYonetimi(secilenKasaID, secilenKasaAdi); // (secilenKasaID, secilenKasaAdi)
            islemForm.Show();
            this.Hide();

        }

        private void buttonSec_Click(object sender, EventArgs e) // kasa -> select  
        {
            KasaSecimiYap();
        }


        private void dgvKasalar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // // Baþlýk satýrýna çift týklanmasýný engelle
            {
                KasaSecimiYap();
            }
        }

        private void dgvKasalar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Enter tuþunun DataGridView'da yeni satýra geçmek gibi varsayýlan hareketini engelle
                e.Handled = true;
                KasaSecimiYap();
            }
        }

        private void dgvKasalar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormKasaYonetimi_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Formun kapatýlmasý tetiklendiðinde tüm uygulamayý sonlandýr.
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }


}
