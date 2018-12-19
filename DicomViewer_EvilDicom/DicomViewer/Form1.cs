using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EvilDICOM.Core;
using EvilDICOM.Core.Helpers;

namespace DicomViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        

        public Image LoadSegmentedImage (string fileName, int density)
        {
            var dcm = EvilDICOM.Core.DICOMObject.Read(fileName);
            string photo = dcm.FindFirst(TagHelper.PhotometricInterpretation).DData.ToString();
            ushort bitsAllocated = (ushort)dcm.FindFirst(TagHelper.BitsAllocated).DData;
            ushort highBit = (ushort)dcm.FindFirst(TagHelper.HighBit).DData;
            ushort bitsStored = (ushort)dcm.FindFirst(TagHelper.BitsStored).DData;
            double intercept = (double)dcm.FindFirst(TagHelper.RescaleIntercept).DData;
            double slope = (double)dcm.FindFirst(TagHelper.RescaleSlope).DData;
            ushort rows = (ushort)dcm.FindFirst(TagHelper.Rows).DData;
            ushort colums = (ushort)dcm.FindFirst(TagHelper.Columns).DData;
            ushort pixelRepresentation = (ushort)dcm.FindFirst(TagHelper.PixelRepresentation).DData;
            List<byte> pixelData = (List<byte>)dcm.FindFirst(TagHelper.PixelData).DData_;
            double window = (double)dcm.FindFirst(TagHelper.WindowWidth).DData;
            double level = (double)dcm.FindFirst(TagHelper.WindowCenter).DData;

            if (!photo.Contains("MONOCHROME"))//just works for gray images
                return null;

            int index = 0;
            byte[] outPixelData = new byte[rows * colums * 4];//rgba
            //ushort mask = (ushort)(ushort.MaxValue >> (bitsAllocated - bitsStored));//>> = /(2^x)
            double maxval = Math.Pow(2, bitsStored);//2^12 = 4096

            for (int i = 0; i < pixelData.Count; i += 2)
            {
                ushort gray = (ushort)((ushort)(pixelData[i]) + (ushort)(pixelData[i + 1] << 8));//<< = *2^8 , count the value from 12 bits (2^12 = 4056)
                //double valgray = gray & mask;//remove not used bits
                double valgray = gray;

                if (pixelRepresentation == 1)// the last bit is the sign, apply a2 complement
                {
                    if (valgray > (maxval / 2))
                        valgray = (valgray - maxval);

                }

                valgray = slope * valgray + intercept;//modality lut


                //This is  the window level algorithm
                double half = ((window - 1) / 2.0) - 0.5;

                if (valgray <= level - half || valgray < density)
                    valgray = 0;
                else if (valgray >= level + half && valgray >= density)
                    valgray = 255;
                else
                    valgray = ((valgray - (level - 0.5)) / (window - 1) + 0.5) * 255;

                outPixelData[index] = (byte)valgray;
                outPixelData[index + 1] = (byte)valgray;
                outPixelData[index + 2] = (byte)valgray;
                outPixelData[index + 3] = 255;

                index += 4;
            }

            Image newimage = this.ImageFromRgbaArray(outPixelData, colums, rows);
            return newimage;
        }

        public Image LoadImage(string fileName)
        {
            var dcm = EvilDICOM.Core.DICOMObject.Read(fileName);
            string photo = dcm.FindFirst(TagHelper.PhotometricInterpretation).DData.ToString();
            ushort bitsAllocated = (ushort)dcm.FindFirst(TagHelper.BitsAllocated).DData;
            ushort highBit = (ushort)dcm.FindFirst(TagHelper.HighBit).DData;
            ushort bitsStored = (ushort)dcm.FindFirst(TagHelper.BitsStored).DData;
            double intercept = (double)dcm.FindFirst(TagHelper.RescaleIntercept).DData;
            double slope = (double)dcm.FindFirst(TagHelper.RescaleSlope).DData;
            ushort rows = (ushort)dcm.FindFirst(TagHelper.Rows).DData;
            ushort colums = (ushort)dcm.FindFirst(TagHelper.Columns).DData;
            ushort pixelRepresentation = (ushort)dcm.FindFirst(TagHelper.PixelRepresentation).DData;
            List<byte> pixelData = (List<byte>)dcm.FindFirst(TagHelper.PixelData).DData_;
            double window = (double)dcm.FindFirst(TagHelper.WindowWidth).DData;
            double level = (double)dcm.FindFirst(TagHelper.WindowCenter).DData;

            if (!photo.Contains("MONOCHROME"))//just works for gray images
                return null;

            int index = 0;
            byte[] outPixelData = new byte[rows * colums * 4];//rgba
            ushort mask = (ushort)(ushort.MaxValue >> (bitsAllocated - bitsStored));
            double maxval = Math.Pow(2, bitsStored);

            for (int i = 0; i < pixelData.Count; i += 2)
            {
                ushort gray = (ushort)((ushort)(pixelData[i]) + (ushort)(pixelData[i + 1] << 8));//<< = *2^8 , count the value from 12 bits (2^12 = 4056)
                double valgray = gray & mask;//remove not used bits

                if (pixelRepresentation == 1)// the last bit is the sign, apply a2 complement
                {
                    if (valgray > (maxval / 2))
                        valgray = (valgray - maxval);

                }

                valgray = slope * valgray + intercept;//modality lut


                //This is  the window level algorithm
                double half = ((window - 1) / 2.0) - 0.5;

                if (valgray <= level - half)
                    valgray = 0;
                else if (valgray >= level + half)
                    valgray = 255;
                else
                    valgray = ((valgray - (level - 0.5)) / (window - 1) + 0.5) * 255;

                outPixelData[index] = (byte)valgray;
                outPixelData[index + 1] = (byte)valgray;
                outPixelData[index + 2] = (byte)valgray;
                outPixelData[index + 3] = 255;

                index += 4;
            }

            Image newimage = this.ImageFromRgbaArray(outPixelData, colums, rows);
            return newimage;
        }

        public Image ImageFromRgbaArray(byte[] arr, int width, int height)
        {
            var output = new Bitmap(width, height);
            var rect = new Rectangle(0, 0, width, height);
            var bmpData = output.LockBits(rect,
                ImageLockMode.ReadWrite, output.PixelFormat);
            var ptr = bmpData.Scan0;
            Marshal.Copy(arr, 0, ptr, arr.Length);
            output.UnlockBits(bmpData);
            return output;
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            // Show the Open File dialog. If the user clicks OK, load the
            // picture that the user chose.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var dcm = DICOMObject.Read(openFileDialog1.FileNames[0]);
      
                trackBar1.Enabled = true;
                trackBar1.Maximum = openFileDialog1.FileNames.Length;
                trackBar1.Minimum = 1;

                MinSliceLabel.Text = Convert.ToString(1);
                MinSliceLabel.Visible = true;

                MaxSliceLabel.Text = Convert.ToString(openFileDialog1.FileNames.Length);
                MaxSliceLabel.Visible = true;


                double window = (double)dcm.FindFirst(TagHelper.WindowWidth).DData;
                double level = (double)dcm.FindFirst(TagHelper.WindowCenter).DData;
                trackBar2.Minimum = Convert.ToInt32(level - window/2);
                trackBar2.Maximum = Convert.ToInt32(level + window/2);
                trackBar2.Enabled = true;
                trackBar2.Value = trackBar2.Minimum;

                MinDensityLabel.Text = Convert.ToString(trackBar2.Minimum);
                MinDensityLabel.Visible = true;
                MaxDensityLabel.Text = Convert.ToString(trackBar2.Maximum);
                MaxDensityLabel.Visible = true;

                SegmentateCheckBox.Enabled = true;

                ClearButton.Enabled = true;

                //SaveButton.Enabled = true;

                pictureBox1.Image = LoadImage(openFileDialog1.FileNames[trackBar1.Value - 1]);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            pictureBox1.Image = LoadImage(openFileDialog1.FileNames[trackBar1.Value - 1]);
            CurrentSliceTextbox.Text = Convert.ToString(trackBar1.Value);

            if (SegmentateCheckBox.Checked == true)
            {
                pictureBox2.Image = LoadSegmentedImage(openFileDialog1.FileNames[trackBar1.Value - 1], trackBar2.Value - 1);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox2.Image = null;

            trackBar1.Enabled = false;
            trackBar1.Minimum = 1;
            trackBar1.Maximum = 10;
            trackBar1.Value = 1;

            CurrentSliceTextbox.Text = null;
            CurrentSliceTextbox.Enabled = false;

            MinSliceLabel.Visible = false;
            MaxSliceLabel.Visible = false;

            trackBar2.Enabled = false;
            trackBar2.Minimum = 1;
            trackBar2.Maximum = 10;
            trackBar2.Value = 1;

            CurrentDensityTextBox.Text = null;
            CurrentDensityTextBox.Enabled = false;

            MinDensityLabel.Visible = false;
            MaxDensityLabel.Visible = false;

            SegmentateCheckBox.Enabled = false;
            SegmentateCheckBox.Checked = false;

            ClearButton.Enabled = false;

            //SaveButton.Enabled = false;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SegmentateCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            if (SegmentateCheckBox.Checked == true)
            {
                pictureBox2.Image = LoadSegmentedImage(openFileDialog1.FileNames[trackBar1.Value - 1], trackBar2.Value);

                CurrentDensityTextBox.Text = Convert.ToString(trackBar2.Value);
                CurrentDensityTextBox.Enabled = true;
            }
            else
                pictureBox2.Image = null;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            if (SegmentateCheckBox.Checked == true)
            {
                pictureBox2.Image = LoadSegmentedImage(openFileDialog1.FileNames[trackBar1.Value - 1], trackBar2.Value);
                
            }
            CurrentDensityTextBox.Text = Convert.ToString(trackBar2.Value);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
          
        }

        [DllImport("TestLib.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern double Add(double a, double b);

        private void ExternalButton_Click(object sender, EventArgs e)
        {
            ExternalTextBox.Enabled = true;

            var x = Add(25, 17);
            ExternalTextBox.Text = x.ToString();
        }
    }
}
