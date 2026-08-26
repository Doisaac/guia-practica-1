namespace Ejercicio4_Polimorfismo;

/// <summary>
/// Representa a un Gato, derivado de la clase base Animal.
/// </summary>
public class Gato : Animal
{
    /// <summary>
    /// Constructor para inicializar una nueva instancia de Gato.
    /// </summary>
    /// <param name="nombre">Nombre asignado al gato.</param>
    public Gato(string nombre) : base(nombre)
    {
    }

    /// <summary>
    /// Sobrescribe el método HacerSonido para emitir el maullido característico.
    /// </summary>
    public override void HacerSonido()
    {
        Console.WriteLine($"[Gato] {Nombre} dice: ¡Miau, miau!");
    }
}