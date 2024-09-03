namespace DesignPatterns_Implementations_API.Creational.FactoryMethod.Models;

public class AirShipping : ShippingBase
{
    public override decimal CalculateShippingCost()
    {
        // TODO: Soome logic here

        return Weight * 0.12m;
    }

    public override void Ship()
    {
       // TODO: Some ship logic here
       
       Console.WriteLine("Some Air shipping happening here");
    }
}