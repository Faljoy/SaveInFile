using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace FileFolder
{
    static public class InputInFile
    {
        public static string StartProgram()
        {
            Console.WriteLine("\t\t\t~Welcome to the console pad:~");
            Console.WriteLine("~Enter the text and we will save it in a convenient format for you~");
            return Console.ReadLine();
        }

        public static int CheckATryChoseFile()
        {
            int choseNumberInFileType;
            while (true)
            {
                choseNumberInFileType = InputInFile.ChoseFileType();
                if (choseNumberInFileType == 0)
                {
                    Console.WriteLine("~Please, chose a current type a File~\n " +
                        "~or u want exit about program~\n\t|1 - chose a File Type|\n\t" +
                        "|any key - Exit|");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            continue;
                        default:
                            Environment.Exit(0);
                            break;
                    }
                }
                else break;
            }
            return choseNumberInFileType;
        }

        public static int ChoseFileType()
        {
            int resultat = 0;
            Console.WriteLine("~Chose a type file:~\n\t|1 - txt|\n\t|2 - csv|\n\t|3 - pdf|");
            string chose = Console.ReadLine();
            switch (chose)
            {
                case "1":
                    resultat = 1;
                    break;
                case "2":
                    resultat = 2;
                    break;
                case "3":
                    resultat = 3;
                    break;
                default:
                    resultat = 0;
                    break;
            }
            return resultat;
        }

        public static async void SaveInTxt(string inputText, string path)
        {
            using (FileStream fstream = new FileStream($@"{path}\TextInTXT.txt", FileMode.OpenOrCreate))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(inputText);
                // асинхронная запись массива байтов в файл
                await fstream.WriteAsync(array, 0, array.Length);
                Console.WriteLine("~Text save in txt file~");
            }
        }

        public static async void SaveInCvs(string inputText, string path)
        {
            using (FileStream fstream = new FileStream($@"{path}\TextInCVS.cvs", FileMode.OpenOrCreate))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(inputText);
                // асинхронная запись массива байтов в файл
                await fstream.WriteAsync(array, 0, array.Length);
                Console.WriteLine("~Text save in cvs file~");
            }
        }

        public static async void SaveInPdf(string inputText, string path)
        {
            using (FileStream fstream = new FileStream($@"{path}\TextInPDF.pdf", FileMode.OpenOrCreate))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(inputText);
                // асинхронная запись массива байтов в файл
                await fstream.WriteAsync(array, 0, array.Length);
                Console.WriteLine("~Text save in pdf file~");
            }
        }
    }
}
