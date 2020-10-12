namespace laba2
{
    partial class Form_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ToolStripMenuItem_File = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_OpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_SaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_Menu = new System.Windows.Forms.MenuStrip();
            this.Panel_Tools = new System.Windows.Forms.Panel();
            this.Panel_Saturation = new System.Windows.Forms.Panel();
            this.Label_Saturation = new System.Windows.Forms.Label();
            this.Label_Red = new System.Windows.Forms.Label();
            this.Label_Blue = new System.Windows.Forms.Label();
            this.Label_Green = new System.Windows.Forms.Label();
            this.Label_Brightness = new System.Windows.Forms.Label();
            this.Label_Contrast = new System.Windows.Forms.Label();
            this.Button_Smaller = new System.Windows.Forms.Button();
            this.Button_Bigger = new System.Windows.Forms.Button();
            this.Button_Color = new System.Windows.Forms.Button();
            this.Button_Draw = new System.Windows.Forms.Button();
            this.TextBox_Rotation = new System.Windows.Forms.TextBox();
            this.Label_Rotation = new System.Windows.Forms.Label();
            this.ComboBox_Zoom = new System.Windows.Forms.ComboBox();
            this.Label_Zoom = new System.Windows.Forms.Label();
            this.ColorDialog_BrushColor = new System.Windows.Forms.ColorDialog();
            this.OpenFileDialog_Open = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog_Save = new System.Windows.Forms.SaveFileDialog();
            this.Panel_Picture = new System.Windows.Forms.Panel();
            this.PictureBox_Picture = new System.Windows.Forms.PictureBox();
            this.NoFocusTrackBar_Blue = new laba2.NoFocusTrackBar();
            this.NoFocusTrackBar_Red = new laba2.NoFocusTrackBar();
            this.NoFocusTrackBar_Green = new laba2.NoFocusTrackBar();
            this.NoFocusTrackBar_Brightness = new laba2.NoFocusTrackBar();
            this.NoFocusTrackBar_Rotation = new laba2.NoFocusTrackBar();
            this.NoFocusTrackBar_Contrast = new laba2.NoFocusTrackBar();
            this.MenuStrip_Menu.SuspendLayout();
            this.Panel_Tools.SuspendLayout();
            this.Panel_Saturation.SuspendLayout();
            this.Panel_Picture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoFocusTrackBar_Blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoFocusTrackBar_Red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoFocusTrackBar_Green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoFocusTrackBar_Brightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoFocusTrackBar_Rotation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoFocusTrackBar_Contrast)).BeginInit();
            this.SuspendLayout();
            // 
            // ToolStripMenuItem_File
            // 
            this.ToolStripMenuItem_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_OpenFile,
            this.ToolStripMenuItem_SaveFile});
            this.ToolStripMenuItem_File.Name = "ToolStripMenuItem_File";
            this.ToolStripMenuItem_File.Size = new System.Drawing.Size(46, 26);
            this.ToolStripMenuItem_File.Text = "File";
            // 
            // ToolStripMenuItem_OpenFile
            // 
            this.ToolStripMenuItem_OpenFile.Name = "ToolStripMenuItem_OpenFile";
            this.ToolStripMenuItem_OpenFile.Size = new System.Drawing.Size(153, 26);
            this.ToolStripMenuItem_OpenFile.Text = "Open file";
            this.ToolStripMenuItem_OpenFile.Click += new System.EventHandler(this.ToolStripMenuItem_OpenFile_Click);
            // 
            // ToolStripMenuItem_SaveFile
            // 
            this.ToolStripMenuItem_SaveFile.Name = "ToolStripMenuItem_SaveFile";
            this.ToolStripMenuItem_SaveFile.Size = new System.Drawing.Size(153, 26);
            this.ToolStripMenuItem_SaveFile.Text = "Save file";
            // 
            // MenuStrip_Menu
            // 
            this.MenuStrip_Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_File});
            this.MenuStrip_Menu.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip_Menu.Name = "MenuStrip_Menu";
            this.MenuStrip_Menu.Size = new System.Drawing.Size(1356, 30);
            this.MenuStrip_Menu.TabIndex = 25;
            this.MenuStrip_Menu.Text = "menuStrip1";
            // 
            // Panel_Tools
            // 
            this.Panel_Tools.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Tools.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Panel_Tools.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_Tools.Controls.Add(this.Panel_Saturation);
            this.Panel_Tools.Controls.Add(this.NoFocusTrackBar_Brightness);
            this.Panel_Tools.Controls.Add(this.NoFocusTrackBar_Rotation);
            this.Panel_Tools.Controls.Add(this.NoFocusTrackBar_Contrast);
            this.Panel_Tools.Controls.Add(this.Label_Brightness);
            this.Panel_Tools.Controls.Add(this.Label_Contrast);
            this.Panel_Tools.Controls.Add(this.Button_Smaller);
            this.Panel_Tools.Controls.Add(this.Button_Bigger);
            this.Panel_Tools.Controls.Add(this.Button_Color);
            this.Panel_Tools.Controls.Add(this.Button_Draw);
            this.Panel_Tools.Controls.Add(this.TextBox_Rotation);
            this.Panel_Tools.Controls.Add(this.Label_Rotation);
            this.Panel_Tools.Controls.Add(this.ComboBox_Zoom);
            this.Panel_Tools.Controls.Add(this.Label_Zoom);
            this.Panel_Tools.Location = new System.Drawing.Point(0, 32);
            this.Panel_Tools.Name = "Panel_Tools";
            this.Panel_Tools.Size = new System.Drawing.Size(1356, 139);
            this.Panel_Tools.TabIndex = 26;
            // 
            // Panel_Saturation
            // 
            this.Panel_Saturation.Controls.Add(this.NoFocusTrackBar_Blue);
            this.Panel_Saturation.Controls.Add(this.NoFocusTrackBar_Red);
            this.Panel_Saturation.Controls.Add(this.NoFocusTrackBar_Green);
            this.Panel_Saturation.Controls.Add(this.Label_Saturation);
            this.Panel_Saturation.Controls.Add(this.Label_Red);
            this.Panel_Saturation.Controls.Add(this.Label_Blue);
            this.Panel_Saturation.Controls.Add(this.Label_Green);
            this.Panel_Saturation.Location = new System.Drawing.Point(1014, 0);
            this.Panel_Saturation.Name = "Panel_Saturation";
            this.Panel_Saturation.Size = new System.Drawing.Size(341, 138);
            this.Panel_Saturation.TabIndex = 24;
            // 
            // Label_Saturation
            // 
            this.Label_Saturation.AutoSize = true;
            this.Label_Saturation.Location = new System.Drawing.Point(125, 6);
            this.Label_Saturation.Name = "Label_Saturation";
            this.Label_Saturation.Size = new System.Drawing.Size(73, 17);
            this.Label_Saturation.TabIndex = 15;
            this.Label_Saturation.Text = "Saturation";
            // 
            // Label_Red
            // 
            this.Label_Red.AutoSize = true;
            this.Label_Red.Location = new System.Drawing.Point(42, 29);
            this.Label_Red.Name = "Label_Red";
            this.Label_Red.Size = new System.Drawing.Size(34, 17);
            this.Label_Red.TabIndex = 16;
            this.Label_Red.Text = "Red";
            // 
            // Label_Blue
            // 
            this.Label_Blue.AutoSize = true;
            this.Label_Blue.Location = new System.Drawing.Point(249, 29);
            this.Label_Blue.Name = "Label_Blue";
            this.Label_Blue.Size = new System.Drawing.Size(36, 17);
            this.Label_Blue.TabIndex = 18;
            this.Label_Blue.Text = "Blue";
            // 
            // Label_Green
            // 
            this.Label_Green.AutoSize = true;
            this.Label_Green.Location = new System.Drawing.Point(139, 29);
            this.Label_Green.Name = "Label_Green";
            this.Label_Green.Size = new System.Drawing.Size(48, 17);
            this.Label_Green.TabIndex = 17;
            this.Label_Green.Text = "Green";
            // 
            // Label_Brightness
            // 
            this.Label_Brightness.AutoSize = true;
            this.Label_Brightness.Location = new System.Drawing.Point(853, 19);
            this.Label_Brightness.Name = "Label_Brightness";
            this.Label_Brightness.Size = new System.Drawing.Size(75, 17);
            this.Label_Brightness.TabIndex = 14;
            this.Label_Brightness.Text = "Brightness";
            // 
            // Label_Contrast
            // 
            this.Label_Contrast.AutoSize = true;
            this.Label_Contrast.Location = new System.Drawing.Point(708, 19);
            this.Label_Contrast.Name = "Label_Contrast";
            this.Label_Contrast.Size = new System.Drawing.Size(61, 17);
            this.Label_Contrast.TabIndex = 13;
            this.Label_Contrast.Text = "Contrast";
            // 
            // Button_Smaller
            // 
            this.Button_Smaller.Location = new System.Drawing.Point(73, 26);
            this.Button_Smaller.Name = "Button_Smaller";
            this.Button_Smaller.Size = new System.Drawing.Size(55, 45);
            this.Button_Smaller.TabIndex = 12;
            this.Button_Smaller.Text = "Size-";
            this.Button_Smaller.UseVisualStyleBackColor = true;
            // 
            // Button_Bigger
            // 
            this.Button_Bigger.Location = new System.Drawing.Point(11, 26);
            this.Button_Bigger.Name = "Button_Bigger";
            this.Button_Bigger.Size = new System.Drawing.Size(56, 46);
            this.Button_Bigger.TabIndex = 11;
            this.Button_Bigger.Text = "Size+";
            this.Button_Bigger.UseVisualStyleBackColor = true;
            // 
            // Button_Color
            // 
            this.Button_Color.Location = new System.Drawing.Point(330, 49);
            this.Button_Color.Name = "Button_Color";
            this.Button_Color.Size = new System.Drawing.Size(94, 23);
            this.Button_Color.TabIndex = 8;
            this.Button_Color.Text = "Select color";
            this.Button_Color.UseVisualStyleBackColor = true;
            // 
            // Button_Draw
            // 
            this.Button_Draw.Location = new System.Drawing.Point(330, 19);
            this.Button_Draw.Name = "Button_Draw";
            this.Button_Draw.Size = new System.Drawing.Size(94, 23);
            this.Button_Draw.TabIndex = 7;
            this.Button_Draw.Text = "change to brush image";
            this.Button_Draw.UseVisualStyleBackColor = true;
            // 
            // TextBox_Rotation
            // 
            this.TextBox_Rotation.Location = new System.Drawing.Point(178, 91);
            this.TextBox_Rotation.Name = "TextBox_Rotation";
            this.TextBox_Rotation.Size = new System.Drawing.Size(100, 22);
            this.TextBox_Rotation.TabIndex = 4;
            this.TextBox_Rotation.Text = "0";
            // 
            // Label_Rotation
            // 
            this.Label_Rotation.AutoSize = true;
            this.Label_Rotation.Location = new System.Drawing.Point(191, 0);
            this.Label_Rotation.Name = "Label_Rotation";
            this.Label_Rotation.Size = new System.Drawing.Size(81, 17);
            this.Label_Rotation.TabIndex = 2;
            this.Label_Rotation.Text = "Rotation (°)";
            // 
            // ComboBox_Zoom
            // 
            this.ComboBox_Zoom.FormattingEnabled = true;
            this.ComboBox_Zoom.Items.AddRange(new object[] {
            "25",
            "50",
            "75",
            "100",
            "125",
            "150"});
            this.ComboBox_Zoom.Location = new System.Drawing.Point(482, 48);
            this.ComboBox_Zoom.Name = "ComboBox_Zoom";
            this.ComboBox_Zoom.Size = new System.Drawing.Size(121, 24);
            this.ComboBox_Zoom.TabIndex = 1;
            this.ComboBox_Zoom.Text = "100";
            this.ComboBox_Zoom.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Zoom_SelectedIndexChanged);
            // 
            // Label_Zoom
            // 
            this.Label_Zoom.AutoSize = true;
            this.Label_Zoom.Location = new System.Drawing.Point(511, 19);
            this.Label_Zoom.Name = "Label_Zoom";
            this.Label_Zoom.Size = new System.Drawing.Size(70, 17);
            this.Label_Zoom.TabIndex = 0;
            this.Label_Zoom.Text = "Zoom (%)";
            // 
            // OpenFileDialog_Open
            // 
            this.OpenFileDialog_Open.Filter = "jpg (*.jpg)|*.jpg|bmp (*.bmp)|*.bmp|png (*.png)|*.png";
            // 
            // SaveFileDialog_Save
            // 
            this.SaveFileDialog_Save.Filter = "jpg (*.jpg)|*.jpg|bmp (*.bmp)|*.bmp|png (*.png)|*.png";
            // 
            // Panel_Picture
            // 
            this.Panel_Picture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Picture.AutoScroll = true;
            this.Panel_Picture.Controls.Add(this.PictureBox_Picture);
            this.Panel_Picture.Location = new System.Drawing.Point(0, 178);
            this.Panel_Picture.Name = "Panel_Picture";
            this.Panel_Picture.Size = new System.Drawing.Size(1356, 359);
            this.Panel_Picture.TabIndex = 27;
            // 
            // PictureBox_Picture
            // 
            this.PictureBox_Picture.Location = new System.Drawing.Point(0, -1);
            this.PictureBox_Picture.Name = "PictureBox_Picture";
            this.PictureBox_Picture.Size = new System.Drawing.Size(1356, 360);
            this.PictureBox_Picture.TabIndex = 0;
            this.PictureBox_Picture.TabStop = false;
            // 
            // NoFocusTrackBar_Blue
            // 
            this.NoFocusTrackBar_Blue.Location = new System.Drawing.Point(218, 49);
            this.NoFocusTrackBar_Blue.Name = "NoFocusTrackBar_Blue";
            this.NoFocusTrackBar_Blue.Size = new System.Drawing.Size(104, 56);
            this.NoFocusTrackBar_Blue.TabIndex = 23;
            this.NoFocusTrackBar_Blue.Scroll += new System.EventHandler(this.NoFocusTrackBar_Blue_Scroll);
            // 
            // NoFocusTrackBar_Red
            // 
            this.NoFocusTrackBar_Red.Location = new System.Drawing.Point(3, 49);
            this.NoFocusTrackBar_Red.Name = "NoFocusTrackBar_Red";
            this.NoFocusTrackBar_Red.Size = new System.Drawing.Size(104, 56);
            this.NoFocusTrackBar_Red.TabIndex = 21;
            this.NoFocusTrackBar_Red.Scroll += new System.EventHandler(this.NoFocusTrackBar_Red_Scroll);
            // 
            // NoFocusTrackBar_Green
            // 
            this.NoFocusTrackBar_Green.Location = new System.Drawing.Point(108, 49);
            this.NoFocusTrackBar_Green.Name = "NoFocusTrackBar_Green";
            this.NoFocusTrackBar_Green.Size = new System.Drawing.Size(104, 56);
            this.NoFocusTrackBar_Green.TabIndex = 22;
            this.NoFocusTrackBar_Green.Scroll += new System.EventHandler(this.NoFocusTrackBar_Green_Scroll);
            // 
            // NoFocusTrackBar_Brightness
            // 
            this.NoFocusTrackBar_Brightness.Location = new System.Drawing.Point(836, 49);
            this.NoFocusTrackBar_Brightness.Name = "NoFocusTrackBar_Brightness";
            this.NoFocusTrackBar_Brightness.Size = new System.Drawing.Size(104, 56);
            this.NoFocusTrackBar_Brightness.TabIndex = 20;
            // 
            // NoFocusTrackBar_Rotation
            // 
            this.NoFocusTrackBar_Rotation.Location = new System.Drawing.Point(178, 29);
            this.NoFocusTrackBar_Rotation.Maximum = 360;
            this.NoFocusTrackBar_Rotation.Name = "NoFocusTrackBar_Rotation";
            this.NoFocusTrackBar_Rotation.Size = new System.Drawing.Size(104, 56);
            this.NoFocusTrackBar_Rotation.TabIndex = 6;
            this.NoFocusTrackBar_Rotation.Scroll += new System.EventHandler(this.NoFocusTrackBar_Rotation_Scroll);
            // 
            // NoFocusTrackBar_Contrast
            // 
            this.NoFocusTrackBar_Contrast.Location = new System.Drawing.Point(677, 49);
            this.NoFocusTrackBar_Contrast.Name = "NoFocusTrackBar_Contrast";
            this.NoFocusTrackBar_Contrast.Size = new System.Drawing.Size(104, 56);
            this.NoFocusTrackBar_Contrast.TabIndex = 19;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 543);
            this.Controls.Add(this.Panel_Picture);
            this.Controls.Add(this.Panel_Tools);
            this.Controls.Add(this.MenuStrip_Menu);
            this.Name = "Form_Main";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.MenuStrip_Menu.ResumeLayout(false);
            this.MenuStrip_Menu.PerformLayout();
            this.Panel_Tools.ResumeLayout(false);
            this.Panel_Tools.PerformLayout();
            this.Panel_Saturation.ResumeLayout(false);
            this.Panel_Saturation.PerformLayout();
            this.Panel_Picture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoFocusTrackBar_Blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoFocusTrackBar_Red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoFocusTrackBar_Green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoFocusTrackBar_Brightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoFocusTrackBar_Rotation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoFocusTrackBar_Contrast)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_File;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_OpenFile;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_SaveFile;
        private System.Windows.Forms.MenuStrip MenuStrip_Menu;
        private System.Windows.Forms.Panel Panel_Tools;
        private System.Windows.Forms.TextBox TextBox_Rotation;
        private System.Windows.Forms.Label Label_Rotation;
        private NoFocusTrackBar NoFocusTrackBar_Rotation;
        private System.Windows.Forms.Panel Panel_Saturation;
        private NoFocusTrackBar NoFocusTrackBar_Blue;
        private NoFocusTrackBar NoFocusTrackBar_Red;
        private NoFocusTrackBar NoFocusTrackBar_Green;
        private System.Windows.Forms.Label Label_Red;
        private System.Windows.Forms.Label Label_Blue;
        private System.Windows.Forms.Label Label_Green;
        private NoFocusTrackBar NoFocusTrackBar_Brightness;
        private NoFocusTrackBar NoFocusTrackBar_Contrast;
        private System.Windows.Forms.Label Label_Saturation;
        private System.Windows.Forms.Label Label_Brightness;
        private System.Windows.Forms.Label Label_Contrast;
        private System.Windows.Forms.Button Button_Smaller;
        private System.Windows.Forms.Button Button_Bigger;
        private System.Windows.Forms.Button Button_Color;
        private System.Windows.Forms.Button Button_Draw;
        private System.Windows.Forms.ComboBox ComboBox_Zoom;
        private System.Windows.Forms.Label Label_Zoom;
        private System.Windows.Forms.ColorDialog ColorDialog_BrushColor;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog_Open;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog_Save;
        private System.Windows.Forms.Panel Panel_Picture;
        private System.Windows.Forms.PictureBox PictureBox_Picture;
    }
}

