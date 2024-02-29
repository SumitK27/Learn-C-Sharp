using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesDirectories
{
    public class FileDirectory
    {
        public static void FileAndDirectoryExample()
        {
            // Get the current directory
            string currentDirectory = Directory.GetCurrentDirectory();

            PrintFilesAndDirectories(currentDirectory);

            // Check if a file exists
            string filePath = Path.Combine(currentDirectory, "file.txt");
            EnsureExists(filePath, true);

            // Check if a directory exists
            string directoryPath = Path.Combine(currentDirectory, "folder");
            EnsureExists(directoryPath, false);

            PrintFilesAndDirectories(currentDirectory);

            // Move a file to a directory
            string destinationFilePath = Path.Combine(directoryPath, "file.txt");
            File.Move(filePath, destinationFilePath);

            PrintFilesAndDirectories(currentDirectory);

            // Copy a file to a directory
            string copiedFilePath = Path.Combine(currentDirectory, "text.txt");
            File.Copy(destinationFilePath, copiedFilePath);

            PrintFilesAndDirectories(currentDirectory);

            // Delete a file
            File.Delete(copiedFilePath);

            PrintFilesAndDirectories(currentDirectory);

            // Delete a directory
            Directory.Delete(directoryPath, true);

            PrintFilesAndDirectories(currentDirectory);
        }

        static void PrintFilesAndDirectories(string directoryPath)
        {
            Console.WriteLine("Files:");
            string[] files = Directory.GetFiles(directoryPath, "*.txt");
            string[] directories = Directory.GetDirectories(directoryPath);

            foreach (string file in files)
            {
                Console.WriteLine(file);
            }

            foreach (string directory in directories)
            {
                Console.WriteLine(directory);
                string[] filesInDirectory = Directory.GetFiles(directory, "*.txt", SearchOption.AllDirectories);
                foreach (string file in filesInDirectory)
                {
                    Console.WriteLine(file);
                }
            }
        }

        static void EnsureExists(string path, bool isFile)
        {
            if (isFile)
            {
                if (!File.Exists(path))
                {
                    // File.Create returns a FileStream, which should be closed when you're done with it
                    using (File.Create(path)) { }
                }
                else
                {
                    Console.WriteLine("File already exists");
                }
            }
            else
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                else
                {
                    Console.WriteLine("Directory already exists");
                }
            }
        }
    }
}
