


//METHODS

void ExitApplication()
{
    Console.WriteLine("Hit any key to exit the application");
    Console.ReadKey();
    Environment.Exit(0);
}

void PauseApplication()
{
    Console.WriteLine("Hit any key to continue");
    Console.ReadKey();
}

bool BreakLoop()
{
    Console.WriteLine("Would you like to try again? please enter Yes or Y");
    string tryAgain = Console.ReadLine();
    

    if (tryAgain.ToLower() != "yes" && tryAgain.ToLower() != "y")

    {
        Console.WriteLine("Goodbye!");
        return false;
    }
    else
    {
        return true;
    }
}




//HELLO WORLD LOOP
while (true)
{
    Console.WriteLine("Hello World!");
    bool continueOrEndLoop = BreakLoop();
    if(!continueOrEndLoop)
    {
        break;
    }
}


// USER INPUT COUNTING LOOP
while (true)
{
    Console.WriteLine("Please enter a number to count up to.");
    int numberGoal = int.Parse(Console.ReadLine());

    for ( int i = 0; i <= numberGoal;i++)
    {
        Console.WriteLine(i);

    }

    Console.WriteLine("We will start counting down now");

    PauseApplication();

    for (int i = numberGoal; i >= 0; i--)
    {
        Console.WriteLine(i);
    }
    bool continueOrEndLoop = BreakLoop();
    if (!continueOrEndLoop)
    {
        break;
    }
}






// ACESSKEY LOOP WITHOUT MAX AMOUNT OF ATTEMPTS

while (true)

{
    Console.WriteLine("please enter a passkey to get into the vault");
    string acessKeyAttempt;
    acessKeyAttempt = Console.ReadLine();
    if (acessKeyAttempt == "13579")
    {
        Console.WriteLine("welcome to the vault please enjoy your time here");
        break;
    }
    else
    {
        
        Console.WriteLine("you have entered the wrong key please try again");  
    }
}


//ACESSKEY LOOP WITH MAX AMOUNT OF ATTEMPTS

while (true)
{ 
    int maxAttempts = 5;
    int acessKeyAttempts = 0;
    for (int i = 0; i< maxAttempts; i++)
    {
        Console.WriteLine("please enter a passkey to get into the vault");
        string userInputForAcessKey;
        userInputForAcessKey = Console.ReadLine();


            if (userInputForAcessKey != "13579")
            {
            acessKeyAttempts++;
            Console.WriteLine("you have entered the wrong key please try again");
            }
            else
            {
            
            break;  
            }
        
        if( acessKeyAttempts > 5)
        {
            Console.WriteLine("you tried too many times please try again later");
            ExitApplication();
        }
    }
    Console.WriteLine("welcome to the vault please enjoy your time here");
    bool continueOrEndLoop = BreakLoop();
    if (!continueOrEndLoop)
    {
        break;
    }
}



