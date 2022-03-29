using System.Collections;

namespace ChampionsLeagueLibrary;

public enum FootballClub
{
    None,
    FCPorto,
    Arsenal,
    RealMadrid,
    Chelsea,
    Barcelona
}

// TODO: Vytvořte statickou třídu FootballClubInfo
public static class FootballClubInfo
{
    // TODO: Vytvořte veřejnou konstatu int Count, která vrací počet hodnot (položek) ve výčtovém typu FootballClub
    public const int Count = 6;

    // TODO: Vytvořte veřejnou statickou vlastnost IEnumerable Items, která disponuje pouze operací get
    // - pomocí enumerátoru vraťte všechny položky ve výčtovém typu FootballClub (od None až po Barcelona)
    public static IEnumerable? Items { 
        get {
            //List<FootballClub> list = new List<FootballClub>();
            foreach (FootballClub item in Enum.GetValues(typeof(FootballClub)))
            {
                //list.Add(item);
                yield return item;
            }

            //yield return list.GetEnumerator();
        } 
    }

    // TODO: Vytvořte veřejnou statickou metodu string GetName
    // - parametr FootballClub footballClub
    // - metoda vrací řetězcové vyjádření pro každou položku výčtového typu
    // None -> "", FCPorto -> "FC Porto", Arsenal -> "Arsenal", RealMadrid -> "Real Madrid"
    // Chelsea -> "Chelsea", Barcelona -> "Barcelona"
    // - jinak je vrácen prázdný řetězec
    public static string GetName(FootballClub footballClub)
    {
        switch (footballClub)
        {
            case FootballClub.None:
                return "";
                break;
            case FootballClub.FCPorto:
                return "FC Porto";
                break;
            case FootballClub.Arsenal:
                return "Arsenal";
                break;
            case FootballClub.RealMadrid:
                return "Real Madrid";
                break;
            case FootballClub.Chelsea:
                return "Chelsea";
                break;
            case FootballClub.Barcelona:
                return "Barcelona";
                break;
            default:
                return string.Empty;
                break;
        }
    }
    // Konec třídy FootballClubInfo
}