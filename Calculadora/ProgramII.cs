// See https://aka.ms/new-console-template for more information

using CriacaoCalculadoraII;

//int primeiroNumero = 10;
//int segundoNumero = 5;

Console.WriteLine("Digite o primeiro numero: ");
int primeiroNumero = int.Parse(Console.ReadLine());


Console.WriteLine("Digite o segundo numero: ");
int segundoNumero = int.Parse(Console.ReadLine());

CalculadoraII calculadora = new CalculadoraII();


int respostaSoma = calculadora.SomaDoisNumeros(primeiroNumero, segundoNumero);
Console.WriteLine($"A Soma de {primeiroNumero} + {segundoNumero} é:  {respostaSoma}");

int respostaSubtracao = calculadora.SubtraiDoisNumeros(primeiroNumero, segundoNumero);
Console.WriteLine($"A Subtracao de {primeiroNumero} - {segundoNumero} é:  {respostaSubtracao}");

int respostaMultiplicacao = calculadora.MultiplicaDoisNumeros(primeiroNumero, segundoNumero);
Console.WriteLine($"A Multiplicacao de {primeiroNumero} * {segundoNumero} é:  {respostaMultiplicacao}");



bool ePossivelDividir = calculadora.DivisaoValida(segundoNumero);

if (ePossivelDividir)
{
    int resposta = calculadora.DivideDoisNumeros(primeiroNumero, segundoNumero);
    Console.WriteLine($"A divisao de {primeiroNumero} por {segundoNumero} é:  {resposta}");
}
else 
{
    Console.WriteLine("Nao é possivel dividir um numero por zero!");
}
Console.ReadLine();