namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 4 Conversoes e Outros Tipos Numericos");

            // o double não tem muitas casas decimais 308
            double salario;
            salario = 1200.50;
            Console.WriteLine("Salario Double: " + salario);

            // o int é uma variavel de 32 bits
            int salarioEmInteiro;
            salarioEmInteiro = (int) salario;

            Console.WriteLine("Salario em inteiro: " + salarioEmInteiro);

            // o long é uma variavel de 64 bits
            long idadeUniverso;
            idadeUniverso = 130000000000;
            Console.WriteLine("Idade do universo: " + idadeUniverso);

            // o short é uma variavel de 16 bits
            short quantidadeProdutos;
            quantidadeProdutos = 15000;
            Console.WriteLine("Quantidade de produtos: " + quantidadeProdutos);

            // o float não tem muitas casas decimais 38
            float altura;
            altura = 1.80f;
            Console.WriteLine("Altura: " + altura);

            Console.WriteLine("A execução acabou. Tecle enter para sair.");
            Console.Read();
        }
    }
}