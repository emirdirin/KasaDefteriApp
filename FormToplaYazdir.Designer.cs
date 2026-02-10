namespace KasaDefteriApp
{
    partial class FormToplaYazdir
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

        private Label label1;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormToplaYazdir));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            textBoxToplamCikan = new TextBox();
            textBoxToplamGiren = new TextBox();
            panel2 = new Panel();
            textBoxToplamBakiye = new TextBox();
            label4 = new Label();
            buttonGeri1 = new Button();
            buttonYazdir = new Button();
            labelTarih = new Label();
            labelNull = new Label();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDialog1 = new PrintDialog();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Honeydew;
            label1.Location = new Point(3, 11);
            label1.Name = "label1";
            label1.Size = new Size(184, 23);
            label1.TabIndex = 0;
            label1.Text = "Toplam Giren Miktarý : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.Honeydew;
            label2.Location = new Point(3, 64);
            label2.Name = "label2";
            label2.Size = new Size(186, 23);
            label2.TabIndex = 1;
            label2.Text = "Toplam Çýkan Miktarý : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.Honeydew;
            label3.Location = new Point(3, 18);
            label3.Name = "label3";
            label3.Size = new Size(129, 23);
            label3.TabIndex = 2;
            label3.Text = "Toplam Bakiye :";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(textBoxToplamCikan);
            panel1.Controls.Add(textBoxToplamGiren);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(34, 74);
            panel1.Name = "panel1";
            panel1.Size = new Size(424, 105);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // textBoxToplamCikan
            // 
            textBoxToplamCikan.BackColor = Color.Honeydew;
            textBoxToplamCikan.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBoxToplamCikan.ForeColor = Color.Red;
            textBoxToplamCikan.Location = new Point(193, 64);
            textBoxToplamCikan.Name = "textBoxToplamCikan";
            textBoxToplamCikan.ReadOnly = true;
            textBoxToplamCikan.Size = new Size(221, 30);
            textBoxToplamCikan.TabIndex = 3;
            textBoxToplamCikan.TextAlign = HorizontalAlignment.Right;
            // 
            // textBoxToplamGiren
            // 
            textBoxToplamGiren.BackColor = Color.Honeydew;
            textBoxToplamGiren.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBoxToplamGiren.ForeColor = Color.Green;
            textBoxToplamGiren.Location = new Point(193, 11);
            textBoxToplamGiren.Name = "textBoxToplamGiren";
            textBoxToplamGiren.ReadOnly = true;
            textBoxToplamGiren.Size = new Size(221, 30);
            textBoxToplamGiren.TabIndex = 2;
            textBoxToplamGiren.TextAlign = HorizontalAlignment.Right;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(textBoxToplamBakiye);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(34, 201);
            panel2.Name = "panel2";
            panel2.Size = new Size(424, 60);
            panel2.TabIndex = 4;
            // 
            // textBoxToplamBakiye
            // 
            textBoxToplamBakiye.BackColor = Color.Honeydew;
            textBoxToplamBakiye.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBoxToplamBakiye.Location = new Point(193, 10);
            textBoxToplamBakiye.Name = "textBoxToplamBakiye";
            textBoxToplamBakiye.ReadOnly = true;
            textBoxToplamBakiye.Size = new Size(221, 30);
            textBoxToplamBakiye.TabIndex = 3;
            textBoxToplamBakiye.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.Honeydew;
            label4.Location = new Point(34, 9);
            label4.Name = "label4";
            label4.Size = new Size(0, 28);
            label4.TabIndex = 5;
            // 
            // buttonGeri1
            // 
            buttonGeri1.BackColor = Color.Honeydew;
            buttonGeri1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            buttonGeri1.Image = (Image)resources.GetObject("buttonGeri1.Image");
            buttonGeri1.Location = new Point(34, 283);
            buttonGeri1.Name = "buttonGeri1";
            buttonGeri1.Size = new Size(107, 55);
            buttonGeri1.TabIndex = 6;
            buttonGeri1.Text = "Geri";
            buttonGeri1.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonGeri1.UseVisualStyleBackColor = false;
            buttonGeri1.Click += buttonGeri1_Click;
            // 
            // buttonYazdir
            // 
            buttonYazdir.BackColor = Color.Honeydew;
            buttonYazdir.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            buttonYazdir.Image = (Image)resources.GetObject("buttonYazdir.Image");
            buttonYazdir.Location = new Point(291, 283);
            buttonYazdir.Name = "buttonYazdir";
            buttonYazdir.Size = new Size(163, 55);
            buttonYazdir.TabIndex = 7;
            buttonYazdir.Text = "  Yazdýr";
            buttonYazdir.TextAlign = ContentAlignment.MiddleRight;
            buttonYazdir.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonYazdir.UseVisualStyleBackColor = false;
            buttonYazdir.Click += buttonYazdir_Click;
            // 
            // labelTarih
            // 
            labelTarih.AutoSize = true;
            labelTarih.BackColor = Color.Honeydew;
            labelTarih.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelTarih.ForeColor = Color.FromArgb(0, 64, 64);
            labelTarih.Location = new Point(34, 26);
            labelTarih.Name = "labelTarih";
            labelTarih.Size = new Size(55, 25);
            labelTarih.TabIndex = 8;
            labelTarih.Text = "Tarih";
            // 
            // labelNull
            // 
            labelNull.AutoSize = true;
            labelNull.Enabled = false;
            labelNull.Location = new Point(408, 26);
            labelNull.Name = "labelNull";
            labelNull.Size = new Size(33, 20);
            labelNull.TabIndex = 9;
            labelNull.Text = "null";
            labelNull.Visible = false;
            // 
            // printDocument1
            // 
            printDocument1.BeginPrint += printDocument1_BeginPrint;
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            printDialog1.Document = printDocument1;
            printDialog1.UseEXDialog = true;
            // 
            // FormToplaYazdir
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(486, 347);
            Controls.Add(labelNull);
            Controls.Add(labelTarih);
            Controls.Add(buttonYazdir);
            Controls.Add(buttonGeri1);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormToplaYazdir";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormToplaYazdir_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label2;
        private Label label3;
        private Panel panel1;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private TextBox textBoxToplamCikan;
        private TextBox textBoxToplamGiren;
        private Panel panel2;
        private TextBox textBoxToplamBakiye;
        private Label label4;
        private Button buttonGeri1;
        private Button buttonYazdir;
        private Label labelTarih;
        private Label labelNull;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private PrintDialog printDialog1;
    }
}

// namespace end