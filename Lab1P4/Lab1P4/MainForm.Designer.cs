namespace Lab1P4
{
    partial class MainForm
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
            menuStrip1 = new MenuStrip();
            FileToolStripMenuItem = new ToolStripMenuItem();
            CreateToolStripMenuItem = new ToolStripMenuItem();
            CreateObjectToolStripMenuItem = new ToolStripMenuItem();
            CreateDotToolStripMenuItem = new ToolStripMenuItem();
            CreateLineToolStripMenuItem = new ToolStripMenuItem();
            CreateRectangleToolStripMenuItem = new ToolStripMenuItem();
            CreateEllipseToolStripMenuItem = new ToolStripMenuItem();
            CreateStringToolStripMenuItem = new ToolStripMenuItem();
            ExitToolStripMenuItem = new ToolStripMenuItem();
            MainPictureBox = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MainPictureBox).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { FileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            FileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { CreateToolStripMenuItem, ExitToolStripMenuItem });
            FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            FileToolStripMenuItem.Size = new Size(48, 20);
            FileToolStripMenuItem.Text = "Файл";
            // 
            // CreateToolStripMenuItem
            // 
            CreateToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { CreateObjectToolStripMenuItem, CreateStringToolStripMenuItem });
            CreateToolStripMenuItem.Name = "CreateToolStripMenuItem";
            CreateToolStripMenuItem.Size = new Size(180, 22);
            CreateToolStripMenuItem.Text = "Создать";
            // 
            // CreateObjectToolStripMenuItem
            // 
            CreateObjectToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { CreateDotToolStripMenuItem, CreateLineToolStripMenuItem, CreateRectangleToolStripMenuItem, CreateEllipseToolStripMenuItem });
            CreateObjectToolStripMenuItem.Name = "CreateObjectToolStripMenuItem";
            CreateObjectToolStripMenuItem.Size = new Size(180, 22);
            CreateObjectToolStripMenuItem.Text = "Объект";
            // 
            // CreateDotToolStripMenuItem
            // 
            CreateDotToolStripMenuItem.Name = "CreateDotToolStripMenuItem";
            CreateDotToolStripMenuItem.Size = new Size(180, 22);
            CreateDotToolStripMenuItem.Text = "Точка";
            CreateDotToolStripMenuItem.Click += CreateDotToolStripMenuItem_Click;
            // 
            // CreateLineToolStripMenuItem
            // 
            CreateLineToolStripMenuItem.Name = "CreateLineToolStripMenuItem";
            CreateLineToolStripMenuItem.Size = new Size(180, 22);
            CreateLineToolStripMenuItem.Text = "Линия";
            CreateLineToolStripMenuItem.Click += CreateLineToolStripMenuItem_Click;
            // 
            // CreateRectangleToolStripMenuItem
            // 
            CreateRectangleToolStripMenuItem.Name = "CreateRectangleToolStripMenuItem";
            CreateRectangleToolStripMenuItem.Size = new Size(180, 22);
            CreateRectangleToolStripMenuItem.Text = "Прямоугольник";
            CreateRectangleToolStripMenuItem.Click += CreateRectangleToolStripMenuItem_Click;
            // 
            // CreateEllipseToolStripMenuItem
            // 
            CreateEllipseToolStripMenuItem.Name = "CreateEllipseToolStripMenuItem";
            CreateEllipseToolStripMenuItem.Size = new Size(180, 22);
            CreateEllipseToolStripMenuItem.Text = "Элипс";
            // 
            // CreateStringToolStripMenuItem
            // 
            CreateStringToolStripMenuItem.Name = "CreateStringToolStripMenuItem";
            CreateStringToolStripMenuItem.Size = new Size(180, 22);
            CreateStringToolStripMenuItem.Text = "Строку";
            // 
            // ExitToolStripMenuItem
            // 
            ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            ExitToolStripMenuItem.Size = new Size(180, 22);
            ExitToolStripMenuItem.Text = "Выход";
            // 
            // MainPictureBox
            // 
            MainPictureBox.Location = new Point(12, 27);
            MainPictureBox.Name = "MainPictureBox";
            MainPictureBox.Size = new Size(776, 411);
            MainPictureBox.TabIndex = 1;
            MainPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MainPictureBox);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MainPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem FileToolStripMenuItem;
        private ToolStripMenuItem CreateToolStripMenuItem;
        private ToolStripMenuItem ExitToolStripMenuItem;
        private ToolStripMenuItem CreateObjectToolStripMenuItem;
        private ToolStripMenuItem CreateStringToolStripMenuItem;
        private PictureBox MainPictureBox;
        private ToolStripMenuItem CreateDotToolStripMenuItem;
        private ToolStripMenuItem CreateLineToolStripMenuItem;
        private ToolStripMenuItem CreateRectangleToolStripMenuItem;
        private ToolStripMenuItem CreateEllipseToolStripMenuItem;
    }
}