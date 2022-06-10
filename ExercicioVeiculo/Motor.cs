using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioVeiculo
{
    public class Motor
    {
        public TipoMotor TipoMotor { get; set; }
        public TipoCombustivel TipoCombustivel { get; set; }
        public string Descricao { get; set; }
        public double Potencia { get; set; }
        public double Torque { get; set; }
        public Motor(TipoMotor tipoMotor, TipoCombustivel tipoCombustivel, 
                     string descricao, double potencia, double torque) 
        {
            this.TipoMotor = tipoMotor;
            this.TipoCombustivel = tipoCombustivel;
            this.Descricao = descricao;
            this.Potencia = potencia;
            this.Torque = torque;
        }
    }
}
