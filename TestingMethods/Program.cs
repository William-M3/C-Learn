
Random dice = new Random();
int roll = dice.Next(1,7);
Console.WriteLine(roll);

// Stateful or instances methods must have their class declared as an object to access information
// stateless or static methods can be access through the className.classMethod

int firstValue = 500;
int secondValue = 600;
int largerValue = Math.Max(firstValue, secondValue);

Console.WriteLine(largerValue);
