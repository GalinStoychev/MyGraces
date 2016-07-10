namespace Interfaces
{
    using Enumerations;

    public interface IHeroFactory
    {
        IHeroable CreateAHero(string name, HeroTypes type);
    }
}
