
using  Specifications;
namespace Catalog;

public class Product:ISellable
{
    public int id;
    public string title;
    public string description;
    public double unitPrice;
    public int quantity;

    public Product(int id, string t, string d, double price, int q){
        this.id=id;
        this.title=t;
        this.description=d;
        this.unitPrice=price;
        this.quantity=q;
    }

    void ISellable.Sell(){
        Console.WriteLine("Product is sold");
    }

    void ISellable.Promote(){
          Console.WriteLine("Product is promoted");
    }

    void ISellable.Test(){
          Console.WriteLine("Product is Tested");
    }


}
