using Projekt;
using System.Reflection;

bool pokracovat = true;

List<EvidencePojistenych> pojistenci = new List<EvidencePojistenych>();

do
{
    Vypis();
    int volba;
    while (!int.TryParse(Console.ReadLine(), out volba))
        Console.WriteLine("Neplatná volba, zkuste prosím znovu:");
    switch (volba)
    {
        case 1:
            // Příkaz č. 1

            Console.WriteLine("\nZadejte jméno pojištěného:");
            string jmeno = Console.ReadLine();

            Console.WriteLine("Zadejte příjmení:");
            string prijmeni = Console.ReadLine();

            Console.WriteLine("Zadejte telefonní číslo:");
            int telefonniCislo;
            while (!int.TryParse(Console.ReadLine(), out telefonniCislo))
                Console.WriteLine("Neplatný znak, zkuste prosím znovu:");

            Console.WriteLine("Zadejte věk:");
            int vek;
            while (!int.TryParse(Console.ReadLine(), out vek))
                Console.WriteLine("Neplatný znak, zkuste prosím znovu:");

            pojistenci.Add(new EvidencePojistenych(jmeno, prijmeni, telefonniCislo, vek));

            Console.WriteLine("Data byla uložena. Pokračujte libovolnou klávesou...");
            Console.ReadKey();

            pokracovat = true;

            break;
        case 2:
            // Příkaz č. 2

            Console.WriteLine();
            foreach (EvidencePojistenych evidencePojistenych in pojistenci)
            {
                Console.WriteLine(evidencePojistenych);
            }
            Console.WriteLine("\nPokračujte libovolnou klávesou...");
            Console.ReadKey();

            pokracovat = true;
            break;
        case 3:

            Console.WriteLine("\nZadejte jméno pojištěného:");
            jmeno = Console.ReadLine();

            Console.WriteLine("Zadejte příjmení:");
            prijmeni = Console.ReadLine();

            Console.WriteLine();
            foreach (EvidencePojistenych evidencePojistenych in pojistenci)
            {
                if(evidencePojistenych.Jmeno == jmeno && evidencePojistenych.Prijmeni == prijmeni)
                {
                    Console.WriteLine(evidencePojistenych);
                }
            }

            Console.WriteLine("\nPokračujte libovolnou klávesou...");
            Console.ReadKey();

            pokracovat = true;

            break;
        case 4:
            // Příkaz č. 4

            pokracovat = false;
            Console.WriteLine("K ukončení programu pokračujte libovolnou klávesou...");
            Console.ReadKey();
            break;
        default:
            break;
    }
} while (pokracovat == true);

static void Vypis()
{
    Console.Clear();
    Console.WriteLine("--------------------------");
    Console.WriteLine("Evidence pojištěných");
    Console.WriteLine("--------------------------");
    Console.WriteLine();
    Console.WriteLine("Vyberte si akci:");
    Console.WriteLine("1 - Přidat nového pojištěného");
    Console.WriteLine("2 - Vypsat všechny pojištěné");
    Console.WriteLine("3 - Vyhledat pojištěného");
    Console.WriteLine("4 - Konec");
}