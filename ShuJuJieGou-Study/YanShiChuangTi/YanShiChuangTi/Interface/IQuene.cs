using System;
using System.Collections.Generic;
using System.Text;

namespace ShuJuJieGouStudy
{
    public interface IQuene<E>
    {
        int GetSize();
        bool IsEmpty();
        void Enquene(E e);
        E Dequene();
        E GetFront();
    }
}
