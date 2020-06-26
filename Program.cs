using System;

namespace AnoNascimento
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Faça um programa que leia um ano de nascimento e escreva (baseado no ano atual) a idade e se é de maior ou de menor. Além disso, se a idade for menor que 5 anos, questionar se o usuário não errou o ano de nascimento e voltar a fazer a pergunta até que a idade seja válida (maior ou igual a 5 anos).
            int anoNascimento, anoAtual, idade;

            idade = 0;
            while ( idade <= 5){
                Console.WriteLine("Digite o seu ano de nascimento: (e tecle ENTER)");
                anoNascimento = int.Parse(Console.ReadLine());
                anoAtual = DateTime.Now.Year;
                idade = anoAtual - anoNascimento;
                if (idade <= 5)
                {
                    Console.WriteLine("Você é muito novo");
                }
                else if (idade >= 18)
                {
                    Console.WriteLine("Você é maior de idade");
                }
                else
                {
                    Console.WriteLine("Você é menor de idade");
                }
            }
        }
    }
}
