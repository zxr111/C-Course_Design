using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        //初始化图片
        Bitmap bitmap = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
              
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        //打开操作
        private void button1_Click(object sender, EventArgs e)
        {
            //Graphics g;
            OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
            if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = OpenFileDialog1.FileName;
                bitmap = (Bitmap)Image.FromFile(path);
                pictureBox1.Image = bitmap.Clone() as Image;
            }
        }
        //保存
        private void button1_Click_1(object sender, EventArgs e)
        {
            bool isSave = true;
            SaveFileDialog savefiledialog1 = new SaveFileDialog();
            if (savefiledialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = savefiledialog1.FileName.ToString();
                if(filename != "" && filename != null)
                {
                    string Extname = filename.Substring(filename.LastIndexOf(".") + 1).ToString();
                    System.Drawing.Imaging.ImageFormat imageformate = null;

                    if (Extname != "")
                    {
                        switch (Extname)
                        {
                            case "":
                                imageformate = System.Drawing.Imaging.ImageFormat.Jpeg;
                                break;
                            case "jpg":
                                imageformate = System.Drawing.Imaging.ImageFormat.Jpeg;
                                break;
                            case "png":
                                imageformate = System.Drawing.Imaging.ImageFormat.Png;
                                break;
                            case "bmp":
                                imageformate = System.Drawing.Imaging.ImageFormat.Bmp;
                                break;
                            case "gif":
                                imageformate = System.Drawing.Imaging.ImageFormat.Gif;
                                break;
                            default:
                                MessageBox.Show("存储文件格式不正确");
                                isSave = false;
                                break;
                        }

                        if (isSave)
                        {
                            try
                            {
                                this.pictureBox2.Image.Save(filename, imageformate);
                            }
                            catch 
                            {
                                MessageBox.Show("没有处理图片，保存失败");
                            }
                        }
                    }
                }
            }
        }//保存

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        //变暗
        private void button2_Click(object sender, EventArgs e)
        {
            if (bitmap != null)
            {
                Bitmap newbitmap = bitmap.Clone() as Bitmap;
                //sw.Reset();
               // sw.Restart();
                Color pixel;
                int red, green, blue;
                for (int x = 0; x < newbitmap.Width; x++)
                {
                    for (int y = 0; y < newbitmap.Height; y++)
                    {
                        pixel = newbitmap.GetPixel(x, y);
                        red = (int)(pixel.R * 0.6);
                        green = (int)(pixel.G * 0.6);
                        blue = (int)(pixel.B * 0.6);
                        newbitmap.SetPixel(x, y, Color.FromArgb(red, green, blue));
                    }
                }
               // sw.Stop();
               // timer.Text = sw.ElapsedMilliseconds.ToString();
                pictureBox2.Image = newbitmap.Clone() as Image;
            }
        }
        //测试
        private void button3_Click(object sender, EventArgs e)
        {
            if (bitmap != null)
            {
                Bitmap newbitmap = bitmap.Clone() as Bitmap;
                //sw.Reset();
                // sw.Restart();
                Color pixel;
                int red, green, blue;
                for (int x = 0; x < newbitmap.Width; x++)
                {
                    for (int y = 0; y < newbitmap.Height; y++)
                    {
                        pixel = newbitmap.GetPixel(x, y);
                            red = (int)(0.7 * pixel.R);
                            green = (int)(0.2 * pixel.G);
                            blue = (int)(0.1 * pixel.R);
                            newbitmap.SetPixel(x, y, Color.FromArgb(red, green, blue));
                    }
                }
                // sw.Stop();
                // timer.Text = sw.ElapsedMilliseconds.ToString();
                pictureBox2.Image = newbitmap.Clone() as Image;
            }
        }
        //马赛克
        private void button4_Click(object sender, EventArgs e)
        {
            if (bitmap != null)
            {
                Bitmap newbitmap = bitmap.Clone() as Bitmap;
                //sw.Reset();
                //sw.Restart();
                int RIDIO = 10;//马赛克的尺度，默认为周围两个像素
                for (int h = 0; h < newbitmap.Height; h += RIDIO)
                {
                    for (int w = 0; w < newbitmap.Width; w += RIDIO)
                    {
                        int avgRed = 0, avgGreen = 0, avgBlue = 0;
                        int count = 0;
                        //取周围的像素
                        for (int x = w; (x < w + RIDIO && x < newbitmap.Width); x++)
                        {
                            for (int y = h; (y < h + RIDIO && y < newbitmap.Height); y++)
                            {
                                Color pixel = newbitmap.GetPixel(x, y);
                                avgRed += pixel.R;
                                avgGreen += pixel.G;
                                avgBlue += pixel.B;
                                count++;
                            }
                        }

                        //取平均值
                        avgRed = avgRed / count;
                        avgBlue = avgBlue / count;
                        avgGreen = avgGreen / count;

                        //设置颜色
                        for (int x = w; (x < w + RIDIO && x < newbitmap.Width); x++)
                        {
                            for (int y = h; (y < h + RIDIO && y < newbitmap.Height); y++)
                            {
                                Color newColor = Color.FromArgb(avgRed, avgGreen, avgBlue);
                                newbitmap.SetPixel(x, y, newColor);
                            }
                        }
                    }
                }
                pictureBox2.Image = newbitmap.Clone() as Image;
            }//马赛克
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
        //浮雕
        private void button6_Click(object sender, EventArgs e)
        {
            if (bitmap != null)
            {
                Bitmap newbitmap = bitmap.Clone() as Bitmap;
                Color pixel;
                int red, blue, green;
                for (int h = 0; h < newbitmap.Width; h++)
                {
                    for (int w = 0; w < bitmap.Height; w++)
                    {
                        pixel = newbitmap.GetPixel(h, w);
                        red = (int)(255 - pixel.R);
                        blue = (int)(255 - pixel.B);
                        green = (int)(255 - pixel.G);
                        newbitmap.SetPixel(h, w, Color.FromArgb(red, green, blue));
                    }                    
                }
                pictureBox2.Image = newbitmap.Clone() as Image;
            }
        }//浮雕

        //黑白
        private void button7_Click(object sender, EventArgs e)
        {
            if (bitmap != null)
            {
                Bitmap newbitmap = bitmap.Clone() as Bitmap;
                //sw.Reset();
                // sw.Restart();
                Color pixel;
                int red, green, blue;
                for (int x = 0; x < newbitmap.Width; x++)
                {
                    for (int y = 0; y < newbitmap.Height; y++)
                    {
                        pixel = newbitmap.GetPixel(x, y);
                        if (pixel.R > 125 || pixel.G > 125 || pixel.B > 125)
                        {
                            red = (int)(255);
                            green = (int)(255);
                            blue = (int)(255);
                            newbitmap.SetPixel(x, y, Color.FromArgb(red, green, blue));
                        }
                        else
                        {
                            red = (int)(0);
                            green = (int)(0);
                            blue = (int)(0);
                            newbitmap.SetPixel(x, y, Color.FromArgb(red, green, blue));
                        }
                    }
                }
                pictureBox2.Image = newbitmap.Clone() as Image;
            }
        }//黑白
    }
}
