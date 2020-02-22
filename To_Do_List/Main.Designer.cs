namespace To_Do_List
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Time = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.BackPanel = new System.Windows.Forms.Panel();
            this.learning1 = new To_Do_List.Learning();
            this.books1 = new To_Do_List.Books();
            this.targets1 = new To_Do_List.Targets();
            this.ideas1 = new To_Do_List.Ideas();
            this.done1 = new To_Do_List.Done();
            this.LeftPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.DoneListButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LearningButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ExitButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.MinimizeButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.IdeasButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TargetsButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BooksButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EnableInsertName = new Bunifu.Framework.UI.BunifuImageButton();
            this.InsertImage = new Bunifu.Framework.UI.BunifuImageButton();
            this.InsertName = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.Label();
            this.LeftPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EnableInsertName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InsertImage)).BeginInit();
            this.SuspendLayout();
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Dock = System.Windows.Forms.DockStyle.Right;
            this.Time.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(71)))), ((int)(((byte)(127)))));
            this.Time.Location = new System.Drawing.Point(719, 0);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(125, 36);
            this.Time.TabIndex = 5;
            this.Time.Text = "00:00:00";
            // 
            // Date
            // 
            this.Date.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(71)))), ((int)(((byte)(127)))));
            this.Date.Location = new System.Drawing.Point(458, 36);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(386, 33);
            this.Date.TabIndex = 6;
            this.Date.Text = "6 February 2020";
            this.Date.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 60000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.panel1;
            this.bunifuDragControl2.Vertical = true;
            // 
            // BackPanel
            // 
            this.BackPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(90)))), ((int)(((byte)(130)))));
            this.BackPanel.ForeColor = System.Drawing.Color.Transparent;
            this.BackPanel.Location = new System.Drawing.Point(190, 154);
            this.BackPanel.Name = "BackPanel";
            this.BackPanel.Size = new System.Drawing.Size(10, 65);
            this.BackPanel.TabIndex = 10;
            // 
            // learning1
            // 
            this.learning1.Location = new System.Drawing.Point(200, 115);
            this.learning1.Name = "learning1";
            this.learning1.Size = new System.Drawing.Size(650, 420);
            this.learning1.TabIndex = 0;
            // 
            // books1
            // 
            this.books1.Location = new System.Drawing.Point(200, 115);
            this.books1.Name = "books1";
            this.books1.Size = new System.Drawing.Size(650, 420);
            this.books1.TabIndex = 3;
            // 
            // targets1
            // 
            this.targets1.AutoScroll = true;
            this.targets1.Location = new System.Drawing.Point(200, 115);
            this.targets1.Name = "targets1";
            this.targets1.Size = new System.Drawing.Size(650, 420);
            this.targets1.TabIndex = 2;
            // 
            // ideas1
            // 
            this.ideas1.Location = new System.Drawing.Point(200, 115);
            this.ideas1.Name = "ideas1";
            this.ideas1.Size = new System.Drawing.Size(650, 420);
            this.ideas1.TabIndex = 1;
            // 
            // done1
            // 
            this.done1.Location = new System.Drawing.Point(200, 115);
            this.done1.Name = "done1";
            this.done1.Size = new System.Drawing.Size(650, 420);
            this.done1.TabIndex = 11;
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LeftPanel.BackgroundImage")));
            this.LeftPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LeftPanel.Controls.Add(this.DoneListButton);
            this.LeftPanel.Controls.Add(this.LearningButton);
            this.LeftPanel.Controls.Add(this.ExitButton);
            this.LeftPanel.Controls.Add(this.MinimizeButton);
            this.LeftPanel.Controls.Add(this.IdeasButton);
            this.LeftPanel.Controls.Add(this.TargetsButton);
            this.LeftPanel.Controls.Add(this.BooksButton);
            this.LeftPanel.Controls.Add(this.panel1);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(177)))), ((int)(((byte)(231)))));
            this.LeftPanel.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(31)))), ((int)(((byte)(144)))));
            this.LeftPanel.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(65)))), ((int)(((byte)(154)))));
            this.LeftPanel.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Quality = 10;
            this.LeftPanel.Size = new System.Drawing.Size(200, 531);
            this.LeftPanel.TabIndex = 0;
            // 
            // DoneListButton
            // 
            this.DoneListButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.DoneListButton.BackColor = System.Drawing.Color.Transparent;
            this.DoneListButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DoneListButton.BorderRadius = 0;
            this.DoneListButton.ButtonText = "   Done";
            this.DoneListButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoneListButton.DisabledColor = System.Drawing.Color.Gray;
            this.DoneListButton.Iconcolor = System.Drawing.Color.Transparent;
            this.DoneListButton.Iconimage = global::To_Do_List.Properties.Resources.unnamed;
            this.DoneListButton.Iconimage_right = null;
            this.DoneListButton.Iconimage_right_Selected = null;
            this.DoneListButton.Iconimage_Selected = null;
            this.DoneListButton.IconMarginLeft = 0;
            this.DoneListButton.IconMarginRight = 0;
            this.DoneListButton.IconRightVisible = true;
            this.DoneListButton.IconRightZoom = 0D;
            this.DoneListButton.IconVisible = true;
            this.DoneListButton.IconZoom = 90D;
            this.DoneListButton.IsTab = false;
            this.DoneListButton.Location = new System.Drawing.Point(0, 414);
            this.DoneListButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DoneListButton.Name = "DoneListButton";
            this.DoneListButton.Normalcolor = System.Drawing.Color.Transparent;
            this.DoneListButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.DoneListButton.OnHoverTextColor = System.Drawing.Color.White;
            this.DoneListButton.selected = false;
            this.DoneListButton.Size = new System.Drawing.Size(200, 65);
            this.DoneListButton.TabIndex = 5;
            this.DoneListButton.Text = "   Done";
            this.DoneListButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DoneListButton.Textcolor = System.Drawing.Color.White;
            this.DoneListButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoneListButton.Click += new System.EventHandler(this.DoneListButon_Click);
            // 
            // LearningButton
            // 
            this.LearningButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.LearningButton.BackColor = System.Drawing.Color.Transparent;
            this.LearningButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LearningButton.BorderRadius = 0;
            this.LearningButton.ButtonText = "  Learning";
            this.LearningButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LearningButton.DisabledColor = System.Drawing.Color.Gray;
            this.LearningButton.Iconcolor = System.Drawing.Color.Transparent;
            this.LearningButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("LearningButton.Iconimage")));
            this.LearningButton.Iconimage_right = null;
            this.LearningButton.Iconimage_right_Selected = null;
            this.LearningButton.Iconimage_Selected = null;
            this.LearningButton.IconMarginLeft = 0;
            this.LearningButton.IconMarginRight = 0;
            this.LearningButton.IconRightVisible = true;
            this.LearningButton.IconRightZoom = 0D;
            this.LearningButton.IconVisible = true;
            this.LearningButton.IconZoom = 90D;
            this.LearningButton.IsTab = false;
            this.LearningButton.Location = new System.Drawing.Point(0, 154);
            this.LearningButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LearningButton.Name = "LearningButton";
            this.LearningButton.Normalcolor = System.Drawing.Color.Transparent;
            this.LearningButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.LearningButton.OnHoverTextColor = System.Drawing.Color.White;
            this.LearningButton.selected = false;
            this.LearningButton.Size = new System.Drawing.Size(200, 65);
            this.LearningButton.TabIndex = 1;
            this.LearningButton.Text = "  Learning";
            this.LearningButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LearningButton.Textcolor = System.Drawing.Color.White;
            this.LearningButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LearningButton.Click += new System.EventHandler(this.LearningButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitButton.BorderRadius = 0;
            this.ExitButton.ButtonText = "  Exit";
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ExitButton.DisabledColor = System.Drawing.Color.Gray;
            this.ExitButton.Iconcolor = System.Drawing.Color.Transparent;
            this.ExitButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("ExitButton.Iconimage")));
            this.ExitButton.Iconimage_right = null;
            this.ExitButton.Iconimage_right_Selected = null;
            this.ExitButton.Iconimage_Selected = null;
            this.ExitButton.IconMarginLeft = 0;
            this.ExitButton.IconMarginRight = 0;
            this.ExitButton.IconRightVisible = true;
            this.ExitButton.IconRightZoom = 0D;
            this.ExitButton.IconVisible = true;
            this.ExitButton.IconZoom = 60D;
            this.ExitButton.IsTab = false;
            this.ExitButton.Location = new System.Drawing.Point(100, 486);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Normalcolor = System.Drawing.Color.Transparent;
            this.ExitButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.ExitButton.OnHoverTextColor = System.Drawing.Color.White;
            this.ExitButton.selected = false;
            this.ExitButton.Size = new System.Drawing.Size(100, 45);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "  Exit";
            this.ExitButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitButton.Textcolor = System.Drawing.Color.White;
            this.ExitButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.MinimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MinimizeButton.BorderRadius = 0;
            this.MinimizeButton.ButtonText = "  Minimize";
            this.MinimizeButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MinimizeButton.DisabledColor = System.Drawing.Color.Gray;
            this.MinimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeButton.Iconcolor = System.Drawing.Color.Transparent;
            this.MinimizeButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("MinimizeButton.Iconimage")));
            this.MinimizeButton.Iconimage_right = null;
            this.MinimizeButton.Iconimage_right_Selected = null;
            this.MinimizeButton.Iconimage_Selected = null;
            this.MinimizeButton.IconMarginLeft = 0;
            this.MinimizeButton.IconMarginRight = 0;
            this.MinimizeButton.IconRightVisible = true;
            this.MinimizeButton.IconRightZoom = 0D;
            this.MinimizeButton.IconVisible = true;
            this.MinimizeButton.IconZoom = 60D;
            this.MinimizeButton.IsTab = false;
            this.MinimizeButton.Location = new System.Drawing.Point(0, 486);
            this.MinimizeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Normalcolor = System.Drawing.Color.Transparent;
            this.MinimizeButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.MinimizeButton.OnHoverTextColor = System.Drawing.Color.White;
            this.MinimizeButton.selected = false;
            this.MinimizeButton.Size = new System.Drawing.Size(100, 45);
            this.MinimizeButton.TabIndex = 6;
            this.MinimizeButton.Text = "  Minimize";
            this.MinimizeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MinimizeButton.Textcolor = System.Drawing.Color.White;
            this.MinimizeButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // IdeasButton
            // 
            this.IdeasButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.IdeasButton.BackColor = System.Drawing.Color.Transparent;
            this.IdeasButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.IdeasButton.BorderRadius = 0;
            this.IdeasButton.ButtonText = "   Ideas";
            this.IdeasButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.IdeasButton.DisabledColor = System.Drawing.Color.Gray;
            this.IdeasButton.Iconcolor = System.Drawing.Color.Transparent;
            this.IdeasButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("IdeasButton.Iconimage")));
            this.IdeasButton.Iconimage_right = null;
            this.IdeasButton.Iconimage_right_Selected = null;
            this.IdeasButton.Iconimage_Selected = null;
            this.IdeasButton.IconMarginLeft = 0;
            this.IdeasButton.IconMarginRight = 0;
            this.IdeasButton.IconRightVisible = true;
            this.IdeasButton.IconRightZoom = 0D;
            this.IdeasButton.IconVisible = true;
            this.IdeasButton.IconZoom = 90D;
            this.IdeasButton.IsTab = false;
            this.IdeasButton.Location = new System.Drawing.Point(0, 349);
            this.IdeasButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IdeasButton.Name = "IdeasButton";
            this.IdeasButton.Normalcolor = System.Drawing.Color.Transparent;
            this.IdeasButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.IdeasButton.OnHoverTextColor = System.Drawing.Color.White;
            this.IdeasButton.selected = false;
            this.IdeasButton.Size = new System.Drawing.Size(200, 65);
            this.IdeasButton.TabIndex = 4;
            this.IdeasButton.Text = "   Ideas";
            this.IdeasButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IdeasButton.Textcolor = System.Drawing.Color.White;
            this.IdeasButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdeasButton.Click += new System.EventHandler(this.IdeasButton_Click);
            // 
            // TargetsButton
            // 
            this.TargetsButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.TargetsButton.BackColor = System.Drawing.Color.Transparent;
            this.TargetsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TargetsButton.BorderRadius = 0;
            this.TargetsButton.ButtonText = "  Tragets";
            this.TargetsButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TargetsButton.DisabledColor = System.Drawing.Color.Gray;
            this.TargetsButton.Iconcolor = System.Drawing.Color.Transparent;
            this.TargetsButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("TargetsButton.Iconimage")));
            this.TargetsButton.Iconimage_right = null;
            this.TargetsButton.Iconimage_right_Selected = null;
            this.TargetsButton.Iconimage_Selected = null;
            this.TargetsButton.IconMarginLeft = 0;
            this.TargetsButton.IconMarginRight = 0;
            this.TargetsButton.IconRightVisible = true;
            this.TargetsButton.IconRightZoom = 0D;
            this.TargetsButton.IconVisible = true;
            this.TargetsButton.IconZoom = 90D;
            this.TargetsButton.IsTab = false;
            this.TargetsButton.Location = new System.Drawing.Point(0, 284);
            this.TargetsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TargetsButton.Name = "TargetsButton";
            this.TargetsButton.Normalcolor = System.Drawing.Color.Transparent;
            this.TargetsButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.TargetsButton.OnHoverTextColor = System.Drawing.Color.White;
            this.TargetsButton.selected = false;
            this.TargetsButton.Size = new System.Drawing.Size(200, 65);
            this.TargetsButton.TabIndex = 0;
            this.TargetsButton.Text = "  Tragets";
            this.TargetsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TargetsButton.Textcolor = System.Drawing.Color.White;
            this.TargetsButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TargetsButton.Click += new System.EventHandler(this.TargetsButton_Click);
            // 
            // BooksButton
            // 
            this.BooksButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.BooksButton.BackColor = System.Drawing.Color.Transparent;
            this.BooksButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BooksButton.BorderRadius = 0;
            this.BooksButton.ButtonText = "  Books";
            this.BooksButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BooksButton.DisabledColor = System.Drawing.Color.Gray;
            this.BooksButton.Iconcolor = System.Drawing.Color.Transparent;
            this.BooksButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("BooksButton.Iconimage")));
            this.BooksButton.Iconimage_right = null;
            this.BooksButton.Iconimage_right_Selected = null;
            this.BooksButton.Iconimage_Selected = null;
            this.BooksButton.IconMarginLeft = 0;
            this.BooksButton.IconMarginRight = 0;
            this.BooksButton.IconRightVisible = true;
            this.BooksButton.IconRightZoom = 0D;
            this.BooksButton.IconVisible = true;
            this.BooksButton.IconZoom = 90D;
            this.BooksButton.IsTab = false;
            this.BooksButton.Location = new System.Drawing.Point(0, 219);
            this.BooksButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BooksButton.Name = "BooksButton";
            this.BooksButton.Normalcolor = System.Drawing.Color.Transparent;
            this.BooksButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.BooksButton.OnHoverTextColor = System.Drawing.Color.White;
            this.BooksButton.selected = false;
            this.BooksButton.Size = new System.Drawing.Size(200, 65);
            this.BooksButton.TabIndex = 2;
            this.BooksButton.Text = "  Books";
            this.BooksButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BooksButton.Textcolor = System.Drawing.Color.White;
            this.BooksButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BooksButton.Click += new System.EventHandler(this.BooksButton_Click);
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.EnableInsertName);
            this.panel1.Controls.Add(this.InsertImage);
            this.panel1.Controls.Add(this.InsertName);
            this.panel1.Controls.Add(this.UserName);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 154);
            this.panel1.TabIndex = 0;
            // 
            // EnableInsertName
            // 
            this.EnableInsertName.BackColor = System.Drawing.Color.Transparent;
            this.EnableInsertName.Image = global::To_Do_List.Properties.Resources.pencil;
            this.EnableInsertName.ImageActive = global::To_Do_List.Properties.Resources.pencil;
            this.EnableInsertName.Location = new System.Drawing.Point(168, 113);
            this.EnableInsertName.Name = "EnableInsertName";
            this.EnableInsertName.Size = new System.Drawing.Size(30, 30);
            this.EnableInsertName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EnableInsertName.TabIndex = 8;
            this.EnableInsertName.TabStop = false;
            this.EnableInsertName.Zoom = 1;
            this.EnableInsertName.Click += new System.EventHandler(this.EnableInsertName_Click);
            // 
            // InsertImage
            // 
            this.InsertImage.BackColor = System.Drawing.Color.Transparent;
            this.InsertImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.InsertImage.Image = global::To_Do_List.Properties.Resources.ProfileImage0;
            this.InsertImage.ImageActive = ((System.Drawing.Image)(resources.GetObject("InsertImage.ImageActive")));
            this.InsertImage.ImageLocation = "ProfileImage";
            this.InsertImage.Location = new System.Drawing.Point(45, 12);
            this.InsertImage.Name = "InsertImage";
            this.InsertImage.Size = new System.Drawing.Size(100, 100);
            this.InsertImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.InsertImage.TabIndex = 7;
            this.InsertImage.TabStop = false;
            this.InsertImage.Zoom = 1;
            this.InsertImage.Click += new System.EventHandler(this.InsertImage_Click);
            // 
            // InsertName
            // 
            this.InsertName.BackColor = System.Drawing.Color.SteelBlue;
            this.InsertName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InsertName.Enabled = false;
            this.InsertName.Location = new System.Drawing.Point(45, 137);
            this.InsertName.Name = "InsertName";
            this.InsertName.Size = new System.Drawing.Size(100, 13);
            this.InsertName.TabIndex = 7;
            this.InsertName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InsertName.Visible = false;
            this.InsertName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InsertName_KeyDown);
            // 
            // UserName
            // 
            this.UserName.Font = new System.Drawing.Font("Monotype Corsiva", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.ForeColor = System.Drawing.Color.White;
            this.UserName.Location = new System.Drawing.Point(37, 115);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(117, 27);
            this.UserName.TabIndex = 1;
            this.UserName.Text = "User";
            this.UserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 531);
            this.Controls.Add(this.BackPanel);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.learning1);
            this.Controls.Add(this.books1);
            this.Controls.Add(this.targets1);
            this.Controls.Add(this.ideas1);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.done1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List";
            this.Load += new System.EventHandler(this.ToDoList_Load);
            this.LeftPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EnableInsertName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InsertImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel LeftPanel;
        private Bunifu.Framework.UI.BunifuFlatButton LearningButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label UserName;
        private Bunifu.Framework.UI.BunifuFlatButton TargetsButton;
        private Bunifu.Framework.UI.BunifuFlatButton BooksButton;
        private Bunifu.Framework.UI.BunifuFlatButton IdeasButton;
        private Bunifu.Framework.UI.BunifuFlatButton MinimizeButton;
        private Bunifu.Framework.UI.BunifuFlatButton ExitButton;
        private Ideas ideas1;
        private Targets targets1;
        private Books books1;
        private Learning learning1;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuImageButton InsertImage;
        private System.Windows.Forms.TextBox InsertName;
        private Bunifu.Framework.UI.BunifuImageButton EnableInsertName;
        private System.Windows.Forms.Panel BackPanel;
        private Bunifu.Framework.UI.BunifuFlatButton DoneListButton;
        private Done done1;
    }
}

