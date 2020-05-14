using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    public partial class ResultForm : Form
    {
        public ResultForm(uint[] Vector1, uint[] Vector2, Stopwatch sw, bool result)
        {
            InitializeComponent();
            for (int i = 2; i < Vector1.Length; i++)                           // Заполнение таблиц результатами
            {
                ResultView1.Rows.Add(i, Vector1[i]);
                ResultView2.Rows.Add(i, Vector2[i]);
            }
            if (result)
            {
                ResultAndTimeLanel.ForeColor = Color.Green;                    // Если результат положительный
                ResultAndTimeLanel.Text = "✔ Графы равны\n\n";                //
            }
            else
            {
                ResultAndTimeLanel.ForeColor = Color.Red;                      // Если результат отрицательный
                ResultAndTimeLanel.Text = "✖ Графы НЕ равны\n\n";             //
            }
            ResultAndTimeLanel.Text += "Потрачено " + sw.Elapsed.ToString();   // Вывод потраченного времени
        }
    }
}
