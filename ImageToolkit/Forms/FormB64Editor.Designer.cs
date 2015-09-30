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
            this.textBoxB64.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxB64.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxB64.Location = new System.Drawing.Point(12, 12);
            this.textBoxB64.Multiline = true;
            this.textBoxB64.Name = "textBoxB64";
            this.textBoxB64.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxB64.Size = new System.Drawing.Size(600, 506);
            this.textBoxB64.TabIndex = 0;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(537, 524);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 25);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonAction
            // 
            this.buttonAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAction.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAction.Location = new System.Drawing.Point(456, 524);
            this.buttonAction.Name = "buttonAction";
            this.buttonAction.Size = new System.Drawing.Size(75, 25);
            this.buttonAction.TabIndex = 3;
            this.buttonAction.Text = "&Action";
            this.buttonAction.UseVisualStyleBackColor = true;
            this.buttonAction.Click += new System.EventHandler(this.buttonAction_Click);
            // 
            // numericUpDownColumns
            // 
            this.numericUpDownColumns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDownColumns.Location = new System.Drawing.Point(79, 524);
            this.numericUpDownColumns.Name = "numericUpDownColumns";
            this.numericUpDownColumns.Size = new System.Drawing.Size(51, 25);
            this.numericUpDownColumns.TabIndex = 2;
            this.numericUpDownColumns.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.numericUpDownColumns.ValueChanged += new System.EventHandler(this.numericUpDownColumns_ValueChanged);
            // 
            // labelColumns
            // 
            this.labelColumns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelColumns.AutoSize = true;
            this.labelColumns.Location = new System.Drawing.Point(12, 528);
            this.labelColumns.Name = "labelColumns";
            this.labelColumns.Size = new System.Drawing.Size(61, 17);
            this.labelColumns.TabIndex = 1;
            this.labelColumns.Text = "C&olumns:";
            // 
            // saveFileDialogB64
            // 
            this.saveFileDialogB64.DefaultExt = "txt";
            this.saveFileDialogB64.Filter = "Text files ({0}) | {1}";
            this.saveFileDialogB64.Title = "Save...";
            this.saveFileDialogB64.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialogB64_FileOk);
            // 
            // FormB64Editor
            // 
            this.AcceptButton = this.buttonAction;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(624, 561);
            this.Controls.Add(this.labelColumns);
            this.Controls.Add(this.numericUpDownColumns);
            this.Controls.Add(this.buttonAction);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.textBoxB64);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(320, 320);
            this.Name = "FormB64Editor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "B64 - Editor";
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