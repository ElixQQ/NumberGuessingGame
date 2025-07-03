Random rnd = new Random();

int min;
    while (true) {

        Console.Write("Minimum number: ");
        string minInput = Console.ReadLine();

        if (int.TryParse(minInput, out min)) {
            break;
        }else {
            Console.WriteLine("Invalid input! Please try just numbers.");
    }
}

int max;
    while (true) {

        Console.Write("Maximum number: ");
        string maxInput = Console.ReadLine();

        if (int.TryParse(maxInput, out max)) {
            break;
        }else{
            Console.WriteLine("Invalid input! Please try just numbers.");
        }
    }
Console.WriteLine("");

string input;
    while (true) {

    int number = rnd.Next(min, max);

    Console.WriteLine("Is your number bigger than: " + number);

    input = Console.ReadLine().ToLower();

    if (input == "yes") {
        min = number + 1;
    }else if (input == "no") {
        max = number;
    }else if (input == "equal" || input == "done") {
        Console.WriteLine("I did it! Your nummber: " + number);
        break;
    }else{
        Console.WriteLine("Please just 'yes', 'no' or 'equal'");
    }if (min >= max) {
        Console.WriteLine("The possible range is exhausted. Did you maybe make a mistake?");
        break;
    }
}
