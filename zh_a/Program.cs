//Kérjen be a felhasználótól egy tört számot. A szám egy 10 és 20 közötti törtszám legyen, amit
//bekérést követően alakítson egész értékké! Csak az intervallumban meghatározott számértéket
//fogadhatja el a program!

//Megoldás:
//Console.WriteLine("Kérek egy tört számot(10-20) :");
//double szam = Convert.ToDouble(Console.ReadLine());
//int szamKonv = Convert.ToInt32(szam);

//if(szam >= 10 && szam <= 20 )
//{
//    Console.WriteLine(szamKonv);
//} else
//{
//    Console.WriteLine("Nem 10 és 20 között adtad meg a számot");
//}

//Töltsön fel egy tömböt 25 és 50 közötti véletlenszámokkal. A tömb hossza az első bekért, egészre
//alakított szám legyen.

//Megoldás:

int szam = new Random().Next(25, 50);
int[] tomb = new int[szam];
int n = 0;

Console.WriteLine($"A tömb hossza: {szam}");

for (int i = 0; i < tomb.Length; i++)
{
    tomb[i] = new Random().Next(25, 51);
    n++;
    Console.WriteLine($"A tömb {n}. eleme: {tomb[i]}");
}

//a) Hány darab 40-nél nagyobb, páratlan szám van a tömbben? (3 pont)
int paratlanSzamolo = 0;
foreach (int p in tomb)
{
    if (p >= 40 && p % 2 != 0)
    {
        paratlanSzamolo++;
        Console.WriteLine($"A páratlan számok: {p}");
    }
}
Console.WriteLine($"A páratlan számok darabja: {paratlanSzamolo}");

//b) Kérjen be a felhasználótól egy 30 és 40 közötti számot, majd írja ki, hogy szerepel-e ez a szám
//a tömbben és hogy hányszor. Az intervallumellenőrzést nem kell elvégeznie. (3 pont)
Console.WriteLine("!!!Kérek 30-40 között egy számot:");
int bekertSzam = Convert.ToInt32(Console.ReadLine());
int szamolo = 0;

foreach(int sz in tomb)
{
    if (sz == bekertSzam)
    {
        szamolo++;
    }
}
Console.WriteLine($"A bekért szám ennyiszer szerepel a tömbben: {szamolo}");

//c) Minden 3-mal osztható tömbelemet szorozzon meg 2-vel! (5 pont)
for (int i = 0; i < tomb.Length; i++)
{
    if (tomb[i] % 3 == 0)
    {
        Console.WriteLine($"A hárommal osztható tömbelem: {tomb[i]}");
        Console.WriteLine($"Kettővel szorozva {tomb[i] * 2}");
    }
}

//d) Hányszor fordul elő a legnagyobb tömbelem? (3 pont)

Array.Sort(tomb);
for (int i = tomb.Length - 1; i > -1; i--)
{

    Console.WriteLine(tomb.First());
}

//e) Mennyi a 20 és 40 közötti számok átlaga? (3 pont)
int dbSzam = 0;
int megfeleloSzamok = 0;
int atlag = 0;

foreach (int huszNegyven in tomb)
{
    if (huszNegyven <= 40 && huszNegyven >= 20)
    {
        dbSzam++;
        megfeleloSzamok += huszNegyven;
        Console.WriteLine($"A 20 és 40 közötti számok: {huszNegyven}");
    }
}
Console.WriteLine($"Ennyi 20 és 40 közötti szám van: {dbSzam}");

atlag = megfeleloSzamok / dbSzam;
Console.WriteLine($"Az átlag: {atlag}");