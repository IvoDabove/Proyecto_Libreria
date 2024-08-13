
public class Lapiceras : Productos{


    public int idLapiceras;
    public int stockLapiceras = 3;
    public  int precioLapiceras;
    public static int precioLapicerass;
    
    public int precioTotLapiceras;
    public  Lapiceras(int id,int stock,int precio, int sumador): base(id,stock,precio,sumador){
        this.idLapiceras=id;
        this.stockLapiceras=stock;
       this.precioLapiceras=precio;
        this.precioTotLapiceras=Sumador;
       
    }

    
    public int Precio {get => precio; set => precio = value; }
    
}