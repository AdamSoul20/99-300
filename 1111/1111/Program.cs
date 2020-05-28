using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1111
{
    class Program {
        static void Main(string[] args) 
        {
            int z = 0;
            Console.WriteLine("Введите 1 число диапозона"); int n = Int32.Parse(Console.ReadLine()); 
            Console.WriteLine("Введите 2 число диапозона"); int m = Int32.Parse(Console.ReadLine()); 
            bool b;
            if (n < m)
            { 
                for (int i = n; i <= m; i++)
                {
                    b = true;
                    
                    for (int j = 2; j < i; j++)
                    { 
                        if (i % j == 0) 
                        { 
                            b = false;
                            break; 
                        } 
                    }
                    if (b) 
                    { 
                        Console.WriteLine(i + " простое число");
                        z += 1; 
                    }   
                } 
            }
            Console.WriteLine(z + "простых чисел");
            Console.ReadKey();   
        } 
    }
}
