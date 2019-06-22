using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enigma
{
    public partial class RotorForm : Form
    {
        public string rotorName = "";
        public int[] configs;

        private bool loaded = false;
        private bool change = false;

        public RotorForm()
        {
            InitializeComponent();
        }

        private void RotorForm_Load(object sender, EventArgs e)
        {
            if (rotorName=="rotor1")
            {
                rotorLabel.Text = "转子1";
            }
            else if (rotorName == "rotor2")
            {
                rotorLabel.Text = "转子2";
            }
            else if (rotorName == "rotor3")
            {
                rotorLabel.Text = "转子3";
            }

            UpdateForm();
            loaded = true;
        }
        /// <summary>
        /// 更新交换规则
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        public void UpdateConnection(int firstIndex, int secondIndex)
        {
            int index = 0;
            
            foreach (var item in configs)
            {
                if (item == secondIndex)
                {
                    break;
                }
                else
                {
                    index++;
                }

            }
            configs[index] = configs[firstIndex];
            configs[firstIndex] = secondIndex;
            //更新页面
            UpdateForm();
        }


        /// <summary>
        /// 更新界面
        /// </summary>
        public void UpdateForm()
        {
            for (int i = 0; i < 26; i++)
            {
                ComboBox comboBox = (ComboBox)this.Controls["config" + i];
                comboBox.SelectedItem = comboBox.Items[configs[i]];
                //Console.WriteLine(i + "," + configs[i]);
            }
            change = false;
        }

        private void config0_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loaded && !change)
            {
                change = true;
                UpdateConnection(0, config0.SelectedIndex);
            }
        }

        private void config1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loaded && !change)
            {
                change = true;
                UpdateConnection(1, config1.SelectedIndex);
            }
        }

        private void config2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loaded && !change)
            {
                change = true;
                UpdateConnection(2, config2.SelectedIndex);
            }
        }

        private void config3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loaded && !change)
            {
                change = true;
                UpdateConnection(3, config3.SelectedIndex);
            }
        }

        private void config4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loaded && !change)
            {
                change = true;
                UpdateConnection(4, config4.SelectedIndex);
            }
        }

        private void config5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loaded && !change)
            {
                change = true;
                UpdateConnection(5, config5.SelectedIndex);
            }
        }

        private void config6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loaded && !change)
            {
                change = true;
                UpdateConnection(6, config6.SelectedIndex);
            }
        }

        private void config7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loaded && !change)
            {
                change = true;
                UpdateConnection(7, config7.SelectedIndex);
            }
        }

        private void config8_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loaded && !change)
            {
                change = true;
                UpdateConnection(8, config8.SelectedIndex);
            }
        }

        private void config9_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loaded && !change)
            {
                change = true;
                UpdateConnection(9, config9.SelectedIndex);
            }
        }

        private void config10_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loaded && !change)
            {
                change = true;
                UpdateConnection(10, config10.SelectedIndex);
            }
        }

        private void config11_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loaded && !change)
            {
                change = true;
                UpdateConnection(11, config11.SelectedIndex);
            }
        }

        private void config12_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loaded && !change)
            {
                change = true;
                UpdateConnection(12, config12.SelectedIndex);
            }
        }

        private void config13_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loaded && !change)
            {
                change = true;
                UpdateConnection(13, config13.SelectedIndex);
            }
        }

        private void config14_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loaded && !change)
            {
                change = true;
                UpdateConnection(14, config14.SelectedIndex);
            }
        }

        private void config15_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loaded && !change)
            {
                change = true;
                UpdateConnection(15, config15.SelectedIndex);
            }
        }

        private void config16_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loaded && !change)
            {
                change = true;
                UpdateConnection(16, config16.SelectedIndex);
            }
        }

        private void config17_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loaded && !change)
            {
                change = true;
                UpdateConnection(17, config17.SelectedIndex);
            }
        }

        private void config18_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loaded && !change)
            {
                change = true;
                UpdateConnection(18, config18.SelectedIndex);
            }
        }

        private void config19_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loaded && !change)
            {
                change = true;
                UpdateConnection(19, config19.SelectedIndex);
            }
        }

        private void config20_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loaded && !change)
            {
                change = true;
                UpdateConnection(20, config20.SelectedIndex);
            }
        }

        private void config21_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loaded && !change)
            {
                change = true;
                UpdateConnection(21, config21.SelectedIndex);
            }
        }

        private void config22_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loaded && !change)
            {
                change = true;
                UpdateConnection(22, config22.SelectedIndex);
            }
        }

        private void config23_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loaded && !change)
            {
                change = true;
                UpdateConnection(23, config23.SelectedIndex);
            }
        }

        private void config24_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loaded && !change)
            {
                change = true;
                UpdateConnection(24, config24.SelectedIndex);
            }
        }

        private void config25_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loaded && !change)
            {
                change = true;
                UpdateConnection(25, config25.SelectedIndex);
            }
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            EventCenter.Broadcast<string, int[]>(EventType.RotorChange, rotorName, configs);
            this.Close();
        }
    }
}
