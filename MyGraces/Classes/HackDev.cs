namespace Classes
{
    using System;
    using System.Collections.Generic;
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

            // TODO Add basic skills
            this.AddSkills(new PowerMode());
            this.AddItems(new Coffee());
        }
    }
}
