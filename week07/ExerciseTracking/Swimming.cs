public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int lengthInMinutes, int laps) : base(date, lengthInMinutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000.0 * 0.62;
    }

    public override double GetSpeed()
    {
        double distance = GetDistance();
        return distance / GetLengthInMinutes() * 60;
    }

    public override double GetPace()
    {
        double distance = GetDistance();
        return GetLengthInMinutes() / distance;
    }
}