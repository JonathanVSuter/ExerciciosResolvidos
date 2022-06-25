using System;
using System.Collections.Generic;
using System.Text;

namespace CalcularAreafiguras
{
    public class Hexagono : IFiguraGeometrica
    {
        public double CalcularArea 
        {
            get
            {
                return (((3 * (Math.Pow(ComprimentoLado, 2))) * Math.Sqrt(3))/2);
            } 
        }

        public int NumeroTotalDeLados
        { 
            get 
            { 
                return 6; 
            } 
        }

        public double Perimetro { get; }

        public double ComprimentoLado { get; set; }
    }
}
