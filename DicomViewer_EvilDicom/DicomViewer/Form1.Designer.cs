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
            this.MaxDensityLabel = new System.Windows.Forms.Label();
            this.CurrentDensityLabel = new System.Windows.Forms.Label();
            this.CurrentDensityTextBox = new System.Windows.Forms.TextBox();
            this.MinDensityLabel = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MaxSliceLabel = new System.Windows.Forms.Label();
            this.CurrentSliceLabel = new System.Windows.Forms.Label();
            this.CurrentSliceTextbox = new System.Windows.Forms.TextBox();
            this.MinSliceLabel = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SegmentateCheckBox = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.FEButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.SigmaSpaceLabel = new System.Windows.Forms.Label();
            this.SigmaColorLabel = new System.Windows.Forms.Label();
            this.DiameterLabel = new System.Windows.Forms.Label();
            this.SigmaSpaceTextBox = new System.Windows.Forms.TextBox();
            this.SigmaColorTextBox = new System.Windows.Forms.TextBox();
            this.DiameterTextBox = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.FilterButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 518F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 518F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 518F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 518F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1538, 640);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 512);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(521, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(512, 512);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MaxDensityLabel);
            this.panel1.Controls.Add(this.CurrentDensityLabel);
            this.panel1.Controls.Add(this.CurrentDensityTextBox);
            this.panel1.Controls.Add(this.MinDensityLabel);
            this.panel1.Controls.Add(this.trackBar2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(521, 521);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 55);
            this.panel1.TabIndex = 5;
            // 
            // MaxDensityLabel
            // 
            this.MaxDensityLabel.AutoSize = true;
            this.MaxDensityLabel.Location = new System.Drawing.Point(485, 32);
            this.MaxDensityLabel.Name = "MaxDensityLabel";
            this.MaxDensityLabel.Size = new System.Drawing.Size(27, 13);
            this.MaxDensityLabel.TabIndex = 5;
            this.MaxDensityLabel.Text = "Max";
            this.MaxDensityLabel.Visible = false;
            // 
            // CurrentDensityLabel
            // 
            this.CurrentDensityLabel.AutoSize = true;
            this.CurrentDensityLabel.Location = new System.Drawing.Point(198, 32);
            this.CurrentDensityLabel.Name = "CurrentDensityLabel";
            this.CurrentDensityLabel.Size = new System.Drawing.Size(79, 13);
            this.CurrentDensityLabel.TabIndex = 4;
            this.CurrentDensityLabel.Text = "Current Density";
            // 
            // CurrentDensityTextBox
            // 
            this.CurrentDensityTextBox.Enabled = false;
            this.CurrentDensityTextBox.Location = new System.Drawing.Point(283, 29);
            this.CurrentDensityTextBox.Name = "CurrentDensityTextBox";
            this.CurrentDensityTextBox.ReadOnly = true;
            this.CurrentDensityTextBox.Size = new System.Drawing.Size(43, 20);
            this.CurrentDensityTextBox.TabIndex = 3;
            // 
            // MinDensityLabel
            // 
            this.MinDensityLabel.AutoSize = true;
            this.MinDensityLabel.Location = new System.Drawing.Point(3, 32);
            this.MinDensityLabel.Name = "MinDensityLabel";
            this.MinDensityLabel.Size = new System.Drawing.Size(24, 13);
            this.MinDensityLabel.TabIndex = 2;
            this.MinDensityLabel.Text = "Min";
            this.MinDensityLabel.Visible = false;
            // 
            // trackBar2
            // 
            this.trackBar2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar2.Enabled = false;
            this.trackBar2.Location = new System.Drawing.Point(0, 0);
            this.trackBar2.Minimum = 1;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(512, 55);
            this.trackBar2.TabIndex = 0;
            this.trackBar2.Value = 1;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.MaxSliceLabel);
            this.panel2.Controls.Add(this.CurrentSliceLabel);
            this.panel2.Controls.Add(this.CurrentSliceTextbox);
            this.panel2.Controls.Add(this.MinSliceLabel);
            this.panel2.Controls.Add(this.trackBar1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 521);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(512, 55);
            this.panel2.TabIndex = 6;
            // 
            // MaxSliceLabel
            // 
            this.MaxSliceLabel.AutoSize = true;
            this.MaxSliceLabel.Location = new System.Drawing.Point(485, 32);
            this.MaxSliceLabel.Name = "MaxSliceLabel";
            this.MaxSliceLabel.Size = new System.Drawing.Size(27, 13);
            this.MaxSliceLabel.TabIndex = 9;
            this.MaxSliceLabel.Text = "Max";
            this.MaxSliceLabel.Visible = false;
            // 
            // CurrentSliceLabel
            // 
            this.CurrentSliceLabel.AutoSize = true;
            this.CurrentSliceLabel.Location = new System.Drawing.Point(203, 32);
            this.CurrentSliceLabel.Name = "CurrentSliceLabel";
            this.CurrentSliceLabel.Size = new System.Drawing.Size(70, 13);
            this.CurrentSliceLabel.TabIndex = 8;
            this.CurrentSliceLabel.Text = "Current Slice:";
            // 
            // CurrentSliceTextbox
            // 
            this.CurrentSliceTextbox.Enabled = false;
            this.CurrentSliceTextbox.Location = new System.Drawing.Point(279, 29);
            this.CurrentSliceTextbox.Name = "CurrentSliceTextbox";
            this.CurrentSliceTextbox.ReadOnly = true;
            this.CurrentSliceTextbox.Size = new System.Drawing.Size(37, 20);
            this.CurrentSliceTextbox.TabIndex = 7;
            // 
            // MinSliceLabel
            // 
            this.MinSliceLabel.AutoSize = true;
            this.MinSliceLabel.Location = new System.Drawing.Point(3, 32);
            this.MinSliceLabel.Name = "MinSliceLabel";
            this.MinSliceLabel.Size = new System.Drawing.Size(24, 13);
            this.MinSliceLabel.TabIndex = 6;
            this.MinSliceLabel.Text = "Min";
            this.MinSliceLabel.Visible = false;
            // 
            // trackBar1
            // 
            this.trackBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar1.Enabled = false;
            this.trackBar1.Location = new System.Drawing.Point(0, 0);
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(512, 55);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.SegmentateCheckBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(521, 582);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(512, 55);
            this.panel3.TabIndex = 7;
            // 
            // SegmentateCheckBox
            // 
            this.SegmentateCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.SegmentateCheckBox.AutoSize = true;
            this.SegmentateCheckBox.Enabled = false;
            this.SegmentateCheckBox.Location = new System.Drawing.Point(223, 18);
            this.SegmentateCheckBox.Name = "SegmentateCheckBox";
            this.SegmentateCheckBox.Size = new System.Drawing.Size(74, 23);
            this.SegmentateCheckBox.TabIndex = 3;
            this.SegmentateCheckBox.Text = "Segmentate";
            this.SegmentateCheckBox.UseVisualStyleBackColor = true;
            this.SegmentateCheckBox.CheckedChanged += new System.EventHandler(this.SegmentateCheckBox_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.FEButton);
            this.panel4.Controls.Add(this.openButton);
            this.panel4.Controls.Add(this.ClearButton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 582);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(512, 55);
            this.panel4.TabIndex = 8;
            // 
            // FEButton
            // 
            this.FEButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.FEButton.Enabled = false;
            this.FEButton.Location = new System.Drawing.Point(423, 18);
            this.FEButton.Name = "FEButton";
            this.FEButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FEButton.Size = new System.Drawing.Size(75, 23);
            this.FEButton.TabIndex = 4;
            this.FEButton.Text = "Generate FE";
            this.FEButton.UseVisualStyleBackColor = true;
            this.FEButton.Click += new System.EventHandler(this.FEButton_Click);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(9, 17);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 23);
            this.openButton.TabIndex = 0;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Enabled = false;
            this.ClearButton.Location = new System.Drawing.Point(99, 18);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 1;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Location = new System.Drawing.Point(1039, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(512, 512);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.SigmaSpaceLabel);
            this.panel5.Controls.Add(this.SigmaColorLabel);
            this.panel5.Controls.Add(this.DiameterLabel);
            this.panel5.Controls.Add(this.SigmaSpaceTextBox);
            this.panel5.Controls.Add(this.SigmaColorTextBox);
            this.panel5.Controls.Add(this.DiameterTextBox);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(1038, 520);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(514, 57);
            this.panel5.TabIndex = 10;
            // 
            // SigmaSpaceLabel
            // 
            this.SigmaSpaceLabel.AutoSize = true;
            this.SigmaSpaceLabel.Location = new System.Drawing.Point(382, 33);
            this.SigmaSpaceLabel.Name = "SigmaSpaceLabel";
            this.SigmaSpaceLabel.Size = new System.Drawing.Size(67, 13);
            this.SigmaSpaceLabel.TabIndex = 5;
            this.SigmaSpaceLabel.Text = "SigmaSpace";
            // 
            // SigmaColorLabel
            // 
            this.SigmaColorLabel.AutoSize = true;
            this.SigmaColorLabel.Location = new System.Drawing.Point(229, 33);
            this.SigmaColorLabel.Name = "SigmaColorLabel";
            this.SigmaColorLabel.Size = new System.Drawing.Size(60, 13);
            this.SigmaColorLabel.TabIndex = 4;
            this.SigmaColorLabel.Text = "SigmaColor";
            // 
            // DiameterLabel
            // 
            this.DiameterLabel.AutoSize = true;
            this.DiameterLabel.Location = new System.Drawing.Point(73, 33);
            this.DiameterLabel.Name = "DiameterLabel";
            this.DiameterLabel.Size = new System.Drawing.Size(49, 13);
            this.DiameterLabel.TabIndex = 3;
            this.DiameterLabel.Text = "Diameter";
            // 
            // SigmaSpaceTextBox
            // 
            this.SigmaSpaceTextBox.Location = new System.Drawing.Point(367, 10);
            this.SigmaSpaceTextBox.Name = "SigmaSpaceTextBox";
            this.SigmaSpaceTextBox.Size = new System.Drawing.Size(100, 20);
            this.SigmaSpaceTextBox.TabIndex = 2;
            // 
            // SigmaColorTextBox
            // 
            this.SigmaColorTextBox.Location = new System.Drawing.Point(209, 10);
            this.SigmaColorTextBox.Name = "SigmaColorTextBox";
            this.SigmaColorTextBox.Size = new System.Drawing.Size(100, 20);
            this.SigmaColorTextBox.TabIndex = 1;
            // 
            // DiameterTextBox
            // 
            this.DiameterTextBox.Location = new System.Drawing.Point(45, 10);
            this.DiameterTextBox.Name = "DiameterTextBox";
            this.DiameterTextBox.Size = new System.Drawing.Size(100, 20);
            this.DiameterTextBox.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.FilterButton);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(1038, 581);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(514, 57);
            this.panel6.TabIndex = 11;
            // 
            // FilterButton
            // 
            this.FilterButton.Location = new System.Drawing.Point(224, 18);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(75, 23);
            this.FilterButton.TabIndex = 2;
            this.FilterButton.Text = "Filter";
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "Текстовый документ|*.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1538, 640);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "DicomViewer";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label MinDensityLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label CurrentDensityLabel;
        private System.Windows.Forms.TextBox CurrentDensityTextBox;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label CurrentSliceLabel;
        private System.Windows.Forms.TextBox CurrentSliceTextbox;
        private System.Windows.Forms.Label MinSliceLabel;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox SegmentateCheckBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button FEButton;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox SigmaSpaceTextBox;
        private System.Windows.Forms.TextBox SigmaColorTextBox;
        private System.Windows.Forms.TextBox DiameterTextBox;
        private System.Windows.Forms.Label SigmaSpaceLabel;
        private System.Windows.Forms.Label SigmaColorLabel;
        private System.Windows.Forms.Label DiameterLabel;
        private System.Windows.Forms.Label MaxDensityLabel;
        private System.Windows.Forms.Label MaxSliceLabel;
    }
}

