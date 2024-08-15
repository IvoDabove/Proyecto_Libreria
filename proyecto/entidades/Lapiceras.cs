
public class Lapiceras {


    public int idLapiceras;
    public int stockLapiceras = 3;
    public  int precioLapiceras;
    public String marca;
    public static int precioLapicerass;
    
    public int precioTotLapiceras;
    public  Lapiceras(int id,int stock,int precio, int sumador, String marca){
        this.idLapiceras=id;
        this.stockLapiceras=stock;
       this.precioLapiceras=precio;
        this.precioTotLapiceras=sumador;
        this.marca=marca;
       
    }

    public int Id {get => idLapiceras; set => idLapiceras = value; }
    public int StockLapiceras {get => stockLapiceras; set => stockLapiceras= value; }
    public int Precio {get => precioLapiceras; set => precioLapiceras = value; }
    public int Sumador{get => precioTotLapiceras; set => precioTotLapiceras = value; }
    
    public String Marca {get => marca; set => marca = value; }
}