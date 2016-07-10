namespace Classes
{
    using System;
    using System.Collections.Generic;
    using Interfaces;
    using Skills;
    using Items;

    public class TelerikAcademyDev : Hero, IHeroable, ICommentable
    {
        public TelerikAcademyDev(string name)
            : base(name)
        {
            this.Energy = 15;
            this.Power = 9;

            // TODO Add basic skills
            this.AddSkills(new DecreaseOpponentEnergy());
            this.AddItems(new Mouse());
        }

        public string MakeAComment()
        {
            return "Work Work Work...";
        }
    }
}
