using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace UAS_ParkirApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult result;
            result = MessageBox.Show("Anda yakin ingin Keluar??", "Exit", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
        public Panel PnlContainer
        {
            get { return panelContainer; }
            set { panelContainer = value; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            tanggal.Text = DateTime.Now.ToString("dd MMM yyyy"); //tanggal

            //timer berjalan
            Timer t = new Timer();
            t.Interval = 1000;
            t.Tick += new EventHandler(this.t_Tick);
            t.Start();

            //userControl
            KendaraanMasuk km = new KendaraanMasuk();
            PnlContainer.Controls.Add(km);
            km.Dock = DockStyle.Fill;

            KendaraanKeluar kl = new KendaraanKeluar();
            PnlContainer.Controls.Add(kl);
            kl.Dock = DockStyle.Fill;

            Riwayat rwyt = new Riwayat();
            PnlContainer.Controls.Add(rwyt);
            rwyt.Dock = DockStyle.Fill;
            rwyt.updateData(this);

            DaftarAnggota da = new DaftarAnggota();
            PnlContainer.Controls.Add(da);
            da.Dock = DockStyle.Fill;

            TarifParkir tp = new TarifParkir();
            tp.Dock = DockStyle.Fill;
            PnlContainer.Controls.Add(tp);

            hitungkndraan();

        }
        private void t_Tick(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            string time = "";

            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time += ":";

            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";

            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }
            jam.Text = time;
        }


        private void tarifParkir_Click(object sender, EventArgs e)
        {
            PnlContainer.Controls["tarifParkir"].BringToFront();
        }

        private void daftarAnggota_Click(object sender, EventArgs e)
        {
            PnlContainer.Controls["DaftarAnggota"].BringToFront();
        }

        private void riwayatParkir_Click(object sender, EventArgs e)
        {
            PnlContainer.Controls["Riwayat"].BringToFront();
            
        }

        private void kendKeluar_Click(object sender, EventArgs e)
        {
            PnlContainer.Controls["KendaraanKeluar"].BringToFront();
        }

        private void kendMasuk_Click(object sender, EventArgs e)
        {
            PnlContainer.Controls["KendaraanMasuk"].BringToFront();
        }
        internal void hitungkndraan()
        {
            
            int jmlhMobil = 0;
            int jmlhMotor = 0;
            string[] lines = File.ReadAllLines("../../DataParkir/DataParkir.csv");
            for (int i = 1; i < lines.Length; i++)
            {
                string[] kolom = lines[i].Trim().Split(';');
                if (kolom[2] == "motor")
                {
                    jmlhMotor += 1;
                }
                else
                {
                    jmlhMobil += 1;
                }
            }
            labelJmlhMobil.Text = jmlhMobil.ToString();
            labelJmlhMotor.Text = jmlhMotor.ToString();
        }

        Point lastPoint;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;

            }
        }
    }
}
