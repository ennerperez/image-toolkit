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
            resources.ApplyResources(this.openFileDialogImage, "openFileDialogImage");
            this.openFileDialogImage.Tag = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif;" +
    " *.png |Text files (*.txt, *.bin, *.b64) | *.txt; *.bin; *.b64";
            this.openFileDialogImage.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogImage_FileOk);
            // 
            // saveFileDialogImage
            // 
            this.saveFileDialogImage.DefaultExt = "jpg";
            resources.ApplyResources(this.saveFileDialogImage, "saveFileDialogImage");
            this.saveFileDialogImage.Tag = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif;" +
    " *.png |Text files (*.txt, *.bin, *.b64) | *.txt; *.bin; *.b64";
            this.saveFileDialogImage.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialogImage_FileOk);
            // 
            // contextMenuStripImage
            // 
            this.contextMenuStripImage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.contextMenuStripImage.Name = "contextMenuStripImage";
            resources.ApplyResources(this.contextMenuStripImage, "contextMenuStripImage");
            this.contextMenuStripImage.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripImage_Opening);
            // 
            // copyToolStripMenuItem
            // 
            resources.ApplyResources(this.copyToolStripMenuItem, "copyToolStripMenuItem");
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            resources.ApplyResources(this.pasteToolStripMenuItem, "pasteToolStripMenuItem");
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // toolStripMenu
            // 
            resources.ApplyResources(this.toolStripMenu, "toolStripMenu");
            this.toolStripMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.toolStripMenu.CanOverflow = false;
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
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            // 
            // toolStripButtonOpen
            // 
            resources.ApplyResources(this.toolStripButtonOpen, "toolStripButtonOpen");
            this.toolStripButtonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonOpen.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonOpen.Name = "toolStripButtonOpen";
            this.toolStripButtonOpen.Click += new System.EventHandler(this.toolStripButtonOpen_Click);
            // 
            // toolStripButtonClose
            // 
            this.toolStripButtonClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.toolStripButtonClose, "toolStripButtonClose");
            this.toolStripButtonClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonClose.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonClose.Name = "toolStripButtonClose";
            this.toolStripButtonClose.Click += new System.EventHandler(this.toolStripButtonClose_Click);
            // 
            // toolStripButtonAbout
            // 
            this.toolStripButtonAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.toolStripButtonAbout, "toolStripButtonAbout");
            this.toolStripButtonAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAbout.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonAbout.Name = "toolStripButtonAbout";
            this.toolStripButtonAbout.Click += new System.EventHandler(this.toolStripButtonAbout_Click);
            // 
            // toolStripButtonClear
            // 
            resources.ApplyResources(this.toolStripButtonClear, "toolStripButtonClear");
            this.toolStripButtonClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonClear.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonClear.Name = "toolStripButtonClear";
            this.toolStripButtonClear.Click += new System.EventHandler(this.toolStripButtonClear_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // toolStripButtonCrop
            // 
            resources.ApplyResources(this.toolStripButtonCrop, "toolStripButtonCrop");
            this.toolStripButtonCrop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCrop.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonCrop.Name = "toolStripButtonCrop";
            this.toolStripButtonCrop.Click += new System.EventHandler(this.toolStripButtonCrop_Click);
            // 
            // toolStripButtonRestore
            // 
            resources.ApplyResources(this.toolStripButtonRestore, "toolStripButtonRestore");
            this.toolStripButtonRestore.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRestore.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonRestore.Name = "toolStripButtonRestore";
            this.toolStripButtonRestore.Click += new System.EventHandler(this.toolStripButtonRestore_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // toolStripButtonToB64
            // 
            resources.ApplyResources(this.toolStripButtonToB64, "toolStripButtonToB64");
            this.toolStripButtonToB64.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonToB64.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonToB64.Name = "toolStripButtonToB64";
            this.toolStripButtonToB64.Click += new System.EventHandler(this.toolStripButtonToB64_Click);
            // 
            // toolStripButtonFromB64
            // 
            resources.ApplyResources(this.toolStripButtonFromB64, "toolStripButtonFromB64");
            this.toolStripButtonFromB64.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFromB64.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonFromB64.Name = "toolStripButtonFromB64";
            this.toolStripButtonFromB64.Click += new System.EventHandler(this.toolStripButtonFromB64_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // toolStripButtonSave
            // 
            resources.ApplyResources(this.toolStripButtonSave, "toolStripButtonSave");
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSave.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // bufferedPanelPreview
            // 
            this.bufferedPanelPreview.AllowDrop = true;
            resources.ApplyResources(this.bufferedPanelPreview, "bufferedPanelPreview");
            this.bufferedPanelPreview.ContextMenuStrip = this.contextMenuStripImage;
            this.bufferedPanelPreview.Controls.Add(this.labelDragDropPreview);
            this.bufferedPanelPreview.Name = "bufferedPanelPreview";
            this.bufferedPanelPreview.DragDrop += new System.Windows.Forms.DragEventHandler(this.bufferedPanelPreview_DragDrop);
            this.bufferedPanelPreview.DragEnter += new System.Windows.Forms.DragEventHandler(this.bufferedPanelPreview_DragEnter);
            // 
            // labelDragDropPreview
            // 
            this.labelDragDropPreview.AllowDrop = true;
            this.labelDragDropPreview.BackColor = System.Drawing.Color.Transparent;
            this.labelDragDropPreview.ContextMenuStrip = this.contextMenuStripImage;
            resources.ApplyResources(this.labelDragDropPreview, "labelDragDropPreview");
            this.labelDragDropPreview.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelDragDropPreview.Name = "labelDragDropPreview";
            this.labelDragDropPreview.DragDrop += new System.Windows.Forms.DragEventHandler(this.bufferedPanelPreview_DragDrop);
            this.labelDragDropPreview.DragEnter += new System.Windows.Forms.DragEventHandler(this.bufferedPanelPreview_DragEnter);
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.bufferedPanelPreview);
            this.Controls.Add(this.toolStripMenu);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "FormMain";
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

