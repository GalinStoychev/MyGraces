namespace Classes.Items
{
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
    }
}
