using System;
using System.Globalization;
using Investment_Application.Entities;

namespace Investment_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to investment application!!!");
            Console.WriteLine("User Name:");
            string user = Console.ReadLine();
            Portfolio userPortfolio = new Portfolio(user);
            bool showPortfolio = true;
            while (showPortfolio)
            {
                Console.WriteLine();
                Console.WriteLine("Add New Finance Asset in your portfolio -> 1");
                Console.WriteLine("See portfolio -> 2");
                Console.WriteLine("Sell Finance Asset -> 3");
                Console.WriteLine("See Portfolio Resume -> 4");
                Console.WriteLine("See month resume");
                Console.WriteLine("Stop Application -> 6");
                int option = int.Parse(Console.ReadLine());

                if (option == 1)
                {
                    Console.WriteLine("Asset Name:");
                    string assetName = Console.ReadLine();
                    Console.WriteLine("Asset Value:");
                    double assetValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine("Asset Amount:");
                    int assetAmount = int.Parse(Console.ReadLine());
                    Console.WriteLine("Date:");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    FinancialAsset newAsset = new FinancialAsset(assetName, assetValue, assetAmount, date);
                    userPortfolio.NewAsset(newAsset);
                }
                if (option == 2)
                {
                    foreach (FinancialAsset asset in userPortfolio.FinancialAssets)
                    {
                        Console.WriteLine(
                            "Name: " + asset.AssetName +
                            " Value: " + asset.AssetValue +
                            " Amount: " + asset.AssetAmount +
                            " TotalValue: " + asset.TotalValue() +
                            " Date: " + asset.Date);

                    }
                }
                if (option == 3)
                {
                    Console.WriteLine("Asset Name:");
                    string assetName = Console.ReadLine();
                    Console.WriteLine("Asset Amount:");
                    int assetAmount = int.Parse(Console.ReadLine());
                    userPortfolio.SellAsset(assetName, assetAmount);
                }
                if (option == 4)
                {
                    double portfolioValue = userPortfolio.PortfolioValue();
                    Console.WriteLine("Portfolio Value: " + portfolioValue);
                }
                if (option == 5)
                {
                    Console.WriteLine("Month: ");
                    int month = int.Parse(Console.ReadLine());
                    Console.WriteLine("Year:");
                    int year = int.Parse(Console.ReadLine());
                    double monthValue = userPortfolio.PortfolioValueByDate(month, year);
                    Console.WriteLine("Month Value: " + monthValue);
                }
                if (option == 6)
                {
                    showPortfolio = false;
                }
            }
        }
    }
}
