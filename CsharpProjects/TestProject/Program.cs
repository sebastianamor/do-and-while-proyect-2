
int Totales;
int i = 0;

do
{
    Console.WriteLine("\n  Enter an integer value between 5 and 10  :");
    
    
    if (!int.TryParse(Console.ReadLine(), out Totales))
    {
        Console.WriteLine("Error: Ingrese un número válido entre el 5 y el 10");
        continue;
    }
    
    switch (Totales)
    {     
        if ( i <= 5 ){
        case 1: 
            
            Console.WriteLine($" tu numero es inferior a 5 {i}");
            break;
        case 2: 
               if (i > 0) 
            {
                
                Console.WriteLine($"Editado. Total: {i}");
            }
            else
            {
                Console.WriteLine("No hay elementos para editar");
            }
            break;
             }
        case 3: 
            Console.WriteLine($"Repitiendo... Contador actual: {i}");
            break;
        case 4: 
            Console.WriteLine("Saliendo del programa...");
            break;
        default:
            Console.WriteLine("Opción no válida numero entre el 5 y 10   ");
            break;
            
    }
} while  ( Totales != 4);

Console.WriteLine($"Resultados finales - Contador: {i}, Monstruos: {monster}, Héroes: {hero}");