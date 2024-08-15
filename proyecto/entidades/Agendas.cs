public class Agendas {
  public int idAgendas;
  public int stockAgendas;
  //public static int precioAgendass;
   public  int precioAgendas;
   public String material;
  public int precioTotAgendas;
    public  Agendas(int id,int stock,int precio, int sumador, String material){
        this.idAgendas=id;
        this.stockAgendas=stock;
        this.precioAgendas= precio;
        this.precioTotAgendas=sumador;
        this.material=material;
        

    }
     public int Id {get => idAgendas; set => idAgendas = value; }
     public int Stock {get => stockAgendas; set => stockAgendas = value; }
   public int Precio {get => precioAgendas; set => precioAgendas = value; }
   public int Sumador {get => precioTotAgendas; set => precioTotAgendas = value; }
   public String Material {get => material; set => material=value; }
}