using System.Drawing;

public class Resaltadores {

    public int idResaltadores;
    public int stockResaltadores;
    public  int precioResaltadores;
    public static int precioResaltadoress;

    public int precioTotResaltadores;

    public String marcaRes;
 
    public  Resaltadores(int id,int stock,int precio, int sumador, String marca){
        this.idResaltadores=id;
        this.stockResaltadores=stock;
       this.precioResaltadores= precio;
        this.precioTotResaltadores=sumador;
       this.marcaRes=marca;
       
    }
   

    
    public int Id {get => idResaltadores; set => idResaltadores = value; }
    public int Stock {get => stockResaltadores; set => stockResaltadores = value; }
    public int Precio {get => precioResaltadores; set => precioResaltadores = value; }
    public int Sumador {get => precioTotResaltadores; set => precioTotResaltadores = value; }
    public String Marca {get => marcaRes; set => marcaRes = value; }
    
}