using System;

namespace IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é o seu nome? ");
            string nome_= Convert.ToString(Console.ReadLine());
                
            Console.WriteLine("Digite seu peso: ");
            float peso = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite sua altura: ");
            float altura = (float)Convert.ToDouble(Console.ReadLine());

            float imc = peso / (altura * altura);

            if (imc > 18.5)
            {
                Console.WriteLine("IMC abaixo");
            }
            else if (imc <= 24.9)
            {
                Console.WriteLine("Adequado");
            }
            else if (imc > 25)
            {
                Console.WriteLine("IMC acima");
            }




        }
    }
}
