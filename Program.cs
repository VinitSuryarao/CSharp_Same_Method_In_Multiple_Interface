using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Same_Method_In_Multiple_Interface
{
    // First Interface with Same Method
    public interface IData1
    {
        void Display();
    }
    // Second Interface with Same Method
    public interface IData2
    {
        void Display();
    }
    // Inherit Both Method in One Interface
    public interface IData3 : IData1, IData2
    {
        void FinalDisplay();
    }

    public class DisplayClass : IData3
    {
        public void Display()
        {
            Console.WriteLine(" This is Display Method ");
        }
        public void FinalDisplay()
        {
            Console.WriteLine(" This is FinalDisplay Method ");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DisplayClass obj = new DisplayClass();
            obj.Display();
            obj.FinalDisplay();
            Console.ReadLine();
        }
    }
}
