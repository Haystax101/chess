using System.Globalization;

namespace printedboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if ((e.Column + e.Row) % 2 == 1)
                e.Graphics.FillRectangle(Brushes.SandyBrown, e.CellBounds);
            else
                e.Graphics.FillRectangle(Brushes.White, e.CellBounds);
        }

        private void Button_Click(Button btn)
        {
            if (btn.BackColor == Color.Red)
                btn.BackColor = Color.Transparent;
            else
                btn.BackColor = Color.Red;
        }

        private void a8_Click(object sender, EventArgs e)
        {
            Button_Click(a8);
        }
    }
}