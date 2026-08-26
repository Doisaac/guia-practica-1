namespace Ejercicio3_Herencia_Simple;
  
/// <summary>
/// Clase para representar un coche, que hereda de la clase Vehículo.
/// </summary>
public class Coche : Vehiculo
{
  /// <summary>
  /// Conduce el coche. </summary>
  public void Conducir ()
  {
    Console.WriteLine("El coche está siendo conducido");
  }
}