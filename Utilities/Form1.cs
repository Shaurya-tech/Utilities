using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Utilities
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            BackgroundNotification.Visible = true;
            BackgroundNotification.ShowBalloonTip(500);
            this.Hide();
        }

        private void BackgroundNotification_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (SideBar.Width == 200)
            {
                //SideBar.Visible = false;
                SideBar.Width = 52;
                bunifuTransition1.ShowSync(SideBar);
            }

            else
            {
                //SideBar.Visible = false;
                SideBar.Width = 200;
                bunifuTransition1.ShowSync(SideBar);
            }
        }

        // Tab Bools
        public List<bool> tabs = new List<bool>();
        public bool dash, web;

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set Pages (tabControl1) to hide headers (selected tab etc...)
            Pages.Appearance = TabAppearance.FlatButtons;
            Pages.ItemSize = new Size(0, 1);
            Pages.SizeMode = TabSizeMode.Fixed;

            // Add tabs to list<bool> tabs
            tabs.Add(dash);
            tabs.Add(web);

            Update.Start();
            Username.Text = Environment.UserName;
        }

        /* Tab Button Clicks */

        private void TabSwitch(int tab)
        {
            for (int i = 0; i < tabs.Count; i++)
            {
                tabs[i] = false;
            }

            tabs[tab] = true;
            Pages.SelectedIndex = tab;
        }

        private void DashButton_Click(object sender, EventArgs e)
        {
            TabSwitch(0);
        }

        private void Update_Tick(object sender, EventArgs e)
        {
            Update.Interval = 10000;

            if (DateTime.Now.ToString("TT") == "AM")
            {
                TimeLabel.Text = "Good Morning";
            }

            else
            {
                TimeLabel.Text = "Good Evening";
            }
        }

        private void Pages_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void webscrapeLoad_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(webscrapeSource.Text))
            {
                webscraper.Navigate(webscrapeSource.Text);
                wsDebug.Text = "Loading Page";
            }
        }

        private void webscraper_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            wsDebug.AppendText(Environment.NewLine + "Page Loaded! ");
            wsDebug.AppendText(Environment.NewLine + "Scraping For Links ");

            List<string> Links = new List<string>();
            string html = webscraper.DocumentText;
            string[] seperating = html.Split(' ');

            int nLinks = 0;
         
            foreach(var line in seperating)
            {
                if (line.Contains("href") || line.Contains("http") || line.Contains("src="))
                {
                    if (line.Contains(webscrapeFilter.Text))
                    {
                        nLinks++;
                        Links.Add(line);
                    }
                }
            }

            wsDebug.AppendText(Environment.NewLine + "Number of Links Found: " + nLinks);

            wsLinks.Items.Clear();

            foreach (var link in Links)
            {
                foreach (Match item in Regex.Matches(link, @"(http|ftp|https):\/\/([\w\-_]+(?:(?:\.[\w\-_]+)+))([\w\-\.,@?^=%&amp;:/~\+#]*[\w\-\@?^=%&amp;/~\+#])?"))
                {
                    wsLinks.Items.Add(item.Value);
                }
            }
        }

        private void playerDropDown_onItemSelected(object sender, EventArgs e)
        {
            if (playerDropDown.selectedIndex == 0)
            {
                if (wsLinks.SelectedIndex > -1)
                {
                    playerSource.Text = wsLinks.Items[wsLinks.SelectedIndex].ToString();
                    playerSource.Visible = true;
                }

                else
                {
                    MessageBox.Show("Please Select A Link First!");
                }
            }

            else if (playerDropDown.selectedIndex == 1)
            {
                playerSource.Visible = true;
                playerSource.Text = "URL: ";
            }
        }

        private void playerSource_Click(object sender, EventArgs e)
        {
            if (playerDropDown.selectedIndex == 1)
            {
                playerSource.Text = "";
            }
        }

        private void materialCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (materialCheckBox1.CheckState == CheckState.Checked)
            {
                Settings.PlayerSettings.set(ref Settings.PlayerSettings.overlay, 1);
            }

            else
            {
                Settings.PlayerSettings.set(ref Settings.PlayerSettings.overlay, 0);
            }
            
        }

        private void WebButton_Click(object sender, EventArgs e)
        {
            TabSwitch(1);
        }
    }
}
