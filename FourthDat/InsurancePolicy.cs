using System;

abstract class InsurancePolicy
{
    public int PolicyNo { get; init; }
    public string Name { get; set; }

    private double premium;

    public double Premium
    {
        get { return premium; }
        set 
        {
            if (value >= 0)
            {
                premium = value;
            }
            else
            {
                Console.WriteLine("Premium must be greater than zero");
            }
            
        }
    }

    public virtual double CalculatePremium()
    {
        return Premium;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Insurance Policy");
    }
}

class LifeInsurance : InsurancePolicy
{
    public const double LifeInsuranceCharge = 500;

    public override double CalculatePremium()
    {
        return Premium + LifeInsuranceCharge;
    }

    public new void DisplayInfo()
    {
        Console.WriteLine("Life Insurance Policy");
    }
}

class HealthInsurance : InsurancePolicy
{
    public const double HealthInsuranceCharge = 1000;

    public sealed override double CalculatePremium()
    {
        return Premium + HealthInsuranceCharge;
    }
}
