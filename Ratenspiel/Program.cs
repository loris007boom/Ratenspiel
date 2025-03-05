int maximum = 100;
int minimum = 0;
string? a = "";
Console.WriteLine("Denke dir ein Zahl von 0 bis 100 aus.");
Console.WriteLine("Ich werde dein Zahl herausfinden!");
Console.WriteLine("Sag mir einfach, wenn dein Zahl grösser, kleiner oder richtig ist.");
Console.Write("Ist dein Zahl " + (maximum+minimum)/2 + "? ");
a = Convert.ToString(Console.ReadLine());
while (a!="richtig"&&a!="grösser"&&a!="kleiner")
{Console.WriteLine("Bitte, antworte nur mit: grösser, kleiner oder richtig.");
Console.Write("Ist dein Zahl " + (maximum+minimum)/2 + "? ");
a = Convert.ToString(Console.ReadLine());}
while (a!="richtig")
{
    if (a=="grösser")
{
    minimum = (maximum+minimum)/2;
    Console.Write("Ist dein Zahl " + (maximum+minimum)/2 + "? ");
    a = Convert.ToString(Console.ReadLine());
    while (a!="richtig"&&a!="grösser"&&a!="kleiner")
{Console.WriteLine("Bitte, antworte nur mit: grösser, kleiner oder richtig.");
Console.Write("Ist dein Zahl " + (maximum+minimum)/2 + "? ");
a = Convert.ToString(Console.ReadLine());}
}
if (a=="kleiner")
{
    maximum = (maximum+minimum)/2;
    Console.Write("Ist dein Zahl " + (maximum+minimum)/2 + "? ");
    a = Convert.ToString(Console.ReadLine());
    while (a!="richtig"&&a!="grösser"&&a!="kleiner")
{Console.WriteLine("Bitte, antworte nur mit: grösser, kleiner oder richtig.");
Console.Write("Ist dein Zahl " + (maximum+minimum)/2 + "? ");
a = Convert.ToString(Console.ReadLine());}
}
}

if (a=="richtig")
Console.WriteLine("Ich habe wieder gewonnen!");