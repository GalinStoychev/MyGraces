namespace Classes.Items
{
    using Interfaces;

    public class Mouse : Item, IItemable
    {
        public Mouse()
        {
            this.Name = "Mouse";
            this.PowerBonus = 6;
        }
    }
}
