using System.Collections.Generic;
using System.Collections;
namespace ArrayListC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //옛날방식 declaring an ArrayList
            ArrayList myArrayList = new ArrayList();
            ArrayList myArrayList2 = new ArrayList(100);

            //obj로 받아서 타입 아무거나 들어감
            myArrayList.Add(25);
            myArrayList.Add("Hello");
            myArrayList.Add(13.37);
        }
    }
}
