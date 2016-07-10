namespace MyGracesApp
{
    using System;
    using System.ComponentModel;
    using System.Windows.Forms;
    using Classes;
    using Enumerations;

    public partial class InitializeTheBeginnig : Form
    {
        public InitializeTheBeginnig()
        {
            InitializeComponent();
            this.NewEngine = new Engine();
        }

        public Engine NewEngine { get; }

        // Button Exit
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you really want to exit?", "Exit", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        // Add heroes
        public void StartEngine()
        {
            // Add Hero One
            string firstHeroName = this.POneName.Text;
            string selectedHeroPlayerOne = this.comboBox_PlayerOne.Text;
            HeroTypes heroTypePlayerOne = GetHeroType(selectedHeroPlayerOne);
            this.NewEngine.AddHero(firstHeroName, heroTypePlayerOne);

            // Add Hero Two
            string secondHeroName = this.PTwoName.Text;
            string selectedHeroPlayerTwo = this.comboBox_PlayerTwo.Text;
            HeroTypes heroTypePlayerTwo = GetHeroType(selectedHeroPlayerTwo);
            this.NewEngine.AddHero(secondHeroName, heroTypePlayerTwo);
        }

        // Hero types
        private HeroTypes GetHeroType(string selectedHero)
        {
            switch (selectedHero)
            {
                case "Hack Dev": return HeroTypes.HackDev;
                case "Cozy Dev": return HeroTypes.CozyDev;
                case "Teleric Academy Dev": return HeroTypes.TelerikAcademyDev;
                default: throw new ArgumentException("There is no such a hero type");
            }
        }

        // Go to next form
        private void NextForm_Click(object sender, EventArgs e)
        {
            StartEngine();
            SkillsAndItemsChoice next = new SkillsAndItemsChoice(this.POneName.Text, this.PTwoName.Text);
            next.NewEngine = this.NewEngine;
            this.Hide();
            next.Show();
        }
    }
}
