namespace Toolkit.Forms
{
    partial class FormB64Editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormB64Editor));
            this.textBoxB64 = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonAction = new System.Windows.Forms.Button();
            this.numericUpDownColumns = new System.Windows.Forms.NumericUpDown();
            this.labelColumns = new System.Windows.Forms.Label();
            this.saveFileDialogB64 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColumns)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxB64
            // 
            resources.ApplyResources(this.textBoxB64, "textBoxB64");
            this.textBoxB64.Name = "textBoxB64";
            // 
            // buttonClose
            // 
            resources.ApplyResources(this.buttonClose, "buttonClose");
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonAction
            // 
            resources.ApplyResources(this.buttonAction, "buttonAction");
            this.buttonAction.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAction.Name = "buttonAction";
            this.buttonAction.UseVisualStyleBackColor = true;
            this.buttonAction.Click += new System.EventHandler(this.buttonAction_Click);
            // 
            // numericUpDownColumns
            // 
            resources.ApplyResources(this.numericUpDownColumns, "numericUpDownColumns");
            this.numericUpDownColumns.Name = "numericUpDownColumns";
            this.numericUpDownColumns.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.numericUpDownColumns.ValueChanged += new System.EventHandler(this.numericUpDownColumns_ValueChanged);
            // 
            // labelColumns
            // 
            resources.ApplyResources(this.labelColumns, "labelColumns");
            this.labelColumns.Name = "labelColumns";
            // 
            // saveFileDialogB64
            // 
            this.saveFileDialogB64.DefaultExt = "txt";
            resources.ApplyResources(this.saveFileDialogB64, "saveFileDialogB64");
            this.saveFileDialogB64.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialogB64_FileOk);
            // 
            // FormB64Editor
            // 
            this.AcceptButton = this.buttonAction;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.buttonClose;
            this.Controls.Add(this.labelColumns);
            this.Controls.Add(this.numericUpDownColumns);
            this.Controls.Add(this.buttonAction);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.textBoxB64);
            this.DoubleBuffered = true;
            this.Name = "FormB64Editor";
            this.Load += new System.EventHandler(this.FormB64Editor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColumns)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxB64;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonAction;
        private System.Windows.Forms.NumericUpDown numericUpDownColumns;
        private System.Windows.Forms.Label labelColumns;
        private System.Windows.Forms.SaveFileDialog saveFileDialogB64;
    }
}