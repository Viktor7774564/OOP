using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool res = false;
            Programmer p = new Programmer();
            Rasch rasch = new Rasch();
            Console.WriteLine("Введите фамилию программиста:");
            p.Fam = Console.ReadLine();
            Console.WriteLine("Введите число программ, написанных программистом:");
            p.numOfProg = Convert.ToInt32(Console.ReadLine()); //p.numOfProg=10
            Console.WriteLine("Введите число языков, которыми он пишет программы:");
            p.numOfLang = Convert.ToInt32(Console.ReadLine()); //p.numOfLang = 10
            int Q1 = p.Quality1();
            int Qp1 = rasch.Quality2(Q1, p.numOfProg);
            int Q2 = 100;

            res = ReferenceEquals(Q1, Q2);
        }
    }
}
