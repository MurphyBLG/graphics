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
            ClearButton = new Button();
            SaveParametersForMultipleTrees = new Button();
            CountOfTreesTextBox = new TextBox();
            label3 = new Label();
            SaveSingleTreeParams = new Button();
            SingleTreeCountOfBranches = new TextBox();
            label2 = new Label();
            TrunkHeight = new TextBox();
            label1 = new Label();
            MultipleTreeRadioButton = new RadioButton();
            SingleTreeRadioButton = new RadioButton();
            MainPictureBox = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MainPictureBox).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ClearButton);
            groupBox1.Controls.Add(SaveParametersForMultipleTrees);
            groupBox1.Controls.Add(CountOfTreesTextBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(SaveSingleTreeParams);
            groupBox1.Controls.Add(SingleTreeCountOfBranches);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TrunkHeight);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(MultipleTreeRadioButton);
            groupBox1.Controls.Add(SingleTreeRadioButton);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(192, 657);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(6, 334);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(175, 39);
            ClearButton.TabIndex = 10;
            ClearButton.Text = "Очистить полотно";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // SaveParametersForMultipleTrees
            // 
            SaveParametersForMultipleTrees.Location = new Point(6, 288);
            SaveParametersForMultipleTrees.Name = "SaveParametersForMultipleTrees";
            SaveParametersForMultipleTrees.Size = new Size(180, 40);
            SaveParametersForMultipleTrees.TabIndex = 9;
            SaveParametersForMultipleTrees.Text = "Сохранить параметры";
            SaveParametersForMultipleTrees.UseVisualStyleBackColor = true;
            SaveParametersForMultipleTrees.Click += SaveParametersForMultipleTrees_Click;
            // 
            // CountOfTreesTextBox
            // 
            CountOfTreesTextBox.Location = new Point(103, 241);
            CountOfTreesTextBox.Name = "CountOfTreesTextBox";
            CountOfTreesTextBox.Size = new Size(83, 23);
            CountOfTreesTextBox.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 244);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 7;
            label3.Text = "Кол-во деревьев";
            // 
            // SaveSingleTreeParams
            // 
            SaveSingleTreeParams.Location = new Point(6, 141);
            SaveSingleTreeParams.Name = "SaveSingleTreeParams";
            SaveSingleTreeParams.Size = new Size(180, 39);
            SaveSingleTreeParams.TabIndex = 6;
            SaveSingleTreeParams.Text = "Сохранить параметры";
            SaveSingleTreeParams.UseVisualStyleBackColor = true;
            SaveSingleTreeParams.Click += SaveSingleTreeParams_Click;
            // 
            // SingleTreeCountOfBranches
            // 
            SingleTreeCountOfBranches.Location = new Point(121, 102);
            SingleTreeCountOfBranches.Name = "SingleTreeCountOfBranches";
            SingleTreeCountOfBranches.Size = new Size(65, 23);
            SingleTreeCountOfBranches.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 105);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 4;
            label2.Text = "Количество веток";
            // 
            // TrunkHeight
            // 
            TrunkHeight.Location = new Point(103, 64);
            TrunkHeight.Name = "TrunkHeight";
            TrunkHeight.Size = new Size(83, 23);
            TrunkHeight.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 67);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 2;
            label1.Text = "Высота ствола";
            // 
            // MultipleTreeRadioButton
            // 
            MultipleTreeRadioButton.AutoSize = true;
            MultipleTreeRadioButton.Location = new Point(6, 201);
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
        private TextBox TrunkHeight;
        private Label label1;
        private TextBox SingleTreeCountOfBranches;
        private Label label2;
        private Button SaveSingleTreeParams;
        private Label label3;
        private TextBox CountOfTreesTextBox;
        private Button SaveParametersForMultipleTrees;
        private Button ClearButton;
    }
}
