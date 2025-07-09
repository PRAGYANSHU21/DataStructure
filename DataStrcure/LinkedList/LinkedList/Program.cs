namespace LinkedList
{
    public class LinkedListProg
    {
        private Node head;
        private Node tail;
        private int size;

        public LinkedListProg()
        {
            head = null;
            tail = null;
            size = 0;
        }

        public int length()
        {
            return size;
        }

        public bool isEmpty() 
        { 
            return size == 0;
        }

        public void addLast(int e)
        {
            Node newest = new Node(e, null);

            if(this.isEmpty())
            {
                head = newest;
            }
            else
            {
                tail.Next = newest;
            }

            tail = newest;
            size++;
        }

        public void display()
        {
            var p = head;
            while (p != null)
            {
                Console.Write(p.Element + "-->");
                p = p.Next;
            }
        }

        static void Main(string[] args)
        {
            LinkedListProg linkedList = new LinkedListProg();
            linkedList.addLast(99);
            linkedList.addLast(50);
            linkedList.addLast(99);
            linkedList.display();
            Console.ReadKey();
        }
    }
}
