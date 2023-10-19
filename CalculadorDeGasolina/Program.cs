using System;

class Program
{
    static void Main(string[] args)
    {
        bool continuar = true;
        while (continuar)
        {
            Console.Write("Digite o preço da gasolina: ");
            double precoGasolina = double.Parse(Console.ReadLine());
            Console.Write("Digite o preço do álcool: ");
            double precoAlcool = double.Parse(Console.ReadLine());
            double relacaoConsumo = 0.7;
            double relacaoPreco = precoAlcool / precoGasolina;
            if (relacaoPreco > relacaoConsumo)
            {
                Console.WriteLine("Abasteça com gasolina.");
            }
            else if (relacaoPreco < relacaoConsumo)
            {
                Console.WriteLine("Abasteça com álcool.");
            }
            else
            {
                Console.WriteLine("Tanto faz abastecer com gasolina ou álcool.");
            }
            Console.Write("Deseja efetuar um novo cálculo? (s/n) ");
            string resposta = Console.ReadLine();
            if (resposta.ToLower() == "n")
            {
                continuar = false;
            }
        }
    }
}

