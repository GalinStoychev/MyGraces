namespace Enumerations
{

    public struct Stats
    {
        public Stats(int power, int energy, int codingSpeed)
        {
            this.Power = power;
            this.Energy = energy;
            this.CodingSpeed = codingSpeed;
        }

        public int Power { get; private set; }
        public int Energy { get; private set; }
        public int CodingSpeed { get; private set; }

        public override string ToString()
        {
            return string.Format("{0}\n{1}\n{2}", this.Power, this.Energy, this.CodingSpeed);
        }
    }
}
