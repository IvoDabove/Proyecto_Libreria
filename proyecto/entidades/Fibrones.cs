
public class Fibrones : Productos{
   public  int stockFibrones;
   public int idFibrones;
   public  int precioFibrones;
   public static int precioFibroness;

 
 public int precioTotFibrones;

    

    public  Fibrones(int id,int stock,int precio, int sumador): base(id,stock,precio, sumador){
        this.idFibrones=id;
        this.stockFibrones=stock;
        this.precioFibrones=precio;
         this.precioTotFibrones=sumador;
        

    }
   public int Precio {get => precio; set => precio = value; }
}