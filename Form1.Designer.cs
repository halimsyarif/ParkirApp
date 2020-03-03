namespace UAS_ParkirApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelJmlhMotor = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelJmlhMobil = new System.Windows.Forms.Label();
            this.jam = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tanggal = new System.Windows.Forms.Label();
            this.tarifParkir = new System.Windows.Forms.Button();
            this.daftarAnggota = new System.Windows.Forms.Button();
            this.riwayatParkir = new System.Windows.Forms.Button();
            this.kendKeluar = new System.Windows.Forms.Button();
            this.kendMasuk = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(400, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Universitas Paramadina";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(445, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Parking System";
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit.BackgroundImage")));
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.exit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(775, 0);
            this.exit.Margin = new System.Windows.Forms.Padding(4);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(44, 46);
            this.exit.TabIndex = 0;
            this.exit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MintCream;
            this.panel2.Controls.Add(this.labelJmlhMotor);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.labelJmlhMobil);
            this.panel2.Controls.Add(this.jam);
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Controls.Add(this.tanggal);
            this.panel2.Controls.Add(this.tarifParkir);
            this.panel2.Controls.Add(this.daftarAnggota);
            this.panel2.Controls.Add(this.riwayatParkir);
            this.panel2.Controls.Add(this.kendKeluar);
            this.panel2.Controls.Add(this.kendMasuk);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 537);
            this.panel2.TabIndex = 2;
            // 
            // labelJmlhMotor
            // 
            this.labelJmlhMotor.AutoSize = true;
            this.labelJmlhMotor.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJmlhMotor.Location = new System.Drawing.Point(62, 485);
            this.labelJmlhMotor.Name = "labelJmlhMotor";
            this.labelJmlhMotor.Size = new System.Drawing.Size(29, 19);
            this.labelJmlhMotor.TabIndex = 0;
            this.labelJmlhMotor.Text = "20";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(97, 485);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Motor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 462);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mobil";
            // 
            // labelJmlhMobil
            // 
            this.labelJmlhMobil.AutoSize = true;
            this.labelJmlhMobil.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJmlhMobil.Location = new System.Drawing.Point(62, 462);
            this.labelJmlhMobil.Name = "labelJmlhMobil";
            this.labelJmlhMobil.Size = new System.Drawing.Size(29, 19);
            this.labelJmlhMobil.TabIndex = 0;
            this.labelJmlhMobil.Text = "20";
            // 
            // jam
            // 
            this.jam.AutoSize = true;
            this.jam.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jam.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.jam.Location = new System.Drawing.Point(56, 366);
            this.jam.Name = "jam";
            this.jam.Size = new System.Drawing.Size(80, 21);
            this.jam.TabIndex = 0;
            this.jam.Text = "00:00:00";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(39, 431);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(131, 25);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "Total Kendaraan";
            // 
            // tanggal
            // 
            this.tanggal.AutoSize = true;
            this.tanggal.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tanggal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tanggal.Location = new System.Drawing.Point(42, 341);
            this.tanggal.Name = "tanggal";
            this.tanggal.Size = new System.Drawing.Size(113, 21);
            this.tanggal.TabIndex = 0;
            this.tanggal.Text = "10 Jan 2020";
            // 
            // tarifParkir
            // 
            this.tarifParkir.Dock = System.Windows.Forms.DockStyle.Top;
            this.tarifParkir.Location = new System.Drawing.Point(0, 260);
            this.tarifParkir.Name = "tarifParkir";
            this.tarifParkir.Size = new System.Drawing.Size(200, 65);
            this.tarifParkir.TabIndex = 7;
            this.tarifParkir.Text = "Tarif Parkir";
            this.tarifParkir.UseVisualStyleBackColor = true;
            this.tarifParkir.Click += new System.EventHandler(this.tarifParkir_Click);
            // 
            // daftarAnggota
            // 
            this.daftarAnggota.Dock = System.Windows.Forms.DockStyle.Top;
            this.daftarAnggota.Location = new System.Drawing.Point(0, 195);
            this.daftarAnggota.Name = "daftarAnggota";
            this.daftarAnggota.Size = new System.Drawing.Size(200, 65);
            this.daftarAnggota.TabIndex = 6;
            this.daftarAnggota.Text = "Daftar Anggota";
            this.daftarAnggota.UseVisualStyleBackColor = true;
            this.daftarAnggota.Click += new System.EventHandler(this.daftarAnggota_Click);
            // 
            // riwayatParkir
            // 
            this.riwayatParkir.Dock = System.Windows.Forms.DockStyle.Top;
            this.riwayatParkir.Location = new System.Drawing.Point(0, 130);
            this.riwayatParkir.Name = "riwayatParkir";
            this.riwayatParkir.Size = new System.Drawing.Size(200, 65);
            this.riwayatParkir.TabIndex = 5;
            this.riwayatParkir.Text = "Riwayat Parkir";
            this.riwayatParkir.UseVisualStyleBackColor = true;
            this.riwayatParkir.Click += new System.EventHandler(this.riwayatParkir_Click);
            // 
            // kendKeluar
            // 
            this.kendKeluar.Dock = System.Windows.Forms.DockStyle.Top;
            this.kendKeluar.Location = new System.Drawing.Point(0, 65);
            this.kendKeluar.Name = "kendKeluar";
            this.kendKeluar.Size = new System.Drawing.Size(200, 65);
            this.kendKeluar.TabIndex = 4;
            this.kendKeluar.Text = "Kendaraan Keluar";
            this.kendKeluar.UseVisualStyleBackColor = true;
            this.kendKeluar.Click += new System.EventHandler(this.kendKeluar_Click);
            // 
            // kendMasuk
            // 
            this.kendMasuk.Dock = System.Windows.Forms.DockStyle.Top;
            this.kendMasuk.Location = new System.Drawing.Point(0, 0);
            this.kendMasuk.Name = "kendMasuk";
            this.kendMasuk.Size = new System.Drawing.Size(200, 65);
            this.kendMasuk.TabIndex = 3;
            this.kendMasuk.Text = "Kendaraan Masuk";
            this.kendMasuk.UseVisualStyleBackColor = true;
            this.kendMasuk.Click += new System.EventHandler(this.kendMasuk_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Location = new System.Drawing.Point(200, 78);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(619, 537);
            this.panelContainer.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 78);
            this.panel1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(819, 615);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button tarifParkir;
        private System.Windows.Forms.Button daftarAnggota;
        private System.Windows.Forms.Button riwayatParkir;
        private System.Windows.Forms.Button kendKeluar;
        private System.Windows.Forms.Button kendMasuk;
        private System.Windows.Forms.Label tanggal;
        private System.Windows.Forms.Label jam;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label labelJmlhMotor;
        private System.Windows.Forms.Label labelJmlhMobil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
    }
}

