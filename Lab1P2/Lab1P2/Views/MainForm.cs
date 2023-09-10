using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Lab1P2.Models;

namespace Lab1P2
{
    public partial class MainForm : Form
    {
        private readonly BindingList<LineType> _lineTypesBindingList = new BindingList<LineType>();

        private readonly BindingList<GeometricFigure> _figures = new()
        {
            new GeometricFigure("Квадрат"),
            new GeometricFigure("Треугольник"),
            new GeometricFigure("Прямоугольник")
        };

        public MainForm()
        {
            InitializeComponent();
            LineTypesListBox.DataSource = _lineTypesBindingList;
            GeometricFiguresComboBox.DataSource = _figures;
        }

        private void AddLineTypeButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(LineTypeInputTextBox.Text))
            {
                MessageBox.Show("Поле тип линии пусто", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _lineTypesBindingList.Add(new LineType
            {
                Name = LineTypeInputTextBox.Text
            });
        }

        private void WatchButton_Click(object sender, EventArgs e)
        {
            YourChoiceTextBox.Text = string.Format(
                "Тип линии: {0} " + Environment.NewLine + "Вид геометрической фигуры: {1}",
                LineTypesListBox.SelectedValue,
                GeometricFiguresComboBox.SelectedValue);
        }
    }
}
