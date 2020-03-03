using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UAS_ParkirApp
{
    public partial class karcis : Form
    {
        public karcis()
        {
            InitializeComponent();
        }
        public karcis(string dateTime, string plat, string kend): this()
        {
            label8.Text = dateTime;
            label9.Text = plat;
            label12.Text = "[" + kend + "]";
        }
              

        private void button1_Click(object sender, EventArgs e)
        {
            using (var image = new Bitmap(struk.Width,struk.Height))
            {
                struk.DrawToBitmap(image, new Rectangle(0, 0, image.Width, image.Height));
                image.Save("../../DataParkir/" + "tes" + ".bmp");
            }
            this.Close();
        }

        private void karcis_Load(object sender, EventArgs e)
        {

        }
    }
}
