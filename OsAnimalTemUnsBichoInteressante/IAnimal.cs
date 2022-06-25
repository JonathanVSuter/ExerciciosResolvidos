using System;
using System.Collections.Generic;
using System.Text;

namespace OsAnimalTemUnsBichoInteressante
{
    public interface IAnimal
    {
        void Respirar();
        void Caminhar();
        void Levantar();
        void Correr();
        bool Vivo { get; set; }
        bool ComeAnimaisVivosApenas { get; set; }
        TipoDeAlimentacao TipoDeAlimentacao { get; }
    }
}
