namespace Classes
{
    using System;
    using System.Collections.Generic;
    using Interfaces;
    using Skills;

    public class TelerikAcademyDev : Hero, IHeroable
    {
        public TelerikAcademyDev(string name)
            : base(name)
        {
            this.Energy = 20;
            this.Power = 20;

            // TODO Add basic skills
            this.AddSkills(new DecreaseOpponentEnergy());
        }
    }
}
