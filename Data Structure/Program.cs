using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();               //created the list object of the SortedLinkedList class
            list.Add(56);
            list.Add(30);
            list.Add(40);
            list.Add(70);
            list.Display();
            Console.WriteLine("this is stored in linked list");
            list.InsertAtParticularPosition(2, 30);
            list.Display();
            list.Display();
            Console.ReadLine();
        }
    }
}
