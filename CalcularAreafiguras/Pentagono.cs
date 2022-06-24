using System;
using System.Collections.Generic;
using System.Text;

namespace CalcularAreafiguras
{
    public class Pentagono : IFiguraGeometrica
    {
        private double _tangente36graus = 0.726542528;
        public double CalcularArea 
        { 
            get 
            {
                var metadeLado = ComprimentoLado / 2;
                var altura = metadeLado / _tangente36graus;
                var areaTriangulo = (metadeLado * altura) / 2;
                return areaTriangulo * 10;
            } 
        }
        public int NumeroTotalDeLados 
        {
            get 
            { 
                return 5; 
            }
        }
        public double Perimetro 
        { 
            get
            {
                return NumeroTotalDeLados * ComprimentoLado;
            } 
        }
        public double ComprimentoLado { get; set; }        
    }
}
