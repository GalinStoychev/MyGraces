namespace MyGracesApp
{
    using System;
    using System.ComponentModel;
    using System.Windows.Forms;
    using Classes;
    using Interfaces;
    using Enumerations;

    public partial class MainForm : Form
    {
        private const int MaxLines = 1000;
        private Random generator = new Random();

        public MainForm(string PlayerOneName, string PlayerTwoName)
        {
            InitializeComponent();
            POneName.Text = PlayerOneName;
            PTwoName.Text = PlayerTwoName;
            this.PlayerOnePBar.Maximum = MaxLines;
            this.PlayerTwoPBar.Maximum = MaxLines;
        }

        public Engine NewEngine { get; set; }

        private void StartCoding()
        {
            IHeroable playerOne = this.NewEngine.AvailableHeroes[0];
            IHeroable playerTwo = this.NewEngine.AvailableHeroes[1];

            // get intial coding speed
            playerOne.CodingSpeed = playerOne.GeTInitialCodingSpeed();
            playerTwo.CodingSpeed = playerTwo.GeTInitialCodingSpeed();

            // apply skills
            ISkillable randomSkillOne = GetSkill(playerOne);
            ApplySkill(playerOne, playerTwo, randomSkillOne);

            ISkillable randomSkillTwo = GetSkill(playerTwo);
            ApplySkill(playerTwo, playerOne, randomSkillTwo);

            // print skills
            PrintRandomSkill(randomSkillOne, this.PlayerTwoUsedSKillLabel);
            PrintRandomSkill(randomSkillTwo, this.PlayerOneUsedSKillLabel);

            // print current Coding speed
            PlayerOneCodingSpeed.Text = "+" + playerOne.CodingSpeed.ToString() + " lines";
            PlayerTwoCodingSpeed.Text = "+" + playerTwo.CodingSpeed.ToString() + " lines";

            // print comments
            MakeAComment(playerOne, this.PlayerOneComment);
            MakeAComment(playerTwo, this.PlayerTwoComment);

            // Print items
            PlayerOneItemLabel.Text = playerOne.ShowAllItems();
            PlayerTwoItemLabel.Text = playerTwo.ShowAllItems();

            // check for end of game
            CheckForEndOfGame(playerOne, playerTwo);
        }

        private void MakeAComment(IHeroable hero, Label label)
        {
            if (hero is TelerikAcademyDev)
            {
                TelerikAcademyDev developer = hero as TelerikAcademyDev;
                label.Text = developer.MakeAComment();
            }
            else if (hero is CozyDev)
            {
                CozyDev developer = hero as CozyDev;
                label.Text = developer.MakeAComment();
            }
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

            if (increasedProgressBarPlayerOne >= MaxLines && increasedProgressBarPlayerTwo >= MaxLines)
            {
                this.PlayerOnePBar.Value = MaxLines;
                this.PlayerTwoPBar.Value = MaxLines;
                MessageBox.Show("Draw");
            }
            else if (increasedProgressBarPlayerTwo >= MaxLines)
            {
                this.PlayerTwoPBar.Value = MaxLines;
                MessageBox.Show(string.Format("Winner is {0}", this.NewEngine.AvailableHeroes[1].Name));
            }
            else if (increasedProgressBarPlayerOne > MaxLines)
            {
                this.PlayerOnePBar.Value = MaxLines;
                MessageBox.Show(string.Format("Winner is {0}", this.NewEngine.AvailableHeroes[0].Name));
            }
            else
            {
                this.PlayerOnePBar.Value += playerOne.CodingSpeed;
                this.PlayerTwoPBar.Value += playerTwo.CodingSpeed;
            }
        }

        private void FightButton_Click(object sender, EventArgs e)
        {
            StartCoding();
        }
    }
}
