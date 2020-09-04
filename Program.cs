using System;
using System.IO;
using System.Collections.Generic;

namespace CodeHeader
{
    class Program
    {

        static void Main(string[] args)
        {
            if (args.Length == 3)
            {

                List<string> FilesPath = new List<string>();

                string path = args[0];
                string extension = args[1];
                string headerTemplatePath = args[2];

                if (!Directory.Exists(path))
                {
                    Log.DirectoryExpection(DirectoryExpection.NULL_DIR);
                    return;
                }

                GetFilesInPath(path, extension, FilesPath);

                string header = File.ReadAllText(headerTemplatePath);

                AddHeader(FilesPath, header);
            }
            else
            {
                Console.WriteLine("No path or file extension added");
            }
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

        static void AddHeader(List<string> FilesPath, string header)
        {
            foreach (var path in FilesPath)
            {
                var file = File.ReadAllText(path);
                File.WriteAllText(path, header + "\n \n \n" + file);
                Console.WriteLine("Added Header to {0} file", path);
            }
        }
    }
}
