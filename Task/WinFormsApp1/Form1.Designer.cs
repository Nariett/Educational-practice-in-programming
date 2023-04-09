namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.taskOneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskTwoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskThreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskFourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskFiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taskOneToolStripMenuItem,
            this.taskTwoToolStripMenuItem,
            this.taskThreeToolStripMenuItem,
            this.taskFourToolStripMenuItem,
            this.taskFiveToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // taskOneToolStripMenuItem
            // 
            this.taskOneToolStripMenuItem.Name = "taskOneToolStripMenuItem";
            this.taskOneToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.taskOneToolStripMenuItem.Text = "Task One";
            this.taskOneToolStripMenuItem.Click += new System.EventHandler(this.taskOneToolStripMenuItem_Click);
            // 
            // taskTwoToolStripMenuItem
            // 
            this.taskTwoToolStripMenuItem.Name = "taskTwoToolStripMenuItem";
            this.taskTwoToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.taskTwoToolStripMenuItem.Text = "Task Two";
            this.taskTwoToolStripMenuItem.Click += new System.EventHandler(this.taskTwoToolStripMenuItem_Click);
            // 
            // taskThreeToolStripMenuItem
            // 
            this.taskThreeToolStripMenuItem.Name = "taskThreeToolStripMenuItem";
            this.taskThreeToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.taskThreeToolStripMenuItem.Text = "Task Three";
            this.taskThreeToolStripMenuItem.Click += new System.EventHandler(this.taskThreeToolStripMenuItem_Click);
            // 
            // taskFourToolStripMenuItem
            // 
            this.taskFourToolStripMenuItem.Name = "taskFourToolStripMenuItem";
            this.taskFourToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.taskFourToolStripMenuItem.Text = "Task Four";
            this.taskFourToolStripMenuItem.Click += new System.EventHandler(this.taskFourToolStripMenuItem_Click);
            // 
            // taskFiveToolStripMenuItem
            // 
            this.taskFiveToolStripMenuItem.Name = "taskFiveToolStripMenuItem";
            this.taskFiveToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.taskFiveToolStripMenuItem.Text = "Task Five";
            this.taskFiveToolStripMenuItem.Click += new System.EventHandler(this.taskFiveToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem taskOneToolStripMenuItem;
        private ToolStripMenuItem taskTwoToolStripMenuItem;
        private ToolStripMenuItem taskThreeToolStripMenuItem;
        private ToolStripMenuItem taskFourToolStripMenuItem;
        private ToolStripMenuItem taskFiveToolStripMenuItem;
    }
}