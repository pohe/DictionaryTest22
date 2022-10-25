// See https://aka.ms/new-console-template for more information
using DictionaryTest22;


Player p1 = new Player(10, "Fnuggi", PlayerType.Wizard);
Player p2 = new Player(1, "Buggi", PlayerType.Wizard);
Player p3 = new Player(2, "Luggi", PlayerType.Warrior);
Player p4 = new Player(17, "Hulli", PlayerType.Hunter);
Player p5 = new Player(16, "Goggi", PlayerType.Warrior);

//Console.WriteLine(p1.ToString() );


//Player[] playerArray = new Player[5];
//playerArray[0] = p1;
//playerArray[1] = p2;
//playerArray[2] = p3;
//playerArray[3] = p4;
//playerArray[4] = p5;

//foreach (Player p in playerArray)
//{
//    Console.WriteLine(p.ToString());
//}

List<Player> playerList = new List<Player>() { p1, p2, p3, p4, p5 };

int searchForNo = 170;

foreach (Player item in playerList)
{
    if (item.No == searchForNo)
        Console.WriteLine(item);
}



//foreach (Player item in playerList)
//{
//    Console.WriteLine(item);
//}

//playerList.Remove(p3);
//int i = 0;

//while( i< playerList.Count)
//{
//    Console.WriteLine(playerList[i].ToString());
//    i++;
//}

//bool p3Findes = playerList.Contains(p3);
//Console.WriteLine(p3Findes);

Dictionary<int, Player> playerDictionary = new Dictionary<int, Player>();
playerDictionary.Add(p1.No, p1);
playerDictionary.Add(p2.No, p2);
playerDictionary.Add(p3.No, p3);
playerDictionary.Add(p4.No, p4);
playerDictionary.Add(p5.No, p5);


foreach (var item in playerDictionary)
{
    Console.WriteLine(item.Key);
}

Player pp = playerDictionary[10];
Console.WriteLine($"PP {pp}");


if ( playerDictionary.ContainsKey(170) )
    Console.WriteLine(playerDictionary[170]);

Player px = new Player(10, "XXXX", PlayerType.Wizard);

if (!playerDictionary.ContainsKey(px.No))
    playerDictionary.Add(px.No, px);

playerDictionary.Remove(px.No);


Dictionary<string, Player> playerDictionaryByName = new Dictionary<string, Player>();

playerDictionaryByName.Add(p1.Name, p1);
playerDictionaryByName.Add(p2.Name, p2);
playerDictionaryByName.Add(p3.Name, p3);
playerDictionaryByName.Add(p4.Name, p4);
playerDictionaryByName.Add(p5.Name, p5);

Console.WriteLine("playerDictionaryByName");
foreach (var item in playerDictionaryByName.Keys)
{
    Console.WriteLine(item);
}

Console.WriteLine(  "DictionaryStudent");

Dictionary<int, Student> dictionaryStudent = new Dictionary<int, Student>();
Student s1;
s1 = new Student("Poul", true);
Student s2 = new Student("Carina", true);
Student s3 = new Student("Anders", false);

dictionaryStudent.Add(s1.Id, s1);
dictionaryStudent.Add(s2.Id, s2);
dictionaryStudent.Add(s3.Id, s3);

dictionaryStudent.Remove(s2.Id);

foreach (Student s in dictionaryStudent.Values)
{
    Console.WriteLine(s.ToString());
}


//Don't do it
//for (int i = 1; i <= dictionaryStudent.Count; i++)
//{
//    if (dictionaryStudent.ContainsKey(i))
//        Console.WriteLine(dictionaryStudent[i] );
//}
