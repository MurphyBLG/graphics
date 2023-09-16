namespace Lab1P4
{
    partial class CreateLineForm
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
            X1Label = new Label();
            Y1Label = new Label();
            X2Label = new Label();
            Y2Label = new Label();
            X1TextBox = new TextBox();
            Y1TextBox = new TextBox();
            X2TextBox = new TextBox();
            Y2TextBox = new TextBox();
            CreateButton = new Button();
            SuspendLayout();
            // 
            // X1Label
            // 
            X1Label.AutoSize = true;
            X1Label.Location = new Point(50, 46);
            X1Label.Name = "X1Label";
            X1Label.Size = new Size(26, 15);
            X1Label.TabIndex = 0;
            X1Label.Text = "X1: ";
            // 
            // Y1Label
            // 
            Y1Label.AutoSize = true;
            Y1Label.Location = new Point(50, 74);
            Y1Label.Name = "Y1Label";
            Y1Label.Size = new Size(26, 15);
            Y1Label.TabIndex = 1;
            Y1Label.Text = "Y1: ";
            // 
            // X2Label
            // 
            X2Label.AutoSize = true;
            X2Label.Location = new Point(50, 103);
            X2Label.Name = "X2Label";
            X2Label.Size = new Size(26, 15);
            X2Label.TabIndex = 2;
            X2Label.Text = "X2: ";
            // 
            // Y2Label
            // 
            Y2Label.AutoSize = true;
            Y2Label.Location = new Point(50, 127);
            Y2Label.Name = "Y2Label";
            Y2Label.Size = new Size(26, 15);
            Y2Label.TabIndex = 3;
            Y2Label.Text = "Y2: ";
            // 
            // X1TextBox
            // 
            X1TextBox.Location = new Point(82, 38);
            X1TextBox.Name = "X1TextBox";
            X1TextBox.Size = new Size(103, 23);
            X1TextBox.TabIndex = 4;
            // 
            // Y1TextBox
            // 
            Y1TextBox.Location = new Point(82, 66);
            Y1TextBox.Name = "Y1TextBox";
            Y1TextBox.Size = new Size(103, 23);
            Y1TextBox.TabIndex = 5;
            // 
            // X2TextBox
            // 
            X2TextBox.Location = new Point(82, 95);
            X2TextBox.Name = "X2TextBox";
            X2TextBox.Size = new Size(103, 23);
            X2TextBox.TabIndex = 6;
            // 
            // Y2TextBox
            // 
            Y2TextBox.Location = new Point(82, 124);
            Y2TextBox.Name = "Y2TextBox";
            Y2TextBox.Size = new Size(103, 23);
            Y2TextBox.TabIndex = 7;
            // 
            // CreateButton
            // 
            CreateButton.Location = new Point(50, 162);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(135, 23);
            CreateButton.TabIndex = 8;
            CreateButton.Text = "Создать";
            CreateButton.UseVisualStyleBackColor = true;
            CreateButton.Click += CreateButton_Click;
            // 
            // CreateLineForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(246, 209);
            Controls.Add(CreateButton);
            Controls.Add(Y2TextBox);
            Controls.Add(X2TextBox);
            Controls.Add(Y1TextBox);
            Controls.Add(X1TextBox);
            Controls.Add(Y2Label);
            Controls.Add(X2Label);
            Controls.Add(Y1Label);
            Controls.Add(X1Label);
            Name = "CreateLineForm";
            Text = "CreateLineForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label X1Label;
        private Label Y1Label;
        private Label X2Label;
        private Label Y2Label;
        private TextBox X1TextBox;
        private TextBox Y1TextBox;
        private TextBox X2TextBox;
        private TextBox Y2TextBox;
        private Button CreateButton;
    }
}