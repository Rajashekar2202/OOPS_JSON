using InverntoryManagment;

namespace InventoryManagment
{
    class Program
    {
        public static void Main(string[] args)
        {
            string path = @"C:\Users\Gone Srinivas\Desktop\New folder\InverntoryManagment\InverntoryManagment\Inventory.json";
            FetchData fetchData = new FetchData();
            Inventory data = fetchData.Read(path);

            for (int i = 0; i < data.typesOfRice.Count; i++)
            {

                Console.WriteLine(data.typesOfRice[i].name);
                Console.WriteLine(data.typesOfRice[i].weight);
                Console.WriteLine(data.typesOfRice[i].price);
                Console.WriteLine("--------------------------");
            }
            for (int i = 0; i < data.typesOfPulse.Count; i++)
            {

                Console.WriteLine(data.typesOfPulse[i].name);
                Console.WriteLine(data.typesOfPulse[i].weight);
                Console.WriteLine(data.typesOfPulse[i].price);
                Console.WriteLine("--------------------------");
            }
            for (int i = 0; i < data.typesOfWheat.Count; i++)
            {

                Console.WriteLine(data.typesOfWheat[i].name);
                Console.WriteLine(data.typesOfWheat[i].weight);
                Console.WriteLine(data.typesOfWheat[i].price);
                Console.WriteLine("--------------------------");
            }
        }

    }
}

