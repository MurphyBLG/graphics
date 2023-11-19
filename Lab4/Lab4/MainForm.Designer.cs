namespace Lab4
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
            groupBox1 = new GroupBox();
            MultipleTreeRadioButton = new RadioButton();
            SingleTreeRadioButton = new RadioButton();
            MainPictureBox = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MainPictureBox).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(MultipleTreeRadioButton);
            groupBox1.Controls.Add(SingleTreeRadioButton);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(192, 657);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // MultipleTreeRadioButton
            // 
            MultipleTreeRadioButton.AutoSize = true;
            MultipleTreeRadioButton.Location = new Point(6, 253);
            MultipleTreeRadioButton.Name = "MultipleTreeRadioButton";
            MultipleTreeRadioButton.Size = new Size(175, 19);
            MultipleTreeRadioButton.TabIndex = 1;
            MultipleTreeRadioButton.TabStop = true;
            MultipleTreeRadioButton.Text = "Рисование соснового бора";
            MultipleTreeRadioButton.UseVisualStyleBackColor = true;
            MultipleTreeRadioButton.CheckedChanged += MultipleTreeRadioButton_CheckedChanged;
            // 
            // SingleTreeRadioButton
            // 
            SingleTreeRadioButton.AutoSize = true;
            SingleTreeRadioButton.Location = new Point(6, 22);
            SingleTreeRadioButton.Name = "SingleTreeRadioButton";
            SingleTreeRadioButton.Size = new Size(150, 19);
            SingleTreeRadioButton.TabIndex = 0;
            SingleTreeRadioButton.TabStop = true;
            SingleTreeRadioButton.Text = "Рисование одной елки";
            SingleTreeRadioButton.UseVisualStyleBackColor = true;
            SingleTreeRadioButton.CheckedChanged += SingleTreeRadioButton_CheckedChanged;
            // 
            // MainPictureBox
            // 
            MainPictureBox.BorderStyle = BorderStyle.FixedSingle;
            MainPictureBox.Location = new Point(229, 12);
            MainPictureBox.Name = "MainPictureBox";
            MainPictureBox.Size = new Size(1023, 657);
            MainPictureBox.TabIndex = 1;
            MainPictureBox.TabStop = false;
            MainPictureBox.Click += MainPictureBox_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(MainPictureBox);
            Controls.Add(groupBox1);
            Name = "MainForm";
            Text = "Идивидуальное задание Рявкин Виталий Алексеевич КЭ-403";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MainPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton MultipleTreeRadioButton;
        private RadioButton SingleTreeRadioButton;
        private PictureBox MainPictureBox;
    }
}
