namespace Normal_Map_Converter
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadImage = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveImage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.Quit = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.Undo = new System.Windows.Forms.ToolStripMenuItem();
            this.Redo = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.RESOLUTION_TextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SAMPLESIZE_TextBox = new System.Windows.Forms.TextBox();
            this.SAMPLESIZE_Label = new System.Windows.Forms.Label();
            this.SAMPLESIZE_Slider = new System.Windows.Forms.TrackBar();
            this.RESOLUTION_Label = new System.Windows.Forms.Label();
            this.RESOLUTION_Slider = new System.Windows.Forms.TrackBar();
            this.AVERAGE_Button = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BLUE_TextBox = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.BLUE_Slider = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.GREEN_TextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GREEN_Slider = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RED_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RED_Slider = new System.Windows.Forms.TrackBar();
            this.AVERAGE = new System.Windows.Forms.Label();
            this.CREATEMAP_ProgressBar = new System.Windows.Forms.ProgressBar();
            this.GENERATE_Button = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SAMPLESIZE_Slider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RESOLUTION_Slider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BLUE_Slider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GREEN_Slider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RED_Slider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DimGray;
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.Edit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.fileToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fileToolStripMenuItem.BackgroundImage")));
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadImage,
            this.SaveImage,
            this.toolStripMenuItem2,
            this.Quit});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fileToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // LoadImage
            // 
            this.LoadImage.Name = "LoadImage";
            this.LoadImage.Padding = new System.Windows.Forms.Padding(0);
            this.LoadImage.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.LoadImage.Size = new System.Drawing.Size(179, 20);
            this.LoadImage.Text = "Load Image";
            this.LoadImage.Click += new System.EventHandler(this.loadFileToolStripMenuItem_Click);
            // 
            // SaveImage
            // 
            this.SaveImage.Name = "SaveImage";
            this.SaveImage.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveImage.Size = new System.Drawing.Size(179, 22);
            this.SaveImage.Text = "Save Image";
            this.SaveImage.Click += new System.EventHandler(this.SaveImage_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(176, 6);
            // 
            // Quit
            // 
            this.Quit.Name = "Quit";
            this.Quit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.Quit.Size = new System.Drawing.Size(179, 22);
            this.Quit.Text = "Quit";
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // Edit
            // 
            this.Edit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Edit.BackgroundImage")));
            this.Edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Undo,
            this.Redo});
            this.Edit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(39, 20);
            this.Edit.Text = "Edit";
            // 
            // Undo
            // 
            this.Undo.Name = "Undo";
            this.Undo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.Undo.Size = new System.Drawing.Size(174, 22);
            this.Undo.Text = "Undo";
            this.Undo.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // Redo
            // 
            this.Redo.Name = "Redo";
            this.Redo.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Z)));
            this.Redo.Size = new System.Drawing.Size(174, 22);
            this.Redo.Text = "Redo";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1284, 512);
            this.splitContainer1.SplitterDistance = 768;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.splitContainer2.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer2.Panel1.Controls.Add(this.RESOLUTION_TextBox);
            this.splitContainer2.Panel1.Controls.Add(this.label11);
            this.splitContainer2.Panel1.Controls.Add(this.label12);
            this.splitContainer2.Panel1.Controls.Add(this.label10);
            this.splitContainer2.Panel1.Controls.Add(this.label7);
            this.splitContainer2.Panel1.Controls.Add(this.SAMPLESIZE_TextBox);
            this.splitContainer2.Panel1.Controls.Add(this.SAMPLESIZE_Label);
            this.splitContainer2.Panel1.Controls.Add(this.SAMPLESIZE_Slider);
            this.splitContainer2.Panel1.Controls.Add(this.RESOLUTION_Label);
            this.splitContainer2.Panel1.Controls.Add(this.RESOLUTION_Slider);
            this.splitContainer2.Panel1.Controls.Add(this.AVERAGE_Button);
            this.splitContainer2.Panel1.Controls.Add(this.label9);
            this.splitContainer2.Panel1.Controls.Add(this.label8);
            this.splitContainer2.Panel1.Controls.Add(this.label6);
            this.splitContainer2.Panel1.Controls.Add(this.BLUE_TextBox);
            this.splitContainer2.Panel1.Controls.Add(this.label);
            this.splitContainer2.Panel1.Controls.Add(this.BLUE_Slider);
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.GREEN_TextBox);
            this.splitContainer2.Panel1.Controls.Add(this.label5);
            this.splitContainer2.Panel1.Controls.Add(this.GREEN_Slider);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.RED_TextBox);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.RED_Slider);
            this.splitContainer2.Panel1.Controls.Add(this.AVERAGE);
            this.splitContainer2.Panel1.Controls.Add(this.CREATEMAP_ProgressBar);
            this.splitContainer2.Panel1.Controls.Add(this.GENERATE_Button);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.pictureBox2);
            this.splitContainer2.Size = new System.Drawing.Size(768, 512);
            this.splitContainer2.SplitterDistance = 252;
            this.splitContainer2.TabIndex = 0;
            // 
            // RESOLUTION_TextBox
            // 
            this.RESOLUTION_TextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RESOLUTION_TextBox.Location = new System.Drawing.Point(146, 182);
            this.RESOLUTION_TextBox.MaxLength = 3;
            this.RESOLUTION_TextBox.Name = "RESOLUTION_TextBox";
            this.RESOLUTION_TextBox.Size = new System.Drawing.Size(45, 20);
            this.RESOLUTION_TextBox.TabIndex = 29;
            this.RESOLUTION_TextBox.TextChanged += new System.EventHandler(this.RESOLUTION_TextBox_TextChanged);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label11.Location = new System.Drawing.Point(18, 222);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "1";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label12.Location = new System.Drawing.Point(222, 222);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "500";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label10.Location = new System.Drawing.Point(18, 289);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "1";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Location = new System.Drawing.Point(225, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "10";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // SAMPLESIZE_TextBox
            // 
            this.SAMPLESIZE_TextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SAMPLESIZE_TextBox.Location = new System.Drawing.Point(140, 243);
            this.SAMPLESIZE_TextBox.MaxLength = 3;
            this.SAMPLESIZE_TextBox.Name = "SAMPLESIZE_TextBox";
            this.SAMPLESIZE_TextBox.Size = new System.Drawing.Size(45, 20);
            this.SAMPLESIZE_TextBox.TabIndex = 24;
            this.SAMPLESIZE_TextBox.TextChanged += new System.EventHandler(this.SAMPLESIZE_TextBox_TextChanged);
            // 
            // SAMPLESIZE_Label
            // 
            this.SAMPLESIZE_Label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SAMPLESIZE_Label.AutoSize = true;
            this.SAMPLESIZE_Label.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.SAMPLESIZE_Label.Location = new System.Drawing.Point(69, 247);
            this.SAMPLESIZE_Label.Name = "SAMPLESIZE_Label";
            this.SAMPLESIZE_Label.Size = new System.Drawing.Size(65, 13);
            this.SAMPLESIZE_Label.TabIndex = 23;
            this.SAMPLESIZE_Label.Text = "Sample Size";
            this.SAMPLESIZE_Label.Click += new System.EventHandler(this.label10_Click);
            // 
            // SAMPLESIZE_Slider
            // 
            this.SAMPLESIZE_Slider.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SAMPLESIZE_Slider.Location = new System.Drawing.Point(11, 269);
            this.SAMPLESIZE_Slider.Minimum = 1;
            this.SAMPLESIZE_Slider.Name = "SAMPLESIZE_Slider";
            this.SAMPLESIZE_Slider.Size = new System.Drawing.Size(234, 45);
            this.SAMPLESIZE_Slider.TabIndex = 22;
            this.SAMPLESIZE_Slider.Value = 1;
            this.SAMPLESIZE_Slider.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // RESOLUTION_Label
            // 
            this.RESOLUTION_Label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RESOLUTION_Label.AutoSize = true;
            this.RESOLUTION_Label.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.RESOLUTION_Label.Location = new System.Drawing.Point(59, 185);
            this.RESOLUTION_Label.Name = "RESOLUTION_Label";
            this.RESOLUTION_Label.Size = new System.Drawing.Size(84, 13);
            this.RESOLUTION_Label.TabIndex = 21;
            this.RESOLUTION_Label.Text = "Resolution (Blur)";
            // 
            // RESOLUTION_Slider
            // 
            this.RESOLUTION_Slider.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RESOLUTION_Slider.Location = new System.Drawing.Point(11, 201);
            this.RESOLUTION_Slider.Maximum = 500;
            this.RESOLUTION_Slider.Minimum = 1;
            this.RESOLUTION_Slider.Name = "RESOLUTION_Slider";
            this.RESOLUTION_Slider.Size = new System.Drawing.Size(234, 45);
            this.RESOLUTION_Slider.TabIndex = 20;
            this.RESOLUTION_Slider.TickFrequency = 20;
            this.RESOLUTION_Slider.Value = 1;
            this.RESOLUTION_Slider.Scroll += new System.EventHandler(this.RESOLUTION_Slider_Scroll);
            // 
            // AVERAGE_Button
            // 
            this.AVERAGE_Button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AVERAGE_Button.BackColor = System.Drawing.Color.DimGray;
            this.AVERAGE_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AVERAGE_Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AVERAGE_Button.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.AVERAGE_Button.Location = new System.Drawing.Point(41, 145);
            this.AVERAGE_Button.Name = "AVERAGE_Button";
            this.AVERAGE_Button.Size = new System.Drawing.Size(175, 24);
            this.AVERAGE_Button.TabIndex = 19;
            this.AVERAGE_Button.Text = "Generate Average From Image";
            this.AVERAGE_Button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AVERAGE_Button.UseVisualStyleBackColor = false;
            this.AVERAGE_Button.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label9.Location = new System.Drawing.Point(221, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "255";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label8.Location = new System.Drawing.Point(222, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "255";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Location = new System.Drawing.Point(64, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "0";
            // 
            // BLUE_TextBox
            // 
            this.BLUE_TextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BLUE_TextBox.Location = new System.Drawing.Point(12, 119);
            this.BLUE_TextBox.MaxLength = 3;
            this.BLUE_TextBox.Name = "BLUE_TextBox";
            this.BLUE_TextBox.Size = new System.Drawing.Size(45, 20);
            this.BLUE_TextBox.TabIndex = 15;
            this.BLUE_TextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label
            // 
            this.label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label.AutoSize = true;
            this.label.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label.Location = new System.Drawing.Point(21, 103);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(28, 13);
            this.label.TabIndex = 14;
            this.label.Text = "Blue";
            // 
            // BLUE_Slider
            // 
            this.BLUE_Slider.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BLUE_Slider.LargeChange = 1;
            this.BLUE_Slider.Location = new System.Drawing.Point(56, 104);
            this.BLUE_Slider.Maximum = 255;
            this.BLUE_Slider.Name = "BLUE_Slider";
            this.BLUE_Slider.Size = new System.Drawing.Size(190, 45);
            this.BLUE_Slider.TabIndex = 13;
            this.BLUE_Slider.TickFrequency = 10;
            this.BLUE_Slider.Scroll += new System.EventHandler(this.BLUE_Slider_Scroll);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(64, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "0";
            // 
            // GREEN_TextBox
            // 
            this.GREEN_TextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GREEN_TextBox.Location = new System.Drawing.Point(12, 78);
            this.GREEN_TextBox.MaxLength = 3;
            this.GREEN_TextBox.Name = "GREEN_TextBox";
            this.GREEN_TextBox.Size = new System.Drawing.Size(45, 20);
            this.GREEN_TextBox.TabIndex = 11;
            this.GREEN_TextBox.TextChanged += new System.EventHandler(this.GREEN_TextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(17, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Green";
            // 
            // GREEN_Slider
            // 
            this.GREEN_Slider.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GREEN_Slider.LargeChange = 1;
            this.GREEN_Slider.Location = new System.Drawing.Point(56, 63);
            this.GREEN_Slider.Maximum = 255;
            this.GREEN_Slider.Name = "GREEN_Slider";
            this.GREEN_Slider.Size = new System.Drawing.Size(190, 45);
            this.GREEN_Slider.TabIndex = 9;
            this.GREEN_Slider.TickFrequency = 10;
            this.GREEN_Slider.Scroll += new System.EventHandler(this.GREEN_Slider_Scroll);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(221, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "255";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(64, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "0";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // RED_TextBox
            // 
            this.RED_TextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RED_TextBox.Location = new System.Drawing.Point(12, 38);
            this.RED_TextBox.MaxLength = 3;
            this.RED_TextBox.Name = "RED_TextBox";
            this.RED_TextBox.Size = new System.Drawing.Size(45, 20);
            this.RED_TextBox.TabIndex = 5;
            this.RED_TextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Red";
            // 
            // RED_Slider
            // 
            this.RED_Slider.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RED_Slider.LargeChange = 1;
            this.RED_Slider.Location = new System.Drawing.Point(56, 23);
            this.RED_Slider.Maximum = 255;
            this.RED_Slider.Name = "RED_Slider";
            this.RED_Slider.Size = new System.Drawing.Size(190, 45);
            this.RED_Slider.TabIndex = 3;
            this.RED_Slider.TickFrequency = 10;
            this.RED_Slider.Scroll += new System.EventHandler(this.red_Scroll);
            // 
            // AVERAGE
            // 
            this.AVERAGE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AVERAGE.AutoSize = true;
            this.AVERAGE.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.AVERAGE.Location = new System.Drawing.Point(82, 7);
            this.AVERAGE.Name = "AVERAGE";
            this.AVERAGE.Size = new System.Drawing.Size(81, 13);
            this.AVERAGE.TabIndex = 2;
            this.AVERAGE.Text = "Average Height";
            this.AVERAGE.Click += new System.EventHandler(this.label1_Click);
            // 
            // CREATEMAP_ProgressBar
            // 
            this.CREATEMAP_ProgressBar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CREATEMAP_ProgressBar.Location = new System.Drawing.Point(56, 477);
            this.CREATEMAP_ProgressBar.Maximum = 50;
            this.CREATEMAP_ProgressBar.Name = "CREATEMAP_ProgressBar";
            this.CREATEMAP_ProgressBar.Size = new System.Drawing.Size(150, 10);
            this.CREATEMAP_ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.CREATEMAP_ProgressBar.TabIndex = 1;
            this.CREATEMAP_ProgressBar.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // GENERATE_Button
            // 
            this.GENERATE_Button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GENERATE_Button.BackColor = System.Drawing.Color.DimGray;
            this.GENERATE_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GENERATE_Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.GENERATE_Button.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.GENERATE_Button.Location = new System.Drawing.Point(41, 458);
            this.GENERATE_Button.Name = "GENERATE_Button";
            this.GENERATE_Button.Size = new System.Drawing.Size(180, 42);
            this.GENERATE_Button.TabIndex = 0;
            this.GENERATE_Button.Text = "Create Map";
            this.GENERATE_Button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GENERATE_Button.UseVisualStyleBackColor = false;
            this.GENERATE_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(512, 512);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 512);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1284, 536);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Normal Map Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SAMPLESIZE_Slider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RESOLUTION_Slider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BLUE_Slider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GREEN_Slider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RED_Slider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadImage;
        private System.Windows.Forms.ToolStripMenuItem SaveImage;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem Quit;
        private System.Windows.Forms.ToolStripMenuItem Edit;
        private System.Windows.Forms.ToolStripMenuItem Undo;
        private System.Windows.Forms.ToolStripMenuItem Redo;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button GENERATE_Button;
        private System.Windows.Forms.ProgressBar CREATEMAP_ProgressBar;
        private System.Windows.Forms.Label AVERAGE;
        private System.Windows.Forms.TrackBar RED_Slider;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox RED_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox BLUE_TextBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TrackBar BLUE_Slider;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox GREEN_TextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar GREEN_Slider;
        private System.Windows.Forms.Button AVERAGE_Button;
        private System.Windows.Forms.Label RESOLUTION_Label;
        private System.Windows.Forms.TrackBar RESOLUTION_Slider;
        private System.Windows.Forms.Label SAMPLESIZE_Label;
        private System.Windows.Forms.TrackBar SAMPLESIZE_Slider;
        private System.Windows.Forms.TextBox SAMPLESIZE_TextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox RESOLUTION_TextBox;
    }
}

