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
    IDictionary<CommodityCategory,double> _taxRates{get;}
    
}