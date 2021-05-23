//A class containing properties for a product
using System;
public class Product{
    private Guid UniqueID;
    private string Barcode;
    private string _Name;
    public string Name{
        get{
            return _Name;
        }
        set{
            _Name = value; 
        }
    }
    private decimal Price;
    private decimal Cost;
    private bool IsOnShelf;
    private Guid Shop;
    
    public Product(string barcode, string name, decimal price, decimal cost, bool isOnShelf, Guid shop){
        Guid uniqueID = Guid.NewGuid();
        UniqueID = uniqueID;
        Barcode = barcode;
        _Name = name;
        Price = price;
        Cost = cost;
        IsOnShelf = isOnShelf;
        Shop = shop;
    }

    public override string ToString()
    {
        return "Product: " + Barcode + " " + Name + " " + Price + " " + Cost + " " + IsOnShelf + " " + Shop;
    }

}