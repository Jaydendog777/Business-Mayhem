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
    public partial class UpgradeScreen : UserControl
    {
        static public double lemonProfitUpgradeCost = 50;
        static public double fastFoodProfitUpgradeCost = 25000;

        public UpgradeScreen()
        {
            InitializeComponent();
            labelRefresh(); //Refresh all shops labels
        }

        //Exit back to game screen
        private void upgradesExitButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new GameScreen());
        }

        //upgrade profit of lemonade and increase upgrade cost
        private void lemonProfitUpgradeButton_Click(object sender, EventArgs e)
        {
            if (GameScreen.totalCash >= lemonProfitUpgradeCost)
            {
                GameScreen.totalCash -= lemonProfitUpgradeCost;
                lemonProfitUpgradeCost = lemonProfitUpgradeCost * 2.25;
                lemonadeStand.lemonMult += 0.4;
                GameScreen.lemonadeProfit += 1 * lemonadeStand.lemonMult;

                labelRefresh();
            }
        }

        //Refresh all shop labels
        private void labelRefresh()
        {
            upgradesCashLabel.Text = $"{GameScreen.totalCash.ToString("C")}";
            lemonUpgradeOneCostLabel.Text = $"{lemonProfitUpgradeCost.ToString("C")}";
            fastFoodUpgradeOneCostLabel.Text = $"{fastFoodProfitUpgradeCost.ToString("C")}";
        }

        //upgrade profit of fast food and increase upgrade cost
        private void fastFoodProfitUpgradeButton_Click_1(object sender, EventArgs e)
        {
            if (GameScreen.totalCash >= fastFoodProfitUpgradeCost)
            {
                GameScreen.totalCash -= fastFoodProfitUpgradeCost;
                fastFoodProfitUpgradeCost = fastFoodProfitUpgradeCost * 2.25;
                FastFoodResturant.fastFoodMult += 0.4;
                GameScreen.fastFoodProfit += 1 * FastFoodResturant.fastFoodMult;

                labelRefresh();
            }
        }
    }
}
