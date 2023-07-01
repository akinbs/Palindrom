using System; 
namespace Palindrom
{
    class program
    {
        static void Main(string[] args)
        {
            while(true) 
            {
                Stack Mystack = new Stack();
                Queue Myqueue = new Queue();
                string Word;
                Console.WriteLine("P - A - L - I - N - D - R - O - M");
                Console.Write("Give Me a word: ");
                Word = Console.ReadLine();
                for (int i = 0; i < Word.Length; i++)
                {
                    Myqueue.enQueue(Word[i]);
                    Mystack.push(Word[i]);
                }
                bool result = true;
                while (!Myqueue.isEmpty())
                {
                    if (Myqueue.deQueue() != Mystack.pop())
                    {
                        result = false;
                        break;
                    }

                }
                if (result)
                {
                    Console.WriteLine(Word + " is palindrom");
                }
                else
                {
                    Console.WriteLine(Word + " isn't a palindorm");
                }
                Console.ReadKey();
            }
        }
    }
    class Node
    {
        public char data;
        public Node next;
        public Node(char data) 
        {
            this.data = data;
            next = null;
        }
    }
    class Stack
    {
        public Node top; 
        public Stack()
        {
            top = null;
        }
        bool isEmpty() 
        {
            return top == null;
        }
        public void push(char data)
        {
            Node item = new Node(data);
            if (isEmpty() )
            {
                top = item;
            }
            else
            {
                item.next = top; 
                top = item;
            }
        }
        public char pop()
        {
            char ch; 
            if (isEmpty()) {
                ch = 's';
            }
            else
            {
                ch = top.data; 
                top = top.next;
            }
            return ch;
        }
    } 
    class Queue 
    {
        public Node front, rear; 
        public Queue()
        {
            this.front = null;
            this.rear = null;
        } 
        public bool isEmpty()
        {
            return front == null; 
        } 
        public void enQueue(char data)
        {   
            Node item = new Node (data);
            if (isEmpty())
            {
                front = rear = item;
            }
            else
            {
                rear.next = item;
                rear = item;
            }
        }
        public char deQueue()
        {
            char ch; 
            if(isEmpty())
            {
                ch='s';
            }
            else
            {
                ch= front.data; 
                front = front.next;
            } 
            return ch;
        }
    }
}