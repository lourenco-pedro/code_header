using System;
using System.IO;

namespace CodeHeader
{
    class Program
    {

        public static string Path;

        static void Main(string[] args)
        {
            Console.WriteLine("Insert project root folder: ");
            Path = Console.ReadLine();

            if (!Directory.Exists(Path))
            {
                Log.DirectoryExpection(DirectoryExpection.NULL_DIR);
                return;
            }

            var allFiles = GetFilesInPath(Path);

            DEV.LogStringArray(allFiles);
        }

        static string[] GetFilesInPath(string Path)
        {
            var files = Directory.GetFiles(Path, "*.cs");
            var dirs = Directory.GetDirectories(Path);

            foreach (var dir in dirs)
            {
                var returnedFiles = GetFilesInPath(dir);
                Array.Resize(ref files, files.Length + returnedFiles.Length);

                for (int i = files.Length - returnedFiles.Length; i < files.Length; i++)
                {
                    string newFile = returnedFiles[i];
                }
            }

            return files;
        }
    }
}
