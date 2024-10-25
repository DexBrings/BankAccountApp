namespace BankAccountApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lege Dein Konto an:");
            Console.WriteLine("Gib Deine Kontonummer an:");
            string number = Console.ReadLine();
            Console.WriteLine("Gib nun Deinen Namen ein:");
            string name = Console.ReadLine();
            Console.WriteLine("Und nun bitte noch den Anfangsbestand in ganzen Euro:");
            int balance = int.Parse(Console.ReadLine());

            BankAccount account = new BankAccount(number, name, balance);

            while (true)
            {
                Console.WriteLine("Bitte wähle eine Aktion aus:");
                Console.WriteLine("1. Kontostand anzeigen");
                Console.WriteLine("2. Einzahlung machen");
                Console.WriteLine("3. Auszahlung machen");
                Console.WriteLine("4. Beenden");

                string input = Console.ReadLine();

                if (input == "1")
                {
                    account.PrintBalance();
                }
                else if (input == "2")
                {
                    Console.WriteLine("Wie hoch soll die Einzahlung in ganzen Euro sein?");
                    account.MakeDeposit(float.Parse(Console.ReadLine()));
                    account.PrintBalance();
                }
                else if (input == "3")
                {
                    Console.WriteLine("Wie hoch soll die Auszahlung in ganzen Euro sein?");
                    account.MakeWithdrawal(float.Parse(Console.ReadLine()));
                    account.PrintBalance();
                }
                else if (input == "4")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe! Bitte nur eine Zahl von 1 bis 4.");
                }
            }

        }
    }
}
