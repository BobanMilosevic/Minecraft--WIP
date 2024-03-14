using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft
{
    public interface IDataStorage
    {
        void SaveData(Loot inventory);
        void AddData(Loot inventory);
    }
    public class Streams : IDataStorage
    {
        public void SaveData(Loot Sloot)
        {
            using (StreamWriter temp = new StreamWriter("Minecraft.txt"))
            {
                foreach (Loot str in Sloot.LootList)
                {
                    temp.WriteLine($"{str.LootName},{str.Count}");
                }
            }
        }

        public void AddData(Loot Aloot)
        {
            using (StreamReader gang = File.OpenText("Minecraft.txt"))
            {
                string loot;
                while ((loot = gang.ReadLine()) != null)
                {
                    string[] data = loot.Split(',');
                    if (data.Length == 2)
                    {
                        Aloot.LootList.Add(new Loot { LootName = data[0], Count = int.Parse(data[1]) });
                    }

                }
            }
        }
    }
}
