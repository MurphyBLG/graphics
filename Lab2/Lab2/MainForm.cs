using System.Diagnostics;

namespace Lab2;

public partial class MainForm : Form
{
    private readonly List<PointF> _originalPoints = new()
    {
        new PointF(0, 0),
        new PointF(0, 20),
        new PointF(20, 15),
        new PointF(40, 20),
        new PointF(40, 0),
        new PointF(20, 5)
    };

    private readonly List<PointF> _originalMiddleLine = new()
    {
        new PointF(20, 15),
        new PointF(20, 5),
    };

    private List<PointF> _currentPoints = new();
    private List<PointF> _currentMiddleline = new();
    private readonly Bitmap _bitmap;

    public MainForm()
    {
        InitializeComponent();
        _currentPoints = _originalPoints;
        _currentMiddleline = _originalMiddleLine;
        _bitmap = new Bitmap(MainPictureBox.Width, MainPictureBox.Height);
        MainPictureBox.Image = (Image)_bitmap;
        MainPictureBox.BackgroundImageLayout = ImageLayout.None;
    }

    private void CreateObjectButton_Click(object sender, EventArgs e)
    {
        DrawFigure();
    }

    private void DrawFigure()
    {
        ClearImage();
        using var g = Graphics.FromImage(_bitmap);
        var pen = new Pen(Color.Black);

        for (int i = 0; i < _currentPoints.Count; i++)
            g.DrawLine(pen, _currentPoints[i], _currentPoints[(i + 1) % _currentPoints.Count]);

        for (int i = 0; i < _currentMiddleline.Count; i++)
            g.DrawLine(pen, _currentMiddleline[i], _currentMiddleline[(i + 1) % _currentMiddleline.Count]);

        g.Flush();
        MainPictureBox.Invalidate();
    }

    private void ApplyMove_Click(object sender, EventArgs e)
    {
        var xMove = Int32.Parse(XCordTextBox.Text);
        var yMove = Int32.Parse(YCordTextBox.Text);

        for (int i = 0; i < _currentPoints.Count; i++)
            _currentPoints[i] = new PointF(_currentPoints[i].X + xMove, _currentPoints[i].Y + yMove);

        for (int i = 0; i < _currentMiddleline.Count; i++)
            _currentMiddleline[i] = new PointF(_currentMiddleline[i].X + xMove, _currentMiddleline[i].Y + yMove);

        DrawFigure();
    }

    private void ClearImage()
    {
        var g = Graphics.FromImage(_bitmap);
        g.Clear(Color.Empty);
    }

    private void ApplyRotation_Click(object sender, EventArgs e)
    {
        var angle = ToRadians(float.Parse(AngleTextBox.Text));

        for (int i = 0; i < _currentPoints.Count; i++)
        {
            var newX = _currentPoints[i].X * MathF.Cos(angle) - _currentPoints[i].Y * MathF.Sin(angle) - (_currentPoints[0].X * MathF.Cos(angle) - _currentPoints[0].Y * MathF.Sin(angle)) + _currentPoints[0].X;
            var newY = _currentPoints[i].X * MathF.Sin(angle) + _currentPoints[i].Y * MathF.Cos(angle) - (_currentPoints[0].X * MathF.Sin(angle) + _currentPoints[0].Y * MathF.Cos(angle)) + _currentPoints[0].Y;
            _currentPoints[i] = new PointF(newX, newY);
        }

        for (int i = 0; i < _currentMiddleline.Count; i++)
        {
            var newX = _currentMiddleline[i].X * MathF.Cos(angle) - _currentMiddleline[i].Y * MathF.Sin(angle) - (_currentPoints[0].X * MathF.Cos(angle) - _currentPoints[0].Y * MathF.Sin(angle)) + _currentPoints[0].X;
            var newY = _currentMiddleline[i].X * MathF.Sin(angle) + _currentMiddleline[i].Y * MathF.Cos(angle) - (_currentPoints[0].X * MathF.Sin(angle) + _currentPoints[0].Y * MathF.Cos(angle)) + _currentPoints[0].Y;
            _currentMiddleline[i] = new PointF(newX, newY);
        }

        DrawFigure();
    }

    private float ToRadians(double degrees)
    {
        return (MathF.PI / 180) * (float)(degrees % 360);
    }

    private void ApplyStretching_Click(object sender, EventArgs e)
    {
        var k = float.Parse(CoefficientTextBox.Text);

        for (int i = 0; i < _currentPoints.Count; i++)
        {
            var newX = _currentPoints[i].X * k;
            var newY = _currentPoints[i].Y * k;
            _currentPoints[i] = new PointF(newX, newY);
        }

        for (int i = 0; i < _currentMiddleline.Count; i++)
        {
            var newX = _currentMiddleline[i].X * k;
            var newY = _currentMiddleline[i].Y * k;
            _currentMiddleline[i] = new PointF(newX, newY);
        }

        DrawFigure();
    }
}