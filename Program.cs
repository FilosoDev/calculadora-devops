using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Calculadora Simples em .NET");
            Console.WriteLine("Escolha uma operação:");
            Console.WriteLine("1. Adição (+)");
            Console.WriteLine("2. Subtração (-)");
            Console.WriteLine("3. Multiplicação (*)");
            Console.WriteLine("4. Divisão (/)");
            Console.WriteLine("5. Sair");

            string opcao = Console.ReadLine();

            if (opcao == "5")
            {
                break;
            }

            Console.WriteLine("Digite o primeiro número:");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            double resultado = 0;

            switch (opcao)
            {
                case "1":
                    resultado = numero1 + numero2;
                    Console.WriteLine($"Resultado: {numero1} + {numero2} = {resultado}");
                    break;
                case "2":
                    resultado = numero1 - numero2;
                    Console.WriteLine($"Resultado: {numero1} - {numero2} = {resultado}");
                    break;
                case "3":
                    resultado = numero1 * numero2;
                    Console.WriteLine($"Resultado: {numero1} * {numero2} = {resultado}");
                    break;
                case "4":
                    if (numero2 != 0)
                    {
                        resultado = numero1 / numero2;
                        Console.WriteLine($"Resultado: {numero1} / {numero2} = {resultado}");
                    }
                    else
                    {
                        Console.WriteLine("Erro: Divisão por zero não é permitida.");
                    }
                    break;
                default:
                    Console.WriteLine("Opção inválida, tente novamente.");
                    break;
            }

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}
