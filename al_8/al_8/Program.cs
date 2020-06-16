using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace al_8
{
    abstract class Handler
    {
        public Handler Successor { get; set; }
        public abstract void HandleRequest(int request);
    }
    class ConcreteHandler1 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request == 10)
                Console.WriteLine("десять");
            else if (Successor != null)
                Successor.HandleRequest(request);
        }
    }
    class ConcreteHandler2 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request == 100)
                Console.WriteLine("сто");
            else if (Successor != null)
                Successor.HandleRequest(request);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Handler h1 = new ConcreteHandler1();
            Handler h2 = new ConcreteHandler2();
            h1.Successor = h2;
            h1.HandleRequest(10);
            h1.HandleRequest(100);
            Console.ReadLine();
        }
    }
}

