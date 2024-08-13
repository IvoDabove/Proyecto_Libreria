public class Reglas : Productos{

    public int idReglas;
    public int stockReglas ;
    public  int precioReglas;
    public static int precioReglass;


    public int precioTotReglas;
    public Reglas(int id,int stock,int precio, int sumador): base(id,stock,precio, sumador){
        this.idReglas=id;
        this.stockReglas=stock;
        this.precioReglas=precio;
        this.precioTotReglas=sumador;
       
    }

    
    public int Precio {get => precio; set => precio = value; }
    
    }