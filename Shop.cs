using System;
using System.Collections.Generic;
namespace ShopUI{
    public class Shop{
        private Guid _UniqueID;
        public Guid UniqueID{
            get{
                return _UniqueID;
            }
            set{
                _UniqueID = value; 
            }
        }
          private string _Name;
        public string Name{
        get{
            return _Name;
        }
        set{
            _Name = value; 
        }
    }

        //List of shops
        List<Shop> shops = new List<Shop>();
        public List<Shop> Shops{
            get {return shops;}
        }
        //List of products
        List<Product> products = new List<Product>();
        public List<Product> Products{
            get {return products;}
        }

        public Shop(string name){
            Guid uniqueID = Guid.NewGuid();
            _UniqueID = uniqueID;
            Name = name;
        }

          public override string ToString()
    {
        return "Shop: " + Name;
    }
        public void addShop(Shop shop){
            shops.Add(shop);
        }

        public void editShop(Shop shop, string name, string edit){
            foreach(Shop element in shops)
            {
                if(element.Name == name){
                    shop.Name = edit;
                }
            }
        }

         public void deleteShop(Shop shop, string name){
            if(shop.Name == name){
            shops.Remove(shop);
            }
        }

        public void addProduct(Product product){
            products.Add(product);
        }

        public void editProduct(Product product, string name, string edit){
            foreach(Product element in products)
            {
                if(element.Name == name){
                    product.Name = edit;
                }
            }
        }

         public void deleteProduct(Product product, string name){
            if(product.Name == name){
            products.Remove(product);
            }
        }

    }
}