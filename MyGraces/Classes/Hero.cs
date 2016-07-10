namespace Classes
{
    using System;
    using System.Collections.Generic;
    using Interfaces;
    using Classes;
    using System.Windows.Forms;
    public abstract class Hero : IHeroable
    {
        private int codingSpeed;
        private string name;

        public Hero(string name)
        {
            this.Name = name;
            this.Skills = new List<ISkillable>();
            this.Items = new List<IItemable>();
        }

        public int Energy { get; protected set; }

        public string Name
        {
            get
            {
                return this.name;
            }
            protected set
            {
                try
                {
                    this.name = value;
                    if (value.Length < 1 || value.Length > 15)
                    {
                        throw new IvalidNameException("Invalid Name: name must be between 1 and 15 charackters", 1, 15);
                    }
                }
                catch (IvalidNameException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public int Power { get; protected set; }

        public int CodingSpeed
        {
            get
            {
                return this.codingSpeed;
            }
            set
            {
                this.codingSpeed = value;
            }
        }

        public int GeTInitialCodingSpeed()
        {
           return this.Power * this.Energy;
        }

        public IList<IItemable> Items { get; protected set; }

        public List<ISkillable> Skills { get; protected set; }

        public void CalculateSkillEffect()
        {
            // TODO Change Energy, Power... Temporarely
        }

        public void CalculateItemEffect()
        {
            // TODO Change Energy, Power... permanently
        }

        public void AddItems(IItemable itemToAdd)
        {
            //TODO 
        }

        public void AddSkills(ISkillable skillToAdd)
        {
            //TODO 
            this.Skills.Add(skillToAdd);
        }
    }
}
