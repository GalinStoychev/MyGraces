namespace Classes
{
    using System;
    using System.Collections.Generic;
    using Interfaces;
    using Classes;
    using Classes.Items;

    using System.Windows.Forms;
    using Enumerations;
    using System.Text;
    public abstract class Hero : IHeroable
    {
        private int codingSpeed;
        private string name;
        private int power;
        private int energy;

        public Hero(string name)
        {
            this.Name = name;
            this.Skills = new List<ISkillable>();
            this.Items = new List<IItemable>();
        }

        public int Energy
        {
            get
            {
                int energyBonus = 0;
                foreach (var item in this.Items)
                {
                    energyBonus += item.EnergyBonus;
                }
                return this.energy + energyBonus;
            }
            protected set
            {
                this.energy = value;
            }
        }

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
                    if (value.Length <= 1 || value.Length > 15)
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

        public int Power
        {
            get
            {
                int powerBonus = 0;
                foreach (var item in this.Items)
                {
                    powerBonus += item.PowerBonus;
                }
                return this.power + powerBonus;
            }
            protected set
            {
                this.power = value;
            }
        }

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
            return (this.Power * this.Energy) / 10;
        }

        public IList<IItemable> Items { get; protected set; }

        public List<ISkillable> Skills { get; protected set; }

        //public void CalculateSkillEffect()
        //{
        //    // TODO Change Energy, Power... Temporarely
        //}

        //public void CalculateItemEffect()
        //{
        //    // TODO Change Energy, Power... permanently
        //}

        public void AddItems(IItemable itemToAdd)
        {
            this.Items.Add(itemToAdd);
        }

        public void AddSkills(ISkillable skillToAdd)
        {
            this.Skills.Add(skillToAdd);
        }

        public string ShowAllItems()
        {
            var allItems = new StringBuilder();
            foreach (var item in this.Items)
            {
                allItems.AppendLine(item.ToString());
            }

            return allItems.ToString();
        }
    }
}
