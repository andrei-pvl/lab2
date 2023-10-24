using System;
using Vectors;

namespace VectorProject
{
    internal class Program
    {
        static int Main(string[] args)
        {
            Vector vector1 = new Vector(4, 3, 0);
            Vector vector2 = new Vector(6, -4, 26);

            Console.WriteLine(vector1.ToString());
            
            Console.WriteLine(vector1 + vector2);
            Console.WriteLine(vector1 - vector2);          
            Console.WriteLine(vector1 * 5);
            Console.WriteLine(vector1 * vector2);

            Console.WriteLine(vector1.Length());
            
            Console.WriteLine(vector1.Equals(vector2));
            
            Console.WriteLine((double)vector2);
            Console.WriteLine((Vector2D)vector1);
            
            Console.WriteLine(vector1 != vector2);
            Console.WriteLine(vector1 == vector2);

            return 0;
        }
    }
}
