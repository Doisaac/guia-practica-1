namespace Ejercicio3_Herencia_Simple;

/// <summary>
/// Clase base para representar un vehículo.
/// </summary>
public class Vehiculo
{
  /// <summary>
  /// Arranca el vehículo.
  /// </summary>
  public void Arrancar ()
  {
    Console.WriteLine("El vehículo ha arrancado");
  }

  /// <summary>
  /// Detiene el vehículo.
  /// </summary>
  public void Detener ()
  {
    Console.WriteLine("El vehículo ha sido detenido");
  }
}