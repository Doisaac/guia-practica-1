using Ejercicio1_Abstraccion;

Console.WriteLine();
Console.WriteLine("**** Ejercicio 1: Implementación de Abstracción de Datos ****");
Console.WriteLine();

CuentaBancaria cuentaBancaria = new();

try
{
  bool continuar = true;
  while (continuar)
  {
    Console.WriteLine("Menú de Operaciones:");
    Console.WriteLine("1. Depositar");
    Console.WriteLine("2. Retirar");
    Console.WriteLine("3. Consultar Saldo");
    Console.WriteLine("4. Salir");
    Console.Write("Seleccione una opción (1-4): ");

    string? opcion = Console.ReadLine();
    switch (opcion)
    {
      case "1":
        Console.Write("Ingrese el monto a depositar: ");
    
        if (!decimal.TryParse(Console.ReadLine(), out decimal montoADepositar))
        {
          Console.WriteLine("Ingrese un monto válido.");
          break;
        }
        
        try
        {
          cuentaBancaria.Depositar(montoADepositar);
          Console.WriteLine($"Depósito exitoso. Nuevo saldo: ${cuentaBancaria.ConsultarSaldo():0.00}");
        }
        catch(Exception ex)
        {
          Console.WriteLine($"Error al depositar: {ex.Message}");
          break;
        }
        break;

      case "2":
        Console.Write("Ingrese el monto a retirar: ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal montoARetirar))
        {
          Console.WriteLine("Ingrese un monto válido.");
          break;
        }

        try
        {
          cuentaBancaria.Retirar(montoARetirar);
          Console.WriteLine($"Retiro exitoso. Nuevo saldo: ${cuentaBancaria.ConsultarSaldo():0.00}");
        }
        catch(Exception ex)
        {
          Console.WriteLine($"Error al retirar: {ex.Message}");
          break;
        }
        break;

      case "3":
        Console.WriteLine($"Saldo actual: ${cuentaBancaria.ConsultarSaldo():0.00}");
        break;

      case "4":
        continuar = false;
        Console.WriteLine("Saliendo del programa...");
        break;

      default:
        Console.WriteLine("Opción inválida. Por favor seleccione una opción válida (1-4).");
        break;
    }

    Console.WriteLine();
  }
}
catch (Exception ex)
{
  Console.WriteLine($"Error: {ex.Message}");
}
