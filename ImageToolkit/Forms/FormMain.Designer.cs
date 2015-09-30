namespace Toolkit.Forms
{
    partial class FormMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonToB64 = new System.Windows.Forms.Button();
            this.trackBarCompressRatio = new System.Windows.Forms.TrackBar();
            this.labelCompressRatioPercent = new System.Windows.Forms.Label();
            this.buttonFromB64 = new System.Windows.Forms.Button();
            this.openFileDialogImage = new System.Windows.Forms.OpenFileDialog();
            this.buttonClear = new System.Windows.Forms.Button();
            this.bufferedPanelPreview = new System.Windows.Forms.BufferedPanel();
            this.labelDragDropPreview = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCompressRatio)).BeginInit();
            this.bufferedPanelPreview.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAbout
            // 
            this.buttonAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAbout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAbout.BackgroundImage")));
            this.buttonAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonAbout.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.buttonAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbout.Location = new System.Drawing.Point(427, 373);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(25, 25);
            this.buttonAbout.TabIndex = 7;
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonOpen.BackgroundImage")));
            this.buttonOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonOpen.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.buttonOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpen.Location = new System.Drawing.Point(427, 12);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(25, 25);
            this.buttonOpen.TabIndex = 1;
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonToB64
            // 
            this.buttonToB64.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonToB64.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonToB64.BackgroundImage")));
            this.buttonToB64.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonToB64.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.buttonToB64.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonToB64.Location = new System.Drawing.Point(427, 74);
            this.buttonToB64.Name = "buttonToB64";
            this.buttonToB64.Size = new System.Drawing.Size(25, 25);
            this.buttonToB64.TabIndex = 3;
            this.buttonToB64.UseVisualStyleBackColor = true;
            this.buttonToB64.Click += new System.EventHandler(this.buttonToB64_Click);
            // 
            // trackBarCompressRatio
            // 
            this.trackBarCompressRatio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarCompressRatio.Enabled = false;
            this.trackBarCompressRatio.Location = new System.Drawing.Point(12, 408);
            this.trackBarCompressRatio.Maximum = 100;
            this.trackBarCompressRatio.Name = "trackBarCompressRatio";
            this.trackBarCompressRatio.Size = new System.Drawing.Size(399, 45);
            this.trackBarCompressRatio.TabIndex = 5;
            this.trackBarCompressRatio.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarCompressRatio.Scroll += new System.EventHandler(this.trackBarCompressRatio_Scroll);
            // 
            // labelCompressRatioPercent
            // 
            this.labelCompressRatioPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCompressRatioPercent.Location = new System.Drawing.Point(412, 408);
            this.labelCompressRatioPercent.Name = "labelCompressRatioPercent";
            this.labelCompressRatioPercent.Size = new System.Drawing.Size(40, 17);
            this.labelCompressRatioPercent.TabIndex = 6;
            this.labelCompressRatioPercent.Text = "0%";
            this.labelCompressRatioPercent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonFromB64
            // 
            this.buttonFromB64.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFromB64.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonFromB64.BackgroundImage")));
            this.buttonFromB64.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonFromB64.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.buttonFromB64.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFromB64.Location = new System.Drawing.Point(427, 43);
            this.buttonFromB64.Name = "buttonFromB64";
            this.buttonFromB64.Size = new System.Drawing.Size(25, 25);
            this.buttonFromB64.TabIndex = 2;
            this.buttonFromB64.UseVisualStyleBackColor = true;
            this.buttonFromB64.Click += new System.EventHandler(this.buttonFromB64_Click);
            // 
            // openFileDialogImage
            // 
            this.openFileDialogImage.DefaultExt = "jpg";
            this.openFileDialogImage.Filter = "Image files (*{0}) | *{1} |Text files (*{2}) | *{3}";
            this.openFileDialogImage.Tag = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif;" +
    " *.png |Text files (*.txt, *.bin, *.b64) | *.txt; *.bin; *.b64";
            this.openFileDialogImage.Title = "Open...";
            this.openFileDialogImage.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogImage_FileOk);
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonClear.BackgroundImage")));
            this.buttonClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonClear.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Location = new System.Drawing.Point(427, 105);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(25, 25);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // bufferedPanelPreview
            // 
            this.bufferedPanelPreview.AllowDrop = true;
            this.bufferedPanelPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bufferedPanelPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bufferedPanelPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bufferedPanelPreview.Controls.Add(this.labelDragDropPreview);
            this.bufferedPanelPreview.Location = new System.Drawing.Point(12, 12);
            this.bufferedPanelPreview.Name = "bufferedPanelPreview";
            this.bufferedPanelPreview.Padding = new System.Windows.Forms.Padding(9);
            this.bufferedPanelPreview.Size = new System.Drawing.Size(409, 386);
            this.bufferedPanelPreview.TabIndex = 0;
            this.bufferedPanelPreview.BackgroundImageChanged += new System.EventHandler(this.bufferedPanelPreview_BackgroundImageChanged);
            this.bufferedPanelPreview.DragDrop += new System.Windows.Forms.DragEventHandler(this.bufferedPanelPreview_DragDrop);
            this.bufferedPanelPreview.DragEnter += new System.Windows.Forms.DragEventHandler(this.bufferedPanelPreview_DragEnter);
            // 
            // labelDragDropPreview
            // 
            this.labelDragDropPreview.AllowDrop = true;
            this.labelDragDropPreview.BackColor = System.Drawing.Color.Transparent;
            this.labelDragDropPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDragDropPreview.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelDragDropPreview.Location = new System.Drawing.Point(9, 9);
            this.labelDragDropPreview.Name = "labelDragDropPreview";
            this.labelDragDropPreview.Size = new System.Drawing.Size(389, 366);
            this.labelDragDropPreview.TabIndex = 0;
            this.labelDragDropPreview.Text = "Drag && Drop\r\nAny image or text based here";
            this.labelDragDropPreview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDragDropPreview.DragDrop += new System.Windows.Forms.DragEventHandler(this.bufferedPanelPreview_DragDrop);
            this.labelDragDropPreview.DragEnter += new System.Windows.Forms.DragEventHandler(this.bufferedPanelPreview_DragEnter);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(464, 441);
            this.Controls.Add(this.labelCompressRatioPercent);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonToB64);
            this.Controls.Add(this.buttonFromB64);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.trackBarCompressRatio);
            this.Controls.Add(this.bufferedPanelPreview);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(480, 480);
            this.Name = "FormMain";
            this.Text = "Image Toolkit";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCompressRatio)).EndInit();
            this.bufferedPanelPreview.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Label labelDragDropPreview;
        private System.Windows.Forms.Button buttonToB64;
        private System.Windows.Forms.TrackBar trackBarCompressRatio;
        private System.Windows.Forms.Label labelCompressRatioPercent;
        private System.Windows.Forms.Button buttonFromB64;
        private System.Windows.Forms.BufferedPanel bufferedPanelPreview;
        private System.Windows.Forms.OpenFileDialog openFileDialogImage;
        private System.Windows.Forms.Button buttonClear;
    }
}

