using System.ComponentModel;

namespace KasaDefteriApp
{

    partial class FormIslemEkle
    {
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

        private void InitializeComponent()
        {
            components = new Container();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FormIslemEkle));
            label1 = new Label();
            label2 = new Label();
            textBoxIslem = new TextBox();
            textBoxMiktar = new TextBox();
            buttonTamam = new Button();
            ımageList1 = new ImageList(components);
            buttonIptal = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(26, 39);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 0;
            label1.Text = "İşlem : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = SystemColors.Info;
            label2.Location = new Point(26, 119);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 1;
            label2.Text = "Miktar : ";
            // 
            // textBoxIslem
            // 
            textBoxIslem.BackColor = Color.Honeydew;
            textBoxIslem.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBoxIslem.Location = new Point(26, 71);
            textBoxIslem.Name = "textBoxIslem";
            textBoxIslem.Size = new Size(235, 30);
            textBoxIslem.TabIndex = 2;
            textBoxIslem.KeyDown += textBoxIslem_KeyDown;
            // 
            // textBoxMiktar
            // 
            textBoxMiktar.BackColor = Color.Honeydew;
            textBoxMiktar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBoxMiktar.ForeColor = Color.Black;
            textBoxMiktar.Location = new Point(26, 151);
            textBoxMiktar.MaxLength = 20;
            textBoxMiktar.Name = "textBoxMiktar";
            textBoxMiktar.Size = new Size(235, 30);
            textBoxMiktar.TabIndex = 3;
            textBoxMiktar.Text = "0,00 ₺";
            textBoxMiktar.TextAlign = HorizontalAlignment.Right;
            textBoxMiktar.Enter += textBoxMiktar_Enter;
            textBoxMiktar.KeyDown += textBoxMiktar_KeyDown;
            textBoxMiktar.Leave += textBoxMiktar_Leave;
            // 
            // buttonTamam
            // 
            buttonTamam.BackColor = Color.Honeydew;
            buttonTamam.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonTamam.ForeColor = SystemColors.ActiveCaptionText;
            buttonTamam.Image = (Image)resources.GetObject("buttonTamam.Image");
            buttonTamam.Location = new Point(153, 216);
            buttonTamam.Name = "buttonTamam";
            buttonTamam.Size = new Size(108, 45);
            buttonTamam.TabIndex = 4;
            buttonTamam.Text = "Kaydet";
            buttonTamam.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonTamam.UseVisualStyleBackColor = false;
            buttonTamam.Click += buttonTamam_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Black;
            ımageList1.Images.SetKeyName(0, "png-transparent-check-check-mark-computer-icons-green-tick-miscellaneous-angle-leaf.png");
            ımageList1.Images.SetKeyName(1, "sil3.png");
            // 
            // buttonIptal
            // 
            buttonIptal.BackColor = Color.Honeydew;
            buttonIptal.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonIptal.ForeColor = SystemColors.ActiveCaptionText;
            buttonIptal.Image = (Image)resources.GetObject("buttonIptal.Image");
            buttonIptal.Location = new Point(26, 216);
            buttonIptal.Name = "buttonIptal";
            buttonIptal.Size = new Size(76, 45);
            buttonIptal.TabIndex = 5;
            buttonIptal.Text = "İptal";
            buttonIptal.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonIptal.UseVisualStyleBackColor = false;
            buttonIptal.Click += buttonIptal_Click;
            // 
            // FormIslemEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(287, 284);
            Controls.Add(buttonIptal);
            Controls.Add(buttonTamam);
            Controls.Add(textBoxMiktar);
            Controls.Add(textBoxIslem);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormIslemEkle";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormIslemEkle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
        private TextBox textBoxIslem;
        private TextBox textBoxMiktar;
        private Button buttonTamam;
        private Button buttonIptal;
        private ImageList ımageList1;
    }
}