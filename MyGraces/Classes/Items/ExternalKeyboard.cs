namespace Classes.Items
{
    using System;
    using Interfaces;

    public class ExternalKeyboard : Item, IItemable
    {
        public ExternalKeyboard()
        {
            this.Name = "External Keyboard";
            this.EnergyBonus = 5;
        }
    }
}
