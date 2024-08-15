public class Productos{
    protected int id;
    protected  int stock;
    protected int precio; 
    
     public int sumador; 
 
    
    
public Productos(int id, int stock, int precio, int sumador){
    this.id = id;
    this.stock = stock;
    this.precio = precio;
    this.sumador= sumador;
   
}

public int Stock {get => stock; set => stock = value; }
public int Precio {get => precio; set => precio = value; }

public int Id {get => id; set => id = value; }
public int Sumador {get => sumador; set => sumador = value; }

}