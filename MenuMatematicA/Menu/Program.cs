namespace Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcioS = "";
            while (opcioS != "Q" && opcioS != "q")
            {
                Menu();
                Console.WriteLine("Quina opció vols escollir?");
                opcioS = Console.ReadLine();
                if (!ValidarOpcio(opcioS))
                {
                    Console.WriteLine("No has escollit una opció de les possibles.");
                    BorrarConsola();
                }
                else
                {
                    
                }
            }
        }
        static void Menu()
        {
            ConsolaFons();
            Capcalera();
            MenuText();
            return;
        }
        static bool ValidarOpcio(string opcioS) // Aquest validara si la opció que hem escollit esta entre els valors possibles.
        {
            int opcioN = 0;
            bool validacio = false;
            if ("87654321Q".Contains(opcioS))
            {
                opcioN = Convert.ToInt32(opcioS);
                validacio = true;
                if (opcioN > 8 || opcioN < 1)
                {
                    validacio = false;
                }
            }
            else
            {
                validacio = false;
            }
            return validacio;
        }
        static void BorrarConsola() // Aquest borrara la consola jo vulgui tornant d'aquesta manera al principi
        {
            int contador = 3;
            while (contador >= 0)
            {
                Console.Write("\r");
                Console.Write($"Tornant al menú en {contador} segons...");
                Thread.Sleep(1000);
                contador--;
            }
            Console.Clear();
            return;
        }
        static string MenuText() // Aquest es el menu en text
            {
            string text;
            text = "╔═══════════════════════════════════════════════════════╗\n" +
                   "║                        OPCIONS                        ║\n" +
                   "╠═══════════════════════════════════════════════════════╣\n" +
                   "║                                                       ║\n" +
                   "║                      1 - MAXIM                        ║\n" +
                   "║                      2 - MCD                          ║\n" +
                   "║                      3 - MCM                          ║\n" +
                   "║                      4 - FACTORIAL                    ║\n" +
                   "║                      5 - COMBINATORI                  ║\n" +
                   "║                      6 - MAJOR DIVISOR                ║\n" +
                   "║                      7 - ES PRIMER                    ║\n" +
                   "║                      8 - NUMEROS PRIMERS              ║\n" +
                   "║                      Q - SORTIR                       ║\n" +
                   "║                                                       ║\n" +
                   "╚═══════════════════════════════════════════════════════╝";

            Console.WriteLine(text);
            
            return text;
            }
        static void Capcalera()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t MENÚ MATEMÀTIC 2024");
            Console.WriteLine("\r");
            Console.WriteLine("\r");
            return;
        }
        static void ConsolaFons()
        {
            Console.WindowHeight = 20;
            Console.WindowWidth = 60;
            Console.BackgroundColor = ConsoleColor.DarkGray;

        }
    }
}