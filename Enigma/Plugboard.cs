using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma
{
    class Plugboard
    {
        private string alphabet;
        private int[] config;

        public Plugboard ()
        {
            alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            config = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
        }

        public int Pass (int value)
        {
            return config[value];
        }
        /// <summary>
        /// 添加对应关系
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        public void AddConnection (string first, string second)
        {
            first = first.ToUpper();
            second = second.ToUpper();
            //两边相同则返回
            if (first == second || first == "" || second == "") return;

            char firstChar = first[0], secondChar = second[0];
            //非字母表中字符则返回
            if (!alphabet.Contains(firstChar) || !alphabet.Contains(secondChar)) return;
            //得到两边的字母对应数字
            int firstIndex = alphabet.IndexOf(firstChar), secondIndex = alphabet.IndexOf(secondChar);
            //两字母交换
            config[config[firstIndex]] = config[firstIndex];
            config[config[secondIndex]] = config[secondIndex];
            config[firstIndex] = secondIndex;
            config[secondIndex] = firstIndex;
        }
        /// <summary>
        /// 取消插线板
        /// </summary>
        /// <param name="connection"></param>
        public void RemoveConnection(string connection)
        {
            //交换为空则返回
            if (connection == null) return;

            int firstIndex = alphabet.IndexOf(connection[0]), secondIndex = alphabet.IndexOf(connection[5]);

            config[firstIndex] = firstIndex;
            config[secondIndex] = secondIndex;
        }
        /// <summary>
        /// 得到连线规则列表
        /// </summary>
        /// <returns></returns>
        public List<string> GetConnections ()
        {
            List<string> connections = new List<string>();
            HashSet<int> foundConnections = new HashSet<int>();

            foreach (int i in config)
            {
                if (config[i] != i && !foundConnections.Contains(i))
                {
                    foundConnections.Add(i);
                    foundConnections.Add(config[i]);
                    connections.Add(alphabet[config[i]] + " to " + alphabet[i]);
                }
            }

            return connections;
        }
    }
}
