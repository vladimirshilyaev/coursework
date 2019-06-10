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
            this.CurrentDensityLabel = new System.Windows.Forms.Label();
            this.CurrentDensityTextBox = new System.Windows.Forms.TextBox();
            this.MinDensityLabel = new System.Windows.Forms.Label();
            this.MaxDensityLabel = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CurrentSliceLabel = new System.Windows.Forms.Label();
            this.CurrentSliceTextbox = new System.Windows.Forms.TextBox();
            this.MinSliceLabel = new System.Windows.Forms.Label();
            this.MaxSliceLabel = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.FEButton = new System.Windows.Forms.Button();
            this.SegmentateCheckBox = new System.Windows.Forms.CheckBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.FilterButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
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
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.7907F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.2093F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1256, 536);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(412, 433);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(421, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(412, 433);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CurrentDensityLabel);
            this.panel1.Controls.Add(this.CurrentDensityTextBox);
            this.panel1.Controls.Add(this.MinDensityLabel);
            this.panel1.Controls.Add(this.MaxDensityLabel);
            this.panel1.Controls.Add(this.trackBar2);
            this.panel1.Location = new System.Drawing.Point(421, 442);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 55);
            this.panel1.TabIndex = 5;
            // 
            // CurrentDensityLabel
            // 
            this.CurrentDensityLabel.AutoSize = true;
            this.CurrentDensityLabel.Location = new System.Drawing.Point(173, 32);
            this.CurrentDensityLabel.Name = "CurrentDensityLabel";
            this.CurrentDensityLabel.Size = new System.Drawing.Size(79, 13);
            this.CurrentDensityLabel.TabIndex = 4;
            this.CurrentDensityLabel.Text = "Current Density";
            // 
            // CurrentDensityTextBox
            // 
            this.CurrentDensityTextBox.Enabled = false;
            this.CurrentDensityTextBox.Location = new System.Drawing.Point(258, 29);
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
            // trackBar2
            // 
            this.trackBar2.Dock = System.Windows.Forms.DockStyle.Top;
            this.trackBar2.Enabled = false;
            this.trackBar2.Location = new System.Drawing.Point(0, 0);
            this.trackBar2.Minimum = 1;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(410, 45);
            this.trackBar2.TabIndex = 0;
            this.trackBar2.Value = 1;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CurrentSliceLabel);
            this.panel2.Controls.Add(this.CurrentSliceTextbox);
            this.panel2.Controls.Add(this.MinSliceLabel);
            this.panel2.Controls.Add(this.MaxSliceLabel);
            this.panel2.Controls.Add(this.trackBar1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 442);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(412, 55);
            this.panel2.TabIndex = 6;
            // 
            // CurrentSliceLabel
            // 
            this.CurrentSliceLabel.AutoSize = true;
            this.CurrentSliceLabel.Location = new System.Drawing.Point(173, 32);
            this.CurrentSliceLabel.Name = "CurrentSliceLabel";
            this.CurrentSliceLabel.Size = new System.Drawing.Size(70, 13);
            this.CurrentSliceLabel.TabIndex = 8;
            this.CurrentSliceLabel.Text = "Current Slice:";
            // 
            // CurrentSliceTextbox
            // 
            this.CurrentSliceTextbox.Enabled = false;
            this.CurrentSliceTextbox.Location = new System.Drawing.Point(249, 29);
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
            // trackBar1
            // 
            this.trackBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.trackBar1.Enabled = false;
            this.trackBar1.Location = new System.Drawing.Point(0, 0);
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(412, 45);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.FEButton);
            this.panel3.Controls.Add(this.SegmentateCheckBox);
            this.panel3.Controls.Add(this.CloseButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(421, 503);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(412, 30);
            this.panel3.TabIndex = 7;
            // 
            // FEButton
            // 
            this.FEButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.FEButton.Enabled = false;
            this.FEButton.Location = new System.Drawing.Point(83, 4);
            this.FEButton.Name = "FEButton";
            this.FEButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FEButton.Size = new System.Drawing.Size(75, 23);
            this.FEButton.TabIndex = 4;
            this.FEButton.Text = "Generate FE";
            this.FEButton.UseVisualStyleBackColor = true;
            this.FEButton.Click += new System.EventHandler(this.FEButton_Click);
            // 
            // SegmentateCheckBox
            // 
            this.SegmentateCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.SegmentateCheckBox.AutoSize = true;
            this.SegmentateCheckBox.Enabled = false;
            this.SegmentateCheckBox.Location = new System.Drawing.Point(3, 4);
            this.SegmentateCheckBox.Name = "SegmentateCheckBox";
            this.SegmentateCheckBox.Size = new System.Drawing.Size(74, 23);
            this.SegmentateCheckBox.TabIndex = 3;
            this.SegmentateCheckBox.Text = "Segmentate";
            this.SegmentateCheckBox.UseVisualStyleBackColor = true;
            this.SegmentateCheckBox.CheckedChanged += new System.EventHandler(this.SegmentateCheckBox_CheckedChanged);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CloseButton.Location = new System.Drawing.Point(334, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "Exit";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.openButton);
            this.panel4.Controls.Add(this.ClearButton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 503);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(412, 30);
            this.panel4.TabIndex = 8;
            // 
            // FilterButton
            // 
            this.FilterButton.Enabled = false;
            this.FilterButton.Location = new System.Drawing.Point(183, 5);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(75, 23);
            this.FilterButton.TabIndex = 2;
            this.FilterButton.Text = "Filter";
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(3, 4);
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
            this.ClearButton.Location = new System.Drawing.Point(84, 4);
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
            this.pictureBox3.Location = new System.Drawing.Point(838, 2);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(416, 435);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(838, 441);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(416, 57);
            this.panel5.TabIndex = 10;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.FilterButton);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(838, 502);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(416, 32);
            this.panel6.TabIndex = 11;
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
            this.ClientSize = new System.Drawing.Size(1256, 536);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "DicomViewer";
            this.tableLayoutPanel1.ResumeLayout(false);
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
        private System.Windows.Forms.Label MaxDensityLabel;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label CurrentSliceLabel;
        private System.Windows.Forms.TextBox CurrentSliceTextbox;
        private System.Windows.Forms.Label MinSliceLabel;
        private System.Windows.Forms.Label MaxSliceLabel;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox SegmentateCheckBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button FEButton;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
    }
}

