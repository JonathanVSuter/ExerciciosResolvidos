using System;
using System.Collections.Generic;
using System.Text;

namespace CalcularAreafiguras
{
    public interface IFiguraGeometrica
    {
        double CalcularArea { get; }
        int NumeroTotalDeLados { get;}
        double Perimetro { get;}
        double ComprimentoLado { get; set; }
    }
}
