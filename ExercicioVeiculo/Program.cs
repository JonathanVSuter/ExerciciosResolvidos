/*
 *
Motor;
  Tipo de motor;
  Tipo de combustível;
  Descricao; 
  Potencia;
  Torque;

Modelo:  
  Descrição;  	

Marca;
  Descrição;
  País Origem;

Veiculo:
  Chassis;
  Ano;
  Modelo;
  Marca;
  Preco;
  Motor;
 
 */


using System;

namespace ExercicioVeiculo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o modelo do veículo:");
            string entradaModelo = Console.ReadLine();
            Console.WriteLine("Informe o tipo de motor:");
            int entradaTipoMotor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o tipo de combustível:");
            int entradaTipoCombustivel = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe a descrição de motor:");
            string entradaDescMotor = Console.ReadLine();
            Console.WriteLine("Informe a potência do motor:");
            double entradaPotencia = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o torque do motor:");
            double entradaTorque = Convert.ToDouble(Console.ReadLine()); ;
            Console.WriteLine("Informe a descrição da marca ");
            string entradaDescMarca = Console.ReadLine();
            Console.WriteLine("Informe o país de origem da marca:");
            string entradaPaisorigemMarca = Console.ReadLine();
            Console.WriteLine("Informe o tipo de caçamba:");
            int entradaTipoCacamba = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de eixos:");
            string entradaEixos = Console.ReadLine();
            Console.WriteLine("Informe a capacidade de carga:");
            double entradaCapacidadeCarga = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe quantidade de marcha:");
            string entradaQtdMarcha = Console.ReadLine();
            Console.WriteLine("Informe o chassis:");
            string entradaChassis = Console.ReadLine();
            Console.WriteLine("Informe o ano:");
            string entradaAno = Console.ReadLine();

            Modelo modelo = new Modelo(entradaModelo);
            Motor motor = new Motor((TipoMotor)entradaTipoMotor, (TipoCombustivel)entradaTipoCombustivel,
                                    entradaDescMotor, entradaPotencia, entradaTorque);
            Marca marca = new Marca(entradaDescMarca, entradaPaisorigemMarca);
            Caminhao caminhao1 = new Caminhao((TipoCacamba)entradaTipoCacamba, entradaEixos, entradaCapacidadeCarga
                                              , entradaQtdMarcha, modelo, motor, marca
                                              , entradaChassis, entradaAno);

            Console.WriteLine("Descricao do modelo:" + caminhao1.Modelo.Descricao);
            Console.WriteLine("Descricao do motor:" + caminhao1.Motor.Descricao);
            Console.WriteLine("Descricao do motor:potência:" + caminhao1.Motor.Potencia);
            Console.WriteLine("Descricao do motor:tipo combustível:" + caminhao1.Motor.TipoCombustivel);
            Console.WriteLine("Descricao do motor:tipo do motor:" + caminhao1.Motor.TipoMotor);
            Console.WriteLine("Descricao do motor:torque:" + caminhao1.Motor.Torque);
            Console.WriteLine("Descricao do motor:marca:descrição:" + caminhao1.Marca.Descricao);
            Console.WriteLine("Descricao do motor:marca:país origem:" + caminhao1.Marca.PaisOrigem);
            Console.WriteLine("Descricao do motor:ano:" + caminhao1.Ano);
            Console.WriteLine("Descricao do motor:chassis:" + caminhao1.Chassis);
            Console.WriteLine("Descricao do motor:eixos:" + caminhao1.Eixos);
            Console.WriteLine("Descricao do motor:tipo caçamba:" + caminhao1.TipoCacamba);
            Console.WriteLine("Descricao do motor:capacidade de carga:" + caminhao1.CapacidadeCarga);



            //Inicializando cada tipo antes de inicializar o tipo principal:
            //Modelo modelo = new Modelo("MB710");
            //Motor motor = new Motor(TipoMotor.EmLinha, TipoCombustivel.Diesel, "MWM I6", 450, 2000);
            //Marca marca = new Marca("Mercedes", "Alemanha");
            //Caminhao caminhao1 = new Caminhao(TipoCacamba.Bau, "4", 35000
            //                                  , "20", modelo, motor,marca
            //                                  , "AAAASDASDKJAKJSDLKAJ", "2020");

            //Inicializando tudo de uma vez:
            //Caminhao caminhao1 = new Caminhao(TipoCacamba.Bau, "4", 35000
            //                                  ,"20", new Modelo("MB710"), new Motor(TipoMotor.EmLinha, TipoCombustivel.Diesel, "MWM I6", 450, 2000),
            //                                  new Marca("Mercedes", "Alemanha"), "AAAASDASDKJAKJSDLKAJ", "2020");

        }
    }
}
