using System.Security.Cryptography.X509Certificates;
using Newtonsoft.Json.Linq;

class Logica {
 public int stockActual;


    public void calculoStockHojas(String tipoProducto){
        
        Persistencia.actualizarHojas(tipoProducto);

        
    }

    public void calculoStockResaltadores(String tipoProducto){
        Persistencia.actualizarResaltadores(tipoProducto);
        
    }
    public void calculoStockAgenda(String tipoProducto){
        Persistencia.actualizarAgendas(tipoProducto);
     
    }

    public void calculoStockLapicera(String tipoProducto){
        Persistencia.actualizarLapicera(tipoProducto);
        
    }
    public void calculoStockRegla(String tipoProducto){
        Persistencia.actualizarReglas(tipoProducto);
        
    }
    public void calculoStockFibrones(String tipoProducto){
        Persistencia.actualizarFibrones(tipoProducto);
       
    }
    
    public  void generarSubtotalHojas(String pathHojas){
     
          String subtotalHojas;
          String jsonString = File.ReadAllText(pathHojas);
            foreach (JObject obj in JArray.Parse(jsonString))
            {
                  String suma = String.Join(",", obj);
                  subtotalHojas = suma.Substring(62, 5);
                 
                  Persistencia.subtotalHojas = subtotalHojas;       
            subtotalHojas = "0";
            }
    }
    public  void generarSubtotalResaltadores(String pathResaltadores){
     
          String subtotalResaltadores;
          String jsonString = File.ReadAllText(pathResaltadores);
            foreach (JObject obj in JArray.Parse(jsonString))
            {
                  String suma = String.Join(",", obj);
                  subtotalResaltadores = suma.Substring(62, 5);
                 
                  Persistencia.subtotalResaltadores = subtotalResaltadores;     
                  subtotalResaltadores = "0";  
            }
    }
    public  void generarSubtotalAgendas(String pathAgendas){
     
          String subtotalAgendas;
          String jsonString = File.ReadAllText(pathAgendas);
            foreach (JObject obj in JArray.Parse(jsonString))
            {
                  String suma = String.Join(",", obj);
                  subtotalAgendas = suma.Substring(62, 5);
                 
                  Persistencia.subtotalAgendas = subtotalAgendas;       
                  subtotalAgendas = "0";
            }
    } 
    public  void generarSubtotalFibrones(String pathFibrones){
     
          String subtotalFibrones;
          String jsonString = File.ReadAllText(pathFibrones);
            foreach (JObject obj in JArray.Parse(jsonString))
            {
                  String suma = String.Join(",", obj);
                  subtotalFibrones = suma.Substring(62, 5);
                 
                  Persistencia.subtotalFibrones = subtotalFibrones;    
                  subtotalFibrones = "0";   
            }
    } 
    public  void generarSubtotalReglas(String pathReglas){
     
          String subtotalReglas;
          String jsonString = File.ReadAllText(pathReglas);
            foreach (JObject obj in JArray.Parse(jsonString))
            {
                  String suma = String.Join(",", obj);
                  
                  subtotalReglas = suma.Substring(60, 5);
                  
                  Persistencia.subtotalReglas = subtotalReglas; 
                subtotalReglas = "0";
            }
    } 
    public  void generarSubtotalLapiceras(String pathLapiceras){
     
          String subtotalLapiceras;
          String jsonString = File.ReadAllText(pathLapiceras);
            foreach (JObject obj in JArray.Parse(jsonString))
            {
                  String suma = String.Join(",", obj);
                  subtotalLapiceras = suma.Substring(61, 4);
                  
                  Persistencia.subtotalLapiceras = subtotalLapiceras;  
                     subtotalLapiceras = "0";  
            }
    } 




}