namespace Classes.Skills
{
    using Enumerations;
    using Interfaces;

    public class DecreaseOpponentEnergy : Skill, ISkillable
    {
        public DecreaseOpponentEnergy()
        {
            this.Type = SkillType.TrickingSkill;
        }

        public override int TrickOpponent(IHeroable opponent)
        {
            return opponent.Energy - 10;
        }
    }
}
