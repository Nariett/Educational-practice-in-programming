namespace MainForm2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.taskOneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskTwoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskThreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskFourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taskOneToolStripMenuItem,
            this.taskTwoToolStripMenuItem,
            this.taskThreeToolStripMenuItem,
            this.taskFourToolStripMenuItem});
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Main Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem taskOneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taskTwoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taskThreeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taskFourToolStripMenuItem;
    }
}

