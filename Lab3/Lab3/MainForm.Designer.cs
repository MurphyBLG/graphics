namespace Lab3
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
            splitContainer1 = new SplitContainer();
            LineByLineFillingButton = new Button();
            SeedFillingButton = new Button();
            PickColorButton = new Button();
            RefreshButton = new Button();
            MainPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MainPictureBox).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(LineByLineFillingButton);
            splitContainer1.Panel1.Controls.Add(SeedFillingButton);
            splitContainer1.Panel1.Controls.Add(PickColorButton);
            splitContainer1.Panel1.Controls.Add(RefreshButton);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(MainPictureBox);
            splitContainer1.Size = new Size(1264, 681);
            splitContainer1.SplitterDistance = 245;
            splitContainer1.TabIndex = 0;
            // 
            // LineByLineFillingButton
            // 
            LineByLineFillingButton.Location = new Point(12, 199);
            LineByLineFillingButton.Name = "LineByLineFillingButton";
            LineByLineFillingButton.Size = new Size(221, 42);
            LineByLineFillingButton.TabIndex = 2;
            LineByLineFillingButton.Text = "Построчная заливка";
            LineByLineFillingButton.UseVisualStyleBackColor = true;
            LineByLineFillingButton.Click += LineByLineFillingButton_Click;
            // 
            // SeedFillingButton
            // 
            SeedFillingButton.Location = new Point(12, 144);
            SeedFillingButton.Name = "SeedFillingButton";
            SeedFillingButton.Size = new Size(221, 49);
            SeedFillingButton.TabIndex = 1;
            SeedFillingButton.Text = "Заливка с затравкой";
            SeedFillingButton.UseVisualStyleBackColor = true;
            SeedFillingButton.Click += SeedFillingButton_Click;
            // 
            // PickColorButton
            // 
            PickColorButton.Location = new Point(12, 74);
            PickColorButton.Name = "PickColorButton";
            PickColorButton.Size = new Size(221, 64);
            PickColorButton.TabIndex = 1;
            PickColorButton.Text = "Выбрать цвет";
            PickColorButton.UseVisualStyleBackColor = true;
            PickColorButton.Click += PickColorButton_Click;
            // 
            // RefreshButton
            // 
            RefreshButton.Location = new Point(12, 12);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(221, 56);
            RefreshButton.TabIndex = 0;
            RefreshButton.Text = "Перерисовать фигуру";
            RefreshButton.UseVisualStyleBackColor = true;
            RefreshButton.Click += RefreshButton_Click;
            // 
            // MainPictureBox
            // 
            MainPictureBox.Location = new Point(3, 3);
            MainPictureBox.Name = "MainPictureBox";
            MainPictureBox.Size = new Size(1008, 675);
            MainPictureBox.TabIndex = 0;
            MainPictureBox.TabStop = false;
            MainPictureBox.MouseClick += MainPictureBox_MouseClick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(splitContainer1);
            Name = "MainForm";
            Text = "Рявкин В КЭ-403 Алгоритмы закраски замкнутых поверхностей";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MainPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private PictureBox MainPictureBox;
        private Button RefreshButton;
        private Button PickColorButton;
        private Button SeedFillingButton;
        private Button LineByLineFillingButton;
    }
}