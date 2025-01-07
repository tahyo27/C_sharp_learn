using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPrac1
{
    internal class Box<T>
    {
        //public T Content { get; set; }

        //public string Log()
        //{
        //    return $"Box contains {Content}";
        //}

        private T content;
        
        public Box(T initialValue)
        {
            content = initialValue;
        }

        public void UpdateContent(T newContent)
        {
            content = newContent;
            Console.WriteLine($"Update content to {content}");
        }

        public T GetContent()
        {
            return content;
        }
    }
}
