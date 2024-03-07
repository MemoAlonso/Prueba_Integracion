using System;

namespace Calculator
{
    class calculadora
    {
        static void Main(string[] args)
        {
            char opcion;
            double num1, num2, result;
            string continueOperation;// variable no inicializada para poder seguir ejecutando el programa 

            do// utilizando el bucle do while , el programa correra hasta que le solicitimes que se detenga 
            {
                Console.WriteLine("CALCULADORA - GUILLERMO ALONSO");
                Console.WriteLine("---------------------------------------------------------------------------------");
                Console.WriteLine("Seleccione una operación a realizar: \nS - Suma \nR - Resta \nM - Multiplicación \nD - División");
                Console.WriteLine("---------------------------------------------------------------------------------");
                opcion = char.Parse(Console.ReadLine().ToUpper());// Utilicé el comando ToUpper para que la opción que ingrese se transforme en mayusculas y acepte la opción

                switch (opcion)// usamos Switch para la elección de opciones 
                {
                    case 'S':// SUMA 
                        Console.WriteLine("Ingrese el primer número:");
                        num1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número:");
                        num2 = double.Parse(Console.ReadLine());
                        result = num1 + num2;
                        Console.WriteLine($"El resultado de la suma es: {result}");
                        break;
                    case 'R':// resta
                        Console.WriteLine("Ingrese el primer número:");
                        num1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número:");
                        num2 = double.Parse(Console.ReadLine());
                        result = num1 - num2;
                        Console.WriteLine($"El resultado de la resta es: {result}");
                        break;
                    case 'M':// multiplicación
                        Console.WriteLine("Ingrese el primer número:");
                        num1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número:");
                        num2 = double.Parse(Console.ReadLine());
                        result = num1 * num2;
                        Console.WriteLine($"El resultado de la multiplicación es: {result}");
                        break;
                    case 'D':// división 
                        Console.WriteLine("Ingrese el primer número:");
                        num1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número:");
                        num2 = double.Parse(Console.ReadLine());
                        if (num2 == 0)// aqui hay un condicional para que no se permita dividir para 0
                        {
                            Console.WriteLine("No se puede dividir un valor de cero.");// mensaje en caso de ingresar el 0
                        }
                        else
                        {
                            result = num1 / num2;
                            Console.WriteLine($"El resultado de la división es: {result}");
                        }
                        break;
                    default:// en caso de que ninguna de que la opcion ingresada no sea ninguna de las disponibles
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                Console.WriteLine("¿Desea continuar S/N?");
                continueOperation = Console.ReadLine().ToUpper();// to upper nuevamente para que indistinga entre mayusculas o minusculas al ingresar ya que se transforman 

            } while (continueOperation == "S");// el programa continuara ejecuntadose a menos de que ingresemos otro parametro
        }
    }
}