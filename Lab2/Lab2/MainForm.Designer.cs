namespace Lab2
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
            ControlsGroupBox = new GroupBox();
            CoefficientYTextBox = new TextBox();
            CoefficientYLabel = new Label();
            ApplyStretching = new Button();
            ApplyRotation = new Button();
            ApplyMove = new Button();
            CoefficientXTextBox = new TextBox();
            CoefficientXLabel = new Label();
            StretchLabel = new Label();
            AngleTextBox = new TextBox();
            AngleLabel = new Label();
            RotationLabel = new Label();
            YCordTextBox = new TextBox();
            XCordTextBox = new TextBox();
            YCordLabel = new Label();
            XCordLabel = new Label();
            MoveLabel = new Label();
            CreateObjectButton = new Button();
            PaintGroupBox = new GroupBox();
            ZeroZeroLabel = new Label();
            YLabel = new Label();
            XLabel = new Label();
            MainPictureBox = new PictureBox();
            ControlsGroupBox.SuspendLayout();
            PaintGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MainPictureBox).BeginInit();
            SuspendLayout();
            // 
            // ControlsGroupBox
            // 
            ControlsGroupBox.Controls.Add(CoefficientYTextBox);
            ControlsGroupBox.Controls.Add(CoefficientYLabel);
            ControlsGroupBox.Controls.Add(ApplyStretching);
            ControlsGroupBox.Controls.Add(ApplyRotation);
            ControlsGroupBox.Controls.Add(ApplyMove);
            ControlsGroupBox.Controls.Add(CoefficientXTextBox);
            ControlsGroupBox.Controls.Add(CoefficientXLabel);
            ControlsGroupBox.Controls.Add(StretchLabel);
            ControlsGroupBox.Controls.Add(AngleTextBox);
            ControlsGroupBox.Controls.Add(AngleLabel);
            ControlsGroupBox.Controls.Add(RotationLabel);
            ControlsGroupBox.Controls.Add(YCordTextBox);
            ControlsGroupBox.Controls.Add(XCordTextBox);
            ControlsGroupBox.Controls.Add(YCordLabel);
            ControlsGroupBox.Controls.Add(XCordLabel);
            ControlsGroupBox.Controls.Add(MoveLabel);
            ControlsGroupBox.Controls.Add(CreateObjectButton);
            ControlsGroupBox.Location = new Point(12, 12);
            ControlsGroupBox.Name = "ControlsGroupBox";
            ControlsGroupBox.Size = new Size(210, 507);
            ControlsGroupBox.TabIndex = 0;
            ControlsGroupBox.TabStop = false;
            // 
            // CoefficientYTextBox
            // 
            CoefficientYTextBox.Location = new Point(136, 374);
            CoefficientYTextBox.Name = "CoefficientYTextBox";
            CoefficientYTextBox.Size = new Size(55, 23);
            CoefficientYTextBox.TabIndex = 16;
            // 
            // CoefficientYLabel
            // 
            CoefficientYLabel.AutoSize = true;
            CoefficientYLabel.Location = new Point(13, 377);
            CoefficientYLabel.Name = "CoefficientYLabel";
            CoefficientYLabel.Size = new Size(114, 15);
            CoefficientYLabel.TabIndex = 15;
            CoefficientYLabel.Text = "Коэффициент по Y:";
            // 
            // ApplyStretching
            // 
            ApplyStretching.Location = new Point(6, 426);
            ApplyStretching.Name = "ApplyStretching";
            ApplyStretching.Size = new Size(198, 26);
            ApplyStretching.TabIndex = 14;
            ApplyStretching.Text = "Применить";
            ApplyStretching.UseVisualStyleBackColor = true;
            ApplyStretching.Click += ApplyStretching_Click;
            // 
            // ApplyRotation
            // 
            ApplyRotation.Location = new Point(6, 263);
            ApplyRotation.Name = "ApplyRotation";
            ApplyRotation.Size = new Size(198, 30);
            ApplyRotation.TabIndex = 13;
            ApplyRotation.Text = "Применить";
            ApplyRotation.UseVisualStyleBackColor = true;
            ApplyRotation.Click += ApplyRotation_Click;
            // 
            // ApplyMove
            // 
            ApplyMove.Location = new Point(6, 160);
            ApplyMove.Name = "ApplyMove";
            ApplyMove.Size = new Size(198, 30);
            ApplyMove.TabIndex = 12;
            ApplyMove.Text = "Применить";
            ApplyMove.UseVisualStyleBackColor = true;
            ApplyMove.Click += ApplyMove_Click;
            // 
            // CoefficientXTextBox
            // 
            CoefficientXTextBox.Location = new Point(136, 340);
            CoefficientXTextBox.Name = "CoefficientXTextBox";
            CoefficientXTextBox.Size = new Size(55, 23);
            CoefficientXTextBox.TabIndex = 11;
            // 
            // CoefficientXLabel
            // 
            CoefficientXLabel.AutoSize = true;
            CoefficientXLabel.Location = new Point(13, 343);
            CoefficientXLabel.Name = "CoefficientXLabel";
            CoefficientXLabel.Size = new Size(117, 15);
            CoefficientXLabel.TabIndex = 10;
            CoefficientXLabel.Text = "Коэффициент по X: ";
            // 
            // StretchLabel
            // 
            StretchLabel.AutoSize = true;
            StretchLabel.Location = new Point(80, 311);
            StretchLabel.Name = "StretchLabel";
            StretchLabel.Size = new Size(72, 15);
            StretchLabel.TabIndex = 9;
            StretchLabel.Text = "Растяжение";
            // 
            // AngleTextBox
            // 
            AngleTextBox.Location = new Point(51, 229);
            AngleTextBox.Name = "AngleTextBox";
            AngleTextBox.Size = new Size(153, 23);
            AngleTextBox.TabIndex = 8;
            // 
            // AngleLabel
            // 
            AngleLabel.AutoSize = true;
            AngleLabel.Location = new Point(10, 232);
            AngleLabel.Name = "AngleLabel";
            AngleLabel.Size = new Size(39, 15);
            AngleLabel.TabIndex = 7;
            AngleLabel.Text = "Угол: ";
            // 
            // RotationLabel
            // 
            RotationLabel.AutoSize = true;
            RotationLabel.Location = new Point(84, 202);
            RotationLabel.Name = "RotationLabel";
            RotationLabel.Size = new Size(55, 15);
            RotationLabel.TabIndex = 6;
            RotationLabel.Text = "Поворот";
            // 
            // YCordTextBox
            // 
            YCordTextBox.Location = new Point(38, 132);
            YCordTextBox.Name = "YCordTextBox";
            YCordTextBox.Size = new Size(166, 23);
            YCordTextBox.TabIndex = 5;
            // 
            // XCordTextBox
            // 
            XCordTextBox.Location = new Point(38, 102);
            XCordTextBox.Name = "XCordTextBox";
            XCordTextBox.Size = new Size(166, 23);
            XCordTextBox.TabIndex = 4;
            // 
            // YCordLabel
            // 
            YCordLabel.AutoSize = true;
            YCordLabel.Location = new Point(11, 135);
            YCordLabel.Name = "YCordLabel";
            YCordLabel.Size = new Size(20, 15);
            YCordLabel.TabIndex = 3;
            YCordLabel.Text = "Y: ";
            // 
            // XCordLabel
            // 
            XCordLabel.AutoSize = true;
            XCordLabel.Location = new Point(12, 105);
            XCordLabel.Name = "XCordLabel";
            XCordLabel.Size = new Size(20, 15);
            XCordLabel.TabIndex = 2;
            XCordLabel.Text = "X: ";
            // 
            // MoveLabel
            // 
            MoveLabel.AutoSize = true;
            MoveLabel.Location = new Point(65, 69);
            MoveLabel.Name = "MoveLabel";
            MoveLabel.Size = new Size(87, 15);
            MoveLabel.TabIndex = 1;
            MoveLabel.Text = "Перемещение";
            // 
            // CreateObjectButton
            // 
            CreateObjectButton.Location = new Point(6, 22);
            CreateObjectButton.Name = "CreateObjectButton";
            CreateObjectButton.Size = new Size(198, 34);
            CreateObjectButton.TabIndex = 0;
            CreateObjectButton.Text = "Создать объект";
            CreateObjectButton.UseVisualStyleBackColor = true;
            CreateObjectButton.Click += CreateObjectButton_Click;
            // 
            // PaintGroupBox
            // 
            PaintGroupBox.Controls.Add(ZeroZeroLabel);
            PaintGroupBox.Controls.Add(YLabel);
            PaintGroupBox.Controls.Add(XLabel);
            PaintGroupBox.Controls.Add(MainPictureBox);
            PaintGroupBox.Location = new Point(228, 12);
            PaintGroupBox.Name = "PaintGroupBox";
            PaintGroupBox.Size = new Size(560, 507);
            PaintGroupBox.TabIndex = 1;
            PaintGroupBox.TabStop = false;
            // 
            // ZeroZeroLabel
            // 
            ZeroZeroLabel.AutoSize = true;
            ZeroZeroLabel.Location = new Point(11, 22);
            ZeroZeroLabel.Name = "ZeroZeroLabel";
            ZeroZeroLabel.Size = new Size(22, 15);
            ZeroZeroLabel.TabIndex = 3;
            ZeroZeroLabel.Text = "0,0";
            // 
            // YLabel
            // 
            YLabel.AutoSize = true;
            YLabel.Location = new Point(10, 474);
            YLabel.Name = "YLabel";
            YLabel.Size = new Size(14, 15);
            YLabel.TabIndex = 2;
            YLabel.Text = "Y";
            // 
            // XLabel
            // 
            XLabel.AutoSize = true;
            XLabel.Location = new Point(498, 19);
            XLabel.Name = "XLabel";
            XLabel.Size = new Size(14, 15);
            XLabel.TabIndex = 1;
            XLabel.Text = "X";
            // 
            // MainPictureBox
            // 
            MainPictureBox.BorderStyle = BorderStyle.FixedSingle;
            MainPictureBox.Location = new Point(27, 37);
            MainPictureBox.Name = "MainPictureBox";
            MainPictureBox.Size = new Size(527, 464);
            MainPictureBox.TabIndex = 0;
            MainPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 531);
            Controls.Add(PaintGroupBox);
            Controls.Add(ControlsGroupBox);
            Name = "MainForm";
            Text = "Аффинные преобразования";
            ControlsGroupBox.ResumeLayout(false);
            ControlsGroupBox.PerformLayout();
            PaintGroupBox.ResumeLayout(false);
            PaintGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MainPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox ControlsGroupBox;
        private GroupBox PaintGroupBox;
        private Button CreateObjectButton;
        private Label MoveLabel;
        private Label YCordLabel;
        private Label XCordLabel;
        private TextBox XCordTextBox;
        private TextBox YCordTextBox;
        private Label AngleLabel;
        private Label RotationLabel;
        private TextBox AngleTextBox;
        private TextBox CoefficientXTextBox;
        private Label CoefficientXLabel;
        private Label StretchLabel;
        private Button ApplyRotation;
        private Button ApplyMove;
        private Button ApplyStretching;
        private PictureBox MainPictureBox;
        private Label CoefficientYLabel;
        private TextBox CoefficientYTextBox;
        private Label XLabel;
        private Label YLabel;
        private Label ZeroZeroLabel;
    }
}