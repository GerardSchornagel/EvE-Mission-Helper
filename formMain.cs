using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Tesseract;

namespace EvE_Mission_Helper
{
    public partial class formMain : Form
    {
	    private Bitmap bmpRaw;
        private Bitmap bmpCrop;
        private Bitmap bmpInvert;
        private Bitmap bmpGrayscale;
        private Size sz = Screen.PrimaryScreen.Bounds.Size;

        public formMain()
        {
            InitializeComponent();
        }
		
		        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void btnScreenshot_Click(object sender, EventArgs e)
        {
            var hDesk = User32.GetDesktopWindow();
            var hSrc = User32.GetWindowDC(hDesk);
            var hDest = GDI32.CreateCompatibleDC(hSrc);
            var hBmp = GDI32.CreateCompatibleBitmap(hSrc, sz.Width, sz.Height);
            var hPrevBmp = GDI32.SelectObject(hDest, hBmp);
            GDI32.BitBlt(hDest, 0, 0, sz.Width, sz.Height, hSrc, 0, 0, GDI32.SRCCOPY);
            bmpRaw = Image.FromHbitmap(hBmp);

            GDI32.SelectObject(hDest, hPrevBmp);
            GDI32.DeleteObject(hBmp);
            GDI32.DeleteDC(hDest);
            User32.ReleaseDC(hDesk, hSrc);

            pctScreenshot.Image = bmpRaw;
        }

        private void udc_Change(object sender, EventArgs e)
        {
            int x = int.Parse(udcX.Text);
            int y = int.Parse(udcY.Text);
            int w = int.Parse(udcW.Text);
            int h = int.Parse(udcH.Text);
            bmpCrop = bmpRaw.Clone(new Rectangle(x, y, w, h), bmpRaw.PixelFormat);
            pctCrop.Image = bmpCrop;
        }

        private void btnOCR_Click(object sender, EventArgs e)
        {
            using (var engine = new TesseractEngine(@"./tessdata", "eng", EngineMode.Default))
            {
                byte[] pngBytes;
                using (var stream = new MemoryStream())
                {
                    bmpGrayscale.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                    pngBytes = stream.ToArray();
                }

                using (var img = Pix.LoadFromMemory(pngBytes))
                {
                    using (var page = engine.Process(img))
                    {
                        var text = page.GetText();
                        txtTrim.Text = "";
                        txtRaw.Text = "Mean confidence: " + page.GetMeanConfidence();

                        txtRaw.Text += "\r\n" + "Text (GetText):";
                        txtRaw.Text += "\r\n" + text;

                        using (var iter = page.GetIterator())
                        {
                            iter.Begin();

                            do
                            {
                                do
                                {
                                    do
                                    {
                                        do
                                        {
                                            txtTrim.Text += iter.GetText(PageIteratorLevel.Word) + " ";

                                            if (iter.IsAtFinalOf(PageIteratorLevel.TextLine, PageIteratorLevel.Word))
                                            {
                                                txtTrim.Text += "\r\n";
                                            }
                                        } while (iter.Next(PageIteratorLevel.TextLine, PageIteratorLevel.Word));
                                    } while (iter.Next(PageIteratorLevel.Para, PageIteratorLevel.TextLine));
                                } while (iter.Next(PageIteratorLevel.Block, PageIteratorLevel.Para));
                            } while (iter.Next(PageIteratorLevel.Block));
                        }
                    }
                }
            }
        }

        private void btnInvert_Click(object sender, EventArgs e)
        {
            using (Bitmap bmpSource = new Bitmap(bmpCrop))
            {
                bmpInvert = new Bitmap(bmpSource.Width, bmpSource.Height);

                for (int x = 0; x < bmpSource.Width; x++)
                {
                    for (int y = 0; y < bmpSource.Height; y++)
                    {

                        Color clrPixel = bmpSource.GetPixel(x, y);

                        clrPixel = Color.FromArgb(255 - clrPixel.R, 255 -
                           clrPixel.G, 255 - clrPixel.B);

                        bmpInvert.SetPixel(x, y, clrPixel);
                    }
                }
                pctInvert.Image = bmpInvert;
            }
        }

        private void btnGrayscale_Click(object sender, EventArgs e)
        {
            Color p;
            bmpGrayscale = bmpInvert;
            for (int y = 0; y < bmpGrayscale.Height; y++)
            {
                for (int x = 0; x < bmpGrayscale.Width; x++)
                {
                    //get pixel value
                    p = bmpGrayscale.GetPixel(x, y);

                    //extract pixel component ARGB
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    //find average
                    int avg = (r + g + b) / 3;

                    //set new pixel value
                    bmpGrayscale.SetPixel(x, y, Color.FromArgb(a, avg, avg, avg));
                }
            }

            pctGrayscale.Image = bmpGrayscale;
        }

        private void btnMission_Click(object sender, EventArgs e)
        {
            txtMission.Text = txtTrim.Text;
        }

        private void btnURIDirect_Click(object sender, EventArgs e)
        {
            string url;
            url = "https://wiki.eveuniversity.org/" + txtMission.Text + " (" + cmbFaction.Text + ") (" + cmbLevel.Text + ")";
            url = url.Replace("'", "%27");
            url = url.Replace(" ", "_");
            url = url.Replace("&", "^&");
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }

        private void btnURISearch_Click(object sender, EventArgs e)
        {
            //Pirate+Invasion
            string url;
            url = "https://wiki.eveuniversity.org/index.php?title=Special:Search&search=" + txtMission.Text;
            url = url.Replace(" ", "+");
            url = url.Replace("&", "^&");
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }
    }
}

/// <summary>
/// Helper class containing Gdi32 API functions
/// </summary>
public static class GDI32
{
    public const int SRCCOPY = 0x00CC0020; // BitBlt dwRop parameter
    [DllImport("gdi32.dll")]
    public static extern bool BitBlt(IntPtr hObject, int nXDest, int nYDest,
        int nWidth, int nHeight, IntPtr hObjectSource,
        int nXSrc, int nYSrc, int dwRop);
    [DllImport("gdi32.dll")]
    public static extern IntPtr CreateCompatibleBitmap(IntPtr hDC, int nWidth,
        int nHeight);
    [DllImport("gdi32.dll")]
    public static extern IntPtr CreateCompatibleDC(IntPtr hDC);
    [DllImport("gdi32.dll")]
    public static extern bool DeleteDC(IntPtr hDC);
    [DllImport("gdi32.dll")]
    public static extern bool DeleteObject(IntPtr hObject);
    [DllImport("gdi32.dll")]
    public static extern IntPtr SelectObject(IntPtr hDC, IntPtr hObject);
}

/// <summary>
/// Helper class containing User32 API functions
/// </summary>
public static class User32
{
    [DllImport("user32.dll")]
    public static extern IntPtr GetDesktopWindow();
    [DllImport("user32.dll")]
    public static extern IntPtr GetWindowDC(IntPtr hWnd);
    [DllImport("user32.dll")]
    public static extern IntPtr ReleaseDC(IntPtr hWnd, IntPtr hDC);
}