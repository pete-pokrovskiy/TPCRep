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
            const string originalNameMask = "family-of-year-2016-{0}.jpg";
            const string thumbnailNameMask = "family-of-year-2016-thumb-{0}.jpg";

            AdjustFileNameService service = new AdjustFileNameService();
            service.AdjustName("C:\\output-thumbnails", thumbnailNameMask);


            Console.ReadLine();
        }
    }
}
