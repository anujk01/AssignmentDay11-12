using System;

namespace InventoryManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            FetchJasonForRice fetchJasonForRice = new FetchJasonForRice();
            Rice ricedata = fetchJasonForRice.ReadTheJasonFile("C:/Users/anujk/source/repos/InventoryManagement/new2.json");

            Console.WriteLine(ricedata);

            for (int i = 0; i < ricedata.typesofRice.Count; i++)
            {
                Console.WriteLine(ricedata.typesofRice[i].name);
                Console.WriteLine(ricedata.typesofRice[i].weight);
                Console.WriteLine(ricedata.typesofRice[i].price);
            }
        }
    }
}
