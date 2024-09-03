namespace DesignPatterns_Implementations_API.Creational.FactoryMethod.Models;

public class SeaShipping : ShippingBase
{
    public override decimal CalculateShippingCost()
    {
        // TODO: Some logic here

        return Weight * 0.08m;
    }

    public override void Ship()
    {
        // TODO: Some logic here
        
        Console.WriteLine("Some Sea shipping happening here");
    }
}