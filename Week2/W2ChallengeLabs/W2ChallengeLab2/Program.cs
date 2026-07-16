string userPassword = "ThisUserPass";
string userID = "ThisUserID";
bool isLoggedIn = false;
int attemptsLeft = 4;

string attemptedPassword;
string attemptedUserID;

void attemptLogIn()
{
    if (attemptsLeft > 1)
    {
        if ((attemptedUserID != userID) || (attemptedPassword != userPassword))
        {
            attemptsLeft--;
            Console.WriteLine($"Wrong credentials, you have {attemptsLeft} attempts left");

            attemptedPassword = null;
            attemptedUserID = null;

            fetchCredentials();
        }
        else
        {
            Console.WriteLine($"Welcome, {userID}");

            isLoggedIn = true;
            attemptsLeft = 4;

            //Display Welcome Page...
        }
    }
    else
    {
        if (!isLoggedIn)
        {
            Console.WriteLine("Max attempts reached.");

            //Insert options for account recovery

            Environment.Exit(0);
        }
    }
}

void fetchCredentials()
{
    Console.WriteLine("insert user ID:");
    attemptedUserID = Console.ReadLine();
    Console.WriteLine();

    Console.WriteLine("insert user Password:");
    attemptedPassword = Console.ReadLine();
    Console.WriteLine();

    attemptLogIn();
}

void Initialize()
{
    fetchCredentials();
}

Initialize();



