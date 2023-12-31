﻿namespace Lab1P4;

public partial class CreateDotForm : Form
{
    private readonly Bitmap _bitmap;
    private readonly Color _color;
    public CreateDotForm(Bitmap bitmap, Color color)
    {
        InitializeComponent();
        _bitmap = bitmap;
        _color = color;
    }

    private void CreateDotButton_Click(object sender, EventArgs e)
    {
        using var g = Graphics.FromImage(_bitmap);
        var brush = new SolidBrush(_color);
        var xCord = Convert.ToInt32(XCordTextBox.Text);
        var yCord = Convert.ToInt32(YCordTextBox.Text);
        var radius = 5;
        g.FillEllipse(brush, xCord - radius, yCord - radius, 2 * radius, 2 * radius);
        g.Flush();
        this.Close();
    }
}