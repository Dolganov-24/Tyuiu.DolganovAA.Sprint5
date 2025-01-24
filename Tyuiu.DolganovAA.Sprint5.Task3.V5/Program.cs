using Tyuiu.DolganovAA.Sprint5.Task3.V5.Lib;
namespace Tyuiu.DolganovAA.Sprint5.Task3.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(2);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан");
        }
    }
}