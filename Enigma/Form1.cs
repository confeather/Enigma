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
    public partial class Form1 : Form
    {
        public EnigmaMachine enigmaMachine;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            enigmaMachine = new EnigmaMachine();
            EventCenter.AddListener<string, int[]>(EventType.RotorChange, UpdateRotor);
            EventCenter.AddListener<int[]>(EventType.ReflectorChange, UpdateRelector);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            EventCenter.RemoveListener<string, int[]>(EventType.RotorChange, UpdateRotor);
            EventCenter.RemoveListener<int[]>(EventType.ReflectorChange, UpdateRelector);
        }


        /// <summary>
        /// 输出结果
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {
            int length = inputTextBox.Text.Length;
            //输出结果
            outputTextBox.Text = enigmaMachine.Translate(inputTextBox.Text);
            //Console.WriteLine(enigmaMachine.rotor1.backwardConfig[18]);
            bool controlsEnabled = length == 0;

            rotorPos1.Enabled = controlsEnabled;
            rotorPos2.Enabled = controlsEnabled;
            rotorPos3.Enabled = controlsEnabled;

            connectButton.Enabled = controlsEnabled;
            removeButton.Enabled = controlsEnabled;

            rotor1btn1.Enabled = controlsEnabled;
            rotor2btn.Enabled = controlsEnabled;
            rotor3btn.Enabled = controlsEnabled;

            reflectBtn.Enabled = controlsEnabled;
        }

        //变换转子初始位置状态
        private void rotorPos1_ValueChanged(object sender, EventArgs e)
        {
            enigmaMachine.SetRotorPosition((int)rotorPos3.Value, (int)rotorPos2.Value, (int)rotorPos1.Value);
        }
        private void rotorPos2_ValueChanged(object sender, EventArgs e)
        {
            enigmaMachine.SetRotorPosition((int)rotorPos3.Value, (int)rotorPos2.Value, (int)rotorPos1.Value);
        }
        private void rotorPos3_ValueChanged(object sender, EventArgs e)
        {
            enigmaMachine.SetRotorPosition((int)rotorPos3.Value, (int)rotorPos2.Value, (int)rotorPos1.Value);
        }
        /// <summary>
        /// 添加连线规则按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void connectButton_Click(object sender, EventArgs e)
        {
            enigmaMachine.AddPlugboardConnection(leftPlugcomboBox.Text, rightPlugComboBox.Text);
            UpdateConnections();
        }
        /// <summary>
        /// 移除连线规则按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeButton_Click(object sender, EventArgs e)
        {
            enigmaMachine.RemovePlugboardConnection((string)connectionListBox.SelectedItem);
            UpdateConnections();
        }
        /// <summary>
        /// 更新插线板法则，展示出来
        /// </summary>
        private void UpdateConnections ()
        {
            connectionListBox.Items.Clear();
            foreach (string item in enigmaMachine.GetPlugboardConnections())
            {
                connectionListBox.Items.Add(item);
            }
        }

        private void rightPlugComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rotor1btn1_Click(object sender, EventArgs e)
        {
            RotorForm rotorForm = new RotorForm();
            rotorForm.configs = enigmaMachine.rotor1.forwardConfig;
            rotorForm.rotorName = "rotor1";
            rotorForm.Show();
        }



        /// <summary>
        /// 更新转子规则
        /// </summary>
        /// <param name="rotorName"></param>
        /// <param name="configs"></param>
        private void UpdateRotor(string rotorName,int[] configs)
        {
            if (rotorName=="rotor1")
            {
                enigmaMachine.rotor1 = new Rotor(configs);
            }
            else if (rotorName == "rotor2")
            {
                enigmaMachine.rotor2 = new Rotor(configs);
            }
            else if (rotorName == "rotor3")
            {
                enigmaMachine.rotor3 = new Rotor(configs);
            }
        }
        /// <summary>
        /// 更新反射器反射规则
        /// </summary>
        /// <param name="configs"></param>
        private void UpdateRelector(int[] configs)
        {
            enigmaMachine.reflector.config = configs;
        }

        private void rotor2btn_Click(object sender, EventArgs e)
        {
            RotorForm rotorForm = new RotorForm();
            rotorForm.configs = enigmaMachine.rotor2.forwardConfig;
            rotorForm.rotorName = "rotor2";
            rotorForm.Show();
        }

        private void rotor3btn_Click(object sender, EventArgs e)
        {
            RotorForm rotorForm = new RotorForm();
            rotorForm.configs = enigmaMachine.rotor3.forwardConfig;
            rotorForm.rotorName = "rotor3";
            rotorForm.Show();
        }

        private void rotorPosLabel_Click(object sender, EventArgs e)
        {

        }

        private void reflectBtn_Click(object sender, EventArgs e)
        {
            ReflectForm form = new ReflectForm();
            form.original = enigmaMachine.reflector.original;
            form.configs = enigmaMachine.reflector.config;
            form.Show();
        }
    }
}
