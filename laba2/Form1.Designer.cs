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
            this.Label_Height = new System.Windows.Forms.Label();
            this.Label_Width = new System.Windows.Forms.Label();
            this.Panel_Saturation = new System.Windows.Forms.Panel();
            this.Label_Saturation = new System.Windows.Forms.Label();
            this.Label_Red = new System.Windows.Forms.Label();
            this.Label_Blue = new System.Windows.Forms.Label();
            this.Label_Green = new System.Windows.Forms.Label();
            this.Label_Brightness = new System.Windows.Forms.Label();
            this.Label_Contrast = new System.Windows.Forms.Label();
            this.Button_Color = new System.Windows.Forms.Button();
            this.Button_Draw = new System.Windows.Forms.Button();
            this.Label_Rotation = new System.Windows.Forms.Label();
            this.Label_Zoom = new System.Windows.Forms.Label();
            this.ColorDialog_BrushColor = new System.Windows.Forms.ColorDialog();
            this.OpenFileDialog_Open = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog_Save = new System.Windows.Forms.SaveFileDialog();
            this.Panel_Picture = new System.Windows.Forms.Panel();
            this.PictureBox_Picture = new System.Windows.Forms.PictureBox();
            this.Button_Apply = new System.Windows.Forms.Button();
            this.ToolStripMenuItem_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.NoFocusTrackBar_Height = new laba2.NoFocusTrackBar();
            this.NoFocusTrackBar_Width = new laba2.NoFocusTrackBar();
            this.NoFocusTrackBar_Blue = new laba2.NoFocusTrackBar();
            this.NoFocusTrackBar_Red = new laba2.NoFocusTrackBar();
            this.NoFocusTrackBar_Green = new laba2.NoFocusTrackBar();
            this.NoFocusTrackBar_Brightness = new laba2.NoFocusTrackBar();
            this.NoFocusTrackBar_Rotation = new laba2.NoFocusTrackBar();
            this.NoFocusTrackBar_Contrast = new laba2.NoFocusTrackBar();
            this.NumericUpDown_PenWidth = new System.Windows.Forms.NumericUpDown();
            this.Label_Pen = new System.Windows.Forms.Label();
            this.Panel_ColorDisplay = new System.Windows.Forms.Panel();
            this.Label_RotationValue = new System.Windows.Forms.Label();
            this.Label_WidthValue = new System.Windows.Forms.Label();
            this.Label_HeightValue = new System.Windows.Forms.Label();
            this.Label_ContrastValue = new System.Windows.Forms.Label();
            this.Label_BrightnessValue = new System.Windows.Forms.Label();
            this.Label_RedValue = new System.Windows.Forms.Label();
            this.Label_GreenValue = new System.Windows.Forms.Label();
            this.Label_BlueValue = new System.Windows.Forms.Label();
            this.MenuStrip_Menu.SuspendLayout();
            this.Panel_Tools.SuspendLayout();
            this.Panel_Saturation.SuspendLayout();
            this.Panel_Picture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoFocusTrackBar_Height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoFocusTrackBar_Width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoFocusTrackBar_Blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoFocusTrackBar_Red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoFocusTrackBar_Green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoFocusTrackBar_Brightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoFocusTrackBar_Rotation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoFocusTrackBar_Contrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_PenWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // ToolStripMenuItem_File
            // 
            this.ToolStripMenuItem_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_OpenFile,
            this.ToolStripMenuItem_SaveFile,
            this.ToolStripMenuItem_SaveAs});
            this.ToolStripMenuItem_File.Name = "ToolStripMenuItem_File";
            this.ToolStripMenuItem_File.Size = new System.Drawing.Size(46, 24);
            this.ToolStripMenuItem_File.Text = "File";
            // 
            // ToolStripMenuItem_OpenFile
            // 
            this.ToolStripMenuItem_OpenFile.Name = "ToolStripMenuItem_OpenFile";
            this.ToolStripMenuItem_OpenFile.Size = new System.Drawing.Size(224, 26);
            this.ToolStripMenuItem_OpenFile.Text = "Open file";
            this.ToolStripMenuItem_OpenFile.Click += new System.EventHandler(this.ToolStripMenuItem_OpenFile_Click);
            // 
            // ToolStripMenuItem_SaveFile
            // 
            this.ToolStripMenuItem_SaveFile.Name = "ToolStripMenuItem_SaveFile";
            this.ToolStripMenuItem_SaveFile.Size = new System.Drawing.Size(224, 26);
            this.ToolStripMenuItem_SaveFile.Text = "Save file";
            this.ToolStripMenuItem_SaveFile.Click += new System.EventHandler(this.ToolStripMenuItem_SaveFile_Click);
            // 
            // MenuStrip_Menu
            // 
            this.MenuStrip_Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_File});
            this.MenuStrip_Menu.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip_Menu.Name = "MenuStrip_Menu";
            this.MenuStrip_Menu.Size = new System.Drawing.Size(1356, 28);
            this.MenuStrip_Menu.TabIndex = 25;
            this.MenuStrip_Menu.Text = "menuStrip1";
            // 
            // Panel_Tools
            // 
            this.Panel_Tools.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Tools.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Panel_Tools.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_Tools.Controls.Add(this.Label_BrightnessValue);
            this.Panel_Tools.Controls.Add(this.Label_ContrastValue);
            this.Panel_Tools.Controls.Add(this.Label_HeightValue);
            this.Panel_Tools.Controls.Add(this.Label_WidthValue);
            this.Panel_Tools.Controls.Add(this.Label_RotationValue);
            this.Panel_Tools.Controls.Add(this.Panel_ColorDisplay);
            this.Panel_Tools.Controls.Add(this.Label_Pen);
            this.Panel_Tools.Controls.Add(this.NumericUpDown_PenWidth);
            this.Panel_Tools.Controls.Add(this.Button_Apply);
            this.Panel_Tools.Controls.Add(this.Label_Height);
            this.Panel_Tools.Controls.Add(this.Label_Width);
            this.Panel_Tools.Controls.Add(this.NoFocusTrackBar_Height);
            this.Panel_Tools.Controls.Add(this.NoFocusTrackBar_Width);
            this.Panel_Tools.Controls.Add(this.Panel_Saturation);
            this.Panel_Tools.Controls.Add(this.NoFocusTrackBar_Brightness);
            this.Panel_Tools.Controls.Add(this.NoFocusTrackBar_Rotation);
            this.Panel_Tools.Controls.Add(this.NoFocusTrackBar_Contrast);
            this.Panel_Tools.Controls.Add(this.Label_Brightness);
            this.Panel_Tools.Controls.Add(this.Label_Contrast);
            this.Panel_Tools.Controls.Add(this.Button_Color);
            this.Panel_Tools.Controls.Add(this.Button_Draw);
            this.Panel_Tools.Controls.Add(this.Label_Rotation);
            this.Panel_Tools.Controls.Add(this.Label_Zoom);
            this.Panel_Tools.Enabled = false;
            this.Panel_Tools.Location = new System.Drawing.Point(0, 32);
            this.Panel_Tools.Name = "Panel_Tools";
            this.Panel_Tools.Size = new System.Drawing.Size(1356, 139);
            this.Panel_Tools.TabIndex = 26;
            // 
            // Label_Height
            // 
            this.Label_Height.AutoSize = true;
            this.Label_Height.Location = new System.Drawing.Point(629, 29);
            this.Label_Height.Name = "Label_Height";
            this.Label_Height.Size = new System.Drawing.Size(49, 17);
            this.Label_Height.TabIndex = 28;
            this.Label_Height.Text = "Height";
            // 
            // Label_Width
            // 
            this.Label_Width.AutoSize = true;
            this.Label_Width.Location = new System.Drawing.Point(487, 29);
            this.Label_Width.Name = "Label_Width";
            this.Label_Width.Size = new System.Drawing.Size(44, 17);
            this.Label_Width.TabIndex = 27;
            this.Label_Width.Text = "Width";
            // 
            // Panel_Saturation
            // 
            this.Panel_Saturation.Controls.Add(this.Label_BlueValue);
            this.Panel_Saturation.Controls.Add(this.Label_GreenValue);
            this.Panel_Saturation.Controls.Add(this.Label_RedValue);
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
            this.Label_Brightness.Location = new System.Drawing.Point(924, 19);
            this.Label_Brightness.Name = "Label_Brightness";
            this.Label_Brightness.Size = new System.Drawing.Size(75, 17);
            this.Label_Brightness.TabIndex = 14;
            this.Label_Brightness.Text = "Brightness";
            // 
            // Label_Contrast
            // 
            this.Label_Contrast.AutoSize = true;
            this.Label_Contrast.Location = new System.Drawing.Point(772, 19);
            this.Label_Contrast.Name = "Label_Contrast";
            this.Label_Contrast.Size = new System.Drawing.Size(61, 17);
            this.Label_Contrast.TabIndex = 13;
            this.Label_Contrast.Text = "Contrast";
            // 
            // Button_Color
            // 
            this.Button_Color.Location = new System.Drawing.Point(196, 49);
            this.Button_Color.Name = "Button_Color";
            this.Button_Color.Size = new System.Drawing.Size(94, 23);
            this.Button_Color.TabIndex = 8;
            this.Button_Color.Text = "Select color";
            this.Button_Color.UseVisualStyleBackColor = true;
            this.Button_Color.Click += new System.EventHandler(this.Button_Color_Click);
            // 
            // Button_Draw
            // 
            this.Button_Draw.Location = new System.Drawing.Point(196, 16);
            this.Button_Draw.Name = "Button_Draw";
            this.Button_Draw.Size = new System.Drawing.Size(94, 23);
            this.Button_Draw.TabIndex = 7;
            this.Button_Draw.Text = "change to brush image";
            this.Button_Draw.UseVisualStyleBackColor = true;
            this.Button_Draw.Click += new System.EventHandler(this.Button_Draw_Click);
            // 
            // Label_Rotation
            // 
            this.Label_Rotation.AutoSize = true;
            this.Label_Rotation.Location = new System.Drawing.Point(343, 12);
            this.Label_Rotation.Name = "Label_Rotation";
            this.Label_Rotation.Size = new System.Drawing.Size(81, 17);
            this.Label_Rotation.TabIndex = 2;
            this.Label_Rotation.Text = "Rotation (°)";
            // 
            // Label_Zoom
            // 
            this.Label_Zoom.AutoSize = true;
            this.Label_Zoom.Location = new System.Drawing.Point(556, 6);
            this.Label_Zoom.Name = "Label_Zoom";
            this.Label_Zoom.Size = new System.Drawing.Size(51, 17);
            this.Label_Zoom.TabIndex = 0;
            this.Label_Zoom.Text = "Resize";
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
            this.Panel_Picture.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Panel_Picture.Controls.Add(this.PictureBox_Picture);
            this.Panel_Picture.Location = new System.Drawing.Point(0, 178);
            this.Panel_Picture.Name = "Panel_Picture";
            this.Panel_Picture.Size = new System.Drawing.Size(1356, 359);
            this.Panel_Picture.TabIndex = 27;
            // 
            // PictureBox_Picture
            // 
            this.PictureBox_Picture.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PictureBox_Picture.Location = new System.Drawing.Point(0, -1);
            this.PictureBox_Picture.Name = "PictureBox_Picture";
            this.PictureBox_Picture.Size = new System.Drawing.Size(400, 360);
            this.PictureBox_Picture.TabIndex = 0;
            this.PictureBox_Picture.TabStop = false;
            this.PictureBox_Picture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_Picture_MouseDown);
            this.PictureBox_Picture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox_Picture_MouseMove);
            this.PictureBox_Picture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox_Picture_MouseUp);
            // 
            // Button_Apply
            // 
            this.Button_Apply.Location = new System.Drawing.Point(11, 28);
            this.Button_Apply.Name = "Button_Apply";
            this.Button_Apply.Size = new System.Drawing.Size(148, 44);
            this.Button_Apply.TabIndex = 29;
            this.Button_Apply.Text = "Apply changes";
            this.Button_Apply.UseVisualStyleBackColor = true;
            this.Button_Apply.Click += new System.EventHandler(this.Button_Apply_Click);
            // 
            // ToolStripMenuItem_SaveAs
            // 
            this.ToolStripMenuItem_SaveAs.Name = "ToolStripMenuItem_SaveAs";
            this.ToolStripMenuItem_SaveAs.Size = new System.Drawing.Size(224, 26);
            this.ToolStripMenuItem_SaveAs.Text = "Save as...";
            this.ToolStripMenuItem_SaveAs.Click += new System.EventHandler(this.ToolStripMenuItem_SaveAs_Click);
            // 
            // NoFocusTrackBar_Height
            // 
            this.NoFocusTrackBar_Height.Location = new System.Drawing.Point(599, 49);
            this.NoFocusTrackBar_Height.Maximum = 200;
            this.NoFocusTrackBar_Height.Minimum = 1;
            this.NoFocusTrackBar_Height.Name = "NoFocusTrackBar_Height";
            this.NoFocusTrackBar_Height.Size = new System.Drawing.Size(104, 56);
            this.NoFocusTrackBar_Height.TabIndex = 26;
            this.NoFocusTrackBar_Height.Value = 100;
            this.NoFocusTrackBar_Height.Scroll += new System.EventHandler(this.NoFocusTrackBar_Size_Scroll);
            // 
            // NoFocusTrackBar_Width
            // 
            this.NoFocusTrackBar_Width.Location = new System.Drawing.Point(456, 49);
            this.NoFocusTrackBar_Width.Maximum = 200;
            this.NoFocusTrackBar_Width.Minimum = 1;
            this.NoFocusTrackBar_Width.Name = "NoFocusTrackBar_Width";
            this.NoFocusTrackBar_Width.Size = new System.Drawing.Size(104, 56);
            this.NoFocusTrackBar_Width.TabIndex = 25;
            this.NoFocusTrackBar_Width.Value = 100;
            this.NoFocusTrackBar_Width.Scroll += new System.EventHandler(this.NoFocusTrackBar_Size_Scroll);
            // 
            // NoFocusTrackBar_Blue
            // 
            this.NoFocusTrackBar_Blue.Location = new System.Drawing.Point(218, 49);
            this.NoFocusTrackBar_Blue.Maximum = 200;
            this.NoFocusTrackBar_Blue.Name = "NoFocusTrackBar_Blue";
            this.NoFocusTrackBar_Blue.Size = new System.Drawing.Size(104, 56);
            this.NoFocusTrackBar_Blue.TabIndex = 23;
            this.NoFocusTrackBar_Blue.Value = 100;
            this.NoFocusTrackBar_Blue.Scroll += new System.EventHandler(this.NoFocusTrackBar_Saturation_Scroll);
            // 
            // NoFocusTrackBar_Red
            // 
            this.NoFocusTrackBar_Red.Location = new System.Drawing.Point(3, 49);
            this.NoFocusTrackBar_Red.Maximum = 200;
            this.NoFocusTrackBar_Red.Name = "NoFocusTrackBar_Red";
            this.NoFocusTrackBar_Red.Size = new System.Drawing.Size(104, 56);
            this.NoFocusTrackBar_Red.TabIndex = 21;
            this.NoFocusTrackBar_Red.Value = 100;
            this.NoFocusTrackBar_Red.Scroll += new System.EventHandler(this.NoFocusTrackBar_Saturation_Scroll);
            // 
            // NoFocusTrackBar_Green
            // 
            this.NoFocusTrackBar_Green.Location = new System.Drawing.Point(108, 49);
            this.NoFocusTrackBar_Green.Maximum = 200;
            this.NoFocusTrackBar_Green.Name = "NoFocusTrackBar_Green";
            this.NoFocusTrackBar_Green.Size = new System.Drawing.Size(104, 56);
            this.NoFocusTrackBar_Green.TabIndex = 22;
            this.NoFocusTrackBar_Green.Value = 100;
            this.NoFocusTrackBar_Green.Scroll += new System.EventHandler(this.NoFocusTrackBar_Saturation_Scroll);
            // 
            // NoFocusTrackBar_Brightness
            // 
            this.NoFocusTrackBar_Brightness.Location = new System.Drawing.Point(904, 49);
            this.NoFocusTrackBar_Brightness.Maximum = 100;
            this.NoFocusTrackBar_Brightness.Minimum = -100;
            this.NoFocusTrackBar_Brightness.Name = "NoFocusTrackBar_Brightness";
            this.NoFocusTrackBar_Brightness.Size = new System.Drawing.Size(104, 56);
            this.NoFocusTrackBar_Brightness.TabIndex = 20;
            this.NoFocusTrackBar_Brightness.Scroll += new System.EventHandler(this.NoFocusTrackBar_Brightness_Scroll);
            // 
            // NoFocusTrackBar_Rotation
            // 
            this.NoFocusTrackBar_Rotation.Location = new System.Drawing.Point(332, 49);
            this.NoFocusTrackBar_Rotation.Maximum = 361;
            this.NoFocusTrackBar_Rotation.Minimum = -1;
            this.NoFocusTrackBar_Rotation.Name = "NoFocusTrackBar_Rotation";
            this.NoFocusTrackBar_Rotation.Size = new System.Drawing.Size(104, 56);
            this.NoFocusTrackBar_Rotation.TabIndex = 6;
            this.NoFocusTrackBar_Rotation.Scroll += new System.EventHandler(this.NoFocusTrackBar_Rotation_Scroll);
            this.NoFocusTrackBar_Rotation.Leave += new System.EventHandler(this.NoFocusTrackBar_Rotation_Leave);
            // 
            // NoFocusTrackBar_Contrast
            // 
            this.NoFocusTrackBar_Contrast.Location = new System.Drawing.Point(748, 49);
            this.NoFocusTrackBar_Contrast.Maximum = 200;
            this.NoFocusTrackBar_Contrast.Name = "NoFocusTrackBar_Contrast";
            this.NoFocusTrackBar_Contrast.Size = new System.Drawing.Size(104, 56);
            this.NoFocusTrackBar_Contrast.TabIndex = 19;
            this.NoFocusTrackBar_Contrast.Value = 100;
            this.NoFocusTrackBar_Contrast.Scroll += new System.EventHandler(this.NoFocusTrackBar_Contrast_Scroll);
            // 
            // NumericUpDown_PenWidth
            // 
            this.NumericUpDown_PenWidth.Location = new System.Drawing.Point(196, 112);
            this.NumericUpDown_PenWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDown_PenWidth.Name = "NumericUpDown_PenWidth";
            this.NumericUpDown_PenWidth.Size = new System.Drawing.Size(94, 22);
            this.NumericUpDown_PenWidth.TabIndex = 30;
            this.NumericUpDown_PenWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Label_Pen
            // 
            this.Label_Pen.AutoSize = true;
            this.Label_Pen.Location = new System.Drawing.Point(202, 88);
            this.Label_Pen.Name = "Label_Pen";
            this.Label_Pen.Size = new System.Drawing.Size(69, 17);
            this.Label_Pen.TabIndex = 31;
            this.Label_Pen.Text = "Pen width";
            // 
            // Panel_ColorDisplay
            // 
            this.Panel_ColorDisplay.BackColor = System.Drawing.SystemColors.MenuText;
            this.Panel_ColorDisplay.Location = new System.Drawing.Point(290, 49);
            this.Panel_ColorDisplay.Name = "Panel_ColorDisplay";
            this.Panel_ColorDisplay.Size = new System.Drawing.Size(29, 23);
            this.Panel_ColorDisplay.TabIndex = 32;
            // 
            // Label_RotationValue
            // 
            this.Label_RotationValue.AutoSize = true;
            this.Label_RotationValue.Location = new System.Drawing.Point(370, 88);
            this.Label_RotationValue.Name = "Label_RotationValue";
            this.Label_RotationValue.Size = new System.Drawing.Size(22, 17);
            this.Label_RotationValue.TabIndex = 33;
            this.Label_RotationValue.Text = "0°";
            // 
            // Label_WidthValue
            // 
            this.Label_WidthValue.AutoSize = true;
            this.Label_WidthValue.Location = new System.Drawing.Point(489, 88);
            this.Label_WidthValue.Name = "Label_WidthValue";
            this.Label_WidthValue.Size = new System.Drawing.Size(44, 17);
            this.Label_WidthValue.TabIndex = 34;
            this.Label_WidthValue.Text = "100%";
            // 
            // Label_HeightValue
            // 
            this.Label_HeightValue.AutoSize = true;
            this.Label_HeightValue.Location = new System.Drawing.Point(630, 88);
            this.Label_HeightValue.Name = "Label_HeightValue";
            this.Label_HeightValue.Size = new System.Drawing.Size(44, 17);
            this.Label_HeightValue.TabIndex = 35;
            this.Label_HeightValue.Text = "100%";
            // 
            // Label_ContrastValue
            // 
            this.Label_ContrastValue.AutoSize = true;
            this.Label_ContrastValue.Location = new System.Drawing.Point(781, 88);
            this.Label_ContrastValue.Name = "Label_ContrastValue";
            this.Label_ContrastValue.Size = new System.Drawing.Size(44, 17);
            this.Label_ContrastValue.TabIndex = 36;
            this.Label_ContrastValue.Text = "100%";
            // 
            // Label_BrightnessValue
            // 
            this.Label_BrightnessValue.AutoSize = true;
            this.Label_BrightnessValue.Location = new System.Drawing.Point(937, 88);
            this.Label_BrightnessValue.Name = "Label_BrightnessValue";
            this.Label_BrightnessValue.Size = new System.Drawing.Size(44, 17);
            this.Label_BrightnessValue.TabIndex = 37;
            this.Label_BrightnessValue.Text = "100%";
            // 
            // Label_RedValue
            // 
            this.Label_RedValue.AutoSize = true;
            this.Label_RedValue.Location = new System.Drawing.Point(36, 88);
            this.Label_RedValue.Name = "Label_RedValue";
            this.Label_RedValue.Size = new System.Drawing.Size(44, 17);
            this.Label_RedValue.TabIndex = 35;
            this.Label_RedValue.Text = "100%";
            // 
            // Label_GreenValue
            // 
            this.Label_GreenValue.AutoSize = true;
            this.Label_GreenValue.Location = new System.Drawing.Point(141, 88);
            this.Label_GreenValue.Name = "Label_GreenValue";
            this.Label_GreenValue.Size = new System.Drawing.Size(44, 17);
            this.Label_GreenValue.TabIndex = 36;
            this.Label_GreenValue.Text = "100%";
            // 
            // Label_BlueValue
            // 
            this.Label_BlueValue.AutoSize = true;
            this.Label_BlueValue.Location = new System.Drawing.Point(251, 88);
            this.Label_BlueValue.Name = "Label_BlueValue";
            this.Label_BlueValue.Size = new System.Drawing.Size(44, 17);
            this.Label_BlueValue.TabIndex = 37;
            this.Label_BlueValue.Text = "100%";
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
            ((System.ComponentModel.ISupportInitialize)(this.NoFocusTrackBar_Height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoFocusTrackBar_Width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoFocusTrackBar_Blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoFocusTrackBar_Red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoFocusTrackBar_Green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoFocusTrackBar_Brightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoFocusTrackBar_Rotation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoFocusTrackBar_Contrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_PenWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_File;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_OpenFile;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_SaveFile;
        private System.Windows.Forms.MenuStrip MenuStrip_Menu;
        private System.Windows.Forms.Panel Panel_Tools;
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
        private System.Windows.Forms.Button Button_Color;
        private System.Windows.Forms.Button Button_Draw;
        private System.Windows.Forms.Label Label_Zoom;
        private System.Windows.Forms.ColorDialog ColorDialog_BrushColor;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog_Open;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog_Save;
        private System.Windows.Forms.Panel Panel_Picture;
        private System.Windows.Forms.PictureBox PictureBox_Picture;
        private System.Windows.Forms.Label Label_Height;
        private System.Windows.Forms.Label Label_Width;
        private NoFocusTrackBar NoFocusTrackBar_Height;
        private NoFocusTrackBar NoFocusTrackBar_Width;
        private System.Windows.Forms.Button Button_Apply;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_SaveAs;
        private System.Windows.Forms.Label Label_Pen;
        private System.Windows.Forms.NumericUpDown NumericUpDown_PenWidth;
        private System.Windows.Forms.Panel Panel_ColorDisplay;
        private System.Windows.Forms.Label Label_BrightnessValue;
        private System.Windows.Forms.Label Label_ContrastValue;
        private System.Windows.Forms.Label Label_HeightValue;
        private System.Windows.Forms.Label Label_WidthValue;
        private System.Windows.Forms.Label Label_RotationValue;
        private System.Windows.Forms.Label Label_BlueValue;
        private System.Windows.Forms.Label Label_GreenValue;
        private System.Windows.Forms.Label Label_RedValue;
    }
}

