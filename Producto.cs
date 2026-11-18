using System;
namespace TecnoPunto
{
    public class Producto
    {
        // Campos privados para encapsular la informacion.
        private string _codigo;
        private string _nombre;
        private decimal _precio;
        private int _cantidad;

        // Propiedades del codigo
        public string Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }

        }
        // Propiedad nombre (validacion simple: verifica si es nulo o esta vacio)
        public string Nombre
        {
            get { return _nombre; }
            set
            {
                if (string.IsNullOrEmpty(value) || value == "")
                {
                    throw new ArgumentException("El nombre del producto no puede estar vacío.");
                }
                _nombre = value;
            }
        }
        //Propiedad precio( validacion simple: verifica si es nulo o esta vacio)
        public decimal Precio
        {
            get { return _precio; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("El precio del producto no puede ser negativo.");
                }
                _precio = value;
            }
        }

        // Propiedad Cantidad (validacion simple: no negativa)
        public int Cantidad
        {
            get { return _cantidad; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("La cantidad del producto no puede ser negativa.");
                }
                _cantidad = value;
            }
        }

        // Propiedad para calcular el valor total del producto (precio * cantidad)

        public decimal ValorTotal
        {
            get { return _precio * _cantidad; }
        }

        public Producto(string codigo, string nombre, decimal precio, int cantidad)
        {
            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
            Cantidad = cantidad;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine("_________________________________________");
            Console.WriteLine($"Código: {Codigo}");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Precio: {Precio:C}");
            Console.WriteLine($"Cantidad: {Cantidad}");
            Console.WriteLine($"Valor Total: {ValorTotal:C}");
            Console.WriteLine("_________________________________________");
        }
    }

}