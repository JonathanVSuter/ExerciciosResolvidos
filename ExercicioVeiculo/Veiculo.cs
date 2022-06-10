using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioVeiculo
{
    public abstract class Veiculo
    {
        public string Chassis { get; set; }
        public string Ano { get; set; }
        public Modelo Modelo { get; set; }
        public Marca Marca { get; set; }
        public Motor Motor { get; set; }
        public double Preco { get; set; }
        public Veiculo(string chassis, string ano, Modelo modelo, Marca marca, Motor motor)
        {            
            this.Chassis = chassis;
            this.Ano = ano;            
            this.Marca = marca;
            this.Motor = motor;
        }
        public Veiculo() { }
    }
}
