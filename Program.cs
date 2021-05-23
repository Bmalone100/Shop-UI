using System;
namespace ShopUI{
    class Program{
        public static void Main(string[] args){
            //create shops
            Shop shop = new Shop("Londis");
            Shop secondShop = new Shop("Maxol");

            //create products
            Product product = new Product("11111023654", "Fanta", 1.00m, 0.80m, true, shop.UniqueID);
            Product secondProduct = new Product("11002314007", "Diet Coke", 1.00m, 0.80m, false, shop.UniqueID);

            //run shop methods
            shop.addShop(shop);
            shop.addShop(secondShop);

                foreach(Shop element in shop.Shops){
                    Console.WriteLine("Shop: " + element.Name);
                }

            shop.editShop(secondShop, secondShop.Name, "Applegreen");
            Console.WriteLine(shop.Name);
            Console.WriteLine(secondShop.Name);

            shop.deleteShop(secondShop, secondShop.Name);

            Console.WriteLine("After removing shop: " + secondShop.Name);
            shop.Shops.ForEach(Console.WriteLine);

            //run product methods
            shop.addProduct(product);
            shop.addProduct(secondProduct);

                foreach(Product element in shop.Products){
                    Console.WriteLine("Product: " + element.Name);
                }

            shop.editProduct(product, product.Name, "Coke");
            Console.WriteLine(product.ToString());
            Console.WriteLine(secondProduct.ToString());

            shop.deleteProduct(secondProduct, secondProduct.Name);

            Console.WriteLine("After removing product: " + secondProduct.Name);
            shop.Products.ForEach(Console.WriteLine);
        }
    }
}
