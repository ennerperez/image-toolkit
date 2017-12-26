namespace Toolkit.Forms
{
    partial class FormCrop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCrop));
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelX = new System.Windows.Forms.Label();
            this.numericUpDownX = new System.Windows.Forms.NumericUpDown();
            this.labelY = new System.Windows.Forms.Label();
            this.numericUpDownY = new System.Windows.Forms.NumericUpDown();
            this.labelWidth = new System.Windows.Forms.Label();
            this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.labelHeight = new System.Windows.Forms.Label();
            this.numericUpDownHeight = new System.Windows.Forms.NumericUpDown();
            this.buttonCrop = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.imageCropControl = new OpenLiveWriter.Controls.ImageCropControl();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.buttonCrop);
            this.panel1.Controls.Add(this.buttonOk);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.panel1.Name = "panel1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.labelX);
            this.flowLayoutPanel1.Controls.Add(this.numericUpDownX);
            this.flowLayoutPanel1.Controls.Add(this.labelY);
            this.flowLayoutPanel1.Controls.Add(this.numericUpDownY);
            this.flowLayoutPanel1.Controls.Add(this.labelWidth);
            this.flowLayoutPanel1.Controls.Add(this.numericUpDownWidth);
            this.flowLayoutPanel1.Controls.Add(this.labelHeight);
            this.flowLayoutPanel1.Controls.Add(this.numericUpDownHeight);
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // labelX
            // 
            resources.ApplyResources(this.labelX, "labelX");
            this.labelX.Name = "labelX";
            // 
            // numericUpDownX
            // 
            resources.ApplyResources(this.numericUpDownX, "numericUpDownX");
            this.numericUpDownX.Name = "numericUpDownX";
            this.numericUpDownX.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // labelY
            // 
            resources.ApplyResources(this.labelY, "labelY");
            this.labelY.Name = "labelY";
            // 
            // numericUpDownY
            // 
            resources.ApplyResources(this.numericUpDownY, "numericUpDownY");
            this.numericUpDownY.Name = "numericUpDownY";
            this.numericUpDownY.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // labelWidth
            // 
            resources.ApplyResources(this.labelWidth, "labelWidth");
            this.labelWidth.Name = "labelWidth";
            // 
            // numericUpDownWidth
            // 
            resources.ApplyResources(this.numericUpDownWidth, "numericUpDownWidth");
            this.numericUpDownWidth.Name = "numericUpDownWidth";
            this.numericUpDownWidth.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // labelHeight
            // 
            resources.ApplyResources(this.labelHeight, "labelHeight");
            this.labelHeight.Name = "labelHeight";
            // 
            // numericUpDownHeight
            // 
            resources.ApplyResources(this.numericUpDownHeight, "numericUpDownHeight");
            this.numericUpDownHeight.Name = "numericUpDownHeight";
            this.numericUpDownHeight.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // buttonCrop
            // 
            resources.ApplyResources(this.buttonCrop, "buttonCrop");
            this.buttonCrop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonCrop.Name = "buttonCrop";
            this.buttonCrop.UseVisualStyleBackColor = true;
            this.buttonCrop.Click += new System.EventHandler(this.ButtonCrop_Click);
            // 
            // buttonOk
            // 
            resources.ApplyResources(this.buttonOk, "buttonOk");
            this.buttonOk.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // imageCropControl
            // 
            this.imageCropControl.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            resources.ApplyResources(this.imageCropControl, "imageCropControl");
            this.imageCropControl.AspectRatio = null;
            this.imageCropControl.Bitmap = null;
            this.imageCropControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageCropControl.GridLines = false;
            this.imageCropControl.Name = "imageCropControl";
            this.imageCropControl.TabStop = false;
            this.imageCropControl.CropRectangleChanged += new System.EventHandler(this.ImageCropControl_CropRectangleChanged);
            // 
            // FormCrop
            // 
            this.AcceptButton = this.buttonOk;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.imageCropControl);
            this.DoubleBuffered = true;
            this.Name = "FormCrop";
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private OpenLiveWriter.Controls.ImageCropControl imageCropControl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCrop;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.NumericUpDown numericUpDownHeight;
        private System.Windows.Forms.NumericUpDown numericUpDownX;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.NumericUpDown numericUpDownWidth;
        private System.Windows.Forms.NumericUpDown numericUpDownY;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}