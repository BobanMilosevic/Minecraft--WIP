using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft
{
    public class Loot
    {
        public List<Loot> LootList {  get; set; }
        public Loot()
        {
            LootList = new List<Loot>();
            Count = 1;
        }
        public string LootName { get; set; }
        public int Count { get; set; }
        public override string ToString()
        {
            return $"{LootName} x{Count}";
        }
    }
}
