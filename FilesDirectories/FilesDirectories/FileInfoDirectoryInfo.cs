using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesDirectories
{
    public class FileInfoDirectoryInfo
    {
        public static void FileInfoDirectoryInfoExample()
        {
            // Get the current directory
            DirectoryInfo currentDirectory = new DirectoryInfo(Directory.GetCurrentDirectory());

            PrintFilesAndDirectories(currentDirectory);

            // Check if a file exists
            FileInfo file = new FileInfo(Path.Combine(currentDirectory.FullName, "file.txt"));
            EnsureExists(file);

            // Check if a directory exists
            DirectoryInfo directory = new DirectoryInfo(Path.Combine(currentDirectory.FullName, "folder"));
            EnsureExists(directory);

            PrintFilesAndDirectories(currentDirectory);

            // Move a file to a directory
            FileInfo destinationFile = new FileInfo(Path.Combine(directory.FullName, "file.txt"));
            file.MoveTo(destinationFile.FullName);

            PrintFilesAndDirectories(currentDirectory);

            // Copy a file to a directory
            FileInfo copiedFile = destinationFile.CopyTo(Path.Combine(currentDirectory.FullName, "text.txt"));

            PrintFilesAndDirectories(currentDirectory);

            // Delete a file
            copiedFile.Delete();

            PrintFilesAndDirectories(currentDirectory);

            // Delete a directory
            directory.Delete(true);

            PrintFilesAndDirectories(currentDirectory);
        }

        static void PrintFilesAndDirectories(DirectoryInfo directory)
        {
            Console.WriteLine("Files:");
            FileInfo[] files = directory.GetFiles("*.txt");
            DirectoryInfo[] directories = directory.GetDirectories();

            foreach (FileInfo file in files)
            {
                Console.WriteLine(file.FullName);
            }

            foreach (DirectoryInfo dir in directories)
            {
                Console.WriteLine(dir.FullName);
                FileInfo[] filesInDirectory = dir.GetFiles("*.txt");
                foreach (FileInfo file in filesInDirectory)
                {
                    Console.WriteLine(file.FullName);
                }
            }
        }

        static void EnsureExists(FileSystemInfo item)
        {
            if (item is FileInfo)
            {
                if (!item.Exists)
                {
                    using (FileStream fs = ((FileInfo)item).Create()) { }
                }
                else
                {
                    Console.WriteLine("File already exists");
                }
            }
            else if (item is DirectoryInfo)
            {
                if (!item.Exists)
                {
                    ((DirectoryInfo)item).Create();
                }
                else
                {
                    Console.WriteLine("Directory already exists");
                }
            }
        }
    }
}