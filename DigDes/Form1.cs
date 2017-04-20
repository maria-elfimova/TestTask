using System;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigDes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap image1;
        private void button_convert_Click(object sender, EventArgs e)
        {
            try
            {
                String path = label_path.Text;
                image1 = new Bitmap(path);

                FileInfo file = new FileInfo(label_pathToResult.Text);
                StreamWriter stWr = file.CreateText();

                int countWidth = image1.Width / 150;
                int countHeight = image1.Height / 90;
                Color pixelColor;
                int color = 0;

                for (int y = 0; y < image1.Height - countHeight + 1; y += countHeight)
                {
                    for (int x = 0; x < image1.Width - countWidth + 1; x += countWidth)
                    {
                        for (int p = 0; p < countWidth; p++)
                        {
                            for (int k = 0; k < countHeight; k++)
                            {
                                pixelColor = image1.GetPixel(x + p, y + k);
                                color += (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                            }
                        }
                        color /= countWidth;
                        color /= countHeight;
                        if (color < 50)
                        {
                            stWr.Write("#");
                        }
                        else if (color < 100)
                        {
                            stWr.Write("%");
                        }
                        else if (color < 150)
                        {
                            stWr.Write("*");
                        }
                        else if (color < 200)
                        {
                            stWr.Write(":");
                        }
                        else if (color < 240)
                        {
                            stWr.Write(".");
                        }
                        else
                        {
                            stWr.Write(" ");
                        }
                    }
                    stWr.WriteLine();
                }
                stWr.Close();
                MessageBox.Show("Conversion completed.");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("There was an error." +
                    "Check the path to the image file.");
            }
        }

        private void button_selectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                label_path.Text = openFileDialog.FileName;

        }

        private void button_selectText_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                label_pathToResult.Text = openFileDialog.FileName;
        }

    }
}
