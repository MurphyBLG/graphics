namespace Lab1P4;

public partial class CreateLineForm : Form
{
    private readonly Bitmap _bitmap;
    private readonly Color _color;

    public CreateLineForm(Bitmap bitmap, Color color)
    {
        InitializeComponent();
        _bitmap = bitmap;
        _color = color;
    }

    private void CreateButton_Click(object sender, EventArgs e)
    {
        using var g = Graphics.FromImage(_bitmap);
        var pen = new Pen(_color);
        var x1Cord = Convert.ToInt32(X1TextBox.Text);
        var x2Cord = Convert.ToInt32(X2TextBox.Text);
        var y1Cord = Convert.ToInt32(Y1TextBox.Text);
        var y2Cord = Convert.ToInt32(Y2TextBox.Text);

        g.DrawLine(pen, x1Cord, y1Cord, x2Cord, y2Cord);
        g.Flush();
        this.Close();
    }
}