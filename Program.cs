bool runProgram = true;

while (runProgram == true)
{
    Console.WriteLine("Hello. Welcome to our buffet. All you can eat for $9.99. We only charge extra for wine. How many people are in you group");
    int people = int.Parse(Console.ReadLine());

    if (people > 6)
    {

    }
    else
    {
        runProgram = false;
    }

    Console.WriteLine("A table for  ! Please follow me and take a seat. Lets get started with some drinks. We've got wine and juice.");
    
    int drinkWine = 4;
    int drinkJuice = 2;
    double buffetFood = 9.99;
   
    Console.WriteLine("Person 1, wine or juice?");

    string choice = Console.ReadLine();
    if (choice == "wine" || choice == "juice") {
        Console.WriteLine(choice + "Great Choice!"); 
    } else {
        Console.WriteLine("Invaild input. Please try again.");
    }
    Console.WriteLine("Person 2, wine or juice?");
    
    if (choice == "wine" || choice == "juice")
    {
        Console.WriteLine(choice + "Great Choice!");
    }
    else
    {
        Console.WriteLine("Invaild input. Please try again.");
    }
    Console.WriteLine("Person 3, wine or juice?");
    
    if (choice == "wine" || choice == "juice")
    {
        Console.WriteLine(choice + "Great Choice!");
    }
    else
    {
        Console.WriteLine("Invaild input. Please try again.");
    }
    Console.WriteLine("Person 4, wine or juice?");
    
    if (choice == "wine" || choice == "juice")
    {
        Console.WriteLine(choice + "Great Choice!");
    }
    else
    {
        Console.WriteLine("Invaild input. Please try again.");
    }
    Console.WriteLine("Person 5, wine or juice?");
    
    if (choice == "wine" || choice == "juice")
    {
        Console.WriteLine(choice + "Great Choice!");
    }
    else
    {
        Console.WriteLine("Invaild input. Please try again.");
    }
    Console.WriteLine("Person 6, wine or juice?");
   
    if (choice == "wine" || choice == "juice")
    {
        Console.WriteLine(choice + "Great Choice!");
    }
    else
    {
        Console.WriteLine("Invaild input. Please try again.");
    }

    double billM = drinkWine + drinkJuice + buffetFood;


}




