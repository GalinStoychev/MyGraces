using Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classes;
using Classes.Skills;

namespace MyGracesApp
{
    public partial class SkillsAndItemsChoice : Form
    {
        public SkillsAndItemsChoice(string PlayerOneName, string PlayerTwoName)
        {
            InitializeComponent();
            POneName.Text = PlayerOneName;
            PTwoName.Text = PlayerTwoName;
        }

        public Engine NewEngine { get; set; }

        private void ReadyButtonPOne_Click(object sender, EventArgs e)
        {
            List<ISkillable> skillList = new List<ISkillable>();
            AssignSkills(this.NewEngine.AvailableHeroes[0], SkillListPOne);
            // TODO TrickSKills
            // TODO ItemList
        }

        // TODO PlayerTwo assign SKills and Items
        private void ReadyButtonPTwo_Click(object sender, EventArgs e)
        {
            List<ISkillable> skillList = new List<ISkillable>();
            AssignSkills(this.NewEngine.AvailableHeroes[1], SkillListPTwo);
            // TODO TrickSKills
            // TODO ItemList
        }

        private void AssignSkills(IHeroable hero, CheckedListBox skillList)
        {
            for (int i = 0; i < skillList.Items.Count; i++)
            {
                if (skillList.GetItemChecked(i))
                {
                    ISkillable skillToAdd = GetSkills(skillList.Text);
                    hero.AddSkills(skillToAdd);
                }
            }
        }

        private ISkillable GetSkills(string skillToFind)
        {
            switch (skillToFind)
            {
                case "Decrease Opponent Energy": return new DecreaseOpponentEnergy();
                case "Mesmerize": return new Mesmerize();
                case "Power Mode": return new PowerMode();
                default: throw new ArgumentException();
            }
        }



        private void NextButton_Click(object sender, EventArgs e)
        {
            MainForm next = new MainForm();
            next.NewEngine = this.NewEngine;
            this.Hide();
            next.Show();
        }

        
    }
}
