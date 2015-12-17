using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab01
{
    class TestFileAndDirectory
    {
        static void Main(string[] args)
        {
            const string CLOSE = "end";
            string directoryName;
            string fileName;
            string[] listOfFiles;
            Write("Enter a directory >> ");
            directoryName = ReadLine();
            
            while (directoryName != CLOSE)
            {
                if (Directory.Exists(directoryName))
                {
                    WriteLine("Directory exists, and it contains the following: ");
                    listOfFiles = Directory.GetFiles(directoryName);
                    for (int x = 0; x < listOfFiles.Length; ++x)
                        WriteLine("{0, 4}", listOfFiles[x]);
                    Write("Enter a filename >> ");
                    fileName = ReadLine();
                    if (File.Exists(fileName))
                    {
                        WriteLine("File exists");
                        WriteLine("File was created " + File.GetCreationTime(fileName));
                    }
                    else
                        WriteLine("File \'" + fileName + "\' does not exist.");
                }
                else
                    WriteLine("Directory does not exists.");

                Write("Enter a directory or type \'end\' to quit >> ");
                directoryName = ReadLine();
            }
        }
    }
}
