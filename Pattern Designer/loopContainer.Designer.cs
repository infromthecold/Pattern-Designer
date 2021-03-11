
namespace Pattern_Designer
{
	partial class loopContainer
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
			this.loopCount = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.loopCount)).BeginInit();
			this.SuspendLayout();
			// 
			// loopCount
			// 
			this.loopCount.Location = new System.Drawing.Point(9, 6);
			this.loopCount.Name = "loopCount";
			this.loopCount.Size = new System.Drawing.Size(41, 20);
			this.loopCount.TabIndex = 0;
			this.loopCount.ValueChanged += new System.EventHandler(this.updateCounter);
			// 
			// loopContainer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.ClientSize = new System.Drawing.Size(145, 32);
			this.ControlBox = false;
			this.Controls.Add(this.loopCount);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "loopContainer";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			((System.ComponentModel.ISupportInitialize)(this.loopCount)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.NumericUpDown loopCount;
	}
}