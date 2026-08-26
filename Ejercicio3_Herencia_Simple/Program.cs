using Ejercicio3_Herencia_Simple;

Console.WriteLine();
Console.WriteLine("**** Ejercicio 3: Herencia Simple ****");
Console.WriteLine();

try
{
  // Instancia de coche
  Coche coche = new();

  // Validaciones 
  bool cocheEncendido = false;
  bool cocheDetenido = true;
  bool cocheEnMovimiento = false;

  bool continuar = true;
  while (continuar)
  {
    Console.WriteLine("¿Qué desea hacer con el coche?");
    Console.WriteLine("1. Arrancar el coche");
    Console.WriteLine("2. Detener el coche");
    Console.WriteLine("3. Conducir el coche");
    Console.WriteLine("4. Salir");
    Console.Write("Ingrese el número de la opción deseada: ");

    string opcion = Console.ReadLine() ?? "";
    Console.WriteLine();

    switch (opcion)
    {
      case "1":
        if (cocheEncendido)
        {
          Console.WriteLine("El coche ya está arrancado.");
          break;
        }

        // Uso del método heredado de la clase base Vehículo
        coche.Arrancar();

        cocheEncendido = true;
        cocheDetenido = false;
        break;

      case "2":
        if (cocheDetenido)
        {
          Console.WriteLine("El coche ya está detenido.");
          break;
        }

        // Uso del método heredado de la clase base Vehículo
        coche.Detener();

        cocheDetenido = true;
        cocheEnMovimiento = false;
        break;

      case "3":
        if (!cocheEncendido)
        {
          Console.WriteLine("El coche no está arrancado. Por favor, arranque el coche primero.");
          break;
        }
        if (cocheEnMovimiento)
        {
          Console.WriteLine("El coche ya está en movimiento.");
          break;
        }

        // Uso del método específico de la clase derivada Coche
        coche.Conducir();
        
        cocheEnMovimiento = true;
        break;

      case "4":
        Console.WriteLine("Saliendo del programa...");
        continuar = false;
        break;

      default:
        Console.WriteLine("Opción no válida. Por favor, seleccione una opción del 1 al 4.");
        break;
    }
    Console.WriteLine();
  }   
} catch (Exception ex)
{
  Console.WriteLine($"Ocurrió un error: {ex.Message}");
}