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
            SetThicknessTo5MenuItem = new ToolStripMenuItem();
            SetThicknessTo10MenuItem = new ToolStripMenuItem();
            SetThicknessTo15MenuItem = new ToolStripMenuItem();
            BackgroundColorToolStripMenuItem = new ToolStripMenuItem();
            LineColorToolStripMenuItem = new ToolStripMenuItem();
            ColorDialog = new ColorDialog();
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
            RectangleMenuStrip.Items.AddRange(new ToolStripItem[] { типЛинииToolStripMenuItem, толщинаToolStripMenuItem, BackgroundColorToolStripMenuItem, LineColorToolStripMenuItem });
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
            SolidLineToolStripMenuItem.Size = new Size(190, 26);
            SolidLineToolStripMenuItem.Text = "Непрерывная";
            SolidLineToolStripMenuItem.Click += SolidLineToolStripMenuItem_Click;
            // 
            // DottedLineToolStripMenuItem
            // 
            DottedLineToolStripMenuItem.Name = "DottedLineToolStripMenuItem";
            DottedLineToolStripMenuItem.Size = new Size(190, 26);
            DottedLineToolStripMenuItem.Text = "Пунктирная";
            DottedLineToolStripMenuItem.Click += DottedLineToolStripMenuItem_Click;
            // 
            // толщинаToolStripMenuItem
            // 
            толщинаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { SetThicknessTo5MenuItem, SetThicknessTo10MenuItem, SetThicknessTo15MenuItem });
            толщинаToolStripMenuItem.Name = "толщинаToolStripMenuItem";
            толщинаToolStripMenuItem.Size = new Size(222, 24);
            толщинаToolStripMenuItem.Text = "Толщина";
            // 
            // SetThicknessTo5MenuItem
            // 
            SetThicknessTo5MenuItem.Name = "SetThicknessTo5MenuItem";
            SetThicknessTo5MenuItem.Size = new Size(108, 26);
            SetThicknessTo5MenuItem.Text = "5";
            SetThicknessTo5MenuItem.Click += SetThicknessTo5MenuItem_Click;
            // 
            // SetThicknessTo10MenuItem
            // 
            SetThicknessTo10MenuItem.Name = "SetThicknessTo10MenuItem";
            SetThicknessTo10MenuItem.Size = new Size(108, 26);
            SetThicknessTo10MenuItem.Text = "10";
            SetThicknessTo10MenuItem.Click += SetThicknessTo10MenuItem_Click;
            // 
            // SetThicknessTo15MenuItem
            // 
            SetThicknessTo15MenuItem.Name = "SetThicknessTo15MenuItem";
            SetThicknessTo15MenuItem.Size = new Size(108, 26);
            SetThicknessTo15MenuItem.Text = "15";
            SetThicknessTo15MenuItem.Click += SetThicknessTo15MenuItem_Click;
            // 
            // BackgroundColorToolStripMenuItem
            // 
            BackgroundColorToolStripMenuItem.Name = "BackgroundColorToolStripMenuItem";
            BackgroundColorToolStripMenuItem.Size = new Size(222, 24);
            BackgroundColorToolStripMenuItem.Text = "Цвет фона";
            BackgroundColorToolStripMenuItem.Click += BackgroundColorToolStripMenuItem_Click;
            // 
            // LineColorToolStripMenuItem
            // 
            LineColorToolStripMenuItem.Name = "LineColorToolStripMenuItem";
            LineColorToolStripMenuItem.Size = new Size(222, 24);
            LineColorToolStripMenuItem.Text = "Цвет линии обводки";
            LineColorToolStripMenuItem.Click += LineColorToolStripMenuItem_Click;
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
        private ToolStripMenuItem BackgroundColorToolStripMenuItem;
        private ToolStripMenuItem LineColorToolStripMenuItem;
        private ToolStripMenuItem SolidLineToolStripMenuItem;
        private ToolStripMenuItem DottedLineToolStripMenuItem;
        private ToolStripMenuItem SetThicknessTo5MenuItem;
        private ToolStripMenuItem SetThicknessTo10MenuItem;
        private ToolStripMenuItem SetThicknessTo15MenuItem;
        private ColorDialog ColorDialog;
    }
}