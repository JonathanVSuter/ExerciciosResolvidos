using System;

namespace ExerciciosResolvidos
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario=0;
            double salarioComreajuste = 0;
            double valorReajuste = 0;
            Console.WriteLine("Informe o seu salário");
            salario = Convert.ToDouble(Console.ReadLine());

            if (salario <= 1200)
            {
                //com regra de três
                valorReajuste = ((salario / 100) * 20);
                //multiplicação direta;
                valorReajuste = salario * 0.2;
                //com regra de três;
                salarioComreajuste = valorReajuste + salario;
                //multiplicação direta;
                salarioComreajuste = salario * 1.2;
            }
            else if (salario > 1200 && salario <= 2000)
            {
                valorReajuste = ((salario / 100) * 13);
                salarioComreajuste = salario + valorReajuste;
            }
            else if (salario > 2000 && salario <= 2500)
            {
                valorReajuste = ((salario / 100) * 10);
                salarioComreajuste = valorReajuste + salario;
            }
            else if (salario > 2500) 
            {
                valorReajuste = (salario / 100) * 5;
                salarioComreajuste = valorReajuste + salario;
            }
            Console.WriteLine($"O valor do salário após o reajuste é {salarioComreajuste}");
            Console.WriteLine($"O valor do reajuste é {valorReajuste}");
            Console.WriteLine($"O valor do salário em dólares é: {salarioComreajuste/4.7}");
            Console.WriteLine($"O valor do salário em euros é: {salarioComreajuste / 5.2}");
        }
    }
}
