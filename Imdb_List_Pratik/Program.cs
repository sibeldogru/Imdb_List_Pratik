using System.ComponentModel;
using Imdb_List_Pratik;



List<Film> films = new List<Film>();

string yanit;

do
{
  Film film = new Film();
  Console.Write("Filmin adını giriniz:");
  film.Name = Console.ReadLine();


double rating; 
Console.Write("Filmin iMDB puanını giriniz:");
while (!double.TryParse(Console.ReadLine(), out rating))
 {
   Console.WriteLine("Geçersiz puan! Lütfen bir sayı girin:");
 }
 film.Rating = rating;

    films.Add(film);

  Console.WriteLine("Yeni bir film eklemek ister misiniz? Evet için 'e', hayır için 'h'ye basınız.");
  yanit = Console.ReadLine().ToLower();

} while (yanit == "e");


Console.WriteLine("------TÜM FİLMLER------");
foreach (var film in films)
{
    Console.WriteLine("Film: " + film.Name);
    Console.WriteLine("iMDB Puanı: " + film.Rating.ToString("0.0"));
}

Console.WriteLine("------IMDB PUANI 4 İLE 9 ARASINDA OLAN FİLMLER------");

foreach (var film in films.Where(f => f.Rating >= 4.0 && f.Rating <= 9.0))
{
    Console.WriteLine("Film: " + film.Name);
    Console.WriteLine("iMDB Puanı: " + film.Rating.ToString("0.0"));
}

Console.WriteLine("------A İLE BAŞLAYAN FİLMLER------");
foreach (var film in films.Where(f => f.Name.StartsWith("A", StringComparison.OrdinalIgnoreCase)))
{
    Console.WriteLine("Film: " + film.Name);
    Console.WriteLine("iMDB Puanı: " + film.Rating.ToString("0.0"));
}



