using System.Drawing;
using static System.Windows.Forms.AxHost;

namespace Lab3;

public partial class MainForm : Form
{
    private Color _fillColor = ColorTranslator.FromHtml("#333333");
    private readonly List<PointF> _originalPoints = new()
    {
        new PointF(300, 150),
        new PointF(300, 270),
        new PointF(420, 240),
        new PointF(540, 270),
        new PointF(540, 150),
        new PointF(420, 180)
    };

    private readonly List<PointF> _originalMiddleLine = new()
    {
        new PointF(420, 240),
        new PointF(420, 180)
    };

    private Point? _selectedPoint;

    private readonly Bitmap _bitmap;

    public MainForm()
    {
        InitializeComponent();
        _bitmap = new Bitmap(MainPictureBox.Width, MainPictureBox.Height);
        MainPictureBox.Image = (Image)_bitmap;
        MainPictureBox.BackgroundImageLayout = ImageLayout.None;
        _selectedPoint = null;
        DrawFigure();
    }

    private void DrawFigure()
    {
        ClearImage();
        using var g = Graphics.FromImage(_bitmap);
        var pen = new Pen(Color.Black);

        for (var i = 0; i < _originalPoints.Count; i++)
            g.DrawLine(pen, _originalPoints[i], _originalPoints[(i + 1) % _originalPoints.Count]);

        for (var i = 0; i < _originalMiddleLine.Count; i++)
            g.DrawLine(pen, _originalMiddleLine[i], _originalMiddleLine[(i + 1) % _originalMiddleLine.Count]);

        g.Flush();
        MainPictureBox.Invalidate();
    }

    private void ClearImage()
    {
        var g = Graphics.FromImage(_bitmap);
        g.Clear(Color.Empty);
    }

    private void RefreshButton_Click(object sender, EventArgs e)
    {
        DrawFigure();
    }

    private void PickColorButton_Click(object sender, EventArgs e)
    {
        var colorDialog = new ColorDialog();

        if (colorDialog.ShowDialog() == DialogResult.OK)
            _fillColor = colorDialog.Color;
    }

    private void MainPictureBox_MouseClick(object sender, MouseEventArgs e)
    {
        _selectedPoint = new Point(e.X, e.Y);
    }

    public bool IsPointInPolygon(List<PointF> polygon, int x, int y)
    {
        var crossings = 0;
        for (var i = 0; i < polygon.Count; i++)
        {
            var p1 = polygon[i];
            var p2 = polygon[(i + 1) % polygon.Count];

            if ((!(p1.Y <= y) || !(p2.Y > y)) && (!(p1.Y > y) || !(p2.Y <= y)))
                continue;

            var vt = (y - p1.Y) / (p2.Y - p1.Y);
            if (x < p1.X + vt * (p2.X - p1.X))
                crossings++;
        }

        return crossings % 2 == 1 && x >= 0 && x < MainPictureBox.Width && y >= 0 && y < MainPictureBox.Height;
    }

    private void SeedFillingButton_Click(object sender, EventArgs e)
    {
        if (_selectedPoint is null)
        {
            MessageBox.Show("Пожалуйста, выберите точку из которой желаете начать заливку", "Вниманиа!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        if (!IsPointInPolygon(_originalPoints, _selectedPoint.Value.X, _selectedPoint.Value.Y))
        {
            MessageBox.Show("Выбранная точка не находится внутри фигуры", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var targetColor = _bitmap.GetPixel(_selectedPoint.Value.X, _selectedPoint.Value.Y);

        var pixelsToFill = new Stack<Point>();
        pixelsToFill.Push(new Point(_selectedPoint.Value.X, _selectedPoint.Value.Y));

        while (pixelsToFill.Count > 0)
        {
            var currentPixel = pixelsToFill.Pop();
            var x = currentPixel.X;
            var y = currentPixel.Y;

            if (x < 0 || x >= _bitmap.Width || y < 0 || y >= _bitmap.Height ||
                _bitmap.GetPixel(x, y) != targetColor)
                continue;

            _bitmap.SetPixel(x, y, _fillColor);

            MainPictureBox.Refresh();

            pixelsToFill.Push(new Point(x + 1, y));
            pixelsToFill.Push(new Point(x, y + 1));
            pixelsToFill.Push(new Point(x - 1, y));
            pixelsToFill.Push(new Point(x, y - 1));
        }
    }

    private async void LineByLineFillingButton_Click(object sender, EventArgs e)
    {
        if (_selectedPoint is null)
        {
            MessageBox.Show("Пожалуйста, выберите точку из которой желаете начать заливку", "Вниманиа!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        if (!IsPointInPolygon(_originalPoints, _selectedPoint.Value.X, _selectedPoint.Value.Y))
        {
            MessageBox.Show("Выбранная точка не находится внутри фигуры", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var emptyColor = _bitmap.GetPixel(1, 1);
        var currentColor = _bitmap.GetPixel(_selectedPoint.Value.X, _selectedPoint.Value.Y);

        var segments = new List<(PointF start, PointF end)>();
        for (int Y = 0; Y < _bitmap.Height; Y++)
        {
            var startPoint = PointF.Empty;

            for (int X = 0; X < _bitmap.Width; X++)
            {
                var thisColor = _bitmap.GetPixel(X, Y);

                if (thisColor != currentColor || thisColor != emptyColor)
                {
                    if (startPoint == PointF.Empty)
                    {
                        startPoint = new PointF(X + 1, Y);
                    }
                    else
                    {
                        var endPoint = new PointF(X - 1, Y);
                        if (startPoint.X != X && startPoint.X != endPoint.X)
                            segments.Add(new(startPoint, new PointF(X - 1, Y)));
                        startPoint = new PointF(X + 1, Y);
                    }
                }
            }
        }

        foreach (var segment in segments)
        {
            var prevPixel = _bitmap.GetPixel((int)segment.start.X, (int)segment.start.Y - 1);
            if ((prevPixel != currentColor || prevPixel != emptyColor) && SegmentIsNotEnd(segment.start))
            {
                for (int x = (int)segment.start.X; x <= (int)segment.end.X; x++)
                {
                    _bitmap.SetPixel(x, (int)segment.start.Y, _fillColor);
                }
            }

            MainPictureBox.Refresh();
        }
    }

    private bool SegmentIsNotEnd(PointF point)
    {
        var emptyColor = _bitmap.GetPixel(1, 1);

        for (int Y = (int)point.Y; Y < _bitmap.Height; Y++)
        {
            if (_bitmap.GetPixel((int)point.X, Y) != emptyColor)
                return true;
        }

        return false;
    }
}