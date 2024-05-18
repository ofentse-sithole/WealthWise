using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WealthWise
{
    public class Advice
    {

        //User will be given advices on how to take care of their fiancials

        public static void GetAdvice()
        {
            int option = int.Parse(Console.ReadLine());

            Console.WriteLine("Please be adviced that we can help you finaincially. Please choose an option below: ");
            Console.WriteLine("1. Get advice on how to save money");
            Console.WriteLine("2. Get advice on how to invest money");
            Console.WriteLine("3. Get advice on how to spend money");

            //how to save money
            if (option == 1)
            {
                Console.WriteLine("Make a Budget: Track your income and expenses. " +
                    "Set clear spending limits for different categories. " +
                    "A budget helps you prioritize saving and avoid overspending2." + "\n" + "\n" +

                    "Avoid Impulse Purchases: When you feel the urge to buy something, pause and " +
                    "consider if it’s a necessity. Avoiding impulsive spending can " +
                    "significantly boost your savings1.");

            }
            //how to invest money
            else if (option == 2)
            {
                Console.WriteLine("Flexible Savings Accounts and Money Market Funds: " +
                    "Flexible savings accounts let you deposit and withdraw funds while earning interest. " +
                    "Money market funds aim for higher yields than regular savings accounts1." + "\n" + "\n" +

                    "Stockbroking Account for Stocks: Invest directly in individual stocks listed on the stock " +
                    "exchange. Research companies and choose wisely1.");

            }

            //how to spend money
            else if (option == 3)
            {
                Console.WriteLine("Create a Budget: Track your income and expenses to understand your financial situation. " +
                    "Organize purchases by category (food, clothing, entertainment, etc.). Set monthly limits for each" +
                    " category within your income1." + "\n" + "\n" +

                    "Plan Purchases in Advance: Avoid spur-of-the-moment decisions. Write down what you need to buy while " +
                    "you’re calm and at home. Compare prices and decide before your actual shopping trip1.");

            }
        }
    }
}
