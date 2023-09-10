using Lab1P3.Enums;
using System.Diagnostics;
using System.Drawing.Drawing2D;

namespace Lab1P3
{
    public partial class Form1 : Form
    {
        private Rectangle _rectangle;
        private Point _mouseDownLocation;
        private Point _rectangleMouseDownLocation;
        private bool _lastClickedItemIsRectangle = false;
        private bool _mouseButtonIsPressed = false;
        private Color _rectangleBorderColor = Color.Black;
        private int _rectangelBorderThickness = 3;
        private Color _rectangleFillingColor = Color.Red;
        private TypeOfLine _typeOfLine = TypeOfLine.Solid;

        public Form1()
        {
            InitializeComponent();
            var coordinates = new Point(10, 10);
            var rectangleSizes = new Size(100, 200);
            _rectangle = new Rectangle(coordinates, rectangleSizes);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);

            RedrawRectangle(e);
        }

        public void RedrawRectangle(PaintEventArgs e)
        {
            float[] dashValues = { 2, 2 };
            var borderPen = new Pen(_rectangleBorderColor, _rectangelBorderThickness);
            if (_typeOfLine == TypeOfLine.Dotted)
                borderPen.DashPattern = dashValues;
            var insideBrush = new SolidBrush(_rectangleFillingColor);

            e.Graphics.FillRectangle(insideBrush, _rectangle);
            e.Graphics.DrawRectangle(borderPen, _rectangle);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && _lastClickedItemIsRectangle)
            {
                _rectangle.Location = new Point((e.X - _mouseDownLocation.X) + _rectangleMouseDownLocation.X, (e.Y - _mouseDownLocation.Y) + _rectangleMouseDownLocation.Y);
                panel1.Refresh();
                this.Invalidate();
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (_rectangle.Contains(e.Location))
                _lastClickedItemIsRectangle = true;

            switch (e.Button)
            {
                case MouseButtons.Left:
                    if (!_mouseButtonIsPressed)
                    {
                        _mouseDownLocation = e.Location;
                        _rectangleMouseDownLocation = _rectangle.Location;
                    }

                    _mouseButtonIsPressed = true;
                    break;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseButtonIsPressed = false;
            _lastClickedItemIsRectangle = false;
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (_lastClickedItemIsRectangle && e.Button == MouseButtons.Right)
                RectangleMenuStrip.Show(e.Location);
        }

        private void SolidLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _typeOfLine = TypeOfLine.Solid;
            panel1.Refresh();
        }

        private void DottedLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _typeOfLine = TypeOfLine.Dotted;
            panel1.Refresh();
        }

        private void SetThicknessTo5MenuItem_Click(object sender, EventArgs e)
        {
            _rectangelBorderThickness = (int)WeightOfLine.Five;
            panel1.Refresh();
        }

        private void SetThicknessTo10MenuItem_Click(object sender, EventArgs e)
        {
            _rectangelBorderThickness = (int)WeightOfLine.Ten;
            panel1.Refresh();
        }

        private void SetThicknessTo15MenuItem_Click(object sender, EventArgs e)
        {
            _rectangelBorderThickness = (int)WeightOfLine.Fifteen;
            panel1.Refresh();
        }
    }
}