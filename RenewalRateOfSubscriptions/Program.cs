using System.Formats.Asn1;

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// Your code goes here



if (daysUntilExpiration <= 10)
{
    if (daysUntilExpiration <= 5)
    {
        if (daysUntilExpiration <= 1)
        {
            if (daysUntilExpiration == 0)
            {
                Console.WriteLine("Your subscription has expired");
            }
            else
            {
                Console.WriteLine("Your subscription expires within a day!");
                discountPercentage = 20;
                Console.WriteLine($"Renew now and save 20%!");
            }
        }
        else
        {
            Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
            discountPercentage = 10;
            Console.WriteLine($"Renew now and save {discountPercentage}%!");
        }
    }
    else
    {
    Console.WriteLine("Your subscription will expire soon. Renew now!");
    }
}