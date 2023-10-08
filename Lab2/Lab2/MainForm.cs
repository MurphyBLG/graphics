using System.Diagnostics;

namespace Lab2;

public partial class MainForm : Form
{
    private readonly List<PointF> _originalPoints = new()
    {
        new PointF(0, 0),
        new PointF(20, 30),
        new PointF(30, 25),
        new PointF(40, 30),
        new PointF(60, 0),
        new PointF(30, 22)
    };
    private List<PointF> _currentPoints = new();
    private readonly Bitmap _bitmap;

    public MainForm()
    {
        InitializeComponent();
        _currentPoints = _originalPoints;
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

        g.Flush();
        MainPictureBox.Invalidate();
    }

    private void ApplyMove_Click(object sender, EventArgs e)
    {
        var xMove = Int32.Parse(XCordTextBox.Text);
        var yMove = Int32.Parse(YCordTextBox.Text);

        for (int i = 0; i < _currentPoints.Count; i++)
            _currentPoints[i] = new PointF(_currentPoints[i].X + xMove, _currentPoints[i].Y + yMove);

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
            var newX = _currentPoints[i].X * MathF.Cos(angle) - _currentPoints[i].Y * MathF.Sin(angle);
            var newY = _currentPoints[i].X * MathF.Sin(angle) + _currentPoints[i].Y * MathF.Cos(angle);
            _currentPoints[i] = new PointF(newX, newY);
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

        DrawFigure();
    }
}