
namespace CriacaoCalculadoraII;

public class CalculadoraII
{
    public int DivideDoisNumeros(int num1, int num2)
    {
        int resultado = num1 / num2;
        return resultado;
    }

    public int SomaDoisNumeros(int num1, int num2)
    {
        int resultado = num1 + num2;
        return resultado;
    }

    public int MultiplicaDoisNumeros(int num1, int num2)
    {
        int resultado = num1 * num2;
        return resultado;
    }

    public int SubtraiDoisNumeros(int num1, int num2)
    {
        int resultado = num1 - num2;
        return resultado;
    }

    public bool DivisaoValida(int num)
    {
        if (num == 0)
            return false;
        return true;
    }
}
