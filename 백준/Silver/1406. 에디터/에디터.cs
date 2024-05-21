using System;
using System.Text;

namespace MyCompiler {
    class Program {
        public static void Main(string[] args) 
        {
            string input = Console.ReadLine();

            Node first = new Node(' ', null);
            Node current = first;
            
            for (int i = 0; i < input.Length; i++)
            {
                char value = input[i];
                Node prev = current;
                current = new Node(value, prev);

                prev.next = current;
            }

            int count = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string commands = Console.ReadLine();
                if (current.prev == null)
                {
                    if (commands[0] == 'L' || commands[0] == 'B') continue;
                }
                if (commands[0] == 'D' && current.next == null) continue;
                current = CarryOut(commands, current);
            }

            current = first;

            WriteAnswer(first);
        }

        private static Node CarryOut(string commands, Node currentNode)
        {
            Node current = currentNode;
            
            string[] command = commands.Split(" ");
            switch(command[0])
            {
            case "L":
                    current = current.prev;
                    break;
            case "D":
                    current = current.next;
                    break;
            case "B":
                    current.prev.next = current.next;
                    if (current.next != null) current.next.prev = current.prev;
                    current = current.prev;
                    break;
            case "P":
                    char value = command[1][0];
                    Node newNode = new Node(value, current);
                    newNode.next = current.next;
                    if (current.next != null) current.next.prev = newNode;
                    current.next = newNode;
                    current = newNode;
                    break;
                default:
                    break;
            }

            return current;
        }

        private static void WriteAnswer(Node start)
        {
            Node current = start.next;

            StringBuilder answer = new StringBuilder();
            
            while (true)
            {
                answer.Append(current.value);
                if (current.next == null) break;
                else current = current.next;
            }

            Console.Write(answer);
        }
    }

    class Node
    {
        public char value = ' ';
        public Node prev = null;
        public Node next = null;

        public Node(char value, Node prev)
        {
            this.value = value;
            this.prev = prev;
        }
    }
}