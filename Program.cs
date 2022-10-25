namespace StockAccountManagment
{
    class Program
    {
        public static void Main(String[] args)
        {
            String path = @"C:\Users\Gone Srinivas\Desktop\New folder\StockAccountManagment\StockAccountManagment\StockInventory.json";

            FetchJsonOfStock fetchJsonOfStock = new FetchJsonOfStock();

            Stock inventory = fetchJsonOfStock.Read(path);

            for (int i = 0; i < inventory.banking.Count; i++)
            {

                Console.WriteLine(inventory.banking[i].stockName);
                Console.WriteLine(inventory.banking[i].numberOfShares);
                Console.WriteLine(inventory.banking[i].price);

                int value = inventory.banking[i].numberOfShares * inventory.banking[i].price;
                Console.WriteLine("The price of {0} for {1}kg is: {2}", inventory.banking[i].stockName, inventory.banking[i].numberOfShares, inventory.banking[i].price);
                Console.WriteLine("--------------------------");
            }
            for (int i = 0; i < inventory.finance.Count; i++)
            {

                Console.WriteLine(inventory.finance[i].stockName);
                Console.WriteLine(inventory.finance[i].numberOfShares);
                Console.WriteLine(inventory.finance[i].price);

                int value = inventory.finance[i].numberOfShares * inventory.finance[i].price;
                Console.WriteLine("The price of {0} for {1}kg is: {2}", inventory.finance[i].stockName, inventory.finance[i].numberOfShares, inventory.finance[i].price);
                Console.WriteLine("--------------------------");
            }
            for (int i = 0; i < inventory.metals.Count; i++)
            {

                Console.WriteLine(inventory.metals[i].stockName);
                Console.WriteLine(inventory.metals[i].numberOfShares);
                Console.WriteLine(inventory.metals[i].price);

                int value = inventory.metals[i].numberOfShares * inventory.metals[i].price;
                Console.WriteLine("The price of {0} for {1}kg is: {2}", inventory.metals[i].stockName, inventory.metals[i].numberOfShares, inventory.metals[i].price);
                Console.WriteLine("--------------------------");
            }
            for (int i = 0; i < inventory.health.Count; i++)
            {

                Console.WriteLine(inventory.health[i].stockName);
                Console.WriteLine(inventory.health[i].numberOfShares);
                Console.WriteLine(inventory.health[i].price);

                int value = inventory.health[i].numberOfShares * inventory.health[i].price;
                Console.WriteLine("The price of {0} for {1}kg is: {2}", inventory.health[i].stockName, inventory.health[i].numberOfShares, inventory.health[i].price);
                Console.WriteLine("--------------------------");
            }
        }
    }
}