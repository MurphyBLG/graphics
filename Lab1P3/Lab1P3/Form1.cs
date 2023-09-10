using Lab1P3.Enums;
using System.Diagnostics;

namespace Lab1P3
{
    public partial class Form1 : Form
    {
        private Rectangle _rectangle;
        private Point _mouseDownLocation;
        private Point _rectangleMouseDownLocation;
        private bool _lastClickedItemIsRectangle = false;
        private bool _mouseButtonIsPressed = false;

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
            var borderPen = new Pen(Color.Black, 3);
            var insideBrush = new SolidBrush(Color.Red);

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
            if (e.Button == MouseButtons.Left)
            {
                if (!_mouseButtonIsPressed)
                {
                    _mouseDownLocation = e.Location;
                    _rectangleMouseDownLocation = _rectangle.Location;
                    if (_rectangle.Contains(e.Location))
                        _lastClickedItemIsRectangle = true;
                }

                _mouseButtonIsPressed = true;
            }


            switch (e.Button)
            {
                case MouseButtons.Left:
                    if (!_mouseButtonIsPressed)
                    {
                        _mouseDownLocation = e.Location;
                        _rectangleMouseDownLocation = _rectangle.Location;
                        if (_rectangle.Contains(e.Location))
                            _lastClickedItemIsRectangle = true;
                    }

                    _mouseButtonIsPressed = true;
                    break;
                case MouseButtons.Right:
                    break;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseButtonIsPressed = false;
            _lastClickedItemIsRectangle = false;
        }
    }
}