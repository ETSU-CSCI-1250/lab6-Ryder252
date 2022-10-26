//////////////////////METHOD/CALLS////////////////////////////////
ShowCharacter("Tennessee", 5);

Console.WriteLine("\nPlease enter the wholesale cost of an item(without the dollar sign).");
var wholesale = double.Parse(Console.ReadLine());
Console.WriteLine("Now please enter its markup percentage(in decimal form).");
var markup = double.Parse(Console.ReadLine());
CalculateRetail(wholesale, markup);

for(int temp = 80; temp <= 100; temp++)
{
double C = Celsius(temp);  
Console.WriteLine($"{temp} = {C}");
}

bool prime = IsPrime(5);

///////////////////////SHOW/CHARACTER///////////////////////////

static void ShowCharacter(string word, int index)
{
    Console.WriteLine($"The indexed character chosen is {word[index - 1]}.");
}

///////////////////////CALCULATE/RETAIL/////////////////////////

static void CalculateRetail(double wholesale, double markup)
{
    double retailPrice = wholesale + (wholesale * markup);
    Console.WriteLine($"Your retail price for this item is {retailPrice, 0:C}.\n");
}

////////////////////////CELSIUS////////////////////////////////

static double Celsius(double F)
{
    double C = (double)5/9 * (F - 32);
    return C;
}

//////////////////////////IS/PRIME/////////////////////////////

static bool IsPrime(int number)
{
    int b = 0;
    for(int i = 1; i <= number; i++)
    {
        if(number % i == 0)
        {
            b++;
        }
    }
    return (b == 2);
}

if(prime == true)
{
    System.Console.WriteLine("\nThe number specified is prime!");
}
else
{
    System.Console.WriteLine("\nThe number specified is composite!");
}