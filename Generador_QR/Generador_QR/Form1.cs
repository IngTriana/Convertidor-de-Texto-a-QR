using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;


namespace Generador_QR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnqr_Click(object sender, EventArgs e)
        {
            Zen.Barcode.CodeQrBarcodeDraw codigoqr = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            PicBoxQR.Image = codigoqr.Draw(txtQR.Text, 200);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "JPEG|*.jpeg";

            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                string varimg = saveFileDialog1.FileName;
                Bitmap varbmp = new Bitmap(PicBoxQR.Image);
                varbmp.Save(varimg, ImageFormat.Jpeg);

            }
        }
    }
}
