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
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 399);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 9);
            this.panel1.Size = new System.Drawing.Size(624, 42);
            this.panel1.TabIndex = 3;
            // 
            // tableLayoutPanelManual
            // 
            this.tableLayoutPanelManual.ColumnCount = 9;
            this.tableLayoutPanelManual.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelManual.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelManual.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelManual.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelManual.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelManual.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelManual.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelManual.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelManual.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelManual.Controls.Add(this.panel2, 8, 0);
            this.tableLayoutPanelManual.Controls.Add(this.labelX, 0, 0);
            this.tableLayoutPanelManual.Controls.Add(this.numericUpDownHeight, 7, 0);
            this.tableLayoutPanelManual.Controls.Add(this.numericUpDownX, 1, 0);
            this.tableLayoutPanelManual.Controls.Add(this.labelHeight, 6, 0);
            this.tableLayoutPanelManual.Controls.Add(this.numericUpDownWidth, 5, 0);
            this.tableLayoutPanelManual.Controls.Add(this.numericUpDownY, 3, 0);
            this.tableLayoutPanelManual.Controls.Add(this.labelY, 2, 0);
            this.tableLayoutPanelManual.Controls.Add(this.labelWidth, 4, 0);
            this.tableLayoutPanelManual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelManual.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanelManual.Name = "tableLayoutPanelManual";
            this.tableLayoutPanelManual.RowCount = 1;
            this.tableLayoutPanelManual.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelManual.Size = new System.Drawing.Size(612, 27);
            this.tableLayoutPanelManual.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonCrop);
            this.panel2.Controls.Add(this.buttonOk);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(456, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(153, 21);
            this.panel2.TabIndex = 4;
            // 
            // buttonCrop
            // 
            this.buttonCrop.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonCrop.Location = new System.Drawing.Point(3, 0);
            this.buttonCrop.Name = "buttonCrop";
            this.buttonCrop.Size = new System.Drawing.Size(75, 21);
            this.buttonCrop.TabIndex = 4;
            this.buttonCrop.Text = "&Crop";
            this.buttonCrop.UseVisualStyleBackColor = true;
            this.buttonCrop.Click += new System.EventHandler(this.buttonCrop_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonOk.Enabled = false;
            this.buttonOk.Location = new System.Drawing.Point(78, 0);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 21);
            this.buttonOk.TabIndex = 5;
            this.buttonOk.Text = "&Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // labelX
            // 
            this.labelX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelX.Location = new System.Drawing.Point(3, 0);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(17, 27);
            this.labelX.TabIndex = 0;
            this.labelX.Text = "&X:";
            this.labelX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDownHeight
            // 
            this.numericUpDownHeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownHeight.Enabled = false;
            this.numericUpDownHeight.Location = new System.Drawing.Point(377, 3);
            this.numericUpDownHeight.Name = "numericUpDownHeight";
            this.numericUpDownHeight.Size = new System.Drawing.Size(73, 20);
            this.numericUpDownHeight.TabIndex = 1;
            this.numericUpDownHeight.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // numericUpDownX
            // 
            this.numericUpDownX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownX.Enabled = false;
            this.numericUpDownX.Location = new System.Drawing.Point(26, 3);
            this.numericUpDownX.Name = "numericUpDownX";
            this.numericUpDownX.Size = new System.Drawing.Size(73, 20);
            this.numericUpDownX.TabIndex = 1;
            this.numericUpDownX.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // labelHeight
            // 
            this.labelHeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHeight.Location = new System.Drawing.Point(330, 0);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(41, 27);
            this.labelHeight.TabIndex = 0;
            this.labelHeight.Text = "&Height:";
            this.labelHeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDownWidth
            // 
            this.numericUpDownWidth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownWidth.Enabled = false;
            this.numericUpDownWidth.Location = new System.Drawing.Point(251, 3);
            this.numericUpDownWidth.Name = "numericUpDownWidth";
            this.numericUpDownWidth.Size = new System.Drawing.Size(73, 20);
            this.numericUpDownWidth.TabIndex = 1;
            this.numericUpDownWidth.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // numericUpDownY
            // 
            this.numericUpDownY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownY.Enabled = false;
            this.numericUpDownY.Location = new System.Drawing.Point(128, 3);
            this.numericUpDownY.Name = "numericUpDownY";
            this.numericUpDownY.Size = new System.Drawing.Size(73, 20);
            this.numericUpDownY.TabIndex = 1;
            this.numericUpDownY.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // labelY
            // 
            this.labelY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelY.Location = new System.Drawing.Point(105, 0);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(17, 27);
            this.labelY.TabIndex = 0;
            this.labelY.Text = "&Y:";
            this.labelY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelWidth
            // 
            this.labelWidth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWidth.Location = new System.Drawing.Point(207, 0);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(38, 27);
            this.labelWidth.TabIndex = 0;
            this.labelWidth.Text = "&Width:";
            this.labelWidth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imageCropControl
            // 
            this.imageCropControl.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            this.imageCropControl.AspectRatio = null;
            this.imageCropControl.Bitmap = null;
            this.imageCropControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageCropControl.GridLines = false;
            this.imageCropControl.Location = new System.Drawing.Point(0, 0);
            this.imageCropControl.Name = "imageCropControl";
            this.imageCropControl.Size = new System.Drawing.Size(624, 399);
            this.imageCropControl.TabIndex = 2;
            this.imageCropControl.CropRectangleChanged += new System.EventHandler(this.imageCropControl_CropRectangleChanged);
            // 
            // FormCrop
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.imageCropControl);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCrop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Crop";
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