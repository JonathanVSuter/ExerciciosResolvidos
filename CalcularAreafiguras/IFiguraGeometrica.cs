using System;
using System.Collections.Generic;
using System.Text;

namespace CalcularAreafiguras
{
    public interface IFiguraGeometrica
    {
        int NumeroTotalDeLados { get;}
        double Perimetro { get;}
        double ComprimentoLado { get; set; }
    }
    public interface ICalcularArea<in T,T1Result, T2Result> where T: IFiguraGeometrica
    {
        T1Result CalcularArea();
        T2Result QuantidadeLados(T figura);
    }
    public interface ICalcularAreaPentagono<in T, out TResult> where T : Pentagono 
    {
        TResult CalcularAreaPentagono(T pentatgono);
    }    
}
