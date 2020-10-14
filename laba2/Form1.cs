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
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

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
        //добавить обработку исключений если не загружено изображение и исправить где-то тут утечку памяти, из-за которой при постоянном вращении потребление памяти возрастает до гигабайтов
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
            //btm.Dispose();
            //PictureBox_Picture.Image = RotateImageN(tmp, NoFocusTrackBar_Rotation.Value);
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
            for(int i = 0; i < 4; i++)
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
            double s = Math.Sin(angle*(Math.PI / 180.0));
            double c = Math.Cos(angle*(Math.PI / 180.0));
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
            // The original bitmap needs to be drawn onto a new bitmap which will probably be bigger 
            // because the corners of the original will move outside the original rectangle.
            // An easy way (OK slightly 'brute force') is to calculate the new bounding box is to calculate the positions of the 
            // corners after rotation and get the difference between the maximum and minimum x and y coordinates.
            float wOver2 = b.Width / 2.0f;
            float hOver2 = b.Height / 2.0f;
            float radians = -(float)(Angle / 180.0 * Math.PI);
            // Get the coordinates of the corners, taking the origin to be the centre of the bitmap.
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

            // Find the min and max x and y coordinates.
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

            // Get the size of the new bitmap.
            SizeF newSize = new SizeF(maxX - minX, maxY - minY);
            // ...and create it.
            Bitmap returnBitmap = new Bitmap((int)Math.Ceiling(newSize.Width), (int)Math.Ceiling(newSize.Height));
            // Now draw the old bitmap on it.
            using (Graphics g = Graphics.FromImage(returnBitmap))
            {
                g.TranslateTransform(newSize.Width / 2.0f, newSize.Height / 2.0f);
                g.RotateTransform(Angle);
                g.TranslateTransform(-b.Width / 2.0f, -b.Height / 2.0f);

                g.DrawImage(b, 0, 0);
            }

            return returnBitmap;
        }
        private Bitmap RotateImage(Bitmap rotateMe, float angle) //209
        {
            //First, re-center the image in a larger image that has a margin/frame
            //to compensate for the rotated image's increased size
            Point dimensions = BoundingBoxDimensions(rotateMe, angle);
            var bmp = new Bitmap(dimensions.X, dimensions.Y);

            using (Graphics g = Graphics.FromImage(bmp))
                g.DrawImageUnscaled(rotateMe, (dimensions.X-rotateMe.Width)/2, (dimensions.Y - rotateMe.Height) / 2, bmp.Width, bmp.Height);

            bmp.Save("moved.png");
            rotateMe = bmp;

            //Now, actually rotate the image
            Bitmap rotatedImage = new Bitmap(rotateMe.Width, rotateMe.Height);

            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                g.TranslateTransform(rotateMe.Width / 2, rotateMe.Height / 2);   //set the rotation point as the center into the matrix
                g.RotateTransform(angle);                                        //rotate
                g.TranslateTransform(-rotateMe.Width / 2, -rotateMe.Height / 2); //restore rotation point into the matrix
                g.DrawImage(ImageBuffer, new Point(0, 0));                          //draw the image on the new bitmap
            }
            //rotatedImage.Dispose();
            bmp.Dispose();
            rotatedImage.Save("rotated.png");
            return rotatedImage;
        }
        /*public static Image RotateImage(Image img, float rotationAngle)
        {
            //create an empty Bitmap image

            Bitmap bmp = new Bitmap(2000, 2000);
            bmp.SetResolution(img.HorizontalResolution, img.VerticalResolution);
            //turn the Bitmap into a Graphics object
            Graphics gfx = Graphics.FromImage(bmp);

            //now we set the rotation point to the center of our image
            gfx.TranslateTransform((float)bmp.Width / 2, (float)bmp.Height / 2);

            //now rotate the image
            gfx.RotateTransform(rotationAngle);

            gfx.TranslateTransform(-(float)bmp.Width / 2, -(float)bmp.Height / 2);

            //set the InterpolationMode to HighQualityBicubic so to ensure a high
            //quality image once it is transformed to the specified size
            gfx.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

            //now draw our new image onto the graphics object
            gfx.DrawImage(img, new Point(0, 0));

            //dispose of our Graphics object
            gfx.Dispose();

            //return the image
            return bmp;
        }*/
        private void NoFocusTrackBar_Red_Scroll(object sender, EventArgs e)
        {

        }

        private void NoFocusTrackBar_Green_Scroll(object sender, EventArgs e)
        {

        }

        private void NoFocusTrackBar_Blue_Scroll(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItem_OpenFile_Click(object sender, EventArgs e)
        {
            

            if (OpenFileDialog_Open.ShowDialog() == DialogResult.OK && OpenFileDialog_Open.FileName.Length > 0)
            {
                //pictureBox.Image = Image.FromFile(ofd.FileName);
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

        private void NoFocusTrackBar_Rotation_Leave(object sender, EventArgs e)
        {

        }

        private void Button_Apply_Click(object sender, EventArgs e)
        {
            //ImageBuffer.Dispose();
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
            Label_RedValue.Text ="100%";
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
            PictureBox_Picture.Image = ResizeImage(tmp, new Size(ImageBuffer.Width*NoFocusTrackBar_Width.Value/100, ImageBuffer.Height*NoFocusTrackBar_Height.Value/100));
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
                //pictureBox.Image = Image.FromFile(ofd.FileName);
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
                //IntPtr hCursor = LoadCursorFromFile("cur1046.cur");
                //Cursor cursor = new Cursor(hCursor);
                //Cursor = cursor;
                if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
                {
                    DrawingNodes.Add(e.Location);
                    using (Graphics grp = Graphics.FromImage(PictureBox_Picture.Image))
                    {
                        if (DrawingNodes.Count > 1)
                            grp.DrawLines(new Pen(CurrentColor, (float)NumericUpDown_PenWidth.Value), DrawingNodes.ToArray());
                    } 
                    // 4 - яркость, 
                    //originalImage = pictureBox.Image;
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
            matrix.Matrix40 = matrix.Matrix41 = matrix.Matrix42 = (1-c)/2;

            Bitmap tmp = new Bitmap(ImageBuffer);
            PictureBox_Picture.Image.Dispose();
            PictureBox_Picture.Image = TransformColor(tmp,matrix);
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
            //dispose g and?
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
            Label_BrightnessValue.Text = (NoFocusTrackBar_Brightness.Value+100).ToString() + "%";
        }

        private void NoFocusTrackBar_Saturation_Scroll(object sender, EventArgs e)
        {
            float rwgt = 0.3086f;
            float gwgt = 0.6094f;
            float bwgt = 0.0820f;
            float rs = NoFocusTrackBar_Red.Value/100f;
            float gs = NoFocusTrackBar_Green.Value/100f;
            float bs = NoFocusTrackBar_Blue.Value/100f;
            float s = rs + gs + bs;
            float olds = s;
            if (s > 1.0)
            { // tune this
                rs /= s;
                gs /= s;
                bs /= s;
                s = 1;
            }
            else olds = 1;
            ColorMatrix matrix = new ColorMatrix();
            matrix.Matrix00= ((float)(1.0 - s) * rwgt + rs)*olds;
            matrix.Matrix01 = ((float)(1.0 - s) * rwgt)*olds;
            matrix.Matrix02 = ((float)(1.0 - s) * rwgt)*olds;
            matrix.Matrix10 = ((float)(1.0 - s) * gwgt)*olds;
            matrix.Matrix11 = ((float)(1.0 - s) * gwgt + gs)*olds;
            matrix.Matrix12 = ((float)(1.0 - s) * gwgt)*olds;
            matrix.Matrix20 = ((float)(1.0 - s) * bwgt)*olds;
            matrix.Matrix21 = ((float)(1.0 - s) * bwgt)*olds;
            matrix.Matrix22 = ((float)(1.0 - s) * bwgt + bs)*olds;

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
