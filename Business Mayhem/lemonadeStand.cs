using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Mayhem
{
    

    internal class lemonadeStand
    {
        static public double lemonProfit, lemonUpgrade, level;
        static public double lemonUpgradeIncrease = 1.33;
        static public double lemonMult = 1;


        //Make money when ran
        static public void lemonadeStandClick(double _profit) 
        { 
            lemonProfit = _profit;

            GameScreen.totalCash += lemonProfit;
        }

        //Upgrade lemonadestand profit and increase upgrade cost
        static public void lemondStandUpgradeClick(double _upgrade, double _lvl)
        {
            lemonUpgrade = _upgrade;
            level = _lvl;

            level = level / 90;
            level++;

            GameScreen.totalCash -= lemonUpgrade;
            GameScreen.lemonadeeUpgrade = lemonUpgrade * lemonUpgradeIncrease * level;
            double x = lemonProfit / 4;
            GameScreen.lemonadeProfit += 1 + x * lemonMult;
            GameScreen.lemonLevel += 1;
        }

    }
}
