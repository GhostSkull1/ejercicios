using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{


    //1.	Contraseña válida
    //Escribir una función llamada contrasenaValida que reciba un string y retorne true si el string es igual a "2Fj(jjbFsuj" o "eoZiugBf&g9". De lo contrario debe retornar false.


    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.Write("Ingrese la contraseña: ");
    //        string password = Console.ReadLine();

    //        bool esValida = ContrasenaValida(password);
    //        Console.WriteLine($"La contraseña es valida: {esValida}");

    //        Console.WriteLine("Presiona cualquier tecla para salir...");
    //        Console.ReadKey();
    //    }

    //    static bool ContrasenaValida(string password)
    //    {
    //        string[] validPasswords = { "2Fj(jjbFsuj", "eoZiugBf&g9" };

    //        foreach (string validPassword in validPasswords)
    //        {
    //            if (password == validPassword)
    //            {
    //                return true;
    //            }
    //        }
    //        return false;
    //    }
    //}



    //2.	Calcular impuestos
    //Escribir una función llamada calcularImpuestos que reciba dos argumentos numéricos: edad e ingresos.Si edad es igual o mayor a 18 y los ingresos son iguales o mayores a 1000 debe retornar ingresos* 40%. De lo contrario retornar 0.

    //class Program
    //{
    //    static void Main(string[] args)
    //    {

    //        Console.Write("Ingrese la edad: ");
    //        string edadInput = Console.ReadLine();
    //        int edad;

    //        if (!int.TryParse(edadInput, out edad))
    //        {
    //            Console.WriteLine("La edad debe ser un número entero.");
    //            return;
    //        }

    //        Console.Write("Ingrese los ingresos: ");
    //        string ingresosInput = Console.ReadLine();
    //        double ingresos;

    //        if (!double.TryParse(ingresosInput, out ingresos))
    //        {
    //            Console.WriteLine("Los ingresos deben ser un numero decimal.");
    //            return;
    //        }

    //        double impuestos = CalcularImpuestos(edad, ingresos);
    //        Console.WriteLine($"El monto de impuestos a pagar es: {impuestos}");

    //        Console.WriteLine("Presiona cualquier tecla para salir.");
    //        Console.ReadKey();
    //    }

    //    static double CalcularImpuestos(int edad, double ingresos)
    //    {
    //        if (edad >= 18 && ingresos >= 1000)
    //        {
    //            return ingresos * 0.40;
    //        }
    //        else
    //        {
    //            return 0;
    //        }
    //    }
    //}





    //3.	IMC(ïndice de masa corporal)
    //El índice de masa corporal(IMC), o BMI por sus siglas en inglés, es un valor que determina la cantidad de grasa de una persona.
    //El BMI se calcula con la siguiente formula: peso / altura^2
    //Escribir una función llamada bmi que reciba dos argumentos: peso y altura, y retorne un string con las siguientes posibilidades:

    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        // Crear una instancia de CultureInfo para manejar puntos como separadores decimales
    //        CultureInfo culture = CultureInfo.InvariantCulture;

    //        Console.Write("Ingrese el peso en kilogramos: ");
    //        double peso;
    //        while (!TryParseDouble(Console.ReadLine(), out peso, culture))
    //        {
    //            Console.Write("Entrada inválida. Ingrese un peso válido en kilogramos: ");
    //        }

    //        Console.Write("Ingrese la altura en metros: ");
    //        double altura;
    //        while (!TryParseDouble(Console.ReadLine(), out altura, culture))
    //        {
    //            Console.Write("Entrada inválida. Ingrese una altura válida en metros: ");
    //        }

    //        double alturaCuadrada = altura * altura;
    //        double imc = peso / alturaCuadrada;

    //        string resultado = Bmi(imc);

    //        Console.WriteLine($"El IMC es: {imc}");
    //        Console.WriteLine($"Categoría: {resultado}");
    //        Console.ReadLine();
    //    }

    //    public static bool TryParseDouble(string input, out double result, CultureInfo culture)
    //    {
    //        // Intentar convertir la entrada usando la configuración regional
    //        return double.TryParse(input, NumberStyles.Float, culture, out result);
    //    }

    //    public static string Bmi(double imc)
    //    {
    //        if (imc < 18.5)
    //        {
    //            return "Bajo peso";
    //        }
    //        else if (imc < 24.9)
    //        {
    //            return "Peso normal";
    //        }
    //        else if (imc < 29.9)
    //        {
    //            return "Sobrepeso";
    //        }
    //        else
    //        {
    //            return "Obesidad";
    //        }
    //    }
    //}






    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        Console.Write("Ingrese el peso en kilogramos: ");
    //        double peso;
    //        while (!double.TryParse(Console.ReadLine(), out peso) || peso <= 0)
    //        {
    //            Console.Write("Entrada inválida. Ingrese un peso válido en kilogramos: ");
    //        }

    //        Console.Write("Ingrese la altura en metros separada por la coma ' , ': ");
    //        double altura;
    //        while (!double.TryParse(Console.ReadLine(), out altura) || altura <= 0)
    //        {
    //            Console.Write("Entrada inválida. Ingrese una altura válida en metros: ");
    //        }

    //        string resultado = Bmi(peso, altura);
    //        Console.WriteLine($"El resultado del IMC es: {resultado}");
    //        Console.ReadLine();
    //    }

    //    public static string Bmi(double peso, double altura)
    //    {
    //        if (altura <= 0)
    //        {
    //            throw new ArgumentException("La altura debe ser mayor que cero.");
    //        }

    //        double imc = peso / (altura * altura);

    //        if (imc < 18.5)
    //        {
    //            return "Bajo peso";
    //        }
    //        else if (imc < 24.9)
    //        {
    //            return "Peso normal";
    //        }
    //        else if (imc < 29.9)
    //        {
    //            return "Sobrepeso";
    //        }
    //        else
    //        {
    //            return "Obesidad";
    //        }
    //    }
    //}




    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        double peso = 110;
    //        double altura = 1.75;

    //        string resultado = Bmi(peso, altura);
    //        Console.WriteLine(resultado);
    //        Console.ReadLine();
    //    }

    //    public static string Bmi(double peso, double altura)
    //    {
    //        if (altura <= 0)
    //        {
    //            throw new ArgumentException("La altura debe ser mayor que cero.");
    //        }

    //        double imc = peso / (altura * altura);

    //        if (imc < 18.5)
    //        {
    //            return "Bajo peso";
    //        }
    //        else if (imc < 24.9)
    //        {
    //            return "Peso normal";
    //        }
    //        else if (imc < 29.9)
    //        {
    //            return "Sobrepeso";
    //        }
    //        else
    //        {
    //            return "Obesidad";
    //        }
    //    }
    //}







    //4.	Imprimir un arreglo
    //Escribir una función llamada imprimirArreglo que reciba un arreglo e imprima cada elemento en una línea a parte:


    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.Write("¿Cuántos números deseas ingresar? ");
    //        if (int.TryParse(Console.ReadLine(), out int cantidad) && cantidad > 0)
    //        {
    //            List<int> numeros = new List<int>();

    //            for (int i = 0; i < cantidad; i++)
    //            {
    //                Console.Write($"Ingrese el número {i + 1}: ");
    //                if (int.TryParse(Console.ReadLine(), out int numero))
    //                {
    //                    numeros.Add(numero);
    //                }
    //                else
    //                {
    //                    Console.WriteLine("Entrada no válida. Se omitirá este número.");
    //                }
    //            }

    //            int[] arreglo = numeros.ToArray();
    //            imprimirArreglo(arreglo);
    //        }
    //        else
    //        {
    //            Console.WriteLine("Entrada no válida. Debes ingresar un número positivo.");
    //        }

    //        Console.WriteLine("Presiona cualquier tecla para salir.");
    //        Console.ReadKey();
    //    }

    //    static void imprimirArreglo(int[] arreglo)
    //    {
    //        foreach (int elemento in arreglo)
    //        {
    //            Console.WriteLine(elemento);
    //        }
    //    }
    //}



    //5.	Número de Likes
    //Escribe una función llamada likes que reciba un número y retorne un string utilizando el formato de K para miles y M para millones.
    //Por ejemplo:
    //•	1400 se convierte en 1K
    //•	34,567 se convierte en 34K
    //•	7’456,345 se convierte en 7M.
    //Si el número es menor a 1000 se debe devolver el mismo número como un string.

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        while (true)
    //        {
    //            Console.Write("Ingrese un número del 1 a un millon (o salir para terminar): ");
    //            string input = Console.ReadLine();

    //            if (input.ToLower() == "salir")
    //            {
    //                break;
    //            }

    //            if (int.TryParse(input, out int number))
    //            {
    //                Console.WriteLine(likes(number));
    //            }
    //            else
    //            {
    //                Console.WriteLine("Entrada no válida. Por favor, ingrese un número válido.");
    //            }
    //        }

    //        Console.WriteLine("Presiona cualquier tecla para salir.");
    //        Console.ReadKey();
    //    }

    //    static string likes(int number)
    //    {
    //        if (number < 1000)
    //        {
    //            return number.ToString();
    //        }
    //        else if (number < 1000000)
    //        {
    //            return (number / 1000) + "K";
    //        }
    //        else
    //        {
    //            return (number / 1000000) + "M";
    //        }
    //    }
    //}





    //6.	FizzBuzz
    //Escribir una función llamada fizzBuzz que reciba un número y retorne un string de acuerdo con lo siguiente:
    //•	"fizz" si el número es múltiplo de 3.
    //•	"buzz" si el número es múltiplo de 5.
    //•	"fizzbuzz" si el número es múltiplo tanto de 3 como de 5.
    //•	Si no cumple ninguna de las condiciones anteriores debe retornar el mismo número.

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        while (true)
    //        {
    //            Console.Write("Ingrese un número o la palabra salir para terminar: ");
    //            string input = Console.ReadLine();

    //            if (input.ToLower() == "salir")
    //            {
    //                break;
    //            }

    //            if (int.TryParse(input, out int numero))
    //            {
    //                Console.WriteLine(fizzBuzz(numero));
    //            }
    //            else
    //            {
    //                Console.WriteLine("Entrada no válida. Por favor, ingrese un número válido.");
    //            }
    //        }

    //        Console.WriteLine("Presiona cualquier tecla para salir.");
    //        Console.ReadKey();
    //    }

    //    static string fizzBuzz(int numero)
    //    {
    //        if (numero % 3 == 0 && numero % 5 == 0)
    //        {
    //            return "fizzbuzz";
    //        }
    //        else if (numero % 3 == 0)
    //        {
    //            return "fizz";
    //        }
    //        else if (numero % 5 == 0)
    //        {
    //            return "buzz";
    //        }
    //        else
    //        {
    //            return numero.ToString();
    //        }
    //    }
    //}






    //7.	Contar rango de números
    //Escribir una función llamada contarRango que reciba dos números y retorne cuántos números que hay entre ellos(excluyéndolos) :
    //Nota: Utiliza un ciclo en tu solución.Puedes asumir que el primer número va a ser menor que el segundo.


    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.Write("Ingrese el primer número: ");
    //        string entradaInicio = Console.ReadLine();
    //        int inicio;

    //        if (!int.TryParse(entradaInicio, out inicio))
    //        {
    //            Console.WriteLine("El valor ingresado no es un número válido.");
    //            return;
    //        }

    //        Console.Write("Ingrese el segundo número: ");
    //        string entradaFin = Console.ReadLine();
    //        int fin;
    //        if (!int.TryParse(entradaFin, out fin))
    //        {
    //            Console.WriteLine("El valor ingresado no es un número válido.");
    //            return;
    //        }

    //        if (inicio >= fin)
    //        {
    //            Console.WriteLine("El primer número debe ser menor que el segundo.");
    //            return;
    //        }

    //        int resultado = contarRango(inicio, fin);
    //        Console.WriteLine($"La cantidad de números entre {inicio} y {fin} (excluyendo los extremos) es: {resultado}");

    //        Console.WriteLine("Presiona cualquier tecla para salir.");
    //        Console.ReadKey();
    //    }

    //    static int contarRango(int inicio, int fin)
    //    {
    //        int contador = 0;

    //        for (int i = inicio + 1; i < fin; i++)
    //        {
    //            contador++;
    //        }
    //        return contador;
    //    }
    //}





    //8.	Sumar rango de números
    //Escribir una función llamada sumarRango que reciba dos argumentos: número inicial y número final.La función debe retornar la suma de los números en ese rango(incluyéndolos).
    //Nota: puedes asumir que el número inicial va a ser menor o igual que el número final.



    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.Write("Ingrese el número inicial: ");
    //        string entradaInicio = Console.ReadLine();
    //        int inicio;

    //        if (!int.TryParse(entradaInicio, out inicio))
    //        {
    //            Console.WriteLine("El valor ingresado no es un número válido.");
    //            return;
    //        }

    //        Console.Write("Ingrese el número final: ");
    //        string entradaFin = Console.ReadLine();
    //        int fin;

    //        if (!int.TryParse(entradaFin, out fin))
    //        {
    //            Console.WriteLine("El valor ingresado no es un número válido.");
    //            return;
    //        }

    //        if (inicio > fin)
    //        {
    //            Console.WriteLine("El número inicial debe ser menor o igual que el número final.");
    //            return;
    //        }

    //        int resultado = sumarRango(inicio, fin);
    //        Console.WriteLine($"La suma de los números entre {inicio} y {fin} (incluyéndolos) es: {resultado}");

    //        Console.WriteLine("Presiona cualquier tecla para salir.");
    //        Console.ReadKey();
    //    }

    //    static int sumarRango(int inicio, int fin)
    //    {
    //        int suma = 0;

    //        for (int i = inicio; i <= fin; i++)
    //        {
    //            suma += i;
    //        }
    //        return suma;
    //    }
    //}


    //9.	Número de aes(letra "a")
    //Escribir una función llamada numeroDeAes que reciba un string y retorne el número de veces que aparece la letra "a":



    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.Write("Ingrese una cadena de texto: ");
    //        string entrada = Console.ReadLine();

    //        int conteo = numeroDeAes(entrada);
    //        Console.WriteLine($"El número de veces que aparece la letra 'a' es: {conteo}");

    //        Console.WriteLine("Presiona cualquier tecla para salir.");
    //        Console.ReadKey();
    //    }

    //    static int numeroDeAes(string texto)
    //    {
    //        int contador = 0;

    //        foreach (char c in texto)
    //        {
    //            if (c == 'a')
    //            {
    //                contador++;
    //            }
    //        }
    //        return contador;
    //    }
    //}


    //10.	Número de caracteres
    //Escribir una función llamada numeroDeCaracteres que reciba un string y un caracter(un string de un caracter). La función debe retornar el número de veces que aparece el caracter en el string.


    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.Write("Ingrese una cadena de texto: ");
    //        string texto = Console.ReadLine();

    //        Console.Write("Ingrese el carácter a buscar: ");
    //        string caracterBusqueda = Console.ReadLine();

    //        if (caracterBusqueda.Length != 1)
    //        {
    //            Console.WriteLine("Debe ingresar un solo carácter.");
    //            return;
    //        }

    //        char caracter = caracterBusqueda[0];
    //        int conteo = numeroDeCaracteres(texto, caracter);
    //        Console.WriteLine($"El número de veces que aparece el carácter '{caracter}' es: {conteo}");

    //        Console.WriteLine("Presiona cualquier tecla para salir.");
    //        Console.ReadKey();
    //    }

    //    static int numeroDeCaracteres(string texto, char caracter)
    //    {
    //        int contador = 0;

    //        foreach (char c in texto)
    //        {
    //            if (c == caracter)
    //            {
    //                contador++;
    //            }
    //        }
    //        return contador;
    //    }
    //}




}
