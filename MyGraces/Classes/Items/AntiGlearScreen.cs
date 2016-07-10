namespace Classes.Items
{
    using Interfaces;

    public class AntiGlearScreen : Item, IItemable
    {
        public AntiGlearScreen()
        {
            this.Name = "Anti Glear Screen";
            this.PowerBonus = 7;
        }
    }
}
