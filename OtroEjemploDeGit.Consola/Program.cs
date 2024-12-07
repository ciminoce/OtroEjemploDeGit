
namespace OtroEjemploDeGit.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Resolución del Problema");
            var numeroIngresado = GetInt("Ingrese un número:", 1, 12);
            var multiplicador = GetInt("Ingrese multiplicador:", 1, 12);
            var multiplo = Multiplicar(numeroIngresado, multiplicador);
            Console.WriteLine($"{numeroIngresado} multiplicado por {multiplicador} es {multiplo}");
        }

        private static int Multiplicar(int numero, int numeroPor) => numero * numeroPor;
        private static int GetInt(string mensaje, int min, int max)
        {
            int entrada = 0;
            do
            {
                Console.Write(mensaje);
                if (int.TryParse(Console.ReadLine(), out entrada) || entrada >= min && entrada <= max)
                {
                    break;
                }
                Console.WriteLine("Error: entrada mal ingresada o fuera de los límites");

            } while (true);
            return entrada;
        }
    }
}
