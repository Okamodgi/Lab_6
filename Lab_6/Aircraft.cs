public class Aircraft : Transport
{
    public override int Speed { get; set; }
    public override int LoadCapacity { get; set; }
    public override int DistanceRange { get; set; }

    public override string GetDescription()
    {
        return $"Самолет с грузоподъемностью в {LoadCapacity} может пролететь {DistanceRange}";
    }
}