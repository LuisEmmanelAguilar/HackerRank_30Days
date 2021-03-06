using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DaysOfCode_15LinkedList
{
    class Program
    {
        public static Node insert(Node head, int data)
        {
            if (head == null)
                return new Node(data);
            else if (head.next == null)
            {
                head.next = new Node(data);
            }
            else
            {
                insert(head.next, data);
            }

            return head;
        }

        public static void display(Node head)
        {
            Node start = head;
            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }

        static void Main(String[] args)
        {

            Node head = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                head = insert(head, data);
            }
            display(head);

            Console.ReadLine();
        }

    }
}
