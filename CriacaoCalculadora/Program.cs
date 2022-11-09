// See https://aka.ms/new-console-template for more information

using CriacaoCalculadora;


namespace CriacaoCalculadora
{
 
    public class Program
    {

        static void Main(String[] args)
        {
            Console.WriteLine("Qual operacao voce deseja fazer: ");
            Console.WriteLine("1- Adicao");
            Console.WriteLine("2- Subtracao");
            Console.WriteLine("3- Multiplicacao");
            Console.WriteLine("1- Divisao");

            int operacao = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro numero: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            int num2 = int.Parse(Console.ReadLine());

            Calculadora calc = new Calculadora();
            

            int resultado = 0;
            
            switch (operacao)
            {
                case 1:
                    {
                        resultado = calc.Adicao(num1, num2);
                        break;
                    }
                case 2:
                    {
                        resultado = calc.Subtracao(num1, num2);
                        break;
                    }
                case 3:
                    {
                        resultado = calc.Multiplicacao(num1, num2);
                        break;
                    }
                case 4:

                    {
                        if(num2 == 0)
                        {
                            Console.WriteLine("Nao é possivel dividir um numero por zero!");
                            return;
                        }
                            resultado = calc.Divisao(num1, num2);
                            break;
                    }

                default:
                    Console.WriteLine("Numero invalido, digite outro numero.");
                    break;
            }

            Console.WriteLine("O resultado da operacao com os numeros {0} e {1} é: {2}", num1, num2, resultado);

            Console.ReadLine();
        }       
    }
}

