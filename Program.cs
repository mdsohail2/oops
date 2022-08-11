using System;
namespace System
{
    public class Cindia
    {
        public string India()
        {
            return "India";
        }

    }
    public class Ckarnataka : Cindia
    {
        public string Karnataka()
        {
            return "karnataka";
        }

    }
    public class Ckerala : Cindia
    {
        public string kerala()
        {
            return "kerala";
        }

    }
    class H_iheritance
    {
        public static void Main(String[] args)
        {
            Ckarnataka state1 = new Ckarnataka();
            Console.WriteLine("My state in :" + state1.Karnataka() + Environment.NewLine + "My country  is :" + state1.India()); //Environment.NewLine helps to get space b/w space/move to next line
            Ckerala state2 = new Ckerala();
            Console.WriteLine();//going to new line (giving space between to print statement
            Console.WriteLine("My state is :" + state2.kerala() + Environment.NewLine + "My country is :" + state2.kerala());
        }
    }
}