namespace KasaDefteriApp
{
    public partial class FormGiris : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGiris));
            pictureBox1 = new PictureBox();
            passwordBox = new TextBox();
            passwordLabel = new Label();
            panelBottom = new Panel();
            labelButtom = new Label();
            buttonGiris = new Button();
            ımageList1 = new ImageList(components);
            buttonCikis = new Button();
            panelTop = new Panel();
            labelWelcome = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelBottom.SuspendLayout();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(0, 64, 64);
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(227, 249);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // passwordBox
            // 
            passwordBox.BackColor = Color.Honeydew;
            passwordBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            passwordBox.ForeColor = SystemColors.ActiveCaptionText;
            passwordBox.Location = new Point(269, 254);
            passwordBox.Name = "passwordBox";
            passwordBox.PasswordChar = '*';
            passwordBox.Size = new Size(201, 31);
            passwordBox.TabIndex = 2;
            // 
            // passwordLabel
            // 
            passwordLabel.BackColor = Color.FromArgb(0, 64, 64);
            passwordLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            passwordLabel.ForeColor = SystemColors.Info;
            passwordLabel.Location = new Point(269, 218);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(61, 24);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Şifre :";
            // 
            // panelBottom
            // 
            panelBottom.BackColor = Color.Honeydew;
            panelBottom.Controls.Add(labelButtom);
            panelBottom.Location = new Point(-1, 405);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(481, 33);
            panelBottom.TabIndex = 4;
            // 
            // labelButtom
            // 
            labelButtom.AutoSize = true;
            labelButtom.ForeColor = SystemColors.ActiveCaptionText;
            labelButtom.Location = new Point(15, 7);
            labelButtom.Name = "labelButtom";
            labelButtom.Size = new Size(231, 20);
            labelButtom.TabIndex = 1;
            labelButtom.Text = "© 2025 Kasa Defteri Uygulaması. ";
            // 
            // buttonGiris
            // 
            buttonGiris.BackColor = Color.Honeydew;
            buttonGiris.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            buttonGiris.ForeColor = SystemColors.ActiveCaptionText;
            buttonGiris.Image = (Image)resources.GetObject("buttonGiris.Image");
            buttonGiris.Location = new Point(378, 305);
            buttonGiris.Name = "buttonGiris";
            buttonGiris.RightToLeft = RightToLeft.No;
            buttonGiris.Size = new Size(92, 50);
            buttonGiris.TabIndex = 0;
            buttonGiris.Text = "Giriş";
            buttonGiris.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonGiris.UseVisualStyleBackColor = false;
            buttonGiris.Click += buttonGiris_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "cikan2.png");
            ımageList1.Images.SetKeyName(1, "cikan4.png");
            ımageList1.Images.SetKeyName(2, "giris2.png");
            ımageList1.Images.SetKeyName(3, "çıkış2.png");
            ımageList1.Images.SetKeyName(4, "çıkış3.png");
            ımageList1.Images.SetKeyName(5, "giriş7.jpg");
            ımageList1.Images.SetKeyName(6, "çıkış4.png");
            // 
            // buttonCikis
            // 
            buttonCikis.BackColor = Color.Honeydew;
            buttonCikis.Font = new Font("Segoe UI Semibold", 9.8F, FontStyle.Bold);
            buttonCikis.ForeColor = SystemColors.ActiveCaptionText;
            buttonCikis.Image = (Image)resources.GetObject("buttonCikis.Image");
            buttonCikis.Location = new Point(269, 305);
            buttonCikis.Name = "buttonCikis";
            buttonCikis.Size = new Size(90, 50);
            buttonCikis.TabIndex = 1;
            buttonCikis.Text = "Çıkış";
            buttonCikis.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonCikis.UseVisualStyleBackColor = false;
            buttonCikis.Click += buttonCikis_Click;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(0, 64, 64);
            panelTop.Controls.Add(labelWelcome);
            panelTop.Location = new Point(-1, 8);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(486, 64);
            panelTop.TabIndex = 5;
            // 
            // labelWelcome
            // 
            labelWelcome.BackColor = Color.Honeydew;
            labelWelcome.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            labelWelcome.ForeColor = Color.FromArgb(0, 64, 64);
            labelWelcome.Location = new Point(-1, 9);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(481, 41);
            labelWelcome.TabIndex = 0;
            labelWelcome.Text = "Kasa Defteri'ne Hoşgeldiniz";
            labelWelcome.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Honeydew;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(287, 100);
            label1.Name = "label1";
            label1.Size = new Size(111, 25);
            label1.TabIndex = 6;
            label1.Text = "Sürüm: 1.0.0";
            // 
            // FormGiris
            // 
            AcceptButton = buttonGiris;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(482, 450);
            Controls.Add(label1);
            Controls.Add(buttonGiris);
            Controls.Add(buttonCikis);
            Controls.Add(panelTop);
            Controls.Add(panelBottom);
            Controls.Add(passwordLabel);
            Controls.Add(passwordBox);
            Controls.Add(pictureBox1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormGiris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "z";
            Load += FormGiris_Load;
            Shown += FormGiris_Shown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelBottom.ResumeLayout(false);
            panelBottom.PerformLayout();
            panelTop.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private TextBox passwordBox;
        private Label passwordLabel;
        private Panel panelBottom;
        private Button button2;
        private Button buttonGiris;
        private Button buttonCikis;
        private Panel panelTop;
        private Label labelWelcome;
        private Label label1;
        private ImageList ımageList1;
        private Label labelButtom;
    }
}