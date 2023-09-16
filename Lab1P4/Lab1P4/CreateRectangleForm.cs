using System.Drawing;

namespace Lab1P4;

public partial class CreateRectangleForm : Form
{
    private readonly Bitmap _bitmap;
    private readonly Color _color;
    public CreateRectangleForm(Color color, Bitmap bitmap)
    {
        _color = color;
        _bitmap = bitmap;
        InitializeComponent();
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

        g.DrawRectangle(pen, rectangle);

        g.Flush();
        this.Close();
    }
}