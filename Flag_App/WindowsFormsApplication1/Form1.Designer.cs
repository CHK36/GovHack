namespace WindowsFormsApplication1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblSubHeader = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelFlagName = new System.Windows.Forms.Label();
            this.lblFlagName = new System.Windows.Forms.Label();
            this.lblCreatorName = new System.Windows.Forms.Label();
            this.screen = new System.Windows.Forms.PictureBox();
            this.pboxup = new System.Windows.Forms.PictureBox();
            this.pboxDown = new System.Windows.Forms.PictureBox();
            this.pboxBig = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblViewStats = new System.Windows.Forms.Label();
            this.pboxCover = new System.Windows.Forms.PictureBox();
            this.lblViewFlags = new System.Windows.Forms.Label();
            this.txtbxStats = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.screen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCover)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(28, 19);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(239, 37);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "NZ Flag Viewer";
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(28, 78);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(355, 214);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = resources.GetString("lblDescription.Text");
            this.lblDescription.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSubHeader
            // 
            this.lblSubHeader.AutoSize = true;
            this.lblSubHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubHeader.ForeColor = System.Drawing.Color.White;
            this.lblSubHeader.Location = new System.Drawing.Point(506, 19);
            this.lblSubHeader.Name = "lblSubHeader";
            this.lblSubHeader.Size = new System.Drawing.Size(277, 37);
            this.lblSubHeader.TabIndex = 2;
            this.lblSubHeader.Text = "View Submissions";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(513, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(818, 598);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // labelFlagName
            // 
            this.labelFlagName.AutoSize = true;
            this.labelFlagName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFlagName.ForeColor = System.Drawing.Color.White;
            this.labelFlagName.Location = new System.Drawing.Point(28, 340);
            this.labelFlagName.Name = "labelFlagName";
            this.labelFlagName.Size = new System.Drawing.Size(250, 37);
            this.labelFlagName.TabIndex = 4;
            this.labelFlagName.Text = "Flag Information";
            // 
            // lblFlagName
            // 
            this.lblFlagName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlagName.ForeColor = System.Drawing.Color.White;
            this.lblFlagName.Location = new System.Drawing.Point(31, 390);
            this.lblFlagName.Name = "lblFlagName";
            this.lblFlagName.Size = new System.Drawing.Size(373, 68);
            this.lblFlagName.TabIndex = 5;
            this.lblFlagName.Text = "Name:";
            // 
            // lblCreatorName
            // 
            this.lblCreatorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatorName.ForeColor = System.Drawing.Color.White;
            this.lblCreatorName.Location = new System.Drawing.Point(31, 458);
            this.lblCreatorName.Name = "lblCreatorName";
            this.lblCreatorName.Size = new System.Drawing.Size(404, 30);
            this.lblCreatorName.TabIndex = 7;
            this.lblCreatorName.Text = "Creator:";
            // 
            // screen
            // 
            this.screen.Location = new System.Drawing.Point(0, 0);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(1600, 850);
            this.screen.TabIndex = 12;
            this.screen.TabStop = false;
            this.screen.Paint += new System.Windows.Forms.PaintEventHandler(this.screen_Paint);
            // 
            // pboxup
            // 
            this.pboxup.ImageLocation = "http://www.clker.com/cliparts/8/7/Y/H/W/e/up-arrow-circle-hi.png";
            this.pboxup.Location = new System.Drawing.Point(429, 78);
            this.pboxup.Name = "pboxup";
            this.pboxup.Size = new System.Drawing.Size(78, 71);
            this.pboxup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxup.TabIndex = 13;
            this.pboxup.TabStop = false;
            this.pboxup.Click += new System.EventHandler(this.pboxup_Click);
            // 
            // pboxDown
            // 
            this.pboxDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pboxDown.BackColor = System.Drawing.Color.Transparent;
            this.pboxDown.Image = ((System.Drawing.Image)(resources.GetObject("pboxDown.Image")));
            this.pboxDown.ImageLocation = "";
            this.pboxDown.Location = new System.Drawing.Point(429, 586);
            this.pboxDown.Name = "pboxDown";
            this.pboxDown.Size = new System.Drawing.Size(78, 71);
            this.pboxDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxDown.TabIndex = 15;
            this.pboxDown.TabStop = false;
            this.pboxDown.Click += new System.EventHandler(this.pboxDown_Click);
            // 
            // pboxBig
            // 
            this.pboxBig.Location = new System.Drawing.Point(13, 60);
            this.pboxBig.Name = "pboxBig";
            this.pboxBig.Size = new System.Drawing.Size(410, 259);
            this.pboxBig.TabIndex = 16;
            this.pboxBig.TabStop = false;
            this.pboxBig.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "All locations",
            "Auckland",
            "Bay of Plenty",
            "Canterbury",
            "Gisborne",
            "Hawkes Bay",
            "Manawatu-Wanganui",
            "Marlborough",
            "Nelson",
            "Northland",
            "Otago",
            "Southland",
            "Taranaki",
            "Waikato",
            "Wellington",
            "West Coast",
            "International"});
            this.comboBox1.Location = new System.Drawing.Point(915, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(416, 45);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblViewStats
            // 
            this.lblViewStats.AutoSize = true;
            this.lblViewStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewStats.ForeColor = System.Drawing.Color.White;
            this.lblViewStats.Location = new System.Drawing.Point(25, 575);
            this.lblViewStats.Name = "lblViewStats";
            this.lblViewStats.Size = new System.Drawing.Size(223, 37);
            this.lblViewStats.TabIndex = 18;
            this.lblViewStats.Text = "View Statistics";
            this.lblViewStats.Click += new System.EventHandler(this.lblViewStats_Click);
            // 
            // pboxCover
            // 
            this.pboxCover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pboxCover.Location = new System.Drawing.Point(513, 78);
            this.pboxCover.Name = "pboxCover";
            this.pboxCover.Size = new System.Drawing.Size(818, 598);
            this.pboxCover.TabIndex = 19;
            this.pboxCover.TabStop = false;
            this.pboxCover.Visible = false;
            // 
            // lblViewFlags
            // 
            this.lblViewFlags.AutoSize = true;
            this.lblViewFlags.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewFlags.ForeColor = System.Drawing.Color.White;
            this.lblViewFlags.Location = new System.Drawing.Point(25, 528);
            this.lblViewFlags.Name = "lblViewFlags";
            this.lblViewFlags.Size = new System.Drawing.Size(174, 37);
            this.lblViewFlags.TabIndex = 20;
            this.lblViewFlags.Text = "View Flags";
            this.lblViewFlags.Click += new System.EventHandler(this.lblViewFlags_Click);
            // 
            // txtbxStats
            // 
            this.txtbxStats.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtbxStats.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbxStats.ForeColor = System.Drawing.Color.White;
            this.txtbxStats.Location = new System.Drawing.Point(513, 78);
            this.txtbxStats.Multiline = true;
            this.txtbxStats.Name = "txtbxStats";
            this.txtbxStats.ReadOnly = true;
            this.txtbxStats.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbxStats.Size = new System.Drawing.Size(776, 565);
            this.txtbxStats.TabIndex = 21;
            this.txtbxStats.Text = "Select a location to view statistics";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1343, 688);
            this.Controls.Add(this.txtbxStats);
            this.Controls.Add(this.lblViewFlags);
            this.Controls.Add(this.pboxCover);
            this.Controls.Add(this.lblViewStats);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pboxBig);
            this.Controls.Add(this.pboxDown);
            this.Controls.Add(this.pboxup);
            this.Controls.Add(this.lblCreatorName);
            this.Controls.Add(this.lblFlagName);
            this.Controls.Add(this.labelFlagName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSubHeader);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.screen);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "NZ Flag Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.screen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblSubHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelFlagName;
        private System.Windows.Forms.Label lblFlagName;
        private System.Windows.Forms.Label lblCreatorName;
        private System.Windows.Forms.PictureBox screen;
        private System.Windows.Forms.PictureBox pboxup;
        private System.Windows.Forms.PictureBox pboxDown;
        private System.Windows.Forms.PictureBox pboxBig;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblViewStats;
        private System.Windows.Forms.PictureBox pboxCover;
        private System.Windows.Forms.Label lblViewFlags;
        private System.Windows.Forms.TextBox txtbxStats;
    }
}

