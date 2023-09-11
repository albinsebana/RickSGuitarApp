using RickSGuitarApp.Model;
using Type = RickSGuitarApp.Model.Type;

namespace RickSGuitarApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            Inventory.InitializeInventory(inventory);

            GuitarSpec customerSearch = new GuitarSpec(Builder.MARTIN, "D-18", Type.ACOUSTIC, 6, Wood.MAHOGANY, Wood.ADIRONDACK);
            //MARTIN, "D-18", Type.ACOUSTIC, 6, Wood.MAHOGANY, Wood.ADIRONDACK
            
            List<Guitar> matchingGuitars = inventory.Search(customerSearch);

            if (matchingGuitars.Count > 0)
            {
                Console.WriteLine("you might like these :");
                foreach (Guitar guitar in matchingGuitars)
                {
                    GuitarSpec spec = guitar.Spec;
                    Console.WriteLine($"  We have a {spec.builder} {spec.model} guitar :{spec.type}" +
                        $"Back Wood {spec.backWood} top wood:{spec.topWood} Price Rs:{guitar.Price} ");
                }

            }
            else
            {
                Console.WriteLine("Sorry, nothing found !!!.");
            }
           
        }
        

    }
}