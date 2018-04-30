namespace MatrixSolver
{
    partial class uxMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uxMainMenu));
            this.uxMainMenu_ToolBar = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scalerMultiplicationCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxMainMenu_Display = new System.Windows.Forms.Panel();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxMainMenu_ToolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxMainMenu_ToolBar
            // 
            this.uxMainMenu_ToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.uxMainMenu_ToolBar.Location = new System.Drawing.Point(0, 0);
            this.uxMainMenu_ToolBar.Name = "uxMainMenu_ToolBar";
            this.uxMainMenu_ToolBar.Size = new System.Drawing.Size(784, 24);
            this.uxMainMenu_ToolBar.TabIndex = 0;
            this.uxMainMenu_ToolBar.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scalerMultiplicationCalculatorToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // scalerMultiplicationCalculatorToolStripMenuItem
            // 
            this.scalerMultiplicationCalculatorToolStripMenuItem.Name = "scalerMultiplicationCalculatorToolStripMenuItem";
            this.scalerMultiplicationCalculatorToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.scalerMultiplicationCalculatorToolStripMenuItem.Text = "Scaler Multiplication Calculator";
            this.scalerMultiplicationCalculatorToolStripMenuItem.Click += new System.EventHandler(this.ScalerMult_ToolStripMenuItem_Click);
            // 
            // uxMainMenu_Display
            // 
            this.uxMainMenu_Display.BackColor = System.Drawing.SystemColors.ControlDark;
            this.uxMainMenu_Display.Location = new System.Drawing.Point(12, 38);
            this.uxMainMenu_Display.Name = "uxMainMenu_Display";
            this.uxMainMenu_Display.Size = new System.Drawing.Size(760, 510);
            this.uxMainMenu_Display.TabIndex = 1;
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // uxMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.uxMainMenu_Display);
            this.Controls.Add(this.uxMainMenu_ToolBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.uxMainMenu_ToolBar;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "uxMainMenu";
            this.Text = "Matrix Solver";
            this.uxMainMenu_ToolBar.ResumeLayout(false);
            this.uxMainMenu_ToolBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip uxMainMenu_ToolBar;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.Panel uxMainMenu_Display;
        private System.Windows.Forms.ToolStripMenuItem scalerMultiplicationCalculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
    }
}

