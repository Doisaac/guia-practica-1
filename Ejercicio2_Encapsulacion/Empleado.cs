using System.Linq;

namespace Ejercicio2_Encapsulacion;

public class Empleado
{
    // Atributos privados para aplicar encapsulación y ocultamiento de información
    private string _nombre = string.Empty;
    private int _edad;

    // Propiedades públicas

    /// <summary>
    /// Obtiene o establece el nombre del empleado.
    /// Valida que no sea nulo, no esté vacío y contenga únicamente caracteres alfabéticos y espacios.
    /// </summary>
    /// <exception cref="ArgumentException">Se lanza cuando el nombre es nulo, vacío, contiene números o caracteres inválidos.</exception>
    public string Nombre
    {
        get => _nombre;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("El nombre del empleado no puede estar vacío.");
            }

            string nombreLimpio = value.Trim();

            // Valida que no contenga dígitos numéricos
            if (nombreLimpio.Any(char.IsDigit))
            {
                throw new ArgumentException("El nombre del empleado no puede contener números.");
            }

            // Valida que contenga al menos una letra válida
            if (!nombreLimpio.Any(char.IsLetter))
            {
                throw new ArgumentException("El nombre del empleado debe contener caracteres válidos.");
            }

            _nombre = nombreLimpio;
        }
    }

    /// <summary>
    /// Obtiene o establece la edad del empleado.
    /// Valida estrictamente que el valor sea mayor que 0 y menor que 100.
    /// </summary>
    /// <exception cref="ArgumentException">Se lanza cuando la edad es menor o igual a 0, o mayor o igual a 100.</exception>
    public int Edad
    {
        get => _edad;
        set
        {
            if (value <= 0 || value >= 100)
            {
                throw new ArgumentException("La edad debe ser mayor que 0 y menor que 100.");
            }

            _edad = value;
        }
    }

    /// <summary>
    /// Constructor para inicializar una nueva instancia de la clase Empleado.
    /// </summary>
    /// <param name="nombre">Nombre del empleado.</param>
    /// <param name="edad">Edad del empleado (mayor que 0 y menor que 100).</param>
    public Empleado(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    }

    /// <summary>
    /// Muestra en consola la información completa del empleado.
    /// </summary>
    public void MostrarInformacion()
    {
        Console.WriteLine($"Datos del Empleado -> Nombre: {Nombre} | Edad: {Edad} años");
    }
}