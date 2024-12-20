namespace RestaurantManagementSystem
{
    partial class sampleView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sampleView));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.viewLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.searchbox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.addBtn = new Bunifu.UI.WinForms.BunifuImageButton();
            this.SuspendLayout();
            // 
            // viewLabel
            // 
            this.viewLabel.AllowParentOverrides = false;
            this.viewLabel.AutoEllipsis = false;
            this.viewLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.viewLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.viewLabel.Font = new System.Drawing.Font("Poppins", 12F);
            this.viewLabel.Location = new System.Drawing.Point(54, 25);
            this.viewLabel.Name = "viewLabel";
            this.viewLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.viewLabel.Size = new System.Drawing.Size(43, 28);
            this.viewLabel.TabIndex = 8;
            this.viewLabel.Text = "Label";
            this.viewLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.viewLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.viewLabel.Click += new System.EventHandler(this.viewLabel_Click);
            // 
            // searchbox
            // 
            this.searchbox.AcceptsReturn = false;
            this.searchbox.AcceptsTab = false;
            this.searchbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchbox.AnimationSpeed = 200;
            this.searchbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.searchbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.searchbox.AutoSizeHeight = true;
            this.searchbox.BackColor = System.Drawing.Color.Transparent;
            this.searchbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchbox.BackgroundImage")));
            this.searchbox.BorderColorActive = System.Drawing.Color.Black;
            this.searchbox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.searchbox.BorderColorHover = System.Drawing.Color.Black;
            this.searchbox.BorderColorIdle = System.Drawing.Color.Black;
            this.searchbox.BorderRadius = 1;
            this.searchbox.BorderThickness = 1;
            this.searchbox.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.searchbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.searchbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchbox.DefaultFont = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbox.DefaultText = "";
            this.searchbox.FillColor = System.Drawing.Color.WhiteSmoke;
            this.searchbox.HideSelection = true;
            this.searchbox.IconLeft = null;
            this.searchbox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.searchbox.IconPadding = 10;
            this.searchbox.IconRight = null;
            this.searchbox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.searchbox.Lines = new string[0];
            this.searchbox.Location = new System.Drawing.Point(815, 78);
            this.searchbox.MaxLength = 32767;
            this.searchbox.MinimumSize = new System.Drawing.Size(1, 1);
            this.searchbox.Modified = false;
            this.searchbox.Multiline = false;
            this.searchbox.Name = "searchbox";
            stateProperties5.BorderColor = System.Drawing.Color.Black;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchbox.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.searchbox.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.Black;
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchbox.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Black;
            stateProperties8.FillColor = System.Drawing.Color.WhiteSmoke;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchbox.OnIdleState = stateProperties8;
            this.searchbox.Padding = new System.Windows.Forms.Padding(3);
            this.searchbox.PasswordChar = '\0';
            this.searchbox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchbox.PlaceholderText = "Search";
            this.searchbox.ReadOnly = false;
            this.searchbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchbox.SelectedText = "";
            this.searchbox.SelectionLength = 0;
            this.searchbox.SelectionStart = 0;
            this.searchbox.ShortcutsEnabled = true;
            this.searchbox.Size = new System.Drawing.Size(247, 38);
            this.searchbox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.searchbox.TabIndex = 7;
            this.searchbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchbox.TextMarginBottom = 0;
            this.searchbox.TextMarginLeft = 3;
            this.searchbox.TextMarginTop = 1;
            this.searchbox.TextPlaceholder = "Search";
            this.searchbox.UseSystemPasswordChar = false;
            this.searchbox.WordWrap = true;
            this.searchbox.TextChanged += new System.EventHandler(this.searchbox_TextChanged);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.ForeColor = System.Drawing.Color.Black;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.Silver;
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(54, 123);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(1008, 10);
            this.bunifuSeparator1.TabIndex = 6;
            // 
            // addBtn
            // 
            this.addBtn.ActiveImage = null;
            this.addBtn.AllowAnimations = true;
            this.addBtn.AllowBuffering = false;
            this.addBtn.AllowToggling = false;
            this.addBtn.AllowZooming = true;
            this.addBtn.AllowZoomingOnFocus = false;
            this.addBtn.BackColor = System.Drawing.Color.Transparent;
            this.addBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.addBtn.ErrorImage = ((System.Drawing.Image)(resources.GetObject("addBtn.ErrorImage")));
            this.addBtn.FadeWhenInactive = false;
            this.addBtn.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.addBtn.Image = global::RestaurantManagementSystem.Properties.Resources.icons8_add_new_50;
            this.addBtn.ImageActive = null;
            this.addBtn.ImageLocation = null;
            this.addBtn.ImageMargin = 10;
            this.addBtn.ImageSize = new System.Drawing.Size(55, 55);
            this.addBtn.ImageZoomSize = new System.Drawing.Size(65, 65);
            this.addBtn.InitialImage = ((System.Drawing.Image)(resources.GetObject("addBtn.InitialImage")));
            this.addBtn.Location = new System.Drawing.Point(46, 55);
            this.addBtn.Name = "addBtn";
            this.addBtn.Rotation = 0;
            this.addBtn.ShowActiveImage = true;
            this.addBtn.ShowCursorChanges = true;
            this.addBtn.ShowImageBorders = true;
            this.addBtn.ShowSizeMarkers = false;
            this.addBtn.Size = new System.Drawing.Size(65, 65);
            this.addBtn.TabIndex = 5;
            this.addBtn.ToolTipText = "";
            this.addBtn.WaitOnLoad = false;
            this.addBtn.Zoom = 10;
            this.addBtn.ZoomSpeed = 10;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click_1);
            // 
            // sampleView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.viewLabel);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.addBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "sampleView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Bunifu.UI.WinForms.BunifuLabel viewLabel;
        public Bunifu.UI.WinForms.BunifuTextBox searchbox;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        public Bunifu.UI.WinForms.BunifuImageButton addBtn;
    }
}