using System.Drawing;

public class Resaltadores : Productos{

    public int idResaltadores;
    public int stockResaltadores;
    public  int precioResaltadores;
    public static int precioResaltadoress;

    public int precioTotResaltadores;


 
    public  Resaltadores(int id,int stock,int precio, int sumador): base(id,stock,precio, sumador){
        this.idResaltadores=id;
        this.stockResaltadores=stock;
       this.precioResaltadores= precio;
        this.precioTotResaltadores=sumador;
       
       
    }
   

    
    public int Precio {get => precio; set => precio = value; }
    
}