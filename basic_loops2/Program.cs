
//METHODS
void ExitApplication()
{
    Console.WriteLine("Hit any key to exit the application");
    Console.ReadKey();
    Environment.Exit(0);
}



void AcessKeyRequest(int acessKey)
{
    int acessKeyAttempts;
    acessKeyAttempts = 0;
    bool openVault;

    do
    {
        Console.WriteLine("please enter a passkey to get into the vault");
       int userInputForAcessKey;
        userInputForAcessKey = int.Parse(Console.ReadLine());
        
        if (userInputForAcessKey!= acessKey)
        {
            Console.WriteLine("wrong acess code please try again");
            acessKeyAttempts++;
            openVault = false;
        }
        else
        {
            openVault = true;
            
        }
        if (acessKeyAttempts >= 5)
        {
            Console.WriteLine("You tried too many times sorry please try again at a later time.");
            openVault = false;
            ExitApplication();
        }
    } while (!openVault);
    Console.WriteLine("Welcome to the vault please enjoy yourself!");
}










//MAIN OBJECTIVE FOR ACCESSKEY USING DO WHILE LOOP STORED IN A METHOD

AcessKeyRequest(13579);








// OPTIONAL STRETCH RETURN TRUE FOR CORRECT ACCESS KEY AND FALSE FOR INCORRECT AND EXCEEDED MAXIMUM ATTEMPTS
int acessKeyAttempts;
acessKeyAttempts = 0;
bool openVault;
int acessKey = 13579;

do
{
    Console.WriteLine("Please enter a passkey to get into the vault");
    int userInputForAcessKey;
    userInputForAcessKey = int.Parse(Console.ReadLine());
    if (userInputForAcessKey != acessKey)
    {
        acessKeyAttempts++;
        openVault = false;
        Console.WriteLine(openVault);
    }
    else
    {
        openVault = true;
        Console.WriteLine(openVault);

    }
    if (acessKeyAttempts >= 5)
    {
        Console.WriteLine("You tried too many times sorry please try again at a later time.");
        Console.WriteLine(openVault);
        openVault = false;
        ExitApplication();
    }

} while (!openVault);
