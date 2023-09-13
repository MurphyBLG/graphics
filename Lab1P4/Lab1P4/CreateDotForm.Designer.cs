namespace Lab1P4
{
    partial class CreateDotForm
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
            XCordTextBox = new TextBox();
            YCordTextBox = new TextBox();
            CreateDotButton = new Button();
            SuspendLayout();
            // 
            // XLabel
            // 
            XLabel.AutoSize = true;
            XLabel.Location = new Point(38, 30);
            XLabel.Name = "XLabel";
            XLabel.Size = new Size(20, 15);
            XLabel.TabIndex = 0;
            XLabel.Text = "X: ";
            // 
            // YLabel
            // 
            YLabel.AutoSize = true;
            YLabel.Location = new Point(38, 59);
            YLabel.Name = "YLabel";
            YLabel.Size = new Size(20, 15);
            YLabel.TabIndex = 1;
            YLabel.Text = "Y: ";
            // 
            // XCordTextBox
            // 
            XCordTextBox.Location = new Point(64, 27);
            XCordTextBox.Name = "XCordTextBox";
            XCordTextBox.Size = new Size(109, 23);
            XCordTextBox.TabIndex = 2;
            // 
            // YCordTextBox
            // 
            YCordTextBox.Location = new Point(64, 56);
            YCordTextBox.Name = "YCordTextBox";
            YCordTextBox.Size = new Size(109, 23);
            YCordTextBox.TabIndex = 3;
            // 
            // CreateDotButton
            // 
            CreateDotButton.Location = new Point(38, 97);
            CreateDotButton.Name = "CreateDotButton";
            CreateDotButton.Size = new Size(135, 26);
            CreateDotButton.TabIndex = 4;
            CreateDotButton.Text = "Создать";
            CreateDotButton.UseVisualStyleBackColor = true;
            CreateDotButton.Click += CreateDotButton_Click;
            // 
            // CreateDotForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(217, 139);
            Controls.Add(CreateDotButton);
            Controls.Add(YCordTextBox);
            Controls.Add(XCordTextBox);
            Controls.Add(YLabel);
            Controls.Add(XLabel);
            Name = "CreateDotForm";
            Text = "CreateDotForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label XLabel;
        private Label YLabel;
        private TextBox XCordTextBox;
        private TextBox YCordTextBox;
        private Button CreateDotButton;
    }
}