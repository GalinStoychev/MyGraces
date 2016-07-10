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
            this.Energy = 10;
            this.Power = 10;

            // TODO Add basic skills
            this.AddSkills(new Mesmerize());
            this.AddItems(new ExternalKeyboard());
        }

        public string MakeAComment()
        {
            return "Viva la revolucion";
        }
    }
}
