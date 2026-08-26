using System.Linq;

namespace Ejercicio5_HerenciaMultinivel;

/// <summary>
/// Clase base abstracta en el nivel superior de la jerarquía de herencia.
/// </summary>
public abstract class Animal
{
    private string _nombre = string.Empty;

    /// <summary>
    /// Obtiene o establece el nombre del animal.
    /// Valida que no sea nulo, no esté vacío y no contenga dígitos numéricos.
    /// </summary>
    /// <exception cref="ArgumentException">Se lanza si el nombre es inválido o contiene números.</exception>
    public string Nombre
    {
        get => _nombre;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("El nombre del animal no puede estar vacío.");
            }

            string nombreLimpio = value.Trim();

            if (nombreLimpio.Any(char.IsDigit))
            {
                throw new ArgumentException("El nombre del animal no puede contener números.");
            }

            if (!nombreLimpio.Any(char.IsLetter))
            {
                throw new ArgumentException("El nombre del animal debe contener caracteres alfabéticos válidos.");
            }

            _nombre = nombreLimpio;
        }
    }

    /// <summary>
    /// Constructor protegido para inicializar la clase base Animal.
    /// </summary>
    /// <param name="nombre">Nombre asignado al animal.</param>
    protected Animal(string nombre)
    {
        Nombre = nombre;
    }

    /// <summary>
    /// Método abstracto que define la acción de emitir un sonido.
    /// Obliga a las clases derivadas a definir su propia implementación.
    /// </summary>
    public abstract void HacerSonido();
}