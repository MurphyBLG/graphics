using System.Diagnostics;

namespace Lab2;

public partial class MainForm : Form
{
    private readonly List<PointF> _originalPoints = new()
    {
        new PointF(0, 0),
        new PointF(0, 80),
        new PointF(80, 60),
        new PointF(160, 80),
        new PointF(160, 0),
        new PointF(80, 20)
    };

    private readonly List<PointF> _originalMiddleLine = new()
    {
        new PointF(80, 60),
        new PointF(80, 20),
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
        if (!CanDraw())
        {
            MessageBox.Show("невозможно отрисовать фигуру, так как она вфйдет за пол€");
            return;
        }

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
        if (string.IsNullOrEmpty(XCordTextBox.Text))
        {
            MessageBox.Show("¬ведите сдвиг по X");
            return;
        }

        if (string.IsNullOrEmpty(YCordTextBox.Text))
        {
            MessageBox.Show("¬ведите сдвиг по X");
            return;
        }

        var xMove = Int32.Parse(XCordTextBox.Text);
        var yMove = Int32.Parse(YCordTextBox.Text);

        for (int i = 0; i < _currentPoints.Count; i++)
            _currentPoints[i] = new PointF(_currentPoints[i].X + xMove, _currentPoints[i].Y + yMove);

        for (int i = 0; i < _currentMiddleline.Count; i++)
            _currentMiddleline[i] = new PointF(_currentMiddleline[i].X + xMove, _currentMiddleline[i].Y + yMove);

        DrawFigure();

        XCordTextBox.Text = "";
        YCordTextBox.Text = "";
    }

    private void ClearImage()
    {
        var g = Graphics.FromImage(_bitmap);
        g.Clear(Color.Empty);
    }

    private void ApplyRotation_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(AngleTextBox.Text))
        {
            MessageBox.Show("¬ведите угол вращени€");
            return;
        }

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
        AngleTextBox.Text = "";
    }

    private float ToRadians(double degrees)
    {
        return (MathF.PI / 180) * (float)(degrees % 360);
    }

    private void ApplyStretching_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(CoefficientXTextBox.Text))
        {
            MessageBox.Show("¬ведите коэффициент раст€жени€ по X");
            return;
        }

        if (string.IsNullOrEmpty(CoefficientYTextBox.Text))
        {
            MessageBox.Show("¬ведите коэффициент раст€жени€ по Y");
            return;
        }

        var kx = float.Parse(CoefficientXTextBox.Text);
        var ky = float.Parse(CoefficientYTextBox.Text);
        var center = GetCenter();

        for (int i = 0; i < _currentPoints.Count; i++)
        {
            _currentPoints[i] = new PointF(_currentPoints[i].X - center.X, _currentPoints[i].Y - center.Y);
            _currentPoints[i] = new PointF(_currentPoints[i].X * kx, _currentPoints[i].Y * ky);
            _currentPoints[i] = new PointF(_currentPoints[i].X + center.X, _currentPoints[i].Y + center.Y);
        }

        for (int i = 0; i < _currentMiddleline.Count; i++)
        {
            _currentMiddleline[i] = new PointF(_currentMiddleline[i].X - center.X, _currentMiddleline[i].Y - center.Y);
            _currentMiddleline[i] = new PointF(_currentMiddleline[i].X * kx, _currentMiddleline[i].Y * ky);
            _currentMiddleline[i] = new PointF(_currentMiddleline[i].X + center.X, _currentMiddleline[i].Y + center.Y);
        }

        DrawFigure();
        CoefficientXTextBox.Text = "";
        CoefficientYTextBox.Text = "";
    }

    private PointF GetCenter()
    {
        var center = new PointF(0, 0);

        foreach (var point in _currentPoints)
        {
            center.X += point.X;
            center.Y += point.Y;
        }

        center.X /= _currentPoints.Count;
        center.Y /= _currentPoints.Count;

        return center;
    }

    private bool CanDraw()
    {
        foreach (var cp in _currentPoints)
        {
            if (cp.X > _bitmap.Width || cp.X < 0 || cp.Y > _bitmap.Height || cp.Y < 0)
                return false;
        }

        foreach (var cp in _currentMiddleline)
        {
            if (cp.X > _bitmap.Width || cp.X < 0 || cp.Y > _bitmap.Height || cp.Y < 0)
                return false;
        }

        return true;
    }
}