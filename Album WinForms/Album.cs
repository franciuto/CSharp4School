public class Album
{
    public int ID { get; set; }
    public string Titolo { get; set; }
    public string Autore { get; set; }
    public int Anno { get; set; }
    public string Categoria { get; set; }
    public int DurataMinuti { get; set; }

    public Album(int id, string titolo, string autore, int anno, string categoria, int durataMinuti)
    {
        ID = id;
        Titolo = titolo;
        Autore = autore;
        Anno = anno;
        Categoria = categoria;
        DurataMinuti = durataMinuti;
    }

    public static List<Album> GetSampleData()
    {
        return new List<Album>()
        {
            new Album(190290, "The dark side of the moon", "Pink Floyd", 1973, "rock", 57),
            new Album(2903123, "Variazioni Goldberg", "Bach", 1741, "classica", 51),
            new Album(2609101, "The Visitors", "ABBA", 1981, "pop", 62),
            new Album(93401, "Kind of Blue", "Miles Davis", 1959, "jazz", 48),
            new Album(190291, "Wish You Were Here", "Pink Floyd", 1975, "rock", 44),
            new Album(2903124, "Sinfonia n. 9", "Beethoven", 1824, "classica", 74),
            new Album(2609102, "Arrival", "ABBA", 1976, "pop", 34),
            new Album(93402, "A Love Supreme", "John Coltrane", 1965, "jazz", 33)
        };
    }
}
