using System;
using System.IO;

namespace dnGLua.API.CodeGenerator
{
    internal static class Program
    {
        /// <summary>
        ///   Generate C# API from JSON file.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="output"></param>
        /// <param name="recursive"></param>
        private static int Main(FileSystemInfo? input = default, DirectoryInfo? output = default, bool recursive = true)
        {
            bool isFolder;
            if (input == null)
            {
                input = new DirectoryInfo(Directory.GetCurrentDirectory());
                isFolder = true;
            }
            else
            {
                if (!input.Exists)
                {
                    Console.Error.WriteLine("Invalid --input argument");
                    return 1;
                }

                isFolder = input.Attributes.HasFlag(FileAttributes.Directory);
            }

            string outputPath;
            if (output is null)
            {
                outputPath = Path.GetDirectoryName(input.FullName)!;
            }
            else
            {
                if (!output.Exists)
                {
                    Console.Error.WriteLine("Invalid --output argument");
                    return 2;
                }

                outputPath = output.FullName;
            }

            if (isFolder)
            {
                var searchOption = recursive
                    ? SearchOption.AllDirectories
                    : SearchOption.TopDirectoryOnly;
                foreach (var file in Directory.EnumerateFiles(input.FullName, "*.json", searchOption))
                {
                    ProcessFile(file, outputPath);
                }
            }
            else
            {
                ProcessFile(input.FullName, outputPath);
            }

            return 0;
        }

        private static void ProcessFile(string fileName, string outputPath)
        {
        }
    }
}