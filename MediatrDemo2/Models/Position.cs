namespace MediatrDemo2.Models
{
    public record Position
    {
        public Security Security { get; init; }
        public int Nominal { get; init; }
        public double CostValueQc { get; init; }
    }
}