using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class PrintService<T>
    {
        private T[] vetor = new T[10];
        private int _count = 0;

        public void AddValue(T value)
        {
            if(_count == 10)
            {
                throw new InvalidOperationException("PrintService is full");
            }
            vetor[_count] = value;
            _count++;
        }

        public T First()
        {
            if (_count == 0)
            {
                throw new InvalidOperationException("PrintService is empty");
            }
            return vetor[0];
        }

        public void Print()
        {
    
            Console.Write("[");
            for(int i = 0; i < _count - 1; i++)
            {
                Console.Write(vetor[i] + ", ");
            }
            Console.Write(vetor[_count - 1]);
            Console.WriteLine("]");
        }
    }
}
