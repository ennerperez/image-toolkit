namespace Toolkit.Forms
{
    partial class FormChroma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChroma));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonColor = new System.Windows.Forms.Button();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.labelKey = new System.Windows.Forms.Label();
            this.buttonKey = new System.Windows.Forms.Button();
            this.labelPercentage = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.numericUpDownPercentage = new System.Windows.Forms.NumericUpDown();
            this.colorDialogKey = new System.Windows.Forms.ColorDialog();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.buttonApply);
            this.panel1.Controls.Add(this.buttonOk);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // buttonColor
            // 
            resources.ApplyResources(this.buttonColor, "buttonColor");
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonApply
            // 
            resources.ApplyResources(this.buttonApply, "buttonApply");
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonOk
            // 
            resources.ApplyResources(this.buttonOk, "buttonOk");
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // labelKey
            // 
            resources.ApplyResources(this.labelKey, "labelKey");
            this.labelKey.Name = "labelKey";
            // 
            // buttonKey
            // 
            resources.ApplyResources(this.buttonKey, "buttonKey");
            this.buttonKey.Name = "buttonKey";
            this.buttonKey.UseVisualStyleBackColor = true;
            this.buttonKey.Click += new System.EventHandler(this.buttonKey_Click);
            // 
            // labelPercentage
            // 
            resources.ApplyResources(this.labelPercentage, "labelPercentage");
            this.labelPercentage.Name = "labelPercentage";
            // 
            // labelColor
            // 
            resources.ApplyResources(this.labelColor, "labelColor");
            this.labelColor.Name = "labelColor";
            // 
            // numericUpDownPercentage
            // 
            resources.ApplyResources(this.numericUpDownPercentage, "numericUpDownPercentage");
            this.numericUpDownPercentage.Name = "numericUpDownPercentage";
            // 
            // colorDialogKey
            // 
            this.colorDialogKey.AnyColor = true;
            this.colorDialogKey.FullOpen = true;
            // 
            // pictureBoxImage
            // 
            resources.ApplyResources(this.pictureBoxImage, "pictureBoxImage");
            this.pictureBoxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.labelKey);
            this.flowLayoutPanel1.Controls.Add(this.buttonKey);
            this.flowLayoutPanel1.Controls.Add(this.labelPercentage);
            this.flowLayoutPanel1.Controls.Add(this.numericUpDownPercentage);
            this.flowLayoutPanel1.Controls.Add(this.labelColor);
            this.flowLayoutPanel1.Controls.Add(this.buttonColor);
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // FormChroma
            // 
            this.AcceptButton = this.buttonOk;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.pictureBoxImage);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "FormChroma";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.NumericUpDown numericUpDownPercentage;
        private System.Windows.Forms.Label labelPercentage;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonKey;
        private System.Windows.Forms.ColorDialog colorDialogKey;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}