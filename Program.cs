namespace ejercicio8Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] palabras = { "Hola", "Adiós", "Nuevo", "Viejo", "Vamos" };
            int posicionAdios = Array.IndexOf(palabras, "Adiós");
            Console.WriteLine("La palabra 'Adiós' se encuentra en la posición: " + posicionAdios);
            Console.Write("Ingrese una palabra: ");
            string palabraUsuario = Console.ReadLine();

            if (Array.Exists(palabras, palabra => palabra == palabraUsuario))
                Console.WriteLine("La palabra ingresada existe en el array.");
            else
                Console.WriteLine("La palabra ingresada no existe en el array.");

           
            int[] numeros = { 1, 5, 7, 8, 4, 3, 9 };

            var numerosMayoresQue3 = numeros.Where(num => num > 3).ToArray();
            Console.WriteLine("Números mayores que 3:");
            foreach (var numero in numerosMayoresQue3)
            {
                Console.WriteLine(numero);
            }


        }
    }
}