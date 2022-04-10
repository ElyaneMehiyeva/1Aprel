using System;

namespace RestaurantSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool menu = true;
            while (true)
            {
                MainMenu();
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        bool choiceItembool = true;
                        while (choiceItembool)
                        {
                            ItemMenu();
                            string choiceItem = Console.ReadLine();
                            switch (choiceItem)
                            {
                                case "0":
                                    choiceItembool = false;
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;
                    case "2":
                        bool choiceOrderBool = true;
                        while (choiceOrderBool)
                        {
                            OrderMenu();
                            string choiceOrder = Console.ReadLine();
                            switch (choiceOrder)
                            {
                                case "0":
                                    choiceOrderBool = false;
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;
                    case "0":
                        menu = false;
                        break;
                    default:
                        break;
                }
            }
        } 
        static void MainMenu()
        {
            Console.WriteLine("1. Menu uzerinde emeliyyat aparmaq");
            Console.WriteLine("2. Sifarisler uzerinde emeliyyat aparmaq");
            Console.WriteLine("0. Sistemden cixmaq");
        }
        static void ItemMenu()
        {
            Console.WriteLine("1.1 - Yeni item elave et");
            Console.WriteLine("1.2 - Item uzerinde duzelis et");
            Console.WriteLine("1.3 - Item sil");
            Console.WriteLine("1.4 - Butun Item-lari goster");
            Console.WriteLine("1.5 - Categoriyasina gore menu item-lari goster");
            Console.WriteLine("1.6 - Qiymet araligina gore menu item-lar goster");
            Console.WriteLine("1.7 - Menu item-lar arasinda ada gore axtaris et (search)");
            Console.WriteLine("0 - Evvelki menuya qayit");
        }
        static void OrderMenu()
        {
            Console.WriteLine("2.1 Yeni sifaris elave etmek");
            Console.WriteLine("2.2 Sifarisin legvi");
            Console.WriteLine("2.3 Butun sifarislerin ekrana cixarilmasi");
            Console.WriteLine("2.4 Verilen tarix araligina gore sifarislrein gosterilmesi");
            Console.WriteLine("2.5 Verilen mebleg araligina gore sifarislerin gosterilmesi");
            Console.WriteLine("2.6 Verilmis bir tarixde olan sifarislerin gosterilmesi");
            Console.WriteLine("2.7 Verilmis nomreye esasen hemin nomreli sifarisin melumatlarinin gosterilmesi");
            Console.WriteLine("0 - Evveli menuya qayit");
        }
    }
}

