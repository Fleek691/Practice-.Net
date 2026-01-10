public enum CommodityCategory
{
    Furniture,
    Grocery,
    Service
}
class Commodity
{
    public CommodityCategory Category{get;set;}
    public int CommodityQuantity{get;set;}
    public string CommodityName{get;set;}
    public double CommodityPrice{get;set;}
    public Commodity(CommodityCategory category,string commodityName,int commodityQuantity, double commodityPrice)
    {
        this.Category=category;
        this.CommodityName=commodityName;
        this.CommodityPrice=commodityPrice;
        this.CommodityQuantity=commodityQuantity;
    }
}

class PrepareBill
{
    private readonly IDictionary<CommodityCategory,double> _taxRates;
    public PrepareBill(IDictionary<CommodityCategory,double> TaxRates)
    {
        this._taxRates=TaxRates;
    }
    public void SetTaxrates(CommodityCategory category, double TaxRates)
    {
        if (this._taxRates.ContainsKey(category))
        {
            this._taxRates[category]=TaxRates;
        }
        else
        {
            this._taxRates.Add(category,TaxRates);
        }
    }

    public double CalculateBillAMount(IList<Commodity> items)
    {
        double billAmount=0;
        foreach(var item in items)
        {
            if (this._taxRates.ContainsKey(item.Category))
            {
                double baseAmount=item.CommodityPrice*item.CommodityQuantity;
                double tax=baseAmount*this._taxRates[item.Category]/100;
                billAmount=billAmount+(baseAmount+tax);
            }
            else
            {
                throw new ArgumentException(nameof(item));
            }
        }
        return billAmount;
        
    }
}