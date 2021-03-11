
namespace Pattern_Designer
{
	partial class Settings
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
			this.label1 = new System.Windows.Forms.Label();
			this.guideWidth = new System.Windows.Forms.NumericUpDown();
			this.guideLable = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.guideHeight = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.spriteSize = new System.Windows.Forms.NumericUpDown();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.BR = new System.Windows.Forms.RadioButton();
			this.BC = new System.Windows.Forms.RadioButton();
			this.BL = new System.Windows.Forms.RadioButton();
			this.MR = new System.Windows.Forms.RadioButton();
			this.MC = new System.Windows.Forms.RadioButton();
			this.ML = new System.Windows.Forms.RadioButton();
			this.TR = new System.Windows.Forms.RadioButton();
			this.TC = new System.Windows.Forms.RadioButton();
			this.TL = new System.Windows.Forms.RadioButton();
			this.useGrid = new System.Windows.Forms.CheckBox();
			this.gridSize = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.guideWidth)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.guideHeight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.spriteSize)).BeginInit();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridSize)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Width";
			// 
			// guideWidth
			// 
			this.guideWidth.Location = new System.Drawing.Point(52, 19);
			this.guideWidth.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
			this.guideWidth.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
			this.guideWidth.Name = "guideWidth";
			this.guideWidth.Size = new System.Drawing.Size(49, 20);
			this.guideWidth.TabIndex = 1;
			this.guideWidth.Value = new decimal(new int[] {
            320,
            0,
            0,
            0});
			// 
			// guideLable
			// 
			this.guideLable.AutoSize = true;
			this.guideLable.Location = new System.Drawing.Point(107, 21);
			this.guideLable.Name = "guideLable";
			this.guideLable.Size = new System.Drawing.Size(38, 13);
			this.guideLable.TabIndex = 2;
			this.guideLable.Text = "Height";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.guideHeight);
			this.groupBox1.Controls.Add(this.guideLable);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.guideWidth);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(212, 51);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Guide";
			// 
			// guideHeight
			// 
			this.guideHeight.Location = new System.Drawing.Point(151, 19);
			this.guideHeight.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
			this.guideHeight.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
			this.guideHeight.Name = "guideHeight";
			this.guideHeight.Size = new System.Drawing.Size(49, 20);
			this.guideHeight.TabIndex = 2;
			this.guideHeight.Value = new decimal(new int[] {
            256,
            0,
            0,
            0});
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(18, 265);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Sprite Size";
			// 
			// spriteSize
			// 
			this.spriteSize.Location = new System.Drawing.Point(163, 263);
			this.spriteSize.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
			this.spriteSize.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
			this.spriteSize.Name = "spriteSize";
			this.spriteSize.Size = new System.Drawing.Size(49, 20);
			this.spriteSize.TabIndex = 5;
			this.spriteSize.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
			this.groupBox3.Controls.Add(this.BR);
			this.groupBox3.Controls.Add(this.BC);
			this.groupBox3.Controls.Add(this.BL);
			this.groupBox3.Controls.Add(this.MR);
			this.groupBox3.Controls.Add(this.MC);
			this.groupBox3.Controls.Add(this.ML);
			this.groupBox3.Controls.Add(this.TR);
			this.groupBox3.Controls.Add(this.TC);
			this.groupBox3.Controls.Add(this.TL);
			this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox3.Location = new System.Drawing.Point(12, 70);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(212, 154);
			this.groupBox3.TabIndex = 9;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Start Position";
			// 
			// BR
			// 
			this.BR.AutoSize = true;
			this.BR.Location = new System.Drawing.Point(186, 120);
			this.BR.Name = "BR";
			this.BR.Size = new System.Drawing.Size(14, 13);
			this.BR.TabIndex = 8;
			this.BR.TabStop = true;
			this.BR.UseVisualStyleBackColor = true;
			this.BR.Click += new System.EventHandler(this.okButonClick);
			// 
			// BC
			// 
			this.BC.AutoSize = true;
			this.BC.Location = new System.Drawing.Point(101, 120);
			this.BC.Name = "BC";
			this.BC.Size = new System.Drawing.Size(14, 13);
			this.BC.TabIndex = 7;
			this.BC.TabStop = true;
			this.BC.UseVisualStyleBackColor = true;
			this.BC.Click += new System.EventHandler(this.okButonClick);
			// 
			// BL
			// 
			this.BL.AutoSize = true;
			this.BL.Location = new System.Drawing.Point(16, 120);
			this.BL.Name = "BL";
			this.BL.Size = new System.Drawing.Size(14, 13);
			this.BL.TabIndex = 6;
			this.BL.TabStop = true;
			this.BL.UseVisualStyleBackColor = true;
			this.BL.Click += new System.EventHandler(this.okButonClick);
			// 
			// MR
			// 
			this.MR.AutoSize = true;
			this.MR.Location = new System.Drawing.Point(186, 74);
			this.MR.Name = "MR";
			this.MR.Size = new System.Drawing.Size(14, 13);
			this.MR.TabIndex = 5;
			this.MR.TabStop = true;
			this.MR.UseVisualStyleBackColor = true;
			this.MR.Click += new System.EventHandler(this.okButonClick);
			// 
			// MC
			// 
			this.MC.AutoSize = true;
			this.MC.Location = new System.Drawing.Point(101, 74);
			this.MC.Name = "MC";
			this.MC.Size = new System.Drawing.Size(14, 13);
			this.MC.TabIndex = 4;
			this.MC.TabStop = true;
			this.MC.UseVisualStyleBackColor = true;
			this.MC.Click += new System.EventHandler(this.okButonClick);
			// 
			// ML
			// 
			this.ML.AutoSize = true;
			this.ML.Location = new System.Drawing.Point(16, 74);
			this.ML.Name = "ML";
			this.ML.Size = new System.Drawing.Size(14, 13);
			this.ML.TabIndex = 3;
			this.ML.TabStop = true;
			this.ML.UseVisualStyleBackColor = true;
			this.ML.Click += new System.EventHandler(this.okButonClick);
			// 
			// TR
			// 
			this.TR.AutoSize = true;
			this.TR.Location = new System.Drawing.Point(186, 29);
			this.TR.Name = "TR";
			this.TR.Size = new System.Drawing.Size(14, 13);
			this.TR.TabIndex = 2;
			this.TR.TabStop = true;
			this.TR.UseVisualStyleBackColor = true;
			this.TR.Click += new System.EventHandler(this.okButonClick);
			// 
			// TC
			// 
			this.TC.AutoSize = true;
			this.TC.Location = new System.Drawing.Point(101, 29);
			this.TC.Name = "TC";
			this.TC.Size = new System.Drawing.Size(14, 13);
			this.TC.TabIndex = 1;
			this.TC.TabStop = true;
			this.TC.UseVisualStyleBackColor = true;
			this.TC.Click += new System.EventHandler(this.okButonClick);
			// 
			// TL
			// 
			this.TL.AutoSize = true;
			this.TL.Location = new System.Drawing.Point(16, 29);
			this.TL.Name = "TL";
			this.TL.Size = new System.Drawing.Size(14, 13);
			this.TL.TabIndex = 0;
			this.TL.TabStop = true;
			this.TL.UseVisualStyleBackColor = true;
			this.TL.Click += new System.EventHandler(this.okButonClick);
			// 
			// useGrid
			// 
			this.useGrid.AutoSize = true;
			this.useGrid.Location = new System.Drawing.Point(17, 231);
			this.useGrid.Name = "useGrid";
			this.useGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.useGrid.Size = new System.Drawing.Size(75, 17);
			this.useGrid.TabIndex = 10;
			this.useGrid.Text = "Show Grid";
			this.useGrid.UseVisualStyleBackColor = true;
			// 
			// gridSize
			// 
			this.gridSize.Location = new System.Drawing.Point(163, 230);
			this.gridSize.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
			this.gridSize.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
			this.gridSize.Name = "gridSize";
			this.gridSize.Size = new System.Drawing.Size(49, 20);
			this.gridSize.TabIndex = 11;
			this.gridSize.ThousandsSeparator = true;
			this.gridSize.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(130, 232);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(27, 13);
			this.label3.TabIndex = 12;
			this.label3.Text = "Size";
			// 
			// button1
			// 
			this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button1.Location = new System.Drawing.Point(82, 291);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 13;
			this.button1.Text = "Close";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.okButonClick);
			// 
			// Settings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(236, 325);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.gridSize);
			this.Controls.Add(this.useGrid);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.spriteSize);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Settings";
			this.Text = "Settings";
			((System.ComponentModel.ISupportInitialize)(this.guideWidth)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.guideHeight)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.spriteSize)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridSize)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label guideLable;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox3;
		public System.Windows.Forms.RadioButton BR;
		public System.Windows.Forms.RadioButton BC;
		public System.Windows.Forms.RadioButton BL;
		public System.Windows.Forms.RadioButton MR;
		public System.Windows.Forms.RadioButton MC;
		public System.Windows.Forms.RadioButton ML;
		public System.Windows.Forms.RadioButton TR;
		public System.Windows.Forms.RadioButton TC;
		public System.Windows.Forms.RadioButton TL;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button1;
		public System.Windows.Forms.NumericUpDown spriteSize;
		public System.Windows.Forms.CheckBox useGrid;
		public System.Windows.Forms.NumericUpDown gridSize;
		public System.Windows.Forms.NumericUpDown guideWidth;
		public System.Windows.Forms.NumericUpDown guideHeight;
	}
}