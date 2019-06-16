﻿using System;
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

        public Image LoadFilteredImage(string fileName, int density, int diameter, int sigmaColor, int sigmaSpace)
        {
            DicomWorkshop dcmWork = new DicomWorkshop(fileName);

            List<byte> segmPixelData = dcmWork.Segmentate(density);

            List<byte> filteredPixels = dcmWork.BilateralFilter(segmPixelData, diameter, sigmaColor, sigmaSpace);

            return dcmWork.RgbaFromPixelData(filteredPixels);
        }

        public void GenerateFEFile(string[] readFileNames, string writeFileName, int density)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            FeModel Model = new FeModel(readFileNames.Count());
            Model.ApdlCreateModel(readFileNames, writeFileName, density);
        }

        public Image LoadSegmentedImage (string fileName, int density)
        {
            DicomWorkshop dcmWork = new DicomWorkshop(fileName);

            return dcmWork.RgbaFromPixelData(dcmWork.Segmentate(density));
        }

        public Image LoadImage(string fileName)
        {
            DicomWorkshop dcmWork = new DicomWorkshop(fileName);

            return dcmWork.RgbaFromPixelData(dcmWork.dcm.pixelData);
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
            pictureBox3.Image = LoadFilteredImage(openFileDialog1.FileNames[trackBar1.Value - 1],trackBar2.Value,Int32.Parse(DiameterTextBox.Text) , Int32.Parse(SigmaColorTextBox.Text), Int32.Parse(SigmaSpaceTextBox.Text));
        }
    }

    public class FeModel
    {
        public int layersCount;

        public List<FeLayer> layers = new List<FeLayer>();

        public FeModel(int layersCount)
        {
            this.layersCount = layersCount;

            for (int i=0; i<layersCount;i++)
            {
                layers.Add(new FeLayer(i));
            }
        }

        public void ApdlCreateModel(string[] srcFileNames, string dstFileName, int density)
        {
            using (StreamWriter sw = File.CreateText(dstFileName))
            {
                ApdlEnterPreprocessor(sw);

                ApdlSetElementType(sw);

                for (int i = 0; i < layersCount; i++)
                {
                    layers[i].ApdlCreateLayer(sw,srcFileNames[i], density);
                }

                ApdlMergeNodes(sw);
                ApdlCompressNodeNumbers(sw);
            }  
        }

        public void ApdlEnterPreprocessor (StreamWriter sw)
        {
            sw.WriteLine("/PREP7");
        }

        public void ApdlSetElementType(StreamWriter sw)
        {
            sw.WriteLine("ET,1,SOLID185 ");
        }

        public void ApdlMergeNodes (StreamWriter sw)
        {
            sw.WriteLine("NUMMRG, NODE, , , , ");
        }

        public void ApdlCompressNodeNumbers (StreamWriter sw)
        {
            sw.WriteLine("NUMCMP, NODE");
        }

        public class FeLayer
        {
            public int layerNumber;
            public int elementsCount;

            public List<FinateElement> elements;

            public FeLayer(int layerNumber)
            {
                this.layerNumber = layerNumber;
            }

            public void ApdlCreateLayer(StreamWriter sw,string srcFileName, int density)
            {
                DicomWorkshop dcmWork = new DicomWorkshop(srcFileName);

                List<byte> segmPixelData = dcmWork.Segmentate(density);

                elements = dcmWork.FinateElementsFromPixelData(segmPixelData, layerNumber);
                
                int elementsId = layerNumber * dcmWork.dcm.rows * dcmWork.dcm.columns;
                
                for (int i = 0; i < elements.Count(); i++)
                {
                    elements[i].ApdlCreateElement(sw);
                }

                elementsCount = elements.Count();
            }
        }
    }

    public class FinateElement
    {
        public int feId;

        public int sliceNumber;

        public int rowNumber;
        public int columnNumber;

        public double rowSpacing;
        public double columnSpacing;
        public double sliceThickness;

        public double value;

        public struct Coords
        {
            public double x;
            public double y;
            public double z;
        }

        public Coords center = new Coords();

        public class Node
        {
            public int id;
            public int elementId;

            public Coords coordinates;

            public Node(int elementId, int id)
            {
                this.elementId = elementId;
                this.id = id;
            }

            public void ApdlCreateNode (StreamWriter sw)
            {
                sw.WriteLine($"N,{ id + 1}," +
                             $"{coordinates.x}," +
                             $"{coordinates.y}," +
                             $"{coordinates.z},,,,");
            }
        }

        public Node[] nodes = new Node[8];

        public FinateElement(int feId, int sliceNumber, int rowNumber, int columnNumber, double sliceThickness, double rowSpacing, double columnSpacing, double value)
        {
            this.feId = feId;
            this.sliceNumber = sliceNumber;
            this.rowNumber = rowNumber;
            this.columnNumber = columnNumber;
            this.sliceThickness = sliceThickness;
            this.rowSpacing = rowSpacing;
            this.columnSpacing = columnSpacing;
            this.value = value;

            SetNodes();
        }

        public void SetNodes()
        {
            center.x = columnSpacing / 2 + columnNumber*columnSpacing;
            center.y = -rowSpacing / 2 - rowNumber * rowSpacing;
            center.z = sliceThickness/2 + sliceNumber*sliceThickness;
            
            for (int i=0;i<nodes.Count();i++)
            {
                nodes[i] = new Node(feId, feId * 8 + i);
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

        public void ApdlCreateElement(StreamWriter sw)
        {
            for (int i=0;i<nodes.Count();i++)
            {
                nodes[i].ApdlCreateNode(sw);
            }

            sw.WriteLine($"EN,{feId + 1}," +
                            $"{nodes[0].id + 1}," +
                            $"{nodes[1].id + 1}," +
                            $"{nodes[2].id + 1}," +
                            $"{nodes[3].id + 1}," +
                            $"{nodes[4].id + 1}," +
                            $"{nodes[5].id + 1}," +
                            $"{nodes[6].id + 1}," +
                            $"{nodes[7].id + 1}");
        }
    }

    public class DicomEntity
    {
        public EvilDICOM.Core.DICOMObject dcm;

        public ushort bitsStored;
        public double intercept;
        public double slope;
        public ushort rows;
        public ushort columns;
        public double window;
        public double level;

        public double rowSpacing;
        public double columnSpacing;

        public double sliceThickness;

        public List<byte> pixelData;

        public DicomEntity(string FileName)
        {
            dcm = EvilDICOM.Core.DICOMObject.Read(FileName);

            bitsStored = (ushort)dcm.FindFirst(TagHelper.BitsStored).DData;
            intercept = (double)dcm.FindFirst(TagHelper.RescaleIntercept).DData;
            slope = (double)dcm.FindFirst(TagHelper.RescaleSlope).DData;
            rows = (ushort)dcm.FindFirst(TagHelper.Rows).DData;
            columns = (ushort)dcm.FindFirst(TagHelper.Columns).DData;
            window = (double)dcm.FindFirst(TagHelper.WindowWidth).DData;
            level = (double)dcm.FindFirst(TagHelper.WindowCenter).DData;

            List<double> pixelSpacings = (List<double>)dcm.FindFirst(TagHelper.PixelSpacing).DData_;
            rowSpacing = pixelSpacings[0];
            columnSpacing = pixelSpacings[1];

            sliceThickness = (double)dcm.FindFirst(TagHelper.SliceThickness).DData;

            pixelData = (List<byte>)dcm.FindFirst(TagHelper.PixelData).DData_;
        }
    }

    public class DicomWorkshop
    {
        public DicomEntity dcm;

        public DicomWorkshop(string fileName)
        {
            dcm = new DicomEntity(fileName);
        }

        public List<byte> Segmentate(int density)
        {
            int size = dcm.pixelData.Count;
            List<byte> segmPixelData = new List<byte>();//rgba
            double maxval = Math.Pow(2, dcm.bitsStored);

            for (int i = 0; i < dcm.pixelData.Count; i += 2)
            {
                short gray = (short)((short)(dcm.pixelData[i]) + (short)(dcm.pixelData[i + 1] << 8));
                double valgray = gray;

                valgray = dcm.slope * valgray + dcm.intercept;//modality lut

                //This is  the window level algorithm
                double half = dcm.window / 2.0;

                if (valgray <= density)
                {
                    segmPixelData.Insert(i, (byte)0);
                    segmPixelData.Insert(i + 1, (byte)0);
                }
                else
                {
                    segmPixelData.Insert(i, (byte)dcm.pixelData[i]);
                    segmPixelData.Insert(i + 1, (byte)dcm.pixelData[i + 1]);
                }
            }
            return segmPixelData;
        }

        public Bitmap RgbaFromPixelData(List<byte> pixelData)
        {
            int index = 0;
            byte[] outPixelData = new byte[dcm.rows * dcm.columns * 4];//rgba
            double maxval = Math.Pow(2, dcm.bitsStored);

            for (int i = 0; i < pixelData.Count; i += 2)
            {
                short gray = (short)((short)(pixelData[i]) + (short)(pixelData[i + 1] << 8));
                double valgray = gray;

                valgray = dcm.slope * valgray + dcm.intercept;//modality lut

                //This is  the window level algorithm
                double half = dcm.window / 2.0;

                if (valgray <= dcm.level - half)
                    valgray = 0;
                else if (valgray >= dcm.level + half)
                    valgray = 255;
                else
                    valgray = ((valgray - (dcm.level - half)) / dcm.window) * 255;

                outPixelData[index] = (byte)valgray;
                outPixelData[index + 1] = (byte)valgray;
                outPixelData[index + 2] = (byte)valgray;
                outPixelData[index + 3] = 255;

                index += 4;
            }
            return BmpFromRgba(outPixelData);
        }

        private Bitmap BmpFromRgba(byte[] arr)
        {
            var output = new Bitmap(dcm.columns, dcm.rows);
            var rect = new Rectangle(0, 0, dcm.columns, dcm.rows);
            var bmpData = output.LockBits(rect,
                ImageLockMode.ReadWrite, output.PixelFormat);
            var ptr = bmpData.Scan0;
            Marshal.Copy(arr, 0, ptr, arr.Length);
            output.UnlockBits(bmpData);
            return output;
        }

        public List<byte> BilateralFilter (List<byte> pixelData, int diameter, int sigmaColor, int sigmaSpace)
        {
            byte[] srcBytes = new byte[pixelData.Count];
            srcBytes = pixelData.ToArray();

            OpenCvSharp.Mat src = new Mat(dcm.rows, dcm.columns * 2, MatType.CV_8UC1);
            OpenCvSharp.Mat dst = new Mat(dcm.rows, dcm.columns * 2, MatType.CV_8UC1);

            src.SetArray(0, 0, srcBytes);

            Cv2.BilateralFilter(src, dst, diameter, sigmaColor, sigmaSpace, BorderTypes.Default);

            byte[] dstBytes = new byte[pixelData.Count];

            dst.GetArray(0, 0, dstBytes);

            List<byte> filteredPixels = new List<byte>(dstBytes);

            return filteredPixels;
        }

        public List<FinateElement> FinateElementsFromPixelData (List<byte> pixelData, int sliceIndex)
        {
            List<FinateElement> elements = new List<FinateElement>();
            int elementsId = sliceIndex * dcm.rows *dcm.columns;

            for (int i = 0; i < pixelData.Count; i += 2)
            {
                short gray = (short)((short)(pixelData[i]) + (short)(pixelData[i + 1] << 8));
                double valgray = gray;

                if (valgray != 0)
                {
                    elements.Add(new FinateElement(elementsId, sliceIndex, (i / 2) / dcm.rows, (i / 2) % dcm.rows, dcm.sliceThickness,
                    dcm.rowSpacing, dcm.columnSpacing, valgray));
                  
                    elementsId++;
                }
            }
            return elements;
        }

    }
    
}

