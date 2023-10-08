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
            ApplyStretching = new Button();
            ApplyRotation = new Button();
            ApplyMove = new Button();
            CoefficientTextBox = new TextBox();
            CoefficientLabel = new Label();
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
            MainPictureBox = new PictureBox();
            ControlsGroupBox.SuspendLayout();
            PaintGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MainPictureBox).BeginInit();
            SuspendLayout();
            // 
            // ControlsGroupBox
            // 
            ControlsGroupBox.Controls.Add(ApplyStretching);
            ControlsGroupBox.Controls.Add(ApplyRotation);
            ControlsGroupBox.Controls.Add(ApplyMove);
            ControlsGroupBox.Controls.Add(CoefficientTextBox);
            ControlsGroupBox.Controls.Add(CoefficientLabel);
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
            ControlsGroupBox.Size = new Size(170, 426);
            ControlsGroupBox.TabIndex = 0;
            ControlsGroupBox.TabStop = false;
            // 
            // ApplyStretching
            // 
            ApplyStretching.Location = new Point(6, 380);
            ApplyStretching.Name = "ApplyStretching";
            ApplyStretching.Size = new Size(158, 26);
            ApplyStretching.TabIndex = 14;
            ApplyStretching.Text = "Применить";
            ApplyStretching.UseVisualStyleBackColor = true;
            ApplyStretching.Click += ApplyStretching_Click;
            // 
            // ApplyRotation
            // 
            ApplyRotation.Location = new Point(6, 263);
            ApplyRotation.Name = "ApplyRotation";
            ApplyRotation.Size = new Size(158, 30);
            ApplyRotation.TabIndex = 13;
            ApplyRotation.Text = "Применить";
            ApplyRotation.UseVisualStyleBackColor = true;
            ApplyRotation.Click += ApplyRotation_Click;
            // 
            // ApplyMove
            // 
            ApplyMove.Location = new Point(6, 160);
            ApplyMove.Name = "ApplyMove";
            ApplyMove.Size = new Size(158, 30);
            ApplyMove.TabIndex = 12;
            ApplyMove.Text = "Применить";
            ApplyMove.UseVisualStyleBackColor = true;
            ApplyMove.Click += ApplyMove_Click;
            // 
            // CoefficientTextBox
            // 
            CoefficientTextBox.Location = new Point(108, 340);
            CoefficientTextBox.Name = "CoefficientTextBox";
            CoefficientTextBox.Size = new Size(55, 23);
            CoefficientTextBox.TabIndex = 11;
            // 
            // CoefficientLabel
            // 
            CoefficientLabel.AutoSize = true;
            CoefficientLabel.Location = new Point(13, 343);
            CoefficientLabel.Name = "CoefficientLabel";
            CoefficientLabel.Size = new Size(90, 15);
            CoefficientLabel.TabIndex = 10;
            CoefficientLabel.Text = "Коэффициент: ";
            // 
            // StretchLabel
            // 
            StretchLabel.AutoSize = true;
            StretchLabel.Location = new Point(55, 311);
            StretchLabel.Name = "StretchLabel";
            StretchLabel.Size = new Size(72, 15);
            StretchLabel.TabIndex = 9;
            StretchLabel.Text = "Растяжение";
            // 
            // AngleTextBox
            // 
            AngleTextBox.Location = new Point(51, 229);
            AngleTextBox.Name = "AngleTextBox";
            AngleTextBox.Size = new Size(110, 23);
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
            RotationLabel.Location = new Point(55, 201);
            RotationLabel.Name = "RotationLabel";
            RotationLabel.Size = new Size(55, 15);
            RotationLabel.TabIndex = 6;
            RotationLabel.Text = "Поворот";
            // 
            // YCordTextBox
            // 
            YCordTextBox.Location = new Point(38, 131);
            YCordTextBox.Name = "YCordTextBox";
            YCordTextBox.Size = new Size(126, 23);
            YCordTextBox.TabIndex = 5;
            // 
            // XCordTextBox
            // 
            XCordTextBox.Location = new Point(38, 102);
            XCordTextBox.Name = "XCordTextBox";
            XCordTextBox.Size = new Size(126, 23);
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
            MoveLabel.Location = new Point(40, 71);
            MoveLabel.Name = "MoveLabel";
            MoveLabel.Size = new Size(87, 15);
            MoveLabel.TabIndex = 1;
            MoveLabel.Text = "Перемещение";
            // 
            // CreateObjectButton
            // 
            CreateObjectButton.Location = new Point(6, 22);
            CreateObjectButton.Name = "CreateObjectButton";
            CreateObjectButton.Size = new Size(158, 34);
            CreateObjectButton.TabIndex = 0;
            CreateObjectButton.Text = "Создать объект";
            CreateObjectButton.UseVisualStyleBackColor = true;
            CreateObjectButton.Click += CreateObjectButton_Click;
            // 
            // PaintGroupBox
            // 
            PaintGroupBox.Controls.Add(MainPictureBox);
            PaintGroupBox.Location = new Point(188, 12);
            PaintGroupBox.Name = "PaintGroupBox";
            PaintGroupBox.Size = new Size(600, 426);
            PaintGroupBox.TabIndex = 1;
            PaintGroupBox.TabStop = false;
            // 
            // MainPictureBox
            // 
            MainPictureBox.Location = new Point(6, 22);
            MainPictureBox.Name = "MainPictureBox";
            MainPictureBox.Size = new Size(588, 398);
            MainPictureBox.TabIndex = 0;
            MainPictureBox.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PaintGroupBox);
            Controls.Add(ControlsGroupBox);
            Name = "Form1";
            Text = "Аффинные преобразования";
            ControlsGroupBox.ResumeLayout(false);
            ControlsGroupBox.PerformLayout();
            PaintGroupBox.ResumeLayout(false);
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
        private TextBox CoefficientTextBox;
        private Label CoefficientLabel;
        private Label StretchLabel;
        private Button ApplyRotation;
        private Button ApplyMove;
        private Button ApplyStretching;
        private PictureBox MainPictureBox;
    }
}