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
            this.tableLayoutPanelManual = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonCrop = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.labelX = new System.Windows.Forms.Label();
            this.numericUpDownHeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownX = new System.Windows.Forms.NumericUpDown();
            this.labelHeight = new System.Windows.Forms.Label();
            this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownY = new System.Windows.Forms.NumericUpDown();
            this.labelY = new System.Windows.Forms.Label();
            this.labelWidth = new System.Windows.Forms.Label();
            this.imageCropControl = new OpenLiveWriter.Controls.ImageCropControl();
            this.panel1.SuspendLayout();
            this.tableLayoutPanelManual.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.tableLayoutPanelManual);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // tableLayoutPanelManual
            // 
            resources.ApplyResources(this.tableLayoutPanelManual, "tableLayoutPanelManual");
            this.tableLayoutPanelManual.Controls.Add(this.panel2, 8, 0);
            this.tableLayoutPanelManual.Controls.Add(this.labelX, 0, 0);
            this.tableLayoutPanelManual.Controls.Add(this.numericUpDownHeight, 7, 0);
            this.tableLayoutPanelManual.Controls.Add(this.numericUpDownX, 1, 0);
            this.tableLayoutPanelManual.Controls.Add(this.labelHeight, 6, 0);
            this.tableLayoutPanelManual.Controls.Add(this.numericUpDownWidth, 5, 0);
            this.tableLayoutPanelManual.Controls.Add(this.numericUpDownY, 3, 0);
            this.tableLayoutPanelManual.Controls.Add(this.labelY, 2, 0);
            this.tableLayoutPanelManual.Controls.Add(this.labelWidth, 4, 0);
            this.tableLayoutPanelManual.Name = "tableLayoutPanelManual";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonCrop);
            this.panel2.Controls.Add(this.buttonOk);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // buttonCrop
            // 
            resources.ApplyResources(this.buttonCrop, "buttonCrop");
            this.buttonCrop.Name = "buttonCrop";
            this.buttonCrop.UseVisualStyleBackColor = true;
            this.buttonCrop.Click += new System.EventHandler(this.buttonCrop_Click);
            // 
            // buttonOk
            // 
            resources.ApplyResources(this.buttonOk, "buttonOk");
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // labelX
            // 
            resources.ApplyResources(this.labelX, "labelX");
            this.labelX.Name = "labelX";
            // 
            // numericUpDownHeight
            // 
            resources.ApplyResources(this.numericUpDownHeight, "numericUpDownHeight");
            this.numericUpDownHeight.Name = "numericUpDownHeight";
            this.numericUpDownHeight.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // numericUpDownX
            // 
            resources.ApplyResources(this.numericUpDownX, "numericUpDownX");
            this.numericUpDownX.Name = "numericUpDownX";
            this.numericUpDownX.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // labelHeight
            // 
            resources.ApplyResources(this.labelHeight, "labelHeight");
            this.labelHeight.Name = "labelHeight";
            // 
            // numericUpDownWidth
            // 
            resources.ApplyResources(this.numericUpDownWidth, "numericUpDownWidth");
            this.numericUpDownWidth.Name = "numericUpDownWidth";
            this.numericUpDownWidth.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // numericUpDownY
            // 
            resources.ApplyResources(this.numericUpDownY, "numericUpDownY");
            this.numericUpDownY.Name = "numericUpDownY";
            this.numericUpDownY.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // labelY
            // 
            resources.ApplyResources(this.labelY, "labelY");
            this.labelY.Name = "labelY";
            // 
            // labelWidth
            // 
            resources.ApplyResources(this.labelWidth, "labelWidth");
            this.labelWidth.Name = "labelWidth";
            // 
            // imageCropControl
            // 
            this.imageCropControl.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            this.imageCropControl.AspectRatio = null;
            this.imageCropControl.Bitmap = null;
            resources.ApplyResources(this.imageCropControl, "imageCropControl");
            this.imageCropControl.GridLines = false;
            this.imageCropControl.Name = "imageCropControl";
            this.imageCropControl.CropRectangleChanged += new System.EventHandler(this.imageCropControl_CropRectangleChanged);
            // 
            // FormCrop
            // 
            this.AcceptButton = this.buttonOk;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.imageCropControl);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "FormCrop";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanelManual.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private OpenLiveWriter.Controls.ImageCropControl imageCropControl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelManual;
        private System.Windows.Forms.Button buttonCrop;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.NumericUpDown numericUpDownHeight;
        private System.Windows.Forms.NumericUpDown numericUpDownX;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.NumericUpDown numericUpDownWidth;
        private System.Windows.Forms.NumericUpDown numericUpDownY;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonOk;
    }
}