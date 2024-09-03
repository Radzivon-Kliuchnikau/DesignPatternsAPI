namespace DesignPatterns_Implementations_API.Creational.FactoryMethod.Models;

public class GroundShipping : ShippingBase
{
    public override decimal CalculateShippingCost()
    {
        // TODO: Define some logic here

        return Weight * 0.05m;
    }

    public override void Ship()
    {
        // TODO: Some "ship" logic should be implemented here. Something with DB?
        
        Console.WriteLine("Some Ground shipping executed there");
    }
}