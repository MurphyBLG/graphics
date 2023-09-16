namespace Lab1P4;

public partial class MainForm : Form
{
    private readonly Bitmap _bitmap;
    private readonly Brush _brush;
    private readonly Color _color;

    public MainForm()
    {
        InitializeComponent();
        _bitmap = new Bitmap(MainPictureBox.Width, MainPictureBox.Height);
        MainPictureBox.Image = (Image)_bitmap;
        MainPictureBox.BackgroundImageLayout = ImageLayout.None;
        _brush = Brushes.Black;
        _color = Color.Black;
    }

    private void CreateDotToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var form = new CreateDotForm(_bitmap, _color);
        form.ShowDialog();
        MainPictureBox.Invalidate();
    }

    private void CreateLineToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var form = new CreateLineForm(_bitmap, _color);
        form.ShowDialog();
        MainPictureBox.Invalidate();
    }

    private void CreateRectangleToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }
}
