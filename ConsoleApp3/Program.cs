using System;
using System.IO;
using System.Threading.Tasks;

namespace FileFolder
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\курсы\дз\auto13";
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }

            string inputText = InputInFile.StartProgram();
            int choseNumberInFileType = InputInFile.CheckATryChoseFile();
            switch (choseNumberInFileType)
            {
                case 1:
                    InputInFile.SaveInTxt(inputText, path);
                    break;
                case 2:
                    InputInFile.SaveInCvs(inputText, path);
                    break;
                case 3:
                    InputInFile.SaveInPdf(inputText, path);
                    break;
                default:
                    Console.WriteLine("Sorry This function not activity");
                    break;
            }
        }
    }
}
