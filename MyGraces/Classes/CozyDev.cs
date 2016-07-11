namespace Classes
{
    using System;
    using System.Collections.Generic;
    using Interfaces;
    using Skills;
    using Items;

    public class CozyDev : Hero, IHeroable, ICommentable
    {
        public CozyDev(string name)
            : base(name)
        {
            this.Energy = 11;
            this.Power = 10;

            this.AddSkills(new Mesmerize());
            this.AddItems(new ExternalKeyboard());
        }

        public string MakeAComment()
        {
            return "Viva la revolucion";
        }
    }
}
