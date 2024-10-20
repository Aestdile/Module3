/*


// Task-1

Console.Write("Enter word: ");
string originWord=Console.ReadLine();

string newString="";

for (int i=originWord.Length-1; i>=0; i--)
{
    newString+=originWord[i];
}

if (originWord==newString)
{
    Console.WriteLine("Palindrome");
}
else
{
    Console.WriteLine("Not Palindrome");
}


// Task-2

Console.Write("Celsius bo'yicha temperaturani kiriting: ");
string input = Console.ReadLine();

if (double.TryParse(input, out double celsius))
{
    double fahrenheit;
    double kelvin;

    switch ((int)celsius) 
    {
        case 0:
            fahrenheit = 32.0;
            kelvin = 273.15;
            break;
        case 25:
            fahrenheit = 77.0;
            kelvin = 298.15;
            break;
        case 100:
            fahrenheit = 212.0;
            kelvin = 373.15;
            break;
        default:
            fahrenheit = (celsius * 9 / 5) + 32;
            kelvin = celsius + 273.15;
            break;
    }

    Console.WriteLine($"Selsiyus: {celsius}, Fahrenheit: {fahrenheit}, Kelvin: {kelvin}");
}
else
{
    Console.WriteLine("Iltimos, to'g'ri son kiriting.");
}


// Task-3

Console.Write("Enter numCount: ");
int numCount=Convert.ToInt32(Console.ReadLine());
List<int> numbers = new List<int>();

for (int i=0; i<numCount; i++)
{
    Console.Write("Enter num: ");
    int num=Convert.ToInt32(Console.ReadLine());
    numbers.Add(num);
}

numbers.Sort();
Console.WriteLine($"Tartiblangan qator: {string.Join(", ", numbers)}");
numbers.Reverse();
Console.WriteLine($"Teskari tartibdagi qator: {string.Join(", ", numbers)}");



// Task-4


Console.Write("Please, enter text: ");
string text=Console.ReadLine();

Dictionary <char, int> dict=new Dictionary<char, int>();

for (int i=0; i<text.Length; i++)
{
    char c=text[i];
    if (dict.ContainsKey(c))
    {
        dict[c]++;
    }
    else
    {
        dict[c]=1;
    }

}

var keys=dict.Keys;

for (int i=0; i<keys.Count; i++)
{
    char key=keys.ElementAt(i);
    Console.WriteLine($"'{key}': {dict[key]} martta qatnashgan!");
}

*/




















