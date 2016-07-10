namespace Classes
{
    using Interfaces;
    using Skills;
    using Items;

    public class HackDev : Hero, IHeroable
    {
        public HackDev(string name)
          : base(name)
        {
            this.Energy = 3;
            this.Power = 18;

            this.AddSkills(new PowerMode());
            this.AddItems(new Coffee());
        }
    }
}
