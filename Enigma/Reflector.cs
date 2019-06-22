using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma
{
    public class Reflector
    {
        public int[] original;
        //反射规则
        public int[] config;

        public Reflector (int[] configs)
        {
            original = configs;
            //config = configs;
            config = new int[26];
            for (int i = 0; i < 26; i++)
            {
                //默认反射规则
                //config[i] = configs[25-i];
                config[configs[i]] = configs[25 - i];
                //Console.WriteLine(config[i]);
            }
        }

        public int Reflect(int input)
        {
            return config[input];
        }
    }
}
