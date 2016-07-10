using Enumerations;
using System;
using System.Collections.Generic;

namespace Interfaces
{
    public interface IHeroFactory
    {
        IHeroable CreateAHero(string name, HeroTypes type);
    }
}
