using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Mayhem
{
    internal class FastFoodResturant
    {
        static public double fastFoodProfit, fastFoodUpgrade, level;
        static public double fastFoodUpgradeIncrease = 1.33;
        static public double fastFoodMult = 1;

        //make money when ran
        static public void fastFoodClick(double _profit)
        {
            fastFoodProfit = _profit;

            GameScreen.totalCash += fastFoodProfit;
        }

        //Upgrade fast food profit and increase fast food upgrade cost
        static public void fastFoodUpgradeClick(double _upgrade, double _lvl)
        {
            fastFoodUpgrade = _upgrade;
            level = _lvl;

            level = level / 90;
            level++;

            GameScreen.totalCash -= fastFoodUpgrade;
            GameScreen.fastFoodUpgrade = fastFoodUpgrade * fastFoodUpgradeIncrease * level;
            double x = fastFoodProfit / 4;
            GameScreen.fastFoodProfit += 250 + x * fastFoodMult;
            GameScreen.fastFoodLevel += 1;
        }
    }
}
