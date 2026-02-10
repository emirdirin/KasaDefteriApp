namespace KasaDefteriApp
{
    partial class FormKasaEkle
    {
        /// <summary>
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
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKasaEkle));
            label1 = new Label();
            txtYeniKasaAdi = new TextBox();
            btnKaydet = new Button();
            ýmageList1 = new ImageList(components);
            btnIptal = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 64, 64);
            label1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(27, 34);
            label1.Name = "label1";
            label1.Size = new Size(96, 25);
            label1.TabIndex = 0;
            label1.Text = "Kasa Adý :";
            // 
            // txtYeniKasaAdi
            // 
            txtYeniKasaAdi.BackColor = Color.Honeydew;
            txtYeniKasaAdi.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            txtYeniKasaAdi.ForeColor = Color.FromArgb(0, 64, 64);
            txtYeniKasaAdi.Location = new Point(27, 73);
            txtYeniKasaAdi.Name = "txtYeniKasaAdi";
            txtYeniKasaAdi.PlaceholderText = "Kasa Adýný Giriniz";
            txtYeniKasaAdi.Size = new Size(201, 30);
            txtYeniKasaAdi.TabIndex = 1;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.Honeydew;
            btnKaydet.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnKaydet.Image = (Image)resources.GetObject("btnKaydet.Image");
            btnKaydet.Location = new Point(133, 138);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(95, 45);
            btnKaydet.TabIndex = 2;
            btnKaydet.Text = "Kaydet";
            btnKaydet.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // ýmageList1
            // 
            ýmageList1.ColorDepth = ColorDepth.Depth32Bit;
            ýmageList1.ImageStream = (ImageListStreamer)resources.GetObject("ýmageList1.ImageStream");
            ýmageList1.TransparentColor = Color.Transparent;
            ýmageList1.Images.SetKeyName(0, "sil4.png");
            ýmageList1.Images.SetKeyName(1, "png-transparent-check-check-mark-computer-icons-green-tick-miscellaneous-angle-leaf.png");
            // 
            // btnIptal
            // 
            btnIptal.BackColor = Color.Honeydew;
            btnIptal.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnIptal.Image = (Image)resources.GetObject("btnIptal.Image");
            btnIptal.Location = new Point(27, 138);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(73, 45);
            btnIptal.TabIndex = 3;
            btnIptal.Text = "Ýptal";
            btnIptal.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIptal.UseVisualStyleBackColor = false;
            btnIptal.Click += btnIptal_Click;
            // 
            // FormKasaEkle
            // 
            AcceptButton = btnKaydet;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(256, 209);
            Controls.Add(btnIptal);
            Controls.Add(btnKaydet);
            Controls.Add(txtYeniKasaAdi);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormKasaEkle";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormKasaEkle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        // Kontrol tanýmlarýný buraya eklemelisiniz (Örn: private System.Windows.Forms.Label label1;)
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYeniKasaAdi;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnIptal;
        private ImageList ýmageList1;
    }
}