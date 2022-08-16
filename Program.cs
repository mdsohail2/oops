using System;

//-------------------------------Inheritance-------------------------
//----SingleInheritance----
/*class Firstclass
{
    public void fclass(){
        
   Console.WriteLine("I'm number one");
    }
}
class Secondclass : Firstclass
{
   public void sclass (){
       Console.WriteLine("I'm number two");
   }
}
class Singleinheritance
{
    public static void Main(string[] args){
    Secondclass c2 = new Secondclass();
    c2.fclass();
    c2.sclass();
    }
}
*/
//----MultiLevel Inheritance----
/*
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
*/
//----Heirarchical Inheritance----
/*class Parent
{
    public void dad()
    {
        Console.WriteLine("I'm Dad");
    }
}
class Son : Parent
{
    public void son1()
    {
        Console.WriteLine("I'm Son");
    }
}
class Daughter : Parent
{
    public void daughter1()
    {
        Console.WriteLine("I'm daughter");
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Son s = new Son();
        s.dad();
        s.son1();
        
        Dauhhter d = new Daughter();
        d.dad();
        d.daughter1();
    }
}
*/
//----MultipleInheritance----
/*class Parent
{
    public void dad()
    {
        Console.WriteLine("I'm dad");
    }
}
class Son
{
    public void son()
    {
        Console.WriteLine("I'm Son");
    }
}
class GrandSon: Son, Parent
{
    public void gson()
    {
        Console.WriteLine("I'm grandSon");
    }
}
class MInherit
{
    public static void Main(string[] args)
    {
        GrandSon s = new GrandSon();
        s.gson();
        s.son();
        s.dad   
    }
}
*/
/*interface IFirstName
{
    void FirstName();
}
interface ILastName
{
    void LastName();
}
class FullName : IFirstName, ILastName
{
    public void FirstName()
    {
        Console.Write("Mohammed");
    }
    public void LastName()
    {
        Console.WriteLine("Sohail");
    }
}
class Program
{
    static void Main(string[] args)
    {
        FullName name = new FullName();
        name.FirstName();
        name.LastName();
    }
}*/

//--------------Polymorphism Example-----------------
//----Compiletime polymorphism(method overloading)----
/*class Program
{
    static int add(int a, int b)
    {
        return a + b;
    }
    static int add(int a,int b,int c)
    {
        return a + b + c;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine(Program.add(2, 3));
        Console.WriteLine(Program.add(2, 5, 3));
    }
}*/
//----Runtime polymorphism(method overriding)(To perform method overriding in C#, you need to use virtual keyword with base class method and override keyword with derived class method.)
/*class One
{
    public virtual void mtd()
    {
        Console.WriteLine("normal method which is virtual");
    }
}
class Two : One
{
    public override void mtd()
    {
        Console.WriteLine("This is the overriden method");
    }
}
class Overriding
{
   public static void Main(string[] args)
    {
        Two or = new Two();
        or.mtd();
    }
}*/


//------------------------Abstraction-----------------------
/*abstract class Highpriority
{
    public abstract void absmtd();

    public void nonabsmtd()
    {
        Console.WriteLine("I'm then nonabstract method");
     
    }
}

class Lowpriority:Highpriority
{
    public override void absmtd()
    {
    Console.WriteLine("I'm abstract method which is overridden");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Lowpriority abs = new  Lowpriority();
        abs.absmtd();
        abs.nonabsmtd();
    }
}*/