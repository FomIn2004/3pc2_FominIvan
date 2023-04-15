namespace PZ_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store(){AllPurshares = ""};
            Client amir = new Client(){AllPurchases = 12000,Name = "Иван"};
            Client Sergey = new Client(){AllPurchases = 3600, Name = "Андрей"};
            Client Marina = new Client(){AllPurchases = 90000, Name = "Ольга"};

            CPU cpu = new CPU() 
            {
                Name ="Ryzen 3 4366", 
                Core = 4, 
                Frequency = 3.14,
                Price = 4500
            };
            Graphics_card graphics_Card = new Graphics_card()
            {
                Name = "GTX 1050 ti",
                RAM = 4,
                DDR = 5,
                Price = 12500
            };
            Motherboard motherboard = new Motherboard()
            {
                Name = "Gigabyte a320m-s2h v2",
                Size = "normal",
                Socket = "AM4",
                Price = 26000
            };

            store.SaveOrder(amir, new Product[1] {graphics_Card});
            store.SaveOrder(Sergey, new Product[2] {cpu, motherboard});
            store.SaveOrder(Marina, new Product[5] {cpu, motherboard, graphics_Card, graphics_Card, cpu });

            Console.WriteLine(store.AllPurshares);
            



        }
    }
}
