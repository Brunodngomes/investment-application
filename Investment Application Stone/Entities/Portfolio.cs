using System.Collections.Generic;

namespace Investment_Application.Entities
{
    class Portfolio
    {
        public string User { get; set; }
        public List<FinancialAsset> FinancialAssets { get; set; } = new List<FinancialAsset>();
        public Portfolio()
        {

        }
        public Portfolio(string user)
        {
            User = user;
        }

        public void NewAsset(FinancialAsset asset)
        {
            FinancialAssets.Add(asset);
        }

        public void SellAsset(string assetName, int assetAmount)
        {
            foreach (FinancialAsset asset in FinancialAssets)
            {
                if (asset.AssetName == assetName && asset.AssetAmount >= assetAmount)
                {
                    asset.AssetAmount -= assetAmount;
                    if (asset.AssetAmount == 0)
                    {
                        FinancialAssets.Remove(asset);
                    }
                    return;
                }
            }

            return;
        }

        public double PortfolioValue()
        {
            double sum = 0;
            foreach (FinancialAsset asset in FinancialAssets)
            {
                sum += asset.TotalValue();
            }
            return sum;
        }

        public double PortfolioValueByDate(int month, int year)
        {
            double sum = 0;
            foreach (FinancialAsset asset in FinancialAssets)
            {
                if (asset.Date.Month == month && asset.Date.Year == year)
                {
                    sum += asset.TotalValue();
                }
            }
            return sum;
        }
    }
}
