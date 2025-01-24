using Tyuiu.DolganovAA.Sprint5.Task6.V12.Lib;
namespace Tyuiu.DolganovAA.Sprint5.Task6.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask6V12.txt");

            Console.WriteLine(ds.LoadFromDataFile(path));

        }
    }
} 