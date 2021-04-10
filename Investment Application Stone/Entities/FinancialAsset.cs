using System;

namespace Investment_Application.Entities
{
    class FinancialAsset
    {
        public string AssetName { get; set; }
        public double AssetValue { get; set; }
        public int AssetAmount { get; set; }
        public DateTime Date { get; set; }
        public FinancialAsset()
        {

        }
        public FinancialAsset(string name, double valuePerAsset, int assetAmount, DateTime date)
        {
            AssetName = name;
            AssetValue = valuePerAsset;
            AssetAmount = assetAmount;
            Date = date;
        }

        public double TotalValue()
        {
            return AssetValue * AssetAmount;
        }
    }
}
