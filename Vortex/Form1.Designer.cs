namespace Vortex
{
    partial class Vortex
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vortex));
            this.miniToolStrip = new System.Windows.Forms.MenuStrip();
            this.BarreAdresse = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.PageOnglet = new DevComponents.DotNetBar.SuperTabControl();
            this.TabControlPanel = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.Browser = new System.Windows.Forms.WebBrowser();
            this.Onglet = new DevComponents.DotNetBar.SuperTabItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SearchEngine = new MetroFramework.Controls.MetroComboBox();
            this.BarreRecherche = new MetroFramework.Controls.MetroTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Parametre = new System.Windows.Forms.ToolStripMenuItem();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvelleFenetreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauOngletToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.navigationPrivéeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.imprimerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aperçuAvantImpressionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.quitterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.annulerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rétablirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.copierToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.collerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.couperToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.sélectionnerToutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.historiqueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.marquePageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsAvancéesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personaliserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Home = new System.Windows.Forms.Button();
            this.Telechargement = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.LogoVortex = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PageOnglet)).BeginInit();
            this.PageOnglet.SuspendLayout();
            this.TabControlPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoVortex)).BeginInit();
            this.SuspendLayout();
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.BackColor = System.Drawing.Color.LavenderBlush;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.Location = new System.Drawing.Point(438, 2);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.Size = new System.Drawing.Size(440, 24);
            this.miniToolStrip.TabIndex = 0;
            // 
            // BarreAdresse
            // 
            this.BarreAdresse.Lines = new string[0];
            this.BarreAdresse.Location = new System.Drawing.Point(383, 25);
            this.BarreAdresse.MaxLength = 32767;
            this.BarreAdresse.Name = "BarreAdresse";
            this.BarreAdresse.PasswordChar = '\0';
            this.BarreAdresse.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.BarreAdresse.SelectedText = "";
            this.BarreAdresse.Size = new System.Drawing.Size(562, 29);
            this.BarreAdresse.TabIndex = 8;
            this.BarreAdresse.UseSelectable = true;
            this.BarreAdresse.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BarreAdresse_KeyUp);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(1619, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(61, 990);
            this.metroPanel1.TabIndex = 9;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // PageOnglet
            // 
            this.PageOnglet.BackColor = System.Drawing.Color.White;
            this.PageOnglet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PageOnglet.CloseButtonOnTabsVisible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.PageOnglet.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.PageOnglet.ControlBox.MenuBox.Name = "";
            this.PageOnglet.ControlBox.Name = "";
            this.PageOnglet.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.PageOnglet.ControlBox.MenuBox,
            this.PageOnglet.ControlBox.CloseBox});
            this.PageOnglet.Controls.Add(this.TabControlPanel);
            this.PageOnglet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PageOnglet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PageOnglet.ForeColor = System.Drawing.Color.Black;
            this.PageOnglet.Location = new System.Drawing.Point(0, 60);
            this.PageOnglet.Name = "PageOnglet";
            this.PageOnglet.ReorderTabsEnabled = true;
            this.PageOnglet.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.PageOnglet.SelectedTabIndex = 0;
            this.PageOnglet.Size = new System.Drawing.Size(1619, 990);
            this.PageOnglet.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageOnglet.TabIndex = 10;
            this.PageOnglet.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.Onglet});
            this.PageOnglet.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.VisualStudio2008Document;
            this.PageOnglet.Text = "PageOnglet";
            // 
            // TabControlPanel
            // 
            this.TabControlPanel.Controls.Add(this.Browser);
            this.TabControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControlPanel.Location = new System.Drawing.Point(0, 30);
            this.TabControlPanel.Name = "TabControlPanel";
            this.TabControlPanel.Size = new System.Drawing.Size(1619, 960);
            this.TabControlPanel.TabIndex = 1;
            this.TabControlPanel.TabItem = this.Onglet;
            // 
            // Browser
            // 
            this.Browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Browser.Location = new System.Drawing.Point(0, 0);
            this.Browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.Browser.Name = "Browser";
            this.Browser.Size = new System.Drawing.Size(1619, 960);
            this.Browser.TabIndex = 0;
            this.Browser.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.Browser_Navigated);
            // 
            // Onglet
            // 
            this.Onglet.AttachedControl = this.TabControlPanel;
            this.Onglet.GlobalItem = false;
            this.Onglet.Name = "Onglet";
            this.Onglet.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.OfficeMobile2014Pink;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // SearchEngine
            // 
            this.SearchEngine.BackColor = System.Drawing.Color.Transparent;
            this.SearchEngine.FormattingEnabled = true;
            this.SearchEngine.ItemHeight = 23;
            this.SearchEngine.Location = new System.Drawing.Point(1132, 25);
            this.SearchEngine.Name = "SearchEngine";
            this.SearchEngine.Size = new System.Drawing.Size(121, 29);
            this.SearchEngine.TabIndex = 11;
            this.SearchEngine.UseSelectable = true;
            this.SearchEngine.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BarreRecherche_KeyUp);
            // 
            // BarreRecherche
            // 
            this.BarreRecherche.Lines = new string[0];
            this.BarreRecherche.Location = new System.Drawing.Point(1294, 25);
            this.BarreRecherche.MaxLength = 32767;
            this.BarreRecherche.Name = "BarreRecherche";
            this.BarreRecherche.PasswordChar = '\0';
            this.BarreRecherche.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.BarreRecherche.SelectedText = "";
            this.BarreRecherche.Size = new System.Drawing.Size(274, 29);
            this.BarreRecherche.TabIndex = 12;
            this.BarreRecherche.UseSelectable = true;
            this.BarreRecherche.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BarreRecherche_KeyUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Parametre});
            this.menuStrip1.Location = new System.Drawing.Point(1571, 30);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(110, 24);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // Parametre
            // 
            this.Parametre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Parametre.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.editionToolStripMenuItem,
            this.historiqueToolStripMenuItem1,
            this.marquePageToolStripMenuItem1,
            this.optionsAvancéesToolStripMenuItem,
            this.aideToolStripMenuItem1});
            this.Parametre.Image = global::Vortex.Properties.Resources.Parametre;
            this.Parametre.Name = "Parametre";
            this.Parametre.Size = new System.Drawing.Size(102, 20);
            this.Parametre.Text = "PARAMETRE";
            this.Parametre.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouvelleFenetreToolStripMenuItem,
            this.nouveauOngletToolStripMenuItem,
            this.navigationPrivéeToolStripMenuItem,
            this.toolStripSeparator1,
            this.imprimerToolStripMenuItem1,
            this.aperçuAvantImpressionToolStripMenuItem1,
            this.toolStripSeparator6,
            this.quitterToolStripMenuItem1});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.fichierToolStripMenuItem.Text = "&Fichier";
            // 
            // nouvelleFenetreToolStripMenuItem
            // 
            this.nouvelleFenetreToolStripMenuItem.Name = "nouvelleFenetreToolStripMenuItem";
            this.nouvelleFenetreToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.nouvelleFenetreToolStripMenuItem.Text = "&Nouvelle Fenetre";
            // 
            // nouveauOngletToolStripMenuItem
            // 
            this.nouveauOngletToolStripMenuItem.Name = "nouveauOngletToolStripMenuItem";
            this.nouveauOngletToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.nouveauOngletToolStripMenuItem.Text = "&Nouveau Onglet";
            // 
            // navigationPrivéeToolStripMenuItem
            // 
            this.navigationPrivéeToolStripMenuItem.Name = "navigationPrivéeToolStripMenuItem";
            this.navigationPrivéeToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.navigationPrivéeToolStripMenuItem.Text = "&Navigation Privée";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(202, 6);
            // 
            // imprimerToolStripMenuItem1
            // 
            this.imprimerToolStripMenuItem1.Name = "imprimerToolStripMenuItem1";
            this.imprimerToolStripMenuItem1.Size = new System.Drawing.Size(205, 22);
            this.imprimerToolStripMenuItem1.Text = "&Imprimer";
            // 
            // aperçuAvantImpressionToolStripMenuItem1
            // 
            this.aperçuAvantImpressionToolStripMenuItem1.Name = "aperçuAvantImpressionToolStripMenuItem1";
            this.aperçuAvantImpressionToolStripMenuItem1.Size = new System.Drawing.Size(205, 22);
            this.aperçuAvantImpressionToolStripMenuItem1.Text = "&Aperçu avant impression";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(202, 6);
            // 
            // quitterToolStripMenuItem1
            // 
            this.quitterToolStripMenuItem1.Name = "quitterToolStripMenuItem1";
            this.quitterToolStripMenuItem1.Size = new System.Drawing.Size(205, 22);
            this.quitterToolStripMenuItem1.Text = "&Quitter";
            // 
            // editionToolStripMenuItem
            // 
            this.editionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.annulerToolStripMenuItem1,
            this.rétablirToolStripMenuItem1,
            this.toolStripSeparator7,
            this.copierToolStripMenuItem1,
            this.collerToolStripMenuItem1,
            this.couperToolStripMenuItem1,
            this.toolStripSeparator8,
            this.sélectionnerToutToolStripMenuItem1});
            this.editionToolStripMenuItem.Name = "editionToolStripMenuItem";
            this.editionToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.editionToolStripMenuItem.Text = "&Edition";
            // 
            // annulerToolStripMenuItem1
            // 
            this.annulerToolStripMenuItem1.Name = "annulerToolStripMenuItem1";
            this.annulerToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.annulerToolStripMenuItem1.Text = "&Annuler";
            // 
            // rétablirToolStripMenuItem1
            // 
            this.rétablirToolStripMenuItem1.Name = "rétablirToolStripMenuItem1";
            this.rétablirToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.rétablirToolStripMenuItem1.Text = "&Rétablir";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(161, 6);
            // 
            // copierToolStripMenuItem1
            // 
            this.copierToolStripMenuItem1.Name = "copierToolStripMenuItem1";
            this.copierToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.copierToolStripMenuItem1.Text = "C&opier";
            // 
            // collerToolStripMenuItem1
            // 
            this.collerToolStripMenuItem1.Name = "collerToolStripMenuItem1";
            this.collerToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.collerToolStripMenuItem1.Text = "Coll&er";
            // 
            // couperToolStripMenuItem1
            // 
            this.couperToolStripMenuItem1.Name = "couperToolStripMenuItem1";
            this.couperToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.couperToolStripMenuItem1.Text = "Co&uper";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(161, 6);
            // 
            // sélectionnerToutToolStripMenuItem1
            // 
            this.sélectionnerToutToolStripMenuItem1.Name = "sélectionnerToutToolStripMenuItem1";
            this.sélectionnerToutToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.sélectionnerToutToolStripMenuItem1.Text = "Sélection&ner tout";
            // 
            // historiqueToolStripMenuItem1
            // 
            this.historiqueToolStripMenuItem1.Name = "historiqueToolStripMenuItem1";
            this.historiqueToolStripMenuItem1.Size = new System.Drawing.Size(169, 22);
            this.historiqueToolStripMenuItem1.Text = "&Historique";
            // 
            // marquePageToolStripMenuItem1
            // 
            this.marquePageToolStripMenuItem1.Name = "marquePageToolStripMenuItem1";
            this.marquePageToolStripMenuItem1.Size = new System.Drawing.Size(169, 22);
            this.marquePageToolStripMenuItem1.Text = "&Marque-Page";
            // 
            // optionsAvancéesToolStripMenuItem
            // 
            this.optionsAvancéesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personaliserToolStripMenuItem});
            this.optionsAvancéesToolStripMenuItem.Name = "optionsAvancéesToolStripMenuItem";
            this.optionsAvancéesToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.optionsAvancéesToolStripMenuItem.Text = "&Options Avancées";
            // 
            // personaliserToolStripMenuItem
            // 
            this.personaliserToolStripMenuItem.Name = "personaliserToolStripMenuItem";
            this.personaliserToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.personaliserToolStripMenuItem.Text = "&Personaliser";
            // 
            // aideToolStripMenuItem1
            // 
            this.aideToolStripMenuItem1.Name = "aideToolStripMenuItem1";
            this.aideToolStripMenuItem1.Size = new System.Drawing.Size(169, 22);
            this.aideToolStripMenuItem1.Text = "&Aide";
            // 
            // Home
            // 
            this.Home.BackgroundImage = global::Vortex.Properties.Resources.Home;
            this.Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Home.FlatAppearance.BorderSize = 0;
            this.Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home.Location = new System.Drawing.Point(1056, 22);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(37, 32);
            this.Home.TabIndex = 16;
            this.Home.UseVisualStyleBackColor = true;
            // 
            // Telechargement
            // 
            this.Telechargement.BackgroundImage = global::Vortex.Properties.Resources.Telechargement;
            this.Telechargement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Telechargement.FlatAppearance.BorderSize = 0;
            this.Telechargement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Telechargement.Location = new System.Drawing.Point(1012, 24);
            this.Telechargement.Name = "Telechargement";
            this.Telechargement.Size = new System.Drawing.Size(38, 30);
            this.Telechargement.TabIndex = 15;
            this.Telechargement.UseVisualStyleBackColor = true;
            // 
            // Stop
            // 
            this.Stop.BackgroundImage = global::Vortex.Properties.Resources.Stop;
            this.Stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Stop.FlatAppearance.BorderSize = 0;
            this.Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Stop.Location = new System.Drawing.Point(976, 22);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(30, 31);
            this.Stop.TabIndex = 14;
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // LogoVortex
            // 
            this.LogoVortex.Image = ((System.Drawing.Image)(resources.GetObject("LogoVortex.Image")));
            this.LogoVortex.Location = new System.Drawing.Point(52, 5);
            this.LogoVortex.Name = "LogoVortex";
            this.LogoVortex.Size = new System.Drawing.Size(195, 58);
            this.LogoVortex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoVortex.TabIndex = 13;
            this.LogoVortex.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Vortex.Properties.Resources.Vortex_Icone;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 56);
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Vortex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackLocation = MetroFramework.Forms.BackLocation.TopRight;
            this.ClientSize = new System.Drawing.Size(1680, 1050);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.Telechargement);
            this.Controls.Add(this.BarreRecherche);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.SearchEngine);
            this.Controls.Add(this.PageOnglet);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.BarreAdresse);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LogoVortex);
            this.MainMenuStrip = this.miniToolStrip;
            this.Name = "Vortex";
            this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.Style = MetroFramework.MetroColorStyle.Pink;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Vortex_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PageOnglet)).EndInit();
            this.PageOnglet.ResumeLayout(false);
            this.TabControlPanel.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoVortex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip miniToolStrip;
        private MetroFramework.Controls.MetroTextBox BarreAdresse;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private DevComponents.DotNetBar.SuperTabControl PageOnglet;
        private DevComponents.DotNetBar.SuperTabControlPanel TabControlPanel;
        private System.Windows.Forms.WebBrowser Browser;
        private DevComponents.DotNetBar.SuperTabItem Onglet;
        private System.Windows.Forms.ImageList imageList1;
        private MetroFramework.Controls.MetroComboBox SearchEngine;
        private MetroFramework.Controls.MetroTextBox BarreRecherche;
        private System.Windows.Forms.PictureBox LogoVortex;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Parametre;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouvelleFenetreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauOngletToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem navigationPrivéeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem imprimerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aperçuAvantImpressionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem annulerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rétablirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem copierToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem collerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem couperToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem historiqueToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem marquePageToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem optionsAvancéesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sélectionnerToutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem personaliserToolStripMenuItem;
        private System.Windows.Forms.Button Telechargement;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Button button1;

    }
}

