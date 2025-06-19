using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Business_Mayhem
{
    public partial class GameScreen : UserControl
    {
        public static double totalCash = 0;
        static public int oneSecond = 50;
        //Lemonade Times
        static public float lemonadeTime = 23;
        static public float lemonadeLoadBarLength = 1;

        //FastFood times
        static public float fastFoodTime = 10;
        static public float fastFoodLoadBarLength = 1;

        //Rugby times
        static public float rugbyTime = 3;
        static public float rugbyLoadBarLength = 1;

        //Lemonade Vars
        static public double lemonadeProfit = 12472456;
        static public double lemonadeeUpgrade = 10;
        static public double lemonLevel = 1;
        static public bool lemonadeLoad = false;

        //Fast Food Vars
        static public double fastFoodProfit = 250;
        static public double fastFoodUpgrade = 5000;
        static public double fastFoodLevel = 0;
        static public bool hasFastFood = false;
        static public bool fastFoodLoad = false;

        //Rugby Team Vars
        static public double rugbyProfit = 1000;
        static public double rugbyUpgrade = 100000;
        static public double rugbyLevel = 0;
        static public bool hasRugby = false;
        static public bool rugbyLoad = false;

        Brush whiteBrush = new SolidBrush(Color.White);



        public GameScreen()
        {
            InitializeComponent();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            //Resets all labels
            cashLabel.Text = $"{totalCash.ToString("C")}";
            lemonadeMoneyLabel.Text = $"{lemonadeProfit.ToString("C")}";
            lemonadeUpgradeButton.Text = $"Upgrade for {lemonadeeUpgrade.ToString("C")}";
            lemonadeStandLevelLabel.Text = $"{lemonLevel}";

            fastFoodLevelLabel.Text = $"{fastFoodLevel}";
            if (hasFastFood == true) // Only run if fast food is unlocked
            {
                fastFoodUpgradeButton.Text = $"Upgrade for {fastFoodUpgrade.ToString("C")}";
                fastFoodMoneyLabel.Text = $"{fastFoodProfit.ToString("C")}";
            }

            rugbyTeamLevelLabel.Text = $"{rugbyLevel}";
            if (hasRugby == true) // Only run if rugby is unlocked
            {
                rugbyTeamUpgradeButton.Text = $"Upgrade for {rugbyUpgrade.ToString("C")}";
                rugbyTeamMoneyLabel.Text = $"{rugbyProfit.ToString("C")}";
            }

            //Checks if lemonade button was clicked
            if (lemonadeLoad == true) // Increases loading bar 
            {
                if (lemonadeLoadBarLength <= 200)
                {
                    lemonadeTime = oneSecond * lemonadeTime;
                    lemonadeTime = 200 / lemonadeTime;
                    lemonadeLoadBarLength += lemonadeTime;
                }
                else // Once loading bar is full run lemonade profit
                {
                    lemonadeLoadBarLength = 0;
                    lemonadeLoad = false;
                    lemonadeStand.lemonadeStandClick(lemonadeProfit);
                }
            }

            //Checks if fastfood button was clicked
            if (fastFoodLoad == true) // Increases loading bar 
            {
                if (fastFoodLoadBarLength <= 200)
                {
                    fastFoodTime = oneSecond * fastFoodTime;
                    fastFoodTime = 200 / fastFoodTime;
                    fastFoodLoadBarLength += fastFoodTime;
                }
                else // Once loading bar is full run fastfood profit
                {
                    fastFoodLoadBarLength = 0;
                    fastFoodLoad = false;
                    FastFoodResturant.fastFoodClick(fastFoodProfit);
                }
            }

            //Checks if rugby button was clicked
            if (rugbyLoad == true) // Increases loading bar 
            {
                if (rugbyLoadBarLength <= 200)
                {
                    rugbyTime = oneSecond * rugbyTime;
                    rugbyTime = 200 / rugbyTime;
                    rugbyLoadBarLength += rugbyTime;
                }
                else // Once loading bar is full run rugby profit
                {
                    rugbyLoadBarLength = 0;
                    rugbyLoad = false;
                    RugbyTeam.rugbyTeamClick(rugbyProfit);
                }
            }

            Refresh();
        }

        //Check if lemonade button is clicked
        private void lemonadeStandButton_Click(object sender, EventArgs e)
        {
            if (lemonadeLoad == false)//Makes sure the button can't be clicked while laod bar goes
            {
                lemonadeLoad = true;
            }
        }

        //Check if lemonade upgrade button is clicked
        private void lemonadeUpgradeButton_Click(object sender, EventArgs e)
        {
            if (totalCash >= lemonadeeUpgrade)// Check if enough cash
            {
                lemonadeStand.lemondStandUpgradeClick(lemonadeeUpgrade, lemonLevel);
            }
        }

        //Switches to upgrade screen
        private void upgradesButton_Click(object sender, EventArgs e)
        {
            GameTimer.Stop();
            Form1.ChangeScreen(this, new UpgradeScreen());
        }

        //Paints loading bars
        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(whiteBrush, 280, 120, lemonadeLoadBarLength, 35); //Lemonade Load Bar
            e.Graphics.FillRectangle(whiteBrush, 280, 207, fastFoodLoadBarLength, 35); // Fast Food Load Bar
            e.Graphics.FillRectangle(whiteBrush, 280, 320, rugbyLoadBarLength, 35); // rugby Load Bar
        }


        //Start timer when switching back to game screen
        private void GameScreen_Load(object sender, EventArgs e)
        {
            GameTimer.Start();
        }


        //Check if fast food upgrade button is clicked
        private void fastFoodUpgradeButton_Click(object sender, EventArgs e)
        {
            if (hasFastFood == false) //Checks if fast food is unlocked or not
            {
                if (totalCash >= 5000) //Checks if user can afford to unlock
                {
                    hasFastFood = true;
                    fastFoodLevel++;
                    totalCash -= 5000;
                    fastFoodButton.Enabled = true;
                }
            }

            if (hasFastFood == true) //Checks if fast food is unlocked or not
            {
                if (totalCash >= fastFoodUpgrade) //Checks if user has enough to upgrade
                {
                    FastFoodResturant.fastFoodUpgradeClick(fastFoodUpgrade, fastFoodLevel);
                }
            }
        }

        //Checks if fast food button was clicked
        private void fastFoodButton_Click(object sender, EventArgs e)
        {
            if (fastFoodLoad == false) //Makes sure the button can't be clicked while laod bar goes
            {
                fastFoodLoad = true;
            }
        }


        //Check if rugby team upgrade button is clicked
        private void rugbyTeamUpgradeButton_Click(object sender, EventArgs e)
        {
            if (hasRugby == false) //Checks if rugby team is unlocked or not
            {
                if (totalCash >= 100000) //Checks if user can afford to unlock
                {
                    hasRugby = true;
                    rugbyLevel++;
                    totalCash -= 100000;
                    rugbyTeamButton.Enabled = true;
                }
            }

            if (hasRugby== true) //Checks if rugby is unlocked or not
            {
                if (totalCash >= rugbyUpgrade) //Checks if user has enough to upgrade
                {
                    RugbyTeam.rugbyTeamUpgradeClick(rugbyUpgrade, rugbyLevel);
                }
            }
        }

        //Checks if rugby button was clicked
        private void rugbyTeamButton_Click(object sender, EventArgs e)
        {
            if (rugbyLoad == false) //Makes sure the button can't be clicked while laod bar goes
            {
                rugbyLoad = true;
            }
        }
    }
}
