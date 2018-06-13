using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace WindowsFormsApplication3
{
    public partial class MainForm : Form
    {
        //初始化图片
        Bitmap bitmap = null;
        byte[] RGB;
        int flag;     //flag = 0 表示黑白 1 表示马赛克 2 表示浮雕
        Stack<Bitmap> stack = new Stack<Bitmap>();  //保存每步执行的操作
        public MainForm()
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
                if (filename != "" && filename != null)
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
                stack.Push(newbitmap);
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
                //sw.Restart();
                int RIDIO = 5;//马赛克的尺度，默认为周围两个像素
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
                stack.Push(newbitmap);
                pictureBox2.Image = newbitmap.Clone() as Image;
            }//马赛克
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
                stack.Push(newbitmap);
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
                        red = (int)(125 - pixel.R);
                        blue = (int)(125 - pixel.B);
                        green = (int)(125 - pixel.G);
                        //溢出处理
                        red = red > 255 ? 255 : (red < 0 ? 0 : red);
                        blue = blue > 255 ? 255 : (blue < 0 ? 0 : blue);
                        green = green > 255 ? 255 : (green < 0 ? 0 : green);
                        newbitmap.SetPixel(h, w, Color.FromArgb(red, green, blue));
                    }
                }
                stack.Push(newbitmap);
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
                        //大于取黑否则白
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
                stack.Push(newbitmap);
                pictureBox2.Image = newbitmap.Clone() as Image;
            }
        }//黑白

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            MessageBox.Show("111");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        //菜单
        private void SingleCheck(object sender)
        {
            //图片操作
            打开图片ToolStripMenuItem.Checked = false;
            保存图片ToolStripMenuItem.Checked = false;
        }
        //图片操作
        private void 打开图片ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SingleCheck(sender);
            OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
            if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = OpenFileDialog1.FileName;
                bitmap = (Bitmap)Image.FromFile(path);
                pictureBox1.Image = bitmap.Clone() as Image;
            }
        }

        private void 保存图片ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SingleCheck(sender);
            bool isSave = true;
            SaveFileDialog savefiledialog1 = new SaveFileDialog();
            if (savefiledialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = savefiledialog1.FileName.ToString();
                if (filename != "" && filename != null)
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
        }
        //特效
        private void 黑白ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SingleCheck(sender);
            if (bitmap != null)
            {
                Bitmap newbitmap = bitmap.Clone() as Bitmap;
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
                stack.Push(newbitmap);
                pictureBox2.Image = newbitmap.Clone() as Image;
            }
        }

        private void 马赛克ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SingleCheck(sender);
            if (bitmap != null)
            {
                Bitmap newbitmap = bitmap.Clone() as Bitmap;
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
                stack.Push(newbitmap);
                pictureBox2.Image = newbitmap.Clone() as Image;
            }//马赛克

        }

        private void 浮雕ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SingleCheck(sender);
            if (bitmap != null)
            {
                Bitmap newbitmap = bitmap.Clone() as Bitmap;
                Color pixel;
                int red, blue, green;
                for (int x = 0; x < newbitmap.Width; x++)
                {
                    for (int y = 0; y < bitmap.Height; y++)
                    {
                        pixel = newbitmap.GetPixel(x, y);
                        red = (int)(255 - pixel.R);
                        blue = (int)(255 - pixel.B);
                        green = (int)(255 - pixel.G);
                        newbitmap.SetPixel(x, y, Color.FromArgb(red, green, blue));
                    }
                }
                stack.Push(newbitmap);
                pictureBox2.Image = newbitmap.Clone() as Image;
            }
        }

        private void 暗化ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SingleCheck(sender);
            if (bitmap != null)
            {
                Bitmap newbitmap = bitmap.Clone() as Bitmap;
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
                stack.Push(newbitmap);
                pictureBox2.Image = newbitmap.Clone() as Image;
            }

            //菜单
        }
        //自定义调节
        //调节亮
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (bitmap != null)
            {
                Bitmap newbitmap = bitmap.Clone() as Bitmap;
                Color pixel;
                int red, green, blue;
                numericUpDown2.Value = trackBarUpColor.Value;
                for (int x = 0; x < newbitmap.Width; x++)
                {
                    for (int y = 0; y < newbitmap.Height; y++)
                    {
                        pixel = newbitmap.GetPixel(x, y);
                        red = pixel.R;
                        blue = pixel.B;
                        green = pixel.G;
                        red += trackBarUpColor.Value;
                        green += trackBarUpColor.Value;
                        blue += trackBarUpColor.Value;
                        //溢出处理
                        red = red > 255 ? 255 : (red < 0 ? 0 : red);
                        blue = blue > 255 ? 255 : (blue < 0 ? 0 : blue);
                        green = green > 255 ? 255 : (green < 0 ? 0 : green);
                        newbitmap.SetPixel(x, y, Color.FromArgb(red, green, blue));
                    }
                }
                stack.Push(newbitmap);
                pictureBox2.Image = newbitmap.Clone() as Image;
            }
        }
        //调节暗
        private void trackBarDownColor_Scroll(object sender, EventArgs e)
        {
            if (bitmap != null)
            {
                Bitmap newbitmap = bitmap.Clone() as Bitmap;
                Color pixel;
                int red, green, blue;
                numericUpDown3.Value = trackBarDownColor.Value;
                for (int x = 0; x < newbitmap.Width; x++)
                {
                    for (int y = 0; y < newbitmap.Height; y++)
                    {
                        pixel = newbitmap.GetPixel(x, y);
                        red = pixel.R;
                        blue = pixel.B;
                        green = pixel.G;
                        red -= trackBarUpColor.Value;
                        green -= trackBarUpColor.Value;
                        blue -= trackBarUpColor.Value;
                        //溢出处理
                        red = red > 255 ? 255 : (red < 0 ? 0 : red);
                        blue = blue > 255 ? 255 : (blue < 0 ? 0 : blue);
                        green = green > 255 ? 255 : (green < 0 ? 0 : green);
                        newbitmap.SetPixel(x, y, Color.FromArgb(red, green, blue));
                    }
                }
                stack.Push(newbitmap);
                pictureBox2.Image = newbitmap.Clone() as Image;
            }
        }

        private void 薄码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bitmap != null)
            {
                flag = 0;
                Bitmap newbitmap = bitmap.Clone() as Bitmap;
                int RIDIO = newbitmap.Width / 100;//马赛克的尺度，默认为周围两个像素
                trackBarFunction.Visible = true;
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
                stack.Push(newbitmap);
                pictureBox2.Image = newbitmap.Clone() as Image;
            }//马赛克
        }

        private void 一般ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bitmap != null)
            {
                flag = 0;
                Bitmap newbitmap = bitmap.Clone() as Bitmap;
                //sw.Reset();
                //sw.Restart();
                int RIDIO = newbitmap.Width / 40;//马赛克的尺度
                trackBarFunction.Visible = true;
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
                stack.Push(newbitmap);
                pictureBox2.Image = newbitmap.Clone() as Image;
            }//马赛克
        }

        private void 究极马赛克ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bitmap != null)
            {
                flag = 0;
                Bitmap newbitmap = bitmap.Clone() as Bitmap;
                int RIDIO = newbitmap.Width / 5;//马赛克的尺度
                trackBarFunction.Visible = true;
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
                stack.Push(newbitmap);
                pictureBox2.Image = newbitmap.Clone() as Image;
            }//马赛克
        }

        private void 黑白ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (bitmap != null)
            {
                flag = 1;
                numericUpDown1.Value = trackBarFunction.Value;
                trackBarFunction.Visible = true;
                Bitmap newbitmap = bitmap.Clone() as Bitmap;
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
                stack.Push(newbitmap);
                pictureBox2.Image = newbitmap.Clone() as Image;
            }
        }

        private void 浮雕ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (bitmap != null)
            {
                flag = 2;
                Bitmap newbitmap = bitmap.Clone() as Bitmap;
                Color pixel;
                int red, blue, green;
                trackBarFunction.Visible = true;
                for (int x = 0; x < newbitmap.Width; x++)
                {
                    for (int y = 0; y < bitmap.Height; y++)
                    {
                        pixel = newbitmap.GetPixel(x, y);
                        red = (int)(255 - pixel.R);
                        blue = (int)(255 - pixel.B);
                        green = (int)(255 - pixel.G);
                        newbitmap.SetPixel(x, y, Color.FromArgb(red, green, blue));
                    }
                }
                stack.Push(newbitmap);
                pictureBox2.Image = newbitmap.Clone() as Image;
            }
        }

        private void 变暗ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bitmap != null)
            {
                Bitmap newbitmap = bitmap.Clone() as Bitmap;
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
                stack.Push(newbitmap);
                pictureBox2.Image = newbitmap.Clone() as Image;
            }
        }

        private void 柔化ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bitmap != null)
            {
                Bitmap newbitmap = bitmap.Clone() as Bitmap;
                Color pixel;
                int red, blue, green;
                int index;
                //高斯模板
                int[] Gauss = { 1, 2, 1, 2, 4, 2, 1, 2, 1 };
                for (int x = 1; x < newbitmap.Width - 1; x++)
                {
                    for (int y = 1; y < newbitmap.Height - 1; y++)
                    {
                        red = 0;
                        blue = 0;
                        green = 0;
                        index = 0;
                        for (int col = -1; col <= 1; col++)
                            for (int row = -1; row <= 1; row++)
                            {
                                pixel = newbitmap.GetPixel(x + row, y + col);
                                red += pixel.R * Gauss[index];
                                blue += pixel.B * Gauss[index];
                                green += pixel.G * Gauss[index];
                                index++;
                            }
                        red /= 16;
                        blue /= 16;
                        green /= 16;
                        //溢出处理
                        red = red > 255 ? 255 : (red < 0 ? 0 : red);
                        blue = blue > 255 ? 255 : (blue < 0 ? 0 : blue);
                        green = green > 255 ? 255 : (green < 0 ? 0 : green);
                        newbitmap.SetPixel(x - 1, y - 1, Color.FromArgb(red, green, blue));
                    }
                }
                stack.Push(newbitmap);
                pictureBox2.Image = newbitmap.Clone() as Image;
            }
        }

        private void 锐化ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bitmap != null)
            {
                Bitmap newbitmap = bitmap.Clone() as Bitmap;
                Color pixel;
                int red, blue, green;
                int index;
                //拉普拉斯模板
                int[] Laplacian = { -1, -1, -1, -1, 9, -1, -1, -1, -1 };
                for (int x = 1; x < newbitmap.Width - 1; x++)
                {
                    for (int y = 1; y < newbitmap.Height - 1; y++)
                    {
                        red = 0;
                        blue = 0;
                        green = 0;
                        index = 0;
                        for (int col = -1; col <= 1; col++)
                            for (int row = -1; row <= 1; row++)
                            {
                                pixel = newbitmap.GetPixel(x + row, y + col);
                                red += pixel.R * Laplacian[index];
                                blue += pixel.B * Laplacian[index];
                                green += pixel.G * Laplacian[index];
                                index++;
                            }
                        //溢出处理
                        red = red > 255 ? 255 : (red < 0 ? 0 : red);
                        blue = blue > 255 ? 255 : (blue < 0 ? 0 : blue);
                        green = green > 255 ? 255 : (green < 0 ? 0 : green);
                        newbitmap.SetPixel(x - 1, y - 1, Color.FromArgb(red, green, blue));
                    }
                }
                stack.Push(newbitmap);
                pictureBox2.Image = newbitmap.Clone() as Image;
            }
        }

        private void 雾化ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bitmap != null)
            {
                Bitmap newbitmap = bitmap.Clone() as Bitmap;
                Bitmap oldbitmap = (Bitmap)this.pictureBox1.Image;
                Color pixel;
                for (int x = 0; x < newbitmap.Width; x++)
                {
                    for (int y = 0; y < bitmap.Height; y++)
                    {
                        System.Random random = new Random();
                        int k = random.Next(100000);
                        //像素块大小
                        int dx = x + k % 19;
                        int dy = y + k % 19;
                        if (dx >= oldbitmap.Width)
                            dx = oldbitmap.Width - 1;
                        if (dy >= oldbitmap.Height)
                            dy = oldbitmap.Height - 1;
                        pixel = oldbitmap.GetPixel(dx, dy);
                        newbitmap.SetPixel(x, y, pixel);
                    }
                }
                pictureBox2.Image = newbitmap.Clone() as Image;
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (bitmap != null)
            {
                Bitmap newbitmap = bitmap.Clone() as Bitmap;
                int width = newbitmap.Width;
                int height = newbitmap.Height;
                int length = height * 3 * width;
                RGB = new byte[length];
                BitmapData data = newbitmap.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format32bppRgb);
                System.IntPtr scan0 = data.Scan0;
                int stride = data.Stride;  //一行的字节数
                System.Runtime.InteropServices.Marshal.Copy(scan0, RGB, 0, length);
                double gray = 0;
                for (int i = 0; i < RGB.Length; i += 3)
                {
                    gray = RGB[i + 2] * 0.3 + RGB[i + 1] * 0.6 + RGB[i] * 0.1;
                    RGB[i + 2] = RGB[i + 1] = RGB[i] = (byte)gray;
                }
                System.Runtime.InteropServices.Marshal.Copy(scan0, RGB, 0, length);
                    //unsafe
                    //{
                    //    byte* p = (byte*)scan0;
                    //    int offset = stride - width * 3;
                    //    double gray = 0;
                    /*    for (int y = 0; y < height; y++)
                        {
                            for (int x = 0; x < width ; x++)
                            {
                                //if ((int)p[2] > 125 || (int)p[1] > 125 || (int)p[0] > 125)
                                // {
                                //    p[2] = p[1] = p[0] = (byte)255;
                                // }
                                // else
                                // {
                                //     p[2] = p[1] = p[0] = (byte)0;
                                // }
                                gray = 0.3 * p[2] + 0.6 * p[1] + 0.1 * p[0];
                                p[2] = p[1] = p[0] = (byte)gray;
                                p += 3;
                            }
                            p += offset;
                        }
                    }*/
                pictureBox2.Image = newbitmap.Clone() as Image;
                newbitmap.UnlockBits(data);
            }
        }

        private void trackBarFunctionUp_Scroll(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                trackBarFunction.Visible = true;
                numericUpDown1.Value = trackBarFunction.Value;
                if (bitmap != null)
                {
                    int size = trackBarFunction.Value;
                    Bitmap newbitmap = bitmap.Clone() as Bitmap;
                    if (size <= 0)
                        size = 1;
                    int RIDIO = newbitmap.Width / size;//马赛克的尺度，默认为周围两个像素
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
                    stack.Push(newbitmap);
                    pictureBox2.Image = newbitmap.Clone() as Image;
                }//马赛克
            }
            if (flag == 1)
            {
                if (bitmap != null)
                {
                    trackBarFunction.Visible = true;
                    numericUpDown1.Value = trackBarFunction.Value;
                    int size = trackBarFunction.Value;
                    Bitmap newbitmap = bitmap.Clone() as Bitmap;
                    Color pixel;
                    int red, green, blue;
                    for (int x = 0; x < newbitmap.Width; x++)
                    {
                        for (int y = 0; y < newbitmap.Height; y++)
                        {
                            pixel = newbitmap.GetPixel(x, y);
                            if (pixel.R > size || pixel.G > size || pixel.B > size)
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
                    stack.Push(newbitmap);
                    pictureBox2.Image = newbitmap.Clone() as Image;
                }
            }
            if (flag == 2)
            {
                if (bitmap != null)
                {
                    trackBarFunction.Visible = true;
                    numericUpDown1.Value = trackBarFunction.Value;
                    Bitmap newbitmap = bitmap.Clone() as Bitmap;
                    Color pixel;
                    int red, blue, green;
                    int size = trackBarFunction.Value;
                    for (int x = 0; x < newbitmap.Width; x++)
                    {
                        for (int y = 0; y < bitmap.Height; y++)
                        {
                            pixel = newbitmap.GetPixel(x, y);
                            red = (int)(size - pixel.R);
                            blue = (int)(size - pixel.B);
                            green = (int)(size - pixel.G);
                            //溢出处理
                            red = red > 255 ? 255 : (red < 0 ? 0 : red);
                            blue = blue > 255 ? 255 : (blue < 0 ? 0 : blue);
                            green = green > 255 ? 255 : (green < 0 ? 0 : green);
                            newbitmap.SetPixel(x, y, Color.FromArgb(red, green, blue));
                        }
                    }
                    stack.Push(newbitmap);
                    pictureBox2.Image = newbitmap.Clone() as Image;
                }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 0)
                numericUpDown1.Value = 1;
            trackBarFunction.Value = (int)numericUpDown1.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            trackBarUpColor.Value = (int)numericUpDown2.Value;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            trackBarDownColor.Value = (int)numericUpDown3.Value;
        }

        private void Last_Click(object sender, EventArgs e)
        {
            if (stack.Count != 0)
                pictureBox2.Image = stack.Pop();
            else
                MessageBox.Show("没有上一步操作了。。");
        }


    }
}
