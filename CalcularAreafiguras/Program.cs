using System;

namespace CalcularAreafiguras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IFiguraGeometrica pentagono = new Pentagono() 
            {
                ComprimentoLado = 12,                
            };
            IFiguraGeometrica quadrado = new Quadrado()
            {
                ComprimentoLado = 10
            };
            Console.WriteLine(pentagono.CalcularArea);
            Console.WriteLine(quadrado.CalcularArea);

        }
    }
}
