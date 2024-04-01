namespace Moja_Gierka
{

    class Program
    {
        private static string nazwaPostaci;

        static void Main(string[] args)
        {
            nazwaPostaci = "Lu Han";

            ObsługaMenu();

            Console.ReadLine();




        }

        static void ObsługaMenu()

        {
            Console.WriteLine("1. Nowa Gra");
            Console.WriteLine("2. Wczytaj Grę");
            Console.WriteLine("3. Wyjdź z gry");

            string opcja = Console.ReadLine();

            Console.WriteLine("Wybrano opcję: " + opcja);

            if (opcja == "1")
            {
                StwórzPostać();
            }

            else if (opcja == "2")
            {

            }

            else
            {
                Console.Clear();
                Console.WriteLine("Dzięki za przetestowanie gierki następny update za jakiś czas");
            }
        }

        static void MenuGry()
        {
            Console.WriteLine("1. Idź na wyprawę");
            Console.WriteLine("2. Zregeneruj się");
            Console.WriteLine("3. Magiczny sklep");
            Console.WriteLine("4. Ekwipunek");
            Console.WriteLine("5. Koniec");
        }

        static void StwórzPostać()
        {
            Console.Clear();
            Console.Write("Podaj imię postaci: ");
            nazwaPostaci = Console.ReadLine();
        }
    }
}