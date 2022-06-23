using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesELinq
{
    public interface IFuncionario
    {
        string Nome { get; set; }
        string CodigoDeCracha { get; set; }
        double Bonificacao { get;}
    }
}
