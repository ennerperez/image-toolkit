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
            this.openFileDialogMain = new System.Windows.Forms.OpenFileDialog();
            this.toolTipMain = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialogMain = new System.Windows.Forms.SaveFileDialog();
            this.contextMenuStripImage = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAbout = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClear = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonChromaKey = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCrop = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRestore = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonToB64 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFromB64 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.bufferedPanelPreview = new System.Windows.Forms.BufferedPanel();
            this.labelPreview = new System.Windows.Forms.Label();
            this.contextMenuStripImage.SuspendLayout();
            this.toolStripMenu.SuspendLayout();
            this.bufferedPanelPreview.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialogMain
            // 
            this.openFileDialogMain.DefaultExt = "jpg";
            resources.ApplyResources(this.openFileDialogMain, "openFileDialogMain");
            this.openFileDialogMain.Tag = "";
            this.openFileDialogMain.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialogMain_FileOk);
            // 
            // saveFileDialogMain
            // 
            this.saveFileDialogMain.DefaultExt = "jpg";
            resources.ApplyResources(this.saveFileDialogMain, "saveFileDialogMain");
            this.saveFileDialogMain.Tag = "";
            this.saveFileDialogMain.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveFileDialogMain_FileOk);
            // 
            // contextMenuStripImage
            // 
            this.contextMenuStripImage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.contextMenuStripImage.Name = "contextMenuStripImage";
            resources.ApplyResources(this.contextMenuStripImage, "contextMenuStripImage");
            this.contextMenuStripImage.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStripImage_Opening);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            resources.ApplyResources(this.copyToolStripMenuItem, "copyToolStripMenuItem");
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            resources.ApplyResources(this.pasteToolStripMenuItem, "pasteToolStripMenuItem");
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
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
            this.toolStripButtonChromaKey,
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
            this.toolStripButtonOpen.Click += new System.EventHandler(this.ToolStripButtonOpen_Click);
            // 
            // toolStripButtonClose
            // 
            this.toolStripButtonClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.toolStripButtonClose, "toolStripButtonClose");
            this.toolStripButtonClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonClose.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonClose.Name = "toolStripButtonClose";
            this.toolStripButtonClose.Click += new System.EventHandler(this.ToolStripButtonClose_Click);
            // 
            // toolStripButtonAbout
            // 
            this.toolStripButtonAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.toolStripButtonAbout, "toolStripButtonAbout");
            this.toolStripButtonAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAbout.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonAbout.Name = "toolStripButtonAbout";
            this.toolStripButtonAbout.Click += new System.EventHandler(this.ToolStripButtonAbout_Click);
            // 
            // toolStripButtonClear
            // 
            resources.ApplyResources(this.toolStripButtonClear, "toolStripButtonClear");
            this.toolStripButtonClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonClear.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonClear.Name = "toolStripButtonClear";
            this.toolStripButtonClear.Click += new System.EventHandler(this.ToolStripButtonClear_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // toolStripButtonChromaKey
            // 
            resources.ApplyResources(this.toolStripButtonChromaKey, "toolStripButtonChromaKey");
            this.toolStripButtonChromaKey.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonChromaKey.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonChromaKey.Name = "toolStripButtonChromaKey";
            this.toolStripButtonChromaKey.Click += new System.EventHandler(this.ToolStripButtonChromaKey_Click);
            // 
            // toolStripButtonCrop
            // 
            resources.ApplyResources(this.toolStripButtonCrop, "toolStripButtonCrop");
            this.toolStripButtonCrop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCrop.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonCrop.Name = "toolStripButtonCrop";
            this.toolStripButtonCrop.Click += new System.EventHandler(this.ToolStripButtonCrop_Click);
            // 
            // toolStripButtonRestore
            // 
            resources.ApplyResources(this.toolStripButtonRestore, "toolStripButtonRestore");
            this.toolStripButtonRestore.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRestore.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonRestore.Name = "toolStripButtonRestore";
            this.toolStripButtonRestore.Click += new System.EventHandler(this.ToolStripButtonRestore_Click);
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
            this.toolStripButtonToB64.Click += new System.EventHandler(this.ToolStripButtonToB64_Click);
            // 
            // toolStripButtonFromB64
            // 
            resources.ApplyResources(this.toolStripButtonFromB64, "toolStripButtonFromB64");
            this.toolStripButtonFromB64.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFromB64.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonFromB64.Name = "toolStripButtonFromB64";
            this.toolStripButtonFromB64.Click += new System.EventHandler(this.ToolStripButtonFromB64_Click);
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
            this.toolStripButtonSave.Click += new System.EventHandler(this.ToolStripButtonSave_Click);
            // 
            // bufferedPanelPreview
            // 
            this.bufferedPanelPreview.AllowDrop = true;
            resources.ApplyResources(this.bufferedPanelPreview, "bufferedPanelPreview");
            this.bufferedPanelPreview.ContextMenuStrip = this.contextMenuStripImage;
            this.bufferedPanelPreview.Controls.Add(this.labelPreview);
            this.bufferedPanelPreview.Name = "bufferedPanelPreview";
            this.bufferedPanelPreview.DragDrop += new System.Windows.Forms.DragEventHandler(this.FormMain_DragDrop);
            this.bufferedPanelPreview.DragEnter += new System.Windows.Forms.DragEventHandler(this.FormMain_DragEnter);
            // 
            // labelPreview
            // 
            this.labelPreview.AllowDrop = true;
            this.labelPreview.BackColor = System.Drawing.Color.Transparent;
            this.labelPreview.ContextMenuStrip = this.contextMenuStripImage;
            resources.ApplyResources(this.labelPreview, "labelPreview");
            this.labelPreview.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelPreview.Name = "labelPreview";
            this.labelPreview.DragDrop += new System.Windows.Forms.DragEventHandler(this.FormMain_DragDrop);
            this.labelPreview.DragEnter += new System.Windows.Forms.DragEventHandler(this.FormMain_DragEnter);
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.Load += FormMain_Load;
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
        private System.Windows.Forms.Label labelPreview;
        private System.Windows.Forms.BufferedPanel bufferedPanelPreview;
        private System.Windows.Forms.OpenFileDialog openFileDialogMain;
        private System.Windows.Forms.ToolTip toolTipMain;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMain;
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
        private System.Windows.Forms.ToolStripButton toolStripButtonChromaKey;
    }
}

