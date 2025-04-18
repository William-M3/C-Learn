
// int heroHealth = 10;
// int monsterHealth = 10;

// Random attack = new Random();
// int attackDamage;


// do
// {
//     attackDamage = attack.Next(1, 11);
//     monsterHealth -= attackDamage;
//     Console.WriteLine($"Monster lost {attackDamage} health. Monster Health is {monsterHealth}");

//     if (monsterHealth > 0)
//     {
//         attackDamage = attack.Next(1,11);
//         heroHealth -= attackDamage;
//         Console.WriteLine($"Hero lost {attackDamage} health. Hero health is {heroHealth}");
//     }

// } while (heroHealth > 0 && monsterHealth > 0);


// string? readResult;
// Console.WriteLine("Please enter a number between 5 and 10:");
// bool notvaildEntry = true;
// int number;

// do
// {
//     readResult = Console.ReadLine();
//     int.TryParse(readResult, out number );

//     if (number >= 5 && number <= 10)
//         notvaildEntry = false;
//     else
//         Console.WriteLine("Sorry, you entered the wrong number.");
// }while(notvaildEntry);

// Console.WriteLine("User input was accepted.");

// Console.WriteLine("Please enter Administrator, Manager, or User:");
// string? readResult;
// bool vaildAnswer = false;
// do 
// {
//     readResult = Console.ReadLine();
//     if (readResult != null)
//         readResult = readResult.Trim().ToLower();

//     if (readResult == "administrator" || readResult == "manager" || readResult == "user")
//     {
//         vaildAnswer = true;
//     } 
//     else
//     {
//         Console.WriteLine("Please enter a valid answer");
//     }

// }while (!vaildAnswer);

// Console.WriteLine($"{readResult} has been accepted.");

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad. ", "I like all three of the menu choices" };
int periodLocation;
for(int index = 0; index < myStrings.Length; index++)
{
    periodLocation = myStrings[index].IndexOf(".");
    if (periodLocation != -1)
    {
        while (periodLocation != -1)
        {
            Console.WriteLine(myStrings[index].Substring(0,periodLocation));
            myStrings[index]= myStrings[index].Remove(0, periodLocation).TrimStart('.').TrimStart(' ');
            periodLocation = myStrings[index].IndexOf(".");
        }
    }
    else
    {
        Console.WriteLine(myStrings[index]);
    }
}