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

namespace laba2
{
    public partial class Form_Main : Form
    {
        Image ImageBuffer;
        public Form_Main()
        {
            InitializeComponent();
        }
        int scale = 100;
        private void ComboBox_Zoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox_Zoom.SelectedItem != null)
            {
                scale = int.Parse(ComboBox_Zoom.SelectedItem.ToString());
            }
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            ComboBox_Zoom.TabStop = false;
        }

        private void NoFocusTrackBar_Rotation_Scroll(object sender, EventArgs e)
        {
            TextBox_Rotation.Text = NoFocusTrackBar_Rotation.Value.ToString();
        }

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
