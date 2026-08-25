using Ejercicio2_Encapsulacion;

Console.WriteLine();
Console.WriteLine("**** Ejercicio 2: Encapsulación y Control de Acceso ****");
Console.WriteLine();

try
{
    Empleado? empleado = null;

    // 1. Captura y validación del Nombre inicial
    string nombreValido = string.Empty;
    while (string.IsNullOrEmpty(nombreValido))
    {
        Console.Write("Ingrese el nombre del empleado: ");
        string entrada = Console.ReadLine() ?? "";

        try
        {
            // Usamos una instancia temporal o validamos asignando a una propiedad
            Empleado temp = new Empleado(entrada, 25);
            nombreValido = temp.Nombre;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error en el nombre: {ex.Message} Intente de nuevo.\n");
        }
    }

    // 2. Captura y validación de la Edad inicial
    int edadValida = 0;
    while (edadValida == 0)
    {
        Console.Write("Ingrese la edad del empleado: ");
        string entrada = Console.ReadLine() ?? "";

        if (!int.TryParse(entrada, out int edadIngresada))
        {
            Console.WriteLine("Error: La edad debe ser un número entero válido. Intente de nuevo.\n");
            continue;
        }

        try
        {
            // Validamos mediante el constructor
            empleado = new Empleado(nombreValido, edadIngresada);
            edadValida = edadIngresada;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error en la edad: {ex.Message} Intente de nuevo.\n");
        }
    }

    Console.WriteLine();
    Console.WriteLine("Registro inicial exitoso.");
    empleado!.MostrarInformacion();
    Console.WriteLine();

    // 3. Menú interactivo de operaciones
    bool continuar = true;
    while (continuar)
    {
        Console.WriteLine("Menú de Operaciones:");
        Console.WriteLine("1. Modificar Nombre");
        Console.WriteLine("2. Modificar Edad");
        Console.WriteLine("3. Consultar Información");
        Console.WriteLine("4. Salir");
        Console.Write("Seleccione una opción (1-4): ");

        string? opcion = Console.ReadLine();
        switch (opcion)
        {
            case "1":
                Console.Write("Ingrese el nuevo nombre: ");
                string nuevoNombre = Console.ReadLine() ?? "";
                try
                {
                    empleado.Nombre = nuevoNombre;
                    Console.WriteLine("Nombre actualizado exitosamente.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al actualizar nombre: {ex.Message}");
                }
                break;

            case "2":
                Console.Write("Ingrese la nueva edad: ");
                if (!int.TryParse(Console.ReadLine(), out int nuevaEdad))
                {
                    Console.WriteLine("Error: Ingrese un valor numérico entero válido.");
                    break;
                }

                try
                {
                    empleado.Edad = nuevaEdad;
                    Console.WriteLine($"Edad actualizada exitosamente. Nueva edad: {empleado.Edad} años");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al actualizar edad: {ex.Message}");
                }
                break;

            case "3":
                empleado.MostrarInformacion();
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
    Console.WriteLine($"Error general en la ejecución: {ex.Message}");
}