namespace _3_CriandoVariaveisPontoFlutuante
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Executando projeto 3 Criando variaveis ponto flutante");

            double salario;

            salario = 5000.00;

            Console.WriteLine("Salario : " + salario);

            double idade;
            idade = 15;

            idade = idade / 2;
            Console.WriteLine("A idade 15 / 2 = " + idade);

            Console.WriteLine("A execução acabou. Tecle enter para sair.");
            Console.Read();
        }
    }
}