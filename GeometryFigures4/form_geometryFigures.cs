// Zaripov Riyaz 220th group, 24.05.22 Figures-3

using System;
using System.Drawing;
using System.Windows.Forms;

namespace GeometryFigures4
{
    public partial class form_geometryFigures : Form
    {
        public form_geometryFigures()
        {
            InitializeComponent();
        }

        Color colorOfPen = Color.Black;
        int thicknessOfPen = 1;

        private void btn_addFigure_Click(object sender, EventArgs e)
        {
            form_addingFigure form = new form_addingFigure();

            switch (cb_chooseFigure.Text)
            {
                case "Triangle":
                    form.panel_triangle.Enabled = true;
                    break;

                case "Rectangle":
                    form.panel_rectangle.Enabled = true;
                    break;

                case "Segment":
                    form.panel_seg.Enabled = true;
                    break;

                case "Circle":
                    form.panel_circle.Enabled = true;
                    break;

                default:
                    MessageBox.Show("Выберите фигуру из предложенных в списке!",
                                    "Предупреждение", MessageBoxButtons.OK, 
                                    MessageBoxIcon.Warning);
                    return;
            }

            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                var paper = panel_FigurePaper.CreateGraphics();

                Figures.LastFigure().Draw(paper, colorOfPen, thicknessOfPen);
            }
        }
        private void saveFiguresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Figures.Save(saveFileDialog.FileName);
            }
        }

        private void loadFiguresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loadFileDialog.ShowDialog() == DialogResult.OK)
            {
                Figures.Load(loadFileDialog.FileName);

                var paper = panel_FigurePaper.CreateGraphics();
                paper.Clear(Color.White);

                Figures.Draw(paper);
            }
        }

        private void clearFiguresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Figures.Clear();
            var paper = panel_FigurePaper.CreateGraphics();
            paper.Clear(Color.White);
        }

        private void panel_FigurePaper_Paint(object sender, PaintEventArgs e)
        {
            var paper = panel_FigurePaper.CreateGraphics();
            Figures.Draw(paper);
        }

        private void btn_chooseColorOfPen_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            colorOfPen = colorDialog.Color;
        }

        private void mtb_ThicknessOfPen_Leave(object sender, EventArgs e)
        {
            thicknessOfPen = int.Parse(mtb_ThicknessOfPen.Text);
        }
    }
}
