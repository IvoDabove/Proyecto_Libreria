using System;
class UserInterface
{
   //https://www.techiedelight.com/es/write-to-json-file-csharp/
   //https://learn.microsoft.com/en-us/dotnet/api/system.io.file.writealltext?view=net-8.0

   public void mostrar()
   {
      Persistencia persistencia = new Persistencia();



      Persistencia.establecerStock();


      Logica productos = new Logica();
      Console.WriteLine("Bienvenido a Belleza Inesperada <3");
      Console.WriteLine("Seleccione que desea hacer");
      Console.WriteLine("1.Comprar" + "\n" + "2.Estadisticas" + "\n" + "0.Salir");
      String opcion1 = Console.ReadLine();
      switch (opcion1)
      {
         case "1":

            String eleccion = "1";
            while (eleccion.Equals("1"))
            {
               Console.WriteLine("Que productos desea comprar?");
               Console.WriteLine("1-Hojas" + "\n" + "2-Agendas" + "\n" + "3-Lapiceras" + "\n" + "4-Resaltadores" + "\n" + "5-Fibrones" + "\n" + "6-Reglas");
               String opcion3 = Console.ReadLine();
               switch (opcion3)
               {
                  case "1":
                     productos.calculoStockHojas("Hojas");
                     break;
                  case "2":
                     productos.calculoStockAgenda("Agenda");
                     break;
                  case "3":
                     productos.calculoStockLapicera("Lapicera");
                     break;
                  case "4":
                     productos.calculoStockResaltadores("Resaltador");
                     break;
                  case "5":
                     productos.calculoStockFibrones("Fibron");
                     break;
                  case "6":
                     productos.calculoStockRegla("Regla");
                     break;
               }


               Console.WriteLine("Desea seguir comprando?");
               Console.WriteLine("1. Seguir comprando" + "\n" + "0. Salir");
               eleccion = Console.ReadLine();
               
            }
            break;
            
         case "0":
            break;
      }
      persistencia.generarFactura();
      persistencia.reiniciar();



   }
}