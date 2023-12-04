using System.Windows.Forms;

namespace lab5;
public partial class MainForm : Form
{
    private int maxIterations = 1000; // Максимальное количество итераций
    private double zoom = 250; // Масштаб
    private readonly Bitmap _bitmap;

    public MainForm()
    {
        InitializeComponent();
        DoubleBuffered = true;
        int width = MainPictureBox.Width;
        int height = MainPictureBox.Height;

        _bitmap = new Bitmap(width, height);
    }

    private void DrawFractal()
    {
        int width = MainPictureBox.Width;
        int height = MainPictureBox.Height;

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                double zx = (x - width / 2.0) / zoom;
                double zy = (y - height / 2.0) / zoom;
                double cx = zx;
                double cy = zy;

                int iteration = 0;
                while (zx * zx + zy * zy < 4 && iteration < maxIterations)
                {
                    double tmp = zx * zx - zy * zy + cx;
                    zy = 2.0 * zx * zy + cy;
                    zx = tmp;
                    iteration++;
                }

                // Преобразование числа итераций в оттенок серого
                int shade = (int)(255.0 * iteration / maxIterations);

                _bitmap.SetPixel(x, y, Color.FromArgb(shade, shade, shade));
            }
        }

        MainPictureBox.Image = _bitmap;
        MainPictureBox.Invalidate();
    }

    private void DrawButton_Click(object sender, EventArgs e)
    {
        maxIterations = Int32.Parse(NestingLevelTextBox.Text);
        DrawFractal();
    }

    private void ClearImage()
    {
        var g = Graphics.FromImage(_bitmap);
        g.Clear(Color.Empty);
    }

    private void ClearButton_Click(object sender, EventArgs e)
    {
        ClearImage();
        MainPictureBox.Invalidate();

    }
}
