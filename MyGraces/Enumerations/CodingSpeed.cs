namespace Enumerations
{
    public struct CodingSpeed
    {
        public CodingSpeed(int power, int energy)
        {
            this.Coding_Speed = (power + energy) / 10;
        }

        int Coding_Speed { get; set; }
    }
}
