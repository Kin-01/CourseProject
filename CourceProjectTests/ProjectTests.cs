using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GraphLibrary;
using System.Windows.Forms;

namespace CourceProjectTests
{
    [TestClass]
    public class ProjectTests
    {
        [TestMethod]
        public void Random_Graph_Test()                         // Тест генерации случайного графа
        {
            Random rand = new Random();
            ProgressBar pr = new ProgressBar();    
            Graph test_class = new Graph(pr);
            test_class.MakeRandomGraph((byte)rand.Next(3,256));
        }
        [TestMethod]
        public void Similar_Top_In_Rib_Test()                   // Тест на добавление ребра, в котором начало и конец одна и та же вершина
        {
            Random rand = new Random();
            ProgressBar pr = new ProgressBar();    
            Graph test_class = new Graph(pr);
            test_class.MakeRandomGraph((byte)rand.Next(0, 256));
            test_class.AddFirstTopOfRib(1);
            if (test_class.AddSecondTopOfRib(1))
                throw new Exception();
        }
        [TestMethod]
        public void Minus_Cordinates_Test()                     // Теста на проверку поиска вершины, если даны отрицательные координаты
        {
            Random rand = new Random();
            ProgressBar pr = new ProgressBar();    
            Graph test_class = new Graph(pr);
            test_class.MakeRandomGraph((byte)rand.Next(0, 256));
            test_class.IsThereTop(-1,-1);
        }
        [TestMethod]
        public void Make_FO_Test()                              // Тест на создание FO представления графа
        {
            Random rand = new Random();
            ProgressBar pr = new ProgressBar();     
            Graph test_class = new Graph(pr);
            test_class.MakeRandomGraph((byte)rand.Next(0, 256));
            test_class.MakeFO();
            if(test_class.GraphInFO == null)
                throw new Exception();
        }
        [TestMethod]
        public void Different_Count_Of_Tops_In_Graph_Test()     // Проверка сравнения графов, если кол-во вершин разное
        {
            ProgressBar pr = new ProgressBar();        
            Graph test_class1 = new Graph(pr);
            Graph test_class2 = new Graph(pr);

            test_class1.MakeRandomGraph(20);
            test_class2.MakeRandomGraph(21);
            if(test_class1.IsEqualTo(test_class2))
                throw new Exception();
        }
    }
}
