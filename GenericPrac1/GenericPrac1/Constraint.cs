using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPrac1
{
    // 제네릭 제약조건 설정 
    internal class Constraint<T> where T : class
    {
        //1. where T : class 참조타입이 아니면 넣지 못하게 제약조건을 설정
    }
}
