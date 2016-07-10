using Enumerations;

namespace Interfaces
{
    public interface ISkillable
    {
        SkillType Type { get; }

         int ImproveCode(IHeroable hero);

         int TrickOpponent(IHeroable opponent);
    }
}
