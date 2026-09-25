using System;

public class Craps
{
    private Random numerosAleatorios = new Random();

    private enum Estado
    {
        CONTINUA,
        GANO,
        PERDIO
    }

    private enum NombreDados
    {
        DOS_UNOS = 2,
        TRES = 3,
        SIETE = 7,
        ONCE = 11,
        DOCE = 12
    }

    public int TirarDados()
    {
        int dado1 = numerosAleatorios.Next(1, 7);
        int dado2 = numerosAleatorios.Next(1, 7);

        int sumaDeDados = dado1 + dado2;

        Console.WriteLine("Dado 1: " + dado1);
        Console.WriteLine("Dado 2: " + dado2);
        Console.WriteLine("Suma: " + sumaDeDados);

        return sumaDeDados;
    }

    public void Jugar()
    {
        Estado estadoJuego = Estado.CONTINUA;
        int miPunto = 0;

        int sumaDeDados = TirarDados();

        switch ((NombreDados)sumaDeDados)
        {
            case NombreDados.SIETE:
            case NombreDados.ONCE:
                estadoJuego = Estado.GANO;
                break;

            case NombreDados.DOS_UNOS:
            case NombreDados.TRES:
            case NombreDados.DOCE:
                estadoJuego = Estado.PERDIO;
                break;

            default:
                estadoJuego = Estado.CONTINUA;
                miPunto = sumaDeDados;

                Console.WriteLine("El punto es: " + miPunto);
                break;
        }

        while (estadoJuego == Estado.CONTINUA)
        {
            sumaDeDados = TirarDados();

            if (sumaDeDados == miPunto)
            {
                estadoJuego = Estado.GANO;
            }
            else if (sumaDeDados == 7)
            {
                estadoJuego = Estado.PERDIO;
            }
        }

        if (estadoJuego == Estado.GANO)
        {
            Console.WriteLine("El jugador gana.");
        }
        else
        {
            Console.WriteLine("El jugador pierde.");
        }
    }
}