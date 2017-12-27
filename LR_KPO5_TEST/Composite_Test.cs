using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using LR_KPO5;

namespace LR_KPO5_TEST
{
    [TestFixture()]
    public class Composite_Test
    {
        [Test()]
        public void DirectoryEmptyTest()
        {
            Directory directory = new Directory(" ", 0);
            int expected = 0;
            int actual = directory.components.Count;
            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void DirectoryAddTest()
        {
            Directory directory = new Directory(" ", 0);
            Component diskC = new Directory("Диск С", 0);
            Component myDocuments = new Directory("Мои документы", 0);
            diskC.Add(myDocuments);
            int expected = 0;
            int actual = directory.components.Count;
            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void DirectoryRemoveTest()
        {
            Directory directory = new Directory(" ", 0);
            Component diskC = new Directory("Диск С", 0);
            Component myDocuments = new Directory("Мои документы", 0);
            diskC.Add(myDocuments);
            diskC.Remove(myDocuments);
            int expected = 0;
            int actual = directory.components.Count;
            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void FileAddTest()
        {
            Directory directory = new Directory(" ", 0);
            Component diskC = new Directory("Диск С", 0);
            Component mkvFile = new File("Видео.mkv", 5270);
            diskC.Add(mkvFile);
            int expected = 0;
            int actual = directory.components.Count;
            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void FileRemoveTest()
        {
            Directory directory = new Directory(" ", 0);
            Component diskC = new Directory("Диск С", 0);
            Component mkvFile = new File("Видео.mkv", 5270);
            diskC.Add(mkvFile);
            diskC.Remove(mkvFile);
            int expected = 0;
            int actual = directory.components.Count;
            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void SizeAddTest()
        {
            Component diskC = new Directory("Диск С", 0);
            Component mkvFile = new File("Видео.mkv", 5270);
            Component exeFile = new File("Program.exe", 2.08);
            diskC.Add(mkvFile);
            diskC.Add(exeFile);
            double expected = 5272.08;
            double actual = diskC.SumSize();
            Assert.AreEqual(expected, actual);
        }

        public void SizeRemoveTest()
        {
            Component diskC = new Directory("Диск С", 0);
            Component mkvFile = new File("Видео.mkv", 5270);
            Component exeFile = new File("Program.exe", 2.08);
            diskC.Add(mkvFile);
            diskC.Add(exeFile);
            diskC.Remove(exeFile);
            double expected = 5270;
            double actual = diskC.SumSize();
            Assert.AreEqual(expected, actual);
        }

    }
}
