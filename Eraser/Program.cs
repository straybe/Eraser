using FluentScheduler;

public class Program
{
    public static void Main(string[] args)
    {
        // Inicialización del JobManager con el registro creado
        JobManager.Initialize(new Eraser());

        // Esto es necesario para que la aplicación no termine inmediatamente
        Console.WriteLine("Presiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}