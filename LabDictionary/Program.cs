using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabDictionary
{
    public class Continent
    {
        public string Name { get; set; }

        public override string ToString()
        {
 	        return string.Format("{0}", Name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DemoDictionary();
        }

        public static void DemoDictionary()
        {
            Continent africa = new Continent() { Name = "Africa" };
            Continent southAmerica = new Continent() { Name = "South America" };
            Continent europe = new Continent() { Name = "Europe" };

            Dictionary<string, Continent> rivers = new Dictionary<string, Continent>()
            {
                {"Nile", africa}, 
                {"Mississippi", southAmerica},
                {"Danube", europe}
            };

            Continent asia = new Continent() { Name = "Asia" };
            rivers.Add("Ganges", asia);
            Console.WriteLine("{0} in continent: {1}", "Danube", rivers["Danube"]);
            Console.WriteLine();

            rivers["Mississippi"] = new Continent() { Name = "North America" };

            foreach (KeyValuePair<string, Continent> element in rivers)
            {
                Console.WriteLine("{0,-12}{1}", element.Key, element.Value);
            }
        }
    }
}
