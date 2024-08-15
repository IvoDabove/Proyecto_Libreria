using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;
using Newtonsoft.Json.Linq;

class Logica {
 public int stockActual;


    public void calculoStockHojas(String tipoProducto){
        Console.WriteLine("Seleccione el tamanio de la hoja:");
        Console.WriteLine("1- A4 "+"\n"+ "2- Oficio");
        String selecMaterial= Console.ReadLine();
        switch(selecMaterial){
                  case "1":
                   Persistencia.actualizarHojas(tipoProducto,3100,"A4");
                  break;
                  case "2":
                   Persistencia.actualizarHojas(tipoProducto,3800,"Oficio");
                  break;
        }    
        

        
    }

    public void calculoStockResaltadores(String tipoProducto){
      Console.WriteLine("Seleccione la marca:");
        Console.WriteLine("1- Ezco "+"\n"+ "2- Filgo");
        String selecMarca= Console.ReadLine();
        if(selecMarca.Equals( "1")){
                  
                   Persistencia.actualizarResaltadores(tipoProducto,1700,"Ezco");
        }    
        else{ 

                  Persistencia.actualizarResaltadores(tipoProducto,1500,"Filgo");
        }        
                  
        
        
    }
    public void calculoStockAgenda(String tipoProducto){
      Console.WriteLine("Seleccione el material de la agenda:");
        Console.WriteLine("1- Plastico "+"\n"+ "2- Cuero");
        String selecMaterial= Console.ReadLine();
        switch(selecMaterial){
                  case "1":
                   Persistencia.actualizarAgendas(tipoProducto,3100,"Plastico");
                  break;
                  case "2":
                   Persistencia.actualizarAgendas(tipoProducto,3600,"Cuero");
                  break;
        }    
       
     
    }

    public void calculoStockLapicera(String tipoProducto){
      Console.WriteLine("Seleccione la marca:");
        Console.WriteLine("1- Bic "+"\n"+ "2- Faber Castel");
        String selecTamanio= Console.ReadLine();
        switch(selecTamanio){
                  case "1":
                  Persistencia.actualizarLapicera(tipoProducto,1000, "Faber Castel");
                  break;
                  case "2":
                  Persistencia.actualizarLapicera(tipoProducto,800,"Bic");
                  break;
        }    
        
        
    }
    public void calculoStockRegla(String tipoProducto){
        Console.WriteLine("Seleccione el tamaño de la regla:");
        Console.WriteLine("1- 15cm "+"\n"+ "2-25 cm");
        String selecTamanio= Console.ReadLine();
        if(selecTamanio.Equals("1" )){
                  
                  Persistencia.actualizarReglas(tipoProducto,2200, "15");
                  
                  
        }    
                  else{
                        Persistencia.actualizarReglas(tipoProducto,2400,"20");
                  }
        
    }
    public void calculoStockFibrones(String tipoProducto){
        Console.WriteLine("Seleccione el color que desea:");
        Console.WriteLine("1- Pastel "+"\n"+ "2- Amarillo cm", "3-verde");
        String selecTamanio= Console.ReadLine();
        switch(selecTamanio){
                  case "1":
                  Persistencia.actualizarFibrones(tipoProducto, "Pastel");
                  break;
                  case "2":
                  Persistencia.actualizarFibrones(tipoProducto,"Amarillo");
                  break;
                  case "3":
                  Persistencia.actualizarFibrones(tipoProducto,"Verde");
                  break;
        }  
       
    }
    
    public  void generarSubtotalHojas(String pathHojas){
     
          String subtotalHojas;
          String jsonString = File.ReadAllText(pathHojas);
          
          
            foreach (JObject obj in JArray.Parse(jsonString))
            {
                  
               
                  //String suma = String.Join(",", obj["Sumador"].ToString());
                 // subtotalHojas = suma.Substring(61, 5);
                 subtotalHojas=Persistencia.subtotalHojas = obj["Sumador"].ToString();  
                  Persistencia.precioHojas= obj["Precio"].ToString(); 
                  Persistencia.tamanioHoja=obj["Tamanio"].ToString();    
            subtotalHojas = "0";
            }
    }
    public  void generarSubtotalResaltadores(String pathResaltadores){
     
          String subtotalResaltadores;
          String jsonString = File.ReadAllText(Persistencia.pathResaltadores);
            foreach (JObject obj in JArray.Parse(jsonString))
            {
                  //String suma = String.Join(",", obj);
                  //subtotalResaltadores = suma.Substring(61, 5);
                 
                   subtotalResaltadores=Persistencia.subtotalResaltadores = obj["Sumador"].ToString();  
                  Persistencia.precioResaltador= obj["Precio"].ToString(); 
                  Persistencia.marcaResaltador=obj["Marca"].ToString();     
                  subtotalResaltadores = "0";  
            }
    }
    public  void generarSubtotalAgendas(String pathAgendas){
     
          String subtotalAgendas;
          String jsonString = File.ReadAllText(pathAgendas);
            foreach (JObject obj in JArray.Parse(jsonString))
            {
                  String suma = String.Join(",", obj);
                  subtotalAgendas = suma.Substring(61, 5);
                 
                  Persistencia.subtotalAgendas =Persistencia.subtotalAgendas = obj["Sumador"].ToString();  
                  Persistencia.precioAgenda= obj["Precio"].ToString(); 
                  Persistencia.material=obj["Material"].ToString();       
                  subtotalAgendas = "0";
            }
    } 
    public  void generarSubtotalFibrones(String pathFibrones){
     
          String subtotalFibrones;
          String jsonString = File.ReadAllText(pathFibrones);
            foreach (JObject obj in JArray.Parse(jsonString))
            {
                 // String suma = String.Join(",", obj);
                  //subtotalFibrones = suma.Substring(61, 5);
                 
                  Persistencia.subtotalFibrones = obj["Sumador"].ToString();  
                  Persistencia.precioFibron= obj["Precio"].ToString(); 
                  Persistencia.colorFibron=obj["Color"].ToString();   
                  subtotalFibrones = "0";   
            }
    } 
    public  void generarSubtotalReglas(String pathReglas){
     
          String subtotalReglas;
          String jsonString = File.ReadAllText(pathReglas);
            foreach (JObject obj in JArray.Parse(jsonString))
            {
                  //String suma = String.Join(",", obj);
                                    
                  Persistencia.subtotalReglas = obj["Sumador"].ToString();  
                  Persistencia.precioRegla= obj["Precio"].ToString(); 
                  Persistencia.tamanioRegla=obj["Tamanio"].ToString();     
                  
                //subtotalReglas = "0";
            }
    } 
    public  void generarSubtotalLapiceras(String pathLapiceras){
     
          String subtotalLapiceras;
          String jsonString = File.ReadAllText(pathLapiceras);
            foreach (JObject obj in JArray.Parse(jsonString))
            {
                 // String suma = String.Join(",", obj);
                   Persistencia.subtotalLapiceras = obj["Sumador"].ToString();  
                  Persistencia.precioLapicera= obj["Precio"].ToString(); 
                  Persistencia.marcaLapicera=obj["Marca"].ToString();

                 
            }
    } 




}