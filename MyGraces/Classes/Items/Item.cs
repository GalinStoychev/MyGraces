namespace Classes.Items
{
    using System.Text;
    using Interfaces;

    public abstract class Item : IItemable
    {
        public Item()
        {
            this.PowerBonus = 0;
            this.EnergyBonus = 0;
        }

        public string Name { get; protected set; }

        public int EnergyBonus { get; protected set; }

        public int PowerBonus { get; protected set; }

        public override string ToString()
        {
            return string.Format("{0}\nEnergy Bonus: {1}\nPower Bonus: {2}", this.Name, this.EnergyBonus, this.PowerBonus);
        }
    }
}
