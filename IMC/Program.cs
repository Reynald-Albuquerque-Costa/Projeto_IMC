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

            Console.WriteLine("Qual é a sua idade? ");
            string idade = Convert.ToString(Console.ReadLine());


            Console.WriteLine("Seu nome é " + nome_);
            Console.WriteLine("Seu peso é " + peso);
            Console.WriteLine("Sua altura é " + altura);
            Console.WriteLine("Sua idade é " + idade);

            float imc = peso / (altura * altura);

            if (imc <= 18.5)
            {
                Console.WriteLine("IMC abaixo");
            }
            else if (imc <= 24.9 && imc > 18.5)
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
