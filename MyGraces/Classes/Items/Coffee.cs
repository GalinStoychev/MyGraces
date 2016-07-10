namespace Classes.Items
{
    using System;
    using Interfaces;

    public class Coffee : Item, IItemable
    {
        public Coffee()
        {
            this.Name = "Coffee";
            this.EnergyBonus = 10;
        }
    }
}
