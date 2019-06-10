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
using OpenCvSharp;

namespace DicomViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        /*public Image FilterImage(string fileName)
        {


            return ;
        }*/

        public void GenerateFEFile(string[] readFileNames, string writeFileName, int density)
        {
            StreamWriter sw = new StreamWriter(writeFileName);
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            sw.WriteLine("/PREP7");

            int sliceIndex = 0;

            for (; sliceIndex < readFileNames.Length;sliceIndex++)
            {
                var dcm = EvilDICOM.Core.DICOMObject.Read(readFileNames[sliceIndex]);
                List<byte> pixelData = (List<byte>)dcm.FindFirst(TagHelper.PixelData).DData_;

                ushort bitsStored = (ushort)dcm.FindFirst(TagHelper.BitsStored).DData;
                double intercept = (double)dcm.FindFirst(TagHelper.RescaleIntercept).DData;
                double slope = (double)dcm.FindFirst(TagHelper.RescaleSlope).DData;
                ushort rows = (ushort)dcm.FindFirst(TagHelper.Rows).DData;
                ushort colums = (ushort)dcm.FindFirst(TagHelper.Columns).DData;
                double window = (double)dcm.FindFirst(TagHelper.WindowWidth).DData;
                double level = (double)dcm.FindFirst(TagHelper.WindowCenter).DData;

                List<double> pixelSpacings = (List<double>)dcm.FindFirst(TagHelper.PixelSpacing).DData_;
                double rowSpacing = pixelSpacings[0];
                double columnSpacing = pixelSpacings[1];

                double sliceThickness = (double)dcm.FindFirst(TagHelper.SliceThickness).DData;

                //sliceThickness = columnSpacing;

                int size = pixelData.Count;
                List<double> segmPixelData = new List<double>();//rgba
                double maxval = Math.Pow(2, bitsStored);

                int index = 0;
                for (int i = 0; i < pixelData.Count; i += 2)
                {
                    short gray = (short)((short)(pixelData[i]) + (short)(pixelData[i + 1] << 8));
                    double valgray = gray;

                    valgray = slope * valgray + intercept;//modality lut

                    //This is  the window level algorithm
                    double half = window / 2.0;

                    if (valgray <= density)
                    {
                        //segmPixelData.Insert(i, (byte)0);
                        //segmPixelData.Insert(i + 1, (byte)0);
                        segmPixelData.Insert(index, 0.0);
                    }
                    else
                    {
                        //segmPixelData.Insert(i, (byte)pixelData[i]);
                        //segmPixelData.Insert(i + 1, (byte)pixelData[i + 1]);
                        segmPixelData.Insert(index, valgray);
                    }
                    index++;
                }

                Element[] elements = new Element[rows * colums];
                int elementsId = sliceIndex * rows* colums;
                //int nodesID = 0;

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < colums; j++)
                    {
                        double valgray = segmPixelData[rows * i + j];
                        //valgray = slope * valgray + intercept;

                        double half = window / 2.0;

                        if (valgray <= level - half)
                            valgray = 0;
                        else if (valgray >= level + half)
                            valgray = maxval;

                        elements[rows * i + j] = new Element();
                        var currentElement = elements[rows * i + j];

                        currentElement.value = valgray;

                        currentElement.sliceNumber = sliceIndex;

                        currentElement.rowNumber = i;
                        currentElement.columnNumber = j;
                        currentElement.rowSpacing = rowSpacing;
                        currentElement.columnSpacing = columnSpacing;
                        currentElement.sliceThickness = sliceThickness;
                        if (valgray != 0.0)
                        {
                            currentElement.FEid = elementsId;
                            elementsId++;
                            currentElement.SetNodes();
                        }
                    }
                }

                /*
                StreamWriter sw = new StreamWriter(writeFileName);
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                sw.WriteLine("/PREP7");
                */

                for (int i = 0; i < elements.Count(); i++)
                {
                    if (elements[i].value != 0.0)
                    {
                        for (int j = 0; j < elements[i].nodes.Count(); j++)
                        {
                            sw.WriteLine($"N,{ elements[i].nodes[j].id + 1},{elements[i].nodes[j].coordinates.x},{elements[i].nodes[j].coordinates.y},{elements[i].nodes[j].coordinates.z},,,,");
                        }
                    }

                }
                sw.WriteLine(" ");
                sw.WriteLine("ET,1,SOLID185 ");
                sw.WriteLine(" ");
                for (int i = 0; i < elements.Count(); i++)
                {
                    if (elements[i].value != 0.0)
                    {
                        sw.WriteLine($"FLST,3,8,1");
                        for (int j = 0; j < elements[i].nodes.Count(); j++)
                        {
                            sw.WriteLine($"FITEM,3,{elements[i].nodes[j].id + 1}");
                        }
                        sw.WriteLine($"EN,{elements[i].FEid + 1},P51X");
                        //sw.WriteLine(" ");
                    }
                }
                 
            }
            sw.Close();
        }

        public Image LoadSegmentedImage (string fileName, int density)
        {
            var dcm = EvilDICOM.Core.DICOMObject.Read(fileName);
            List<byte> pixelData = (List<byte>)dcm.FindFirst(TagHelper.PixelData).DData_;

            ushort bitsStored = (ushort)dcm.FindFirst(TagHelper.BitsStored).DData;
            double intercept = (double)dcm.FindFirst(TagHelper.RescaleIntercept).DData;
            double slope = (double)dcm.FindFirst(TagHelper.RescaleSlope).DData;
            ushort rows = (ushort)dcm.FindFirst(TagHelper.Rows).DData;
            ushort colums = (ushort)dcm.FindFirst(TagHelper.Columns).DData;
            double window = (double)dcm.FindFirst(TagHelper.WindowWidth).DData;
            double level = (double)dcm.FindFirst(TagHelper.WindowCenter).DData;
            
            int size = pixelData.Count;
            List<byte> segmPixelData = new List<byte>();//rgba
            double maxval = Math.Pow(2, bitsStored);

            for (int i = 0; i < pixelData.Count; i += 2)
            {
                short gray = (short)((short)(pixelData[i]) + (short)(pixelData[i + 1] << 8));
                double valgray = gray;

                valgray = slope * valgray + intercept;//modality lut

                //This is  the window level algorithm
                double half = window / 2.0;

                if (valgray <= density)
                {
                    segmPixelData.Insert(i,(byte)0);
                    segmPixelData.Insert(i+1, (byte)0);
                }
                else
                {
                    segmPixelData.Insert(i, (byte)pixelData[i]);
                    segmPixelData.Insert(i + 1, (byte)pixelData[i+1]);
                }
            }
            return RgbaFromPixelData(segmPixelData, colums, rows, bitsStored, slope, intercept, window, level);
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
            ushort columns = (ushort)dcm.FindFirst(TagHelper.Columns).DData;
            ushort pixelRepresentation = (ushort)dcm.FindFirst(TagHelper.PixelRepresentation).DData;
            List<byte> pixelData = (List<byte>)dcm.FindFirst(TagHelper.PixelData).DData_;
            double window = (double)dcm.FindFirst(TagHelper.WindowWidth).DData;
            double level = (double)dcm.FindFirst(TagHelper.WindowCenter).DData;

            if (!photo.Contains("MONOCHROME"))//just works for gray images
                return null;

            return RgbaFromPixelData(pixelData, columns, rows, bitsStored, slope, intercept, window, level);
        }

        public Bitmap RgbaFromPixelData (List<byte> pixelData, int columns, int rows, int bitsStored, double slope, double intercept, double window, double level)
        {
            int index = 0;
            byte[] outPixelData = new byte[rows * columns * 4];//rgba
            double maxval = Math.Pow(2, bitsStored);

            for (int i = 0; i < pixelData.Count; i += 2)
            {
                short gray = (short)((short)(pixelData[i]) + (short)(pixelData[i+1] << 8));
                double valgray = gray;

                valgray = slope * valgray + intercept;//modality lut

                //This is  the window level algorithm
                double half = window / 2.0;

                if (valgray <= level - half)
                    valgray = 0;
                else if (valgray >= level + half)
                    valgray = 255;
                else
                    valgray = ((valgray - (level - half)) / window) * 255;

                outPixelData[index] = (byte)valgray;
                outPixelData[index + 1] = (byte)valgray;
                outPixelData[index + 2] = (byte)valgray;
                outPixelData[index + 3] = 255;

                index += 4;
            }

            return BmpFromRgba(outPixelData, columns, rows);
        }

        public Bitmap BmpFromRgba(byte[] arr, int width, int height)
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
                //pictureBox2.Image = LoadSegmentedImage(openFileDialog1.FileNames[trackBar1.Value - 1], trackBar2.Value);
                pictureBox2.Image = LoadSegmentedImage(openFileDialog1.FileNames[trackBar1.Value - 1], trackBar2.Value);

                /*CurrentDensityTextBox.Text = Convert.ToString(trackBar2.Value);
                CurrentDensityTextBox.Enabled = true;
                SegmentedArray(openFileDialog1.FileNames[trackBar1.Value - 1], trackBar2.Value);*/

                FEButton.Enabled = true;
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

        private void FEButton_Click(object sender, EventArgs e)
        {
            if (SegmentateCheckBox.Checked == true)
            {
                CurrentDensityTextBox.Text = Convert.ToString(trackBar2.Value);
                CurrentDensityTextBox.Enabled = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    //GenerateFEFile(openFileDialog1.FileNames[trackBar1.Value - 1], saveFileDialog1.FileName, trackBar2.Value);  
                    GenerateFEFile(openFileDialog1.FileNames, saveFileDialog1.FileName, trackBar2.Value);
            }
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {

        }
    }

    public class Element
    {
        public int FEid;

        public int sliceNumber;

        public int rowNumber;
        public int columnNumber;

        public double rowSpacing;
        public double columnSpacing;
        public double sliceThickness;

        public struct coords
        {
            public double x;
            public double y;
            public double z;

            public coords (int x, int y, int z)
            {
                this.x = x;
                this.y = y;
                this.z = z;
            }
        }

        public coords center = new coords();
        //public coords[] Nodes = new coords[8];

        public struct node
        {
            public int id;
            public int ElementId;
            public coords coordinates;
        }

        public node[] nodes = new node[8];

        public void SetNodes()
        {
            center.x = columnSpacing / 2 + columnNumber*columnSpacing;
            center.y = -rowSpacing / 2 - rowNumber * rowSpacing;
            center.z = sliceThickness/2 + sliceNumber*sliceThickness;
            
            for (int i=0;i<nodes.Count();i++)
            {
                nodes[i].ElementId = FEid;
                nodes[i].id = FEid * 8+i;
            }

            nodes[0].coordinates.x = center.x - columnSpacing / 2;
            nodes[0].coordinates.y = center.y - rowSpacing / 2;
            nodes[0].coordinates.z = center.z - sliceThickness/2;
            
            nodes[1].coordinates.x = center.x + columnSpacing / 2;
            nodes[1].coordinates.y = center.y - rowSpacing / 2;
            nodes[1].coordinates.z = center.z - sliceThickness / 2;
            
            nodes[2].coordinates.x = center.x + columnSpacing / 2;
            nodes[2].coordinates.y = center.y + rowSpacing / 2;
            nodes[2].coordinates.z = center.z - sliceThickness / 2;
            
            nodes[3].coordinates.x = center.x - columnSpacing / 2;
            nodes[3].coordinates.y = center.y + rowSpacing / 2;
            nodes[3].coordinates.z = center.z - sliceThickness / 2;
           
            nodes[4].coordinates.x = center.x - columnSpacing / 2;
            nodes[4].coordinates.y = center.y - rowSpacing / 2;
            nodes[4].coordinates.z = center.z + sliceThickness / 2;
            
            nodes[5].coordinates.x = center.x + columnSpacing / 2;
            nodes[5].coordinates.y = center.y - rowSpacing / 2;
            nodes[5].coordinates.z = center.z + sliceThickness / 2;
           
            nodes[6].coordinates.x = center.x + columnSpacing / 2;
            nodes[6].coordinates.y = center.y + rowSpacing / 2;
            nodes[6].coordinates.z = center.z + sliceThickness / 2;
          
            nodes[7].coordinates.x = center.x - columnSpacing / 2;
            nodes[7].coordinates.y = center.y + rowSpacing / 2;
            nodes[7].coordinates.z = center.z + sliceThickness / 2;
           
        }

        public double value;
    }
}

