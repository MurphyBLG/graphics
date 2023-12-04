namespace lab5
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
            MainPictureBox = new PictureBox();
            NestingLevelLabel = new Label();
            NestingLevelTextBox = new TextBox();
            DrawButton = new Button();
            ClearButton = new Button();
            ((System.ComponentModel.ISupportInitialize)MainPictureBox).BeginInit();
            SuspendLayout();
            // 
            // MainPictureBox
            // 
            MainPictureBox.BorderStyle = BorderStyle.FixedSingle;
            MainPictureBox.Location = new Point(12, 12);
            MainPictureBox.Name = "MainPictureBox";
            MainPictureBox.Size = new Size(1240, 536);
            MainPictureBox.TabIndex = 0;
            MainPictureBox.TabStop = false;
            // 
            // NestingLevelLabel
            // 
            NestingLevelLabel.AutoSize = true;
            NestingLevelLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NestingLevelLabel.Location = new Point(33, 601);
            NestingLevelLabel.Name = "NestingLevelLabel";
            NestingLevelLabel.Size = new Size(275, 32);
            NestingLevelLabel.TabIndex = 1;
            NestingLevelLabel.Text = "Уровень вложенности: ";
            // 
            // NestingLevelTextBox
            // 
            NestingLevelTextBox.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NestingLevelTextBox.Location = new Point(314, 594);
            NestingLevelTextBox.Name = "NestingLevelTextBox";
            NestingLevelTextBox.Size = new Size(145, 43);
            NestingLevelTextBox.TabIndex = 2;
            NestingLevelTextBox.Text = "1000";
            // 
            // DrawButton
            // 
            DrawButton.Location = new Point(578, 594);
            DrawButton.Name = "DrawButton";
            DrawButton.Size = new Size(281, 45);
            DrawButton.TabIndex = 3;
            DrawButton.Text = "Нарисовать";
            DrawButton.UseVisualStyleBackColor = true;
            DrawButton.Click += DrawButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(891, 594);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(230, 45);
            ClearButton.TabIndex = 4;
            ClearButton.Text = "Очистить";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(ClearButton);
            Controls.Add(DrawButton);
            Controls.Add(NestingLevelTextBox);
            Controls.Add(NestingLevelLabel);
            Controls.Add(MainPictureBox);
            Name = "MainForm";
            Text = "Лабораторная работа 5 Фракталы Рявкин Виталий Алексеевич";
            ((System.ComponentModel.ISupportInitialize)MainPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox MainPictureBox;
        private Label NestingLevelLabel;
        private TextBox NestingLevelTextBox;
        private Button DrawButton;
        private Button ClearButton;
    }
}
