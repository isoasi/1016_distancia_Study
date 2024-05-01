using System;
using System.Globalization;
class URI
{
    static void Main(string[] args)
    {
        //declarar
        int tempo, distancia;

        // Ler a distância em quilômetros
        distancia = int.Parse(Console.ReadLine());

        // Multiplicamos essa distância por 2, já que o carro Y se afasta um quilômetro a cada 2 minutos.
        tempo = distancia * 2 ;

        Console.WriteLine(tempo + " minutos");

        Console.Read();

    }

}


