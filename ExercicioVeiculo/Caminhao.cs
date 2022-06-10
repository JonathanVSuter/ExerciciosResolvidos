using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioVeiculo
{
    public enum TipoCacamba 
    {
        Basculante,
        Bau,
        Graneleiro,
        Container,
        Bitrem,
        Tanque
    }
    public class Caminhao : Veiculo
    {
        public TipoCacamba TipoCacamba { get; set; }
        public string Eixos { get; set; }
        public double CapacidadeCarga { get; set; }
        public string QuantidadeMarcha { get; set; } 
        public Caminhao() { }
        public Caminhao(TipoCacamba tipoCacamba, string eixos, double capacidadeCarga, string quantidadeMarcha) 
        {
            this.TipoCacamba = tipoCacamba;
            this.Eixos = eixos;
            this.CapacidadeCarga = capacidadeCarga;
            this.QuantidadeMarcha = quantidadeMarcha;            
        }
        //public Caminhao(TipoCacamba tipoCacamba, string eixos, double capacidadeCarga, 
        //                string quantidadeMarcha, Modelo modelo, Motor motor, Marca marca,
        //                string chassis, string ano):base(chassis, ano, modelo,marca,motor)
        //{
        //    this.TipoCacamba = tipoCacamba;
        //    this.Eixos = eixos;
        //    this.CapacidadeCarga = capacidadeCarga;
        //    this.QuantidadeMarcha = quantidadeMarcha;
        //}
        public Caminhao(TipoCacamba tipoCacamba, string eixos, double capacidadeCarga,
                        string quantidadeMarcha, Modelo modelo, Motor motor, Marca marca,
                        string chassis, string ano) 
        {
            this.TipoCacamba = tipoCacamba;
            this.Eixos = eixos;
            this.CapacidadeCarga = capacidadeCarga;
            this.QuantidadeMarcha = quantidadeMarcha;
            this.Modelo = modelo;
            this.Motor = motor;
            this.Marca = marca;
            this.Chassis = chassis;
            this.Ano = ano;
        }
    }
}
