using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.IO;

namespace WebScrape
{
    public partial class Form1 : Form
    {
        // End of URL 1 must be the #num for offset
        string URL1 = "https://www.govt.nz/browse/engaging-with-government/the-nz-flag-your-chance-to-decide/gallery/?location=17&scroll=true&start=";
        string URL2 = "";
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            int pageNum = 0;
            StreamWriter sr = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + @"\" + "17International.txt");
            while (true)
            {
                string sURL = URL1 + pageNum.ToString() + URL2;
                WebRequest wrGETURL = WebRequest.Create(sURL);
                Stream objStream = wrGETURL.GetResponse().GetResponseStream();

                StreamReader objReader = new StreamReader(objStream);

                string sLine = "";
                int i = 0, numWritten = 0;

                
                while (sLine != null)
                {
                    i++;
                    sLine = objReader.ReadLine();
                    if (sLine != null)
                    {
                        if (RemoveWhitespace(sLine).Length > 4)
                        {
                            string check = RemoveWhitespace(sLine).Substring(0, 4);
                            if (check.Equals("<img"))
                            {
                                string[] tempSplit = sLine.Split('\t');
                                bool compile = false;
                                string cleanString = "";
                                for (int n = 0; n < tempSplit.Length; n++)
                                {
                                    if (tempSplit[n] != "")
                                    {
                                        compile = true;
                                    }
                                    if (compile == true) cleanString += tempSplit[n];
                                }
                                {
                                   // label1.Text += Environment.NewLine + i.ToString() + ":" + (cleanString);
                                    numWritten++;

                                    //StringBuilder builder = new StringBuilder();
                                    //int testt = (cleanString.IndexOf(".jpg") + 4);
                                    try
                                    {
                                        string flagurl = cleanString.Substring(cleanString.IndexOf("src=") + 5, (cleanString.IndexOf(".jpg") + 4 - (cleanString.IndexOf("src=") + 5)));
                                        string flagName = cleanString.Substring(cleanString.IndexOf("alt=") + 5, (cleanString.IndexOf(" by ")) - (cleanString.IndexOf("alt=") + 5));
                                        string artistName = cleanString.Substring(cleanString.IndexOf(" by ") + 4, (cleanString.IndexOf(",")) - (cleanString.IndexOf(" by ") + 4));
                                        label1.Text += flagurl + "," + flagName + "," + artistName + "," + "0" + Environment.NewLine;
                                        
                                        sr.WriteLine((flagurl + "," + flagName + "," + artistName + "," + "0"));
                                        
                                        
                                    }
                                    catch
                                    {

                                    }

                                }
                            }
                        }
                    }

                }
                
               // if (((pageNum - 1 )/ 1000) != (pageNum / 1000) && (pageNum / 1000) > 1) MessageBox.Show("Test");
                if (pageNum >= 1600){
                    sr.Close();
                    break;
                }
                
                pageNum += 60;
                objReader.Close();
                objStream.Close();
            }
        }
        public  string RemoveWhitespace(string input)
        {
            return new string(input.ToCharArray()
                .Where(c => !Char.IsWhiteSpace(c))
                .ToArray());
        }
    }
}
