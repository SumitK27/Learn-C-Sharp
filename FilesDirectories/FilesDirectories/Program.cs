namespace FilesDirectories
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // File and Directory methods can slow down the application as it performs security checks every time it is called.
            FileDirectory.FileAndDirectoryExample();

            // FileInfo and DirectoryInfo are more efficient as they perform security checks only once when the object is created.
            FileInfoDirectoryInfo.FileInfoDirectoryInfoExample();

            // Path methods are used to manipulate file paths.
            Paths.PathExample();
        }
    }
}