
namespace Pattern_Designer
{
	partial class Pattern
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
			this.Id = new System.Windows.Forms.Label();
			this.checkBox = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.udDelay = new System.Windows.Forms.NumericUpDown();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.spawnBox = new System.Windows.Forms.ComboBox();
			this.udDirection = new System.Windows.Forms.NumericUpDown();
			this.udTurn = new System.Windows.Forms.NumericUpDown();
			this.udSpeed = new System.Windows.Forms.NumericUpDown();
			this.udTime = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.colorBox = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.udDelay)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.udDirection)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.udTurn)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.udSpeed)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.udTime)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(21, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "ID:";
			// 
			// Id
			// 
			this.Id.AutoSize = true;
			this.Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Id.Location = new System.Drawing.Point(32, 8);
			this.Id.Name = "Id";
			this.Id.Size = new System.Drawing.Size(15, 16);
			this.Id.TabIndex = 5;
			this.Id.Text = "0";
			// 
			// checkBox
			// 
			this.checkBox.AutoSize = true;
			this.checkBox.Location = new System.Drawing.Point(133, 10);
			this.checkBox.Name = "checkBox";
			this.checkBox.Size = new System.Drawing.Size(15, 14);
			this.checkBox.TabIndex = 7;
			this.checkBox.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(7, 62);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(26, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Dir+";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(7, 88);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(29, 13);
			this.label5.TabIndex = 12;
			this.label5.Text = "Turn";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(7, 140);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(30, 13);
			this.label7.TabIndex = 4;
			this.label7.Text = "Time";
			// 
			// udDelay
			// 
			this.udDelay.Location = new System.Drawing.Point(101, 34);
			this.udDelay.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
			this.udDelay.Name = "udDelay";
			this.udDelay.Size = new System.Drawing.Size(47, 20);
			this.udDelay.TabIndex = 3;
			this.udDelay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.udDelay.VisibleChanged += new System.EventHandler(this.updateSelected);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(7, 167);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(40, 13);
			this.label10.TabIndex = 0;
			this.label10.Text = "Spawn";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(7, 114);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(44, 13);
			this.label11.TabIndex = 20;
			this.label11.Text = "Speed+";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(7, 36);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(34, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Delay";
			// 
			// spawnBox
			// 
			this.spawnBox.FormattingEnabled = true;
			this.spawnBox.Items.AddRange(new object[] {
            "None",
            "Shoot",
            "Radial",
            "Drop"});
			this.spawnBox.Location = new System.Drawing.Point(76, 164);
			this.spawnBox.Name = "spawnBox";
			this.spawnBox.Size = new System.Drawing.Size(72, 21);
			this.spawnBox.TabIndex = 22;
			this.spawnBox.SelectedIndexChanged += new System.EventHandler(this.updateSelected);
			// 
			// udDirection
			// 
			this.udDirection.Location = new System.Drawing.Point(101, 60);
			this.udDirection.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.udDirection.Name = "udDirection";
			this.udDirection.Size = new System.Drawing.Size(47, 20);
			this.udDirection.TabIndex = 23;
			this.udDirection.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.udDirection.ValueChanged += new System.EventHandler(this.updateSelected);
			// 
			// udTurn
			// 
			this.udTurn.Location = new System.Drawing.Point(101, 86);
			this.udTurn.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
			this.udTurn.Minimum = new decimal(new int[] {
            128,
            0,
            0,
            -2147483648});
			this.udTurn.Name = "udTurn";
			this.udTurn.Size = new System.Drawing.Size(47, 20);
			this.udTurn.TabIndex = 24;
			this.udTurn.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.udTurn.ValueChanged += new System.EventHandler(this.updateSelected);
			// 
			// udSpeed
			// 
			this.udSpeed.Location = new System.Drawing.Point(101, 112);
			this.udSpeed.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
			this.udSpeed.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            -2147483648});
			this.udSpeed.Name = "udSpeed";
			this.udSpeed.Size = new System.Drawing.Size(47, 20);
			this.udSpeed.TabIndex = 25;
			this.udSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.udSpeed.ValueChanged += new System.EventHandler(this.updateSelected);
			// 
			// udTime
			// 
			this.udTime.Location = new System.Drawing.Point(101, 138);
			this.udTime.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.udTime.Name = "udTime";
			this.udTime.Size = new System.Drawing.Size(47, 20);
			this.udTime.TabIndex = 26;
			this.udTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.udTime.ValueChanged += new System.EventHandler(this.updateSelected);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(154, 11);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(13, 13);
			this.label2.TabIndex = 28;
			this.label2.Text = "+";
			this.label2.Click += new System.EventHandler(this.expandCollapse);
			// 
			// colorBox
			// 
			this.colorBox.FormattingEnabled = true;
			this.colorBox.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "Green",
            "Brown",
            "Yellow",
            "Orange",
            "Gray",
            "Purple",
            "Pink",
            "Cyan"});
			this.colorBox.Location = new System.Drawing.Point(76, 192);
			this.colorBox.Name = "colorBox";
			this.colorBox.Size = new System.Drawing.Size(72, 21);
			this.colorBox.TabIndex = 29;
			this.colorBox.SelectedIndexChanged += new System.EventHandler(this.setColour);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(7, 195);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(37, 13);
			this.label6.TabIndex = 30;
			this.label6.Text = "Colour";
			// 
			// Pattern
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 227);
			this.ControlBox = false;
			this.Controls.Add(this.label6);
			this.Controls.Add(this.colorBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.udTime);
			this.Controls.Add(this.udSpeed);
			this.Controls.Add(this.udTurn);
			this.Controls.Add(this.udDirection);
			this.Controls.Add(this.spawnBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.checkBox);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.Id);
			this.Controls.Add(this.udDelay);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.Name = "Pattern";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Pattern";
			this.Load += new System.EventHandler(this.Pattern_Load);
			((System.ComponentModel.ISupportInitialize)(this.udDelay)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.udDirection)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.udTurn)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.udSpeed)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.udTime)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.Label Id;
		public System.Windows.Forms.CheckBox checkBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label6;
		public System.Windows.Forms.NumericUpDown udDelay;
		public System.Windows.Forms.ComboBox spawnBox;
		public System.Windows.Forms.NumericUpDown udDirection;
		public System.Windows.Forms.NumericUpDown udTurn;
		public System.Windows.Forms.NumericUpDown udSpeed;
		public System.Windows.Forms.NumericUpDown udTime;
		public System.Windows.Forms.ComboBox colorBox;
	}
}