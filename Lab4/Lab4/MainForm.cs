namespace Lab4;

public partial class MainForm : Form
{
    private DrawModes _drawMode;

    public MainForm()
    {
        InitializeComponent();
    }

    private void DrawTree(int x, int y, int height, int branches)
    {
        var g = MainPictureBox.CreateGraphics();
        DrawTreeAt(g, x, y, height, branches);
    }

    private void DrawTreeAt(Graphics g, int x, int y, int height, int branches)
    {
        Pen trunkPen = new Pen(Color.Brown, height / 10);
        g.FillRectangle(trunkPen.Brush, x - trunkPen.Width / 2, y, trunkPen.Width, height);

        for (int i = 1; i <= branches; i++)
        {
            DrawBranch(g, x, y - (branches - i) * height / 4, height / 2, i * height / 4);
        }
    }

    private void DrawBranch(Graphics g, int x, int y, int length, int width)
    {
        Point[] trianglePoints =
        {
            new Point(x, y),
            new Point(x - width / 2, y + length),
            new Point(x + width / 2, y + length)
        };

        g.FillPolygon(Brushes.Green, trianglePoints);
    }

    private void DrawPineForest(int x, int y, int treeCount)
    {
        var random = new Random();

        for (var i = 0; i < treeCount; i++)
        {
            var treeX = x + random.Next(-50, 50);
            var treeY = y + random.Next(-50, 50);
            var treeHeight = random.Next(50, 150);

            DrawTree(treeX, treeY, treeHeight, random.Next(3, 6));
        }
    }

    private void SingleTreeRadioButton_CheckedChanged(object sender, EventArgs e)
    {
        _drawMode = SingleTreeRadioButton.Checked ? DrawModes.SingleTree : DrawModes.MultipleTrees;
    }

    private void MultipleTreeRadioButton_CheckedChanged(object sender, EventArgs e)
    {
        _drawMode = MultipleTreeRadioButton.Checked ? DrawModes.MultipleTrees : DrawModes.SingleTree;
    }

    private void MainPictureBox_Click(object sender, EventArgs e)
    {
        var x = ((MouseEventArgs)e).X;
        var y = ((MouseEventArgs)e).Y;

        switch (_drawMode)
        {
            case DrawModes.SingleTree:
                DrawTree(x, y, 50, 2);
                break;
            case DrawModes.MultipleTrees:
                DrawPineForest(x, y, 1);
                break;
        }
    }

}