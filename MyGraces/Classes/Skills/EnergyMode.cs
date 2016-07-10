namespace Classes.Skills
{
    using Enumerations;
    using Interfaces;

   public class EnergyMode : Skill, ISkillable
    {
        public EnergyMode()
        {
            this.Type = SkillType.CodeImprovingSkill;
        }

        public override int ImproveCode(IHeroable hero)
        {
            return hero.Energy;
        }
    }
}
