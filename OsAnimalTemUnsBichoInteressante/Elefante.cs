using System;
using System.Collections.Generic;
using System.Text;

namespace OsAnimalTemUnsBichoInteressante
{
    public class Elefante : IAnimal
    {
        public bool Vivo { get; set; } = true;
        public bool ComeAnimaisVivosApenas { get; set; } = false;

        public TipoDeAlimentacao TipoDeAlimentacao 
        {
            get 
            {
                return TipoDeAlimentacao.Herbivoro;
            }
        }

        public void Caminhar(){}

        public void Correr(){}

        public void Levantar(){}

        public void Respirar(){}
    }
}
