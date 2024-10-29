using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesApp
{
    internal class Rectangle
    {
        public const int NumberOfCorner = 4; //자바에서 final로 상수 선언하는것과 유사함 컴파일 타임에 값 얻어야함 즉 생성된 줄에서 값 필요

        public readonly string Color; // 리드온리의 경우 런타임동안만 할당되어도 괜찮음 

        public double Width {  get; set; }
        public double Height { get; set; }

        public Rectangle(string color)
        {
            Color = color;
        }


    }
}
