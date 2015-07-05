using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class Tile
    {
        //public PictureBox picture { get; private set; }
        public Image image { get; private set; }
        public string title { get; private set; }
        public string description { get; private set; }
        public string[] tags { get; private set; }
        public string creator { get; private set; }

        public Tile(string Title, string Creator, string Description, string[] Tags,  Image image, PictureBox picbox)
        {
            //picture = new PictureBox();
            //picture.BackgroundImage = image;

            this.image = image;
            this.title = Title;
            this.creator = Creator;
            this.description = Description;
            this.tags = Tags;
        }

        public void drawTile(Graphics paper, int x, int y, int width, int height)
        {
            paper.DrawRectangle(new Pen(Color.Black), x, y, width, height);

            TextureBrush b1 = new TextureBrush(image);

            paper.FillRectangle(b1, x, y, width, height);
        }
    }
}
