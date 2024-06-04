namespace youtubedownloader
{
    partial class main
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.panelmover = new System.Windows.Forms.Panel();
            this.btnhide = new System.Windows.Forms.PictureBox();
            this.btnclose = new System.Windows.Forms.PictureBox();
            this.picurl = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.picsearch = new System.Windows.Forms.PictureBox();
            this.picsettings = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelsettings = new System.Windows.Forms.Panel();
            this.lblversion = new System.Windows.Forms.Label();
            this.piclinktree = new System.Windows.Forms.PictureBox();
            this.pickofi = new System.Windows.Forms.PictureBox();
            this.picseparator = new System.Windows.Forms.PictureBox();
            this.picgithub = new System.Windows.Forms.PictureBox();
            this.labeltheme = new System.Windows.Forms.Label();
            this.checkboxtheme = new System.Windows.Forms.CheckBox();
            this.panelurl = new System.Windows.Forms.Panel();
            this.textboxsearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelresult = new System.Windows.Forms.Panel();
            this.textboxnamer = new System.Windows.Forms.TextBox();
            this.textboxdescriptionr = new System.Windows.Forms.TextBox();
            this.picthumb = new System.Windows.Forms.PictureBox();
            this.btndownload = new System.Windows.Forms.Button();
            this.labeldescription = new System.Windows.Forms.Label();
            this.labelname = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panelsearch = new System.Windows.Forms.Panel();
            this.panelsresult = new System.Windows.Forms.Panel();
            this.lblwarn = new System.Windows.Forms.Label();
            this.tboxsearch = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.labelsearch = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.panelmover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnhide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picurl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picsearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picsettings)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelsettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piclinktree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickofi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picseparator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picgithub)).BeginInit();
            this.panelurl.SuspendLayout();
            this.panelresult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picthumb)).BeginInit();
            this.panelsearch.SuspendLayout();
            this.panelsresult.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelmover
            // 
            this.panelmover.BackColor = global::youtubedownloader.Properties.Settings.Default.panelmoverlight;
            this.panelmover.Controls.Add(this.btnhide);
            this.panelmover.Controls.Add(this.btnclose);
            this.panelmover.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::youtubedownloader.Properties.Settings.Default, "panelmoverlight", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.panelmover.Location = new System.Drawing.Point(-2, -1);
            this.panelmover.Name = "panelmover";
            this.panelmover.Size = new System.Drawing.Size(993, 60);
            this.panelmover.TabIndex = 0;
            this.panelmover.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelmover_MouseDown);
            // 
            // btnhide
            // 
            this.btnhide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnhide.Image = ((System.Drawing.Image)(resources.GetObject("btnhide.Image")));
            this.btnhide.Location = new System.Drawing.Point(685, 7);
            this.btnhide.Name = "btnhide";
            this.btnhide.Size = new System.Drawing.Size(45, 45);
            this.btnhide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnhide.TabIndex = 2;
            this.btnhide.TabStop = false;
            this.btnhide.Click += new System.EventHandler(this.btnhide_Click);
            // 
            // btnclose
            // 
            this.btnclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.Location = new System.Drawing.Point(745, 7);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(45, 45);
            this.btnclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnclose.TabIndex = 1;
            this.btnclose.TabStop = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // picurl
            // 
            this.picurl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picurl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picurl.Image = ((System.Drawing.Image)(resources.GetObject("picurl.Image")));
            this.picurl.Location = new System.Drawing.Point(4, 5);
            this.picurl.Name = "picurl";
            this.picurl.Size = new System.Drawing.Size(56, 50);
            this.picurl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picurl.TabIndex = 6;
            this.picurl.TabStop = false;
            this.picurl.Click += new System.EventHandler(this.picurl_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // picsearch
            // 
            this.picsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picsearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picsearch.Image = ((System.Drawing.Image)(resources.GetObject("picsearch.Image")));
            this.picsearch.Location = new System.Drawing.Point(66, 5);
            this.picsearch.Name = "picsearch";
            this.picsearch.Size = new System.Drawing.Size(56, 50);
            this.picsearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picsearch.TabIndex = 7;
            this.picsearch.TabStop = false;
            this.picsearch.Click += new System.EventHandler(this.picsearch_Click);
            // 
            // picsettings
            // 
            this.picsettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picsettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picsettings.Image = ((System.Drawing.Image)(resources.GetObject("picsettings.Image")));
            this.picsettings.Location = new System.Drawing.Point(128, 5);
            this.picsettings.Name = "picsettings";
            this.picsettings.Size = new System.Drawing.Size(56, 50);
            this.picsettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picsettings.TabIndex = 8;
            this.picsettings.TabStop = false;
            this.picsettings.Click += new System.EventHandler(this.picsettings_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = global::youtubedownloader.Properties.Settings.Default.lightpanel;
            this.panel1.Controls.Add(this.picurl);
            this.panel1.Controls.Add(this.picsettings);
            this.panel1.Controls.Add(this.picsearch);
            this.panel1.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::youtubedownloader.Properties.Settings.Default, "lightpanel", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.panel1.Location = new System.Drawing.Point(11, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 59);
            this.panel1.TabIndex = 9;
            // 
            // panelsettings
            // 
            this.panelsettings.BackColor = global::youtubedownloader.Properties.Settings.Default.lightform;
            this.panelsettings.Controls.Add(this.lblversion);
            this.panelsettings.Controls.Add(this.piclinktree);
            this.panelsettings.Controls.Add(this.pickofi);
            this.panelsettings.Controls.Add(this.picseparator);
            this.panelsettings.Controls.Add(this.picgithub);
            this.panelsettings.Controls.Add(this.labeltheme);
            this.panelsettings.Controls.Add(this.checkboxtheme);
            this.panelsettings.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::youtubedownloader.Properties.Settings.Default, "lightform", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.panelsettings.Location = new System.Drawing.Point(794, 59);
            this.panelsettings.Name = "panelsettings";
            this.panelsettings.Size = new System.Drawing.Size(197, 396);
            this.panelsettings.TabIndex = 5;
            // 
            // lblversion
            // 
            this.lblversion.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::youtubedownloader.Properties.Settings.Default, "lighttext", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblversion.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblversion.ForeColor = global::youtubedownloader.Properties.Settings.Default.lighttext;
            this.lblversion.Location = new System.Drawing.Point(65, 275);
            this.lblversion.Name = "lblversion";
            this.lblversion.Size = new System.Drawing.Size(107, 12);
            this.lblversion.TabIndex = 13;
            this.lblversion.Text = "Version: N/A";
            // 
            // piclinktree
            // 
            this.piclinktree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.piclinktree.ErrorImage = ((System.Drawing.Image)(resources.GetObject("piclinktree.ErrorImage")));
            this.piclinktree.Image = ((System.Drawing.Image)(resources.GetObject("piclinktree.Image")));
            this.piclinktree.Location = new System.Drawing.Point(123, 327);
            this.piclinktree.Name = "piclinktree";
            this.piclinktree.Size = new System.Drawing.Size(40, 41);
            this.piclinktree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.piclinktree.TabIndex = 11;
            this.piclinktree.TabStop = false;
            this.piclinktree.Click += new System.EventHandler(this.piclinktree_Click);
            // 
            // pickofi
            // 
            this.pickofi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pickofi.Image = ((System.Drawing.Image)(resources.GetObject("pickofi.Image")));
            this.pickofi.Location = new System.Drawing.Point(29, 327);
            this.pickofi.Name = "pickofi";
            this.pickofi.Size = new System.Drawing.Size(42, 41);
            this.pickofi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pickofi.TabIndex = 10;
            this.pickofi.TabStop = false;
            this.pickofi.Click += new System.EventHandler(this.pickofi_Click);
            // 
            // picseparator
            // 
            this.picseparator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picseparator.BackgroundImage")));
            this.picseparator.Image = ((System.Drawing.Image)(resources.GetObject("picseparator.Image")));
            this.picseparator.Location = new System.Drawing.Point(13, 290);
            this.picseparator.Name = "picseparator";
            this.picseparator.Size = new System.Drawing.Size(166, 31);
            this.picseparator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picseparator.TabIndex = 9;
            this.picseparator.TabStop = false;
            // 
            // picgithub
            // 
            this.picgithub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picgithub.Image = ((System.Drawing.Image)(resources.GetObject("picgithub.Image")));
            this.picgithub.Location = new System.Drawing.Point(77, 327);
            this.picgithub.Name = "picgithub";
            this.picgithub.Size = new System.Drawing.Size(40, 41);
            this.picgithub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picgithub.TabIndex = 5;
            this.picgithub.TabStop = false;
            this.picgithub.Click += new System.EventHandler(this.picgithub_Click);
            // 
            // labeltheme
            // 
            this.labeltheme.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::youtubedownloader.Properties.Settings.Default, "lighttext", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.labeltheme.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltheme.ForeColor = global::youtubedownloader.Properties.Settings.Default.lighttext;
            this.labeltheme.Location = new System.Drawing.Point(8, 9);
            this.labeltheme.Name = "labeltheme";
            this.labeltheme.Size = new System.Drawing.Size(108, 29);
            this.labeltheme.TabIndex = 5;
            this.labeltheme.Text = "THEME:";
            // 
            // checkboxtheme
            // 
            this.checkboxtheme.AutoSize = true;
            this.checkboxtheme.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::youtubedownloader.Properties.Settings.Default, "lighttext", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkboxtheme.ForeColor = global::youtubedownloader.Properties.Settings.Default.lighttext;
            this.checkboxtheme.Location = new System.Drawing.Point(13, 41);
            this.checkboxtheme.Name = "checkboxtheme";
            this.checkboxtheme.Size = new System.Drawing.Size(78, 17);
            this.checkboxtheme.TabIndex = 0;
            this.checkboxtheme.Text = "Dark mode";
            this.checkboxtheme.UseVisualStyleBackColor = true;
            this.checkboxtheme.CheckedChanged += new System.EventHandler(this.checkboxtheme_CheckedChanged);
            // 
            // panelurl
            // 
            this.panelurl.BackColor = global::youtubedownloader.Properties.Settings.Default.lightpanel;
            this.panelurl.Controls.Add(this.textboxsearch);
            this.panelurl.Controls.Add(this.label1);
            this.panelurl.Controls.Add(this.panelresult);
            this.panelurl.Controls.Add(this.button1);
            this.panelurl.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::youtubedownloader.Properties.Settings.Default, "lightpanel", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.panelurl.Location = new System.Drawing.Point(11, 131);
            this.panelurl.Name = "panelurl";
            this.panelurl.Size = new System.Drawing.Size(777, 310);
            this.panelurl.TabIndex = 5;
            this.panelurl.Visible = false;
            // 
            // textboxsearch
            // 
            this.textboxsearch.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxsearch.Location = new System.Drawing.Point(12, 35);
            this.textboxsearch.Multiline = true;
            this.textboxsearch.Name = "textboxsearch";
            this.textboxsearch.Size = new System.Drawing.Size(634, 34);
            this.textboxsearch.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = global::youtubedownloader.Properties.Settings.Default.lightpanel;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::youtubedownloader.Properties.Settings.Default, "lightpanel", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::youtubedownloader.Properties.Settings.Default, "lighttext", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label1.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = global::youtubedownloader.Properties.Settings.Default.lighttext;
            this.label1.Location = new System.Drawing.Point(8, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL:";
            // 
            // panelresult
            // 
            this.panelresult.BackColor = System.Drawing.Color.Transparent;
            this.panelresult.Controls.Add(this.textboxnamer);
            this.panelresult.Controls.Add(this.textboxdescriptionr);
            this.panelresult.Controls.Add(this.picthumb);
            this.panelresult.Controls.Add(this.btndownload);
            this.panelresult.Controls.Add(this.labeldescription);
            this.panelresult.Controls.Add(this.labelname);
            this.panelresult.Location = new System.Drawing.Point(12, 75);
            this.panelresult.Name = "panelresult";
            this.panelresult.Size = new System.Drawing.Size(756, 238);
            this.panelresult.TabIndex = 4;
            this.panelresult.Visible = false;
            // 
            // textboxnamer
            // 
            this.textboxnamer.BackColor = global::youtubedownloader.Properties.Settings.Default.lightpanel;
            this.textboxnamer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxnamer.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::youtubedownloader.Properties.Settings.Default, "lightpanel", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textboxnamer.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::youtubedownloader.Properties.Settings.Default, "lighttext", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textboxnamer.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxnamer.ForeColor = global::youtubedownloader.Properties.Settings.Default.lighttext;
            this.textboxnamer.Location = new System.Drawing.Point(15, 39);
            this.textboxnamer.Multiline = true;
            this.textboxnamer.Name = "textboxnamer";
            this.textboxnamer.ReadOnly = true;
            this.textboxnamer.Size = new System.Drawing.Size(516, 49);
            this.textboxnamer.TabIndex = 7;
            this.textboxnamer.Text = "N/A";
            // 
            // textboxdescriptionr
            // 
            this.textboxdescriptionr.BackColor = global::youtubedownloader.Properties.Settings.Default.lightpanel;
            this.textboxdescriptionr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxdescriptionr.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::youtubedownloader.Properties.Settings.Default, "lightpanel", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textboxdescriptionr.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::youtubedownloader.Properties.Settings.Default, "lighttext", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textboxdescriptionr.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxdescriptionr.ForeColor = global::youtubedownloader.Properties.Settings.Default.lighttext;
            this.textboxdescriptionr.Location = new System.Drawing.Point(15, 120);
            this.textboxdescriptionr.Multiline = true;
            this.textboxdescriptionr.Name = "textboxdescriptionr";
            this.textboxdescriptionr.ReadOnly = true;
            this.textboxdescriptionr.Size = new System.Drawing.Size(516, 108);
            this.textboxdescriptionr.TabIndex = 6;
            this.textboxdescriptionr.Text = "N/A";
            // 
            // picthumb
            // 
            this.picthumb.Location = new System.Drawing.Point(551, 8);
            this.picthumb.Name = "picthumb";
            this.picthumb.Size = new System.Drawing.Size(198, 166);
            this.picthumb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picthumb.TabIndex = 5;
            this.picthumb.TabStop = false;
            // 
            // btndownload
            // 
            this.btndownload.BackColor = global::youtubedownloader.Properties.Settings.Default.lightform;
            this.btndownload.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::youtubedownloader.Properties.Settings.Default, "lighttext", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btndownload.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::youtubedownloader.Properties.Settings.Default, "lightform", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btndownload.ForeColor = global::youtubedownloader.Properties.Settings.Default.lighttext;
            this.btndownload.Location = new System.Drawing.Point(551, 180);
            this.btndownload.Name = "btndownload";
            this.btndownload.Size = new System.Drawing.Size(202, 48);
            this.btndownload.TabIndex = 4;
            this.btndownload.Text = "Download";
            this.btndownload.UseVisualStyleBackColor = false;
            this.btndownload.Click += new System.EventHandler(this.btndownload_Click);
            // 
            // labeldescription
            // 
            this.labeldescription.AutoSize = true;
            this.labeldescription.BackColor = global::youtubedownloader.Properties.Settings.Default.lightpanel;
            this.labeldescription.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::youtubedownloader.Properties.Settings.Default, "lightpanel", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.labeldescription.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::youtubedownloader.Properties.Settings.Default, "lighttext", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.labeldescription.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldescription.ForeColor = global::youtubedownloader.Properties.Settings.Default.lighttext;
            this.labeldescription.Location = new System.Drawing.Point(11, 91);
            this.labeldescription.Name = "labeldescription";
            this.labeldescription.Size = new System.Drawing.Size(166, 21);
            this.labeldescription.TabIndex = 2;
            this.labeldescription.Text = "Description:";
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.BackColor = global::youtubedownloader.Properties.Settings.Default.lightpanel;
            this.labelname.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::youtubedownloader.Properties.Settings.Default, "lightpanel", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.labelname.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::youtubedownloader.Properties.Settings.Default, "lighttext", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.labelname.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelname.ForeColor = global::youtubedownloader.Properties.Settings.Default.lighttext;
            this.labelname.Location = new System.Drawing.Point(11, 13);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(153, 21);
            this.labelname.TabIndex = 0;
            this.labelname.Text = "Video Name:";
            // 
            // button1
            // 
            this.button1.BackColor = global::youtubedownloader.Properties.Settings.Default.lightform;
            this.button1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::youtubedownloader.Properties.Settings.Default, "lighttext", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button1.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::youtubedownloader.Properties.Settings.Default, "lightform", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button1.ForeColor = global::youtubedownloader.Properties.Settings.Default.lighttext;
            this.button1.Location = new System.Drawing.Point(653, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelsearch
            // 
            this.panelsearch.BackColor = global::youtubedownloader.Properties.Settings.Default.lightpanel;
            this.panelsearch.Controls.Add(this.panelsresult);
            this.panelsearch.Controls.Add(this.tboxsearch);
            this.panelsearch.Controls.Add(this.btnsearch);
            this.panelsearch.Controls.Add(this.labelsearch);
            this.panelsearch.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::youtubedownloader.Properties.Settings.Default, "lightpanel", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.panelsearch.Location = new System.Drawing.Point(8, 132);
            this.panelsearch.Name = "panelsearch";
            this.panelsearch.Size = new System.Drawing.Size(780, 316);
            this.panelsearch.TabIndex = 6;
            this.panelsearch.Visible = false;
            // 
            // panelsresult
            // 
            this.panelsresult.BackColor = global::youtubedownloader.Properties.Settings.Default.lightpanel;
            this.panelsresult.Controls.Add(this.lblwarn);
            this.panelsresult.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::youtubedownloader.Properties.Settings.Default, "lightpanel", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.panelsresult.Location = new System.Drawing.Point(13, 73);
            this.panelsresult.Name = "panelsresult";
            this.panelsresult.Size = new System.Drawing.Size(763, 236);
            this.panelsresult.TabIndex = 7;
            // 
            // lblwarn
            // 
            this.lblwarn.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::youtubedownloader.Properties.Settings.Default, "lighttext", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblwarn.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwarn.ForeColor = global::youtubedownloader.Properties.Settings.Default.lighttext;
            this.lblwarn.Location = new System.Drawing.Point(-1, 9);
            this.lblwarn.Name = "lblwarn";
            this.lblwarn.Size = new System.Drawing.Size(382, 29);
            this.lblwarn.TabIndex = 12;
            this.lblwarn.Text = "Results coming soon...";
            // 
            // tboxsearch
            // 
            this.tboxsearch.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxsearch.Location = new System.Drawing.Point(15, 34);
            this.tboxsearch.Multiline = true;
            this.tboxsearch.Name = "tboxsearch";
            this.tboxsearch.Size = new System.Drawing.Size(634, 34);
            this.tboxsearch.TabIndex = 4;
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = global::youtubedownloader.Properties.Settings.Default.lightform;
            this.btnsearch.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::youtubedownloader.Properties.Settings.Default, "lighttext", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnsearch.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::youtubedownloader.Properties.Settings.Default, "lightform", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnsearch.ForeColor = global::youtubedownloader.Properties.Settings.Default.lighttext;
            this.btnsearch.Location = new System.Drawing.Point(656, 34);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(115, 34);
            this.btnsearch.TabIndex = 5;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // labelsearch
            // 
            this.labelsearch.BackColor = global::youtubedownloader.Properties.Settings.Default.lightpanel;
            this.labelsearch.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::youtubedownloader.Properties.Settings.Default, "lightpanel", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.labelsearch.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::youtubedownloader.Properties.Settings.Default, "lighttext", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.labelsearch.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsearch.ForeColor = global::youtubedownloader.Properties.Settings.Default.lighttext;
            this.labelsearch.Location = new System.Drawing.Point(10, 6);
            this.labelsearch.Name = "labelsearch";
            this.labelsearch.Size = new System.Drawing.Size(126, 23);
            this.labelsearch.TabIndex = 1;
            this.labelsearch.Text = "Search:";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(11, 466);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(777, 23);
            this.progressBar.TabIndex = 0;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::youtubedownloader.Properties.Settings.Default.lightform;
            this.ClientSize = new System.Drawing.Size(988, 512);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.panelsearch);
            this.Controls.Add(this.panelsettings);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelurl);
            this.Controls.Add(this.panelmover);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::youtubedownloader.Properties.Settings.Default, "lightform", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Youtube Downloader";
            this.Load += new System.EventHandler(this.main_Load);
            this.panelmover.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnhide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picurl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picsearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picsettings)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelsettings.ResumeLayout(false);
            this.panelsettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piclinktree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickofi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picseparator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picgithub)).EndInit();
            this.panelurl.ResumeLayout(false);
            this.panelurl.PerformLayout();
            this.panelresult.ResumeLayout(false);
            this.panelresult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picthumb)).EndInit();
            this.panelsearch.ResumeLayout(false);
            this.panelsearch.PerformLayout();
            this.panelsresult.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelmover;
        private System.Windows.Forms.PictureBox btnhide;
        private System.Windows.Forms.PictureBox btnclose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxsearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelresult;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Button btndownload;
        private System.Windows.Forms.Panel panelurl;
        private System.Windows.Forms.PictureBox picurl;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label labeldescription;
        private System.Windows.Forms.PictureBox picthumb;
        private System.Windows.Forms.TextBox textboxdescriptionr;
        private System.Windows.Forms.TextBox textboxnamer;
        private System.Windows.Forms.PictureBox picsearch;
        private System.Windows.Forms.PictureBox picsettings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelsettings;
        private System.Windows.Forms.Label labeltheme;
        private System.Windows.Forms.CheckBox checkboxtheme;
        private System.Windows.Forms.PictureBox picgithub;
        private System.Windows.Forms.Panel panelsearch;
        private System.Windows.Forms.Label labelsearch;
        private System.Windows.Forms.Panel panelsresult;
        private System.Windows.Forms.TextBox tboxsearch;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.PictureBox picseparator;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.PictureBox pickofi;
        private System.Windows.Forms.PictureBox piclinktree;
        private System.Windows.Forms.Label lblwarn;
        private System.Windows.Forms.Label lblversion;
    }
}

