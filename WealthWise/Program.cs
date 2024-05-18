using WealthWise;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hi, Welcome to Wealth Wise where we help you to make a wise decision in being healthy");

        Console.WriteLine("\n");

        Console.WriteLine("*******************************");
        Console.WriteLine("\n");

        Console.WriteLine("Please choose whether you want to"  + 
            "\n"+ "option 1: calculate your expenses " +
            "\n" + "option 2: get advice on how to take care of your finances " +
            "\n" + "option 3: Check if you close on reaching your goal: ");

        int user = int.Parse(Console.ReadLine());

        for (int i = 0; i < 2; i++)
        {
            if (user == 1)
            {
                //Expenses
                Expenses();

            }
            else if (user == 2)
            {
                //Advice
                Advice.GetAdvice();
            }
            else if (user == 3)
            {
                //Goal
                goal();
            }
            else
            {
                Console.WriteLine("Invalid option");
            }

            break;
        }
        

    }

    public static void Expenses()
    {
        int salary, rent, food, transport, utilities, other, total;

        int subtotal;
        

        Console.WriteLine("Please enter your salary: ");
        salary = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter your rent: ");
        rent = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter your food expenses: ");
        food = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter your transport expenses: ");
        transport = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter your utilities expenses: ");
        utilities = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter your other expenses: ");
        other = int.Parse(Console.ReadLine());

        subtotal = rent + food + transport + utilities + other;

        total = salary - subtotal;

        Console.WriteLine("The total amount spent on expenses is: " + subtotal);
        Console.WriteLine("\n");
        Console.WriteLine("The total amount left from the salary is : " + total);

    }

    private static void goal()
    {
        int save, goal;

        Console.WriteLine("How much have you save?");
        save = int.Parse(Console.ReadLine());

        Console.WriteLine("What is your goal amount?");
        goal=  int.Parse(Console.ReadLine());

        if (save < goal)
        {
            Console.WriteLine("You are not far from your goal");
        }
        else
        {
            Console.WriteLine("You have reached your goal");
        }
    }
}