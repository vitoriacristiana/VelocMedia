using System;

namespace VelocMedia
{
    class Program
    {
        static void Main(string[] args)
        {   double dd, dt, v;
            Console.Beep();
            Console.Clear();
            Console.Write("Digite a distancia percorrida (metros):");
            dd= double.Parse(Console.ReadLine());
            Console.Write("Digite o tempo gasto(segundos):");
            dt= double.Parse(Console.ReadLine());
            v= dd/dt;
            Console.WriteLine($"Distancia percorrida: {dd} /nTempo gasto: {dt}");
            Console.Write($"Velocidade:");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"{v:N2} m/s");
            Console.ResetColor();




        }
    }
}
