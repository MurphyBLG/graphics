using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1P4
{
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
            _bitmap.SetPixel(Convert.ToInt32(XCordTextBox.Text), Convert.ToInt32(YCordTextBox.Text), _color);
            g.Flush();
        }
    }
}
