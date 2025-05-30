// the ourAnimals array will store the following: 
using System.Reflection.PortableExecutable;

string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";

// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 6];

// TODO: Convert the if-elseif-else construct to a switch statement

// create some initial ourAnimals array entries
for (int i = 0; i < maxPets; i++)
{

    switch (i)
    {
        case 0:
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
            break;
        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "loki";
            break;
        case 2:
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "friendly";
            animalNickname = "Puss";
            break;
        case 3:
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "?";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;
        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;
    }
    ;

    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
}

do
{
    // display the top-level menu options

    Console.Clear();

    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
    Console.WriteLine(" 1. List all of our current pet information");
    Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
    Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
    Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
    Console.WriteLine(" 5. Edit an animal’s age");
    Console.WriteLine(" 6. Edit an animal’s personality description");
    Console.WriteLine(" 7. Display all cats with a specified characteristic");
    Console.WriteLine(" 8. Display all dogs with a specified characteristic");
    Console.WriteLine();
    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

    readResult = Console.ReadLine();
    if (readResult != null)
    {
        menuSelection = readResult.ToLower();
    }

    // Console.WriteLine($"You selected menu option {menuSelection}.");
    // Console.WriteLine("Press the Enter key to continue");

    // pause code execution
    // readResult = Console.ReadLine();

    switch (menuSelection)
    {
        case "1":
            // List all current pet information

            for (int pet = 0; pet < maxPets; pet++)
            {
                if (ourAnimals[pet, 0] != "ID #: ")
                {
                    Console.WriteLine();
                    for (int attribute = 0; attribute < 6; attribute++)
                    {
                        Console.WriteLine(ourAnimals[pet, attribute]);
                    }
                }
            }

            Console.WriteLine("Press the Enter key to continue");
            readResult = Console.ReadLine();
            break;
        case "2":
            // Add a new animal friend to the ourAnimals array

            string anotherPet = "y";
            int petCount = 0;

            for (int pet = 0; pet < maxPets; pet++)
            {

                if (ourAnimals[pet, 0] != "ID #: ")
                {
                    petCount += 1;
                }
            }

            if (petCount < maxPets)
            {
                Console.WriteLine($"We currently have {petCount} pets that need homes. We can manage {(maxPets - petCount)} more.");
            }


            while (anotherPet == "y" && petCount < maxPets)
            {
                bool validEntry = false;
                do
                {
                    Console.WriteLine("\n\rEnter 'dog' or 'cat' to begin a new entry");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalSpecies = readResult.ToLower();
                    }
                    if (animalSpecies != "dog" && animalSpecies != "cat")
                    {
                        validEntry = false;
                    }
                    else
                    {
                        validEntry = true;
                    }
                } while (validEntry == false);

                animalID = animalSpecies.Substring(0, 1) + (petCount + 1).ToString();

                do
                {
                    int petAge;

                    Console.WriteLine("Enter the pet's age or enter ? if unknown");
                    readResult = Console.ReadLine();

                    if (readResult != null)
                    {
                        animalAge = readResult;
                    }

                    if (animalAge != "?")
                    {
                        validEntry = int.TryParse(animalAge, out petAge);
                    }
                    else
                    {
                        validEntry = true;
                    }
                } while (validEntry == false);

                do
                {
                    Console.WriteLine("Enter a physical description of the pet (size, color, gender, weight, housebroken)");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalPhysicalDescription = readResult.ToLower();

                        if (animalPhysicalDescription == "")
                        {
                            animalPhysicalDescription = "tbd";
                        }
                    }
                } while (animalPhysicalDescription == "");

                do
                {
                    Console.WriteLine("Enter a description of the pet's personality (likes or dislikes, tricks, energy level)");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalPersonalityDescription = readResult.ToLower();

                        if (animalPersonalityDescription == "")
                        {
                            animalPersonalityDescription = "tbd";
                        }
                    }
                } while (animalPersonalityDescription == "");

                do
                {
                    Console.WriteLine("Enter a nickname for the pet");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalNickname = readResult.ToLower();
                        if (animalNickname == "")
                        {
                            animalNickname = "tbd";
                        }
                    }
                } while (animalNickname == "");

                ourAnimals[petCount, 0] = "ID #: " + animalID;
                ourAnimals[petCount, 1] = "Species: " + animalSpecies;
                ourAnimals[petCount, 2] = "Age: " + animalAge;
                ourAnimals[petCount, 3] = "Nickname: " + animalNickname;
                ourAnimals[petCount, 4] = "Physical description: " + animalPhysicalDescription;
                ourAnimals[petCount, 5] = "Personality: " + animalPersonalityDescription;

                petCount += 1;
                if (petCount < maxPets)
                {
                    Console.WriteLine("Do you want to enter info for another pet (y/n)");
                    do
                    {
                        readResult = Console.ReadLine();
                        if (readResult != null)
                        {
                            anotherPet = readResult.ToLower();
                        }
                    } while (anotherPet != "y" && anotherPet != "n");
                }
            }

            if (petCount >= maxPets)
            {
                Console.WriteLine("We have reached our limit on the number of pets that we can manage.");
                Console.WriteLine("Press the Enter key to continue");
                readResult = Console.ReadLine();
            }

            break;
        case "3":

            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    if (ourAnimals[i, 2] == "Age: ")
                    {
                        bool validEntry = false;
                        int petAge = 0;
                        do
                        {
                            Console.WriteLine($"For {ourAnimals[i, 0]} please add an age or ? for unknown:");
                            readResult = Console.ReadLine();
                            if (readResult != null)
                            {
                                if (readResult != "?")
                                {
                                    validEntry = int.TryParse(readResult, out petAge);
                                }
                                else
                                {
                                    validEntry = false;
                                }
                                if (validEntry == false)
                                {
                                    Console.WriteLine("Please enter a vaild number.");
                                }

                            }
                        } while (validEntry == false);
                        ourAnimals[i, 2] = "Age: " + petAge;
                    }

                    if (ourAnimals[i, 4] == "Physical description: ")
                    {
                        do
                        {
                            Console.WriteLine($"Please enter a Physical description for {ourAnimals[i, 0]}:");
                            readResult = Console.ReadLine();
                            if (readResult != null)
                            {
                                if (readResult.Length != 0)
                                {
                                    ourAnimals[i, 4] = "Physical description: " + readResult;
                                }
                            }

                        } while (ourAnimals[i, 4] == "Physical description: ");
                    }
                }
            }

            Console.WriteLine("All information is up to date.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        case "4":

            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    if (ourAnimals[i, 3] == "Nickname: ")
                    {
                        do
                        {
                            Console.WriteLine($"For {ourAnimals[i, 0]}, please enter a nickname: ");
                            readResult = Console.ReadLine();
                            if (readResult != null)
                            {
                                if (readResult.Length != 0)
                                {
                                    ourAnimals[i, 3] = "Nickname: " + readResult;
                                }
                            }
                        } while (ourAnimals[i, 3] == "Nickname: ");
                    }

                    if (ourAnimals[i, 5] == "Personality: ")
                    {
                        do
                        {
                            Console.WriteLine($"For {ourAnimals[i, 0]}, Please enter the personality:");
                            readResult = Console.ReadLine();
                            if (readResult != null)
                            {
                                if (readResult.Length != 0)
                                {
                                    ourAnimals[i, 5] = "Personality: " + readResult;
                                }
                            }
                        } while (ourAnimals[i, 5] == "Personality: ");
                    }
                }
            }

            Console.WriteLine("All animal information up to date.");
            Console.WriteLine("Press the Enter Key to continue.");
            readResult = Console.ReadLine();
            break;
        case "5":
            break;
        case "6":
            break;
        case "7":
            break;
        case "8":
            break;
        default:
            break;
    }


} while (menuSelection != "exit");
