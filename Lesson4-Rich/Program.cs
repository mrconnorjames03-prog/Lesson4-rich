Console.WriteLine("Enter your quiz score");

// use an int variable to read & store the user's input
int quizScore = int.Parse(Console.ReadLine());

// initialize bonus to none

string bonus = "None";
if(quizScore > 1000)
{// This only executes if true
    bonus = "Double Points";
}

Console.WriteLine($"Bonus: {bonus}");