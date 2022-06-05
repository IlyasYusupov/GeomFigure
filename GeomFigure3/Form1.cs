using System.Drawing;

namespace GeomFigure3
{
    public partial class GraphicEditor : Form
    {
        Figures fig;
        Bitmap bmp;
        int width;
        public GraphicEditor()
        {
            InitializeComponent();
            fig = new Figures();
            bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
        }

        private void menuItemSave_Click(object sender, EventArgs e)
        {
            if (dlgSave.ShowDialog() == DialogResult.OK)
            {
                string fname = dlgSave.FileName;
                fig.Save(fname);
                MessageBox.Show("Файл сохранен");
            }
            else
            {
                return;
            }
        }

        private void menuItemLoad_Click(object sender, EventArgs e)
        {
            if (dlgLoad.ShowDialog() == DialogResult.OK)
            {
                string fname = dlgLoad.FileName;
                fig.Load(fname);
                using (Graphics graph = Graphics.FromImage(bmp))
                {
                    fig.Draw(graph);
                }
                pbPicture.Image = bmp;
                MessageBox.Show("Файл загружен");
            }
            else
            {
                return;
            }
        }
        public string info;
        private void cbFigures_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbFigures.Text)
            {
                case "Circle":
                    panelCircle.Visible = true;
                    panelFilledFigure.Visible = true;
                    panelLine.Visible = false;
                    panelRectangle.Visible = false;
                    panelTriangle.Visible = false;
                    tbCircleX.Clear();
                    tbCircleY.Clear();
                    tbRadius.Clear();
                    panelFigureColor.BackColor = Color.White;
                    panelStrokColor.BackColor = Color.Black;
                    lbStrokeWidth.Text = String.Format("Select stroke width");
                    trbStrokeWidth.Value = 0;
                    break;

                case "Line":
                    panelLine.Visible = true;
                    panelFilledFigure.Visible = true;
                    panelCircle.Visible = false;
                    panelRectangle.Visible = false;
                    panelTriangle.Visible = false;
                    tbLineX.Clear();
                    tbLineY.Clear();
                    tbLineX2.Clear();
                    tbLineY2.Clear();
                    panelFigureColor.BackColor = Color.White;
                    panelStrokColor.BackColor = Color.Black;
                    lbStrokeWidth.Text = String.Format("Select stroke width");
                    trbStrokeWidth.Value = 0;
                    break;
                case "Rectangle":
                    panelRectangle.Visible = true;
                    panelFilledFigure.Visible = true;
                    panelTriangle.Visible = false;
                    panelCircle.Visible = false;
                    panelLine.Visible = false;
                    tbRectangleX.Clear();
                    tbRectangleY.Clear();
                    tbHight.Clear();
                    tbWidth.Clear();
                    panelFigureColor.BackColor = Color.White;
                    panelStrokColor.BackColor = Color.Black;
                    lbStrokeWidth.Text = String.Format("Select stroke width");
                    trbStrokeWidth.Value = 0;
                    break;
                case "Triangle":
                    panelTriangle.Visible = true;
                    panelFilledFigure.Visible = true;
                    panelCircle.Visible = false;
                    panelLine.Visible = false;
                    panelRectangle.Visible = false;
                    tbTriangleX.Clear();
                    tbTriangleY.Clear();
                    tbTriangleX2.Clear();
                    tbTriangleY2.Clear();
                    tbTriangleX3.Clear();
                    tbTriangleY3.Clear();
                    panelFigureColor.BackColor = Color.White;
                    panelStrokColor.BackColor = Color.Black;
                    lbStrokeWidth.Text = String.Format("Select stroke width");
                    trbStrokeWidth.Value = 0;
                    break;
            }
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            try
            {
                switch (cbFigures.Text)
                {
                    case "Circle":
                        using (Graphics graph = Graphics.FromImage(bmp))
                        { 
                            Circle circle = new Circle(new BasePoint(Int32.Parse(tbCircleX.Text), Int32.Parse(tbCircleY.Text)), Int32.Parse(tbRadius.Text), 
                                                       new SolidBrush(panelFigureColor.BackColor), new Pen(panelStrokColor.BackColor, width), width);
                            fig.Add(circle);
                            circle.Draw(graph);
                        }
                        pbPicture.Image = bmp;
                        break;

                    case "Line":
                        using (Graphics g = Graphics.FromImage(bmp))
                        {                   
                            Line line = new Line(Int32.Parse(tbLineX.Text), Int32.Parse(tbLineY.Text), Int32.Parse(tbLineX2.Text), Int32.Parse(tbLineY2.Text), 
                                                 new Pen(panelStrokColor.BackColor, width), width);
                            fig.Add(line);
                            line.Draw(g);
                        }
                        pbPicture.Image = bmp;
                        break;

                    case "Rectangle":
                        using (Graphics g = Graphics.FromImage(bmp))
                        {
                            Rectangle rectangle = new Rectangle(new BasePoint(Int32.Parse(tbRectangleX.Text), Int32.Parse(tbRectangleY.Text)), Int32.Parse(tbHight.Text), Int32.Parse(tbWidth.Text),
                                                                new SolidBrush(panelFigureColor.BackColor), new Pen(panelStrokColor.BackColor, width), width);
                            fig.Add(rectangle);
                            rectangle.Draw(g);
                        }
                        pbPicture.Image = bmp;
                        break;

                    case "Triangle":
                        using (Graphics g = Graphics.FromImage(bmp))
                        {
                            Triangle triangle = new Triangle(Int32.Parse(tbTriangleX.Text), Int32.Parse(tbTriangleY.Text), Int32.Parse(tbTriangleX2.Text), Int32.Parse(tbTriangleY2.Text),
                                                             Int32.Parse(tbTriangleX3.Text), Int32.Parse(tbTriangleY3.Text), new SolidBrush(panelFigureColor.BackColor), new Pen(panelStrokColor.BackColor, width), width);
                            fig.Add(triangle);
                            triangle.Draw(g);
                        }
                        pbPicture.Image = bmp;
                        break;
                }
            }
            catch
            { }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            pbPicture.Image = null;
            bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            fig.page.Clear();
        }

        private void tbInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!double.TryParse(tbCircleX.Text + e.KeyChar.ToString(), out double a) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void panelFigureColor_MouseClick(object sender, MouseEventArgs e)
        {
            if (cdlgFilled.ShowDialog() == DialogResult.Cancel)
            {
                panelFigureColor.BackColor = Color.White;
                return;
            }
            panelFigureColor.BackColor = cdlgFilled.Color;
        }
        private void panelStrokColor_MouseClick(object sender, MouseEventArgs e)
        {
            if (cdlgFilled.ShowDialog() == DialogResult.Cancel)
            {
                panelStrokColor.BackColor = Color.Black;
                return;
            }
            panelStrokColor.BackColor = cdlgFilled.Color;
        }

        private void trbStrokeWidth_Scroll(object sender, EventArgs e)
        {
            lbStrokeWidth.Text = String.Format("Current value: {0}", trbStrokeWidth.Value);
            width = trbStrokeWidth.Value;
        }
    }
}