public class Ship : Transport
{
    public override int Speed { get; set; }
    public override int LoadCapacity { get; set; }
    public override int DistanceRange { get; set; }

    public override string GetDescription()
    {
        return $"Корабль с грузоподъемностью в {LoadCapacity} может проплыть {DistanceRange}";
    }
}