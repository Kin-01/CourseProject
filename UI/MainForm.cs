// Changelog:
// 
// fix: При генерации вершин, они теперь не выходят за границы области построения
// fix: Обнуление полосы загрузки после сравнения графов
//
//
//

using GraphLibrary;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Windows.Forms;

namespace UI
{
    public partial class MainForm : Form
    {
        Graph Graph1;                             // Граф 1
        Graph Graph2;                             // Граф 2
        byte mode1 = 1, mode2 = 1;                // 1 -> Установить вершину      
                                                  // 2 -> Установить ребро       
                                                  // 3 -> Удалить вершины и ближние рёбра
        bool is_chosen_first_rib1 = false;        // Выбрана ли первая вершина ребра? (Граф 1)
        bool is_chosen_first_rib2 = false;        // Выбрана ли первая вершина ребра? (Граф 2)

        ResultForm LastResultWindow;
        public MainForm()
        {
            InitializeComponent();
            Graph1 = new Graph(ProgressEqual);
            Graph2 = new Graph(ProgressEqual);
            StatusSaveLoad.Text = "";
            SaveFile.Filter = "Json Files(*.json)|*.json";
            OpenFile.Filter = "Json Files(*.json)|*.json";
        }

        // Универсальные методы и кнопки

        private void IsGraphsEqual(object sender, EventArgs e)
        {
            if ((Graph1.N > 2 && Graph1.Ribs.Count > 1) && (Graph2.N > 2 && Graph2.Ribs.Count > 1))
            {                                        // Сравнивает графы, только если кол-во их вершин начинается с 3...
                LastResultStrip.Enabled = false;     // .. и кол-во рёбрер > 1, иначе либо будут ошибки с отрицательными значениями...
                Graph1.MakeFO();                     // ...либо будут ошибки, потому что мощность 2 для них не существует
                Graph2.MakeFO();
                bool result;                        // Результат сравнения
                Stopwatch sw = new Stopwatch();     // Секундомер времени на сравнение
                sw.Start();
                if (Graph1.IsEqualTo(Graph2))
                {
                    sw.Stop();
                    ResultLabel.ForeColor = Color.Green;
                    ResultLabel.Text = "✔ Графы равны\n\n";
                    result = true;
                }
                else
                {
                    sw.Stop();
                    ResultLabel.ForeColor = Color.Red;
                    ResultLabel.Text = "✖ Графы НЕ равны\n\n";
                    result = false;
                }
                if(Graph1.N == Graph2.N)                // Если кол-во вершин не равно, то графы заведомо не равны, поэтому подробных результатов нет
                {
                    LastResultWindow = new ResultForm(Graph1.VectorOfRibs, Graph2.VectorOfRibs, sw, result);
                    LastResultStrip.Enabled = true;     // Включить вкладку "Last Result"
                }
                ResultStatusTimer.Enabled = true;
            }
        }              // Проверка графов на эквивалентность
        public Graph LoadAll(string path)
        {
            try
            {
                using (FileStream buffer = File.OpenRead(path))
                {
                    DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Graph));
                    return jsonSerializer.ReadObject(buffer) as Graph;
                } 
            }
            catch
            {
                MessageBox.Show("Не удалось загрузить файл графа.\n" +
                                "Возможно он повреждён или удалён.\n" +
                                "Попробуйте снова, или создайте граф заново.", "Ошибка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return null;
            }
        }                                   // Десериализация графа из памяти
        public void SaveAll(Graph graph, string path)
        {
            graph.MakeFO();
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Graph));
            FileStream buffer = File.Create(path);
            jsonSerializer.WriteObject(buffer, graph);
            buffer.Close();
        }                       // Сериализация графа из памяти
        private void LoadSatusOff(object sender, EventArgs e)
        {
            StatusSaveLoad.Text = "";
            LoadInfoTimer.Enabled = false;
        }               // Скрыть сообщение об успешной загрузки графа из памяти
        private void ResultStatusOff(object sender, EventArgs e)
        {
            ResultLabel.Text = "";
            ProgressEqual.Value = 0;
            ResultStatusTimer.Enabled = false;
        }            // Скрыть результат о сравнении графов
        private void ShowAboutWindow(object sender, EventArgs e)
        {
            AboutProgram ap = new AboutProgram();
            ap.ShowDialog();
        }            // Показать окно "О программе"
        private void ShowLastSuccessfulResult(object sender, EventArgs e)
        {
            LastResultWindow.ShowDialog();
        }   // Показать окно подробностей результата срвнения

        // Кнопки и методы для поля 1

        private void Choose_Top1(object sender, EventArgs e)
        {
            mode1 = 1;
            button_top1.BackColor = Color.LawnGreen;
            button_rib1.BackColor = Color.White;
            button_delete1.BackColor = Color.White;
        }                // Выбрать режим "Установить новую вершину"
        private void Choose_Rib1(object sender, EventArgs e)
        {
            mode1 = 2;
            button_top1.BackColor = Color.White;
            button_rib1.BackColor = Color.LawnGreen;
            button_delete1.BackColor = Color.White;
        }                // Выбрать режим "Установить новое ребро"
        private void Choose_Del1(object sender, EventArgs e)
        {
            mode1 = 3;
            button_top1.BackColor = Color.White;
            button_rib1.BackColor = Color.White;
            button_delete1.BackColor = Color.Red;
        }                // Выбрать режим "Удалить вершину и прилежащие рёбра"
        private void Clear_Graph1(object sender, EventArgs e)
        {
            GroupOfGraph1.Text = "";
            Graph1 = new Graph(ProgressEqual);
            Graph_Zone1.Refresh();
            array1.Text = "";
        }               // Очистка поля и памяти от текущего графа 1
        private void SaveGraph1(object sender, EventArgs e)
        {
            SaveFile.FileName = "Graph1.json";
            if (SaveFile.ShowDialog() == DialogResult.Cancel)
                return;
            SaveAll(Graph1, SaveFile.FileName);
        }                 // Сохранить граф 1
        private void LoadGraph1(object sender, EventArgs e)
        {
            OpenFile.FileName = "Graph1.json";
            if (OpenFile.ShowDialog() == DialogResult.Cancel)
                return;
            Graph1 = LoadAll(OpenFile.FileName);
            if (Graph1 == null)
            {
                Graph1 = new Graph(ProgressEqual);
                return;
            }
            Graph_Zone1.Refresh();
            array1.Text = Graph1.ToString();
            GroupOfGraph1.Text = OpenFile.FileName;
            StatusSaveLoad.Text = $"✔ Файл \"{OpenFile.FileName} \" загружен успешно";
            LoadInfoTimer.Enabled = true;
            Graph1.Progress_Bar = ProgressEqual;
        }                 // Загрузить граф 1
        private void Refresh_Graph1(object sender, PaintEventArgs e)
        {
            if (Graph1 == null)
                return;
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < Graph1.Ribs.Count; i++)
                g.DrawLine(pen, Graph1.Ribs[i].X1, Graph1.Ribs[i].Y1, Graph1.Ribs[i].X2, Graph1.Ribs[i].Y2);
            for (int i = 0; i < Graph1.Tops.Count; i++)
            {
                if (Graph1.Tops[i].chosen)
                {
                    Pen help_pen = new Pen(Color.Yellow, 3);
                    g.DrawEllipse(help_pen, Graph1.Tops[i].X - 1, Graph1.Tops[i].Y - 1, 27, 27);
                    help_pen = new Pen(Color.Black, 2);
                    g.DrawEllipse(help_pen, Graph1.Tops[i].X - 3, Graph1.Tops[i].Y - 3, 30, 30);
                }
                g.FillEllipse(Brushes.Black, Graph1.Tops[i].X, Graph1.Tops[i].Y, 24, 24);
                g.DrawString(Graph1.Tops[i].name.ToString(), button_top1.Font, Brushes.White, Graph1.Tops[i].X + 6, Graph1.Tops[i].Y + 5);
            }
        }        // Событие "Paint" для графа 1
        private void DoAction1(object sender, MouseEventArgs e)
        {
            if (mode1 == 1 && Graph1.Tops.Count < 31)   // Установить вершину (до 30 штук)
            {
                if (Graph1.IsThereTop(e.X, e.Y) == -1)
                {
                    Graph1.AddTop(e.X, e.Y);           // Добавить новую вершину
                    Graph_Zone1.Refresh();
                }
            }
            else if (mode1 == 2 && Graph1.Ribs.Count < 46)      // Установить ребро
            {
                if (!is_chosen_first_rib1)   // Если не выбрано превой вершины
                {
                    int top_name = Graph1.IsThereTop(e.X, e.Y);
                    if (top_name != -1)
                    {
                        Graph1.AddFirstTopOfRib(top_name);
                        is_chosen_first_rib1 = true;
                    }
                }
                else
                {
                    int top_name = Graph1.IsThereTop(e.X, e.Y);
                    if (top_name != -1)
                    {
                        Graph1.AddSecondTopOfRib(top_name);
                        is_chosen_first_rib1 = false;
                    }
                }
                Graph_Zone1.Refresh();
            }
            else if (mode1 == 3)    // Удалить вершину и ближние рёбра
            {
                int top_name = Graph1.IsThereTop(e.X, e.Y);
                if (top_name != -1)
                    Graph1.DeleteTop(top_name);
                if (Graph1.Tops.Count == 0)
                    array1.Text = "";
                Graph_Zone1.Refresh();
            }
            array1.Text = Graph1.ToString();    // Вывести FO для графа 1 на экран
        }             // Совершить действие относительно выбранного режима (Граф 1)
        private void Random_Graph1(object sender, EventArgs e)
        {
            GroupOfGraph1.Text = "";
            Graph1 = new Graph(ProgressEqual);
            Graph1.MakeRandomGraph((byte)numericrandom1.Value);
            array1.Text = Graph1.ToString();    // Вывести FO для графа 1 на экран
            Graph_Zone1.Refresh();
        }              // Случайная генерация графа 1

        // Кнопки и методы для поля 2

        private void Choose_Top2(object sender, EventArgs e)
        {
            mode2 = 1;
            button_top2.BackColor = Color.LawnGreen;
            button_rib2.BackColor = Color.White;
            button_delete2.BackColor = Color.White;
        }               // Выбрать режим "Установить новую вершину"
        private void Choose_Rib2(object sender, EventArgs e)
        {
            mode2 = 2;
            button_top2.BackColor = Color.White;
            button_rib2.BackColor = Color.LawnGreen;
            button_delete2.BackColor = Color.White;
        }               // Выбрать режим "Установить новое ребро"
        private void Choose_Del2(object sender, EventArgs e)
        {
            mode2 = 3;
            button_top2.BackColor = Color.White;
            button_rib2.BackColor = Color.White;
            button_delete2.BackColor = Color.Red;
        }               // Выбрать режим "Удалить вершину и прилежащие рёбра"
        private void Clear_Graph2(object sender, EventArgs e)
        {
            GroupOfGraph2.Text = "";
            Graph2 = new Graph(ProgressEqual);
            Graph_Zone2.Refresh();
            array2.Text = "";
        }              // Очистка поля и памяти от текущего графа 2
        private void SaveGraph2(object sender, EventArgs e)
        {
            SaveFile.FileName = "Graph2.json";
            if (SaveFile.ShowDialog() == DialogResult.Cancel)
                return;
            SaveAll(Graph2, SaveFile.FileName);
        }                // Сохранить граф 2
        private void LoadGraph2(object sender, EventArgs e)
        {
            OpenFile.FileName = "Graph2.json";
            if (OpenFile.ShowDialog() == DialogResult.Cancel)
                return;
            Graph2 = LoadAll(OpenFile.FileName);
            if (Graph2 == null)
            {
                Graph2 = new Graph(ProgressEqual);
                return;
            }
            Graph_Zone2.Refresh();
            array2.Text = Graph2.ToString();
            GroupOfGraph2.Text = OpenFile.FileName;
            StatusSaveLoad.Text = $"✔ Файл \"{OpenFile.FileName} \" загружен успешно";
            LoadInfoTimer.Enabled = true;
            Graph2.Progress_Bar = ProgressEqual;
        }                // Загрузить граф 2
        private void Refresh_Graph2(object sender, PaintEventArgs e)
        {
            if (Graph2 == null)
                return;
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < Graph2.Ribs.Count; i++)
                g.DrawLine(pen, Graph2.Ribs[i].X1, Graph2.Ribs[i].Y1, Graph2.Ribs[i].X2, Graph2.Ribs[i].Y2);
            for (int i = 0; i < Graph2.Tops.Count; i++)
            {
                if (Graph2.Tops[i].chosen)
                {
                    Pen help_pen = new Pen(Color.Yellow, 3);
                    g.DrawEllipse(help_pen, Graph2.Tops[i].X - 1, Graph2.Tops[i].Y - 1, 27, 27);
                    help_pen = new Pen(Color.Black, 2);
                    g.DrawEllipse(help_pen, Graph2.Tops[i].X - 3, Graph2.Tops[i].Y - 3, 30, 30);
                }
                g.FillEllipse(Brushes.Black, Graph2.Tops[i].X, Graph2.Tops[i].Y, 24, 24);
                g.DrawString(Graph2.Tops[i].name.ToString(), button_top2.Font, Brushes.White, Graph2.Tops[i].X + 6, Graph2.Tops[i].Y + 5);
            }
        }       // Событие "Paint" для графа 2
        private void DoAction2(object sender, MouseEventArgs e)
        {
            if (mode2 == 1 && Graph2.Tops.Count < 31)   // Установить вершину (до 10 штук)
            {
                if (Graph2.IsThereTop(e.X, e.Y) == -1)
                {
                    Graph2.AddTop(e.X, e.Y);           // Добавить новую вершину
                    Graph_Zone2.Refresh();
                }
            }
            else if (mode2 == 2 && Graph2.Ribs.Count < 46)      // Установить ребро
            {
                if (!is_chosen_first_rib2)   // Если не выбрано превой вершины
                {
                    int top_name = Graph2.IsThereTop(e.X, e.Y);
                    if (top_name != -1)
                    {
                        Graph2.AddFirstTopOfRib(top_name);
                        is_chosen_first_rib2 = true;
                    }
                }
                else
                {
                    int top_name = Graph2.IsThereTop(e.X, e.Y);
                    if (top_name != -1)
                    {
                        Graph2.AddSecondTopOfRib(top_name);
                        is_chosen_first_rib2 = false;
                    }
                }
                Graph_Zone2.Refresh();
            }
            else if (mode2 == 3)    // Удалить вершину и ближние рёбра
            {
                int top_name = Graph2.IsThereTop(e.X, e.Y);
                if (top_name != -1)
                    Graph2.DeleteTop(top_name);
                if (Graph2.Tops.Count == 0)
                    array2.Text = "";
                Graph_Zone2.Refresh();
            }
            array2.Text = Graph2.ToString();        // Вывести FO для графа 2 на экран
        }            // Совершить действие относительно выбранного режима (Граф 2)
        private void Random_Graph2(object sender, EventArgs e)
        {
            GroupOfGraph2.Text = "";
            Graph2 = new Graph(ProgressEqual);
            Graph2.MakeRandomGraph((byte)numericrandom2.Value);
            array2.Text = Graph2.ToString();        // Вывести FO для графа 2 на экран
            Graph_Zone2.Refresh();
        }             // Случайная генерация графа 2
    }
}
