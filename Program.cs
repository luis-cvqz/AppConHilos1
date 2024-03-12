using System.Threading;

namespace AppConHilos1;

class Program
{
    public static void DotrabajoPesado()
    {
        Console.WriteLine("DoTrabajoPesado: Estoy levantantdo un camión!!");
        Thread.Sleep(1000);
        Console.WriteLine("DoTrabajoPesado: Cansado! Necesito una siesta de 3 seg.");
        Thread.Sleep(1000);
        Console.WriteLine("DotrabajoPesado: 1...");
        Thread.Sleep(1000);
        Console.WriteLine("DoTrabajoPesado: 2...");
        Thread.Sleep(1000);
        Console.WriteLine("DoTrabajoPesado: 3...");
        Console.WriteLine("DoTrabajoPesado: Ya desperté!");
    }

    public static void DoAlgo()
    {
        Console.WriteLine("DoAlgo: Oye! Haciendo algo aquí!");
        for (int i = 0; i < 20; i++)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine();
        Console.WriteLine("DoAlgo: Ya terminé");
    }

    static void Main(string[] args)
    {
        Console.WriteLine("El main thread comienza aquí.");
        
        Thread backgroundThread = new Thread(new ThreadStart(Program.DotrabajoPesado));
        backgroundThread.Start();

        Program.DoAlgo();

        Console.WriteLine("El Main thread termina aquí.");
    }
}
