using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesDirectories
{
    public class Paths
    {
        public static void PathExample()
        {
            // Combine two paths
            string path1 = @"C:\temp";
            string path2 = "file.txt";
            string combinedPath = Path.Combine(path1, path2);
            Console.WriteLine("Combined: " + combinedPath); // "Combined: C:\temp\file.txt

            // Get the directory name
            string directoryName = Path.GetDirectoryName(combinedPath);
            Console.WriteLine("Directory: " + directoryName); // "Directory: C:\temp

            // Get the file name
            string fileName = Path.GetFileName(combinedPath);
            Console.WriteLine("File: " + fileName); // "File: file.txt

            // Get the file extension
            string fileExtension = Path.GetExtension(combinedPath);
            Console.WriteLine("Extension: " + fileExtension); // "Extension: .txt

            // Get the file name without the extension
            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(combinedPath);
            Console.WriteLine("File without extension: " + fileNameWithoutExtension); // "File without extension: file

            // Get the root directory
            string rootDirectory = Path.GetPathRoot(combinedPath);
            Console.WriteLine("Root: " + rootDirectory); // "Root: C:\
        }
    }
}
