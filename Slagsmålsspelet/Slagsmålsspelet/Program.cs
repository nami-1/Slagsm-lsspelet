int heroHp = 100;
int villianHp = 100;
Random generator = new Random();

string player1 = "Hero";
string player2 = "Villian"; 





while (heroHp > 0 && villianHp > 0){
Console.WriteLine("Beginning of the round !");
Console.WriteLine($"{player1} has {heroHp} health  {player2} has {villianHp} ");

int herodamage = generator.Next(20);
villianHp -= herodamage;
villianHp = Math.Max(0, villianHp);
Console.WriteLine($"{player1} has done {herodamage} damage to {player2}");


int villiandamage = generator.Next(20);
heroHp -= villiandamage;
heroHp = Math.Max(0, heroHp);
Console.WriteLine($"{player2} has done {villiandamage} damage to {player1}");

Console.WriteLine("PRESS ANY KEY TO CONTINUE TO THE GAME!");
Console.ReadKey();
}


Console.WriteLine("The round is over!");

if (heroHp == 0 && villianHp == 0) {
    Console.WriteLine("No winner! Its a draw!");
}

else if (villianHp == 0){
    Console.WriteLine($"The {player1} has won!");
}

else {
    Console.WriteLine($"The {player2} has won!");
}

Console.WriteLine("Press any key to end the game");
Console.ReadKey();
Console.ReadLine();





//if (hitRoll > 95){
  //  Console.WriteLine("Crit!");
//}

//else if (hitRoll > 40) {
  //  Console.WriteLine("Hit");
//}

//else {
  //  Console.WriteLine("Miss!");
//}


