using System;
using System.Collections.Generic;

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
            IFiguraGeometrica hexagono = new Hexagono()
            {
                ComprimentoLado = 10
            };

            //Console.WriteLine(quadrado1.CalcularArea());
            //Console.WriteLine(pentagono.CalcularArea);
            //Console.WriteLine(quadrado.CalcularArea);
            //Console.WriteLine(hexagono.CalcularArea);
        }
        public List<IFiguraGeometrica> Listar() 
        {
            return new List<IFiguraGeometrica>()
            {
                new Hexagono()
                {
                    ComprimentoLado = 10
                },
                new Quadrado()
                {
                    ComprimentoLado = 10
                }
            };
        }
    }
}
