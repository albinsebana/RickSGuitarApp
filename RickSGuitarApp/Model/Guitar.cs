using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickSGuitarApp.Model
{
    internal class Guitar
    {
        private string serialNumber;
        private double price;
        public GuitarSpec spec;
        public List<Guitar> MatchingGuitars;

        public Guitar(string serialNumber, double price, GuitarSpec spec, List<Guitar> matchingGuitars)
        {
            this.serialNumber = serialNumber;
            this.price = price;
            this.spec = spec;
            MatchingGuitars = matchingGuitars;

        }

        public Guitar(string serialNumber, double price, GuitarSpec spec)
        {
            this.serialNumber = serialNumber;
            this.price = price;
            this.spec = spec;
        }

        public string SerialNumber
        {
            get { return serialNumber; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public GuitarSpec Spec
        {
            get { return spec; }
        }
        //public void MachingGuitar(List<Guitar> matchingGuitars)
        //{
        //    Console.WriteLine("Erin, you might like these guitars:");
        //    foreach (Guitar guitar in matchingGuitars)
        //    {
        //        GuitarSpec spec = guitar.Spec;
        //        Console.WriteLine($"  We have a {spec.builder} {spec.model} guitar :{spec.type}Back Wood {spec.backWood} top wood:{spec.topWood} Price Rs:{ guitar.Price} ");
        //    }

        //}
    }
}