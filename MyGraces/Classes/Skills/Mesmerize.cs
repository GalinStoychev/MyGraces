namespace Classes.Skills
{
    using Interfaces;
    using Enumerations;

   public class Mesmerize : Skill, ISkillable
    {
        public Mesmerize()
        {
            this.Type = SkillType.TrickingSkill;
        }

        public override int TrickOpponent(IHeroable opponent)
        {
            return opponent.Energy;
        }
    }
}
