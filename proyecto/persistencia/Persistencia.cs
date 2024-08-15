using System.Runtime.InteropServices.JavaScript;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.VisualBasic;
using Newtonsoft.Json.Linq;
public class Persistencia
{
      public static int stockHojasP, stockResaltadores, stockLapiceras, stockReglas, stockAgendas, stockFibrones;
      public static int contadorHojas, contadorResaltadores, contadorLapiceras, contadorReglas, contadorAgendas, contadorFibrones, sumador;
      public static String subtotalHojas, subtotalAgendas, subtotalFibrones, subtotalLapiceras, subtotalResaltadores, subtotalReglas, tamanio, material;
      
      public static String precioHojas, tamanioHoja, precioAgenda, precioLapicera, marcaLapicera, precioResaltador,marcaResaltador, precioRegla, tamanioRegla, precioFibron, colorFibron;
      Random random = new Random();
      Logica loquita = new Logica();





      public static void establecerStock()
      {
            stockHojasP = 8;
            stockAgendas = 8;
            stockFibrones = 9;
            stockLapiceras = 8;
            stockResaltadores = 8;
            stockReglas = 8;
      }


      //Hojas
      public static List<Hojas> hojas = new List<Hojas>();
      public static String pathHojas = @"..\..\..\Datos\Hojas\hojas.json";
      public static void actualizarHojas(String tipoProducto,int precioH, String tamanio)
      {
            
            Console.WriteLine("Seleccione la cantidad que desea comprar");
            String cantidad = Console.ReadLine();
            contadorHojas = Int32.Parse(cantidad);


            stockHojasP = stockHojasP - contadorHojas;
            int precioTotal = contadorHojas * precioH;
            sumador = sumador + precioTotal;
            Hojas hojaNueva = new Hojas(1, stockHojasP, precioH, sumador, tamanio);
            hojas.Add(hojaNueva);

            string json = JsonSerializer.Serialize(hojas);
            hojas.RemoveAt(0);
            File.WriteAllText(pathHojas, json);

            Console.WriteLine("Ah comprado " + tipoProducto + " por un monto de : $" + precioTotal);


      }


      //Resaltadores
      public static List<Resaltadores> resaltadores = new List<Resaltadores>();
      public static String pathResaltadores = @"..\..\..\Datos\Resaltadores\resaltadores.json";

      public static void actualizarResaltadores(String tipoProducto, int precioRes, String marcaRes)
      {
          
             Console.WriteLine("Seleccione la cantidad que desea comprar");
            String cantidad = Console.ReadLine();
            contadorResaltadores = Int32.Parse(cantidad);


            stockResaltadores = stockResaltadores - contadorResaltadores;
            int precioTotal = contadorResaltadores * precioRes;
            sumador = sumador + precioTotal;
            Resaltadores resaltadorNuevo = new Resaltadores(1, stockResaltadores, precioRes, sumador, marcaRes);
            resaltadores.Add(resaltadorNuevo);

            string json = JsonSerializer.Serialize(resaltadores);
            resaltadores.RemoveAt(0);
            File.WriteAllText(pathResaltadores, json);

            

      }

      //Lapiceras

      public static List<Lapiceras> lapiceras = new List<Lapiceras>();
      public static String pathLapiceras = @"..\..\..\Datos\Lapiceras\lapiceras.json";

      public static void actualizarLapicera(String tipoProducto,int precioL, String marca)
      {
            Lapiceras.precioLapicerass = 800;
            Console.WriteLine("Seleccione la cantidad que desea comprar");
            String cantidad = Console.ReadLine();
            contadorLapiceras = Int32.Parse(cantidad);


            stockLapiceras = stockLapiceras - contadorLapiceras;
            int precioTotal = contadorLapiceras * precioL;
            sumador = sumador + precioTotal;
            Lapiceras lapiceraNueva = new Lapiceras(1, stockLapiceras, precioL, sumador, marca);
            lapiceras.Add(lapiceraNueva);

            string json = JsonSerializer.Serialize(lapiceras);
            lapiceras.RemoveAt(0);
            File.WriteAllText(pathLapiceras, json);

            Console.WriteLine("Ah comprado " + tipoProducto + " por un monto de : $" + precioTotal);


      }

      //Reglas

      public static List<Reglas> reglas = new List<Reglas>();
      public static String pathReglas = @"..\..\..\Datos\Reglas\reglas.json";

      public static void actualizarReglas(String tipoProducto,int precioRegla, String tamanio)
      {
           
            Console.WriteLine("Seleccione la cantidad que desea comprar");
            String cantidad = Console.ReadLine();
            contadorReglas = Int32.Parse(cantidad);


            stockReglas = stockReglas - contadorReglas;
            int precioTotal = contadorReglas * precioRegla;
            sumador = sumador + precioTotal;
             
            Reglas reglaNueva = new Reglas(1, stockReglas, precioRegla, sumador, tamanio);
            reglas.Add(reglaNueva);

            string json = JsonSerializer.Serialize(reglas);
            reglas.RemoveAt(0);
            File.WriteAllText(pathReglas, json);

            Console.WriteLine("Ah comprado " + tipoProducto + " por un monto de : $" + precioTotal);

      }

      //Agendas
      public static List<Agendas> agendas = new List<Agendas>();
      public static String pathAgendas = @"..\..\..\Datos\Agendas\agendas.json";
      public static void actualizarAgendas(String tipoProducto, int precioAg, String material)
      {    /* if( material.Equals("Cuero")){
                  Agendas.precioAgendass = 3600;
             }else{

                  Agendas.precioAgendass = 3100;
             }*/
            Console.WriteLine("Seleccione la cantidad que desea comprar");
            String cantidad = Console.ReadLine();
            contadorAgendas = Int32.Parse(cantidad);

            stockAgendas = stockAgendas - contadorAgendas;

           int precioTotal = contadorAgendas * precioAg;
            sumador = sumador + precioTotal;
            Agendas agendaNueva = new Agendas(1, stockAgendas, precioAg, sumador, material);
            agendas.Add(agendaNueva);

            string json = JsonSerializer.Serialize(agendas);
            
            
             
            agendas.RemoveAt(0);
            File.WriteAllText(pathAgendas, json);

            Console.WriteLine("Ah comprado " + tipoProducto + " por un monto de : $" + precioTotal);

      }

      //Fibrones
      public static List<Fibrones> fibrones = new List<Fibrones>();
      public static String pathFibrones = @"..\..\..\Datos\Fibrones\fibrones.json";
      public static void actualizarFibrones(String tipoProducto, String color)
      {

            Fibrones.precioFibroness = 1500;
            Console.WriteLine("Seleccione la cantidad que desea comprar");
            String cantidad = Console.ReadLine();
            contadorFibrones = Int32.Parse(cantidad);


            stockFibrones = stockFibrones - contadorFibrones;
            int precioTotal = contadorFibrones * Fibrones.precioFibroness;
            sumador = sumador + precioTotal;
            Fibrones fibronNuevo = new Fibrones(1, stockFibrones, 1500, sumador,color);
            fibrones.Add(fibronNuevo);

            string json = JsonSerializer.Serialize(fibrones);
            fibrones.RemoveAt(0);
            File.WriteAllText(pathFibrones, json);

            Console.WriteLine("Ah comprado " + tipoProducto + " por un monto de : $" + precioTotal);


      }

      public void generarFactura()
      {
            loquita.generarSubtotalHojas(pathHojas);
            loquita.generarSubtotalResaltadores(pathResaltadores);
            loquita.generarSubtotalAgendas(pathAgendas);
            loquita.generarSubtotalFibrones(pathFibrones);
            loquita.generarSubtotalReglas(pathReglas);
            loquita.generarSubtotalLapiceras(pathLapiceras);
         
            Console.WriteLine("");
            Console.WriteLine("Factura A" + "\n" + "N° de factura: " + random.NextInt64(1, 1000));
            Console.WriteLine("-Producto Adquirido: Hojas " +tamanioHoja+ "-Precio unitario:"+precioHojas + "-Cantidad: " + contadorHojas + " -Subtotal: " + subtotalHojas+"\n");
            Console.WriteLine("-Producto Adquirido: Agendas de "+material + "-Precio unitario: "+precioAgenda + "-Cantidad: " + contadorAgendas + " -Subtotal: " + subtotalAgendas+"\n");
            Console.WriteLine("-Producto Adquirido: Resaltadores" + "-Precio unitario: " +precioResaltador+ "-Cantidad: " + contadorResaltadores + "Marca :"+marcaResaltador+" -Subtotal: " + subtotalResaltadores+"\n");
            Console.WriteLine("-Producto Adquirido: Fibrones" + "-Precio unitario: 1500 " + "-Cantidad: " + contadorFibrones + "Color"+colorFibron+" -Subtotal: " + subtotalFibrones+"\n");
            Console.WriteLine("-Producto Adquirido: Reglas" + "-Precio unitario: 500 " + "-Cantidad: " + contadorReglas + " -Subtotal: " + subtotalReglas+"\n");
            Console.WriteLine("-Producto Adquirido: Lapiceras" + "-Precio unitario: 800 " + "-Cantidad: " + contadorLapiceras + " -Subtotal: " + subtotalLapiceras+"\n");
          
      }


      //Reinicio de Hojas
      public void reiniciar(){
       Hojas hojaNueva = new Hojas(1, stockHojasP, 2100,0, "");
            hojas.Add(hojaNueva);

            string json = JsonSerializer.Serialize(hojas);
            hojas.RemoveAt(0);
            File.WriteAllText(pathHojas, json);

       //Reinicio de Fibrones
       Fibrones fibronNuevo = new Fibrones(1, stockFibrones, 1500, 0,"");
            fibrones.Add(fibronNuevo);

            string jsonf = JsonSerializer.Serialize(fibrones);
            fibrones.RemoveAt(0);
            File.WriteAllText(pathFibrones, jsonf);

       //Reinicio Agendas
         Agendas agendaNueva = new Agendas(1, stockAgendas, 3100, 0,"");
            agendas.Add(agendaNueva);

            string jsona = JsonSerializer.Serialize(agendas);
            agendas.RemoveAt(0);
            File.WriteAllText(pathAgendas, jsona);

      //Reinicio Reglas
             Reglas reglaNueva = new Reglas(1, stockReglas, 500, 0,"");
            reglas.Add(reglaNueva);

            string jsonr = JsonSerializer.Serialize(reglas);
            reglas.RemoveAt(0);
            File.WriteAllText(pathReglas, jsonr);

      //Reinicio Lapiceras
              Lapiceras lapiceraNueva = new Lapiceras(1, stockLapiceras, 800, 0,"");
            lapiceras.Add(lapiceraNueva);

            string jsonl = JsonSerializer.Serialize(lapiceras);
            lapiceras.RemoveAt(0);
            File.WriteAllText(pathLapiceras, jsonl);

      //Reinicio Resaltadores
             Resaltadores resaltadorNuevo = new Resaltadores(1, stockResaltadores, 1000, 0,"");
            resaltadores.Add(resaltadorNuevo);

            string jsonre = JsonSerializer.Serialize(resaltadores);
            resaltadores.RemoveAt(0);
            File.WriteAllText(pathResaltadores, jsonre);


      }


}
