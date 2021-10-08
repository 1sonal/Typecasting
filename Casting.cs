using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs.TypeCasting
{
    class Casting:Base
    {
        static void Main(String[] args)
        {
            double x = 1234.7;
            int a;
            // Cast double to int.
            a = (int)x;
            System.Console.WriteLine(a);

            Casting c = new Casting();
            Base b = c; //implicit type conversion
            Casting c1 = (Casting)b;   //explicit

            int intType = 9999999;
            double doubleType = 122.23;
            float floatType = 222.222f;
           
            //By using C# predefined method for type casting
            Console.WriteLine("INT to STRING type value with predefined method convertion: " + Convert.ToString(intType));
            Console.WriteLine("DOUBLE to Boolean type value with predefined method convertion: " + Convert.ToBoolean(doubleType));
            Console.WriteLine("FLOAT to INT type value with predefined method convertion: " + Convert.ToUInt32(floatType));

        }
    }

}
