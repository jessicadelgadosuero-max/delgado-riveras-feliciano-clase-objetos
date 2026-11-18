using System;
using System.Security.Cryptography.X509Certificates;

namespace TecnoPunto
{
    class Program
    {
        // Aqui empieza el programa principal pidiendo los 3 productos unos por uno
        static void Main(string[] args)
        {
            Console.WriteLine("=============================================");
            Console.WriteLine("       CONTROL DE INVENTARIO - TECNOPUNTO    ");
            Console.WriteLine("=============================================");

            // Producto 1
            Console.WriteLine("Registro del Producto 1:");
            Producto p1 = CapturarProducto();

            // Producto 2
            Console.WriteLine("\nRegistro del Producto 2:");
            Producto p2 = CapturarProducto();

            //Producto 3
            Console.WriteLine("\nRegistro del Producto 3:");
            Producto p3 = CapturarProducto();

            // limpieza de pantalla para mostrar el reporte limpio
            Console.Clear();
            Console.WriteLine("=============================================");
            Console.WriteLine("       INVENTARIO GENERAL DE PRODUCTOS       ");
            Console.WriteLine("=============================================");

            // Muestra la informacion de los productos registrados
            p1.MostrarInformacion();
            p2.MostrarInformacion();
            p3.MostrarInformacion();

            Console.WriteLine("\nPresione cualquier tecla para finalizar el programa...");
            Console.ReadKey();
        }

        // 2. Metodo auxiliar de captura segura
        // Solicita los datos por teclado y utiliza bloques try-catch para capturar 
        // errores de tipo o excepciones de validación de la clase, evitando que el programa 
        // se cierre inesperadamente.
        static Producto CapturarProducto()
        {
            while (true) // Bucle infinito hasta que se capture un producto válido
            {
                try
                {
                    Console.Write("Ingrese el Codigo: ");
                    string codigo = Console.ReadLine();

                    Console.Write("Ingrese el Nombre: ");
                    string nombre = Console.ReadLine();

                    Console.Write("Ingrese el Precio: ");
                    decimal precio = Convert.ToDecimal(Console.ReadLine());

                    Console.Write("Ingrese la Cantidad: ");
                    int cantidad = Convert.ToInt32(Console.ReadLine());

                    // Instanciacion del objeto evaluando las reglas del constructor
                    Producto producto = new Producto(codigo, nombre, precio, cantidad);
                    Console.WriteLine("-> ¡Producto registrado con éxito!\n");
                    return producto;

                }
                catch (FormatException)
                {
                    // Controla errores si el usuario ingresa letras en lugar de numeros decimales/enteros
                    Console.WriteLine("Error: Debe ingresar un valor numérico válido para el precio y la cantidad. Intente de nuevo.\n");
                }
                catch (ArgumentException ex)
                {
                    // Si el usuario ingresa un valor inválido para nombre, precio o cantidad, se captura la excepción y se muestra el mensaje de error
                    Console.WriteLine($"[Error de validación] {ex.Message} Intente de nuevo.\n");
                }
            }
        }
    }
}