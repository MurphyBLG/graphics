namespace Lab1P4
{
    partial class CreateRectangleForm
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
            XLabel = new Label();
            YLabel = new Label();
            WidthLabel = new Label();
            HeightLabel = new Label();
            XTextBox = new TextBox();
            YTextBox = new TextBox();
            WidthTextBox = new TextBox();
            HeightTextBox = new TextBox();
            CreateButton = new Button();
            SuspendLayout();
            // 
            // XLabel
            // 
            XLabel.AutoSize = true;
            XLabel.Location = new Point(26, 20);
            XLabel.Name = "XLabel";
            XLabel.Size = new Size(20, 15);
            XLabel.TabIndex = 0;
            XLabel.Text = "X: ";
            // 
            // YLabel
            // 
            YLabel.AutoSize = true;
            YLabel.Location = new Point(26, 50);
            YLabel.Name = "YLabel";
            YLabel.Size = new Size(20, 15);
            YLabel.TabIndex = 1;
            YLabel.Text = "Y: ";
            // 
            // WidthLabel
            // 
            WidthLabel.AutoSize = true;
            WidthLabel.Location = new Point(26, 80);
            WidthLabel.Name = "WidthLabel";
            WidthLabel.Size = new Size(45, 15);
            WidthLabel.TabIndex = 2;
            WidthLabel.Text = "Width: ";
            // 
            // HeightLabel
            // 
            HeightLabel.AutoSize = true;
            HeightLabel.Location = new Point(26, 107);
            HeightLabel.Name = "HeightLabel";
            HeightLabel.Size = new Size(49, 15);
            HeightLabel.TabIndex = 3;
            HeightLabel.Text = "Height: ";
            // 
            // XTextBox
            // 
            XTextBox.Location = new Point(52, 17);
            XTextBox.Name = "XTextBox";
            XTextBox.Size = new Size(94, 23);
            XTextBox.TabIndex = 4;
            // 
            // YTextBox
            // 
            YTextBox.Location = new Point(52, 46);
            YTextBox.Name = "YTextBox";
            YTextBox.Size = new Size(94, 23);
            YTextBox.TabIndex = 5;
            // 
            // WidthTextBox
            // 
            WidthTextBox.Location = new Point(77, 77);
            WidthTextBox.Name = "WidthTextBox";
            WidthTextBox.Size = new Size(100, 23);
            WidthTextBox.TabIndex = 6;
            // 
            // HeightTextBox
            // 
            HeightTextBox.Location = new Point(77, 106);
            HeightTextBox.Name = "HeightTextBox";
            HeightTextBox.Size = new Size(100, 23);
            HeightTextBox.TabIndex = 7;
            // 
            // CreateButton
            // 
            CreateButton.Location = new Point(26, 135);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(151, 23);
            CreateButton.TabIndex = 8;
            CreateButton.Text = "Создать";
            CreateButton.UseVisualStyleBackColor = true;
            CreateButton.Click += CreateButton_Click;
            // 
            // CreateRectangleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(191, 170);
            Controls.Add(CreateButton);
            Controls.Add(HeightTextBox);
            Controls.Add(WidthTextBox);
            Controls.Add(YTextBox);
            Controls.Add(XTextBox);
            Controls.Add(HeightLabel);
            Controls.Add(WidthLabel);
            Controls.Add(YLabel);
            Controls.Add(XLabel);
            Name = "CreateRectangleForm";
            Text = "CreateRectangleForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label XLabel;
        private Label YLabel;
        private Label WidthLabel;
        private Label HeightLabel;
        private TextBox XTextBox;
        private TextBox YTextBox;
        private TextBox WidthTextBox;
        private TextBox HeightTextBox;
        private Button CreateButton;
    }
}