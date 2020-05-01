using System;
using System.IO;
using System.Collections.Generic;

namespace CodeHeader
{
    class Program
    {

        static void Main(string[] args)
        {
            List<string> FilesPath = new List<string>();

            Console.WriteLine("Insert project root folder: ");
            string path = Console.ReadLine();

            Console.WriteLine("Insert desired File Extension (without . ): ");
            string extension = Console.ReadLine();

            if (!Directory.Exists(path))
            {
                Log.DirectoryExpection(DirectoryExpection.NULL_DIR);
                return;
            }

            GetFilesInPath(path, extension, FilesPath);
            AddHeader(FilesPath);
        }

        static void GetFilesInPath(string path, string extension, List<string> filesPath)
        {
            var files = Directory.GetFiles(path, "*." + extension);
            var dirs = Directory.GetDirectories(path);

            foreach (var file in files)
            {
                filesPath.Add(file);
            }

            foreach (var dir in dirs)
            {
                GetFilesInPath(dir, extension, filesPath);
            }
        }

        static void AddHeader(List<string> FilesPath)
        {
            var headerLayout = File.ReadAllText(Constants.HEADER_LAYOUT_PATH);

            foreach (var path in FilesPath)
            {
                var file = File.ReadAllText(path);
                File.WriteAllText(path, headerLayout + "\n \n \n" + file);
                Console.WriteLine("Added Header to {0} file", path);
            }
        }
    }
}
