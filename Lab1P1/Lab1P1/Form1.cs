using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1P1
{
    public partial class Form1 : Form
    {
        private string _authorName = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthorNameLabel.Visible = !AuthorNameLabel.Visible;
            AuthorNameTextBox.Visible = !AuthorNameTextBox.Visible;
            SaveAuthorButton.Visible = !SaveAuthorButton.Visible;
        }

        private void AboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Лабораторная работа №1" + Environment.NewLine + "Версия 1.0.0", "Сведения о программе");
        }

        private void SaveAuthorButton_Click(object sender, EventArgs e)
        {
            _authorName = AuthorNameTextBox.Text;
            ChangeAboutAuthorVisibility();
        }

        private void ChangeAboutAuthorVisibility()
        {
            if (string.IsNullOrEmpty(_authorName))
                ProgrammAuthorToolStripMenuItem.Enabled = false;
            else
                ProgrammAuthorToolStripMenuItem.Enabled = true;
        }

        private void ProgrammAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Имя автора: " + _authorName, "Сведения об авторе");
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
