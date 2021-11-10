using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"C:\Users\opilane\Desktop\folder";

            //string[] dirs = Directory.GetDirectories(rootPath, "*", SearchOption.AllDirectories);

            //foreach (string dir in dirs)
            // {
            //Console.WriteLine(dir);

            //}
            //var files = Directory.GetFiles(rootPath, "*.*", SearchOption.TopDirectoryOnly);

            //foreach (string file in files)
            //{
            //Console.WriteLine(file);
            //Console.WriteLine(Path.GetFileName(file));
            //var info = new FileInfo(file);

            //Console.WriteLine($"{ Path.GetFileName(file) }: { info.Length } bytes");
            //}

            string newPath = @"C:\Users\opilane\Desktop\folder\bruh2\bruhinbruh";

            bool directoryExists = Directory.Exists(newPath);

            if (directoryExists)
            {
                Console.WriteLine("See kaust on juba olemas.");
            }
            else
            {
                Console.WriteLine("Sellist kausta pole olemas.");
                Directory.CreateDirectory(newPath);
            }



            Console.ReadLine();
            
        }
    }
}
