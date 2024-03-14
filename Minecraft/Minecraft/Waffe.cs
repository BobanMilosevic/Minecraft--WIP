using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft
{
    public class Tools
    {
        public string Spitzhacke;
        public string Axt;
        public string Schaufel;
        public string Hacke;
        public void Viable(string tool)
        {
            switch (tool)
            {
                case "Spitzhacke":
                    Console.WriteLine();
                    break;
                case "Axt":
                    Console.WriteLine();
                    break;
                case "Schaufel":
                    Console.WriteLine();
                    break;
                case "Hacke":
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine();
                    break;
            }
        }

    }
    public class Waffen : Tools
    {
        public string Schwert;
        public string Bogen;

        public void Angreifen()
        {
            Console.WriteLine("Haa");
        }
    }
}
