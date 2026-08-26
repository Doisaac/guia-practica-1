namespace Ejercicio5_HerenciaMultinivel;

/// <summary>
/// Clase intermedia abstracta que hereda de Animal e introduce características propias de los mamíferos.
/// </summary>
public abstract class Mamifero : Animal
{
    /// <summary>
    /// Constructor protegido de la clase intermedia Mamifero.
    /// Delega la inicialización del nombre a la clase base Animal.
    /// </summary>
    /// <param name="nombre">Nombre del mamífero.</param>
    protected Mamifero(string nombre) : base(nombre)
    {
    }

    /// <summary>
    /// Método introducido en el segundo nivel de la jerarquía para simular la alimentación de crías.
    /// </summary>
    public virtual void Alimentar()
    {
        Console.WriteLine($"[Mamífero] {Nombre} está amamantando y alimentando a sus crías.");
    }
}