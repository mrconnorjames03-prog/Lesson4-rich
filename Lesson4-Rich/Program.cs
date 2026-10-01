//using System.Globalization;

//Console.WriteLine("Enter your quiz score");

//// use an int variable to read & store the user's input
//int quizScore = int.Parse(Console.ReadLine());

//// initialize bonus to none

//string bonus = "None";
//if(quizScore > 1000)
//{// This only executes if true
//    bonus = "Double Points";
//}

//Console.WriteLine($"Bonus: {bonus}");

Console.WriteLine("Enter your score for round 1");
int round1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter your score for round 2");
int round2 = int.Parse(Console.ReadLine());

if (round2 > round1)
{
    Console.WriteLine("Woah you rocked my tits!!!");
}
else if (round1 > round2)
{
    Console.WriteLine("You suck big dick");
    if(round2 < 50)
    {
        Console.WriteLine("Try the level again bitch");
    }
}
else
{
    Console.WriteLine("damn you're still as a statue");
}
if (round1 > 80 && round2 > 80)
{
    Console.WriteLine("You've made the leaderboard motherfucker!");
}

