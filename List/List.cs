using System;

namespace List
{
    class List
    {
        class Node
        {
            public string Data;
            public Node Next;

            public Node(string Dta)
            {
                this.Data = Dta;
                this.Next = null;
            }

            public Node AddEnd(Node Head, Node NewNode)
            {

                if (Head == null)
                {
                    NewNode.Next = Head;
                    Head = NewNode;
                    return Head;
                }
                Node temp = Head;
                while ((temp.Next != null))
                {
                    temp = temp.Next;
                }
                temp.Next = NewNode;
                return Head;

            }
        }

        private Node Head = null;

        public void Add(string Value)
        {
            Node NewNode = new Node(Value);
            Head = NewNode.AddEnd(Head, NewNode);
        }

        public void Print()
        {
            Node temp = Head;
            while (temp != null)
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }
        }

        public int Search(string FindData)
        {
            Node temp = Head;
            int count = -1;
            while (temp != null)
            {
                count++;
                if (temp.Data == FindData)
                {
                    return count;

                }
                temp = temp.Next;
            }
            return -1;

        }

        public string Remove(string NeedToRemove)
        {
            Node temp = Head;
            int count = 0;
            if (Head.Data == NeedToRemove)
            {
                Head = temp.Next;
                return "Removed: Found at [0] index";
            }
            while (temp.Next != null)
            {
                count++;
                if (temp.Next.Data == NeedToRemove)
                {
                    temp.Next = temp.Next.Next;
                    return "Removed: Found at [" + count + "] index";
                }
                temp = temp.Next;
            }
            return "Not Found";
        }
    }
}
