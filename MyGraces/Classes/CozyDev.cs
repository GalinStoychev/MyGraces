﻿namespace Classes
{
    using System;
    using System.Collections.Generic;
    using Interfaces;
    using Skills;

    public class CozyDev : Hero, IHeroable
    {
        public CozyDev(string name)
            : base(name)
        {
            this.Energy = 10;
            this.Power = 10;

            // TODO Add basic skills
            this.AddSkills(new Mesmerize());
        }
    }
}
