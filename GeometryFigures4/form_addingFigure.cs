// Zaripov Riyaz 220th group, 30.05.22 Figures-4

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GeometryFigures4
{
    public partial class form_addingFigure : Form
    {
        public form_addingFigure()
        {
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            try
            {
                if (panel_circle.Enabled)
                {
                    var coords = tb_circXY.Text.Split(',');
                    var x = int.Parse(coords[0]);
                    var y = int.Parse(coords[1]);
                    var width = int.Parse(tb_circWidth.Text);
                    var height = int.Parse(tb_circHeight.Text);

                    Figures.Add(new Circle(new Point(x, y), width, height));
                }
                else if (panel_rectangle.Enabled)
                {
                    var coords = tb_rctXY.Text.Split(',');
                    var x = int.Parse(coords[0]);
                    var y = int.Parse(coords[1]);
                    var width = int.Parse(tb_rctWidth.Text);
                    var height = int.Parse(tb_rctHeight.Text);

                    Figures.Add(new Rectangle(new Point(x, y), width, height));
                }
                else if (panel_seg.Enabled)
                {
                    var coords1 = tb_segX1Y1.Text.Split(',');
                    var x1 = int.Parse(coords1[0]);
                    var y1 = int.Parse(coords1[1]);

                    var coords2 = tb_segX2Y2.Text.Split(',');
                    var x2 = int.Parse(coords2[0]);
                    var y2 = int.Parse(coords2[1]);

                    Figures.Add(new Segment(new Point(x1, y1), new Point(x2, y2)));
                }
                else if (panel_triangle.Enabled)
                {
                    var coords1 = tb_triangX1Y1.Text.Split(',');
                    var x1 = int.Parse(coords1[0]);
                    var y1 = int.Parse(coords1[1]);

                    var coords2 = tb_triangX2Y2.Text.Split(',');
                    var x2 = int.Parse(coords2[0]);
                    var y2 = int.Parse(coords2[1]);

                    var coords3 = tb_triangX3Y3.Text.Split(',');
                    var x3 = int.Parse(coords3[0]);
                    var y3 = int.Parse(coords3[1]);


                    Figures.Add(new Triangle(new Point(x1, y1), new Point(x2, y2),
                                            new Point(x3, y3)));
                }

                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch(FormatException)
            {
                MessageBox.Show("Данные либо отсутствуют, либо введены некорректно!",
                                "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
