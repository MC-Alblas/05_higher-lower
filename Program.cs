Console.WriteLine("Welcome to the guessing game! Press enter to play");
Console.ReadLine();

int RNG() {
    Random random = new Random();
    return random.Next(1, 100);
}

int num = RNG();
Console.WriteLine("I've picked a number between 1 and 100. Can you guess it? You have 7 attempts.");
// Console.WriteLine(num + "is the answer. This is given as a debug feature");
int i = 6;
int j = 1;

do {
    int response = Convert.ToInt32(Console.ReadLine());

    if (response > num && response < 100) {
        Console.WriteLine("lower");
        Console.WriteLine($"{i} turns left");
    }
    
    else if (response < num && response > 0) {
        Console.WriteLine("higher");
        Console.WriteLine($"{i} turns left");
    }

    else if (response == num) {
        Console.WriteLine($"You guessed it! The number was {num}. You guessed it with {i} turns remaining.");
        j = j + 10;
    }

    else {
        Console.WriteLine("Only between 1 and 100");
        Console.WriteLine($"{i} turns left");
    }

    i--;
    j++;
}
while(j < 8);

if (j == 8) {
    Console.WriteLine($"Looks like you ran out of turns. The number was {num}");
}

Console.WriteLine("Press enter to close");
Console.ReadLine();

// Martijn Alblas