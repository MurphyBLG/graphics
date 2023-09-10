namespace Lab1P3
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            RectangleMenuStrip = new ContextMenuStrip(components);
            типЛинииToolStripMenuItem = new ToolStripMenuItem();
            SolidLineToolStripMenuItem = new ToolStripMenuItem();
            DottedLineToolStripMenuItem = new ToolStripMenuItem();
            толщинаToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            цветФонаToolStripMenuItem = new ToolStripMenuItem();
            цветЛинииОбводкиToolStripMenuItem = new ToolStripMenuItem();
            RectangleMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(6, 1);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(910, 593);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            panel1.MouseClick += panel1_MouseClick;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // RectangleMenuStrip
            // 
            RectangleMenuStrip.ImageScalingSize = new Size(20, 20);
            RectangleMenuStrip.Items.AddRange(new ToolStripItem[] { типЛинииToolStripMenuItem, толщинаToolStripMenuItem, цветФонаToolStripMenuItem, цветЛинииОбводкиToolStripMenuItem });
            RectangleMenuStrip.Name = "contextMenuStrip1";
            RectangleMenuStrip.Size = new Size(223, 128);
            // 
            // типЛинииToolStripMenuItem
            // 
            типЛинииToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { SolidLineToolStripMenuItem, DottedLineToolStripMenuItem });
            типЛинииToolStripMenuItem.Name = "типЛинииToolStripMenuItem";
            типЛинииToolStripMenuItem.Size = new Size(222, 24);
            типЛинииToolStripMenuItem.Text = "Тип линии";
            // 
            // SolidLineToolStripMenuItem
            // 
            SolidLineToolStripMenuItem.Name = "SolidLineToolStripMenuItem";
            SolidLineToolStripMenuItem.Size = new Size(224, 26);
            SolidLineToolStripMenuItem.Text = "Непрерывная";
            SolidLineToolStripMenuItem.Click += SolidLineToolStripMenuItem_Click;
            // 
            // DottedLineToolStripMenuItem
            // 
            DottedLineToolStripMenuItem.Name = "DottedLineToolStripMenuItem";
            DottedLineToolStripMenuItem.Size = new Size(224, 26);
            DottedLineToolStripMenuItem.Text = "Пунктирная";
            DottedLineToolStripMenuItem.Click += DottedLineToolStripMenuItem_Click;
            // 
            // толщинаToolStripMenuItem
            // 
            толщинаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2, toolStripMenuItem3, toolStripMenuItem4 });
            толщинаToolStripMenuItem.Name = "толщинаToolStripMenuItem";
            толщинаToolStripMenuItem.Size = new Size(222, 24);
            толщинаToolStripMenuItem.Text = "Толщина";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(224, 26);
            toolStripMenuItem2.Text = "5";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(224, 26);
            toolStripMenuItem3.Text = "10";
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(224, 26);
            toolStripMenuItem4.Text = "15";
            // 
            // цветФонаToolStripMenuItem
            // 
            цветФонаToolStripMenuItem.Name = "цветФонаToolStripMenuItem";
            цветФонаToolStripMenuItem.Size = new Size(222, 24);
            цветФонаToolStripMenuItem.Text = "Цвет фона";
            // 
            // цветЛинииОбводкиToolStripMenuItem
            // 
            цветЛинииОбводкиToolStripMenuItem.Name = "цветЛинииОбводкиToolStripMenuItem";
            цветЛинииОбводкиToolStripMenuItem.Size = new Size(222, 24);
            цветЛинииОбводкиToolStripMenuItem.Text = "Цвет линии обводки";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            RectangleMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ContextMenuStrip RectangleMenuStrip;
        private ToolStripMenuItem типЛинииToolStripMenuItem;
        private ToolStripMenuItem толщинаToolStripMenuItem;
        private ToolStripMenuItem цветФонаToolStripMenuItem;
        private ToolStripMenuItem цветЛинииОбводкиToolStripMenuItem;
        private ToolStripMenuItem SolidLineToolStripMenuItem;
        private ToolStripMenuItem DottedLineToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
    }
}