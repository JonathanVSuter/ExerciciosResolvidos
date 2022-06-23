using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesELinq
{
    public class Gerente : IFuncionario
    {
        public double Salario { get; set; } = 10000;
        public string Nome { get; set; }
        public string CodigoDeCracha { get; set; }
        public string AreaGestao { get; set; }
        public double Bonificacao 
        { 
            get 
            {
                return (Salario / 100) * 80;
            } 
        }
    }
}
