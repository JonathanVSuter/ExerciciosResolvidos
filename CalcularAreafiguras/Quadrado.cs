using System;
using System.Collections.Generic;
using System.Text;

namespace CalcularAreafiguras
{
    public class Quadrado : IFiguraGeometrica, ICalcularArea<Quadrado,double, int>
    {
        //public double CalcularArea { get { return ComprimentoLado* ComprimentoLado; } }

        public int NumeroTotalDeLados { get { return 4; } }

        public double Perimetro { get { return ComprimentoLado * 4; } }

        public double ComprimentoLado { get; set; }

        public double CalcularArea()
        {
            return ComprimentoLado * ComprimentoLado;
        }
        public int QuantidadeLados(Quadrado figura)
        {
            return NumeroTotalDeLados;
        }
    }
}
