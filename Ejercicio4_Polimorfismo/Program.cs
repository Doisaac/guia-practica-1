using Ejercicio4_Polimorfismo;

Console.WriteLine();
Console.WriteLine("**** Ejercicio 4: Demostración de Polimorfismo ****");
Console.WriteLine();

// Colección polimórfica de tipo Animal
List<Animal> animales = new();

try
{
    bool continuar = true;
    while (continuar)
    {
        Console.WriteLine("Menú de Operaciones:");
        Console.WriteLine("1. Registrar Perro");
        Console.WriteLine("2. Registrar Gato");
        Console.WriteLine("3. Escuchar los sonidos de todos los animales (Polimorfismo)");
        Console.WriteLine("4. Salir");
        Console.Write("Seleccione una opción (1-4): ");

        string? opcion = Console.ReadLine();
        switch (opcion)
        {
            case "1":
                RegistrarAnimal("Perro");
                break;

            case "2":
                RegistrarAnimal("Gato");
                break;

            case "3":
                Console.WriteLine("\n--- Emisión Polimórfica de Sonidos ---");
                if (animales.Count == 0)
                {
                    Console.WriteLine("No hay animales registrados actualmente en el sistema.");
                }
                else
                {
                    // Recorrido polimórfico
                    foreach (Animal animal in animales)
                    {
                        animal.HacerSonido();
                    }
                }
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
    Console.WriteLine($"Error general en el sistema: {ex.Message}");
}

// Método local para capturar y registrar animales de manera limpia y blindada
void RegistrarAnimal(string tipo)
{
    while (true)
    {
        Console.Write($"Ingrese el nombre del {tipo}: ");
        string entrada = Console.ReadLine() ?? "";

        try
        {
            Animal nuevoAnimal = tipo switch
            {
                "Perro" => new Perro(entrada),
                "Gato" => new Gato(entrada),
                _ => throw new InvalidOperationException("Tipo de animal desconocido.")
            };

            animales.Add(nuevoAnimal);
            Console.WriteLine($"{tipo} '{nuevoAnimal.Nombre}' registrado exitosamente.");
            break;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al registrar {tipo}: {ex.Message} Intente de nuevo.\n");
        }
    }
}
