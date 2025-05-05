using System;

namespace CursoCSharp.Fundamentos;

public class VariaveisEConstantes
{
    public static void Executar()
    {
        double raio = 4.5;
        const double PI = 3.1415;

        double area = raio * raio * PI;

        Console.WriteLine(area);
        Console.WriteLine("A area e: " + area);

        // Tipos internos
        bool isRaining = false;

        // Minimum and Maximum Value of all number types
        sbyte minByte = sbyte.MinValue;
        sbyte maxByte = sbyte.MaxValue;

        byte normalByte = byte.MaxValue;

        short minShort = short.MinValue;
        short maxShort = short.MaxValue;

        int minInt = int.MinValue;
        int maxInt = int.MaxValue;

        uint unsignaledSignal = uint.MaxValue;

        long minLong = long.MinValue;
        long maxlong = long.MaxValue;

        // not integers
        float floatingNumber = 9.99f;
        double doubleNumber = 9.99999; // Gets the twice of the memory Amount than the float

        decimal enormousNumber = decimal.MaxValue;

        char b = 'b';
        string sString = "aiskdpaoksd apsodkapsokd asopdkasp dk";
    }
}
