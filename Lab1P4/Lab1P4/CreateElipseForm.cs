namespace Lab1P4;

public partial class CreateElipseForm : Form
{
    private readonly Bitmap _bitmap;
    private readonly Color _color;

    public CreateElipseForm(Bitmap bitmap, Color color)
    {
        InitializeComponent();
        _bitmap = bitmap;
        _color = color;
    }

    private void CreateButton_Click(object sender, EventArgs e)
    {
        using var g = Graphics.FromImage(_bitmap);
        var xCord = Convert.ToInt32(XTextBox.Text);
        var yCord = Convert.ToInt32(YTextBox.Text);

        var width = Convert.ToInt32(WidthTextBox.Text);
        var height = Convert.ToInt32(HeightTextBox.Text);

        var point = new Point(xCord, yCord);
        var size = new Size(width, height);
        var rectangle = new Rectangle(point, size);
        var pen = new Pen(_color);

        g.DrawEllipse(pen, rectangle);
        g.Flush();
        this.Close();
    }
}
