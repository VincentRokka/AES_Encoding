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
using System.Security.Cryptography;

namespace BtlATBM
{
    public partial class Form1 : Form
    {
        private byte[] IV = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
        private int BlockSize = 128;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGiauTin_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(pictureBox1.Image);
            int i, j;
            for (i=0; i <img.Width; i++)
            {
                for (j=0;j<img.Height; j++)
                {
                    Color pixel = img.GetPixel(i, j);
                    if (i < 1 && j < textBoxMaHoa.Text.Length)
                    {
                        Console.WriteLine("R[" + i + "][" + j + "] : " + pixel.R);
                        Console.WriteLine("R[" + i + "][" + j + "] : " + pixel.B);
                        Console.WriteLine("R[" + i + "][" + j + "] : " + pixel.G);
                        char letter = Convert.ToChar(textBoxMaHoa.Text.Substring(j, 1));
                        int value = Convert.ToInt32(letter);
                        Console.WriteLine("Letter: " + letter + "\n Value: " + value);
                        img.SetPixel(i, j, Color.FromArgb(pixel.R, pixel.G, value));
                    }
                    if(i == img.Width - 1 && j == img.Height - 1)
                    {
                        img.SetPixel(i, j, Color.FromArgb(pixel.R, pixel.G, textBoxMaHoa.Text.Length));
                    }
                }
            }
            SaveFileDialog savefile = new SaveFileDialog();

            savefile.Filter = "JPG|*.jpg|PNG|*.png";
            savefile.InitialDirectory = @"C:\Users\frval\Desktop\ATBMTT";
            if(savefile.ShowDialog()== DialogResult.OK)
            {
                string filename = savefile.FileName;
                img.Save(filename);
            }
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.InitialDirectory = @"C:\Users\frval\Desktop\ATBMTT";
            openfile.Filter = "JPG|*.jpg|PNG|*.png";
            if(openfile.ShowDialog()== DialogResult.OK)
            {
                string file = openfile.FileName.ToString();
                pictureBox1.ImageLocation = file;
                textBoxBrowse.Text = file;
            }
        }

        private void buttonMaHoa_Click(object sender, EventArgs e)
        {
            
            byte[] bytes = Encoding.Unicode.GetBytes(textBoxThongTin.Text);

            //Encrypt
            SymmetricAlgorithm crypt = Aes.Create();
            HashAlgorithm hash = MD5.Create();
            crypt.BlockSize = BlockSize;
            crypt.Key = hash.ComputeHash(Encoding.Unicode.GetBytes("TTLOCTTT"));
            crypt.IV = IV;

            using (MemoryStream memoryStream = new MemoryStream())
            {
                using (CryptoStream cryptoStream = new CryptoStream(memoryStream, crypt.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cryptoStream.Write(bytes, 0, bytes.Length);
                }

                textBoxMaHoa.Text = Convert.ToBase64String(memoryStream.ToArray());
            }
        }

        private void buttonLayTin_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(textBoxBrowse.Text);
            string message = "";
            Color lpixel = img.GetPixel(img.Width - 1, img.Height - 1);
            int messlen = lpixel.B;
            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color pixel = img.GetPixel(i, j);
                    if (i < 1 && j < messlen)
                    {
                        Console.WriteLine("-------------");
                        Console.WriteLine("R[" + i + "][" + j + "] : " + pixel.R);
                        Console.WriteLine("R[" + i + "][" + j + "] : " + pixel.B);
                        Console.WriteLine("R[" + i + "][" + j + "] : " + pixel.G);

                        int value = pixel.B;
                        Console.WriteLine("Value: " + value);
                        char c = Convert.ToChar(value);

                        string letter = c.ToString();
                        message = message + letter;
                    }
                }
            }
            textBoxThongTin.Text = message;
        }

        private void buttonGiaiMa_Click(object sender, EventArgs e)
        {
            byte[] bytes = Convert.FromBase64String(textBoxThongTin.Text);
            SymmetricAlgorithm crypt = Aes.Create();
            HashAlgorithm hash = MD5.Create();
            crypt.Key = hash.ComputeHash(Encoding.Unicode.GetBytes("TTLOCTTT"));
            crypt.IV = IV;

            using (MemoryStream memoryStream = new MemoryStream(bytes))
            {
                using (CryptoStream cryptoStream = new CryptoStream(memoryStream, crypt.CreateDecryptor(), CryptoStreamMode.Read))
                {
                    byte[] decryptedBytes = new byte[bytes.Length];
                    cryptoStream.Read(decryptedBytes, 0, decryptedBytes.Length);
                    textBoxGiaiMa.Text = Encoding.Unicode.GetString(decryptedBytes);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
