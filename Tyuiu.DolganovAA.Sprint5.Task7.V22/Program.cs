﻿using Tyuiu.DolganovAA.Sprint5.Task7.V22.Lib;
namespace Tyuiu.DolganovAA.Sprint5.Task7.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнила: Долганов А. А. | СМАРТб-24-2";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнила: Долганов Александр Анатольевич | СМАРТб-24-2                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл С:/DataSprint5/InPutDataFileTask7V22.txt (файл взять из архива *");
            Console.WriteLine("* согласно вашему варианту. Создать папку в ручную С:/DataSprint5/ и      *");
            Console.WriteLine("* скопировать в неё файл) в котором есть набор символьных данных.Заменить *");
            Console.WriteLine("* все знаки препинания на #.Полученный результат сохранить в файл         *");
            Console.WriteLine("* OutPutDataFileTask7V22.txt.                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            string path = $@"{Directory.GetCurrentDirectory()}\InPutDataFileTask7V22.txt";
            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask7.txt";

            Console.WriteLine(" Данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(" Находится в файле: ");
            pathSaveFile = ds.LoadDataAndSave(path);
            Console.WriteLine(pathSaveFile);

        }
    }
}