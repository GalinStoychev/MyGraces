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
using Enumerations;

namespace MyGracesApp
{
    public partial class InitializeTheBeginnig : Form
    {
        public InitializeTheBeginnig()
        {
            InitializeComponent();
            this.NewEngine = new Engine();
        }

        public Engine NewEngine { get; }

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

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you really want to exit ?", "Exit", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    // MessageBox.Show(this.FirstHeroNameTBox.Text);

        //}

        private void NextForm_Click(object sender, EventArgs e)
        {
            StartEngine();
            SkillsAndItemsChoice next = new SkillsAndItemsChoice(this.FirstHeroNameTBox.Text);
            next.NewEngine = this.NewEngine;
            this.Hide();
            next.Show();
           // MessageBox.Show(this.newEngine.HerosList[0]);
        }

        public void StartEngine()
        {
            // Add Hero One
            string firstHeroName = this.FirstHeroNameTBox.Text;
            string selectedHeroPlayerOne = this.comboBox_PlayerOne.Text;
            HeroTypes heroTypePlayerOne = GetHeroType(selectedHeroPlayerOne);
            this.NewEngine.AddHero(firstHeroName, heroTypePlayerOne);

            // Add Hero Two
            string secondHeroName = this.SecondHeroNameTBox.Text;
            string selectedHeroPlayerTwo = this.comboBox_PlayerTwo.Text;
            HeroTypes heroTypePlayerTwo = GetHeroType(selectedHeroPlayerTwo);
            this.NewEngine.AddHero(secondHeroName, heroTypePlayerTwo);
        }
    }
}
