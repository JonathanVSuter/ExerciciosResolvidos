using System;
using System.Collections.Generic;
using System.Text;

namespace CalcularAreafiguras
{
    public class Quadrado : IFiguraGeometrica
    {
        public double CalcularArea { get { return ComprimentoLado* ComprimentoLado; } }

        public int NumeroTotalDeLados { get { return 4; } }

        public double Perimetro { get { return ComprimentoLado * 4; } }

        public double ComprimentoLado { get; set; }
    }
}
