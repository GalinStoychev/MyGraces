namespace Classes
{
    using System;
    using Enumerations;
    using Interfaces;

    public abstract class Skill : ISkillable
    {
        public SkillType Type { get; protected set; }

        public virtual int ImproveCode(IHeroable hero)
        {
            return 0;
        }

        public virtual int TrickOpponent(IHeroable opponent)
        {
            return 0;
        }
    }
}
