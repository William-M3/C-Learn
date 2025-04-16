// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(i);
// }

// for (int i = 10; i >= 0; i--)
// {
//     Console.WriteLine(i);
// }

// for ( int i = 0; i < 10; i += 3)
// {
//     Console.WriteLine(i);
// }

// for ( int i = 0; i < 10; i++)
// {
//     Console.WriteLine(i);
//     if (i == 7) break;
// }

// string[] names = {"Alex", "Eddie", "David", "Michael"};
// for (int i = names.Length -1; i >= 0; i--)
// {
//     Console.WriteLine(names[i]);
// }

//Fizz Buzz

for ( int i = 1; i <= 100; i++)
{
    if (i % 5 == 0 && i % 3 == 0)
        Console.WriteLine("Fizzbuzz");
    else if (i % 5 == 0)
        Console.WriteLine("Buzz");
    else if (i % 3 == 0)
        Console.WriteLine("Fizz");
    else
        Console.WriteLine(i);
}