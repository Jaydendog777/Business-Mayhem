using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Mayhem
{
    internal class RugbyTeam
    {
        static public double rugbyProfit, rugbyUpgrade, level;
        static public double rugbyUpgradeIncrease = 1.33;
        static public double rugbyMult = 1;


        //Make money when ran
        static public void rugbyTeamClick(double _profit)
        {
            rugbyProfit = _profit;

            GameScreen.totalCash += rugbyProfit;
        }

        //Upgrade lemonadestand profit and increase upgrade cost
        static public void rugbyTeamUpgradeClick(double _upgrade, double _lvl)
        {
            rugbyUpgrade = _upgrade;
            level = _lvl;

            level = level / 90;
            level++;

            GameScreen.totalCash -= rugbyUpgrade;
            GameScreen.rugbyUpgrade = rugbyUpgrade * rugbyUpgradeIncrease * level;
            double x = rugbyProfit / 4;
            GameScreen.rugbyProfit += 1 + x * rugbyMult;
            GameScreen.rugbyLevel += 1;
        }
    }
}
