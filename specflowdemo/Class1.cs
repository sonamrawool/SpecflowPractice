using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace specflowdemo
{
    public class Class1
    {
     //  [Test]
        public void sonam_testing()
        {

            TestForSonam(34, 4);
        }
     //   [Test]
        public void sonam_testing1()
        {
            TestForSonam(1001,5);
        }
    //   [Test]
        public void sonam_testing2()
        {
            TestForSonam(1000,4);
        }
     //   [Test]
        public void sonam_testing3()
        {
            TestForSonam(-6, 0);
        }
       //[Test]
       public void sonam_testing4()
        {
            TestIf(3);
        }
        [Test]
        public void sonam_testing5()
        {
            TestSwitch();
        }

        public void TestForSonam(int i,int j)
          {
            int k=0 ;

            // -- calculate tax
            if (i>=0 && i<= 1000)
            {
                k = 4;
            }
            else if(i > 1000)
             {
                k = 5;
            }
            else if (i < 0)
            {
                k = 0;
            }

            Assert.AreEqual(j, k);
            Console.WriteLine("value of j is " + j);
        }

        public void TestIf(int i)
        {
            if(i >= 5)
                {
                Console.WriteLine("Condition is true");
                }
            else if(i==4)
            {
                Console.WriteLine("Condition is false");
            }
            else
            {
                Console.WriteLine("Condition is stupid");
            }
        }

        public void TestFor()
        {
            int i;
            for(i=5; i>=0; i--)
            {
                Console.WriteLine("Value of i = {0}", i);
            }
        }

        public void TestWhile()
        {
            int i=0;
            while(i<=5)
            {
                Console.WriteLine("Value of i = {0}", i);
                i++;
            }
        }

        public void TestDoWhile()
        {
            int i = 0;
            do
            {
                Console.WriteLine("Value of i = {0}", i);
                i++;

            }
            while (i<=6);
        }

        public void TestSwitch()
        {
            int x = 1;

            switch (x)
            {
                case 1:
                    Console.WriteLine("1 case");
                    break;
                case 2:
                    Console.WriteLine("2 case");
                    break;
                default:
                    Console.WriteLine("default");
                    break;
            }
        }
    }
}
