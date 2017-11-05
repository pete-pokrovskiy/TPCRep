using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPC.ConsoleTasks
{
    class Program
    {
        static void Main(string[] args)
        {

            if(args == null || (args.Length < 2))
                throw new Exception("Неверно указаны аргументы!");

            string path = args[0];

            if(string.IsNullOrEmpty(path))
                throw new Exception("Не задан путь к изображениям!");
            
            string nameMask = args[1];

            if(string.IsNullOrEmpty(nameMask))
                throw new Exception("Не указана маска имени файла!");

            AdjustFileNameService service = new AdjustFileNameService();

            service.AdjustName(path, nameMask);


            Console.ReadLine();
        }
    }
}
