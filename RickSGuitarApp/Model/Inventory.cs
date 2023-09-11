using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickSGuitarApp.Model
{
    internal class Inventory
    {
        private List<Guitar> guitars;

        public Inventory()
        {
            guitars = new List<Guitar>();
        }

        public void AddGuitar(string serialNumber, double price, GuitarSpec spec)
        {
            Guitar guitar = new Guitar(serialNumber, price, spec);
            guitars.Add(guitar);
        }

        public Guitar GetGuitar(string serialNumber)
        {
            foreach (Guitar guitar in guitars)
            {
                if (guitar.SerialNumber.Equals(serialNumber, StringComparison.OrdinalIgnoreCase))
                {
                    return guitar;
                }
            }
            return null;
        }

        public List<Guitar> Search(GuitarSpec searchSpec)
        {
            List<Guitar> matchingGuitars = new List<Guitar>();
            foreach (Guitar guitar in guitars)
            {
                if (guitar.Spec.Matches(searchSpec))
                    matchingGuitars.Add(guitar);
            }
            return matchingGuitars;
        }
        public  static void InitializeInventory(Inventory inventory)
        {
            inventory.AddGuitar("11277", 3999.95,
         new GuitarSpec(Builder.COLLINGS, "CJ", Type.ACOUSTIC, 6,
                     Wood.INDIAN_ROSEWOOD, Wood.SITKA));
            inventory.AddGuitar("V95693", 1499.95,
              new GuitarSpec(Builder.FENDER, "Stratocastor", Type.ELECTRIC, 6,
                             Wood.ALDER, Wood.ALDER));
            inventory.AddGuitar("V9512", 1549.95,
              new GuitarSpec(Builder.FENDER, "Stratocastor", Type.ELECTRIC, 6,
                             Wood.ALDER, Wood.ALDER));
            inventory.AddGuitar("122784", 5495.95,
              new GuitarSpec(Builder.MARTIN, "D-18", Type.ACOUSTIC, 6,
                             Wood.MAHOGANY, Wood.ADIRONDACK));
            inventory.AddGuitar("76531", 6295.95,
              new GuitarSpec(Builder.MARTIN, "OM-28", Type.ACOUSTIC, 6,
                             Wood.BRAZILIAN_ROSEWOOD, Wood.ADIRONDACK));
            inventory.AddGuitar("70108276", 2295.95,
              new GuitarSpec(Builder.GIBSON, "Les Paul", Type.ELECTRIC, 6,
                             Wood.MAHOGANY, Wood.MAHOGANY));
            inventory.AddGuitar("82765501", 1890.95,
              new GuitarSpec(Builder.GIBSON, "SG '61 Reissue", Type.ELECTRIC, 6,
                             Wood.MAHOGANY, Wood.MAHOGANY));
            inventory.AddGuitar("77023", 6275.95,
              new GuitarSpec(Builder.MARTIN, "D-28", Type.ACOUSTIC, 6,
                             Wood.BRAZILIAN_ROSEWOOD, Wood.ADIRONDACK));
            inventory.AddGuitar("1092", 12995.95,
              new GuitarSpec(Builder.OLSON, "SJ", Type.ACOUSTIC, 12,
                             Wood.INDIAN_ROSEWOOD, Wood.CEDAR));
            inventory.AddGuitar("566-62", 8999.95,
              new GuitarSpec(Builder.RYAN, "Cathedral", Type.ACOUSTIC, 12,
                             Wood.COCOBOLO, Wood.CEDAR));
            inventory.AddGuitar("6 29584", 2100.95,
              new GuitarSpec(Builder.PRS, "Dave Navarro Signature", Type.ELECTRIC,
                             6, Wood.MAHOGANY, Wood.MAPLE));
        }
    }
}