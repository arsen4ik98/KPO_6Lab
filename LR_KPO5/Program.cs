using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_KPO5
{
    class Program
    {
        static void Main(string[] args)
        {
           
            // создаем каталог
       
            Component diskC = new Directory("Диск С", 0);
            // создаем подкаталоги
            Component myDocuments = new Directory("Мои документы", 0);
            Component generalDocuments = new Directory("Общие Документы", 0);
            // создаем новые файлы
            Component jpegFile = new File("Изображение.jpeg", 4.82);
            Component docxFile = new File("Документ.docx", 0.0304);
            Component mp3File = new File("Музыка.mp3", 7.13);
            Component mkvFile = new File("Видео.mkv", 5270);
            Component exeFile = new File("Program.exe", 2.08);
            // добавляем файлы в каталог Мои документы
            myDocuments.Add(jpegFile);
            myDocuments.Add(docxFile);
            myDocuments.Add(mp3File);
            myDocuments.Add(mkvFile);
            // добавляем файлы в каталог Общие Документы
            generalDocuments.Add(exeFile);
            // добавляем каталоги на диск С
            diskC.Add(myDocuments);
            diskC.Add(generalDocuments);
            // выводим все данные
            diskC.Print();

            Console.WriteLine();
            Console.Read();
        }
    }
}
