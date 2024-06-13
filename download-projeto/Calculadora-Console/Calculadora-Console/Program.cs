using System;

public class Calculadora
{
    public static void Main(string[] args)
    {

        int operacao;

        Console.WriteLine("Qual operacao deseja realizar?");
        Console.WriteLine("1.Soma, 2.Subtracao, 3.Multiplicacao, 4.Divisao");
        operacao = Int32.Parse(Console.ReadLine());

        if (operacao > 4 || operacao < 1)
        {


            Console.WriteLine("Insira uma opcao valida");
            return;



        }

        if (operacao == 1)
        {


            int n1;
            int n2;
            int resultado;

            Console.WriteLine("Voce escolheu soma.");
            Console.WriteLine("Insira o primeiro numero");
            n1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo numero");
            n2 = Int32.Parse(Console.ReadLine());

            resultado = n1 + n2;

            Console.WriteLine("Resultado: " + resultado);



        }

        if (operacao == 2)
        {


            int n1;
            int n2;
            int resultado;

            Console.WriteLine("Voce escolheu subtracao.");
            Console.WriteLine("Insira o primeiro numero");
            n1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo numero");
            n2 = Int32.Parse(Console.ReadLine());

            resultado = n1 - n2;

            Console.WriteLine("Resultado: " + resultado);



        }

        if (operacao == 3)
        {


            int n1;
            int n2;
            int resultado;

            Console.WriteLine("Voce escolheu Multiplicacao.");
            Console.WriteLine("Insira o primeiro numero");
            n1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo numero");
            n2 = Int32.Parse(Console.ReadLine());

            resultado = n1 * n2;

            Console.WriteLine("Resultado: " + resultado);



        }

        if (operacao == 4)
        {


            int n1;
            int n2;
            int resultado;

            Console.WriteLine("Voce escolheu Divisao.");
            Console.WriteLine("Insira o primeiro numero");
            n1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo numero");
            n2 = Int32.Parse(Console.ReadLine());

            resultado = n1 / n2;

            Console.WriteLine("Resultado: " + resultado);



        }


    }



}