using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    class Program
    {
        private static void Main(string[] args)
        {
            if (File.Exists("test.txt"))
            {
                string content = File.ReadAllText("test.txt");
                Console.WriteLine("Current content of file:");
                Console.WriteLine(content);
            }
            Console.WriteLine("Please enter new content for the file (type 'exit' and press enter to finish:");
            using (var sw = new StreamWriter("test.txt"))
            {
                string newContent = Console.ReadLine();
                while (newContent != "exit")
                {
                    sw.Write(newContent + Environment.NewLine);
                    newContent = Console.ReadLine();
                }
                sw.Close();
            }

            FileInfo fi = new FileInfo(System.Reflection.Assembly.GetExecutingAssembly().Location);
            if (fi != null)
                Console.WriteLine(String.Format("Information about file: {0}, {1} bytes, last modified on {2} - Full path: {3}", fi.Name, fi.Length, fi.LastWriteTime, fi.FullName));

            DirectoryInfo di = new DirectoryInfo(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location));
            if (di != null)
            {
                FileInfo[] subFiles = di.GetFiles();
                if (subFiles.Length > 0)
                {
                    Console.WriteLine("Files:");
                    foreach (FileInfo subFile in subFiles)
                        Console.WriteLine("   " + subFile.Name + " (" + subFile.Length + " bytes)");
                }
            }
            Console.ReadKey();
        }
    }
}
