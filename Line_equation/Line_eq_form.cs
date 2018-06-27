using System;
using System.Windows.Forms;

namespace Line_equation
{
    public partial class Line_eq_form : Form
    {
        public double x, y;
        public Line_eq_form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Abc_Block(object sender, KeyPressEventArgs e) //Блокировка ввода всего кроме цифр и -
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8 && e.KeyChar != '-')
                e.Handled = true;
        }

        private void solveButton_Click(object sender, EventArgs e) //Обработка нажатия кнопки "Решить"
        {
            try
            {
                double a1 = Convert.ToDouble(A1.Text);
                double b1 = Convert.ToDouble(B1.Text);
                double c1 = Convert.ToDouble(C1.Text);
                double d1 = Convert.ToDouble(D1.Text);
                double a2 = Convert.ToDouble(A2.Text);
                double b2 = Convert.ToDouble(B2.Text);
                double c2 = Convert.ToDouble(C2.Text);
                double d2 = Convert.ToDouble(D2.Text);

                if ((a1 / a2) == (b1 / b2) && (b1 / b2) == (c1 / c2))//Проверка на параллельность
                    MessageBox.Show(@"Плоскости паралельны");
                else
                {
                    eq1.Text = A1.Text + "x + " + "(" + B1.Text + ")" + "y + " + "(" + C1.Text + ")" + "z +" + "(" + D1.Text + ")" + " = 0";
                    eq2.Text = A2.Text + "x + " + "(" + B2.Text + ")" + "y + " + "(" + C2.Text + ")" + "z +" + "(" + D2.Text + ")" + " = 0";

                    SLAU_solve(a1, b1, d1, a2, b2, d2);//Решаем систему что бы определить таким образом точку M(x0,y0,0)
                    double x0 = x;
                    double y0 = y;
                    SLAU_solve(a1, b1, -(c1 - d1), a2, b2, -(c2 - d2));//Решаем систему что бы определить таким образом точку N(x1,y1,1)
                    double x1 = x;
                    double y1 = y;
                    num1.Text = "x - " + "(" + x0 + ")";
                    num2.Text = "y - " + "(" + y0 + ")";
                    den1.Text = "    " + (x1 - x0);
                    den2.Text = "    " + (y1 - y0);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка ввода", "Сообщение");
            }
        }

        public void SLAU_solve(double a, double b, double c, double d, double e, double f)//Метод решения СЛАУ с двумя неизвестными
        {
            y = (a*f - c*d ) / (a*e - b*d);
            x = (c*e - b*f ) / (a*e - b*d);
        }
    }
}
