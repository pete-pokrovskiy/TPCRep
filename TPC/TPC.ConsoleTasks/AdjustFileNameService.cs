using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPC.ConsoleTasks
{
    class AdjustFileNameService
    {
        public void AdjustName(string directoryPath, string nameMask)
        {

            if (!Directory.Exists(directoryPath))
                throw new Exception($"Не существует директория {directoryPath}");

            var directory = new DirectoryInfo(directoryPath);


            var files = directory.GetFiles();



            for (int i = 0; i < files.Length; i++)
            {
                var file = files[i];

                System.Console.WriteLine(file.FullName);


                file.MoveTo(file.Directory.FullName + "\\" + string.Format(nameMask, i));

                //File.Move(file.FullName, Path.Combine(file.Directory.FullName, string.Format(nameMask, i)));

                //file.Move(file.Name, string.Format(nameMask, i));
                //File.Move(Path.Combine(directoryPath, file.Name), Path.Combine(directoryPath, string.Format(nameMask, i)));

            }

        }
    }
}
