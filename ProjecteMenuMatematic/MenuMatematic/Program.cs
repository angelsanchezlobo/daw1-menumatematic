namespace Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcioS = ""; int numero1, numero2, aux;
            while (opcioS != "Q" && opcioS != "q")
            {
                Menu();
                Console.Write("Quina opció vols escollir? ");
                opcioS = Console.ReadLine();
                if (opcioS == "Q" || opcioS == "q")
                {
                    BorrarConsola();
                    Console.WriteLine("Adeu!");
                }
                else if (!ValidarOpcio(opcioS))
                {
                    Console.WriteLine("No has escollit una opció de les possibles.");
                    BorrarConsola();
                }
                else
                {
                    aux = Convert.ToInt32(opcioS);
                    switch (aux)
                    {
                        //Minim Comu Divisor
                        case 3:
                            BorrarConsola();
                            Console.Write("Escriu el primer número per fer el MCD: ");
                            numero1 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Escriu el segón: ");
                            numero2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"El minim comu divisor d'aquests dos numeros {MinimComuDivisor(numero1, numero2)}.");
                            retorn();
                            BorrarConsola();
                            break;
                        //Es primer
                        case 7:
                            BorrarConsola();
                            bool primer = false;
                            Console.Write("Escriu un número per comprovar si es primer: ");
                            numero1 = Convert.ToInt32(Console.ReadLine());
                            primer = EsPrimer(numero1);
                            if (primer)
                                Console.WriteLine($"{numero1} es un numero primer.");
                            else
                                Console.WriteLine($"{numero1} no es un numero primer.");
                            break;
                        //Maxim comu Multiple
                        case 2:
                            BorrarConsola();
                            Console.Write("Escriu el primer número per fer el MCM: ");
                            numero1 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Escriu el segón: ");
                            numero2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"El maxim comu multiple d'aquests dos numeros {MaximComuMultiple(ref numero1, ref numero2)}.");
                            retorn();
                            BorrarConsola();
                            break;
                        //Factorial
                        case 4:
                            BorrarConsola();
                            Console.Write("Escriu un número per fer el factorial d'aquest: ");
                            numero1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"El numero factorial d'aquest número es {Factorial(numero1)}.");
                            retorn();
                            BorrarConsola();
                            break;
                        //Combinatori
                        case 5:
                            BorrarConsola();
                            Console.Write("Escriu el primer número per fer el combinatori: ");
                            numero1 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Escriu el segón: ");
                            numero2 = Convert.ToInt32(Console.ReadLine());
                            int factorial1 = Factorial(numero1);
                            int factorial2 = Factorial(numero2);
                            int factorialResta = Factorial(numero1 - numero2);
                            Console.WriteLine($"El combinatori d'aquests dos numeros es {Combinatori(ref factorial1, ref factorial2, ref factorialResta)}.");
                            retorn();
                            BorrarConsola();
                            break;
                        //PrimersPrimers
                        case 8:
                            BorrarConsola();
                            Console.Write("Escriu un número per veure tots els primers fins aquest rang: ");
                            numero1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"Els numeros primers primers d'aquest numero es {PrimersPrimers(ref numero1)}");
                            retorn();
                            BorrarConsola();
                            break;
                        //Maxim
                        case 1:
                            BorrarConsola();
                            Console.Write("Escriu el primer número per indicar quin es el més gran: ");
                            numero1 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Escriu el segón: ");
                            numero2 = Convert.ToInt32(Console.ReadLine());
                            Maxim(ref numero1, ref numero2);
                            Console.WriteLine($"El numero més gran es {numero1} i el més petit {numero2}.");
                            retorn();
                            BorrarConsola();
                            break;
                        case 6:
                            BorrarConsola();
                            Console.Write("Escriu un número per veure el seu major divisor: ");
                            numero1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"El major divisor d'aquest número introduit es {MajorDivisor(numero1)}");
                            retorn();
                            BorrarConsola();
                            break;
                        default:
                            Console.WriteLine("");
                            break;
                    }
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
            if ("87654321".Contains(opcioS))
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
        static string Resultat()
        {
            string text = "hola";
            Console.WriteLine(text);
            return text;
        }
        static void retorn()
        {
            int contador = 5;
            while (contador >= 0)
            {
                Console.Write("\r");
                Console.Write($"Tornant al menú en {contador} segons...");
                Thread.Sleep(1000);
                contador--;
            }
            return;
        }
        static void BorrarConsola() // Aquest borrara la consola jo vulgui tornant d'aquesta manera al principi
        {
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
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                    MENU MATEMTIC 2024                         ");
            Console.WriteLine("\r");
            Console.WriteLine("\r");
            return;
        }
        static void ConsolaFons()
        {
            Console.WindowHeight = 20;
            Console.WindowWidth = 60;
            Console.BackgroundColor = ConsoleColor.DarkBlue;

        }
        static int MinimComuDivisor(int numero1, int numero2)
        {
            int i = 1, mcd = 1;
            i = numero1 / numero2;
            while (i <= numero1 && i <= numero2)
            {
                if (numero1 % mcd == 0 && numero2 % mcd == 0)
                    mcd = i;
                i++;
            }
            return mcd;
        }
        static bool EsPrimer(int numero1)
        {
            int i = 1, j = 0;
            bool validacio = false;
            while (i <= numero1)
            {
                if (numero1 % i == 0)
                    j++;
                i++;
            }
            if (j == 2)
                validacio = true;
            return validacio;
        }
        static string PrimersPrimers(ref int numero1)
        {
            int j = 2;
            string primers = "";
            for (int i = 2; i <= numero1; i++)
            {
                int divisor = 2;
                bool esPrimer = true;
                while (divisor < i && esPrimer)
                {
                    if (i % divisor == 0)
                    {
                        esPrimer = false;
                    }
                    divisor++;
                }
                if (esPrimer)
                {
                    primers += $" {i} ";
                }
            }
            return primers;
        }
        static int MaximComuMultiple(ref int numero1, ref int numero2)
        {

            int i = 0, mcm = 0;
            i = numero1 * numero2;
            while (i > numero1 && i > numero2)
            {
                if (mcm % numero1 == 0 && mcm % numero2 == 0)
                    mcm = i;
                i--;
            }
            return mcm;
        }
        static int Factorial(int numero)
        {
            int factorial = 1;
            for (int i = 1; i <= numero; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
        static double Combinatori(ref int factorial1, ref int factorial2, ref int factorialResta)
        {
            return (double)factorial1 / (factorial2 * factorialResta);
        }
        static void Maxim(ref int numero1, ref int numero2)
        {
            if (numero2 > numero1)
                (numero1, numero2) = (numero2, numero1);
            return;
        }
        static int MajorDivisor(int numero)
        {
            int majorDivisor = 1;
            for (int i = 2; i <= numero / 2; i++)
            {
                if (numero % i == 0 && i > majorDivisor)
                {
                    majorDivisor = i;
                }
            }

            return majorDivisor;
        }

    }
}