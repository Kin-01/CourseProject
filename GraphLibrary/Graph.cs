using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace GraphLibrary
{
    [Serializable]
    public class Graph
    {
        public List<int> GraphInFO;                         // Граф в представлении FO
        byte Top_Namer;                                     // Номер порядковый номер вершин
        public byte N;                                      // Кол-во вершин
        public List<Top> Tops;                              // Коллекция вершин
        public List<Rib> Ribs;                              // Коллекция рёбер
        
        [NonSerialized]
        int X_firstpointrib;                                // Кордината X начала ребра
        [NonSerialized]
        int Y_firstpointrib;                                // Кордината Y начала ребра
        [NonSerialized]
        int name_firsttopinrib;                             // Имя первой крайной вершины в ребре  
        [NonSerialized]
        int firsttop_index;                                 // Индекс первой вершины ребра
        [NonSerialized]
        public uint[] VectorOfRibs;                         // Вектор подграфов графа
        [NonSerialized]
        public ProgressBar Progress_Bar;                    // Визуализация процесса сравнения графов

        public Graph(ProgressBar progress)
        {
            Progress_Bar = progress;
            Tops = new List<Top>();
            Ribs = new List<Rib>();
            Top_Namer = 1;
        }

        // Методы по обработке графа

        public void MakeFO()
        {
            GraphInFO = new List<int>();
            if (Tops.Count > 1 && Ribs.Count > 0)
            {
                for (int a = 0; a < Tops.Count; a++)
                {
                    for (int b = 0; b < Tops[a].Connected.Count; b++)
                        GraphInFO.Add(Tops[a].Connected[b]);
                    if (a != Tops.Count - 1)
                        GraphInFO.Add(0);
                }
            }
        }                             // Делает граф в представлении FO
        public void AddTop(int X, int Y)
        {
            Tops.Add(new Top(X - 12, Y - 12, Top_Namer++));
            N++;
        }                 // Добавляет новую вершину
        public void AddFirstTopOfRib(int name)
        {
            name_firsttopinrib = name;
            firsttop_index = IndexOfTop(name);
            X_firstpointrib = Tops[firsttop_index].X + 12;
            Y_firstpointrib = Tops[firsttop_index].Y + 12;
            Tops[firsttop_index].chosen = true;
        }           // Сохранить в памяти первую верину в ребре
        public bool AddSecondTopOfRib(int name)
        {
            if (name_firsttopinrib != name)
            {
                int secondindex = IndexOfTop(name);
                Rib newrib = new Rib(name_firsttopinrib, name, X_firstpointrib, Y_firstpointrib, Tops[secondindex].X + 12, Tops[secondindex].Y + 12);
                if (!IsExist(newrib))
                {
                    Ribs.Add(newrib);
                    Tops[secondindex].Connected.Add(name_firsttopinrib);
                    Tops[firsttop_index].Connected.Add(name);
                }
                Tops[firsttop_index].chosen = false;
                return true;
            }
            else
            {
                Tops[firsttop_index].chosen = false;
                return false;
            }
        }          // Добавить ребро в память, на основе первой вершины в памяти и второй вершины (вторая вершина - аргумент)
        public void DeleteTop(int name)
        {
            Tops.RemoveAt(IndexOfTop(name));            // Удалить вершину
            for (int i = 0; i < Ribs.Count; i++)
                if (Ribs[i].top_from == name || Ribs[i].top_to == name)
                {
                    Ribs.RemoveAt(i);
                    i--;
                }
            for (int i = 0; i < Tops.Count; i++)
                if (Tops[i].Connected.Contains(name))
                    Tops[i].Connected.Remove(name);
            if (Tops.Count > 0)
                Top_Namer = (byte)(Tops[Tops.Count - 1].name + 1);
            else
                Top_Namer = 1;
            N--;
        }                  // Удаляет выбранную вершины и все подключенные рёбра
        public bool IsEqualTo(Graph second_graph)
        {
            // Переопределение графа в виде FO в удобный для обработки вид
            if (N != second_graph.N)  // Если кол-во вершин не совпадает, то графы точно не равны
            {
                Progress_Bar.Value = Progress_Bar.Maximum;
                return false;
            }

            Progress_Bar.Value = 0;                                                    // Обнуление прогрессбара
            Progress_Bar.Maximum = (N * (N - 3)) * 2 + N + 1;                          // Нахождение максимального значение в прогресс баре
            Progress_Bar.Step = 1;                                                     // Шаг для прогрессбара

            List<int>[] ListOfHightsCurr = new List<int>[N + 1];   // Массив коллекций где номеру вершини соответвуют вершини, с которыми она свзяна ребром
            List<int>[] ListOfHightsArg = new List<int>[N + 1];    // Массив коллекций где номеру вершини соответвуют вершини, с которыми она свзяна ребром (аргумент)

            byte index_in_FO1 = 0;  // Индекс указателя в представлении FO
            byte index_in_FO2 = 0;  // Индекс указателя в представлении FO (аргумент)

            for (byte name_of_top = 1; name_of_top <= N; name_of_top++, index_in_FO1++, index_in_FO2++)
            {
                ListOfHightsCurr[name_of_top] = new List<int>();   // Инициализация коллекций под номером вершины
                ListOfHightsArg[name_of_top] = new List<int>();    // Инициализация коллекций под номером вершины (аргумент)

                while (index_in_FO1 != GraphInFO.Count && GraphInFO[index_in_FO1] != 0)
                {
                    ListOfHightsCurr[name_of_top].Add(GraphInFO[index_in_FO1]);
                    index_in_FO1++;
                }
                while (index_in_FO2 != second_graph.GraphInFO.Count && second_graph.GraphInFO[index_in_FO2] != 0)
                {
                    ListOfHightsArg[name_of_top].Add(second_graph.GraphInFO[index_in_FO2]);
                    index_in_FO2++;
                }
                Progress_Bar.PerformStep();
            }

            List<byte> Used_Tops = new List<byte>();
            uint count = 0;                                             // Кол-во подграфов
            byte count_of_cycles = 0;                                   // Количество рекурсивно вызваных на данный момент методов

            VectorOfRibs = new uint[N];                                 // Вектор подграфов графа
            second_graph.VectorOfRibs = new uint[N];                    // Вектор подграфов графа (аршумент)

            for (uint max_power = 2; max_power <= N - 1; max_power++)    // Проверяем мощность от 2 до количества вершин
                for (byte last_top = 1; last_top <= N; last_top++)      // Начальная вершина для подграфа
                {
                    SearchLastTop(ref VectorOfRibs, ref count_of_cycles, ref Used_Tops, last_top, ref ListOfHightsCurr, ref count, max_power);
                    Progress_Bar.PerformStep();
                }
            for (byte max_power = 2; max_power <= N - 1; max_power++)    // Проверяем мощность от 2 до количества вершин
                for (byte last_top = 1; last_top <= N; last_top++)      // Начальная вершина для подграфа
                {
                    SearchLastTop(ref second_graph.VectorOfRibs, ref count_of_cycles, ref Used_Tops, last_top, ref ListOfHightsArg, ref count, max_power);
                    Progress_Bar.PerformStep();
                }

            if (IsMatrixesAreEqual(VectorOfRibs, second_graph.VectorOfRibs))
            {
                Progress_Bar.PerformStep();
                return true;
            }
            else
            {
                Progress_Bar.PerformStep();
                return false;
            }

        }        // Сравнивает графы, возвращает 'true' если они равны, и 'false' если нет
        public bool MakeRandomGraph(byte hights)
        {
            if (hights < 3)
                return false;
            Random rand = new Random();
            for (int i = 0; i < hights; i++)
                AddTop(rand.Next(12,389), rand.Next(12,389));      // Генерация вершин и их кординат так, что бы они не забегали за границы полей
            for (int i = 0; i < hights + hights * 0.5; i++)
            {
                int random_first = rand.Next(1, Tops.Count + 1);   // Генерация первой вершины в ребре
                AddFirstTopOfRib(random_first);
                int random_second = -1;
                while ((random_first == random_second) || random_second == -1)           // Генерация второй вершины в ребре
                    random_second = rand.Next(1, Tops.Count + 1);  //
                AddSecondTopOfRib(random_second);
            }
            return true;
        }         // Создание случайного графа

        // Вспомогательные методы

        public int IsThereTop(int X, int Y)
        {
            for (int i = 0; i < Tops.Count; i++)
                if (Math.Sqrt((X - Tops[i].X) * (X - Tops[i].X) + (Y - Tops[i].Y) * (Y - Tops[i].Y)) <= 24)     // Если ты нажал на вершину, которая уже существует
                    return Tops[i].name;
            return -1;
        }              // Возвращает индекс вершины, нажатой мышью, или -1, если в этом месте нет вершин
        public override string ToString()
        {
            string str = "";
            for (int a = 0; a < Tops.Count; a++)
            {
                Tops[a].Connected.Sort();
                for (int b = 0; b < Tops[a].Connected.Count; b++)
                    str += Tops[a].Connected[b] + " ";
                if (a != Tops.Count - 1)
                    str += ", ";
            }
            return str;
        }                // Перегрузка метода ToString() для вывода грава в виде FO на экран

        // Служебные методы

        private int IndexOfTop(int name)
        {
            for (int i = 0; i < Tops.Count; i++)
                if (Tops[i].name == name)
                    return i;
            return -1;
        }                  // Ищет индекс вершины в коллекции по её индексу
        private bool IsExist(Rib newrib)
        {
            for (int i = 0; i < Ribs.Count; i++)
                if (Ribs[i].top_from == newrib.top_from && Ribs[i].top_to == newrib.top_to && Ribs[i].X1 == newrib.X1 && Ribs[i].X2 == newrib.X2 && Ribs[i].Y1 == newrib.Y1 && Ribs[i].Y2 == newrib.Y2 && Ribs[i].lenght == newrib.lenght || Ribs[i].top_from == newrib.top_to && Ribs[i].top_to == newrib.top_from && Ribs[i].X1 == newrib.X2 && Ribs[i].X2 == newrib.X1 && Ribs[i].Y1 == newrib.Y2 && Ribs[i].Y2 == newrib.Y1 && Ribs[i].lenght == newrib.lenght)
                    return true;
            return false;
        }                  // Проверка на существование уже такого ребра

        // Рекурсивный цикл для поиска подграфов
        private void SearchLastTop(ref uint[] VectorOfRibs, ref byte count_of_cycles, ref List<byte> Used_Tops, byte pre_top, ref List<int>[] Tops_In_Fo, ref uint count, uint power)
        {
            count_of_cycles++;                                 // Увеличение вызванного на данный момент метода "SearchLastTop"
            Used_Tops.Add(pre_top);                            // "pre_top" вершина -> использована
            for (byte new_top = 1; new_top <= N; new_top++)
            {
                if (Tops_In_Fo[new_top].Contains(pre_top) && !Used_Tops.Contains(new_top))      // Если вершини "new_top" и "pre_top" имеют соединяющее ребро, то...
                {
                    if (count_of_cycles < power)               // Рекурсивный вызов функции "SearchLastTop" пока их число меньше текущей требуемой мощности
                    {
                        pre_top = new_top;                     // Найденная вершина становится "pre_top", и ищется следующая "new_top" вершина
                        SearchLastTop(ref VectorOfRibs, ref count_of_cycles, ref Used_Tops, pre_top, ref Tops_In_Fo, ref count, power);
                        pre_top = Used_Tops[Used_Tops.Count - 1];
                    }
                    else
                    {
                        Used_Tops.Add(new_top);                 // "new_top" вершина -> использована
                        VectorOfRibs[power]++;
                    }
                }
            }
            count_of_cycles--;
            Used_Tops = CopyCollection(Used_Tops, count_of_cycles);                // Из колеекции "Used_Tops" оставляем первые "count_of_cycles" элементов
        }   
        private List<byte> CopyCollection(List<byte> Collection, uint length)
        {
            List<byte> BufferCollection = new List<byte>();
            for (int i = 0; i < length; i++)
                BufferCollection.Add(Collection[i]);
            return BufferCollection;
        }   // Возвращает подстроку длиной "lenght" первых символов из коллекции "Collection" 
        private bool IsMatrixesAreEqual(uint[] Matrix1, uint[] Matrix2)
        {
            for (uint a = 0; a < N; a++)
                if (Matrix1[a] != Matrix2[a])
                    return false;
            return true;
        }         // Сравнивает две матрицы

        // Служебные классы

        [DataContract]
        public class Rib
        {
            public Rib(int top1, int top2, int x1, int y1, int x2, int y2)
            {
                X1 = x1;
                Y1 = y1;
                X2 = x2;
                Y2 = y2;
                top_from = top1;
                top_to = top2;
                LengthBetweenDots();
            }
            [DataMember]
            public int X1, X2, Y1, Y2, top_from, top_to;
            [DataMember]
            public double lenght;
            private void LengthBetweenDots()
            {
                lenght = Math.Sqrt((X1 - X2) * (X1 - X2) + (Y1 - Y2) * (Y1 - Y2));
            }
        }      // Обьект "Ребро"
        [DataContract]
        public class Top
        {
            public Top(int x, int y, int num)
            {
                X = x;
                Y = y;
                this.name = num;
            }
            [DataMember]
            public int X, Y, name;
            [DataMember]
            public bool chosen = false;
            [DataMember]
            public List<int> Connected = new List<int>();
        }      // Обьект "Вершина"
    }
}
