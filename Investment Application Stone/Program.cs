using System;
using System.Globalization;
using Investment_Application.Entities;

namespace Investment_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your investment application!!!");
            Portfolio userPortfolio = new Portfolio();
            bool showPortfolioOptions = true;
            while (showPortfolioOptions)
            {
                Console.WriteLine();
                userPortfolio.ShowOptions();
                Console.WriteLine();
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
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
                        break;

                    case 2:
                        foreach (FinancialAsset asset in userPortfolio.FinancialAssets)
                        {
                            Console.WriteLine(
                                "Name: " + asset.AssetName +
                                " Value: " + asset.AssetValue +
                                " Amount: " + asset.AssetAmount +
                                " TotalValue: " + asset.TotalValue() +
                                " Date: " + asset.Date);

                        }
                        break;

                    case 3:
                        Console.WriteLine("Asset Name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Asset Amount:");
                        int amount = int.Parse(Console.ReadLine());
                        userPortfolio.SellAsset(name, amount);
                        break;

                    case 4:
                        double portfolioValue = userPortfolio.PortfolioValue();
                        Console.WriteLine("Portfolio Value: " + portfolioValue);
                        break;

                    case 5:
                        Console.WriteLine("Month: ");
                        int month = int.Parse(Console.ReadLine());
                        Console.WriteLine("Year:");
                        int year = int.Parse(Console.ReadLine());
                        double monthValue = userPortfolio.PortfolioValueByDate(month, year);
                        Console.WriteLine("Month Value: " + monthValue);
                        break;

                    case 6:
                        showPortfolioOptions = false;
                        break;

                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }

            }
        }
    }
}
