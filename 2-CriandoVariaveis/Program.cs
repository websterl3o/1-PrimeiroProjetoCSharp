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

            Console.WriteLine("Execução finalizada. Tecle enter para sair...");
            Console.ReadLine();
        }
    }
}