using System.Data;
using System.Text.Json;

public class Hojas : Productos{
   public  int stockHojas;
   public int idHojas;
   public static int precioHojas;
  public int precioHojass;
    public int precioTotHojas;

    

    public  Hojas(int id,int stock,int precio, int sumador): base(id,stock,precio,sumador){
        this.idHojas=id;
        this.stockHojas=stock;
        this.precioHojass= precio;
        this.precioTotHojas=sumador;
        

    }
   public int Precio {get => precio; set => precio = value; }
}