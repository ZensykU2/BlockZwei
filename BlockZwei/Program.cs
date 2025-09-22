

//Aufgabe 1
/*Console.Write("Zahl 1:");
int zahl1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Zahl 2:");
int zahl2 = Convert.ToInt32(Console.ReadLine());
if (zahl2 < zahl1 && zahl1 > 5)
{
    int temp = zahl1;
    zahl1 = zahl2;
    zahl2 = temp;
}
else
{
    if (zahl1 == zahl2)
        zahl1 = 5;
    zahl2 = 8;
}
Console.WriteLine("Ausgabe 1 = " + Convert.ToString(zahl1));
Console.WriteLine("Ausgabe 2 = " + Convert.ToString(zahl2));
Console.ReadLine();
*/
// a) Ausgabe 1 = 3 | Ausgabe 2 = 6
// b) Ausgabe 1 = 5 | Ausgabe 2 = 8

//Aufgabe 2
/*int anzahl = 0;
double note1 = 0.0, note2 = 0.0;
Console.Write("Note 1:");
note1 = Convert.ToDouble(Console.ReadLine());
anzahl += 1;
Console.Write("Note 2:");
note2 = Convert.ToDouble(Console.ReadLine());
anzahl++;
double schnitt = (note1 + note2) / anzahl;
if (schnitt >= 4)
{
    Console.WriteLine("*****");
    int durchschnitt = (int)(schnitt * 2);
    durchschnitt = (durchschnitt + 1) / 2;
    if (durchschnitt == 4)
        Console.WriteLine("Typ 2");
    else
    {
        if (durchschnitt == 5)
            Console.WriteLine("Typ 3");
        else
            Console.WriteLine("Typ 4");
    }
}
else
{
    Console.WriteLine("-----");
    if (note1 >= 4 || note2 >= 4)
        Console.WriteLine("Typ 1");
    else
        Console.WriteLine("Typ 0");
}
Console.ReadLine();
*/
// a) Typ 1
// b) Typ 4
// c) Typ 0
