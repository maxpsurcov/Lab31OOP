namespace Lab31OOP
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
            this.exportProcessListButton = new System.Windows.Forms.Button();
            this.processContextMenuStrip = new System.Windows.Forms.MenuStrip();
            this.modulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.threadsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processList = new System.Windows.Forms.ListBox();
            this.stopProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // exportProcessListButton
            // 
            this.exportProcessListButton.Location = new System.Drawing.Point(569, 428);
            this.exportProcessListButton.Name = "exportProcessListButton";
            this.exportProcessListButton.Size = new System.Drawing.Size(252, 89);
            this.exportProcessListButton.TabIndex = 1;
            this.exportProcessListButton.Text = "exportProcess";
            this.exportProcessListButton.UseVisualStyleBackColor = true;
            // 
            // processContextMenuStrip
            // 
            this.processContextMenuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.processContextMenuStrip.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.processContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modulesToolStripMenuItem,
            this.threadsToolStripMenuItem,
            this.stopProcessToolStripMenuItem});
            this.processContextMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.processContextMenuStrip.Name = "processContextMenuStrip";
            this.processContextMenuStrip.Size = new System.Drawing.Size(950, 42);
            this.processContextMenuStrip.TabIndex = 2;
            this.processContextMenuStrip.Text = "menuStrip1";
            // 
            // modulesToolStripMenuItem
            // 
            this.modulesToolStripMenuItem.Name = "modulesToolStripMenuItem";
            this.modulesToolStripMenuItem.Size = new System.Drawing.Size(148, 34);
            this.modulesToolStripMenuItem.Text = "modulesTool";
            this.modulesToolStripMenuItem.Click += new System.EventHandler(this.modulesToolStripMenuItem_Click);
            // 
            // threadsToolStripMenuItem
            // 
            this.threadsToolStripMenuItem.Name = "threadsToolStripMenuItem";
            this.threadsToolStripMenuItem.Size = new System.Drawing.Size(138, 34);
            this.threadsToolStripMenuItem.Text = "threadsTool";
            this.threadsToolStripMenuItem.Click += new System.EventHandler(this.threadsToolStripMenuItem_Click);
            // 
            // processList
            // 
            this.processList.FormattingEnabled = true;
            this.processList.ItemHeight = 24;
            this.processList.Location = new System.Drawing.Point(30, 80);
            this.processList.Name = "processList";
            this.processList.Size = new System.Drawing.Size(471, 460);
            this.processList.TabIndex = 3;
            // 
            // stopProcessToolStripMenuItem
            // 
            this.stopProcessToolStripMenuItem.Name = "stopProcessToolStripMenuItem";
            this.stopProcessToolStripMenuItem.Size = new System.Drawing.Size(141, 34);
            this.stopProcessToolStripMenuItem.Text = "stopProcess";
            this.stopProcessToolStripMenuItem.Click += new System.EventHandler(this.stopProcessToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 694);
            this.Controls.Add(this.processList);
            this.Controls.Add(this.exportProcessListButton);
            this.Controls.Add(this.processContextMenuStrip);
            this.MainMenuStrip = this.processContextMenuStrip;
            this.Name = "Form1";
            this.Text = "Form1";
            this.processContextMenuStrip.ResumeLayout(false);
            this.processContextMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button exportProcessListButton;
        private System.Windows.Forms.MenuStrip processContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem modulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem threadsToolStripMenuItem;
        private System.Windows.Forms.ListBox processList;
        private System.Windows.Forms.ToolStripMenuItem stopProcessToolStripMenuItem;
    }
}

