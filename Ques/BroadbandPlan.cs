public interface IBroadbandPlan
{
    public int GetBroadbandPlanAmount();
}

class Black : IBroadbandPlan
{

    private readonly bool _isSubscriptionValid;
    private readonly int _discountPercentage;

    private int PlanAmount=3000;

    public Black(bool isSubscriptionValid,int discountPercentage)
    {
        this._isSubscriptionValid=isSubscriptionValid;
        if(discountPercentage<0 || discountPercentage > 50)
        {
            throw new  ArgumentOutOfRangeException(nameof(discountPercentage));
        }
        else
        {
            this._discountPercentage=discountPercentage;
        }
        
    }
    public int GetBroadbandPlanAmount()
    {
        
        if (this._isSubscriptionValid)
        {
            int discountned=PlanAmount-(PlanAmount*this._discountPercentage/100);
            return discountned;
        }
        else
        {
            return PlanAmount;
        }
        
    }
}

class Gold : IBroadbandPlan
{
    private readonly bool _isSubscriptionValid;
    private readonly int _discountPercentage;

    private int PlanAmount=1500;
    public Gold(bool isSubscriptionValid,int discountPercentage)
    {
        this._isSubscriptionValid=isSubscriptionValid;
        if(discountPercentage<0 || discountPercentage > 30)
        {
            throw new ArgumentOutOfRangeException(nameof(discountPercentage));
        }
        else
        {
            this._discountPercentage=discountPercentage;
        }
    }
    public int GetBroadbandPlanAmount()
    {
        if (this._isSubscriptionValid)
        {
            int discounted=PlanAmount-(PlanAmount*this._discountPercentage/100);
            return discounted;
        }
        else
        {
            return PlanAmount;
        }
    }
}
class SubscribePlan
{
    private readonly IList<IBroadbandPlan> _broadbandPlans;

    public SubscribePlan (IList<IBroadbandPlan> broadbandPlans)
    {
        this._broadbandPlans=broadbandPlans;
    }

    public IList<Tuple<string,int>> GetSubscriptionPlan()
    {
        IList<Tuple<string,int>> broadbandPlans=new List<Tuple<string,int>>();
        foreach(var plan in this._broadbandPlans)
        {
            broadbandPlans.Add(new Tuple<string,int>(plan.GetType().Name,plan.GetBroadbandPlanAmount()));
        }
        return broadbandPlans;
    }
    
}