namespace Classes
{
    using System;
    using System.Collections.Generic;
    using Interfaces;
    using Skills;

    public class HackDev : Hero, IHeroable
    {
        public HackDev(string name)
          : base(name)
        {
            this.Energy = 7;
            this.Power = 20;

            // TODO Add basic skills
            this.AddSkills(new PowerMode());
        }
    }
}
