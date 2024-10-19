
/*

// Task-1

Console.Write("Count of Minutes: ");
int countMinutes=Convert.ToInt32(Console.ReadLine());

int hour=countMinutes/60;
int minute=countMinutes%60;

if (minute!=0)
{
    Console.WriteLine($"Result: {hour}:{minute}");
}
else
{
    Console.WriteLine($"Result: {hour}:{minute}0");
}



// Task-2

Console.Write("Yoshni kiriting: ");
int age=Convert.ToInt32(Console.ReadLine());

if (0<age && age<=12)
{
    Console.WriteLine("bola");
}
else if(13<=age && age<=19)
{
    Console.WriteLine("o'smir");
}
else if(20<=age && age<=59)
{
    Console.WriteLine("kattalar");
}
else
{
    Console.WriteLine("katta");
}



// Task-3

Console.Write("First Subject Ball: ");
int firstSubject=Convert.ToInt32(Console.ReadLine());
Console.Write("Second Subject Ball: ");
int secondSubject=Convert.ToInt32(Console.ReadLine());
Console.Write("Third Subject Ball: ");
int thirdSubject=Convert.ToInt32(Console.ReadLine());

int middleScore=(firstSubject+secondSubject+thirdSubject)/3;

string result=
    80<=middleScore && middleScore<=100
        ? "A'lo" 
        : (60<=middleScore && middleScore<=79)
            ? "Yaxshi"
            : (40<=middleScore && middleScore<=59)
                ? "Qoniqarli"
                : "Qoniqarsiz";

Console.WriteLine($"Sizning o'rtacha o'zlashtiringiz: {result}");




// Task-4


Random random=new Random();
int randomNumber=random.Next(0, 100);


Console.Write("Enter num: ");
int num=Convert.ToInt32(Console.ReadLine());

string result=
    num==randomNumber
        ? "Siz kiritgan son randomNumber bilan teng!"
        : num>100
            ? "Iltimos, 1 va 100 oralig'ida son kiriting!"
            : num<randomNumber
                ? "Siz kiritgan son randomNumber dan kichik"
                : num>randomNumber
                    ? "Siz kiritgan son randomNumber dan katta"
                            : "Protcessing...";

Console.WriteLine($"RandomNumber: {randomNumber}");
Console.WriteLine($"{result}");


*/









