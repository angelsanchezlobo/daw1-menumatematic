int numero1, numero2, aux;
Console.Write("opcio: ");
aux = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("hola");
switch (aux)
{
    //Minim Comu Divisor
    case 1:
        Console.Write("num1: ");
        numero1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("num2: ");
        numero2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"El minim comu divisor d'aquests dos numeros {MinimComuDivisor(numero1, numero2)}.");
        break;
    //Es primer
    case 2:
        bool primer = false;
        Console.Write("num1: ");
        numero1 = Convert.ToInt32(Console.ReadLine());
        primer = EsPrimer(numero1);
        if (primer)
            Console.WriteLine($"{numero1} es un numero primer.");
        else
            Console.WriteLine($"{numero1} no es un numero primer.");
        break;
    //Maxim comu divisor
    case 3:
        Console.Write("num1: ");
        numero1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("num2: ");
        numero2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"El maxim comu multiple d'aquests dos numeros {MaximComuMultiple(ref numero1, ref numero2)}.");
        break;
    //Factorial
    case 4:
        Console.Write("num1: ");
        numero1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"El numero factorial d'aquest número es {Factorial(numero1)}.");
        break;
    //Combinatori
    case 5:
        Console.Write("num1: ");
        numero1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("num2: ");
        numero2 = Convert.ToInt32(Console.ReadLine());
        int factorial1 = Factorial(numero1);
        int factorial2 = Factorial(numero2);
        int factorialResta = Factorial(numero1 - numero2);
        Console.WriteLine($"El combinatori d'aquests dos numeros es {Combinatori(ref factorial1, ref factorial2, ref factorialResta)}.");
        break;
    //PrimersPrimers
    case 6:
        Console.Write("num1: ");
        numero1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Els numeros primers primers d'aquest numero es {PrimersPrimers(ref numero1)}");
        break;
    case 7:
        Console.Write("num1: ");
        numero1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("num2: ");
        numero2 = Convert.ToInt32(Console.ReadLine());
        Maxim(ref numero1, ref numero2);
        Console.WriteLine($"El numero més gran es {numero1} i el més petit {numero2}.");
        break;
    default:
        Console.WriteLine("hola");
        break;
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