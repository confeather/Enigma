using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma
{
    public class Rotor
    {
        public int[] forwardConfig, backwardConfig;
        
        public Rotor (int[] config)
        {
            //转子正序不变
            forwardConfig = config;
            //反函数
            backwardConfig = new int[26];
            for (int i = 0; i < 26; i++)
            {
                backwardConfig[forwardConfig[i]] = i;
            }
        }
        /// <summary>
        /// 替换
        /// </summary>
        /// <param name="input"></param>
        /// <param name="offset"></param>
        /// <returns></returns>
        public int Forward (int input, int offset)
        {
            return mod(forwardConfig[mod(input + offset, 26)] - offset, 26);
        }
        /// <summary>
        /// 得到来自上一转子的输出
        /// </summary>
        /// <param name="input"></param>
        /// <param name="offset"></param>
        /// <returns></returns>
        public int Backward (int input, int offset)
        {
            return mod(backwardConfig[mod(input + offset, 26)] - offset, 26);
        }

        private int mod (int x, int m)
        {
            return (x % m + m) % m;
        }
    }
}
