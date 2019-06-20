namespace DicomViewer
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MinLevelLabel = new System.Windows.Forms.Label();
            this.MinLevelTextBox = new System.Windows.Forms.TextBox();
            this.MaxDensityLabel = new System.Windows.Forms.Label();
            this.MinLevelTrackBar = new System.Windows.Forms.TrackBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CurrentSliceLabel = new System.Windows.Forms.Label();
            this.CurrentSliceTextbox = new System.Windows.Forms.TextBox();
            this.MaxSliceLabel = new System.Windows.Forms.Label();
            this.SliceTrackBar = new System.Windows.Forms.TrackBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.MaxLevelLabel = new System.Windows.Forms.Label();
            this.MaxLevelTextBox = new System.Windows.Forms.TextBox();
            this.MaxLevelTrackBar = new System.Windows.Forms.TrackBar();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.DiameterTextBox = new System.Windows.Forms.TextBox();
            this.DiameterLabel = new System.Windows.Forms.Label();
            this.DiameterTrackBar = new System.Windows.Forms.TrackBar();
            this.panel6 = new System.Windows.Forms.Panel();
            this.SigmaColorTextBox = new System.Windows.Forms.TextBox();
            this.SigmaColorLabel = new System.Windows.Forms.Label();
            this.SigmaColorTrackBar = new System.Windows.Forms.TrackBar();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.FEButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.DefaultWindowButton = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.SegmentateCheckBox = new System.Windows.Forms.CheckBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.SigmaSpaceLabel = new System.Windows.Forms.Label();
            this.SigmaSpaceTextBox = new System.Windows.Forms.TextBox();
            this.SigmaSpaceTrackBar = new System.Windows.Forms.TrackBar();
            this.panel12 = new System.Windows.Forms.Panel();
            this.FilterCheckBox = new System.Windows.Forms.CheckBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.FromSliceTrackBar = new System.Windows.Forms.TrackBar();
            this.ToSliceTrackBar = new System.Windows.Forms.TrackBar();
            this.FromSliceLabel = new System.Windows.Forms.Label();
            this.ToSliceLabel = new System.Windows.Forms.Label();
            this.FromSliceTextBox = new System.Windows.Forms.TextBox();
            this.ToSliceTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinLevelTrackBar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SliceTrackBar)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxLevelTrackBar)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiameterTrackBar)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SigmaColorTrackBar)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SigmaSpaceTrackBar)).BeginInit();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FromSliceTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToSliceTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel8, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel9, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel10, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel11, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel12, 2, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1245, 612);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(409, 361);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(418, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(409, 361);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MinLevelLabel);
            this.panel1.Controls.Add(this.MinLevelTextBox);
            this.panel1.Controls.Add(this.MaxDensityLabel);
            this.panel1.Controls.Add(this.MinLevelTrackBar);
            this.panel1.Location = new System.Drawing.Point(418, 370);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 55);
            this.panel1.TabIndex = 5;
            // 
            // MinLevelLabel
            // 
            this.MinLevelLabel.AutoSize = true;
            this.MinLevelLabel.Location = new System.Drawing.Point(167, 35);
            this.MinLevelLabel.Name = "MinLevelLabel";
            this.MinLevelLabel.Size = new System.Drawing.Size(24, 13);
            this.MinLevelLabel.TabIndex = 4;
            this.MinLevelLabel.Text = "Min";
            // 
            // MinLevelTextBox
            // 
            this.MinLevelTextBox.Enabled = false;
            this.MinLevelTextBox.Location = new System.Drawing.Point(197, 32);
            this.MinLevelTextBox.Name = "MinLevelTextBox";
            this.MinLevelTextBox.ReadOnly = true;
            this.MinLevelTextBox.Size = new System.Drawing.Size(43, 20);
            this.MinLevelTextBox.TabIndex = 3;
            // 
            // MaxDensityLabel
            // 
            this.MaxDensityLabel.AutoSize = true;
            this.MaxDensityLabel.Location = new System.Drawing.Point(459, 32);
            this.MaxDensityLabel.Name = "MaxDensityLabel";
            this.MaxDensityLabel.Size = new System.Drawing.Size(27, 13);
            this.MaxDensityLabel.TabIndex = 1;
            this.MaxDensityLabel.Text = "Max";
            this.MaxDensityLabel.Visible = false;
            // 
            // MinLevelTrackBar
            // 
            this.MinLevelTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MinLevelTrackBar.Enabled = false;
            this.MinLevelTrackBar.Location = new System.Drawing.Point(0, 0);
            this.MinLevelTrackBar.Minimum = 1;
            this.MinLevelTrackBar.Name = "MinLevelTrackBar";
            this.MinLevelTrackBar.Size = new System.Drawing.Size(408, 55);
            this.MinLevelTrackBar.TabIndex = 0;
            this.MinLevelTrackBar.Value = 1;
            this.MinLevelTrackBar.Scroll += new System.EventHandler(this.MinLevelTrackBar_Scroll);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CurrentSliceLabel);
            this.panel2.Controls.Add(this.CurrentSliceTextbox);
            this.panel2.Controls.Add(this.MaxSliceLabel);
            this.panel2.Controls.Add(this.SliceTrackBar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 370);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(409, 55);
            this.panel2.TabIndex = 6;
            // 
            // CurrentSliceLabel
            // 
            this.CurrentSliceLabel.AutoSize = true;
            this.CurrentSliceLabel.Location = new System.Drawing.Point(152, 32);
            this.CurrentSliceLabel.Name = "CurrentSliceLabel";
            this.CurrentSliceLabel.Size = new System.Drawing.Size(33, 13);
            this.CurrentSliceLabel.TabIndex = 8;
            this.CurrentSliceLabel.Text = "Slice:";
            // 
            // CurrentSliceTextbox
            // 
            this.CurrentSliceTextbox.Enabled = false;
            this.CurrentSliceTextbox.Location = new System.Drawing.Point(191, 29);
            this.CurrentSliceTextbox.Name = "CurrentSliceTextbox";
            this.CurrentSliceTextbox.ReadOnly = true;
            this.CurrentSliceTextbox.Size = new System.Drawing.Size(37, 20);
            this.CurrentSliceTextbox.TabIndex = 7;
            // 
            // MaxSliceLabel
            // 
            this.MaxSliceLabel.AutoSize = true;
            this.MaxSliceLabel.Location = new System.Drawing.Point(456, 32);
            this.MaxSliceLabel.Name = "MaxSliceLabel";
            this.MaxSliceLabel.Size = new System.Drawing.Size(27, 13);
            this.MaxSliceLabel.TabIndex = 5;
            this.MaxSliceLabel.Text = "Max";
            this.MaxSliceLabel.Visible = false;
            // 
            // SliceTrackBar
            // 
            this.SliceTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SliceTrackBar.Enabled = false;
            this.SliceTrackBar.Location = new System.Drawing.Point(0, 0);
            this.SliceTrackBar.Minimum = 1;
            this.SliceTrackBar.Name = "SliceTrackBar";
            this.SliceTrackBar.Size = new System.Drawing.Size(409, 55);
            this.SliceTrackBar.TabIndex = 4;
            this.SliceTrackBar.Value = 1;
            this.SliceTrackBar.Scroll += new System.EventHandler(this.SliceTrackBar_Scroll);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.MaxLevelLabel);
            this.panel3.Controls.Add(this.MaxLevelTextBox);
            this.panel3.Controls.Add(this.MaxLevelTrackBar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(418, 431);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(409, 55);
            this.panel3.TabIndex = 7;
            // 
            // MaxLevelLabel
            // 
            this.MaxLevelLabel.AutoSize = true;
            this.MaxLevelLabel.Location = new System.Drawing.Point(165, 29);
            this.MaxLevelLabel.Name = "MaxLevelLabel";
            this.MaxLevelLabel.Size = new System.Drawing.Size(27, 13);
            this.MaxLevelLabel.TabIndex = 6;
            this.MaxLevelLabel.Text = "Max";
            // 
            // MaxLevelTextBox
            // 
            this.MaxLevelTextBox.Enabled = false;
            this.MaxLevelTextBox.Location = new System.Drawing.Point(198, 26);
            this.MaxLevelTextBox.Name = "MaxLevelTextBox";
            this.MaxLevelTextBox.ReadOnly = true;
            this.MaxLevelTextBox.Size = new System.Drawing.Size(43, 20);
            this.MaxLevelTextBox.TabIndex = 5;
            // 
            // MaxLevelTrackBar
            // 
            this.MaxLevelTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MaxLevelTrackBar.Enabled = false;
            this.MaxLevelTrackBar.Location = new System.Drawing.Point(0, 0);
            this.MaxLevelTrackBar.Minimum = 1;
            this.MaxLevelTrackBar.Name = "MaxLevelTrackBar";
            this.MaxLevelTrackBar.Size = new System.Drawing.Size(409, 55);
            this.MaxLevelTrackBar.TabIndex = 1;
            this.MaxLevelTrackBar.Value = 1;
            this.MaxLevelTrackBar.Scroll += new System.EventHandler(this.MaxLevelTrackBar_Scroll);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.FromSliceTextBox);
            this.panel4.Controls.Add(this.FromSliceLabel);
            this.panel4.Controls.Add(this.FromSliceTrackBar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 431);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(409, 55);
            this.panel4.TabIndex = 8;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Location = new System.Drawing.Point(832, 2);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(411, 363);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.DiameterTextBox);
            this.panel5.Controls.Add(this.DiameterLabel);
            this.panel5.Controls.Add(this.DiameterTrackBar);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(832, 369);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(411, 57);
            this.panel5.TabIndex = 10;
            // 
            // DiameterTextBox
            // 
            this.DiameterTextBox.Enabled = false;
            this.DiameterTextBox.Location = new System.Drawing.Point(199, 30);
            this.DiameterTextBox.Name = "DiameterTextBox";
            this.DiameterTextBox.ReadOnly = true;
            this.DiameterTextBox.Size = new System.Drawing.Size(43, 20);
            this.DiameterTextBox.TabIndex = 5;
            // 
            // DiameterLabel
            // 
            this.DiameterLabel.AutoSize = true;
            this.DiameterLabel.Location = new System.Drawing.Point(144, 33);
            this.DiameterLabel.Name = "DiameterLabel";
            this.DiameterLabel.Size = new System.Drawing.Size(49, 13);
            this.DiameterLabel.TabIndex = 3;
            this.DiameterLabel.Text = "Diameter";
            // 
            // DiameterTrackBar
            // 
            this.DiameterTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DiameterTrackBar.Enabled = false;
            this.DiameterTrackBar.Location = new System.Drawing.Point(0, 0);
            this.DiameterTrackBar.Minimum = 1;
            this.DiameterTrackBar.Name = "DiameterTrackBar";
            this.DiameterTrackBar.Size = new System.Drawing.Size(411, 57);
            this.DiameterTrackBar.TabIndex = 1;
            this.DiameterTrackBar.Value = 1;
            this.DiameterTrackBar.Scroll += new System.EventHandler(this.DiameterTrackBar_Scroll);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.SigmaColorTextBox);
            this.panel6.Controls.Add(this.SigmaColorLabel);
            this.panel6.Controls.Add(this.SigmaColorTrackBar);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(832, 430);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(411, 57);
            this.panel6.TabIndex = 11;
            // 
            // SigmaColorTextBox
            // 
            this.SigmaColorTextBox.Enabled = false;
            this.SigmaColorTextBox.Location = new System.Drawing.Point(199, 33);
            this.SigmaColorTextBox.Name = "SigmaColorTextBox";
            this.SigmaColorTextBox.ReadOnly = true;
            this.SigmaColorTextBox.Size = new System.Drawing.Size(43, 20);
            this.SigmaColorTextBox.TabIndex = 5;
            // 
            // SigmaColorLabel
            // 
            this.SigmaColorLabel.AutoSize = true;
            this.SigmaColorLabel.Location = new System.Drawing.Point(133, 36);
            this.SigmaColorLabel.Name = "SigmaColorLabel";
            this.SigmaColorLabel.Size = new System.Drawing.Size(60, 13);
            this.SigmaColorLabel.TabIndex = 4;
            this.SigmaColorLabel.Text = "SigmaColor";
            // 
            // SigmaColorTrackBar
            // 
            this.SigmaColorTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SigmaColorTrackBar.Enabled = false;
            this.SigmaColorTrackBar.Location = new System.Drawing.Point(0, 0);
            this.SigmaColorTrackBar.Minimum = 1;
            this.SigmaColorTrackBar.Name = "SigmaColorTrackBar";
            this.SigmaColorTrackBar.Size = new System.Drawing.Size(411, 57);
            this.SigmaColorTrackBar.TabIndex = 1;
            this.SigmaColorTrackBar.Value = 1;
            this.SigmaColorTrackBar.Scroll += new System.EventHandler(this.SigmaColorTrackBar_Scroll);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.ToSliceTextBox);
            this.panel7.Controls.Add(this.ToSliceLabel);
            this.panel7.Controls.Add(this.ToSliceTrackBar);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(3, 492);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(409, 55);
            this.panel7.TabIndex = 12;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.FEButton);
            this.panel8.Controls.Add(this.ClearButton);
            this.panel8.Controls.Add(this.openButton);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(3, 553);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(409, 56);
            this.panel8.TabIndex = 13;
            // 
            // FEButton
            // 
            this.FEButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.FEButton.Enabled = false;
            this.FEButton.Location = new System.Drawing.Point(321, 24);
            this.FEButton.Name = "FEButton";
            this.FEButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FEButton.Size = new System.Drawing.Size(75, 23);
            this.FEButton.TabIndex = 4;
            this.FEButton.Text = "Generate FE";
            this.FEButton.UseVisualStyleBackColor = true;
            this.FEButton.Click += new System.EventHandler(this.FEButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Enabled = false;
            this.ClearButton.Location = new System.Drawing.Point(90, 24);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 1;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(9, 24);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 23);
            this.openButton.TabIndex = 0;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.DefaultWindowButton);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(418, 492);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(409, 55);
            this.panel9.TabIndex = 14;
            // 
            // DefaultWindowButton
            // 
            this.DefaultWindowButton.Enabled = false;
            this.DefaultWindowButton.Location = new System.Drawing.Point(170, 19);
            this.DefaultWindowButton.Name = "DefaultWindowButton";
            this.DefaultWindowButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DefaultWindowButton.Size = new System.Drawing.Size(75, 23);
            this.DefaultWindowButton.TabIndex = 5;
            this.DefaultWindowButton.Text = "Default";
            this.DefaultWindowButton.UseVisualStyleBackColor = true;
            this.DefaultWindowButton.Click += new System.EventHandler(this.DefaultWindowButton_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.SegmentateCheckBox);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(418, 553);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(409, 56);
            this.panel10.TabIndex = 15;
            // 
            // SegmentateCheckBox
            // 
            this.SegmentateCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.SegmentateCheckBox.AutoSize = true;
            this.SegmentateCheckBox.Enabled = false;
            this.SegmentateCheckBox.Location = new System.Drawing.Point(171, 24);
            this.SegmentateCheckBox.Name = "SegmentateCheckBox";
            this.SegmentateCheckBox.Size = new System.Drawing.Size(74, 23);
            this.SegmentateCheckBox.TabIndex = 3;
            this.SegmentateCheckBox.Text = "Segmentate";
            this.SegmentateCheckBox.UseVisualStyleBackColor = true;
            this.SegmentateCheckBox.CheckedChanged += new System.EventHandler(this.SegmentateCheckBox_CheckedChanged);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.SigmaSpaceLabel);
            this.panel11.Controls.Add(this.SigmaSpaceTextBox);
            this.panel11.Controls.Add(this.SigmaSpaceTrackBar);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(833, 492);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(409, 55);
            this.panel11.TabIndex = 16;
            // 
            // SigmaSpaceLabel
            // 
            this.SigmaSpaceLabel.AutoSize = true;
            this.SigmaSpaceLabel.Location = new System.Drawing.Point(125, 35);
            this.SigmaSpaceLabel.Name = "SigmaSpaceLabel";
            this.SigmaSpaceLabel.Size = new System.Drawing.Size(67, 13);
            this.SigmaSpaceLabel.TabIndex = 5;
            this.SigmaSpaceLabel.Text = "SigmaSpace";
            // 
            // SigmaSpaceTextBox
            // 
            this.SigmaSpaceTextBox.Enabled = false;
            this.SigmaSpaceTextBox.Location = new System.Drawing.Point(198, 32);
            this.SigmaSpaceTextBox.Name = "SigmaSpaceTextBox";
            this.SigmaSpaceTextBox.ReadOnly = true;
            this.SigmaSpaceTextBox.Size = new System.Drawing.Size(43, 20);
            this.SigmaSpaceTextBox.TabIndex = 5;
            // 
            // SigmaSpaceTrackBar
            // 
            this.SigmaSpaceTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SigmaSpaceTrackBar.Enabled = false;
            this.SigmaSpaceTrackBar.Location = new System.Drawing.Point(0, 0);
            this.SigmaSpaceTrackBar.Minimum = 1;
            this.SigmaSpaceTrackBar.Name = "SigmaSpaceTrackBar";
            this.SigmaSpaceTrackBar.Size = new System.Drawing.Size(409, 55);
            this.SigmaSpaceTrackBar.TabIndex = 1;
            this.SigmaSpaceTrackBar.Value = 1;
            this.SigmaSpaceTrackBar.Scroll += new System.EventHandler(this.SigmaSpaceTrackBar_Scroll);
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.FilterCheckBox);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(833, 553);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(409, 56);
            this.panel12.TabIndex = 17;
            // 
            // FilterCheckBox
            // 
            this.FilterCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.FilterCheckBox.Enabled = false;
            this.FilterCheckBox.Location = new System.Drawing.Point(184, 24);
            this.FilterCheckBox.Name = "FilterCheckBox";
            this.FilterCheckBox.Size = new System.Drawing.Size(74, 23);
            this.FilterCheckBox.TabIndex = 4;
            this.FilterCheckBox.Text = "Filter";
            this.FilterCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FilterCheckBox.UseVisualStyleBackColor = true;
            this.FilterCheckBox.CheckedChanged += new System.EventHandler(this.FilterCheckBox_CheckedChanged);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "Текстовый документ|*.txt";
            // 
            // FromSliceTrackBar
            // 
            this.FromSliceTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FromSliceTrackBar.Enabled = false;
            this.FromSliceTrackBar.Location = new System.Drawing.Point(0, 0);
            this.FromSliceTrackBar.Minimum = 1;
            this.FromSliceTrackBar.Name = "FromSliceTrackBar";
            this.FromSliceTrackBar.Size = new System.Drawing.Size(409, 55);
            this.FromSliceTrackBar.TabIndex = 5;
            this.FromSliceTrackBar.Value = 1;
            // 
            // ToSliceTrackBar
            // 
            this.ToSliceTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToSliceTrackBar.Enabled = false;
            this.ToSliceTrackBar.Location = new System.Drawing.Point(0, 0);
            this.ToSliceTrackBar.Minimum = 1;
            this.ToSliceTrackBar.Name = "ToSliceTrackBar";
            this.ToSliceTrackBar.Size = new System.Drawing.Size(409, 55);
            this.ToSliceTrackBar.TabIndex = 5;
            this.ToSliceTrackBar.Value = 1;
            // 
            // FromSliceLabel
            // 
            this.FromSliceLabel.AutoSize = true;
            this.FromSliceLabel.Location = new System.Drawing.Point(152, 33);
            this.FromSliceLabel.Name = "FromSliceLabel";
            this.FromSliceLabel.Size = new System.Drawing.Size(33, 13);
            this.FromSliceLabel.TabIndex = 10;
            this.FromSliceLabel.Text = "From:";
            // 
            // ToSliceLabel
            // 
            this.ToSliceLabel.AutoSize = true;
            this.ToSliceLabel.Location = new System.Drawing.Point(152, 32);
            this.ToSliceLabel.Name = "ToSliceLabel";
            this.ToSliceLabel.Size = new System.Drawing.Size(23, 13);
            this.ToSliceLabel.TabIndex = 11;
            this.ToSliceLabel.Text = "To:";
            // 
            // FromSliceTextBox
            // 
            this.FromSliceTextBox.Enabled = false;
            this.FromSliceTextBox.Location = new System.Drawing.Point(191, 32);
            this.FromSliceTextBox.Name = "FromSliceTextBox";
            this.FromSliceTextBox.ReadOnly = true;
            this.FromSliceTextBox.Size = new System.Drawing.Size(37, 20);
            this.FromSliceTextBox.TabIndex = 11;
            // 
            // ToSliceTextBox
            // 
            this.ToSliceTextBox.Enabled = false;
            this.ToSliceTextBox.Location = new System.Drawing.Point(191, 29);
            this.ToSliceTextBox.Name = "ToSliceTextBox";
            this.ToSliceTextBox.ReadOnly = true;
            this.ToSliceTextBox.Size = new System.Drawing.Size(37, 20);
            this.ToSliceTextBox.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1245, 612);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "DicomViewer";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinLevelTrackBar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SliceTrackBar)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxLevelTrackBar)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiameterTrackBar)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SigmaColorTrackBar)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SigmaSpaceTrackBar)).EndInit();
            this.panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FromSliceTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToSliceTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TrackBar SliceTrackBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label MinLevelLabel;
        private System.Windows.Forms.TextBox MinLevelTextBox;
        private System.Windows.Forms.Label MaxDensityLabel;
        private System.Windows.Forms.TrackBar MinLevelTrackBar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label CurrentSliceLabel;
        private System.Windows.Forms.TextBox CurrentSliceTextbox;
        private System.Windows.Forms.Label MaxSliceLabel;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox SegmentateCheckBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button FEButton;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label SigmaSpaceLabel;
        private System.Windows.Forms.Label SigmaColorLabel;
        private System.Windows.Forms.Label DiameterLabel;
        private System.Windows.Forms.Label MaxLevelLabel;
        private System.Windows.Forms.TextBox MaxLevelTextBox;
        private System.Windows.Forms.TrackBar MaxLevelTrackBar;
        private System.Windows.Forms.TextBox DiameterTextBox;
        private System.Windows.Forms.TrackBar DiameterTrackBar;
        private System.Windows.Forms.TextBox SigmaColorTextBox;
        private System.Windows.Forms.TrackBar SigmaColorTrackBar;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox SigmaSpaceTextBox;
        private System.Windows.Forms.TrackBar SigmaSpaceTrackBar;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button DefaultWindowButton;
        private System.Windows.Forms.CheckBox FilterCheckBox;
        private System.Windows.Forms.TextBox FromSliceTextBox;
        private System.Windows.Forms.Label FromSliceLabel;
        private System.Windows.Forms.TrackBar FromSliceTrackBar;
        private System.Windows.Forms.TextBox ToSliceTextBox;
        private System.Windows.Forms.Label ToSliceLabel;
        private System.Windows.Forms.TrackBar ToSliceTrackBar;
    }
}

