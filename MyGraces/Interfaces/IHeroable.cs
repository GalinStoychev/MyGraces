using System;
using System.Collections.Generic;
using System.Linq;
namespace Interfaces
{
    public interface IHeroable
    {
        string Name { get; }
        int Energy { get; }
        int Power { get; }
        int CodingSpeed { get; set; }
        List<ISkillable> Skills { get; }
        IList<IItemable> Items { get; }

        int GeTInitialCodingSpeed();
        void AddSkills(ISkillable skill);
        void AddItems(IItemable item);
        string ShowAllItems();
    }
}
