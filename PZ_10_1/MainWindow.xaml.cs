using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PZ_10_1
{
    public partial class MainWindow : Window
    {
        public ColorRGB mcolor { get; set; }

        public Color clr { get; set; }
        public MainWindow()
        {

            InitializeComponent();
            mcolor = new ColorRGB();
            mcolor.red = 0;
            mcolor.green = 0;
            mcolor.blue = 0;
            this.lbl1.Background = new SolidColorBrush(Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Grigoriy.Strokes.Clear();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Grigoriy.EditingMode = InkCanvasEditingMode.None;
            string imgPath = @"C:\Desktop";
            MemoryStream ms = new MemoryStream();
            FileStream fs = new FileStream(imgPath, FileMode.Create);

            RenderTargetBitmap rtb = new RenderTargetBitmap((int)Grigoriy.Width,(int)Grigoriy .Height, 96, 96, PixelFormats.Default);
            rtb.Render(Grigoriy);

            GifBitmapEncoder gifEnc = new GifBitmapEncoder();
            gifEnc.Frames.Add(BitmapFrame.Create(rtb));
            gifEnc.Save(fs);
            fs.Close();
            this.Grigoriy.EditingMode = InkCanvasEditingMode.Ink;
            MessageBox.Show("Файл сохранен, " + imgPath);
        }
        public class ColorRGB
        {
            public byte red { get; set; }
            public byte green { get; set; }
            public byte blue { get; set; }
        }
        private void sld_Color_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var slider = sender as Slider;
            string crlName = slider.Name;
            double value = slider.Value;

            if (crlName.Equals("sld_RedColor"))
            {
                mcolor.red = Convert.ToByte(value);
            }
            if (crlName.Equals("sld_GreenColor"))
            {
                mcolor.green = Convert.ToByte(value);
            }
            if (crlName.Equals("sld_BlueColor"))
            {
                mcolor.blue = Convert.ToByte(value);
            }
            clr = Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue);
            this.lbl1.Background = new SolidColorBrush(Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue));
            this.Grigoriy.DefaultDrawingAttributes.Color = clr;
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            this.Grigoriy.EditingMode = InkCanvasEditingMode.Select;

        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            this.Grigoriy.EditingMode = InkCanvasEditingMode.None;
            this.Grigoriy.EditingMode = InkCanvasEditingMode.Ink;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            mcolor = new ColorRGB();
            mcolor.red = 255;
            mcolor.green = 154;
            mcolor.blue = 0;
            this.lbl1.Background = new SolidColorBrush(Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue));
            clr = Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue);

            this.Grigoriy.DefaultDrawingAttributes.Color = clr;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            mcolor = new ColorRGB();
            mcolor.red = 237;
            mcolor.green = 48;
            mcolor.blue = 0;
            this.lbl1.Background = new SolidColorBrush(Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue));
            clr = Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue);

            this.Grigoriy.DefaultDrawingAttributes.Color = clr;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            mcolor = new ColorRGB();
            mcolor.red = 238;
            mcolor.green = 0;
            mcolor.blue = 104;
            this.lbl1.Background = new SolidColorBrush(Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue));
            clr = Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue);

            this.Grigoriy.DefaultDrawingAttributes.Color = clr;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            mcolor = new ColorRGB();
            mcolor.red = 231;
            mcolor.green = 102;
            mcolor.blue = 0;
            this.lbl1.Background = new SolidColorBrush(Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue));
            clr = Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue);

            this.Grigoriy.DefaultDrawingAttributes.Color = clr;
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            mcolor = new ColorRGB();
            mcolor.red = 48;
            mcolor.green = 48;
            mcolor.blue = 255;
            this.lbl1.Background = new SolidColorBrush(Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue));
            clr = Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue);

            this.Grigoriy.DefaultDrawingAttributes.Color = clr;
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            mcolor = new ColorRGB();
            mcolor.red = 0;
            mcolor.green = 0;
            mcolor.blue = 0;
            this.lbl1.Background = new SolidColorBrush(Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue));
            clr = Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue);

            this.Grigoriy.DefaultDrawingAttributes.Color = clr;
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            mcolor = new ColorRGB();
            mcolor.red = 0;
            mcolor.green = 205;
            mcolor.blue = 255;
            this.lbl1.Background = new SolidColorBrush(Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue));
            clr = Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue);

            this.Grigoriy.DefaultDrawingAttributes.Color = clr;
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            mcolor = new ColorRGB();
            mcolor.red = 0;
            mcolor.green = 205;
            mcolor.blue = 0;
            this.lbl1.Background = new SolidColorBrush(Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue));
            clr = Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue);

            this.Grigoriy.DefaultDrawingAttributes.Color = clr;
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            mcolor = new ColorRGB();
            mcolor.red = 0;
            mcolor.green = 205;
            mcolor.blue = 150;
            this.lbl1.Background = new SolidColorBrush(Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue));
            clr = Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue);

            this.Grigoriy.DefaultDrawingAttributes.Color = clr;
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            mcolor = new ColorRGB();
            mcolor.red = 255;
            mcolor.green = 0;
            mcolor.blue = 255;
            this.lbl1.Background = new SolidColorBrush(Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue));
            clr = Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue);

            this.Grigoriy.DefaultDrawingAttributes.Color = clr;
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            mcolor = new ColorRGB();
            mcolor.red = 255;
            mcolor.green = 205;
            mcolor.blue = 255;
            this.lbl1.Background = new SolidColorBrush(Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue));
            clr = Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue);

            this.Grigoriy.DefaultDrawingAttributes.Color = clr;
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            mcolor = new ColorRGB();
            mcolor.red = 237;
            mcolor.green = 48;
            mcolor.blue = 157;
            this.lbl1.Background = new SolidColorBrush(Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue));
            clr = Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue);

            this.Grigoriy.DefaultDrawingAttributes.Color = clr;
        }
    }
}
