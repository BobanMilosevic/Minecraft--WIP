using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Minecraft
{
    public class Blöcke
    {
        public int Hp { get; set; }
        public string Name { get; set; }
        public string Loot { get; set; }

        public void Abbauen(Loot inventory)
        {
            Console.WriteLine($"{Name} wird abgebaut\n");
            int initialHp = Hp;
            while (Hp > 0)
            {
                Hp--;
                //System.Threading.Thread.Sleep(100);
                Console.WriteLine($"    HP: {Hp}\n");
            }
            Console.WriteLine($"{Name} wurde abgebaut und erzeugt {Loot}");
            Console.WriteLine("-------------------------------------------------------");
            if (!inventory.LootList.Any(lootItem => lootItem.LootName == Loot))
            {
                inventory.LootList.Add(new Minecraft.Loot { LootName = Loot });
            }
            else
            {
                inventory.LootList.Find(lootItem => lootItem.LootName ==Loot).Count++;
            }
            Console.WriteLine($"{Loot} wurde dem Inventar hinzugefügt");
            Hp = initialHp;
        }
    }

    public class Holzblock : Blöcke
    {
        public Holzblock()
        {
            Hp = 5;
            Name = "Holzblock";
            Loot = "Holzblock";
        }
    }

    public class Erdblock : Blöcke
    {
        public Erdblock()
        {
            Hp = 5;
            Name = "Erdblock";
            Loot = "Erdblock";
        }
    }

    public class Steinblock : Blöcke
    {
        public Steinblock()
        {
            Hp = 10;
            Name = "Steinblock";
            Loot = "Steinblock";
        }
    }

    public class Steinkohle : Blöcke
    {
        public Steinkohle()
        {
            Hp = 10;
            Name = "Steinkohle";
            Loot = "Kohle";
        }
    }

    public class Eisenerz : Blöcke
    {
        public Eisenerz()
        {
            Hp = 15;
            Name = "Eisenerz";
            Loot = "Roheisen";
        }
    }

    public class Golderz : Blöcke
    {
        public Golderz()
        {
            Hp = 20;
            Name = "Golderz";
            Loot = "Rohgold";
        }
    }

    public class Diamanterz : Blöcke
    {
        public Diamanterz()
        {
            Hp = 30;
            Name = "Diamanterz";
            Loot = "Diamant";
        }
    }

    public class Redstoneerz : Blöcke
    {
        public Redstoneerz()
        {
            Hp = 30;
            Name = "Redstoneerz";
            Loot = "Redstone";
        }
    }

    public class Smaragderz : Blöcke
    {
        public Smaragderz()
        {
            Hp = 30;
            Name = "Smaragderz";
            Loot = "Smaragd";
        }
    }

    public class Lapislazulierz : Blöcke
    {
        public Lapislazulierz()
        {
            Hp = 15;
            Name = "Lapislazulierz";
            Loot = "Lapislazuli";
        }
    }
    public class Obsidian : Blöcke
    {
        public Obsidian()
        {
            Hp = 50;
            Name = "Obsidian";
            Loot = "Obsidian";
        }
    }

}