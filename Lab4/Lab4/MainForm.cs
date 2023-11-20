namespace Lab4;

public partial class MainForm : Form
{
    private DrawModes _drawMode;
    private int? _trunkHeightForSingleTree;
    private int? _countOfBranchesForSingleTree;
    private int? _countOfTrees;

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
        var trunkPen = new Pen(Color.Brown, height / 10);
        g.FillRectangle(trunkPen.Brush, x - trunkPen.Width / 2, y, trunkPen.Width, height);

        for (var i = branches; i >= 1; i--)
        {
            DrawBranch(g, x, y - (branches - i) * height / 4, height / 2, i * height / 4);
        }
    }

    private void DrawBranch(Graphics g, int x, int y, int length, int width)
    {
        Point[] trianglePoints =
        {
            new(x, y),
            new(x - width / 2, y + length),
            new(x + width / 2, y + length)
        };

        g.FillPolygon(Brushes.Green, trianglePoints);
        g.DrawPolygon(Pens.Black, trianglePoints);
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
                if (_trunkHeightForSingleTree is null)
                {
                    MessageBox.Show("Задайте высоту ствола", "Внимание!");
                    return;
                }

                if (_countOfBranchesForSingleTree is null)
                {
                    MessageBox.Show("Задайте количество ветвей", "Внимание!");
                    return;
                }
                DrawTree(x, y, _trunkHeightForSingleTree.Value, _countOfBranchesForSingleTree.Value);
                break;
            case DrawModes.MultipleTrees:
                if (_countOfTrees is null)
                {
                    MessageBox.Show("Задайте количество ветвей", "Внимание!");
                    return;
                }

                DrawPineForest(x, y, _countOfTrees.Value);
                break;
        }
    }

    private void ClearButton_Click(object sender, EventArgs e)
    {
        MainPictureBox.Image = null;
    }

    private void SaveSingleTreeParams_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(TrunkHeight.Text))
        {
            MessageBox.Show("Задайте высоту ствола", "Внимание!");
            return;
        }

        if (!int.TryParse(TrunkHeight.Text, out var treeHeight))
        {
            MessageBox.Show("Высота ствола должна быть целым числом", "Внимание!");
            return;
        }

        _trunkHeightForSingleTree = treeHeight;

        if (string.IsNullOrEmpty(SingleTreeCountOfBranches.Text))
        {
            MessageBox.Show("Задайте количество ветвей", "Внимание!");
            return;
        }

        if (!int.TryParse(SingleTreeCountOfBranches.Text, out var countOfBranches))
        {
            MessageBox.Show("Высота ствола должна быть целым числом", "Внимание!");
            return;
        }

        _countOfBranchesForSingleTree = countOfBranches;
    }

    private void SaveParametersForMultipleTrees_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(CountOfTreesTextBox.Text))
        {
            MessageBox.Show("Задайте количество деревьев", "Внимание!");
            return;
        }

        if (!int.TryParse(CountOfTreesTextBox.Text, out var countOfTrees))
        {
            MessageBox.Show("Количество деревьев должно быть целым числом", "Внимание!");
            return;
        }

        _countOfTrees = countOfTrees;
    }
}