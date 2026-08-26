using System.Linq;

namespace Ejercicio5_HerenciaMultinivel;

/// <summary>
/// Clase derivada final que hereda de Mamifero, completando la jerarquía multinivel:
/// Animal (Nivel 1) -> Mamifero (Nivel 2) -> Perro (Nivel 3).
/// </summary>
public class Perro : Mamifero
{
    private string _raza = string.Empty;

    /// <summary>
    /// Obtiene o establece la raza del perro.
    /// Valida que no sea nula, vacía ni contenga números.
    /// </summary>
    /// <exception cref="ArgumentException">Se lanza cuando la raza es inválida o numérica.</exception>
    public string Raza
    {
        get => _raza;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("La raza del perro no puede estar vacía.");
            }

            string razaLimpia = value.Trim();

            if (razaLimpia.Any(char.IsDigit))
            {
                throw new ArgumentException("La raza del perro no puede contener números.");
            }

            if (!razaLimpia.Any(char.IsLetter))
            {
                throw new ArgumentException("La raza debe contener caracteres válidos.");
            }

            _raza = razaLimpia;
        }
    }

    /// <summary>
    /// Constructor de la clase Perro.
    /// Delega la asignación del nombre a Mamifero y Animal mediante 'base(nombre)'.
    /// </summary>
    /// <param name="nombre">Nombre del perro.</param>
    /// <param name="raza">Raza del perro.</param>
    public Perro(string nombre, string raza) : base(nombre)
    {
        Raza = raza;
    }

    /// <summary>
    /// Sobrescribe el método abstracto HacerSonido() definido originalmente en la clase base Animal.
    /// </summary>
    public override void HacerSonido()
    {
        Console.WriteLine($"[Perro] {Nombre} ({Raza}) dice: ¡Guau, guau!");
    }

    /// <summary>
    /// Muestra la información del perro y su posición en la jerarquía multinivel.
    /// </summary>
    public void MostrarInformacion()
    {
        Console.WriteLine($"Ficha: Nombre: {Nombre} | Raza: {Raza} | Jerarquía: Animal -> Mamifero -> Perro");
    }
}