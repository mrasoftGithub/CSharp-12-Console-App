using System.Runtime.CompilerServices;
var InLineArray = new InLineArrayStruct();
InLineArray[0] = 100;
InLineArray[1] = 200;

Console.WriteLine("InLineArray:");
Console.WriteLine($"-InLineArray[0]:{InLineArray[0]}");
Console.WriteLine($"-InLineArray[1]:{InLineArray[1]}\n");

//--------------------------------------------------------------------------------

var arrayOud = new int[] { 1, 2, 3 };
int[] arrayCollectionExpression = [1, 2, 3];

Span<int> spanCollectionExpression = [10, 20, 30];
List<int> listCollectionExpression = [100, 200, 300];

List<int> collectieSpreadOperator = [.. arrayCollectionExpression, .. spanCollectionExpression, .. listCollectionExpression, 1000, 2000];

Console.WriteLine("collectieSpreadOperator:");
foreach (int i in collectieSpreadOperator)
{
    Console.WriteLine(i);
}

//--------------------------------------------------------------------------------

// Constructor
EIGENAAR1 eigenaar1 = new(1, "Sandra's auto", "Sandra", "Janssen", "Noord");
eigenaar1.ToonGegevens();

// Primary Constructor
EIGENAAR2 eigenaar2 = new(2, "Peter's auto", "Peter", "Veerman", "Midden");
eigenaar2.ToonGegevens();

public class EIGENAAR1
{
    // Backing variables
    private readonly int? _ID;
    private readonly string? _Omschrijving;
    private readonly string? _Voornaam;
    private readonly string? _Achternaam;
    private readonly string? _Regio;

    public EIGENAAR1(int? ID, string? Omschrijving, string? Voornaam, string? Achternaam, string? Regio)
    {
        // Constructor
        _ID = ID;
        _Omschrijving = Omschrijving;
        _Voornaam = Voornaam;
        _Achternaam = Achternaam;
        _Regio = Regio;
    }

    public void ToonGegevens()
    {
        // Alles wat via de constructor binnenkomt moet je
        // overzetten naar Backing variables om het te kunnen gebruiken
        Console.WriteLine($"\nID:{_ID}\nOmschrijving:{_Omschrijving}\nVoornaam:{_Voornaam}\nAchternaam:{_Achternaam}\nRegio:{_Regio}");
    }
}

public class EIGENAAR2(int? ID, string? Omschrijving, string? Voornaam, string? Achternaam, string? Regio)
{
    public void ToonGegevens()
    {
        // Je kunt de parameters van de Primary Constructor meteen gebruiken
        Console.WriteLine($"\nID: {ID}\nOmschrijving:{Omschrijving}\nVoornaam:{Voornaam}\nAchternaam:{Achternaam}\nRegio:{Regio}");
    }
}

//--------------------------------------------------------------------------------

// Inline Array
[InlineArray(2)]
public struct InLineArrayStruct
{
    private int? _ID;
}
