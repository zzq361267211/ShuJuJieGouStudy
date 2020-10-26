using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShuJuJieGouStudy
{
    interface IStack<E>
    {
      
         int Size { get;  }

         void Push(E e);

         E Pop();

         E Peek();

         bool IsEmpty();
    }
}
