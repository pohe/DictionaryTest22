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

List<Player> playerList = new List<Player>() {p1, p2, p3, p4, p5};

//foreach (Player item in playerList)
//{
//    Console.WriteLine(item);
//}

playerList.Remove(p3);
int i = 0;

while( i< playerList.Count)
{
    Console.WriteLine(playerList[i].ToString());
    i++;
}

bool p3Findes = playerList.Contains(p3);
Console.WriteLine(p3Findes);


