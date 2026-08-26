namespace Ejercicio4_Polimorfismo;

/// <summary>
/// Representa a un Perro, derivado de la clase base Animal.
/// </summary>
public class Perro : Animal
{
    /// <summary>
    /// Constructor para inicializar una nueva instancia de Perro.
    /// </summary>
    /// <param name="nombre">Nombre asignado al perro.</param>
    public Perro(string nombre) : base(nombre)
    {
    }

    /// <summary>
    /// Sobrescribe el método HacerSonido para emitir el ladrido característico.
    /// </summary>
    public override void HacerSonido()
    {
        Console.WriteLine($"[Perro] {Nombre} dice: ¡Guau, guau!");
    }
}