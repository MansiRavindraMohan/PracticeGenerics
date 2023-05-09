using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeGenerics
{
    public class GenericClass<T>
    {
        //Variable of type T
        public T data;

        //This is my generic constructor
        public GenericClass(T data)
        {
            this.data = data;
            Console.WriteLine("Data : " + this.data);
        }
        public void GenericMethod(T data)
        {
            Console.WriteLine("Data : " + data);
        }
        public void GenericMethodOne<T>(T data)
        {
            Console.WriteLine("Data : " + data);
        }
    }
}
