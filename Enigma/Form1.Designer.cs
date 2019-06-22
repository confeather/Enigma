namespace Enigma
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputTextBox = new System.Windows.Forms.RichTextBox();
            this.outputTextBox = new System.Windows.Forms.RichTextBox();
            this.rotorPos1 = new System.Windows.Forms.NumericUpDown();
            this.rotorPos2 = new System.Windows.Forms.NumericUpDown();
            this.rotorPos3 = new System.Windows.Forms.NumericUpDown();
            this.rotorPosLabel = new System.Windows.Forms.Label();
            this.rotor1Label = new System.Windows.Forms.Label();
            this.rotor2Label = new System.Windows.Forms.Label();
            this.rotor3Label = new System.Windows.Forms.Label();
            this.plugboardLabel = new System.Windows.Forms.Label();
            this.leftPlugcomboBox = new System.Windows.Forms.ComboBox();
            this.rightPlugComboBox = new System.Windows.Forms.ComboBox();
            this.connectionListBox = new System.Windows.Forms.ListBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.inputLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rotor1btn1 = new System.Windows.Forms.Button();
            this.rotor2btn = new System.Windows.Forms.Button();
            this.rotor3btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.reflectBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rotorPos1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotorPos2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotorPos3)).BeginInit();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(9, 351);
            this.inputTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(300, 200);
            this.inputTextBox.TabIndex = 11;
            this.inputTextBox.Text = "";
            this.inputTextBox.TextChanged += new System.EventHandler(this.inputTextBox_TextChanged);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(433, 351);
            this.outputTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(300, 200);
            this.outputTextBox.TabIndex = 12;
            this.outputTextBox.Text = "";
            // 
            // rotorPos1
            // 
            this.rotorPos1.Location = new System.Drawing.Point(145, 92);
            this.rotorPos1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rotorPos1.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.rotorPos1.Name = "rotorPos1";
            this.rotorPos1.Size = new System.Drawing.Size(53, 25);
            this.rotorPos1.TabIndex = 2;
            this.rotorPos1.ValueChanged += new System.EventHandler(this.rotorPos1_ValueChanged);
            // 
            // rotorPos2
            // 
            this.rotorPos2.Location = new System.Drawing.Point(145, 46);
            this.rotorPos2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rotorPos2.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.rotorPos2.Name = "rotorPos2";
            this.rotorPos2.Size = new System.Drawing.Size(53, 25);
            this.rotorPos2.TabIndex = 1;
            this.rotorPos2.ValueChanged += new System.EventHandler(this.rotorPos2_ValueChanged);
            // 
            // rotorPos3
            // 
            this.rotorPos3.Location = new System.Drawing.Point(145, 7);
            this.rotorPos3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rotorPos3.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.rotorPos3.Name = "rotorPos3";
            this.rotorPos3.Size = new System.Drawing.Size(53, 25);
            this.rotorPos3.TabIndex = 0;
            this.rotorPos3.ValueChanged += new System.EventHandler(this.rotorPos3_ValueChanged);
            // 
            // rotorPosLabel
            // 
            this.rotorPosLabel.AutoSize = true;
            this.rotorPosLabel.Location = new System.Drawing.Point(28, 9);
            this.rotorPosLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rotorPosLabel.Name = "rotorPosLabel";
            this.rotorPosLabel.Size = new System.Drawing.Size(105, 15);
            this.rotorPosLabel.TabIndex = 5;
            this.rotorPosLabel.Text = "初始转子3位置";
            this.rotorPosLabel.Click += new System.EventHandler(this.rotorPosLabel_Click);
            // 
            // rotor1Label
            // 
            this.rotor1Label.AutoSize = true;
            this.rotor1Label.Location = new System.Drawing.Point(28, 172);
            this.rotor1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rotor1Label.Name = "rotor1Label";
            this.rotor1Label.Size = new System.Drawing.Size(82, 15);
            this.rotor1Label.TabIndex = 6;
            this.rotor1Label.Text = "转子一规则";
            // 
            // rotor2Label
            // 
            this.rotor2Label.AutoSize = true;
            this.rotor2Label.Location = new System.Drawing.Point(28, 214);
            this.rotor2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rotor2Label.Name = "rotor2Label";
            this.rotor2Label.Size = new System.Drawing.Size(82, 15);
            this.rotor2Label.TabIndex = 13;
            this.rotor2Label.Text = "转子二规则";
            // 
            // rotor3Label
            // 
            this.rotor3Label.AutoSize = true;
            this.rotor3Label.Location = new System.Drawing.Point(28, 263);
            this.rotor3Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rotor3Label.Name = "rotor3Label";
            this.rotor3Label.Size = new System.Drawing.Size(82, 15);
            this.rotor3Label.TabIndex = 14;
            this.rotor3Label.Text = "转子三规则";
            // 
            // plugboardLabel
            // 
            this.plugboardLabel.AutoSize = true;
            this.plugboardLabel.Location = new System.Drawing.Point(439, 9);
            this.plugboardLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.plugboardLabel.Name = "plugboardLabel";
            this.plugboardLabel.Size = new System.Drawing.Size(82, 15);
            this.plugboardLabel.TabIndex = 15;
            this.plugboardLabel.Text = "连线板规则";
            // 
            // leftPlugcomboBox
            // 
            this.leftPlugcomboBox.FormattingEnabled = true;
            this.leftPlugcomboBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.leftPlugcomboBox.Location = new System.Drawing.Point(612, 9);
            this.leftPlugcomboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.leftPlugcomboBox.MaxLength = 1;
            this.leftPlugcomboBox.Name = "leftPlugcomboBox";
            this.leftPlugcomboBox.Size = new System.Drawing.Size(52, 23);
            this.leftPlugcomboBox.TabIndex = 6;
            // 
            // rightPlugComboBox
            // 
            this.rightPlugComboBox.FormattingEnabled = true;
            this.rightPlugComboBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.rightPlugComboBox.Location = new System.Drawing.Point(717, 9);
            this.rightPlugComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rightPlugComboBox.MaxLength = 1;
            this.rightPlugComboBox.Name = "rightPlugComboBox";
            this.rightPlugComboBox.Size = new System.Drawing.Size(52, 23);
            this.rightPlugComboBox.TabIndex = 7;
            this.rightPlugComboBox.SelectedIndexChanged += new System.EventHandler(this.rightPlugComboBox_SelectedIndexChanged);
            // 
            // connectionListBox
            // 
            this.connectionListBox.FormattingEnabled = true;
            this.connectionListBox.ItemHeight = 15;
            this.connectionListBox.Location = new System.Drawing.Point(442, 30);
            this.connectionListBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.connectionListBox.Name = "connectionListBox";
            this.connectionListBox.Size = new System.Drawing.Size(159, 199);
            this.connectionListBox.TabIndex = 9;
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(646, 50);
            this.connectButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(100, 27);
            this.connectButton.TabIndex = 8;
            this.connectButton.Text = "新增";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(646, 110);
            this.removeButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(100, 27);
            this.removeButton.TabIndex = 10;
            this.removeButton.Text = "移除";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(13, 333);
            this.inputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(37, 15);
            this.inputLabel.TabIndex = 21;
            this.inputLabel.Text = "输入";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(430, 333);
            this.outputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(37, 15);
            this.outputLabel.TabIndex = 22;
            this.outputLabel.Text = "输出";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(672, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "替换";
            // 
            // rotor1btn1
            // 
            this.rotor1btn1.Location = new System.Drawing.Point(117, 168);
            this.rotor1btn1.Name = "rotor1btn1";
            this.rotor1btn1.Size = new System.Drawing.Size(75, 23);
            this.rotor1btn1.TabIndex = 24;
            this.rotor1btn1.Text = "详情";
            this.rotor1btn1.UseVisualStyleBackColor = true;
            this.rotor1btn1.Click += new System.EventHandler(this.rotor1btn1_Click);
            // 
            // rotor2btn
            // 
            this.rotor2btn.Location = new System.Drawing.Point(117, 210);
            this.rotor2btn.Name = "rotor2btn";
            this.rotor2btn.Size = new System.Drawing.Size(75, 23);
            this.rotor2btn.TabIndex = 25;
            this.rotor2btn.Text = "详情";
            this.rotor2btn.UseVisualStyleBackColor = true;
            this.rotor2btn.Click += new System.EventHandler(this.rotor2btn_Click);
            // 
            // rotor3btn
            // 
            this.rotor3btn.Location = new System.Drawing.Point(117, 259);
            this.rotor3btn.Name = "rotor3btn";
            this.rotor3btn.Size = new System.Drawing.Size(75, 23);
            this.rotor3btn.TabIndex = 26;
            this.rotor3btn.Text = "详情";
            this.rotor3btn.UseVisualStyleBackColor = true;
            this.rotor3btn.Click += new System.EventHandler(this.rotor3btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 27;
            this.label2.Text = "初始转子2位置";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 15);
            this.label3.TabIndex = 28;
            this.label3.Text = "初始转子1位置";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(569, 273);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 29;
            this.label4.Text = "反射器规则";
            // 
            // reflectBtn
            // 
            this.reflectBtn.Location = new System.Drawing.Point(658, 269);
            this.reflectBtn.Name = "reflectBtn";
            this.reflectBtn.Size = new System.Drawing.Size(75, 23);
            this.reflectBtn.TabIndex = 30;
            this.reflectBtn.Text = "详情";
            this.reflectBtn.UseVisualStyleBackColor = true;
            this.reflectBtn.Click += new System.EventHandler(this.reflectBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.reflectBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rotor3btn);
            this.Controls.Add(this.rotor2btn);
            this.Controls.Add(this.rotor1btn1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.connectionListBox);
            this.Controls.Add(this.rightPlugComboBox);
            this.Controls.Add(this.leftPlugcomboBox);
            this.Controls.Add(this.plugboardLabel);
            this.Controls.Add(this.rotor3Label);
            this.Controls.Add(this.rotor2Label);
            this.Controls.Add(this.rotor1Label);
            this.Controls.Add(this.rotorPosLabel);
            this.Controls.Add(this.rotorPos3);
            this.Controls.Add(this.rotorPos2);
            this.Controls.Add(this.rotorPos1);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.inputTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.Text = "恩尼格玛机";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rotorPos1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotorPos2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotorPos3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox inputTextBox;
        private System.Windows.Forms.RichTextBox outputTextBox;
        private System.Windows.Forms.NumericUpDown rotorPos1;
        private System.Windows.Forms.NumericUpDown rotorPos2;
        private System.Windows.Forms.NumericUpDown rotorPos3;
        private System.Windows.Forms.Label rotorPosLabel;
        private System.Windows.Forms.Label rotor1Label;
        private System.Windows.Forms.Label rotor2Label;
        private System.Windows.Forms.Label rotor3Label;
        private System.Windows.Forms.Label plugboardLabel;
        private System.Windows.Forms.ComboBox leftPlugcomboBox;
        private System.Windows.Forms.ComboBox rightPlugComboBox;
        private System.Windows.Forms.ListBox connectionListBox;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button rotor1btn1;
        private System.Windows.Forms.Button rotor2btn;
        private System.Windows.Forms.Button rotor3btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button reflectBtn;
    }
}

