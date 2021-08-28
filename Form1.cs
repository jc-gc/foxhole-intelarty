using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pfim;

namespace foxhole_intelarty
{
    public partial class Form1 : Form
    {
        DataTable mapTable = new DataTable();

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
                Regex newPattern = new Regex("Home|World");

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
            var origBitmap = bitmap;
            Pen blackPen = new Pen(Color.Black, 1);

            for (int x = 0; x < bitmap.Width; x += 59)
            {
                int x1 = x;
                int y1 = 0;
                int x2 = x;
                int y2 = bitmap.Height;

                using (var graphics = Graphics.FromImage(bitmap))
                {
                    graphics.DrawLine(blackPen, x1, y1, x2, y2);
                }
            }

            for (int y = 0; y < bitmap.Height; y += 59)
            {
                int x1 = 0;
                int y1 = y;
                int x2 = bitmap.Width;
                int y2 = y;

                using (var graphics = Graphics.FromImage(bitmap))
                {
                    graphics.DrawLine(blackPen, x1, y1, x2, y2);
                }
            }
        }

        private void mapTileCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateImg();
        }
    }
}
 