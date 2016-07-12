namespace MyGracesApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Windows.Forms;
    using Classes;
    using Classes.Skills;
    using Classes.Items;
    using Interfaces;

    public partial class SkillsAndItemsChoice : Form
    {
        public SkillsAndItemsChoice(string PlayerOneName, string PlayerTwoName)
        {
            InitializeComponent();
            POneName.Text = PlayerOneName;
            PTwoName.Text = PlayerTwoName;
        }

        public Engine NewEngine { get; set; }

        // Assign skill and items
        private void ReadyButtonPOne_Click(object sender, EventArgs e)
        {
            List<ISkillable> skillList = new List<ISkillable>();
            AssignSkills(this.NewEngine.AvailableHeroes[0], this.SkillListPOne);
            AddItems(this.NewEngine.AvailableHeroes[0], this.ItemListPOne);
        }

        private void ReadyButtonPTwo_Click(object sender, EventArgs e)
        {
            List<ISkillable> skillList = new List<ISkillable>();
            AssignSkills(this.NewEngine.AvailableHeroes[1], this.SkillListPTwo);
            AddItems(this.NewEngine.AvailableHeroes[1], this.ItemListPTwo);

        }

        private void AddItems(IHeroable hero, CheckedListBox itemList)
        {
            for (int i = 0; i < itemList.Items.Count; i++)
            {
                if (itemList.GetItemChecked(i))
                {
                    var item = itemList.Items[i];
                    IItemable itemToAdd = GetItems(item.ToString());
                    hero.AddItems(itemToAdd);
                }
            }
        }

        private void AssignSkills(IHeroable hero, CheckedListBox skillList)
        {
            for (int i = 0; i < skillList.Items.Count; i++)
            {
                if (skillList.GetItemChecked(i))
                {
                    var item = skillList.Items[i];
                    ISkillable skillToAdd = GetSkills(item.ToString());
                    hero.AddSkills(skillToAdd);
                }
            }
        }

        private IItemable GetItems(string itemToAdd)
        {
            switch (itemToAdd)
            {
                case "Anti Glear Screen": return new AntiGlearScreen();
                case "Coffee": return new Coffee();
                case "External Keyboard": return new ExternalKeyboard();
                case "Mouse": return new Mouse();
                default: throw new ArgumentException("There is not such an item");
            }
        }

        private ISkillable GetSkills(string skillToFind)
        {
            switch (skillToFind)
            {
                case "Decrease Opponent Energy": return new DecreaseOpponentEnergy();
                case "Mesmerize": return new Mesmerize();
                case "Power Mode": return new PowerMode();
                case "Energy Mode": return new EnergyMode();
                default: throw new ArgumentException("There is not such a skill");
            }
        }

        // Go to next form
        private void NextButton_Click(object sender, EventArgs e)
        {
            MainForm next = new MainForm(POneName.Text, PTwoName.Text);
            next.NewEngine = this.NewEngine;
            this.Hide();
            next.Show();
        }
    }
}
