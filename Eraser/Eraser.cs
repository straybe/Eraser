using FluentScheduler;

public class Eraser : Registry
{
    public Eraser()
    {
        Schedule(() => Console.WriteLine("Han pasado 10 segundos")).ToRunNow().AndEvery(10).Seconds();
    }
}