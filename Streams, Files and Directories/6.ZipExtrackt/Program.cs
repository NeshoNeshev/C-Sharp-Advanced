using System;
using System.IO.Compression;

namespace _6._Zip_and_Extract
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\nnesh\OneDrive\Работен плот\Pictures";
            string zipPath = @"C:\Users\nnesh\OneDrive\Работен плот\result.zip";
            string pathExtractedFile = @"C:\Users\nnesh\OneDrive\Работен плот\SOFT";
            ZipFile.CreateFromDirectory(filePath, zipPath);
            ZipFile.ExtractToDirectory(zipPath, pathExtractedFile);
        }
    }
}
