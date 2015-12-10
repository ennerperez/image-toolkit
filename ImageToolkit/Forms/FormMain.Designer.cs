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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonFromB64 = new System.Windows.Forms.Button();
            this.trackBarCompressRatio = new System.Windows.Forms.TrackBar();
            this.labelCompressRatioPercent = new System.Windows.Forms.Label();
            this.buttonToB64 = new System.Windows.Forms.Button();
            this.openFileDialogImage = new System.Windows.Forms.OpenFileDialog();
            this.buttonClear = new System.Windows.Forms.Button();
            this.toolTipMain = new System.Windows.Forms.ToolTip(this.components);
            this.buttonSaveAs = new System.Windows.Forms.Button();
            this.buttonCrop = new System.Windows.Forms.Button();
            this.labelCompress = new System.Windows.Forms.Label();
            this.saveFileDialogImage = new System.Windows.Forms.SaveFileDialog();
            this.buttonRestore = new System.Windows.Forms.Button();
            this.contextMenuStripImage = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bufferedPanelPreview = new System.Windows.Forms.BufferedPanel();
            this.labelDragDropPreview = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCompressRatio)).BeginInit();
            this.contextMenuStripImage.SuspendLayout();
            this.bufferedPanelPreview.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAbout
            // 
            this.buttonAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonAbout.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.buttonAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbout.Image = ((System.Drawing.Image)(resources.GetObject("buttonAbout.Image")));
            this.buttonAbout.Location = new System.Drawing.Point(427, 373);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(25, 25);
            this.buttonAbout.TabIndex = 8;
            this.toolTipMain.SetToolTip(this.buttonAbout, "About");
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonOpen.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.buttonOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpen.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpen.Image")));
            this.buttonOpen.Location = new System.Drawing.Point(427, 12);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(25, 25);
            this.buttonOpen.TabIndex = 1;
            this.toolTipMain.SetToolTip(this.buttonOpen, "Open");
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonFromB64
            // 
            this.buttonFromB64.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFromB64.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonFromB64.Enabled = false;
            this.buttonFromB64.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.buttonFromB64.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFromB64.Image = ((System.Drawing.Image)(resources.GetObject("buttonFromB64.Image")));
            this.buttonFromB64.Location = new System.Drawing.Point(427, 136);
            this.buttonFromB64.Name = "buttonFromB64";
            this.buttonFromB64.Size = new System.Drawing.Size(25, 25);
            this.buttonFromB64.TabIndex = 3;
            this.toolTipMain.SetToolTip(this.buttonFromB64, "Conver from B64");
            this.buttonFromB64.UseVisualStyleBackColor = true;
            this.buttonFromB64.Click += new System.EventHandler(this.buttonFromB64_Click);
            // 
            // trackBarCompressRatio
            // 
            this.trackBarCompressRatio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarCompressRatio.AutoSize = false;
            this.trackBarCompressRatio.Enabled = false;
            this.trackBarCompressRatio.Location = new System.Drawing.Point(116, 408);
            this.trackBarCompressRatio.Maximum = 100;
            this.trackBarCompressRatio.Name = "trackBarCompressRatio";
            this.trackBarCompressRatio.Size = new System.Drawing.Size(295, 21);
            this.trackBarCompressRatio.TabIndex = 6;
            this.trackBarCompressRatio.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarCompressRatio.Scroll += new System.EventHandler(this.trackBarCompressRatio_Scroll);
            // 
            // labelCompressRatioPercent
            // 
            this.labelCompressRatioPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCompressRatioPercent.Location = new System.Drawing.Point(412, 408);
            this.labelCompressRatioPercent.Name = "labelCompressRatioPercent";
            this.labelCompressRatioPercent.Size = new System.Drawing.Size(40, 17);
            this.labelCompressRatioPercent.TabIndex = 7;
            this.labelCompressRatioPercent.Text = "0%";
            this.labelCompressRatioPercent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonToB64
            // 
            this.buttonToB64.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonToB64.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonToB64.Enabled = false;
            this.buttonToB64.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.buttonToB64.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonToB64.Image = ((System.Drawing.Image)(resources.GetObject("buttonToB64.Image")));
            this.buttonToB64.Location = new System.Drawing.Point(427, 167);
            this.buttonToB64.Name = "buttonToB64";
            this.buttonToB64.Size = new System.Drawing.Size(25, 25);
            this.buttonToB64.TabIndex = 2;
            this.toolTipMain.SetToolTip(this.buttonToB64, "Conver to B64");
            this.buttonToB64.UseVisualStyleBackColor = true;
            this.buttonToB64.Click += new System.EventHandler(this.buttonToB64_Click);
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
            this.buttonClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonClear.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Image = ((System.Drawing.Image)(resources.GetObject("buttonClear.Image")));
            this.buttonClear.Location = new System.Drawing.Point(427, 43);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(25, 25);
            this.buttonClear.TabIndex = 4;
            this.toolTipMain.SetToolTip(this.buttonClear, "Clear");
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSaveAs
            // 
            this.buttonSaveAs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveAs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonSaveAs.Enabled = false;
            this.buttonSaveAs.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.buttonSaveAs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveAs.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveAs.Image")));
            this.buttonSaveAs.Location = new System.Drawing.Point(427, 198);
            this.buttonSaveAs.Name = "buttonSaveAs";
            this.buttonSaveAs.Size = new System.Drawing.Size(25, 25);
            this.buttonSaveAs.TabIndex = 1;
            this.toolTipMain.SetToolTip(this.buttonSaveAs, "Save");
            this.buttonSaveAs.UseVisualStyleBackColor = true;
            this.buttonSaveAs.Click += new System.EventHandler(this.buttonSaveAs_Click);
            // 
            // buttonCrop
            // 
            this.buttonCrop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonCrop.Enabled = false;
            this.buttonCrop.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.buttonCrop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCrop.Image = ((System.Drawing.Image)(resources.GetObject("buttonCrop.Image")));
            this.buttonCrop.Location = new System.Drawing.Point(427, 74);
            this.buttonCrop.Name = "buttonCrop";
            this.buttonCrop.Size = new System.Drawing.Size(25, 25);
            this.buttonCrop.TabIndex = 4;
            this.toolTipMain.SetToolTip(this.buttonCrop, "Crop");
            this.buttonCrop.UseVisualStyleBackColor = true;
            this.buttonCrop.Click += new System.EventHandler(this.buttonCrop_Click);
            // 
            // labelCompress
            // 
            this.labelCompress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCompress.AutoSize = true;
            this.labelCompress.Location = new System.Drawing.Point(12, 408);
            this.labelCompress.Name = "labelCompress";
            this.labelCompress.Size = new System.Drawing.Size(98, 17);
            this.labelCompress.TabIndex = 5;
            this.labelCompress.Text = "Compress ratio";
            // 
            // saveFileDialogImage
            // 
            this.saveFileDialogImage.DefaultExt = "jpg";
            this.saveFileDialogImage.Filter = "Image files (*{0}) | *{1} ";
            this.saveFileDialogImage.Tag = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif;" +
    " *.png |Text files (*.txt, *.bin, *.b64) | *.txt; *.bin; *.b64";
            this.saveFileDialogImage.Title = "Save...";
            this.saveFileDialogImage.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialogImage_FileOk);
            // 
            // buttonRestore
            // 
            this.buttonRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRestore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonRestore.Enabled = false;
            this.buttonRestore.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.buttonRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRestore.Image = ((System.Drawing.Image)(resources.GetObject("buttonRestore.Image")));
            this.buttonRestore.Location = new System.Drawing.Point(427, 105);
            this.buttonRestore.Name = "buttonRestore";
            this.buttonRestore.Size = new System.Drawing.Size(25, 25);
            this.buttonRestore.TabIndex = 4;
            this.buttonRestore.UseVisualStyleBackColor = true;
            this.buttonRestore.Click += new System.EventHandler(this.buttonRestore_Click);
            // 
            // contextMenuStripImage
            // 
            this.contextMenuStripImage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.contextMenuStripImage.Name = "contextMenuStripImage";
            this.contextMenuStripImage.Size = new System.Drawing.Size(103, 48);
            this.contextMenuStripImage.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripImage_Opening);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // bufferedPanelPreview
            // 
            this.bufferedPanelPreview.AllowDrop = true;
            this.bufferedPanelPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bufferedPanelPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bufferedPanelPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bufferedPanelPreview.ContextMenuStrip = this.contextMenuStripImage;
            this.bufferedPanelPreview.Controls.Add(this.labelDragDropPreview);
            this.bufferedPanelPreview.Location = new System.Drawing.Point(12, 12);
            this.bufferedPanelPreview.Name = "bufferedPanelPreview";
            this.bufferedPanelPreview.Padding = new System.Windows.Forms.Padding(9);
            this.bufferedPanelPreview.Size = new System.Drawing.Size(409, 386);
            this.bufferedPanelPreview.TabIndex = 0;
            this.bufferedPanelPreview.DragDrop += new System.Windows.Forms.DragEventHandler(this.bufferedPanelPreview_DragDrop);
            this.bufferedPanelPreview.DragEnter += new System.Windows.Forms.DragEventHandler(this.bufferedPanelPreview_DragEnter);
            //this.bufferedPanelPreview.Paint += new System.Windows.Forms.PaintEventHandler(this.bufferedPanelPreview_Paint);
            //this.bufferedPanelPreview.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bufferedPanelPreview_MouseDown);
            //this.bufferedPanelPreview.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bufferedPanelPreview_MouseMove);
            //this.bufferedPanelPreview.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bufferedPanelPreview_MouseUp);
            // 
            // labelDragDropPreview
            // 
            this.labelDragDropPreview.AllowDrop = true;
            this.labelDragDropPreview.BackColor = System.Drawing.Color.Transparent;
            this.labelDragDropPreview.ContextMenuStrip = this.contextMenuStripImage;
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
            this.Controls.Add(this.labelCompress);
            this.Controls.Add(this.labelCompressRatioPercent);
            this.Controls.Add(this.buttonRestore);
            this.Controls.Add(this.buttonCrop);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonFromB64);
            this.Controls.Add(this.buttonToB64);
            this.Controls.Add(this.buttonSaveAs);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.trackBarCompressRatio);
            this.Controls.Add(this.bufferedPanelPreview);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(480, 480);
            this.Name = "FormMain";
            this.Text = "Image Toolkit";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCompressRatio)).EndInit();
            this.contextMenuStripImage.ResumeLayout(false);
            this.bufferedPanelPreview.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Label labelDragDropPreview;
        private System.Windows.Forms.Button buttonFromB64;
        private System.Windows.Forms.TrackBar trackBarCompressRatio;
        private System.Windows.Forms.Label labelCompressRatioPercent;
        private System.Windows.Forms.Button buttonToB64;
        private System.Windows.Forms.BufferedPanel bufferedPanelPreview;
        private System.Windows.Forms.OpenFileDialog openFileDialogImage;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.ToolTip toolTipMain;
        private System.Windows.Forms.Label labelCompress;
        private System.Windows.Forms.Button buttonSaveAs;
        private System.Windows.Forms.SaveFileDialog saveFileDialogImage;
        private System.Windows.Forms.Button buttonCrop;
        private System.Windows.Forms.Button buttonRestore;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripImage;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
    }
}

