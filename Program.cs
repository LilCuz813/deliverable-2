
bool runProgram = true;

while (runProgram == true)
{
    Console.WriteLine("Hello. Welcome to our buffet. All you can eat for $9.99. We only charge extra for wine. How many people are in you group? Please parties of 6 or lower.");
    int people = int.Parse(Console.ReadLine());

    if (people > 6)
    {

    }
    else
    {
        runProgram = false;
    }

    Console.WriteLine("A table for " + people ,"! Please follow me and take a seat. Lets get started with some drinks. We've got wine and juice.");

    int drinkWine = people * 4;
    int drinkJuice = people * 2;
    double buffetFood = people * 9.99;

    for (int i = 0; i < people; i++)
    {
        Console.Write("Guest" + i + "Would you like juice or wine? Please respond with W, for wine and J for juice.");
    }
    string choice = Console.ReadLine();
    if (choice == "wine")
    {
        drinkWine++;
        Console.WriteLine(choice + "Great Choice!");
    }
    else if (choice == "juice")
    {
        drinkJuice++;
        Console.WriteLine(choice + "Great Choice!");
    }
    else 
    {
        Console.WriteLine("Invalid response. Please try again.");
    }

    Console.WriteLine("Person 2, wine or juice?");

    if (choice == "wine")
    {
        drinkWine++;
        Console.WriteLine(choice + "Great Choice!");
    }
    else if (choice == "juice")
    {
        drinkJuice++;
        Console.WriteLine(choice + "Great Choice!");
    }
    else
    {
        Console.WriteLine("Invalid response. Please try again.");
    }

    Console.WriteLine("Person 3, wine or juice?");

    if (choice == "wine")
    {
        drinkWine++;
        Console.WriteLine(choice + "Great Choice!");
    }
    else if (choice == "juice")
    {
        drinkJuice++;
        Console.WriteLine(choice + "Great Choice!");
    }
    else
    {
        Console.WriteLine("Invalid response. Please try again.");
    }

    Console.WriteLine("Person 4, wine or juice?");

    if (choice == "wine")
    {
        drinkWine++;
        Console.WriteLine(choice + "Great Choice!");
    }
    else if (choice == "juice")
    {
        drinkJuice++;
        Console.WriteLine(choice + "Great Choice!");
    }
    else
    {
        Console.WriteLine("Invalid response. Please try again.");
    }

    Console.WriteLine("Person 5, wine or juice?");

    if (choice == "wine")
    {
        drinkWine++;
        Console.WriteLine(choice + "Great Choice!");
    }
    else if (choice == "juice")
    {
        drinkJuice++;
        Console.WriteLine(choice + "Great Choice!");
    }
    else
    {
        Console.WriteLine("Invalid response. Please try again.");
    }

    Console.WriteLine("Person 6, wine or juice?");

    if (choice == "wine")
    {
        drinkWine++;
        Console.WriteLine(choice + "Great Choice!");
    }
    else if (choice == "juice")
    {
        drinkJuice++;
        Console.WriteLine(choice + "Great Choice!");
    }
    else
    {
        Console.WriteLine("Invalid response. Please try again.");
    }
    double billM = drinkWine + drinkJuice + buffetFood;



}
