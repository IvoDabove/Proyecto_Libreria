using System.Data;
using System.Text.Json;

public class Hojas {
   public  int stockHojas;
   public int idHojas;
   //public static int precioHojas;
  public int precioHojass;
    public int precioTotHojas;
   public String tamanioH;
    

    public  Hojas(int id,int stock,int precio, int sumador, String tamanioH){
        this.idHojas=id;
        this.stockHojas=stock;
        this.precioHojass= precio;
        this.precioTotHojas=sumador;
        this.tamanioH=tamanioH;

    }

    public int Id {get => idHojas; set => idHojas = value; }
    public int Stock {get => stockHojas; set => stockHojas = value; }
    public int Precio {get => precioHojass; set => precioHojass = value; }
    public int Sumador {get => precioTotHojas; set => precioTotHojas = value; }
   public String Tamanio {get => tamanioH; set => tamanioH = value; }
}