using System;

namespace QuickMartPOS
{
    class Program
    {
        static void Main()
        {
            // Creating sample products
            var milk = new Product("Milk", 60.00m, VatCategory.ZeroRated);
            var tv = new Product("TV", 35000.00m, VatCategory.Standard);
            var mask = new Product("Medical Mask", 20.00m, VatCategory.Exempt);

            // Creating receipt object
            var receipt = new Receipt();

            // Adding items to the receipt
            receipt.AddItem(new SaleItem(tv, 1)); // 1 TV
            receipt.AddItem(new SaleItem(milk, 2)); // 2 Milk
            receipt.AddItem(new SaleItem(mask, 5)); // 5 Medical Masks

            // Printing the receipt to console
            receipt.PrintReceipt();
        }
    }
}
