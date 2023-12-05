internal class Program
{
    private static void Main(string[] args)
    {
        int ZeroToShow=0; // ZeroToShow mostrara los numeros de la secuencia Fibonnacci esta se inicializa en 0 
        int ZeroDontSee=0; // ZeroDontSee se usara para igualar el valor de ZeroToShow esto para reemplazar el valor que posee ZeroToShow
        int NumberOne=1; // NumberOne es una variable que contiene el numero uno, esto para indicar que esta variable va a estar por delante de las anteriores dos

        for (int i = 0; i < 20; i++)
        {
            Console.Write($"{ZeroToShow}, ");
            ZeroDontSee = ZeroToShow;
            ZeroToShow = NumberOne;
            NumberOne = ZeroDontSee + NumberOne;
        }
    }
}