using Ejercicio5_HerenciaMultinivel;

Console.WriteLine();
Console.WriteLine("** Ejercicio 5: Herencia Multinivel y Sobrescritura **");
Console.WriteLine();

try
{

    string nombreValido = string.Empty;
    string razaValida = string.Empty;

    // 1. Validación interactiva del Nombre
    while (string.IsNullOrEmpty(nombreValido))
    {
        Console.Write("Ingrese el nombre del perro: ");
        string entrada = Console.ReadLine() ?? "";

        try
        {
            Perro temp = new(entrada, "Temporal");
            nombreValido = temp.Nombre;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error en el nombre: {ex.Message} Intente de nuevo.\n");
        }
    }

    // 2. Validación interactiva de la Raza
    while (string.IsNullOrEmpty(razaValida))
    {
        Console.Write("Ingrese la raza del perro: ");
        string entrada = Console.ReadLine() ?? "";

        try
        {
            Perro temp = new(nombreValido, entrada);
            razaValida = temp.Raza;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error en la raza: {ex.Message} Intente de nuevo.\n");
        }
    }

    // 3. Instanciación definitiva
    Perro miPerro = new(nombreValido, razaValida);
    Console.WriteLine("\nRegistro completado exitosamente.");
    miPerro.MostrarInformacion();
    Console.WriteLine();

    // 4. Menú interactivo demostrativo
    bool continuar = true;
    while (continuar)
    {
        Console.WriteLine("Menú de Operaciones:");
        Console.WriteLine("1. Ejecutar HacerSonido() [Método sobrescrito de Animal]");
        Console.WriteLine("2. Ejecutar Alimentar()   [Método heredado de Mamifero]");
        Console.WriteLine("3. Modificar Datos del Perro");
        Console.WriteLine("4. Consultar Ficha Completa");
        Console.WriteLine("5. Salir");
        Console.Write("Seleccione una opción (1-5): ");

        string? opcion = Console.ReadLine();
        Console.WriteLine();

        switch (opcion)
        {
            case "1":
                miPerro.HacerSonido();
                break;

            case "2":
                miPerro.Alimentar();
                break;

            case "3":
                ModificarDatos(miPerro);
                break;

            case "4":
                miPerro.MostrarInformacion();
                break;

            case "5":
                continuar = false;
                Console.WriteLine("Saliendo del programa...");
                break;

            default:
                Console.WriteLine("Opción inválida. Seleccione una opción entre 1 y 5.");
                break;
        }

        Console.WriteLine();
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Error no controlado: {ex.Message}");
}

// Submenú para modificar datos con validación encapsulada
void ModificarDatos(Perro perro)
{
    Console.WriteLine("-- Modificar Datos --");
    Console.WriteLine("a. Modificar Nombre");
    Console.WriteLine("b. Modificar Raza");
    Console.Write("Seleccione qué desea modificar (a/b): ");
    string subOpcion = (Console.ReadLine() ?? "").Trim().ToLower();

    if (subOpcion == "a")
    {
        Console.Write("Ingrese el nuevo nombre: ");
        string nuevoNombre = Console.ReadLine() ?? "";
        try
        {
            perro.Nombre = nuevoNombre;
            Console.WriteLine("Nombre actualizado exitosamente.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al actualizar nombre: {ex.Message}");
        }
    }
    else if (subOpcion =="b")
    {
        Console.Write("Ingrese la nueva raza: ");
        string nuevaRaza = Console.ReadLine() ?? "";
        try
        {
            perro.Raza = nuevaRaza;
            Console.WriteLine("Raza actualizada exitosamente.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al actualizar raza: {ex.Message}");
        }
    }
    else
    {
        Console.WriteLine("Opción de modificación inválida.");
    }
}