using HW13.Task2;
using static System.Console;
using static HW13.Task2.NewtonFunctions;
using static HW13.Task2.TextJsonFunctions;

Song mySong1 = new("Blind Empire", "Harmonix College", new TimeSpan(0,3,18), 2019, Genre.Post | Genre.Metal);
Song mySong2 = new("Pet Sematary", "Ramones", new TimeSpan(0, 3, 30), 1989, Genre.Punk | Genre.Rock);
Song mySong3 = new("Мы Вам Не Верим", "Порнофильмы", new TimeSpan(0, 6, 36), 2014, 12);
Song mySong4 = new("Pig Powder", "God Is An Astronaut", new TimeSpan(0, 6, 36), 2015, Genre.Post | Genre.Rock);
Song mySong5 = new("I Want Out", "Helloween", new TimeSpan(0, 6, 36), 1988, Genre.Metal);
Song mySong6 = new("Norupo", "Heilung", new TimeSpan(0, 4, 17), 2019, 19);
Song mySong7 = new("Stairway to Heaven", "Led Zeppelin", new TimeSpan(0, 8, 02), 1971, Genre.Rock);

SongService Service = new();

Service.AddSongsInList(mySong1, mySong2, mySong3, mySong4, mySong5, mySong6, mySong7);

WriteLine("\n\t~~~~~~~[Text Serialize]~~~~~~~");
foreach (var song in SongService.SongsList)
{
    WriteLine(TextSerialize(Service.GetSongsData(song)));
}

WriteLine("\n\t~~~~~~~[NewtonSerialize]~~~~~~~");
foreach (var song in SongService.SongsList)
{
    WriteLine(NewtonSerialize(Service.GetSongsData(song)));
}


WriteLine("\n\t~~~~~~~[Serch]~~~~~~~");
string genreStr = "Post, Rock";
Service.SearchSongByGenre(genreStr);