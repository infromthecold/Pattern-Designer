
namespace Pattern_Designer
{
    partial class PatternDesigner
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatternDesigner));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.addActionButton = new System.Windows.Forms.ToolStripButton();
			this.deleteActionButton = new System.Windows.Forms.ToolStripButton();
			this.upButton = new System.Windows.Forms.ToolStripButton();
			this.downButton = new System.Windows.Forms.ToolStripButton();
			this.loadButton = new System.Windows.Forms.ToolStripButton();
			this.settingsButton = new System.Windows.Forms.ToolStripButton();
			this.saveButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.unlinkButton = new System.Windows.Forms.ToolStripButton();
			this.exportButton = new System.Windows.Forms.ToolStripButton();
			this.play = new System.Windows.Forms.ToolStripButton();
			this.Stop = new System.Windows.Forms.ToolStripButton();
			this.stepButton = new System.Windows.Forms.ToolStripButton();
			this.pauseButton = new System.Windows.Forms.ToolStripButton();
			this.scrollBar = new System.Windows.Forms.VScrollBar();
			this.label2 = new System.Windows.Forms.Label();
			this.amount = new System.Windows.Forms.NumericUpDown();
			this.panel2 = new System.Windows.Forms.Panel();
			this.statusBar = new System.Windows.Forms.StatusStrip();
			this.statusLable = new System.Windows.Forms.ToolStripStatusLabel();
			this.displayArea = new System.Windows.Forms.Panel();
			this.scrollPanel = new System.Windows.Forms.Panel();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.amount)).BeginInit();
			this.panel2.SuspendLayout();
			this.statusBar.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.AutoSize = false;
			this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addActionButton,
            this.deleteActionButton,
            this.upButton,
            this.downButton,
            this.loadButton,
            this.settingsButton,
            this.saveButton,
            this.toolStripButton1,
            this.unlinkButton,
            this.exportButton,
            this.play,
            this.Stop,
            this.stepButton,
            this.pauseButton});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1213, 52);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// addActionButton
			// 
			this.addActionButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.addActionButton.Image = ((System.Drawing.Image)(resources.GetObject("addActionButton.Image")));
			this.addActionButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.addActionButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.addActionButton.Name = "addActionButton";
			this.addActionButton.Size = new System.Drawing.Size(36, 49);
			this.addActionButton.Text = "Add Action";
			this.addActionButton.Click += new System.EventHandler(this.addActionButton_Click);
			// 
			// deleteActionButton
			// 
			this.deleteActionButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.deleteActionButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteActionButton.Image")));
			this.deleteActionButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.deleteActionButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.deleteActionButton.Name = "deleteActionButton";
			this.deleteActionButton.Size = new System.Drawing.Size(36, 49);
			this.deleteActionButton.Text = "Delete Action";
			this.deleteActionButton.Click += new System.EventHandler(this.deleteActionButton_Click);
			// 
			// upButton
			// 
			this.upButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.upButton.Image = ((System.Drawing.Image)(resources.GetObject("upButton.Image")));
			this.upButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.upButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.upButton.Name = "upButton";
			this.upButton.Size = new System.Drawing.Size(36, 49);
			this.upButton.Text = "Move Up";
			this.upButton.Click += new System.EventHandler(this.upButton_Click);
			// 
			// downButton
			// 
			this.downButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.downButton.Image = ((System.Drawing.Image)(resources.GetObject("downButton.Image")));
			this.downButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.downButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.downButton.Name = "downButton";
			this.downButton.Size = new System.Drawing.Size(36, 49);
			this.downButton.Text = "Move Down";
			this.downButton.Click += new System.EventHandler(this.downButton_Click);
			// 
			// loadButton
			// 
			this.loadButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.loadButton.Image = ((System.Drawing.Image)(resources.GetObject("loadButton.Image")));
			this.loadButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.loadButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.loadButton.Name = "loadButton";
			this.loadButton.Size = new System.Drawing.Size(36, 49);
			this.loadButton.Text = "Load";
			this.loadButton.Click += new System.EventHandler(this.openButton_Click);
			// 
			// settingsButton
			// 
			this.settingsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.Image")));
			this.settingsButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.settingsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.settingsButton.Name = "settingsButton";
			this.settingsButton.Size = new System.Drawing.Size(36, 49);
			this.settingsButton.Text = "Settings";
			this.settingsButton.Click += new System.EventHandler(this.openSettings);
			// 
			// saveButton
			// 
			this.saveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
			this.saveButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.saveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(36, 49);
			this.saveButton.Text = "Save";
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(36, 49);
			this.toolStripButton1.Text = "Link Loop";
			this.toolStripButton1.Click += new System.EventHandler(this.linkChecked);
			// 
			// unlinkButton
			// 
			this.unlinkButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.unlinkButton.Image = ((System.Drawing.Image)(resources.GetObject("unlinkButton.Image")));
			this.unlinkButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.unlinkButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.unlinkButton.Name = "unlinkButton";
			this.unlinkButton.Size = new System.Drawing.Size(36, 49);
			this.unlinkButton.Text = "Unlink loop";
			this.unlinkButton.Click += new System.EventHandler(this.unlinkChecked);
			// 
			// exportButton
			// 
			this.exportButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.exportButton.Image = ((System.Drawing.Image)(resources.GetObject("exportButton.Image")));
			this.exportButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.exportButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.exportButton.Name = "exportButton";
			this.exportButton.Size = new System.Drawing.Size(36, 49);
			this.exportButton.Text = "toolStripButton2";
			this.exportButton.Click += new System.EventHandler(this.export);
			// 
			// play
			// 
			this.play.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.play.Image = ((System.Drawing.Image)(resources.GetObject("play.Image")));
			this.play.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.play.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.play.Name = "play";
			this.play.Size = new System.Drawing.Size(36, 49);
			this.play.Text = "Play";
			this.play.Click += new System.EventHandler(this.runClick);
			// 
			// Stop
			// 
			this.Stop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.Stop.Image = ((System.Drawing.Image)(resources.GetObject("Stop.Image")));
			this.Stop.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.Stop.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Stop.Name = "Stop";
			this.Stop.Size = new System.Drawing.Size(36, 49);
			this.Stop.Text = "Stop";
			this.Stop.Visible = false;
			this.Stop.Click += new System.EventHandler(this.stopClick);
			// 
			// stepButton
			// 
			this.stepButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.stepButton.Image = ((System.Drawing.Image)(resources.GetObject("stepButton.Image")));
			this.stepButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.stepButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.stepButton.Name = "stepButton";
			this.stepButton.Size = new System.Drawing.Size(36, 49);
			this.stepButton.Text = "Step Through";
			this.stepButton.Click += new System.EventHandler(this.stepClick);
			// 
			// pauseButton
			// 
			this.pauseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.pauseButton.Image = ((System.Drawing.Image)(resources.GetObject("pauseButton.Image")));
			this.pauseButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.pauseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.pauseButton.Name = "pauseButton";
			this.pauseButton.Size = new System.Drawing.Size(36, 49);
			this.pauseButton.Text = "Pause";
			this.pauseButton.Click += new System.EventHandler(this.pauseClick);
			// 
			// scrollBar
			// 
			this.scrollBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.scrollBar.Location = new System.Drawing.Point(0, 52);
			this.scrollBar.Name = "scrollBar";
			this.scrollBar.Size = new System.Drawing.Size(19, 495);
			this.scrollBar.TabIndex = 6;
			this.scrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollBar_Scroll);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(7, 4);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Sprites";
			// 
			// amount
			// 
			this.amount.Location = new System.Drawing.Point(10, 21);
			this.amount.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
			this.amount.Name = "amount";
			this.amount.Size = new System.Drawing.Size(49, 20);
			this.amount.TabIndex = 1;
			this.amount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.amount);
			this.panel2.Location = new System.Drawing.Point(433, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(72, 46);
			this.panel2.TabIndex = 22;
			// 
			// statusBar
			// 
			this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLable});
			this.statusBar.Location = new System.Drawing.Point(0, 547);
			this.statusBar.Name = "statusBar";
			this.statusBar.Size = new System.Drawing.Size(1213, 28);
			this.statusBar.TabIndex = 24;
			this.statusBar.Text = "statusStrip1";
			// 
			// statusLable
			// 
			this.statusLable.BackColor = System.Drawing.SystemColors.Control;
			this.statusLable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.statusLable.Margin = new System.Windows.Forms.Padding(10, 3, 0, 4);
			this.statusLable.Name = "statusLable";
			this.statusLable.Size = new System.Drawing.Size(52, 21);
			this.statusLable.Text = "Status";
			// 
			// displayArea
			// 
			this.displayArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.displayArea.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.displayArea.Location = new System.Drawing.Point(283, 54);
			this.displayArea.Margin = new System.Windows.Forms.Padding(0);
			this.displayArea.Name = "displayArea";
			this.displayArea.Size = new System.Drawing.Size(928, 490);
			this.displayArea.TabIndex = 5;
			this.displayArea.Paint += new System.Windows.Forms.PaintEventHandler(this.display_Paint);
			// 
			// scrollPanel
			// 
			this.scrollPanel.BackColor = System.Drawing.Color.Gray;
			this.scrollPanel.Location = new System.Drawing.Point(23, 56);
			this.scrollPanel.Name = "scrollPanel";
			this.scrollPanel.Size = new System.Drawing.Size(257, 319);
			this.scrollPanel.TabIndex = 26;
			// 
			// PatternDesigner
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(1213, 575);
			this.Controls.Add(this.statusBar);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.scrollBar);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.displayArea);
			this.Controls.Add(this.scrollPanel);
			this.IsMdiContainer = true;
			this.Name = "PatternDesigner";
			this.Text = "Pattern Designer";
			this.Load += new System.EventHandler(this.PatternDesigner_Load);
			this.Shown += new System.EventHandler(this.PatternDesigner_Shown);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.amount)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.statusBar.ResumeLayout(false);
			this.statusBar.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton addActionButton;
        private System.Windows.Forms.ToolStripButton deleteActionButton;
        private System.Windows.Forms.ToolStripButton upButton;
        private System.Windows.Forms.ToolStripButton downButton;
        private System.Windows.Forms.ToolStripButton settingsButton;
        private System.Windows.Forms.ToolStripButton loadButton;
        private System.Windows.Forms.ToolStripButton saveButton;
        private System.Windows.Forms.ToolStripButton play;
		private System.Windows.Forms.VScrollBar scrollBar;
		private System.Windows.Forms.ToolStripButton Stop;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown amount;
		private System.Windows.Forms.Panel displayArea;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripButton unlinkButton;
		private System.Windows.Forms.ToolStripButton stepButton;
		private System.Windows.Forms.ToolStripButton pauseButton;
		private System.Windows.Forms.StatusStrip statusBar;
		private System.Windows.Forms.ToolStripStatusLabel statusLable;
		private System.Windows.Forms.ToolStripButton exportButton;
		private System.Windows.Forms.Panel scrollPanel;
	}
}

