namespace _2_criandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 2 - Criando Variaveis");

            int idade;
            idade = 10;
            Console.WriteLine("A idade é: " + idade);

            idade = 32;
            Console.WriteLine("A idade mudou, ela agora é: " + idade);

            idade = 10 + 5;
            Console.WriteLine("Idade 10 somada com 5: " + idade);

            idade = 10 * 2;
            Console.WriteLine("Idade 10 multiplicada com 2: " + idade);

            idade = 10 / 2;
            Console.WriteLine("Idade 10 dividida com 2: " + idade);

            idade = 10 + 10 * 2 / 3;
            Console.WriteLine("Idade 10 somada com 10, multiplicada com 2 e dividida com 3: " + idade);

            Console.WriteLine("Execução finalizada. Tecle enter para sair...");
            Console.ReadLine();
        }
    }
}