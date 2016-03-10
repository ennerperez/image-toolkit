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
            this.openFileDialogImage = new System.Windows.Forms.OpenFileDialog();
            this.toolTipMain = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialogImage = new System.Windows.Forms.SaveFileDialog();
            this.contextMenuStripImage = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAbout = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClear = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonCrop = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRestore = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonToB64 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFromB64 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.bufferedPanelPreview = new System.Windows.Forms.BufferedPanel();
            this.labelDragDropPreview = new System.Windows.Forms.Label();
            this.contextMenuStripImage.SuspendLayout();
            this.toolStripMenu.SuspendLayout();
            this.bufferedPanelPreview.SuspendLayout();
            this.SuspendLayout();
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
            // saveFileDialogImage
            // 
            this.saveFileDialogImage.DefaultExt = "jpg";
            this.saveFileDialogImage.Filter = "Image files (*{0}) | *{1} ";
            this.saveFileDialogImage.Tag = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif;" +
    " *.png |Text files (*.txt, *.bin, *.b64) | *.txt; *.bin; *.b64";
            this.saveFileDialogImage.Title = "Save...";
            this.saveFileDialogImage.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialogImage_FileOk);
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
            // toolStripMenu
            // 
            this.toolStripMenu.AutoSize = false;
            this.toolStripMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.toolStripMenu.CanOverflow = false;
            this.toolStripMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStripMenu.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStripMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonOpen,
            this.toolStripButtonClose,
            this.toolStripButtonAbout,
            this.toolStripButtonClear,
            this.toolStripSeparator1,
            this.toolStripButtonCrop,
            this.toolStripButtonRestore,
            this.toolStripSeparator2,
            this.toolStripButtonToB64,
            this.toolStripButtonFromB64,
            this.toolStripSeparator4,
            this.toolStripButtonSave});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Padding = new System.Windows.Forms.Padding(0);
            this.toolStripMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripMenu.Size = new System.Drawing.Size(48, 561);
            this.toolStripMenu.TabIndex = 9;
            // 
            // toolStripButtonOpen
            // 
            this.toolStripButtonOpen.AutoSize = false;
            this.toolStripButtonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOpen.Image")));
            this.toolStripButtonOpen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpen.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonOpen.Name = "toolStripButtonOpen";
            this.toolStripButtonOpen.Size = new System.Drawing.Size(48, 48);
            this.toolStripButtonOpen.Text = "&Open...";
            this.toolStripButtonOpen.Click += new System.EventHandler(this.toolStripButtonOpen_Click);
            // 
            // toolStripButtonClose
            // 
            this.toolStripButtonClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonClose.AutoSize = false;
            this.toolStripButtonClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonClose.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonClose.Image")));
            this.toolStripButtonClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonClose.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonClose.Name = "toolStripButtonClose";
            this.toolStripButtonClose.Size = new System.Drawing.Size(48, 48);
            this.toolStripButtonClose.Text = "&Close";
            this.toolStripButtonClose.Click += new System.EventHandler(this.toolStripButtonClose_Click);
            // 
            // toolStripButtonAbout
            // 
            this.toolStripButtonAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonAbout.AutoSize = false;
            this.toolStripButtonAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAbout.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAbout.Image")));
            this.toolStripButtonAbout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAbout.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonAbout.Name = "toolStripButtonAbout";
            this.toolStripButtonAbout.Size = new System.Drawing.Size(48, 48);
            this.toolStripButtonAbout.Text = "&About...";
            this.toolStripButtonAbout.Click += new System.EventHandler(this.toolStripButtonAbout_Click);
            // 
            // toolStripButtonClear
            // 
            this.toolStripButtonClear.AutoSize = false;
            this.toolStripButtonClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonClear.Enabled = false;
            this.toolStripButtonClear.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonClear.Image")));
            this.toolStripButtonClear.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonClear.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonClear.Name = "toolStripButtonClear";
            this.toolStripButtonClear.Size = new System.Drawing.Size(48, 48);
            this.toolStripButtonClear.Text = "&Clear";
            this.toolStripButtonClear.Click += new System.EventHandler(this.toolStripButtonClear_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(47, 6);
            // 
            // toolStripButtonCrop
            // 
            this.toolStripButtonCrop.AutoSize = false;
            this.toolStripButtonCrop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCrop.Enabled = false;
            this.toolStripButtonCrop.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCrop.Image")));
            this.toolStripButtonCrop.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonCrop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCrop.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonCrop.Name = "toolStripButtonCrop";
            this.toolStripButtonCrop.Size = new System.Drawing.Size(48, 48);
            this.toolStripButtonCrop.Text = "C&rop";
            this.toolStripButtonCrop.Click += new System.EventHandler(this.toolStripButtonCrop_Click);
            // 
            // toolStripButtonRestore
            // 
            this.toolStripButtonRestore.AutoSize = false;
            this.toolStripButtonRestore.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRestore.Enabled = false;
            this.toolStripButtonRestore.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRestore.Image")));
            this.toolStripButtonRestore.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonRestore.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRestore.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonRestore.Name = "toolStripButtonRestore";
            this.toolStripButtonRestore.Size = new System.Drawing.Size(48, 48);
            this.toolStripButtonRestore.Text = "C&rop";
            this.toolStripButtonRestore.Click += new System.EventHandler(this.toolStripButtonRestore_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(47, 6);
            // 
            // toolStripButtonToB64
            // 
            this.toolStripButtonToB64.AutoSize = false;
            this.toolStripButtonToB64.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonToB64.Enabled = false;
            this.toolStripButtonToB64.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonToB64.Image")));
            this.toolStripButtonToB64.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonToB64.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonToB64.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonToB64.Name = "toolStripButtonToB64";
            this.toolStripButtonToB64.Size = new System.Drawing.Size(48, 48);
            this.toolStripButtonToB64.Text = "Convert &to B64";
            this.toolStripButtonToB64.Click += new System.EventHandler(this.toolStripButtonToB64_Click);
            // 
            // toolStripButtonFromB64
            // 
            this.toolStripButtonFromB64.AutoSize = false;
            this.toolStripButtonFromB64.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFromB64.Enabled = false;
            this.toolStripButtonFromB64.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFromB64.Image")));
            this.toolStripButtonFromB64.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonFromB64.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFromB64.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonFromB64.Name = "toolStripButtonFromB64";
            this.toolStripButtonFromB64.Size = new System.Drawing.Size(48, 48);
            this.toolStripButtonFromB64.Text = "Convert &from B64";
            this.toolStripButtonFromB64.Click += new System.EventHandler(this.toolStripButtonFromB64_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(47, 6);
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.AutoSize = false;
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSave.Enabled = false;
            this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
            this.toolStripButtonSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(48, 48);
            this.toolStripButtonSave.Text = "&Save...";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // bufferedPanelPreview
            // 
            this.bufferedPanelPreview.AllowDrop = true;
            this.bufferedPanelPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bufferedPanelPreview.ContextMenuStrip = this.contextMenuStripImage;
            this.bufferedPanelPreview.Controls.Add(this.labelDragDropPreview);
            this.bufferedPanelPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bufferedPanelPreview.Location = new System.Drawing.Point(48, 0);
            this.bufferedPanelPreview.Name = "bufferedPanelPreview";
            this.bufferedPanelPreview.Padding = new System.Windows.Forms.Padding(9);
            this.bufferedPanelPreview.Size = new System.Drawing.Size(584, 561);
            this.bufferedPanelPreview.TabIndex = 0;
            this.bufferedPanelPreview.DragDrop += new System.Windows.Forms.DragEventHandler(this.bufferedPanelPreview_DragDrop);
            this.bufferedPanelPreview.DragEnter += new System.Windows.Forms.DragEventHandler(this.bufferedPanelPreview_DragEnter);
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
            this.labelDragDropPreview.Size = new System.Drawing.Size(566, 543);
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
            this.ClientSize = new System.Drawing.Size(632, 561);
            this.Controls.Add(this.bufferedPanelPreview);
            this.Controls.Add(this.toolStripMenu);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(528, 480);
            this.Name = "FormMain";
            this.Text = "Image Toolkit";
            this.contextMenuStripImage.ResumeLayout(false);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.bufferedPanelPreview.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelDragDropPreview;
        private System.Windows.Forms.BufferedPanel bufferedPanelPreview;
        private System.Windows.Forms.OpenFileDialog openFileDialogImage;
        private System.Windows.Forms.ToolTip toolTipMain;
        private System.Windows.Forms.SaveFileDialog saveFileDialogImage;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripImage;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpen;
        private System.Windows.Forms.ToolStripButton toolStripButtonClose;
        private System.Windows.Forms.ToolStripButton toolStripButtonAbout;
        private System.Windows.Forms.ToolStripButton toolStripButtonClear;
        private System.Windows.Forms.ToolStripButton toolStripButtonCrop;
        private System.Windows.Forms.ToolStripButton toolStripButtonRestore;
        private System.Windows.Forms.ToolStripButton toolStripButtonFromB64;
        private System.Windows.Forms.ToolStripButton toolStripButtonToB64;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}

