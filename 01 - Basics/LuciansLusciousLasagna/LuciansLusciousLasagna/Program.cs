public static class Lasagna
{
    public static void Main(string[] args)
    {
    
        int layers = 3;
        int minutesInOven = 25;

        Console.WriteLine($"Tiempo de espera enel horno: {ExpectedMinutesInOven()} minutos \n");
        Console.WriteLine($"Tras {minutesInOven} minutos en el horno, aún faltan {RemainingMinutesInOven(minutesInOven)} para que la lasagna esté terminada \n");
        Console.WriteLine($"Para preparar una lasagna de {layers} capas se tardará {PreparationTimeInMinutes(3)} minutos en hacerla \n");
        Console.WriteLine($"El tiempo total que llevamos para hacer una lasagna de {layers} capas, y los {minutesInOven} minutos que lleva en el horno, hacen un total de {ElapsedTimeInMinutes(layers, minutesInOven)} minutos \n");
        Console.ReadLine();
    }


    public static int ExpectedMinutesInOven() => 40;

    public static int RemainingMinutesInOven(int minutesInOven) => (40 - minutesInOven);

    public static int PreparationTimeInMinutes(int layers) => (layers * 2);

    public static int ElapsedTimeInMinutes(int layers, int minutesInOven) => (PreparationTimeInMinutes(layers) + minutesInOven);
}
