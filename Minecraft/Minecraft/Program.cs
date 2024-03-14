namespace Minecraft
{
    public class Game
    {
        public IDataStorage dataStorage;
        static T GetRandomElement<T>(IEnumerable<T> enumerable, Random rand)
        {
            int index = rand.Next(0, enumerable.Count());
            return enumerable.ElementAt(index);
        }
        static void Main(string[] args)
        {
            Tools tools = new Tools();
            Waffen waffen = new Waffen();
            Blöcke block = new Blöcke();
            Blöcke holzblock = new Holzblock();
            Blöcke erdblock = new Erdblock();
            Blöcke steinblock = new Steinblock();
            Blöcke steinkohle = new Steinkohle();
            Blöcke eisenerz = new Eisenerz();
            Blöcke golderz = new Golderz();
            Blöcke diamanterz = new Diamanterz();
            Blöcke redstoneerz = new Redstoneerz();
            Blöcke smaragderz = new Smaragderz();
            Blöcke lapislazulierz = new Lapislazulierz();
            Blöcke obsidian = new Obsidian();

            Random rand = new Random();
            IEnumerable<Blöcke> Randomblöcke = new List<Blöcke> { holzblock, erdblock, steinblock, steinkohle, eisenerz, golderz, diamanterz, redstoneerz, smaragderz, lapislazulierz, obsidian };
            Loot inventory = new Loot();
            IDataStorage dataStorage = new Streams();
            Game game = new Game();

            dataStorage.AddData(inventory);

            string oinput = "";
            string iinput = "";

            Console.WriteLine("Willkommen bei meinem Minecraft Klon! ");
            while (oinput != "b")
            {
                Console.Write("Wollen Sie einen Neuen Spielstand erstellen(N), letzten Spielstand laden(L), Inventar anzeigen(I) oder das Spiel beenden(B): ");
                oinput = Console.ReadLine().ToLower();

                if (oinput == "n")
                {
                    Console.WriteLine("Neuer Spielstand wird erstellt");
                    inventory.LootList.Clear();
                    Continue();
                    iinput = "";
                }
                else if (oinput == "l")
                {
                    Console.WriteLine("Spielstand wird geladen");
                    Continue();
                    iinput = "";
                }
                else if (oinput == "i")
                {
                    foreach (Loot lootItem in inventory.LootList)
                    {
                        Console.WriteLine(lootItem);
                    }
                }
            }
            dataStorage.SaveData(inventory);

            void Continue()
            {
                while (iinput != "n")
                {
                    foreach (Blöcke blocks in Randomblöcke)
                    {
                        Blöcke randomBlock = GetRandomElement(Randomblöcke, rand);
                        randomBlock.Abbauen(inventory);
                    }
                    Console.WriteLine("Möchten Sie weiter abbauen (j/n)");
                    iinput = Console.ReadLine().ToLower();
                }
            }
        }
    }

}