do
{
    Console.WriteLine("What's your pre-tax salary");

    int preTaxSalary = int.Parse(Console.ReadLine());

    if (preTaxSalary <= 14200)
    {
        double netSalary = preTaxSalary - 0.10 * preTaxSalary;
        Console.WriteLine($"Your monthly net salary is {netSalary/12}.");
    }

    else if (preTaxSalary >= 14201 && preTaxSalary <= 54200)
    {
        double netSalary = preTaxSalary - 0.12 * (preTaxSalary - 14200) - 1420;
        Console.WriteLine($"Your monthly net salary is {netSalary/12}.");
    }

    else if (preTaxSalary >= 54201 && preTaxSalary <= 86350)
    {
        double netSalary = preTaxSalary - 0.22 * (preTaxSalary-54200) - 6220 -54;
        Console.WriteLine($"Your monthly net salary is {netSalary/12}.");
    }

    else if (preTaxSalary >= 86351 && preTaxSalary <= 164900)
    {
        double netSalary = preTaxSalary - 0.24 * (preTaxSalary-86350) - 13293;
        Console.WriteLine($"Your monthly net salary is {netSalary/12}.");
    }

    else if (preTaxSalary >= 164901 && preTaxSalary <= 209400)
    {
        double netSalary = preTaxSalary - 0.32 * (preTaxSalary-164901) - 32145;
        Console.WriteLine($"Your monthly net salary is {netSalary/12}.");
    }

    else if (preTaxSalary >= 209401 && preTaxSalary <= 523600)
    {
        double netSalary = preTaxSalary - 0.35 * (preTaxSalary-209400) - 46385;
        Console.WriteLine($"Your monthly net salary is {netSalary/12}.");
    }

    else if (preTaxSalary >= 523601)
    {
        double netSalary = preTaxSalary - 0.37 * (preTaxSalary-523601) - 156355;
        Console.WriteLine($"Your monthly net salary is {netSalary/12}.");
    }

    Console.WriteLine("Would you like to try again? y/n");

    var answer = Console.ReadLine();

    if (answer == "y")
    {
        continue;
    }
    else
    {
        break;
    }
}
while (true);