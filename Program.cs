// See https://aka.ms/new-console-template for more information
using System;
namespace Demo
{
    class one
    {
        public void test1()
        {
            Console.WriteLine("this is class one");
        }
    }
    class two : one
    {
        public void test2()
        {
            Console.WriteLine("this is class two");
        }
    }
    class three : two
    {
        public void test3()
        {
            Console.WriteLine("this is class three");
        }
    }
    class Inheritance
    {
        static void Main(string[] args)
        {
            three t3 = new three();
            t3.test1();
            t3.test2();
            t3.test3();
        }
    }
}