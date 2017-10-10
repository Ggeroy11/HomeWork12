namespace DragAndDrop1
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
            this.TopLevelMenuTextbox = new System.Windows.Forms.TextBox();
            this.SubItemTextBox = new System.Windows.Forms.TextBox();
            this.TopLevelMenu = new System.Windows.Forms.Button();
            this.SubItem = new System.Windows.Forms.Button();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopLevelMenuTextbox
            // 
            this.TopLevelMenuTextbox.Location = new System.Drawing.Point(146, 81);
            this.TopLevelMenuTextbox.Name = "TopLevelMenuTextbox";
            this.TopLevelMenuTextbox.Size = new System.Drawing.Size(100, 20);
            this.TopLevelMenuTextbox.TabIndex = 0;
            // 
            // SubItemTextBox
            // 
            this.SubItemTextBox.Location = new System.Drawing.Point(146, 118);
            this.SubItemTextBox.Name = "SubItemTextBox";
            this.SubItemTextBox.Size = new System.Drawing.Size(100, 20);
            this.SubItemTextBox.TabIndex = 1;
            // 
            // TopLevelMenu
            // 
            this.TopLevelMenu.Location = new System.Drawing.Point(36, 81);
            this.TopLevelMenu.Name = "TopLevelMenu";
            this.TopLevelMenu.Size = new System.Drawing.Size(75, 23);
            this.TopLevelMenu.TabIndex = 2;
            this.TopLevelMenu.Text = "TopLevelMenu";
            this.TopLevelMenu.UseVisualStyleBackColor = true;
            this.TopLevelMenu.Click += new System.EventHandler(this.TopLevelMenu_Click);
            // 
            // SubItem
            // 
            this.SubItem.Location = new System.Drawing.Point(36, 115);
            this.SubItem.Name = "SubItem";
            this.SubItem.Size = new System.Drawing.Size(75, 23);
            this.SubItem.TabIndex = 3;
            this.SubItem.Text = "Sub item";
            this.SubItem.UseVisualStyleBackColor = true;
            this.SubItem.Click += new System.EventHandler(this.SubItem_Click);
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(284, 24);
            this.MenuStrip.TabIndex = 4;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "file";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.helpToolStripMenuItem.Text = "help";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.SubItem);
            this.Controls.Add(this.TopLevelMenu);
            this.Controls.Add(this.SubItemTextBox);
            this.Controls.Add(this.TopLevelMenuTextbox);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TopLevelMenuTextbox;
        private System.Windows.Forms.TextBox SubItemTextBox;
        private System.Windows.Forms.Button TopLevelMenu;
        private System.Windows.Forms.Button SubItem;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}

