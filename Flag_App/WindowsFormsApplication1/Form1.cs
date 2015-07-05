using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        List<Flag> flags = new List<Flag>();
        List<Flag> currentFlags = new List<Flag>();
        List<PictureBox> screenPictureBoxes = new List<PictureBox>();
        int picboxOffset;
        PictureBox currentlySelected;

        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (Flag flag in currentFlags)
            {
                if (flag.xPos <= e.X && flag.xPos + flag.width < e.X
                    && flag.yPos <= e.Y && flag.yPos + flag.height < e.Y)
                {
                    //pictureBox1.Refresh();
                    //pictureBox1.BackgroundImage = flag.flagImage;
                    lblDescription.Visible = false;
                    lblHeader.Visible = false;
                    lblSubHeader.Visible = false;

                    lblFlagName.Visible = true;
                  //  label3.Visible = true;
                    //label4.Visible = true;
                    lblCreatorName.Visible = true;
                   // label6.Visible = true;
                    //lblLocation.Visible = true;
                    //label8.Visible = true;
                    
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            Graphics paper = this.CreateGraphics();

            comboBox1.SelectedIndex = 0;
            comboBox1.SelectionLength = 0;

            string line;
            string[] split;
            int counter = 1;
     
            StreamReader myReader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "CombinedData.txt");

            while ((line = myReader.ReadLine()) != null)
            {
                try
                {
                    split = line.Split(',');
                    Flag flag = new Flag(counter, pictureBox1, split[0], split[1], split[2], split[3], split);
                    flags.Add(flag);
                    //flag.drawFlag(paper, pictureBox1);
                }
                catch
                {

                }
                //paper.FillRectangle(new TextureBrush(flag.flagImage), 100, 100, 100, 100);
                // pictureBox1.BackgroundImage = flag.flagImage;
            }
            DrawControls();
            picboxOffset = flags.Count / 2;
            FillPictureboxes(picboxOffset);
            //for(int i = 0; i < )
        }

        private void DrawControls()
        {
            screenPictureBoxes.Clear();
            PictureBox gridBox = new PictureBox();
            gridBox.Left = lblSubHeader.Left;
            gridBox.Top = lblDescription.Top;
            gridBox.Width = (screen.Width - gridBox.Left);
            gridBox.Height = (screen.Height - gridBox.Top);
            
            gridBox.Visible = true;
            gridBox.BringToFront();
            this.Controls.Add(gridBox);
            gridBox.BringToFront();
            int numWide = (int)Math.Floor((double)gridBox.Width / (double)250);
            int numHigh = (int)Math.Floor((double)gridBox.Height / (double)150);

            for (int x = 0; x < numWide; x++)
            {
                for (int y = 0; y < numHigh; y++)
                {
                    PictureBox temp = new PictureBox();
                    temp.Left = (x * 250) + 15 + gridBox.Left;
                    temp.Top = gridBox.Top + (y * 150);
                    //temp.BackColor = Color.Blue;
                    //if (x == 1) temp.BackColor = Color.Orange;
                    temp.Width = 220;
                    temp.Height = 100;
                    temp.SizeMode = PictureBoxSizeMode.Zoom;
                    temp.Visible = true;
                    temp.Enabled = true;
                    temp.Tag = (x * numHigh) + y;
                    temp.Click += temp_Click;

                    screenPictureBoxes.Add(temp);
                    
                    this.Controls.Add(screenPictureBoxes[(x * numHigh) + y]);
                    screenPictureBoxes[(x * numHigh) + y].BringToFront();
                }
            }
          }



        void temp_Click(object sender, EventArgs e)
        {
            lblCreatorName.Text = "Name: " + flags[picboxOffset + (int)((PictureBox)sender).Tag].creator.ToString();
            lblFlagName.Text = "Flag name: " + flags[picboxOffset + (int)((PictureBox)sender).Tag].flagName.ToString();
            pboxBig.Visible = true;
            flags[picboxOffset + (int)((PictureBox)sender).Tag].drawFlag(pboxBig);
        }

        private void FillPictureboxes(int offset)
        {
            //picboxOffset = offset;
            for (int i = 0; i < screenPictureBoxes.Count; i++)
            {
                flags[offset + i].drawFlag(screenPictureBoxes[i]);
            }
        }

        private void screen_Paint(object sender, PaintEventArgs e)
        {
            screen.Width = this.Width-10;
            screen.Height = this.Height-10;
            pictureBox1.Width = this.Width - pictureBox1.Left;
            pictureBox1.Height = this.Height - pictureBox1.Height;

            DrawControls();
            FillPictureboxes(picboxOffset);
        }

        private void pboxup_Click(object sender, EventArgs e)
        {
            picboxOffset -= screenPictureBoxes.Count;
            FillPictureboxes(picboxOffset);
        }

        private void pboxDown_Click(object sender, EventArgs e)
        {
            picboxOffset += screenPictureBoxes.Count;
            FillPictureboxes(picboxOffset);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            StreamReader myReader;
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                   // myReader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "CombinedData.txt");
                    myReader = null;
                    break;
                case 1:
                    myReader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "CleanData\\Auckland.txt");
                    break;
                case 2:
                    myReader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "CleanData\\BayOfPlenty.txt");
                    break;
                case 3:
                    myReader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "CleanData\\Canterbury.txt");
                    break;
                case 4:
                    myReader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "CleanData\\Gisborne.txt");
                    break;
                case 5:
                    myReader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "CleanData\\HawkesBay.txt");
                    break;
                case 6:
                    myReader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "CleanData\\Manawatu-Wanganui.txt");
                    break;
                case 7:
                    myReader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "CleanData\\Marlborough.txt");
                    break;
                case 8:
                    myReader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "CleanData\\Nelson.txt");
                    break;
                case 9:
                    myReader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "CleanData\\Northland.txt");
                    break;
                case 10:
                    myReader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "CleanData\\Otago.txt");
                    break;
                case 11:
                    myReader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "CleanData\\Southland.txt");
                    break;
                case 12:
                    myReader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "CleanData\\Taranaki.txt");
                    break;
                case 13:
                    myReader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "CleanData\\Waikato.txt");
                    break;
                case 14:
                    myReader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "CleanData\\Wellington.txt");
                    break;
                case 15:
                    myReader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "CleanData\\WestCoast.txt");
                    break;
                case 16:
                    myReader = null;
                    break;
                default:
                    myReader = null;
                    break;
            }

            string line;
            string[] split;
           // txtbxStats.Text = "Artist Name" + '\t' + "Number of Submissions" + '\n';
            txtbxStats.Clear();
            if (myReader != null)
            {
                while ((line = myReader.ReadLine()) != null)
                {
                    try
                    {
                        split = line.Split(',');
                        txtbxStats.Text += split[1] + '\t' + split[2] + '\r' +'\n';
                        //flag.drawFlag(paper, pictureBox1);
                    }
                    catch
                    {

                    }
                    //paper.FillRectangle(new TextureBrush(flag.flagImage), 100, 100, 100, 100);
                    // pictureBox1.BackgroundImage = flag.flagImage;
                }
                txtbxStats.BringToFront();
            }
        }

        private void lblViewStats_Click(object sender, EventArgs e)
        {
            pboxCover.Visible = true;
            pboxCover.BringToFront();
            txtbxStats.Visible = true;
            txtbxStats.BringToFront();
        }

        private void lblViewFlags_Click(object sender, EventArgs e)
        {
            pboxCover.Visible = false;
            txtbxStats.Visible = false;
        }
            
        }
    }

