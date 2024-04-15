public class Car : Transport
{
    public override int Speed { get; set; }
    public override int LoadCapacity { get; set; }
    public override int DistanceRange { get; set; }

    public override string GetDescription()
    {
        return $"Машина с грузоподъемностью в {LoadCapacity} может проехать {DistanceRange}";
    }


}