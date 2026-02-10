namespace KasaDefteriApp
{

    partial class FormIslemYonetimi { 
    // <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        /// 

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIslemYonetimi));
            labelKasaAdi = new Label();
            dgvIslemler = new DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            cmbIslemTipi = new ComboBox();
            textbBoxArama = new TextBox();
            dtpBaslangic = new DateTimePicker();
            dtpBitis = new DateTimePicker();
            labelIslemAdi = new Label();
            labelIlkTarih = new Label();
            labelSonTarih = new Label();
            textBoxBakiye = new TextBox();
            labelBakiye = new Label();
            panel2 = new Panel();
            buttonSil = new Button();
            buttonCikan = new Button();
            buttonGiren = new Button();
            buttonGeri = new Button();
            buttonRapor = new Button();
            imageListButtons = new ImageList(components);
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvIslemler).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // labelKasaAdi
            // 
            labelKasaAdi.AutoSize = true;
            labelKasaAdi.BackColor = Color.Honeydew;
            labelKasaAdi.Font = new Font("Segoe UI", 12.8F, FontStyle.Bold);
            labelKasaAdi.ForeColor = Color.FromArgb(0, 64, 64);
            labelKasaAdi.Location = new Point(21, 9);
            labelKasaAdi.Name = "labelKasaAdi";
            labelKasaAdi.Size = new Size(102, 30);
            labelKasaAdi.TabIndex = 0;
            labelKasaAdi.Text = "Kasa Adý";
            labelKasaAdi.Click += labelKasaAdi_Click;
            // 
            // dgvIslemler
            // 
            dgvIslemler.AllowUserToAddRows = false;
            dgvIslemler.AllowUserToDeleteRows = false;
            dgvIslemler.AllowUserToResizeColumns = false;
            dgvIslemler.AllowUserToResizeRows = false;
            dgvIslemler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvIslemler.BackgroundColor = Color.Honeydew;
            dgvIslemler.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvIslemler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvIslemler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvIslemler.DefaultCellStyle = dataGridViewCellStyle2;
            dgvIslemler.GridColor = SystemColors.InfoText;
            dgvIslemler.Location = new Point(150, 152);
            dgvIslemler.Name = "dgvIslemler";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvIslemler.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvIslemler.RowHeadersVisible = false;
            dgvIslemler.RowHeadersWidth = 45;
            dgvIslemler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvIslemler.Size = new Size(866, 433);
            dgvIslemler.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cmbIslemTipi);
            panel1.Controls.Add(textbBoxArama);
            panel1.Controls.Add(dtpBaslangic);
            panel1.Controls.Add(dtpBitis);
            panel1.Controls.Add(labelIslemAdi);
            panel1.Controls.Add(labelIlkTarih);
            panel1.Controls.Add(labelSonTarih);
            panel1.Controls.Add(textBoxBakiye);
            panel1.Controls.Add(labelBakiye);
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(21, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(995, 79);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.8F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(687, 7);
            label1.Name = "label1";
            label1.Size = new Size(43, 23);
            label1.TabIndex = 9;
            label1.Text = "Tür :";
            // 
            // cmbIslemTipi
            // 
            cmbIslemTipi.BackColor = Color.Honeydew;
            cmbIslemTipi.Font = new Font("Segoe UI Semibold", 9.2F, FontStyle.Bold);
            cmbIslemTipi.FormattingEnabled = true;
            cmbIslemTipi.Items.AddRange(new object[] { "Tümü", "Giren", "Çýkan" });
            cmbIslemTipi.Location = new Point(687, 37);
            cmbIslemTipi.Name = "cmbIslemTipi";
            cmbIslemTipi.Size = new Size(132, 28);
            cmbIslemTipi.TabIndex = 4;
            cmbIslemTipi.Tag = "2";
            cmbIslemTipi.SelectedIndexChanged += cmbIslemTipi_SelectedIndexChanged;
            // 
            // textbBoxArama
            // 
            textbBoxArama.BackColor = Color.Honeydew;
            textbBoxArama.Font = new Font("Segoe UI Semibold", 9.2F, FontStyle.Bold);
            textbBoxArama.Location = new Point(5, 38);
            textbBoxArama.Name = "textbBoxArama";
            textbBoxArama.Size = new Size(145, 28);
            textbBoxArama.TabIndex = 1;
            textbBoxArama.TextChanged += textbBoxArama_TextChanged;
            // 
            // dtpBaslangic
            // 
            dtpBaslangic.AccessibleRole = AccessibleRole.None;
            dtpBaslangic.CalendarFont = new Font("Segoe UI", 9F);
            dtpBaslangic.CalendarMonthBackground = Color.Honeydew;
            dtpBaslangic.Font = new Font("Segoe UI Semibold", 8.200001F, FontStyle.Bold);
            dtpBaslangic.Location = new Point(181, 40);
            dtpBaslangic.Name = "dtpBaslangic";
            dtpBaslangic.Size = new Size(220, 26);
            dtpBaslangic.TabIndex = 2;
            dtpBaslangic.ValueChanged += dtpBaslangic_ValueChanged;
            // 
            // dtpBitis
            // 
            dtpBitis.AccessibleRole = AccessibleRole.None;
            dtpBitis.CalendarFont = new Font("Segoe UI", 9F);
            dtpBitis.CalendarMonthBackground = Color.Honeydew;
            dtpBitis.Font = new Font("Segoe UI Semibold", 8.200001F, FontStyle.Bold);
            dtpBitis.Location = new Point(439, 39);
            dtpBitis.Name = "dtpBitis";
            dtpBitis.Size = new Size(220, 26);
            dtpBitis.TabIndex = 3;
            dtpBitis.ValueChanged += dtpBitis_ValueChanged;
            // 
            // labelIslemAdi
            // 
            labelIslemAdi.AutoSize = true;
            labelIslemAdi.Font = new Font("Segoe UI Semibold", 9.8F, FontStyle.Bold);
            labelIslemAdi.ForeColor = SystemColors.Info;
            labelIslemAdi.Location = new Point(4, 7);
            labelIslemAdi.Name = "labelIslemAdi";
            labelIslemAdi.Size = new Size(89, 23);
            labelIslemAdi.TabIndex = 4;
            labelIslemAdi.Text = "Ýþlem Adý :";
            // 
            // labelIlkTarih
            // 
            labelIlkTarih.AutoSize = true;
            labelIlkTarih.Font = new Font("Segoe UI Semibold", 9.8F, FontStyle.Bold);
            labelIlkTarih.ForeColor = SystemColors.Info;
            labelIlkTarih.Location = new Point(181, 7);
            labelIlkTarih.Name = "labelIlkTarih";
            labelIlkTarih.Size = new Size(135, 23);
            labelIlkTarih.TabIndex = 3;
            labelIlkTarih.Text = "Baþlangýç Tarihi :";
            // 
            // labelSonTarih
            // 
            labelSonTarih.AutoSize = true;
            labelSonTarih.Font = new Font("Segoe UI Semibold", 9.8F, FontStyle.Bold);
            labelSonTarih.ForeColor = SystemColors.Info;
            labelSonTarih.Location = new Point(439, 7);
            labelSonTarih.Name = "labelSonTarih";
            labelSonTarih.Size = new Size(95, 23);
            labelSonTarih.TabIndex = 2;
            labelSonTarih.Text = "Bitiþ Tarihi :";
            // 
            // textBoxBakiye
            // 
            textBoxBakiye.BackColor = Color.Honeydew;
            textBoxBakiye.Font = new Font("Segoe UI Semibold", 9.2F, FontStyle.Bold);
            textBoxBakiye.ImeMode = ImeMode.Off;
            textBoxBakiye.Location = new Point(851, 38);
            textBoxBakiye.Name = "textBoxBakiye";
            textBoxBakiye.Size = new Size(125, 28);
            textBoxBakiye.TabIndex = 5;
            textBoxBakiye.TextAlign = HorizontalAlignment.Right;
            // 
            // labelBakiye
            // 
            labelBakiye.AutoSize = true;
            labelBakiye.Font = new Font("Segoe UI Semibold", 9.8F, FontStyle.Bold);
            labelBakiye.ForeColor = SystemColors.Info;
            labelBakiye.Location = new Point(851, 7);
            labelBakiye.Name = "labelBakiye";
            labelBakiye.Size = new Size(69, 23);
            labelBakiye.TabIndex = 0;
            labelBakiye.Text = "Bakiye :";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(buttonSil);
            panel2.Controls.Add(buttonCikan);
            panel2.Controls.Add(buttonGiren);
            panel2.Location = new Point(21, 152);
            panel2.Name = "panel2";
            panel2.Size = new Size(118, 250);
            panel2.TabIndex = 3;
            // 
            // buttonSil
            // 
            buttonSil.BackColor = Color.Honeydew;
            buttonSil.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonSil.ForeColor = SystemColors.ActiveCaptionText;
            buttonSil.Image = (Image)resources.GetObject("buttonSil.Image");
            buttonSil.Location = new Point(5, 184);
            buttonSil.Name = "buttonSil";
            buttonSil.Size = new Size(105, 58);
            buttonSil.TabIndex = 2;
            buttonSil.Text = "Sil";
            buttonSil.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonSil.UseVisualStyleBackColor = false;
            buttonSil.Click += buttonSil_Click;
            // 
            // buttonCikan
            // 
            buttonCikan.BackColor = Color.Honeydew;
            buttonCikan.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonCikan.ForeColor = SystemColors.ActiveCaptionText;
            buttonCikan.Image = (Image)resources.GetObject("buttonCikan.Image");
            buttonCikan.Location = new Point(5, 95);
            buttonCikan.Name = "buttonCikan";
            buttonCikan.Size = new Size(105, 58);
            buttonCikan.TabIndex = 1;
            buttonCikan.Text = "Çýkan";
            buttonCikan.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonCikan.UseVisualStyleBackColor = false;
            buttonCikan.Click += buttonCikan_Click;
            // 
            // buttonGiren
            // 
            buttonGiren.BackColor = Color.Honeydew;
            buttonGiren.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            buttonGiren.ForeColor = SystemColors.ActiveCaptionText;
            buttonGiren.Image = (Image)resources.GetObject("buttonGiren.Image");
            buttonGiren.Location = new Point(5, 6);
            buttonGiren.Name = "buttonGiren";
            buttonGiren.Size = new Size(105, 58);
            buttonGiren.TabIndex = 0;
            buttonGiren.Text = "Giren";
            buttonGiren.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonGiren.UseVisualStyleBackColor = false;
            buttonGiren.Click += buttonGiren_Click;
            // 
            // buttonGeri
            // 
            buttonGeri.BackColor = Color.Honeydew;
            buttonGeri.Font = new Font("Segoe UI Semibold", 9.2F, FontStyle.Bold);
            buttonGeri.ForeColor = SystemColors.ActiveCaptionText;
            buttonGeri.Image = (Image)resources.GetObject("buttonGeri.Image");
            buttonGeri.Location = new Point(5, 97);
            buttonGeri.Name = "buttonGeri";
            buttonGeri.Size = new Size(105, 58);
            buttonGeri.TabIndex = 3;
            buttonGeri.Text = "Kasalar";
            buttonGeri.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonGeri.UseVisualStyleBackColor = false;
            buttonGeri.Click += buttonGeri_Click;
            // 
            // buttonRapor
            // 
            buttonRapor.BackColor = Color.Honeydew;
            buttonRapor.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonRapor.ForeColor = SystemColors.ActiveCaptionText;
            buttonRapor.Image = (Image)resources.GetObject("buttonRapor.Image");
            buttonRapor.Location = new Point(5, 5);
            buttonRapor.Name = "buttonRapor";
            buttonRapor.Size = new Size(105, 58);
            buttonRapor.TabIndex = 4;
            buttonRapor.Text = "Rapor";
            buttonRapor.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonRapor.UseVisualStyleBackColor = false;
            buttonRapor.Click += buttonRapor_Click;
            // 
            // imageListButtons
            // 
            imageListButtons.ColorDepth = ColorDepth.Depth32Bit;
            imageListButtons.ImageStream = (ImageListStreamer)resources.GetObject("imageListButtons.ImageStream");
            imageListButtons.TransparentColor = Color.Transparent;
            imageListButtons.Images.SetKeyName(0, "giren.png");
            imageListButtons.Images.SetKeyName(1, "çýkan.png");
            imageListButtons.Images.SetKeyName(2, "giren2.png");
            imageListButtons.Images.SetKeyName(3, "giren3.png");
            imageListButtons.Images.SetKeyName(4, "giren4.png");
            imageListButtons.Images.SetKeyName(5, "giren5.jpg");
            imageListButtons.Images.SetKeyName(6, "geri.png");
            imageListButtons.Images.SetKeyName(7, "geri2.png");
            imageListButtons.Images.SetKeyName(8, "geri3.png");
            imageListButtons.Images.SetKeyName(9, "geri4.png");
            imageListButtons.Images.SetKeyName(10, "geri5.png");
            imageListButtons.Images.SetKeyName(11, "cikan.png");
            imageListButtons.Images.SetKeyName(12, "cikan2.png");
            imageListButtons.Images.SetKeyName(13, "cikan3.png");
            imageListButtons.Images.SetKeyName(14, "cikan5.png");
            imageListButtons.Images.SetKeyName(15, "cikan4.png");
            imageListButtons.Images.SetKeyName(16, "sil.jpg");
            imageListButtons.Images.SetKeyName(17, "sil2.png");
            imageListButtons.Images.SetKeyName(18, "sil3.png");
            imageListButtons.Images.SetKeyName(19, "sil4.png");
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(buttonRapor);
            panel3.Controls.Add(buttonGeri);
            panel3.Location = new Point(21, 421);
            panel3.Name = "panel3";
            panel3.Size = new Size(118, 164);
            panel3.TabIndex = 5;
            // 
            // FormIslemYonetimi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(1039, 597);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dgvIslemler);
            Controls.Add(labelKasaAdi);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormIslemYonetimi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "   ";
            FormClosing += FormIslemYonetimi_FormClosing;
            Load += FormIslemYonetimi_Load;
            ((System.ComponentModel.ISupportInitialize)dgvIslemler).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Label labelKasaAdi;
        private DataGridView dgvIslemler;
        private Panel panel1;
        private Label labelBakiye;
        private Panel panel2;
        private TextBox textBoxBakiye;
        private Button buttonGeri;
        private Button buttonSil;
        private Button buttonCikan;
        private Button buttonGiren;
        private ImageList imageListButtons;
        private Label labelIslemAdi;
        private Label labelIlkTarih;
        private Label labelSonTarih;
        //private DateTimePicker dtpBaslangic;
        private DateTimePicker dtpBitis;
        private DateTimePicker dtpBaslangic;
        private TextBox textbBoxArama;
        private ComboBox cmbIslemTipi;
        private Label label1;
        private Button buttonRapor;
        private Panel panel3;
    }
}
