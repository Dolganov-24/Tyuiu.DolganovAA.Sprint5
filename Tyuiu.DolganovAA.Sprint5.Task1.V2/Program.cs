using Tyuiu.DolganovAA.Sprint5.Task1.V2.Lib;
namespace Tyuiu.DolganovAA.Sprint5.Task1.V2

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();


        Console.Title = "Спринт #5 | Выполнил: Долганов А. А. | СМАРТБ-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                        *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #2                                                              *");
        Console.WriteLine("* Выполнил: Долганов Александр Анатольевич |  СМАРТБ-24-1                 *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");


        int startValue = -5;
        int stopValue = 5;


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        string res = ds.SaveToFileTextData(startValue, stopValue);
        Console.WriteLine("Файл " + res);
        Console.WriteLine("Cоздан");
        Console.ReadKey();
    }
}