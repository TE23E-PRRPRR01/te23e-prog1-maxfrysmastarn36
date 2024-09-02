Console.Clear();
Console.WriteLine("Vad är ditt namn? ");
string namn = Console.ReadLine();
Console.Clear();
Console.WriteLine("Vad är din favorit ost? ");
string ost = Console.ReadLine();
Console.Clear();
Console.WriteLine("Favorit prilla? ");
string prilla = Console.ReadLine();
Console.Clear();
Console.WriteLine("Ange en kroppsdel? ");
string kropp = Console.ReadLine();
Console.Clear();

if (namn == "" || ost == "" || prilla == "" || kropp == "")
{
    Console.WriteLine("fuck off");
}
else
{
    Console.WriteLine($"Hallå {namn}, jag tycker också {ost} är mycket smarrig.");
    Console.WriteLine($"{prilla} är mycket lökig inte bra alls. {kropp} sånt händer allså");

}
