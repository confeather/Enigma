using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma
{
    public class EnigmaMachine
    {
        private string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private int rotorPosition, prevLength;
        private Rotor[] rotors;
        public Rotor rotor1, rotor2, rotor3;
        public Reflector reflector;
        private Plugboard plugboard;
        private Dictionary<char, int> alphaToNumber;

        public EnigmaMachine ()
        {
            //转子对应规则
            rotors = new Rotor[] {
                new Rotor(new int[] { 18, 25, 4, 24, 1, 2, 14, 10, 0, 11, 12, 8, 3, 20, 23, 7, 16, 21, 13, 15, 5, 22, 9, 17, 19, 6 }),
                new Rotor(new int[] { 7, 25, 2, 24, 11, 10, 13, 12, 9, 20, 16, 22, 6, 5, 4, 15, 19, 14, 23, 1, 0, 17, 21, 3, 18, 8 }),
                new Rotor(new int[] { 21, 9, 3, 19, 22, 13, 11, 15, 10, 2, 17, 18, 23, 12, 6, 16, 4, 0, 7, 8, 14, 5, 24, 25, 1, 20 }),
                new Rotor(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 })
            };
            //默认转子
            rotor1 = rotors[0];
            rotor2 = rotors[1];
            rotor3 = rotors[2];
            //默认反射板
            reflector = new Reflector(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 });
            //连线板
            plugboard = new Plugboard();

            alphaToNumber = new Dictionary<char, int>();
            foreach (char letter in alphabet)
            {
                alphaToNumber[letter] = alphabet.IndexOf(letter);
            }

            rotorPosition = 0;
            prevLength = 0;
        }
        /// <summary>
        /// 得到结果
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string Translate (string input)
        {
            string result = "";
            //从第二位字符开始要变更转子位置
            rotorPosition -= prevLength;
            input = input.ToUpper();
            foreach (char letter in input)
            {
                if (!alphabet.Contains(letter)) continue;
                //得到字母序号    
                int charValue = alphaToNumber[letter];
                //连线板替换
                charValue = plugboard.Pass(charValue);
                //三次替换计算
                charValue = rotor1.Forward(charValue, RotorPosition1());
                charValue = rotor2.Forward(charValue, RotorPosition2());
                charValue = rotor3.Forward(charValue, RotorPosition3());
                //反射器
                charValue = reflector.Reflect(charValue);
                //原路返回
                charValue = rotor3.Backward(charValue, RotorPosition3());
                charValue = rotor2.Backward(charValue, RotorPosition2());
                charValue = rotor1.Backward(charValue, RotorPosition1());
                //返回插线板
                charValue = plugboard.Pass(charValue);
                //结果
                result += alphabet[charValue];
                //每个字符都会让转子移动
                rotorPosition++;
            }
            //明文长度
            prevLength = result.Length;
            return result;
        }

        /// <summary>
        /// 初始转子位置状态
        /// </summary>
        /// <param name="rotor3"></param>
        /// <param name="rotor2"></param>
        /// <param name="rotor1"></param>
        public void SetRotorPosition(int rotor3, int rotor2, int rotor1)
        {
            rotorPosition = rotor3 * 26 * 26 + rotor2 * 26 + rotor1;
        }

        public int RotorPosition1 ()
        {
            return mod(rotorPosition, 26);
        }
        public int RotorPosition2()
        {
            return mod(rotorPosition, 676) / 26;
        }
        public int RotorPosition3()
        {
            return mod(rotorPosition, 17576) / 676;
        }
        public void SetRotor1 (int value)
        {
            rotor1 = rotors[value];
        }
        public void SetRotor2(int value)
        {
            rotor2 = rotors[value];
        }
        public void SetRotor3(int value)
        {
            rotor3 = rotors[value];
        }
        /// <summary>
        /// 添加插线板规则
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        public void AddPlugboardConnection (string first, string second)
        {
            plugboard.AddConnection(first, second);
        }
        /// <summary>
        /// 移除插线板规则
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        public void RemovePlugboardConnection (string connection)
        {
            plugboard.RemoveConnection(connection);
        }
        /// <summary>
        /// 得到插线板规则列表
        /// </summary>
        /// <returns></returns>
        public List<string> GetPlugboardConnections ()
        {
            return plugboard.GetConnections();
        }

        private int mod(int x, int m)
        {
            return (x % m + m) % m;
        }
    }
}
