using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesELinq
{
    public class Repositor : IFuncionario
    {
        public double Salario { get; set; } = 2000;
        public string Nome { get { return ""; } set { } }
        public string CodigoDeCracha { get; set; }
        public string Local { get; set; }
        public double Bonificacao
        {
            get
            {
                return (Salario / 100) * 20;
            }
        }
    }
}
