namespace Lab1P4
{
    partial class CreateElipseForm
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
            CreateButton = new Button();
            HeightTextBox = new TextBox();
            WidthTextBox = new TextBox();
            YTextBox = new TextBox();
            XTextBox = new TextBox();
            HeightLabel = new Label();
            WidthLabel = new Label();
            YLabel = new Label();
            XLabel = new Label();
            SuspendLayout();
            // 
            // CreateButton
            // 
            CreateButton.Location = new Point(20, 130);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(151, 23);
            CreateButton.TabIndex = 17;
            CreateButton.Text = "Создать";
            CreateButton.UseVisualStyleBackColor = true;
            CreateButton.Click += CreateButton_Click;
            // 
            // HeightTextBox
            // 
            HeightTextBox.Location = new Point(71, 101);
            HeightTextBox.Name = "HeightTextBox";
            HeightTextBox.Size = new Size(100, 23);
            HeightTextBox.TabIndex = 16;
            // 
            // WidthTextBox
            // 
            WidthTextBox.Location = new Point(71, 72);
            WidthTextBox.Name = "WidthTextBox";
            WidthTextBox.Size = new Size(100, 23);
            WidthTextBox.TabIndex = 15;
            // 
            // YTextBox
            // 
            YTextBox.Location = new Point(46, 41);
            YTextBox.Name = "YTextBox";
            YTextBox.Size = new Size(94, 23);
            YTextBox.TabIndex = 14;
            // 
            // XTextBox
            // 
            XTextBox.Location = new Point(46, 12);
            XTextBox.Name = "XTextBox";
            XTextBox.Size = new Size(94, 23);
            XTextBox.TabIndex = 13;
            // 
            // HeightLabel
            // 
            HeightLabel.AutoSize = true;
            HeightLabel.Location = new Point(20, 102);
            HeightLabel.Name = "HeightLabel";
            HeightLabel.Size = new Size(49, 15);
            HeightLabel.TabIndex = 12;
            HeightLabel.Text = "Height: ";
            // 
            // WidthLabel
            // 
            WidthLabel.AutoSize = true;
            WidthLabel.Location = new Point(20, 75);
            WidthLabel.Name = "WidthLabel";
            WidthLabel.Size = new Size(45, 15);
            WidthLabel.TabIndex = 11;
            WidthLabel.Text = "Width: ";
            // 
            // YLabel
            // 
            YLabel.AutoSize = true;
            YLabel.Location = new Point(20, 45);
            YLabel.Name = "YLabel";
            YLabel.Size = new Size(20, 15);
            YLabel.TabIndex = 10;
            YLabel.Text = "Y: ";
            // 
            // XLabel
            // 
            XLabel.AutoSize = true;
            XLabel.Location = new Point(20, 15);
            XLabel.Name = "XLabel";
            XLabel.Size = new Size(20, 15);
            XLabel.TabIndex = 9;
            XLabel.Text = "X: ";
            // 
            // CreateElipseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(187, 170);
            Controls.Add(CreateButton);
            Controls.Add(HeightTextBox);
            Controls.Add(WidthTextBox);
            Controls.Add(YTextBox);
            Controls.Add(XTextBox);
            Controls.Add(HeightLabel);
            Controls.Add(WidthLabel);
            Controls.Add(YLabel);
            Controls.Add(XLabel);
            Name = "CreateElipseForm";
            Text = "CreateElipseForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CreateButton;
        private TextBox HeightTextBox;
        private TextBox WidthTextBox;
        private TextBox YTextBox;
        private TextBox XTextBox;
        private Label HeightLabel;
        private Label WidthLabel;
        private Label YLabel;
        private Label XLabel;
    }
}