using System.Resources;

namespace Lab1P2
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            LineTypeGroupBox = new GroupBox();
            AddLineTypeButton = new Button();
            LineTypeInputTextBox = new TextBox();
            LineTypeLabel = new Label();
            LineTypesListGroupBox = new GroupBox();
            GeometricFiguresComboBox = new ComboBox();
            geometricFigureBindingSource = new BindingSource(components);
            GeometricFiguresTypesLabel = new Label();
            LineTypesListBox = new ListBox();
            lineTypeBindingSource = new BindingSource(components);
            LineTypeListLabel = new Label();
            YourChoiceLabel = new Label();
            groupBox3 = new GroupBox();
            YourChoiceTextBox = new TextBox();
            WatchButton = new Button();
            LineTypeGroupBox.SuspendLayout();
            LineTypesListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)geometricFigureBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lineTypeBindingSource).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // LineTypeGroupBox
            // 
            LineTypeGroupBox.Controls.Add(AddLineTypeButton);
            LineTypeGroupBox.Controls.Add(LineTypeInputTextBox);
            LineTypeGroupBox.Controls.Add(LineTypeLabel);
            LineTypeGroupBox.Location = new Point(14, 28);
            LineTypeGroupBox.Margin = new Padding(4, 3, 4, 3);
            LineTypeGroupBox.Name = "LineTypeGroupBox";
            LineTypeGroupBox.Padding = new Padding(4, 3, 4, 3);
            LineTypeGroupBox.Size = new Size(398, 135);
            LineTypeGroupBox.TabIndex = 0;
            LineTypeGroupBox.TabStop = false;
            // 
            // AddLineTypeButton
            // 
            AddLineTypeButton.Location = new Point(22, 78);
            AddLineTypeButton.Margin = new Padding(4, 3, 4, 3);
            AddLineTypeButton.Name = "AddLineTypeButton";
            AddLineTypeButton.Size = new Size(357, 36);
            AddLineTypeButton.TabIndex = 2;
            AddLineTypeButton.Text = "Добавить";
            AddLineTypeButton.UseVisualStyleBackColor = true;
            AddLineTypeButton.Click += AddLineTypeButton_Click;
            // 
            // LineTypeInputTextBox
            // 
            LineTypeInputTextBox.Location = new Point(22, 48);
            LineTypeInputTextBox.Margin = new Padding(4, 3, 4, 3);
            LineTypeInputTextBox.Name = "LineTypeInputTextBox";
            LineTypeInputTextBox.Size = new Size(356, 23);
            LineTypeInputTextBox.TabIndex = 1;
            LineTypeInputTextBox.Text = "Введите тип линии";
            // 
            // LineTypeLabel
            // 
            LineTypeLabel.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LineTypeLabel.Location = new Point(7, 18);
            LineTypeLabel.Margin = new Padding(4, 0, 4, 0);
            LineTypeLabel.Name = "LineTypeLabel";
            LineTypeLabel.Size = new Size(384, 27);
            LineTypeLabel.TabIndex = 0;
            LineTypeLabel.Text = "Тип линии";
            LineTypeLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // LineTypesListGroupBox
            // 
            LineTypesListGroupBox.Controls.Add(GeometricFiguresComboBox);
            LineTypesListGroupBox.Controls.Add(GeometricFiguresTypesLabel);
            LineTypesListGroupBox.Controls.Add(LineTypesListBox);
            LineTypesListGroupBox.Controls.Add(LineTypeListLabel);
            LineTypesListGroupBox.Location = new Point(14, 189);
            LineTypesListGroupBox.Margin = new Padding(4, 3, 4, 3);
            LineTypesListGroupBox.Name = "LineTypesListGroupBox";
            LineTypesListGroupBox.Padding = new Padding(4, 3, 4, 3);
            LineTypesListGroupBox.Size = new Size(398, 241);
            LineTypesListGroupBox.TabIndex = 1;
            LineTypesListGroupBox.TabStop = false;
            // 
            // GeometricFiguresComboBox
            // 
            GeometricFiguresComboBox.DataSource = geometricFigureBindingSource;
            GeometricFiguresComboBox.DisplayMember = "Name";
            GeometricFiguresComboBox.FormattingEnabled = true;
            GeometricFiguresComboBox.Location = new Point(14, 195);
            GeometricFiguresComboBox.Margin = new Padding(4, 3, 4, 3);
            GeometricFiguresComboBox.Name = "GeometricFiguresComboBox";
            GeometricFiguresComboBox.Size = new Size(364, 23);
            GeometricFiguresComboBox.TabIndex = 3;
            GeometricFiguresComboBox.ValueMember = "Name";
            // 
            // geometricFigureBindingSource
            // 
            geometricFigureBindingSource.DataSource = typeof(Models.GeometricFigure);
            // 
            // GeometricFiguresTypesLabel
            // 
            GeometricFiguresTypesLabel.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            GeometricFiguresTypesLabel.Location = new Point(10, 155);
            GeometricFiguresTypesLabel.Margin = new Padding(4, 0, 4, 0);
            GeometricFiguresTypesLabel.Name = "GeometricFiguresTypesLabel";
            GeometricFiguresTypesLabel.Size = new Size(380, 27);
            GeometricFiguresTypesLabel.TabIndex = 2;
            GeometricFiguresTypesLabel.Text = "Список видов геометрических фигур";
            GeometricFiguresTypesLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LineTypesListBox
            // 
            LineTypesListBox.DataSource = lineTypeBindingSource;
            LineTypesListBox.FormattingEnabled = true;
            LineTypesListBox.ItemHeight = 15;
            LineTypesListBox.Location = new Point(14, 58);
            LineTypesListBox.Margin = new Padding(4, 3, 4, 3);
            LineTypesListBox.Name = "LineTypesListBox";
            LineTypesListBox.Size = new Size(364, 79);
            LineTypesListBox.TabIndex = 1;
            LineTypesListBox.ValueMember = "Name";
            // 
            // lineTypeBindingSource
            // 
            lineTypeBindingSource.DataSource = typeof(Models.LineType);
            // 
            // LineTypeListLabel
            // 
            LineTypeListLabel.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LineTypeListLabel.Location = new Point(10, 18);
            LineTypeListLabel.Margin = new Padding(4, 0, 4, 0);
            LineTypeListLabel.Name = "LineTypeListLabel";
            LineTypeListLabel.Size = new Size(380, 36);
            LineTypeListLabel.TabIndex = 0;
            LineTypeListLabel.Text = "Список типов для линии";
            LineTypeListLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // YourChoiceLabel
            // 
            YourChoiceLabel.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            YourChoiceLabel.Location = new Point(10, 18);
            YourChoiceLabel.Margin = new Padding(4, 0, 4, 0);
            YourChoiceLabel.Name = "YourChoiceLabel";
            YourChoiceLabel.Size = new Size(380, 27);
            YourChoiceLabel.TabIndex = 2;
            YourChoiceLabel.Text = "Ваш выбор";
            YourChoiceLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(YourChoiceTextBox);
            groupBox3.Controls.Add(WatchButton);
            groupBox3.Controls.Add(YourChoiceLabel);
            groupBox3.Location = new Point(14, 456);
            groupBox3.Margin = new Padding(4, 3, 4, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 3, 4, 3);
            groupBox3.Size = new Size(398, 175);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            // 
            // YourChoiceTextBox
            // 
            YourChoiceTextBox.Location = new Point(14, 48);
            YourChoiceTextBox.Margin = new Padding(4, 3, 4, 3);
            YourChoiceTextBox.Multiline = true;
            YourChoiceTextBox.Name = "YourChoiceTextBox";
            YourChoiceTextBox.Size = new Size(364, 64);
            YourChoiceTextBox.TabIndex = 4;
            // 
            // WatchButton
            // 
            WatchButton.Location = new Point(14, 120);
            WatchButton.Margin = new Padding(4, 3, 4, 3);
            WatchButton.Name = "WatchButton";
            WatchButton.Size = new Size(365, 37);
            WatchButton.TabIndex = 3;
            WatchButton.Text = "Посмотреть";
            WatchButton.UseVisualStyleBackColor = true;
            WatchButton.Click += WatchButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 658);
            Controls.Add(groupBox3);
            Controls.Add(LineTypesListGroupBox);
            Controls.Add(LineTypeGroupBox);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
            Text = "MainForm";
            LineTypeGroupBox.ResumeLayout(false);
            LineTypeGroupBox.PerformLayout();
            LineTypesListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)geometricFigureBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)lineTypeBindingSource).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox LineTypeGroupBox;
        private Button AddLineTypeButton;
        private TextBox LineTypeInputTextBox;
        private Label LineTypeLabel;
        private GroupBox LineTypesListGroupBox;
        private Label GeometricFiguresTypesLabel;
        private ListBox LineTypesListBox;
        private Label LineTypeListLabel;
        private ComboBox GeometricFiguresComboBox;
        private Label YourChoiceLabel;
        private GroupBox groupBox3;
        private TextBox YourChoiceTextBox;
        private Button WatchButton;
        private BindingSource lineTypeBindingSource;
        private BindingSource geometricFigureBindingSource;
    }
}