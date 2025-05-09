﻿
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] orderIDs = orderStream.Split(",");
Array.Sort(orderIDs);

foreach (string orderID in orderIDs)
{
    if (orderID.Length == 4)
        Console.WriteLine(orderID);
    else
        Console.WriteLine($"{orderID}\t - Error");
}

// string pangram = "The quick brown fox jumps over the lazy dog";
// string[] pangramWords = pangram.Split(" ");

// for(int i = 0; i < pangramWords.Length; i++)
// {
//     char[] letterArray = pangramWords[i].ToCharArray();
//     Array.Reverse(letterArray);
//     pangramWords[i] = new string(letterArray);
// }

// pangram = String.Join(" ", pangramWords);
// Console.WriteLine(pangram);

// string value = "abc123";
// char[] valueArray = value.ToCharArray();
// Array.Reverse(valueArray);
// //string result = new string(valueArray);
// string result = String.Join(",", valueArray);
// Console.WriteLine(result);
// string[] items = result.Split(',');
// foreach (string item in items)
// {
//     Console.WriteLine(item);
// }

// string[] pallets = [ "B14", "A11", "B12", "A13"];
// Console.WriteLine("");

// Array.Clear(pallets, 0, 2);
// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Array.Resize(ref pallets, 6);
// Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

// pallets[4] = "C01";
// pallets[5] = "C02";

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Array.Resize(ref pallets, 3);
// Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }


// Console.WriteLine("Sorted...");
// Array.Sort(pallets);
// foreach(var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Console.WriteLine("Reversed...");
// Array.Reverse(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }