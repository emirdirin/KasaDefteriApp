namespace KasaDefteriApp
{
    partial class FormKasaYonetimi
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKasaYonetimi));
            label1 = new Label();
            dgvKasalar = new DataGridView();
            panel1 = new Panel();
            buttonSec = new Button();
            buttonSil = new Button();
            buttonEkle = new Button();
            ımgKasaButonlari = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)dgvKasalar).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Honeydew;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.FromArgb(0, 64, 64);
            label1.Location = new Point(12, 34);
            label1.Name = "label1";
            label1.Size = new Size(131, 35);
            label1.TabIndex = 0;
            label1.Text = "KASALAR";
            label1.Click += label1_Click;
            // 
            // dgvKasalar
            // 
            dgvKasalar.AllowUserToAddRows = false;
            dgvKasalar.AllowUserToDeleteRows = false;
            dgvKasalar.AllowUserToResizeColumns = false;
            dgvKasalar.AllowUserToResizeRows = false;
            dgvKasalar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKasalar.BackgroundColor = Color.Honeydew;
            dgvKasalar.BorderStyle = BorderStyle.Fixed3D;
            dgvKasalar.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dgvKasalar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKasalar.GridColor = SystemColors.InfoText;
            dgvKasalar.Location = new Point(12, 97);
            dgvKasalar.Name = "dgvKasalar";
            dgvKasalar.RowHeadersVisible = false;
            dgvKasalar.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvKasalar.Size = new Size(425, 258);
            dgvKasalar.TabIndex = 1;
            dgvKasalar.CellContentClick += dgvKasalar_CellContentClick;
            dgvKasalar.CellDoubleClick += dgvKasalar_CellDoubleClick;
            dgvKasalar.KeyDown += dgvKasalar_KeyDown;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonSec);
            panel1.Controls.Add(buttonSil);
            panel1.Controls.Add(buttonEkle);
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(12, 372);
            panel1.Name = "panel1";
            panel1.Size = new Size(425, 54);
            panel1.TabIndex = 2;
            // 
            // buttonSec
            // 
            buttonSec.BackColor = Color.Honeydew;
            buttonSec.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            buttonSec.ForeColor = SystemColors.ActiveCaptionText;
            buttonSec.Image = (Image)resources.GetObject("buttonSec.Image");
            buttonSec.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSec.Location = new Point(335, 0);
            buttonSec.Name = "buttonSec";
            buttonSec.Size = new Size(90, 54);
            buttonSec.TabIndex = 2;
            buttonSec.Text = "Seç";
            buttonSec.TextAlign = ContentAlignment.MiddleRight;
            buttonSec.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonSec.UseVisualStyleBackColor = false;
            buttonSec.Click += buttonSec_Click;
            // 
            // buttonSil
            // 
            buttonSil.BackColor = Color.Honeydew;
            buttonSil.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            buttonSil.Image = (Image)resources.GetObject("buttonSil.Image");
            buttonSil.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSil.Location = new Point(127, -1);
            buttonSil.Name = "buttonSil";
            buttonSil.Size = new Size(80, 54);
            buttonSil.TabIndex = 1;
            buttonSil.Text = "Sil";
            buttonSil.TextAlign = ContentAlignment.MiddleRight;
            buttonSil.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonSil.UseVisualStyleBackColor = false;
            buttonSil.Click += buttonSil_Click;
            // 
            // buttonEkle
            // 
            buttonEkle.BackColor = Color.Honeydew;
            buttonEkle.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            buttonEkle.Image = (Image)resources.GetObject("buttonEkle.Image");
            buttonEkle.ImageAlign = ContentAlignment.MiddleLeft;
            buttonEkle.Location = new Point(0, 0);
            buttonEkle.Name = "buttonEkle";
            buttonEkle.Size = new Size(85, 54);
            buttonEkle.TabIndex = 0;
            buttonEkle.Text = "Ekle";
            buttonEkle.TextAlign = ContentAlignment.MiddleRight;
            buttonEkle.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonEkle.UseVisualStyleBackColor = false;
            buttonEkle.Click += buttonEkle_Click;
            // 
            // ımgKasaButonlari
            // 
            ımgKasaButonlari.ColorDepth = ColorDepth.Depth32Bit;
            ımgKasaButonlari.ImageStream = (ImageListStreamer)resources.GetObject("ımgKasaButonlari.ImageStream");
            ımgKasaButonlari.TransparentColor = Color.Transparent;
            ımgKasaButonlari.Images.SetKeyName(0, "plusIcon");
            ımgKasaButonlari.Images.SetKeyName(1, "xIcon");
            ımgKasaButonlari.Images.SetKeyName(2, "checkIcon");
            // 
            // FormKasaYonetimi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(452, 441);
            Controls.Add(panel1);
            Controls.Add(dgvKasalar);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormKasaYonetimi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosing += FormKasaYonetimi_FormClosing;
            Load += FormKasaYonetimi_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKasalar).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView dgvKasalar;
        private Panel panel1;
        private Button buttonEkle;
        private ImageList ımgKasaButonlari;
        private Button buttonSec;
        private Button buttonSil;
    }
}
