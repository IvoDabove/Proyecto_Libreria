public class Agendas : Productos{
  public int idAgendas;
  public int stockAgendas;
  public static int precioAgendass;
   public  int precioAgendas;
  
  public int precioTotAgendas;
    public  Agendas(int id,int stock,int precio, int sumador):base(id,stock,precio,sumador){
        this.idAgendas=id;
        this.stockAgendas=stock;
        this.precioAgendas= precio;
        this.precioTotAgendas=sumador;
        
        

    }
   public int Precio {get => precio; set => precio = value; }
}