using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace WindowsFormsApplication1
{
    class Flag
    {
        public int flagIndex { get; private set; }

        public int xPos { get; private set; }
        public int yPos { get; private set; }

        public int width { get; private set; }
        public int height { get; private set; }

        public int GAPx { get; private set; }
        public int GAPy { get; private set; }

        public Image flagImage { get; private set; }

        public string imageUrl { get; private set; }

        public string flagName { get; private set; }
        public string creator { get; private set; }
        public string location { get; private set; }
        public string[] tags { get; private set; }

        public Flag(int flagIndex, PictureBox pic, string url, string name, string creator, string location, string[] tags)
        {
            this.imageUrl = "https://www.govt.nz" + url;

            WebClient wc = new WebClient();
            try
            {
                //byte[] bytes = wc.DownloadData("https://www.govt.nz" + url);
                //MemoryStream ms = new MemoryStream(bytes);
                //this.flagImage = Image.FromStream(ms);

                this.flagName = name;
                this.creator = creator;
                this.location = location;
                this.tags = tags;

                this.flagIndex = flagIndex;

                this.GAPx = pic.Width / 10;
                this.GAPy = pic.Height / 10;

                this.width = pic.Width / 3 - GAPx;
                this.height = pic.Height / 2 - GAPy;

                this.xPos = width * (flagIndex % 3) + GAPx;
                this.yPos = height * (flagIndex % 2) + GAPy;
            }
            catch
            {

            }
        }

        public void drawFlag(PictureBox pic)
        {
            // paper.FillRectangle(new TextureBrush(flagImage), xPos, yPos, width, height);
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.ImageLocation = imageUrl;
        }


    }
}
