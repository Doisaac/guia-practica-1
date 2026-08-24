namespace Ejercicio1_Abstraccion;

public class CuentaBancaria
{
  // Atributos con abstracción
  private decimal _saldo;

  // Métodos 
  
  /// <summary>
  ///  Deposita un monto en la cuenta bancaria, con validación para asegurar que el monto sea mayor que cero.
  /// </summary>
  /// <param name="montoADepositar">El monto a depositar</param>
  /// <exception cref="ArgumentException">La excepción se lanza cuando el monto a depositar es menor o igual a cero.</exception>
  public void Depositar(decimal montoADepositar)
  {
    if (montoADepositar <= 0)
    {
      throw new ArgumentException("El monto a depositar debe ser mayor que cero. Por favor verifique el valor ingresado.");
    }

    _saldo += montoADepositar;
  }
  
  /// <summary>
  ///  Retira un monto de la cuenta bancaria, con validación para asegurar que el monto sea mayor que cero y que no exceda el saldo disponible.
  /// </summary>
  /// <param name="montoARetirar">El monto a retirar</param>
  /// <exception cref="ArgumentException">La excepción se lanza cuando el monto a retirar es menor o igual a cero.</exception>
  /// <exception cref="InvalidOperationException">La excepción se lanza cuando el monto a retirar excede el saldo disponible.</exception>
  public void Retirar(decimal montoARetirar)
  {
    if (montoARetirar <= 0)
    {
      throw new ArgumentException("El monto a retirar debe ser mayor que cero. Por favor verifique el valor ingresado.");
    }

    if (montoARetirar > _saldo)
    {
      throw new InvalidOperationException("Fondos insuficientes para realizar el retiro. Por favor verifique el saldo disponible.");
    }

    _saldo -= montoARetirar;
  }
  
  /// <summary>
  ///  Consulta el saldo de la cuenta bancaria.
  /// </summary>
  /// <returns>El saldo de la cuenta.</returns>
  public decimal ConsultarSaldo()
  {
    return _saldo;
  }
}