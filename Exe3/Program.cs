using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] primeiroArray = { 1, 3, 7, 29, 42, 98, 234, 93 };
            int[] segundoArray = { 4, 6, 93, 7, 55, 32, 3 };

            var diffSequence = primeiroArray.Except(segundoArray);

            Console.WriteLine(string.Join(", ", diffSequence));
            Console.Read();
        }
    }
}
