namespace Classes.Skills
{
    using Enumerations;
    using Interfaces;

    public class PowerMode : Skill, ISkillable
    {
        public PowerMode()
        {
            this.Type = SkillType.CodeImprovingSkill;
        }

        public override int ImproveCode(IHeroable hero)
        {
            return hero.Power * 2;
        }
    }
}
