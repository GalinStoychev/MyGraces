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
using Interfaces;

namespace MyGracesApp
{
    public partial class MainForm : Form
    {
        private Random generator = new Random();

        public MainForm()
        {
            InitializeComponent();
            this.PlayerOnePBar.Maximum = 1500;
            this.PlayerTwoPBar.Maximum = 1500;
        }

        public Engine NewEngine { get; set; }

        private void StartFight()
        {
            IHeroable playerOne = this.NewEngine.AvailableHeroes[0];
            IHeroable playerTwo = this.NewEngine.AvailableHeroes[1];
            playerOne.CodingSpeed = playerOne.GeTInitialCodingSpeed();
            playerTwo.CodingSpeed = playerTwo.GeTInitialCodingSpeed();


            ISkillable randomSkillOne = GetSkill(playerOne);
            ApplySkill(playerOne, playerTwo, randomSkillOne);
            PrintRandomSkill(randomSkillOne, this.PlayerTwoUsedSKillLabel);

            ISkillable randomSkillTwo = GetSkill(playerTwo);
            ApplySkill(playerTwo, playerOne, randomSkillTwo);
            PrintRandomSkill(randomSkillTwo, this.PlayerOneUsedSKillLabel);


            CheckForEndOfGame(playerOne, playerTwo);
        }

        private ISkillable GetSkill(IHeroable hero)
        {
            int randomSkillPlayer = generator.Next(0, hero.Skills.Count);
            return hero.Skills[randomSkillPlayer];
        }

        private void ApplySkill(IHeroable heroInTurn, IHeroable heroNotInTurn, ISkillable randomSkill)
        {
            int skillEffect = 0;

            if (randomSkill.Type.ToString() == "CodeImprovingSkill")
            {
                skillEffect = randomSkill.ImproveCode(heroInTurn);
                heroInTurn.CodingSpeed += skillEffect;
            }
            else if (randomSkill.Type.ToString() == "TrickingSkill")
            {
                skillEffect = randomSkill.TrickOpponent(heroNotInTurn);
                heroNotInTurn.CodingSpeed -= skillEffect;
            }
        }

        private void PrintRandomSkill(ISkillable randomSkill, Label lable)
        {
            string usedSkill = randomSkill.ToString().Split('.')[2];
            lable.Text = usedSkill.ToString();
        }

        private void CheckForEndOfGame(IHeroable playerOne, IHeroable playerTwo)
        {
            int increasedProgressBarPlayerOne = this.PlayerOnePBar.Value + playerOne.CodingSpeed;
            int increasedProgressBarPlayerTwo = this.PlayerTwoPBar.Value + playerTwo.CodingSpeed;

            if (increasedProgressBarPlayerOne > 1500 && increasedProgressBarPlayerTwo > 1500)
            {
                this.PlayerOnePBar.Value = 1500;
                this.PlayerTwoPBar.Value = 1500;
                MessageBox.Show("Draw");
            }
            else if (increasedProgressBarPlayerOne > 1500)
            {
                MessageBox.Show("Winner is Player Two");
                this.PlayerTwoPBar.Value = 1500;
            }
            else if (increasedProgressBarPlayerTwo > 1500)
            {
                MessageBox.Show("Winner is Player One");
                this.PlayerOnePBar.Value = 1500;
            }
            else
            {
                this.PlayerOnePBar.Value += playerOne.CodingSpeed;
                this.PlayerTwoPBar.Value += playerTwo.CodingSpeed;
            }
        }

        private void FightButton_Click(object sender, EventArgs e)
        {
            StartFight();
        }
    }
}
