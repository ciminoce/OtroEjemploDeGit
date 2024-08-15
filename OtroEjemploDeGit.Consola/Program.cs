
namespace OtroEjemploDeGit.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Resolución del Problema");
            Console.Write("Ingrese un número:");
            var numeroIngresado = int.Parse(Console.ReadLine());
            Console.Write("Ingrese multiplicador:");
            var multiplicador = int.Parse(Console.ReadLine());
            var multiplo = Multiplicar(numeroIngresado, multiplicador);
            Console.WriteLine($"{numeroIngresado} multiplicado por {multiplicador} es {multiplo}");
        }

        private static int Multiplicar(int numero, int numeroPor) => numero * numeroPor;
    }
}
