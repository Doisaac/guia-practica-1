namespace Ejercicio4_Polimorfismo;

/// <summary>
/// Clase base abstracta que representa a un animal genérico.
/// </summary>
public abstract class Animal
{
    private string _nombre = string.Empty;

    /// <summary>
    /// Obtiene o establece el nombre del animal.
    /// Valida que no esté vacío y no contenga dígitos numéricos.
    /// </summary>
    /// <exception cref="ArgumentException">Se lanza cuando el nombre es nulo, vacío o numérico.</exception>
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

            _nombre = nombreLimpio;
        }
    }

    /// <summary>
    /// Constructor protegido para inicializar la clase base Animal.
    /// </summary>
    /// <param name="nombre">Nombre del animal.</param>
    protected Animal(string nombre)
    {
        Nombre = nombre;
    }

    /// <summary>
    /// Método abstracto que define la acción de emitir un sonido.
    /// Debe ser implementado obligatoriamente por cada clase derivada.
    /// </summary>
    public abstract void HacerSonido();
}