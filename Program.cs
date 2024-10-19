
/*

// Task-1

Console.Write("word: ");
string word=Console.ReadLine();
int lenz=word.Length;
Console.Write("num: ");
int num=Convert.ToInt32(Console.ReadLine());

if (num>lenz)
{
    string upper=word.ToUpper();
    Console.WriteLine(upper);
}
else
{
    string lower=word.ToLower();
    Console.WriteLine(lower);
}




// Task-2

Console.Write("Enter num1: ");
int x=Convert.ToInt32(Console.ReadLine());
Console.Write("Enter num2: ");
int y=Convert.ToInt32(Console.ReadLine());

if (x>y)
{
    Console.WriteLine("x is greater than y");
}
else if (x<y)
{
    Console.WriteLine("x is less than y");
}
else if (x==y)
{
    Console.WriteLine("x is equal to y");
}
else
{
    Console.WriteLine("x and y are not comprable");
}




// Task-3


Console.WriteLine(@"Assalomu alaykum! 
Xush kelibsiz! 
Men siz kiritgan hafta kunini Ingliz tiliga o'girib beruvchi dasturman.");
Console.WriteLine(@"Iltimos, hafta kunini namunadagidek to'g'ri holatda kiriting  --> 
                Dushanba
                Seshanba
                Chorshanba 
                Payshanba
                Juma
                Shanba 
                Yakshanba ");
string dayName=Console.ReadLine();
string result=dayName switch 
{
    "Dushanba" => "Monday",
    "Seshanba" => "Tuesday",
    "Chorshanba" => "Wednesday",
    "Payshanba" => "Thursday",
    "Juma" => "Friday",
    "Shanba" => "Saturday",
    "Yakshanba" => "Sunday",
    _ => "Ma'lumot kiritishda xatolik bor! Iltimos qaytadan urinib ko'ring!"
};

Console.WriteLine($"    Siz kutgan natija:    " +result);


*/




































