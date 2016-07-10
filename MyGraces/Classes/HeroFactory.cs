namespace Classes
{
    using System;
    using System.Collections.Generic;
    using Enumerations;
    using Interfaces;

    public class HeroFactory : IHeroFactory
    {
        public IHeroable CreateAHero(string name, HeroTypes type)
        {
            switch (type)
            {
                case HeroTypes.CozyDev: return new CozyDev(name);
                case HeroTypes.HackDev: return new HackDev(name);
                case HeroTypes.TelerikAcademyDev: return new TelerikAcademyDev(name);
                default: throw new ArgumentException("there is no such a hero type");
            }
        }
    }
}
