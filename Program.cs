using cs_jogo_de_rpg.src.Entities;

Knight hero1 = new Knight("Arus", 15, "Knight");

Wizard hero2 = new Wizard("Jennica", 20, "White Wizard");

Ninja hero3 = new Ninja("Zeck", 37, "Ninja");

Console.WriteLine(hero2.ToString());
Console.WriteLine(hero2.Attack(4));
Console.WriteLine(hero2.Attack(12));

Console.ReadLine();
