using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rulet
{
    class VariablePaytable
    {

        // Variable ods sets for diferent configuration
        private int[][] variableOddsSets { get; set; }
        //Configuration for given Odds
        private List<List<int[]>> configuration;

        public VariablePaytable(int[][] variableOddsSets, List<List<int[]>> configuration)
        {
            this.variableOddsSets = variableOddsSets;
            this.configuration = configuration;

        }

        public int[] GenerateVariableOdds(int setID)
        {
            // we pick one of the sets
            // and randomly set/generate ods from that set for every number
            // this will be changed when mathematics will be implemented
            //setID = 0 for default roulet
            var selectedVariableSet = variableOddsSets[setID];
            int[] variableOdds = new int[37];
            if (setID == 0)
            {
                for (int i = 0; i < 37; i++)
                {
                    variableOdds[i] = 36;
                }
                return variableOdds;
            }
            List<int> allNumbers = new List<int>();
            for (int i = 0; i < 37; i++)
            {
                allNumbers.Add(i);
            }
            Random rand = new Random();
            var chosenConfiguration = (int[])configuration[setID][rand.Next() % configuration[setID].Count].Clone();
            for (int i = 0; i < chosenConfiguration.Length; i++)
            {
                while (chosenConfiguration[i] > 0)
                {
                    int number = allNumbers[rand.Next() % allNumbers.Count];
                    allNumbers.Remove(number);
                    variableOdds[number] = variableOddsSets[setID][i];
                    chosenConfiguration[i]--;
                }
            }
            return variableOdds;
        }

    }
}
