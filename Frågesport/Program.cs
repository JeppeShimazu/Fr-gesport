//namn
Console.WriteLine("Hej, vad heter du?");
string name = Console.ReadLine();

//intro

Console.WriteLine($"Hej {name}! Välkommen till frågesport spelet");
Console.ReadLine();
Console.WriteLine("spelet består utav 3 frågor i 3 olika kategorier");
Console.ReadLine();
Console.WriteLine("Nu börjar spelet.");
Console.ReadLine();

//poäng
int poäng = 0;

//spelet

Console.WriteLine("Fråga 1: i vilken kontinent bor flest människor?");
Console.WriteLine("a=Europa");
Console.WriteLine("b=Asien");
Console.WriteLine("c=Sydamerika");

string rätt=Console.ReadLine();
if (rätt == "b")

{
Console.WriteLine("Asien var rätt svar!");

poäng++;

Console.WriteLine($"Grattis du har nu {poäng} poäng!");

Console.ReadLine();

}
if (rätt != "b")
{
Console.WriteLine("Du har tyvär fel, correct svar var Asien..");
poäng--;
Console.WriteLine($"Du har nu {poäng} poäng!");
}
//Fråga nummer 2
Console.WriteLine("Nästa fråga.");
Console.ReadLine();
Console.WriteLine("Fråga 2: Hur många tidszoner har ryssland?");
Console.WriteLine("a=7");
Console.WriteLine("b=1 (duh)");
Console.WriteLine("c=11");
string rätt2=Console.ReadLine();
if (rätt2 == "c")
{
Console.WriteLine("11 är rätt!");
poäng++;
Console.WriteLine($"Grattis du har nu {poäng} poäng!");
Console.ReadLine();
}
if (rätt2 != "c")
{
Console.WriteLine("Du har tyvär fel, korrect svar var 11..");
poäng--;
Console.WriteLine($"Du har nu {poäng} poäng!");
}

//Sista frågan
Console.WriteLine("Sista frågan.");
Console.ReadLine();
Console.WriteLine("Fråga 3: Hur många ungar kan en delfin föda under sin livstid?");
Console.WriteLine("a=6");
Console.WriteLine("b=2");
Console.WriteLine("c=8");
string rätt3=Console.ReadLine();
if (rätt3 == "c")
{
Console.WriteLine("8 är rätt!");
poäng++;
Console.WriteLine($"Grattis du har nu {poäng} poäng!");
Console.ReadLine();
}
if (rätt3 != "c")
{
Console.WriteLine("Du har tyvär fel, korrect svar var 8..");
poäng--;
Console.WriteLine($"Du har nu {poäng} poäng!");
}
Console.ReadLine();
Console.WriteLine($"Du fick {poäng} poäng! ");
Console.WriteLine("Tack för att du spelade :)");
Console.ReadLine();
