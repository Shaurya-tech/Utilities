namespace Utilities
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation5 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.SideBar = new System.Windows.Forms.Panel();
            this.WebButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.DashButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TopBar = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.BackgroundNotification = new System.Windows.Forms.NotifyIcon(this.components);
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.Username = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.WebToolsTab = new MaterialSkin.Controls.MaterialTabSelector();
            this.WebToolsTabs = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.webscrapeSource = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Pages = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.Update = new System.Windows.Forms.Timer(this.components);
            this.webscrapeFilter = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.webscrapeLoad = new MaterialSkin.Controls.MaterialFlatButton();
            this.wsDebug = new System.Windows.Forms.TextBox();
            this.wsLinks = new System.Windows.Forms.ListBox();
            this.webscraper = new System.Windows.Forms.WebBrowser();
            this.playerDropDown = new Bunifu.Framework.UI.BunifuDropdown();
            this.playerSource = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.materialCheckBox1 = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialCheckBox2 = new MaterialSkin.Controls.MaterialCheckBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.SideBar.SuspendLayout();
            this.TopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.WebToolsTabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.Pages.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.SideBar;
            this.bunifuDragControl1.Vertical = true;
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.SideBar.Controls.Add(this.WebButton);
            this.SideBar.Controls.Add(this.DashButton);
            this.bunifuTransition1.SetDecoration(this.SideBar, BunifuAnimatorNS.DecorationType.None);
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.Location = new System.Drawing.Point(0, 38);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(200, 455);
            this.SideBar.TabIndex = 1;
            // 
            // WebButton
            // 
            this.WebButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(59)))), ((int)(((byte)(81)))));
            this.WebButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.WebButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WebButton.BorderRadius = 0;
            this.WebButton.ButtonText = "     Web Tools";
            this.WebButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.WebButton, BunifuAnimatorNS.DecorationType.None);
            this.WebButton.DisabledColor = System.Drawing.Color.Gray;
            this.WebButton.Iconcolor = System.Drawing.Color.Transparent;
            this.WebButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("WebButton.Iconimage")));
            this.WebButton.Iconimage_right = null;
            this.WebButton.Iconimage_right_Selected = null;
            this.WebButton.Iconimage_Selected = null;
            this.WebButton.IconMarginLeft = 10;
            this.WebButton.IconMarginRight = 0;
            this.WebButton.IconRightVisible = true;
            this.WebButton.IconRightZoom = 0D;
            this.WebButton.IconVisible = true;
            this.WebButton.IconZoom = 80D;
            this.WebButton.IsTab = true;
            this.WebButton.Location = new System.Drawing.Point(-4, 88);
            this.WebButton.Name = "WebButton";
            this.WebButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.WebButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(59)))), ((int)(((byte)(81)))));
            this.WebButton.OnHoverTextColor = System.Drawing.Color.White;
            this.WebButton.selected = false;
            this.WebButton.Size = new System.Drawing.Size(213, 48);
            this.WebButton.TabIndex = 3;
            this.WebButton.Text = "     Web Tools";
            this.WebButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WebButton.Textcolor = System.Drawing.Color.White;
            this.WebButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WebButton.Click += new System.EventHandler(this.WebButton_Click);
            // 
            // DashButton
            // 
            this.DashButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(59)))), ((int)(((byte)(81)))));
            this.DashButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(59)))), ((int)(((byte)(81)))));
            this.DashButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DashButton.BorderRadius = 0;
            this.DashButton.ButtonText = "     Dashboard";
            this.DashButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.DashButton, BunifuAnimatorNS.DecorationType.None);
            this.DashButton.DisabledColor = System.Drawing.Color.Gray;
            this.DashButton.Iconcolor = System.Drawing.Color.Transparent;
            this.DashButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("DashButton.Iconimage")));
            this.DashButton.Iconimage_right = null;
            this.DashButton.Iconimage_right_Selected = null;
            this.DashButton.Iconimage_Selected = null;
            this.DashButton.IconMarginLeft = 10;
            this.DashButton.IconMarginRight = 0;
            this.DashButton.IconRightVisible = true;
            this.DashButton.IconRightZoom = 0D;
            this.DashButton.IconVisible = true;
            this.DashButton.IconZoom = 80D;
            this.DashButton.IsTab = true;
            this.DashButton.Location = new System.Drawing.Point(-4, 34);
            this.DashButton.Name = "DashButton";
            this.DashButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.DashButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(59)))), ((int)(((byte)(81)))));
            this.DashButton.OnHoverTextColor = System.Drawing.Color.White;
            this.DashButton.selected = true;
            this.DashButton.Size = new System.Drawing.Size(213, 48);
            this.DashButton.TabIndex = 2;
            this.DashButton.Text = "     Dashboard";
            this.DashButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DashButton.Textcolor = System.Drawing.Color.White;
            this.DashButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashButton.Click += new System.EventHandler(this.DashButton_Click);
            // 
            // TopBar
            // 
            this.TopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(102)))), ((int)(((byte)(158)))));
            this.TopBar.Controls.Add(this.bunifuImageButton1);
            this.TopBar.Controls.Add(this.label1);
            this.bunifuTransition1.SetDecoration(this.TopBar, BunifuAnimatorNS.DecorationType.None);
            this.TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBar.Location = new System.Drawing.Point(0, 0);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(883, 38);
            this.TopBar.TabIndex = 0;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(8, 0);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(40, 40);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(59)))), ((int)(((byte)(81)))));
            this.label1.Location = new System.Drawing.Point(854, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.TopBar;
            this.bunifuDragControl2.Vertical = true;
            // 
            // BackgroundNotification
            // 
            this.BackgroundNotification.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.BackgroundNotification.BalloonTipText = "Text";
            this.BackgroundNotification.BalloonTipTitle = "Title";
            this.BackgroundNotification.Icon = ((System.Drawing.Icon)(resources.GetObject("BackgroundNotification.Icon")));
            this.BackgroundNotification.Text = "Utilities";
            this.BackgroundNotification.Visible = true;
            this.BackgroundNotification.Click += new System.EventHandler(this.BackgroundNotification_Click);
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition1.Cursor = null;
            animation5.AnimateOnlyDifferences = true;
            animation5.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.BlindCoeff")));
            animation5.LeafCoeff = 0F;
            animation5.MaxTime = 1F;
            animation5.MinTime = 0F;
            animation5.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicCoeff")));
            animation5.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicShift")));
            animation5.MosaicSize = 0;
            animation5.Padding = new System.Windows.Forms.Padding(0);
            animation5.RotateCoeff = 0F;
            animation5.RotateLimit = 0F;
            animation5.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.ScaleCoeff")));
            animation5.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.SlideCoeff")));
            animation5.TimeCoeff = 0F;
            animation5.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation5;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.Username, BunifuAnimatorNS.DecorationType.None);
            this.Username.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.Color.Silver;
            this.Username.Location = new System.Drawing.Point(186, 10);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(160, 25);
            this.Username.TabIndex = 1;
            this.Username.Text = "Good Morning";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.TimeLabel, BunifuAnimatorNS.DecorationType.None);
            this.TimeLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.ForeColor = System.Drawing.Color.Silver;
            this.TimeLabel.Location = new System.Drawing.Point(22, 11);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(158, 24);
            this.TimeLabel.TabIndex = 0;
            this.TimeLabel.Text = "Good Morning";
            // 
            // WebToolsTab
            // 
            this.WebToolsTab.BaseTabControl = this.WebToolsTabs;
            this.bunifuTransition1.SetDecoration(this.WebToolsTab, BunifuAnimatorNS.DecorationType.None);
            this.WebToolsTab.Depth = 0;
            this.WebToolsTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.WebToolsTab.Location = new System.Drawing.Point(3, 3);
            this.WebToolsTab.MouseState = MaterialSkin.MouseState.HOVER;
            this.WebToolsTab.Name = "WebToolsTab";
            this.WebToolsTab.Size = new System.Drawing.Size(669, 43);
            this.WebToolsTab.TabIndex = 2;
            this.WebToolsTab.Text = "materialTabSelector1";
            // 
            // WebToolsTabs
            // 
            this.WebToolsTabs.Controls.Add(this.tabPage1);
            this.WebToolsTabs.Controls.Add(this.tabPage2);
            this.WebToolsTabs.Controls.Add(this.tabPage5);
            this.bunifuTransition1.SetDecoration(this.WebToolsTabs, BunifuAnimatorNS.DecorationType.None);
            this.WebToolsTabs.Depth = 0;
            this.WebToolsTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WebToolsTabs.Location = new System.Drawing.Point(3, 46);
            this.WebToolsTabs.MouseState = MaterialSkin.MouseState.HOVER;
            this.WebToolsTabs.Name = "WebToolsTabs";
            this.WebToolsTabs.SelectedIndex = 0;
            this.WebToolsTabs.Size = new System.Drawing.Size(669, 380);
            this.WebToolsTabs.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(59)))), ((int)(((byte)(81)))));
            this.tabPage1.Controls.Add(this.webscraper);
            this.tabPage1.Controls.Add(this.wsLinks);
            this.tabPage1.Controls.Add(this.wsDebug);
            this.tabPage1.Controls.Add(this.webscrapeLoad);
            this.tabPage1.Controls.Add(this.webscrapeFilter);
            this.tabPage1.Controls.Add(this.webscrapeSource);
            this.bunifuTransition1.SetDecoration(this.tabPage1, BunifuAnimatorNS.DecorationType.None);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(661, 354);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Web Scraper";
            // 
            // webscrapeSource
            // 
            this.webscrapeSource.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.webscrapeSource, BunifuAnimatorNS.DecorationType.None);
            this.webscrapeSource.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.webscrapeSource.ForeColor = System.Drawing.Color.Silver;
            this.webscrapeSource.HintForeColor = System.Drawing.Color.Silver;
            this.webscrapeSource.HintText = "URL To Scrape";
            this.webscrapeSource.isPassword = false;
            this.webscrapeSource.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.webscrapeSource.LineIdleColor = System.Drawing.Color.Gray;
            this.webscrapeSource.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.webscrapeSource.LineThickness = 3;
            this.webscrapeSource.Location = new System.Drawing.Point(16, 13);
            this.webscrapeSource.Margin = new System.Windows.Forms.Padding(4);
            this.webscrapeSource.Name = "webscrapeSource";
            this.webscrapeSource.Size = new System.Drawing.Size(379, 33);
            this.webscrapeSource.TabIndex = 0;
            this.webscrapeSource.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(59)))), ((int)(((byte)(81)))));
            this.tabPage2.Controls.Add(this.materialCheckBox2);
            this.tabPage2.Controls.Add(this.materialCheckBox1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.bunifuSeparator1);
            this.tabPage2.Controls.Add(this.playerSource);
            this.tabPage2.Controls.Add(this.playerDropDown);
            this.tabPage2.Controls.Add(this.bunifuSeparator2);
            this.bunifuTransition1.SetDecoration(this.tabPage2, BunifuAnimatorNS.DecorationType.None);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(661, 354);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Player";
            // 
            // Pages
            // 
            this.Pages.Controls.Add(this.tabPage3);
            this.Pages.Controls.Add(this.tabPage4);
            this.bunifuTransition1.SetDecoration(this.Pages, BunifuAnimatorNS.DecorationType.None);
            this.Pages.Depth = 0;
            this.Pages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pages.Location = new System.Drawing.Point(200, 38);
            this.Pages.MouseState = MaterialSkin.MouseState.HOVER;
            this.Pages.Name = "Pages";
            this.Pages.SelectedIndex = 0;
            this.Pages.Size = new System.Drawing.Size(683, 455);
            this.Pages.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(59)))), ((int)(((byte)(81)))));
            this.tabPage3.Controls.Add(this.Username);
            this.tabPage3.Controls.Add(this.TimeLabel);
            this.bunifuTransition1.SetDecoration(this.tabPage3, BunifuAnimatorNS.DecorationType.None);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(675, 429);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Dashboard";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(59)))), ((int)(((byte)(81)))));
            this.tabPage4.Controls.Add(this.WebToolsTabs);
            this.tabPage4.Controls.Add(this.WebToolsTab);
            this.bunifuTransition1.SetDecoration(this.tabPage4, BunifuAnimatorNS.DecorationType.None);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(675, 429);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Webtools";
            // 
            // Update
            // 
            this.Update.Tick += new System.EventHandler(this.Update_Tick);
            // 
            // webscrapeFilter
            // 
            this.webscrapeFilter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.webscrapeFilter, BunifuAnimatorNS.DecorationType.None);
            this.webscrapeFilter.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.webscrapeFilter.ForeColor = System.Drawing.Color.Silver;
            this.webscrapeFilter.HintForeColor = System.Drawing.Color.Silver;
            this.webscrapeFilter.HintText = "Filter";
            this.webscrapeFilter.isPassword = false;
            this.webscrapeFilter.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.webscrapeFilter.LineIdleColor = System.Drawing.Color.Gray;
            this.webscrapeFilter.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.webscrapeFilter.LineThickness = 3;
            this.webscrapeFilter.Location = new System.Drawing.Point(406, 13);
            this.webscrapeFilter.Margin = new System.Windows.Forms.Padding(4);
            this.webscrapeFilter.Name = "webscrapeFilter";
            this.webscrapeFilter.Size = new System.Drawing.Size(114, 33);
            this.webscrapeFilter.TabIndex = 1;
            this.webscrapeFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // webscrapeLoad
            // 
            this.webscrapeLoad.AutoSize = true;
            this.webscrapeLoad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bunifuTransition1.SetDecoration(this.webscrapeLoad, BunifuAnimatorNS.DecorationType.None);
            this.webscrapeLoad.Depth = 0;
            this.webscrapeLoad.Location = new System.Drawing.Point(550, 23);
            this.webscrapeLoad.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.webscrapeLoad.MouseState = MaterialSkin.MouseState.HOVER;
            this.webscrapeLoad.Name = "webscrapeLoad";
            this.webscrapeLoad.Primary = false;
            this.webscrapeLoad.Size = new System.Drawing.Size(63, 36);
            this.webscrapeLoad.TabIndex = 2;
            this.webscrapeLoad.Text = "Scrape";
            this.webscrapeLoad.UseVisualStyleBackColor = true;
            this.webscrapeLoad.Click += new System.EventHandler(this.webscrapeLoad_Click);
            // 
            // wsDebug
            // 
            this.wsDebug.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(59)))), ((int)(((byte)(81)))));
            this.wsDebug.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuTransition1.SetDecoration(this.wsDebug, BunifuAnimatorNS.DecorationType.None);
            this.wsDebug.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wsDebug.ForeColor = System.Drawing.Color.Silver;
            this.wsDebug.Location = new System.Drawing.Point(16, 65);
            this.wsDebug.Multiline = true;
            this.wsDebug.Name = "wsDebug";
            this.wsDebug.Size = new System.Drawing.Size(224, 283);
            this.wsDebug.TabIndex = 3;
            this.wsDebug.Text = "test";
            // 
            // wsLinks
            // 
            this.wsLinks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(59)))), ((int)(((byte)(81)))));
            this.wsLinks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuTransition1.SetDecoration(this.wsLinks, BunifuAnimatorNS.DecorationType.None);
            this.wsLinks.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wsLinks.ForeColor = System.Drawing.Color.Silver;
            this.wsLinks.FormattingEnabled = true;
            this.wsLinks.ItemHeight = 19;
            this.wsLinks.Location = new System.Drawing.Point(256, 65);
            this.wsLinks.Name = "wsLinks";
            this.wsLinks.Size = new System.Drawing.Size(357, 266);
            this.wsLinks.TabIndex = 4;
            // 
            // webscraper
            // 
            this.bunifuTransition1.SetDecoration(this.webscraper, BunifuAnimatorNS.DecorationType.None);
            this.webscraper.Location = new System.Drawing.Point(16, 97);
            this.webscraper.MinimumSize = new System.Drawing.Size(20, 20);
            this.webscraper.Name = "webscraper";
            this.webscraper.ScriptErrorsSuppressed = true;
            this.webscraper.Size = new System.Drawing.Size(33, 29);
            this.webscraper.TabIndex = 5;
            this.webscraper.Visible = false;
            this.webscraper.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webscraper_DocumentCompleted);
            // 
            // playerDropDown
            // 
            this.playerDropDown.BackColor = System.Drawing.Color.Transparent;
            this.playerDropDown.BorderRadius = 3;
            this.bunifuTransition1.SetDecoration(this.playerDropDown, BunifuAnimatorNS.DecorationType.None);
            this.playerDropDown.DisabledColor = System.Drawing.Color.Gray;
            this.playerDropDown.ForeColor = System.Drawing.Color.White;
            this.playerDropDown.Items = new string[] {
        "Source: Selected Link",
        "Source: Custom Link"};
            this.playerDropDown.Location = new System.Drawing.Point(13, 14);
            this.playerDropDown.Name = "playerDropDown";
            this.playerDropDown.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.playerDropDown.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.playerDropDown.selectedIndex = -1;
            this.playerDropDown.Size = new System.Drawing.Size(217, 35);
            this.playerDropDown.TabIndex = 0;
            this.playerDropDown.onItemSelected += new System.EventHandler(this.playerDropDown_onItemSelected);
            // 
            // playerSource
            // 
            this.playerSource.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(102)))), ((int)(((byte)(158)))));
            this.playerSource.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.playerSource.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.playerSource.BorderThickness = 3;
            this.playerSource.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.playerSource, BunifuAnimatorNS.DecorationType.None);
            this.playerSource.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerSource.ForeColor = System.Drawing.Color.Silver;
            this.playerSource.isPassword = false;
            this.playerSource.Location = new System.Drawing.Point(238, 7);
            this.playerSource.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.playerSource.Name = "playerSource";
            this.playerSource.Size = new System.Drawing.Size(415, 47);
            this.playerSource.TabIndex = 1;
            this.playerSource.Text = "playerSource";
            this.playerSource.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.playerSource.Visible = false;
            this.playerSource.Click += new System.EventHandler(this.playerSource_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bunifuSeparator1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator1.LineColor = System.Drawing.Color.DimGray;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(6, 60);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(646, 35);
            this.bunifuSeparator1.TabIndex = 2;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(9, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Player Settings";
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bunifuSeparator2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(6, 101);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(646, 35);
            this.bunifuSeparator2.TabIndex = 4;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // materialCheckBox1
            // 
            this.materialCheckBox1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.materialCheckBox1, BunifuAnimatorNS.DecorationType.None);
            this.materialCheckBox1.Depth = 0;
            this.materialCheckBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialCheckBox1.Location = new System.Drawing.Point(13, 136);
            this.materialCheckBox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox1.Name = "materialCheckBox1";
            this.materialCheckBox1.Ripple = true;
            this.materialCheckBox1.Size = new System.Drawing.Size(166, 30);
            this.materialCheckBox1.TabIndex = 5;
            this.materialCheckBox1.Text = "Keep Player Top-Most";
            this.materialCheckBox1.UseVisualStyleBackColor = true;
            this.materialCheckBox1.CheckedChanged += new System.EventHandler(this.materialCheckBox1_CheckedChanged);
            // 
            // materialCheckBox2
            // 
            this.materialCheckBox2.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.materialCheckBox2, BunifuAnimatorNS.DecorationType.None);
            this.materialCheckBox2.Depth = 0;
            this.materialCheckBox2.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBox2.Location = new System.Drawing.Point(13, 166);
            this.materialCheckBox2.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox2.Name = "materialCheckBox2";
            this.materialCheckBox2.Ripple = true;
            this.materialCheckBox2.Size = new System.Drawing.Size(143, 30);
            this.materialCheckBox2.TabIndex = 6;
            this.materialCheckBox2.Text = "Some other option";
            this.materialCheckBox2.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.bunifuTransition1.SetDecoration(this.tabPage5, BunifuAnimatorNS.DecorationType.None);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(661, 354);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Youtube Downloader";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(59)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(883, 493);
            this.Controls.Add(this.Pages);
            this.Controls.Add(this.SideBar);
            this.Controls.Add(this.TopBar);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SideBar.ResumeLayout(false);
            this.TopBar.ResumeLayout(false);
            this.TopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.WebToolsTabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.Pages.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel TopBar;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.NotifyIcon BackgroundNotification;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel SideBar;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuFlatButton DashButton;
        private Bunifu.Framework.UI.BunifuFlatButton WebButton;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Timer Update;
        private MaterialSkin.Controls.MaterialTabSelector WebToolsTab;
        private MaterialSkin.Controls.MaterialTabControl Pages;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private MaterialSkin.Controls.MaterialTabControl WebToolsTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox webscrapeSource;
        private MaterialSkin.Controls.MaterialFlatButton webscrapeLoad;
        private Bunifu.Framework.UI.BunifuMaterialTextbox webscrapeFilter;
        private System.Windows.Forms.ListBox wsLinks;
        private System.Windows.Forms.TextBox wsDebug;
        private System.Windows.Forms.WebBrowser webscraper;
        private Bunifu.Framework.UI.BunifuDropdown playerDropDown;
        private Bunifu.Framework.UI.BunifuMetroTextbox playerSource;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBox1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBox2;
        private System.Windows.Forms.TabPage tabPage5;
    }
}

