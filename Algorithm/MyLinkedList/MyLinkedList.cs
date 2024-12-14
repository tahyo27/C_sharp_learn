using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList
{
    public class MyLinkedList
    {
        public Node<T> Head;

        public MyLinkedList()
        {
            Head = null;
        }

        public void Add(T data) // 맨뒤에 추가
        {
            Node<T> newNode = new Node<T>(data);

            if (Head == null) // 헤드가 null이면 헤드가 없으니 노드 헤드로
            {
                Head = newNode;
            }
            else
            {
                Node<T> currentNode = Head; // 현재 헤드 노드 가져오고
                while (currentNode.Next != null) // 헤드부터 다음 노드 없을때까지 서치
                {
                    currentNode = currentNode.Next;
                }
                currentNode.Next = newNode; // 마지막 노드 다음으로 추가

            }
        }

        public void IdxAdd(int index, T data)
        {
            try
            {
                if (index < 0)
                    throw new IndexOutOfRangeException();

                Node<T> newNode = new Node<T>(data);

                if (index == 0)
                {
                    newNode.Next = Head;
                    Head = newNode;
                    return;
                }

                Node<T> currentNode = Head;
                int currentIdx = 0;

                while (currentNode != null && currentIdx < index - 1)
                {
                    currentNode = currentNode.Next;
                    currentIdx++;
                }

                if (currentNode == null)
                    throw new IndexOutOfRangeException();

                newNode.Next = currentNode.Next;
                currentNode.Next = newNode;


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void Remove(T data)
        {

            if (Head == null)
            {
                return;
            }
            if (Head.Data.Equals(data))
            {
                Head = Head.Next;
                return;
            }

            Node<T> currentNode = Head;

            while (currentNode.Next != null)
            {
                if (currentNode.Next.Data.Equals(data))
                {
                    currentNode.Next = currentNode.Next.Next;
                    return;
                }
                currentNode = currentNode.Next;
            }
        }

        public void Print()
        {
            Node<T> currentNode = Head;
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.Data);
                currentNode = currentNode.Next;
            }
        }
    }
}
