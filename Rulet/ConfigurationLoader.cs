using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rulet
{
    class ConfigurationLoader
    {
        private static ConfigurationLoader loader = null;
        private List<List<int[]>> configuration;
        private VariablePaytable variablePaytable;
        private readonly int[][] targetOdds = new[]
        {
            new[] {36},
            new[] {33, 48, 72},
            new[] {30, 60, 90, 120},
            new[] {30, 50, 100, 150, 200, 250,500 }
        };
        private ConfigurationLoader() {
            configuration = new List<List<int[]>>();
            StreamReader streamReader;
            int[] t = new int[1];
            t[0] = 36;
            List<int[]> defaultConf = new List<int[]>();
            defaultConf.Add(t);
            configuration.Add(defaultConf);
            for (int i = 1; i < targetOdds.Length; i++)
            {
                streamReader = new StreamReader("../../Odds" + i + ".txt");
                configuration.Add(new List<int[]>());
                while (!streamReader.EndOfStream)
                {
                    string[] str = streamReader.ReadLine().Split(' ');
                    int[] configurationInteger = new int[str.Length];
                    for (int j = 0; j < str.Length; j++)
                    {
                        configurationInteger[j] = Convert.ToInt32(str[j]);
                    }
                    configuration[i].Add(configurationInteger);

                }
                streamReader.Close();
            }

            variablePaytable = new VariablePaytable(targetOdds, configuration);

        }

        public static ConfigurationLoader getInstance()
        {
            if (loader == null)
            {
                loader = new ConfigurationLoader();
            }
            return loader;
        }

        public VariablePaytable getPaytable() 
        {
            return variablePaytable;
        }
    }
}
