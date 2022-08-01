using HW._09.Task3;

//created songs
Music track1 = new("Death", 5, "001", "Voice Of The Soul", 223);
Music track2 = new("Metallica", 9, "002", "Master Of Puppets", 515);
Music track3 = new("Pantera", 8, "003", "Cowboys from Hell", 248);
Music track4 = new("Judas Priest", 8, "004", "Painkiller", 364);
Music track5 = new("Iron Maiden", 12, "005", "Fear Of The Dark", 436);
Music track6 = new("Megadeth", 7, "006", "Symphony of Destruction", 241);
Music track7 = new("Scorpions", 7, "007", "Wind Of Change", 301);

//created films
Film movie1 = new("The Bucket List", 4096, "001", "Rob Reiner", "Jack Nicholson", "Rowena King");
Film movie2 = new("Back to the Future", 5879, "002", "Robert Zemeckis", "Michael J. Fox", "Mary Steenburgen");
Film movie3 = new("The Pianist", 8150, "003", "Roman Polanski", "Adrien Brody", "Emilia Fox");
Film movie4 = new("The Shawshank Redemption", 9550, "004", "Frank Darabont", "Tim Robbins", "Renee Blaine");
Film movie5 = new("Titanic", 6780, "005", "James Cameron", "Leonardo DiCaprio", "Kate Winslet");

//created programs
ComputerProgram program1 = new("Unity", 14336, "001");
ComputerProgram program2 = new("Photoshop", 3072, "002");
ComputerProgram program3 = new("Godot", 450, "003");
ComputerProgram program4 = new("Visual Studio", 4153, "004");



//create catalog
Catalog myCatalog = new(countMusic: 7, countFilms: 5, countPrograms: 4);

//added music in catalog
myCatalog.Music[0] = track1;
myCatalog.Music[1] = track2;
myCatalog.Music[2] = track3;
myCatalog.Music[3] = track4;
myCatalog.Music[4] = track5;
myCatalog.Music[5] = track6;
myCatalog.Music[6] = track7;

//added films in catalog
myCatalog.Films[0] = movie1;
myCatalog.Films[1] = movie2;
myCatalog.Films[2] = movie3;
myCatalog.Films[3] = movie4;
myCatalog.Films[4] = movie5;

//added films in catalog
myCatalog.ComputerPrograms[0] = program1;   
myCatalog.ComputerPrograms[1] = program2;
myCatalog.ComputerPrograms[2] = program3;
myCatalog.ComputerPrograms[3] = program4;


//play music
myCatalog.Play(
    myCatalog.Music[0],
    myCatalog.Music[1],
    myCatalog.Music[2],
    myCatalog.Music[3],
    myCatalog.Music[4],
    myCatalog.Music[5],
    myCatalog.Music[6]);


//play films
myCatalog.Play(
    myCatalog.Films[0],
    myCatalog.Films[1],
    myCatalog.Films[2],
    myCatalog.Films[3],
    myCatalog.Films[4]);