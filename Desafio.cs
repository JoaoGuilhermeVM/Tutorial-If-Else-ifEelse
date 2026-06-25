//Desafio do curso para fazer sozinho
//https://learn.microsoft.com/en-us/training/modules/csharp-if-elseif-else/4-exercise-challenge-apply-business-rules

Random random = new();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration > 0)
{
	Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration == 1)
{
	Console.WriteLine($"Your subscription expires within a day!\nRenew now and save 20%!");
}
else if (daysUntilExpiration == 5)
{
	Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\nRenew now and save 10 % !");
}
else if (daysUntilExpiration == 10)
{
	Console.WriteLine("Your subscription will expire soon. Please renew it.");
}