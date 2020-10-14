using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace laba2
{
    public partial class Form_Main : Form
    {
        Image ImageBuffer;
        Color CurrentColor = Color.Black;
        List<Point> DrawingNodes = new List<Point>();
        bool IsDrawing = false;
        public Form_Main()
        {
            InitializeComponent();
        }
        private void ComboBox_Zoom_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            MenuStrip_Menu.Items.Add(ToolStripMenuItem_File);
            ToolStripMenuItem_File.DropDownItems.Add(ToolStripMenuItem_OpenFile);
            ToolStripMenuItem_File.DropDownItems.Add(ToolStripMenuItem_SaveFile);
            ToolStripMenuItem_File.DropDownItems.Add(ToolStripMenuItem_SaveAs);

        }
        private void NoFocusTrackBar_Rotation_Scroll(object sender, EventArgs e)
        {
            Bitmap tmp = new Bitmap(ImageBuffer);
            if (NoFocusTrackBar_Rotation.Value == 360)
                NoFocusTrackBar_Rotation.Value = 0;
            if (NoFocusTrackBar_Rotation.Value == -1)
                NoFocusTrackBar_Rotation.Value = 359;
            Bitmap btm = RotateImageN(tmp, NoFocusTrackBar_Rotation.Value);
            PictureBox_Picture.Image.Dispose();
            PictureBox_Picture.Image = btm;
            PictureBox_Picture.Height = PictureBox_Picture.Image.Height;
            PictureBox_Picture.Width = PictureBox_Picture.Image.Width;
            tmp.Dispose();
            Label_RotationValue.Text = NoFocusTrackBar_Rotation.Value.ToString() + "°";
        }
        private Point BoundingBoxDimensions(Bitmap img, float angle)
        {
            double[] x = new double[4];
            x[0] = 0;
            x[1] = img.Width;
            x[2] = img.Width;
            x[3] = 0;
            double[] y = new double[4];
            y[0] = img.Height;
            y[1] = img.Height;
            y[2] = 0;
            y[3] = 0;
            double xc = img.Width / 2;
            double yc = img.Height / 2;
            for (int i = 0; i < 4; i++)
            {
                Point p = RotatePoint(xc, yc, angle, new Point((int)x[i], (int)y[i]));
                x[i] = p.X; y[i] = p.Y;
            }
            double min_x = x.Min();
            double max_x = x.Max();
            double min_y = y.Min();
            double max_y = y.Max();
            double height = max_y - min_y;
            double width = max_x - min_x;
            return new Point((int)Math.Ceiling(width), (int)Math.Ceiling(height));
        }
        Point RotatePoint(double cx, double cy, double angle, Point p)
        {
            double s = Math.Sin(angle * (Math.PI / 180.0));
            double c = Math.Cos(angle * (Math.PI / 180.0));
            p.X -= (int)cx;
            p.Y -= (int)cy;
            double xnew = p.X * c - p.Y * s;
            double ynew = p.X * s + p.Y * c;
            p.X = (int)(xnew + cx);
            p.Y = (int)(ynew + cy);
            return p;
        }
        Bitmap RotateImageN(Bitmap b, float Angle)
        {
            float wOver2 = b.Width / 2.0f;
            float hOver2 = b.Height / 2.0f;
            float radians = -(float)(Angle / 180.0 * Math.PI);
            PointF[] corners = new PointF[]{
                new PointF(-wOver2, -hOver2),
                new PointF(+wOver2, -hOver2),
                new PointF(+wOver2, +hOver2),
                new PointF(-wOver2, +hOver2)
            };
            for (int i = 0; i < 4; i++)
            {
                PointF p = corners[i];
                PointF newP = new PointF((float)(p.X * Math.Cos(radians) - p.Y * Math.Sin(radians)), (float)(p.X * Math.Sin(radians) + p.Y * Math.Cos(radians)));
                corners[i] = newP;
            }
            float minX = corners[0].X;
            float maxX = minX;
            float minY = corners[0].Y;
            float maxY = minY;
            for (int i = 1; i < 4; i++)
            {
                PointF p = corners[i];
                minX = Math.Min(minX, p.X);
                maxX = Math.Max(maxX, p.X);
                minY = Math.Min(minY, p.Y);
                maxY = Math.Max(maxY, p.Y);
            }
            SizeF newSize = new SizeF(maxX - minX, maxY - minY);
            Bitmap returnBitmap = new Bitmap((int)Math.Ceiling(newSize.Width), (int)Math.Ceiling(newSize.Height));
            using (Graphics g = Graphics.FromImage(returnBitmap))
            {
                g.TranslateTransform(newSize.Width / 2.0f, newSize.Height / 2.0f);
                g.RotateTransform(Angle);
                g.TranslateTransform(-b.Width / 2.0f, -b.Height / 2.0f);

                g.DrawImage(b, 0, 0);
            }

            return returnBitmap;
        }
        private void ToolStripMenuItem_OpenFile_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog_Open.ShowDialog() == DialogResult.OK && OpenFileDialog_Open.FileName.Length > 0)
            {
                using (FileStream fs = new FileStream(OpenFileDialog_Open.FileName, FileMode.Open, FileAccess.Read))
                {
                    ImageBuffer = Image.FromStream(fs);
                    PictureBox_Picture.Image = Image.FromStream(fs);
                }
                PictureBox_Picture.Height = PictureBox_Picture.Image.Height;
                PictureBox_Picture.Width = PictureBox_Picture.Image.Width;
                ActiveForm.Text = OpenFileDialog_Open.FileName + " - Image Editor";
                Panel_Tools.Enabled = true;
            }
        }

        private void ToolStripMenuItem_SaveFile_Click(object sender, EventArgs e)
        {
            PictureBox_Picture.Image.Save(OpenFileDialog_Open.FileName);
            ImageBuffer = (Image)PictureBox_Picture.Image.Clone();
            ResetControls();
        }

        private void Button_Apply_Click(object sender, EventArgs e)
        {
            ImageBuffer = (Image)PictureBox_Picture.Image.Clone();
            ResetControls();

        }
        void ResetControls()
        {
            NoFocusTrackBar_Rotation.Value = 0;
            NoFocusTrackBar_Height.Value = 100;
            NoFocusTrackBar_Width.Value = 100;
            NoFocusTrackBar_Contrast.Value = 100;
            NoFocusTrackBar_Brightness.Value = 0;
            NoFocusTrackBar_Red.Value = 100;
            NoFocusTrackBar_Green.Value = 100;
            NoFocusTrackBar_Blue.Value = 100;
            Label_RedValue.Text = "100%";
            Label_GreenValue.Text = "100%";
            Label_BlueValue.Text = "100%";
            Label_BrightnessValue.Text = "100%";
            Label_ContrastValue.Text = "100%";
            Label_WidthValue.Text = "100%";
            Label_HeightValue.Text = "100%";
            Label_RotationValue.Text = "0°";
            IsDrawing = false;
        }
        Bitmap ResizeImage(Bitmap source, Size NewSize)
        {
            Bitmap bm_source = new Bitmap(source);
            Bitmap bm_dest = new Bitmap(NewSize.Width, NewSize.Height,
                    PixelFormat.Format24bppRgb);
            using (Graphics gr_dest = Graphics.FromImage(bm_dest))
            {
                gr_dest.CompositingQuality = CompositingQuality.HighQuality;
                gr_dest.InterpolationMode = InterpolationMode.HighQualityBicubic;
                gr_dest.SmoothingMode = SmoothingMode.HighQuality;
                gr_dest.PixelOffsetMode = PixelOffsetMode.HighQuality;
                gr_dest.DrawImage(bm_source, 0, 0, bm_dest.Width, bm_dest.Height);
            }
            bm_source.Dispose();
            return bm_dest;
        }
        private void NoFocusTrackBar_Size_Scroll(object sender, EventArgs e)
        {
            Bitmap tmp = new Bitmap(ImageBuffer);
            PictureBox_Picture.Image.Dispose();
            PictureBox_Picture.Image = ResizeImage(tmp, new Size(ImageBuffer.Width * NoFocusTrackBar_Width.Value / 100, ImageBuffer.Height * NoFocusTrackBar_Height.Value / 100));
            tmp.Dispose();
            PictureBox_Picture.Height = PictureBox_Picture.Image.Height;
            PictureBox_Picture.Width = PictureBox_Picture.Image.Width;
            Label_WidthValue.Text = NoFocusTrackBar_Width.Value.ToString() + "%";
            Label_HeightValue.Text = NoFocusTrackBar_Height.Value.ToString() + "%";
        }

        private void ToolStripMenuItem_SaveAs_Click(object sender, EventArgs e)
        {
            if (SaveFileDialog_Save.ShowDialog() == DialogResult.OK && SaveFileDialog_Save.FileName.Length > 0)
            {
                PictureBox_Picture.Image.Save(SaveFileDialog_Save.FileName);
            }
            OpenFileDialog_Open.FileName = SaveFileDialog_Save.FileName;
            ImageBuffer = (Image)PictureBox_Picture.Image.Clone();
            ActiveForm.Text = OpenFileDialog_Open.FileName + " - Image Editor";
            ResetControls();
        }

        private void PictureBox_Picture_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsDrawing)
            {
                if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
                {
                    DrawingNodes.Add(e.Location);
                    using (Graphics grp = Graphics.FromImage(PictureBox_Picture.Image))
                    {
                        if (DrawingNodes.Count > 1)
                            grp.DrawLines(new Pen(CurrentColor, (float)NumericUpDown_PenWidth.Value), DrawingNodes.ToArray());
                    }
                    PictureBox_Picture.Refresh();
                    PictureBox_Picture.Invalidate();
                }
            }
        }

        private void PictureBox_Picture_MouseDown(object sender, MouseEventArgs e)
        {
            if (IsDrawing && (e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                DrawingNodes.Add(e.Location);
            }
        }

        private void PictureBox_Picture_MouseUp(object sender, MouseEventArgs e)
        {
            if (IsDrawing)
            {
                DrawingNodes.Clear();
            }
        }


        private void Button_Color_Click(object sender, EventArgs e)
        {
            if (ColorDialog_BrushColor.ShowDialog() == DialogResult.OK)
            {
                CurrentColor = ColorDialog_BrushColor.Color;
                Panel_ColorDisplay.BackColor = CurrentColor;
            }
        }

        private void NoFocusTrackBar_Contrast_Scroll(object sender, EventArgs e)
        {
            ColorMatrix matrix = new ColorMatrix();
            float c = NoFocusTrackBar_Contrast.Value / 100f;
            matrix.Matrix00 = matrix.Matrix11 = matrix.Matrix22 = c;
            matrix.Matrix40 = matrix.Matrix41 = matrix.Matrix42 = (1 - c) / 2;

            Bitmap tmp = new Bitmap(ImageBuffer);
            PictureBox_Picture.Image.Dispose();
            PictureBox_Picture.Image = TransformColor(tmp, matrix);
            PictureBox_Picture.Height = PictureBox_Picture.Image.Height;
            PictureBox_Picture.Width = PictureBox_Picture.Image.Width;
            Label_ContrastValue.Text = NoFocusTrackBar_Contrast.Value.ToString() + "%";
        }
        Bitmap TransformColor(Bitmap source, ColorMatrix matrix)
        {
            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            Graphics g = Graphics.FromImage(source);
            g.DrawImage(source, new Rectangle(0, 0, source.Width, source.Height), 0, 0,
                source.Width, source.Height, GraphicsUnit.Pixel, imageAttributes);
            g.Dispose();
            imageAttributes.Dispose();
            return source;
        }

        private void NoFocusTrackBar_Brightness_Scroll(object sender, EventArgs e)
        {
            ColorMatrix matrix = new ColorMatrix();
            float b = NoFocusTrackBar_Brightness.Value / 100f;
            matrix.Matrix40 = matrix.Matrix41 = matrix.Matrix42 = b;

            Bitmap tmp = new Bitmap(ImageBuffer);
            PictureBox_Picture.Image.Dispose();
            PictureBox_Picture.Image = TransformColor(tmp, matrix);
            PictureBox_Picture.Height = PictureBox_Picture.Image.Height;
            PictureBox_Picture.Width = PictureBox_Picture.Image.Width;
            Label_BrightnessValue.Text = (NoFocusTrackBar_Brightness.Value + 100).ToString() + "%";
        }
        private void NoFocusTrackBar_Saturation_Scroll(object sender, EventArgs e)
        {
            float rwgt = 0.3086f;
            float gwgt = 0.6094f;
            float bwgt = 0.0820f;
            float rs = NoFocusTrackBar_Red.Value / 100f;
            float gs = NoFocusTrackBar_Green.Value / 100f;
            float bs = NoFocusTrackBar_Blue.Value / 100f;
            float s = rs + gs + bs;
            float olds = s;
            if (s > 1.0)
            {
                rs /= s;
                gs /= s;
                bs /= s;
                s = 1;
            }
            else olds = 1;
            ColorMatrix matrix = new ColorMatrix();
            matrix.Matrix00 = ((float)(1.0 - s) * rwgt + rs) * olds;
            matrix.Matrix01 = ((float)(1.0 - s) * rwgt) * olds;
            matrix.Matrix02 = ((float)(1.0 - s) * rwgt) * olds;
            matrix.Matrix10 = ((float)(1.0 - s) * gwgt) * olds;
            matrix.Matrix11 = ((float)(1.0 - s) * gwgt + gs) * olds;
            matrix.Matrix12 = ((float)(1.0 - s) * gwgt) * olds;
            matrix.Matrix20 = ((float)(1.0 - s) * bwgt) * olds;
            matrix.Matrix21 = ((float)(1.0 - s) * bwgt) * olds;
            matrix.Matrix22 = ((float)(1.0 - s) * bwgt + bs) * olds;

            Bitmap tmp = new Bitmap(ImageBuffer);
            PictureBox_Picture.Image.Dispose();
            PictureBox_Picture.Image = TransformColor(tmp, matrix);
            PictureBox_Picture.Height = PictureBox_Picture.Image.Height;
            PictureBox_Picture.Width = PictureBox_Picture.Image.Width;
            Label_RedValue.Text = NoFocusTrackBar_Red.Value.ToString() + "%";
            Label_GreenValue.Text = NoFocusTrackBar_Green.Value.ToString() + "%";
            Label_BlueValue.Text = NoFocusTrackBar_Blue.Value.ToString() + "%";
        }

        private void Panel_Brush_Click(object sender, EventArgs e)
        {
            IsDrawing = !IsDrawing;
        }

        private void Panel_Color_Click(object sender, EventArgs e)
        {
            if (ColorDialog_BrushColor.ShowDialog() == DialogResult.OK)
            {
                CurrentColor = ColorDialog_BrushColor.Color;
                Panel_ColorDisplay.BackColor = CurrentColor;
            }
        }
    }
    internal class NoFocusTrackBar : System.Windows.Forms.TrackBar
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public extern static int SendMessage(IntPtr hWnd, uint msg, int wParam, int lParam);

        private static int MakeParam(int loWord, int hiWord)
        {
            return (hiWord << 16) | (loWord & 0xffff);
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            SendMessage(this.Handle, 0x0128, MakeParam(1, 0x1), 0);
        }
    }
}
