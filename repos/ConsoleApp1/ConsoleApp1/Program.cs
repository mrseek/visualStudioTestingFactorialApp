using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        
        public int Factorial(int numero) {
            int resultado = 1;
            for (int i = 1; i <= numero; i++)
            {
                resultado = resultado * i;
            }
            return resultado;
        }

        public static void Main(string[] args)
        {

        }
    }
    
}
