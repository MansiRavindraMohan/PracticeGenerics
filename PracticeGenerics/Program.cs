using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeGenerics
{
    class Program
    {
        //Generic means the general form.
        //It does not contain any data type.
        //Generic means not a specific to a particular data type.
        //<>This is angle bracket with type name.
        //TypeName<T> T is type parameter.
        //Generic allow us to create a single class or method that can be used with different data type.
        //Advantages-We can reuse the code.
        public static void Main(string[] args)
        {
            GenericClass<string> genericClass= new GenericClass<string>("Mansi");
            GenericClass<int> generic = new GenericClass<int>(45);
            GenericClass<double> dGeneric = new GenericClass<double>(3.6);
            
            genericClass.GenericMethod("Hello");
            generic.GenericMethod(23);
            dGeneric.GenericMethod(1.4);

            genericClass.GenericMethodOne<string>("Hii");
            generic.GenericMethodOne<int>(48);
            dGeneric.GenericMethodOne<double>(2.5);
            Console.ReadLine();
        }
    }
}
