namespace Jordans_Game
{
    partial class Form1
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.GamePanel = new System.Windows.Forms.Panel();
            this.BoardPanel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MainPanel.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.GamePanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.AutoSize = true;
            this.MainPanel.Controls.Add(this.MenuPanel);
            this.MainPanel.Controls.Add(this.GamePanel);
            this.MainPanel.Controls.Add(this.menuStrip1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(584, 561);
            this.MainPanel.TabIndex = 0;
            // 
            // MenuPanel
            // 
            this.MenuPanel.Controls.Add(this.button1);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuPanel.Location = new System.Drawing.Point(0, 24);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(584, 537);
            this.MenuPanel.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start Game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GamePanel
            // 
            this.GamePanel.AutoSize = true;
            this.GamePanel.Controls.Add(this.BoardPanel);
            this.GamePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GamePanel.Location = new System.Drawing.Point(0, 24);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(584, 537);
            this.GamePanel.TabIndex = 0;
            // 
            // BoardPanel
            // 
            this.BoardPanel.AutoSize = true;
            this.BoardPanel.Location = new System.Drawing.Point(90,0);
            this.BoardPanel.Name = "BoardPanel";
            this.BoardPanel.Size = new System.Drawing.Size(480, 480);
            this.BoardPanel.TabIndex = 1;
            this.BoardPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.BoardPanel_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(125, 20);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.MainPanel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Jordan\'s Game";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.MenuPanel.ResumeLayout(false);
            this.GamePanel.ResumeLayout(false);
            this.GamePanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Panel GamePanel;
        private System.Windows.Forms.Panel BoardPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button button1;
    }
}

