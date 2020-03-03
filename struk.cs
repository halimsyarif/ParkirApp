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
    public partial class struk : Form
    {
        public struk()
        {
            InitializeComponent();
        }
        string tarifMobil;
        string tarifMotor;
        string Plat;
        string jnsKndrn;
        string jamMasuk;
        string jamKeluar;
        string durasi;
        string status;
        string tarif;
        string tagihan;
        private void getTarif()
        {
            if (status == "Member")
            {
                tarifMobil = "0";
                tarifMotor = "0";
            }
            else
            {
                string[] harga = File.ReadAllText("../../tarif.txt").Split('|');
                tarifMobil = harga[0];
                tarifMotor = harga[1];
            }
        }
        private void getStatus()
        {
            string stat = "umum";
            string[] baris = File.ReadAllText("../../anggota.txt").Split('\n');
            for (int i = 1; i < baris.Length; i++)
            {
                string[] anggota = baris[i].Trim().Split('|');
                if (Plat==anggota[2])
                {
                    stat = "Member";
                }
            }
            status = stat;
        }
        public struk(TimeSpan durasiParkir, DateTime jmMasuk, DateTime jmKeluar, string noPlat, string jnskndrn, string karcisHilang) : this()
        {
            Plat = noPlat;
            jnsKndrn = jnskndrn;
            jamMasuk = jmMasuk.ToString();
            jamKeluar = jmKeluar.ToString();
            durasi = durasiParkir.ToString();
            getStatus();
            labelStatus.Text = status;
            getTarif();
            labelDurasi.Text = Convert.ToString(durasiParkir.Hours) + " jam " + Convert.ToString(durasiParkir.Minutes) + " menit";
            labelPlat.Text = noPlat;
            labelMasuk.Text = jmMasuk.ToString();
            labelKeluar.Text = jmKeluar.ToString();
            labelKndrn.Text = jnskndrn;
            if (jnskndrn == "mobil")
            { labelTarif.Text = (Convert.ToInt32(tarifMobil) * (durasiParkir.Hours+1)).ToString(); }
            if (jnskndrn == "motor")
            { labelTarif.Text = (Convert.ToInt32(tarifMotor) * (durasiParkir.Hours + 1)).ToString(); }
            tarif = labelTarif.Text;
            if (karcisHilang == "yes")
            { labelDenda.Text = "50000"; }
            else { labelDenda.Text = "0"; }
            labelTotal.Text = (Convert.ToInt32(labelTarif.Text) + Convert.ToInt32(labelDenda.Text)).ToString();
            tagihan = labelTotal.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (var image = new Bitmap(panelStruk.Width, panelStruk.Height))
            {
                panelStruk.DrawToBitmap(image, new Rectangle(0, 0, image.Width, image.Height));
                image.Save("../../RiwayatParkir/" + "tes" + ".bmp");
            }
            updateData();
            this.Close();
            
        }

        private void updateData() //buat nyimpan data jam keluar
        {
            string fileHasil = "../../RiwayatParkir/RiwayatParkir.csv";
            string hasil = File.ReadAllText("../../RiwayatParkir/RiwayatParkir.csv");

            string[] baris = hasil.Split('\n');
            string[] kolom = baris[baris.Length-1].Trim().Split(';');
            string id = kolom[0];

            hasil = hasil + "\n" + (Convert.ToInt32(id) + 1).ToString() + ";" + Plat + ";" + jnsKndrn + ";" + jamMasuk + ";" + jamKeluar + ";" + labelDurasi.Text + ";" + status + ";" + tarif + ";" + tagihan;

            File.WriteAllText(fileHasil, hasil);

            //cari baris yang dihapus
            string hapusData = "";
            string[] dataParkir = File.ReadAllText("../../DataParkir/DataParkir.csv").Trim().Split('\n');
            for (int i = 1; i < dataParkir.Length; i++)
            {
                string[] kolomParkir = dataParkir[i].Trim().Split(';');
                if (kolomParkir[1] == Plat)
                {
                    hapusData = dataParkir[i];
                }
            }
            var list = new List<string>(dataParkir);
            list.Remove(hapusData);
            dataParkir = list.ToArray();

            string dataBaru = "ID;No. Plat;Jenis Kendaraan;Jam Masuk";
            int noBaru = 1;
            for (int a = 1; a < dataParkir.Length; a++)
            {
                dataBaru += "\n" + noBaru + ";" + dataParkir[a].Substring(2, dataParkir[a].Length-2);
                noBaru += 1;
            }
            File.WriteAllText("../../DataParkir/DataParkir.csv", dataBaru);
        }
        private void struk_Load(object sender, EventArgs e)
        {

        }
    }
}
