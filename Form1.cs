using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
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
        Pen blackPen = new Pen(Color.Black, 1);

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

            string envDir = Environment.CurrentDirectory;
            string imgDir = envDir + @"\warapi\Images\Maps\";

            foreach (string location in Directory.GetFiles(imgDir))
            {
                string filename = location.Replace(imgDir, "");
                Regex newPattern = new Regex("World");

                if (!newPattern.IsMatch(filename))
                {
                    DataRow newrow = mapTable.NewRow();
                    newrow["location"] = location;
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
            var img = Pfim.Pfim.FromFile(mapTable.Rows[curIndex]["location"].ToString());
            var data = Marshal.UnsafeAddrOfPinnedArrayElement(img.Data, 0);
            var bitmap = new Bitmap(img.Width, img.Height, img.Stride, System.Drawing.Imaging.PixelFormat.Format32bppArgb, data);
            imgBoxMap.Image = bitmap;
            drawGrid(bitmap);
        }

        private void drawGrid(Bitmap bitmap)
        {
            graphics = Graphics.FromImage(bitmap);

            for (float x = 58.5f; x < bitmap.Width; x += 58.5f)
            {
                float x1 = x;
                float y1 = 0;
                float x2 = x;
                float y2 = bitmap.Height;

                graphics.DrawLine(blackPen, x1, y1, x2, y2);
            }

            for (float y = 58.5f; y < bitmap.Height; y += 58.5f)
            {
                float x1 = 0;
                float y1 = y;
                float x2 = bitmap.Width;
                float y2 = y;

                graphics.DrawLine(blackPen, x1, y1, x2, y2);
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
                graphics.DrawLine(blackPen, myPos, enemyPos);
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
 