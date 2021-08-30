using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroSet_UI.Forms;
using Pfim;

namespace foxhole_intelarty
{
    public partial class Form1 : MetroSetForm
    {
        DataTable mapTable = new DataTable();

        Graphics graphics;

        Point myPos = Point.Empty;
        Point enemyPos = Point.Empty;

        Pen greenPen = new Pen(Color.LightGreen, 2);
        Pen redPen = new Pen(Color.Red, 2);
        Pen blackPen1 = new Pen(Color.FromArgb(75,0,0,0), 1);
        Pen blackPen2 = new Pen(Color.FromArgb(140, 0, 0, 0), 2);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            findMapTiles();
        }

        private void findMapTiles()
        {

            mapTileCmb.DataSource = mapTable;
            mapTable.Columns.Add("name");
            mapTable.Columns.Add("location");
            mapTileCmb.ValueMember = "location";
            mapTileCmb.DisplayMember = "name";

            Assembly myAssembly = Assembly.GetExecutingAssembly();
            string[] resources = myAssembly.GetManifestResourceNames().Where(str => str.Contains(".TGA")).ToArray();
            string imgResourceDir = "foxhole_intelarty.warapi.Images.Maps.";


            foreach (string resource in resources)
            {
                Debug.WriteLine(resource);


                string filename = resource.Replace(imgResourceDir, "");
                Regex newPattern = new Regex("World");

                if (!newPattern.IsMatch(filename))
                {
                    DataRow newrow = mapTable.NewRow();
                    newrow["location"] = resource;
                    string name = Regex.Replace(filename, "Hex|.TGA|Map", "");
                    name = Regex.Replace(name, "([a-z])([A-Z])", "$1 $2");
                    newrow["name"] = name;
                    mapTable.Rows.Add(newrow);
                }
            }
            updateImg();
        }

        private void updateImg()
        {
            int curIndex = mapTileCmb.SelectedIndex;

            Debug.WriteLine(mapTable.Rows[mapTileCmb.SelectedIndex][0].ToString());

            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream(mapTable.Rows[mapTileCmb.SelectedIndex][1].ToString());
            
            var img = Pfim.Pfim.FromStream(myStream);
            var data = Marshal.UnsafeAddrOfPinnedArrayElement(img.Data, 0);
            var bitmap = new Bitmap(img.Width, img.Height, img.Stride, System.Drawing.Imaging.PixelFormat.Format32bppArgb, data);
            imgBoxMap.Image = bitmap;
            drawGrid(bitmap);
        }

        private void drawGrid(Bitmap bitmap)
        {
            graphics = Graphics.FromImage(bitmap);

            for (float x = 0; x < bitmap.Width; x += 58.5f)
            {
                float x1 = x;
                float y1 = 0;
                float x2 = x;
                float y2 = bitmap.Height;

                graphics.DrawLine(blackPen2, x1, y1, x2, y2);

                for (float subX = x + 19.5f; subX < x + (19.5f * 3); subX += 19.5f)
                {
                    graphics.DrawLine(blackPen1, subX, y1, subX, y2);
                }
            }

            for (float y = 0; y < bitmap.Height; y += 58.5f)
            {
                float x1 = 0;
                float y1 = y;
                float x2 = bitmap.Width;
                float y2 = y;

                graphics.DrawLine(blackPen2, x1, y1, x2, y2);

                for (float subY = y + 19.5f; subY < y + (19.5f * 3); subY += 19.5f)
                {
                    graphics.DrawLine(blackPen1, x1, subY, x2, subY);
                }
            }
        }

        private float pix2m(float omin, float omax, float nmin, float nmax, float ovalue) {
            float OldRange = (omax - omin);
            float NewRange = (nmax - nmin);
            float NewValue = (((ovalue - omin) * NewRange) / OldRange) + nmin;
            return NewValue;
        }

        private void imgBoxMap_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            int circleSizeInt = 10;
            Size circleSize = new Size(circleSizeInt, circleSizeInt);

            if (e.Button == MouseButtons.Left)
            {
                updateImg();
                myPos = new Point(e.X, e.Y);
                graphics.DrawEllipse(greenPen, new Rectangle(myPos - (circleSize / 2), circleSize));
                imgBoxMap.Invalidate();
            }
            else if (e.Button == MouseButtons.Right && !myPos.IsEmpty)
            {
                updateImg();
                enemyPos = new Point(e.X, e.Y);
                graphics.DrawEllipse(greenPen, new Rectangle(myPos - (circleSize / 2), circleSize));
                graphics.DrawEllipse(redPen, new Rectangle(enemyPos - (circleSize / 2), circleSize));
                graphics.DrawLine(blackPen1, myPos, enemyPos);
                imgBoxMap.Invalidate();

                double distancePx = Math.Sqrt(Math.Pow((enemyPos.X - myPos.X), 2) + Math.Pow((enemyPos.Y - myPos.Y), 2));
                double distanceM = Math.Round(pix2m(0, 1024, 0, 2200, (float)distancePx), 1);
                dtsLbl.Text = "Distance: " + distanceM + "m";
                double azi = Math.Atan2(myPos.Y - enemyPos.Y, myPos.X - enemyPos.X);
                aziLbl.Text = "Azi: " + Math.Round(((((azi * 180) / Math.PI) + (360 - 90)) % 360), 1) + "°";
            }
        }

        private void mapTileCmb_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            updateImg();
        }
    }
}
 