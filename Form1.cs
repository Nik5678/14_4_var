using System.Drawing;
using System.Windows.Forms;
namespace _14_4_вариант
{
    public partial class Form1 : Form
    {
        private int circleCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDraw_Click(object sender, System.EventArgs e)
        {
            if (int.TryParse(txtCount.Text, out int count))
            {
                circleCount = count;
                this.Invalidate(); // Перерисовываем форму
            }
            else
            {
                MessageBox.Show("Введите целое число.");
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (circleCount > 0)
            {
                DrawCircles(e.Graphics, 0, 20, 20, 20);
            }
        }

        private void DrawCircles(Graphics g, int current, int x, int y, int diameter)
        {
            if (current >= circleCount) return; // Базовый случай рекурсии

            using (Pen pen = new Pen(Color.Blue, 2))
            {
                g.DrawEllipse(pen, x, y, diameter, diameter);
            }

            // Рекурсивный вызов с новыми параметрами
            DrawCircles(g, current + 1, x + 10, y + 10, diameter + 20);
        }
    }
}
