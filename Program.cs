using CA230320;
using System.Text;

List<Versenyzo> versenyzok = new();

using StreamReader sr = new("..\\..\\..\\src\\ub2017egyeni.txt", Encoding.UTF8);
_ = sr.ReadLine();
while (!sr.EndOfStream)
{
    string sor = sr.ReadLine();
    Versenyzo ujVersenyzo = new(sor);
    versenyzok.Add(ujVersenyzo);
}

int indulokSzam = versenyzok.Count;
Console.WriteLine($"3. feladat: egyéni indulók száma {indulokSzam} fő");

