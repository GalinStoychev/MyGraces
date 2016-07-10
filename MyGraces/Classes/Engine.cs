namespace Classes
{
    using Enumerations;
    using Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Engine
    {
        private IHeroFactory factory;

        public Engine()
        {
            this.factory = new HeroFactory();
            //   this.HerosList = new List<string>();
        }

        public IList<IHeroable> AvailableHeroes = new List<IHeroable>();


        // Adding Heroes
        public void AddHero(string name, HeroTypes type)
        {
            var hero = this.factory.CreateAHero(name, type);
            this.AvailableHeroes.Add(hero);
        }
        // Adding Skills

        public void AddSkill(ISkillable skillToAdd, IHeroable hero)
        {
            hero.AddSkills(skillToAdd);
        }

        // Adding Items


        // Get Hero by Name
        public IHeroable GetHeroByName(string name)
        {
           return this.AvailableHeroes.FirstOrDefault(x => x.Name == name);
        }
    }
}
