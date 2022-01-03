/*
 * Name: Tangled Web
 * Author: P.J . Hutchison
 * Date: 6 July 2019
 * Conversion of VB version to C#
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tangled_Web_2019
{
    public partial class Form1 : Form
    {
        public string[] web_history;
        public Int32 web_counter = 1;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Open form, set first page and open history file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            web_history = new string[80];
            web_history[1] = "http://www.bing.com";
            web_counter++;

            Import_History_from_file();
        }

        /// <summary>
        /// Update Address page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_Address_Change(object sender, EventArgs e)
        {
            Load_WebPage_Click(sender, e);
        }

        /// <summary>
        /// Save history to file when closing window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Closing(object sender, FormClosingEventArgs e)
        {
            Export_History_to_file();
        }
        /// <summary>
        /// Update web page when Address changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_Address_TextUpdate(object sender, EventArgs e)
        {
            Load_WebPage_Click(sender, e);
        }

        /// <summary>
        /// Resize webbrowser if form changed size
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Resize(object sender, EventArgs e)
        {
            webBrowser1.Width = this.Width * 95 / 100;
            webBrowser1.Height = this.Height * 85 / 100;
        }

        /// <summary>
        /// Load web page from txt_address box and update history.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Load_WebPage_Click(object sender, EventArgs e)
        {
            string MyUrl;

            MyUrl = txt_Address.Text;

            if (MyUrl != "")
            {
                // Make sure url starts with HTTP protocol
                if (MyUrl.StartsWith("http://") == false & MyUrl.StartsWith("https://") == false)
                    MyUrl = "http://" + MyUrl;
           
                try
                {
                    webBrowser1.Navigate(new Uri(MyUrl, UriKind.RelativeOrAbsolute));
                    Add_Url_to_History(MyUrl);
                }

                catch (SystemException sec) { 
                    Console.WriteLine(sec.Message);
                }
                catch (Exception x) { 
                    Console.WriteLine(x.Message);
                }
            
            } // End if
        }

        /// <summary>
        /// Add a web page url to history list
        /// </summary>
        /// <param name="url"></param>
        void Add_Url_to_History (string url)
        {
            Boolean found = false;
            string entry = "";
            Int32 n;

            try
            {
                // Check if url has not already been added
                Console.WriteLine("Checking web history");
                if (web_counter > 1)
                {
                    for (n = 1; n < web_counter; n++)
                    {
                        entry = web_history[n];
                        Console.WriteLine(n.ToString() + " : " + entry);
                        if (entry.Contains(url)) 
                            found = true;                        
                    }
                }
                Console.WriteLine("Found = " + found);
                if (found == false)
                {
                    // Add page to history list
                    web_history[web_counter] = url;
                    Console.WriteLine("URL added to web history");
                    web_counter = web_counter + 1;
                    if (web_counter >= 80)
                        web_counter = 1;
                    
                    // Add address to combo box
                    txt_Address.Items.Add(url);
                    Console.WriteLine("URL added to Combo box list");
                }
            }
            catch ( Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Web_counter = " + web_counter);
                Console.WriteLine("URL = " + url);
            }
        }

        /// <summary>
        /// Save history list to a file.
        /// </summary>
        void Export_History_to_file()
        {
            string  History_Path = "";
            StreamWriter file1;

            // History_Path = Microsoft.VisualBasic.Environ("USERPROFILE")
            History_Path = Environment.GetEnvironmentVariable ("USERPROFILE");

            //FileOpen(1, History_Path & "\History.txt", OpenMode.Append)
            file1 = new StreamWriter(History_Path + "\\History.txt");
            foreach (string urlEntry in txt_Address.Items)
                file1.WriteLine(urlEntry);

            //FileClose(1)
            file1.Close();
        }

        /// <summary>
        /// Import history from file to address list.
        /// </summary>
        void Import_History_from_file()
        {
            string urlEntry = "", History_Path = "";
            StreamReader file1;

            // History_Path = Microsoft.VisualBasic.Environ("USERPROFILE")
            History_Path = Environment.GetEnvironmentVariable("USERPROFILE");

            if (File.Exists(History_Path + "\\History.txt"))
            {
                // FileOpen(1, History_Path & "\History.txt", OpenMode.Input)
                file1 = new StreamReader(History_Path + "\\History.txt");
                while (! file1.EndOfStream)
                {
                    //Input(1, urlEntry)
                    urlEntry = file1.ReadLine();
                    txt_Address.Items.Add(urlEntry);
                }
                // FileClose(1)
                file1.Close();
            }
        }

        /// <summary>
        /// Load new web page.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="e"></param>
        void txt_Address_Enter(object s, EventArgs e)
        {
            Load_WebPage_Click(s, e);
        }


    }
}
