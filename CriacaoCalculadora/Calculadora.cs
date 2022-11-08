
namespace CriacaoCalculadora;

public class Calculadora
{
    public static int Adicao(int numero1, int numero2)
    {
        int result = numero1 + numero2;
        return result;
    }

    public static int Subtracao(int numero1, int numero2)
    {
        int result = numero1 - numero2;
        return result;
    }

    public static int Multiplicacao(int numero1, int numero2)
    {
        int result = numero1 * numero2;
        return result;
    }

    public static int Divisao(int numero1, int numero2)
    {
        int result = numero1 / numero2;
        return result;
    }

    public static bool DivisaoValida(int num)
    {
        if (num == 0)
            return false;
        return true;
    }
}


