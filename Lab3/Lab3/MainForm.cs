using System.Drawing;
using System.Net;
using static System.Windows.Forms.AxHost;

namespace Lab3;

public partial class MainForm : Form
{
    private Color _fillColor = ColorTranslator.FromHtml("#444fff");
    private readonly List<Point> _originalPoints = new()
    {
        new Point(300, 150),
        new Point(300, 270),
        new Point(420, 240),
        new Point(540, 270),
        new Point(540, 150),
        new Point(420, 180)
    };

    private readonly List<Point> _originalMiddleLine = new()
    {
        new Point(420, 240),
        new Point(420, 180)
    };

    private Point _selectedPoint;

    private readonly Bitmap _bitmap;

    public MainForm()
    {
        InitializeComponent();
        _bitmap = new Bitmap(MainPictureBox.Width, MainPictureBox.Height);
        MainPictureBox.Image = (Image)_bitmap;
        MainPictureBox.BackgroundImageLayout = ImageLayout.None;
        _selectedPoint = new Point(301, 200);
        DrawFigure();
    }

    private void DrawFigure()
    {
        ClearImage();
        using var g = Graphics.FromImage(_bitmap);
        var pen = new Pen(Color.Black, 1);

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

    private void SeedFillingButton_Click(object sender, EventArgs e)
    {
        var targetColor = _bitmap.GetPixel(_selectedPoint.X, _selectedPoint.Y);

        var pixelsToFill = new Stack<Point>();
        pixelsToFill.Push(new Point(_selectedPoint.X, _selectedPoint.Y));

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

    private void LineByLineFillingButton_Click(object sender, EventArgs e)
    {
        var segments = new List<(Point start, Point end)>();
        var prevList = new List<int>();
        bool recordsInPrev = false;

        for (var y = 0; y < _bitmap.Height; y++)
        {
            var xCrossings = new List<int>();
            var prevColor = Color.Empty;

            for (var x = 0; x < _bitmap.Width; x++)
            {
                var thisColor = _bitmap.GetPixel(x, y);

                if (thisColor.ToArgb() != Color.Black.ToArgb())
                {
                    prevColor = Color.Empty;
                    continue;
                }

                if (prevColor != Color.Empty) 
                    continue;

                prevColor = Color.Black;
                xCrossings.Add(x);
            }

            if (xCrossings.Count > 1)
            {
                var prevValue = recordsInPrev;
               
                recordsInPrev = true;
                if (!prevValue)
                    continue;

                if (prevList.Count % 2 == 0)
                {
                    for (var i = 0; i < prevList.Count; i += 2)
                    {
                        var startPoint = new Point(prevList[i] + 1, y - 1);
                        var endPoint = new Point(prevList[i + 1] - 1, y - 1);
                        segments.Add(new(startPoint, endPoint));
                    }
                }
                else
                {
                    for (var i = 0; i < prevList.Count - 1; i++)
                    {
                        var startPoint = new Point(prevList[i] + 1, y - 1);
                        var endPoint = new Point(prevList[i + 1] - 1, y - 1);
                        segments.Add(new(startPoint, endPoint));
                    }
                }
            }
            else
            {
                recordsInPrev = false;
                prevList = new List<int>(xCrossings);
                continue;
            }

            prevList = new List<int>(xCrossings);
        }

        using var g = Graphics.FromImage(_bitmap);
        var pen = new Pen(_fillColor);
        foreach (var segment in segments)
        {
            g.DrawLine(pen, segment.start.X, segment.start.Y, segment.end.X, segment.start.Y);

            MainPictureBox.Refresh();
        }
    }
}