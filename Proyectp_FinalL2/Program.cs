using System;
//using System.Collection.Generic;
class MainClass
{
  public static void Main (string[] args)
 {
    int opcion = 0;
    while(true)
     {
         Console.Clear();
         MatrizdeDatos datos = new MatrizdeDatos();
         Console.WriteLine("------------------------------");
         Console.WriteLine("Bienvenido al Hotel Aroma Mejia");
         Console.WriteLine("------------------------------");
         Console.WriteLine("");
         Console.WriteLine("Menu");
         Console.WriteLine("1 - habitaciones disponibles");
         Console.WriteLine("2 - Lista de Huespedes");
         Console.WriteLine("3 - Hacer Reserva");
         Console.WriteLine("0- Salir");
         Console.WriteLine("Por favor elija una Opcion: ");
         opcion = System.Convert.ToInt32(Console.ReadLine());
         switch(opcion)
          {
            case 1:            
              Console.Clear();
              Console.WriteLine("------------");
              Console.WriteLine("Habitaciones");
              Console.WriteLine("------------");
              Console.WriteLine("");
              datos.buscarhabitacion();
              Console.ReadKey();
              break; 
            case 2:
              Console.Clear();
              Console.WriteLine("-----------");
              Console.WriteLine("No Reservar");
              Console.WriteLine("-----------");
              Console.WriteLine("");
              datos.buscarhuesped();
              Console.ReadKey();
              break;
              case 3:
              Console.Clear();
              Console.WriteLine("-----------");
              Console.WriteLine(" Reservas");
              Console.WriteLine("-----------");
              Console.WriteLine("");
              datos.ingresoCliente();
              break;
              default:
               Console.Clear();
              Console.WriteLine("El hotel Aroma Mejia, te desea un bonito y bendecido dia.");
              break;

          } 
          if (opcion == 0) 
           {
             
             break;
           }

      }
        
 }
}