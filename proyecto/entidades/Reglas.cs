public class Reglas {

    public int idReglas;
    public int stockReglas ;
    public  int precioReglas;
    public static int precioReglass;
    
    public String tamanioRegla;

    public int precioTotReglas;
   
    public Reglas(int id,int stock,int precio, int sumador, String tamanio){
        this.idReglas=id;
        this.stockReglas=stock;
        this.precioReglas=precio;
        this.precioTotReglas=sumador;
        this.tamanioRegla=tamanio;
       
    }

    
       public int Id {get => idReglas; set => idReglas = value; }
     public int Stock {get => stockReglas; set => stockReglas = value; }
   public int Precio {get => precioReglas; set => precioReglas = value; }
   public int Sumador {get => precioTotReglas; set => precioTotReglas = value; }
   public String Tamanio {get => tamanioRegla; set => tamanioRegla=value; }
    
    }