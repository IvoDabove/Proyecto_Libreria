
public class Fibrones {
   public  int stockFibrones;
   public int idFibrones;
   public  int precioFibrones;
   public static int precioFibroness;
 public String color;
 
 public int precioTotFibrones;

    

    public  Fibrones(int id,int stock,int precio, int sumador, String color){
        this.idFibrones=id;
        this.stockFibrones=stock;
        this.precioFibrones=precio;
         this.precioTotFibrones=sumador;
        this.color=color;

    }
    public int Id {get => idFibrones; set => idFibrones = value; }
    public int StockLapiceras {get => stockFibrones; set => stockFibrones= value; }
   public int Precio {get => precioFibrones; set => precioFibrones = value; }
    public int Sumador{get => precioTotFibrones; set => precioTotFibrones = value; }
     public String Color {get => color; set => color = value; }
}