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

    }
}