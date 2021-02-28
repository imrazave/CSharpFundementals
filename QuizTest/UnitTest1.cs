using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace QuizTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int ageNeil = 22;
            int ageOwen = 19;
            bool isOlderNeil = ageNeil > ageOwen;
            if (isOlderNeil)
            {
                Console.WriteLine("Tea");
            }
            else
            {
                Console.WriteLine("Coffee");
            }
        }

        [TestMethod]
        public void TimesTables()
        {
            int endtable = 5;

            for (int i = 1; i <= endtable; i++)
            {
                int fronttable = 12;
                for (int j = 1; j <= fronttable; j++)
                {
                    Console.WriteLine($"{i}{" X "}{j}{" = "}{i * j}");
                }
            }
        }

        [TestMethod]
        public void MyTestMethod()
        {
            int[] allNums = { 1, 2, 3, 4, 5 };

            int index = 0;

            while (index <= 5)
            {
                Console.WriteLine($"Last index {allNums[index]}");
                index++;
            }
        }
    }
}
