using System;

Random r = new Random();
int SecretNum = r.Next(1, 100);

void NumberPrompt(string question, int secretNum, int numOfTurns)
{
    if (numOfTurns == -1)
    {
        while (true){
        Console.WriteLine($"{question}");
        string answer = Console.ReadLine();
        int parsedAnswer = int.Parse(answer);
        if (parsedAnswer == secretNum)
        {
            Console.WriteLine("Correct Number");
            return;
        }
        else
        {
            Console.WriteLine("Wrong Number");
            Console.WriteLine($"You have infinite guesses remaining");
            if (parsedAnswer > secretNum)
            {
                Console.WriteLine("Too high");
            }
            else
            {
                Console.WriteLine("Too low");
            }
        }
    }
    }
    else
        {
            for (int i = 0; i < numOfTurns; i++)
            {
                Console.WriteLine($"{question}");
                string answer = Console.ReadLine();
                int parsedAnswer = int.Parse(answer);
                if (parsedAnswer == secretNum)
                {
                    Console.WriteLine("Correct Number");
                    return;
                }
                else
                {
                    Console.WriteLine("Wrong Number");
                    Console.WriteLine($"You have {numOfTurns - (i + 1)} guesses remaining");
                    if (parsedAnswer > secretNum)
                    {
                        Console.WriteLine("Too high");
                    }
                    else
                    {
                        Console.WriteLine("Too low");
                    }
                }
            }
        }
    }


    void DifficultySelection()
    {
        Console.WriteLine(SecretNum);
        Console.WriteLine("Select a difficulty: (Easy/Medium/Hard/Cheater)");
        string response = Console.ReadLine().ToLower();
        if (response == "easy")
        {
            NumberPrompt("Guess a Number", SecretNum, 8);
        }
        else if (response == "medium")
        {
            NumberPrompt("Guess a Number", SecretNum, 6);
        }
        else if (response == "hard")
        {
            NumberPrompt("Guess a Number", SecretNum, 4);
        }
        else if (response == "cheater")
        {
            NumberPrompt("Guess a Number", SecretNum, -1);
        }
        else
        {
            Console.WriteLine("Not a category, try again!");
        }
    }
    DifficultySelection();