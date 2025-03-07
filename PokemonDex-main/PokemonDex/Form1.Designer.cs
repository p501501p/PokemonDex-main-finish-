namespace PokemonDex
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            Label_name = new Label();
            LableType = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            groupBox1 = new GroupBox();
            Hp = new Label();
            Attack = new Label();
            Defense = new Label();
            SpAtk = new Label();
            SpDef = new Label();
            Speed = new Label();
            Total = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Poke_type = new Label();
            Poke_name = new Label();
            label10 = new Label();
            Label_Weight = new Label();
            label13 = new Label();
            Label_height = new Label();
            Label_Species = new Label();
            label12 = new Label();
            label8 = new Label();
            label14 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(248, 79);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(260, 266);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // Label_name
            // 
            Label_name.AutoSize = true;
            Label_name.Location = new Point(552, 33);
            Label_name.Name = "Label_name";
            Label_name.Size = new Size(39, 15);
            Label_name.TabIndex = 1;
            Label_name.Text = "Name";
            Label_name.Click += label1_Click;
            // 
            // LableType
            // 
            LableType.AutoSize = true;
            LableType.Location = new Point(552, 63);
            LableType.Name = "LableType";
            LableType.Size = new Size(31, 15);
            LableType.TabIndex = 2;
            LableType.Text = "Type";
            // 
            // button1
            // 
            button1.Location = new Point(30, 43);
            button1.Name = "button1";
            button1.Size = new Size(170, 53);
            button1.TabIndex = 3;
            button1.Text = "Pickachu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(30, 102);
            button2.Name = "button2";
            button2.Size = new Size(170, 53);
            button2.TabIndex = 4;
            button2.Text = "Mewtwo";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(30, 161);
            button3.Name = "button3";
            button3.Size = new Size(170, 53);
            button3.TabIndex = 5;
            button3.Text = "Charizard";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(30, 220);
            button4.Name = "button4";
            button4.Size = new Size(170, 53);
            button4.TabIndex = 6;
            button4.Text = "Meowth";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(30, 279);
            button5.Name = "button5";
            button5.Size = new Size(170, 53);
            button5.TabIndex = 7;
            button5.Text = "Psyduck";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(30, 341);
            button6.Name = "button6";
            button6.Size = new Size(170, 53);
            button6.TabIndex = 8;
            button6.Text = "Hypno";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Hp);
            groupBox1.Controls.Add(Attack);
            groupBox1.Controls.Add(Defense);
            groupBox1.Controls.Add(SpAtk);
            groupBox1.Controls.Add(SpDef);
            groupBox1.Controls.Add(Speed);
            groupBox1.Controls.Add(Total);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(552, 194);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(184, 244);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "BaseStats";
            // 
            // Hp
            // 
            Hp.AutoSize = true;
            Hp.FlatStyle = FlatStyle.System;
            Hp.Location = new Point(68, 30);
            Hp.Name = "Hp";
            Hp.Size = new Size(23, 15);
            Hp.TabIndex = 26;
            Hp.Text = "HP";
            // 
            // Attack
            // 
            Attack.AutoSize = true;
            Attack.FlatStyle = FlatStyle.System;
            Attack.Location = new Point(68, 56);
            Attack.Name = "Attack";
            Attack.Size = new Size(41, 15);
            Attack.TabIndex = 25;
            Attack.Text = "Attack";
            // 
            // Defense
            // 
            Defense.AutoSize = true;
            Defense.FlatStyle = FlatStyle.System;
            Defense.Location = new Point(68, 82);
            Defense.Name = "Defense";
            Defense.Size = new Size(49, 15);
            Defense.TabIndex = 24;
            Defense.Text = "Defense";
            // 
            // SpAtk
            // 
            SpAtk.AutoSize = true;
            SpAtk.FlatStyle = FlatStyle.System;
            SpAtk.Location = new Point(68, 108);
            SpAtk.Name = "SpAtk";
            SpAtk.Size = new Size(44, 15);
            SpAtk.TabIndex = 23;
            SpAtk.Text = "Sp. Atk";
            // 
            // SpDef
            // 
            SpDef.AutoSize = true;
            SpDef.FlatStyle = FlatStyle.System;
            SpDef.Location = new Point(68, 134);
            SpDef.Name = "SpDef";
            SpDef.Size = new Size(44, 15);
            SpDef.TabIndex = 22;
            SpDef.Text = "Sp. Def\t";
            // 
            // Speed
            // 
            Speed.AutoSize = true;
            Speed.FlatStyle = FlatStyle.System;
            Speed.Location = new Point(68, 160);
            Speed.Name = "Speed";
            Speed.Size = new Size(39, 15);
            Speed.TabIndex = 21;
            Speed.Text = "Speed";
            // 
            // Total
            // 
            Total.AutoSize = true;
            Total.FlatStyle = FlatStyle.System;
            Total.Location = new Point(68, 186);
            Total.Name = "Total";
            Total.Size = new Size(32, 15);
            Total.TabIndex = 20;
            Total.Text = "Total";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 30);
            label7.Name = "label7";
            label7.Size = new Size(23, 15);
            label7.TabIndex = 19;
            label7.Text = "HP";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 56);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 18;
            label6.Text = "Attack";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 82);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 17;
            label5.Text = "Defense";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 108);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 16;
            label4.Text = "Sp. Atk";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 134);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 15;
            label3.Text = "Sp. Def\t";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 160);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 14;
            label2.Text = "Speed";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 186);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 13;
            label1.Text = "Total";
            // 
            // Poke_type
            // 
            Poke_type.AutoSize = true;
            Poke_type.Location = new Point(605, 64);
            Poke_type.Name = "Poke_type";
            Poke_type.Size = new Size(31, 15);
            Poke_type.TabIndex = 11;
            Poke_type.Text = "Type";
            // 
            // Poke_name
            // 
            Poke_name.AutoSize = true;
            Poke_name.Location = new Point(605, 34);
            Poke_name.Name = "Poke_name";
            Poke_name.Size = new Size(39, 15);
            Poke_name.TabIndex = 12;
            Poke_name.Text = "Name";
            Poke_name.Click += label2_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(553, 123);
            label10.Name = "label10";
            label10.Size = new Size(43, 15);
            label10.TabIndex = 14;
            label10.Text = "Height";
            // 
            // Label_Weight
            // 
            Label_Weight.AutoSize = true;
            Label_Weight.Location = new Point(606, 154);
            Label_Weight.Name = "Label_Weight";
            Label_Weight.Size = new Size(31, 15);
            Label_Weight.TabIndex = 18;
            Label_Weight.Text = "Type";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(553, 153);
            label13.Name = "label13";
            label13.Size = new Size(45, 15);
            label13.TabIndex = 17;
            label13.Text = "Weight";
            // 
            // Label_height
            // 
            Label_height.AutoSize = true;
            Label_height.Location = new Point(606, 123);
            Label_height.Name = "Label_height";
            Label_height.Size = new Size(43, 15);
            Label_height.TabIndex = 19;
            Label_height.Text = "Height";
            // 
            // Label_Species
            // 
            Label_Species.AutoSize = true;
            Label_Species.Location = new Point(606, 94);
            Label_Species.Name = "Label_Species";
            Label_Species.Size = new Size(46, 15);
            Label_Species.TabIndex = 21;
            Label_Species.Text = "Species";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(553, 93);
            label12.Name = "label12";
            label12.Size = new Size(46, 15);
            label12.TabIndex = 20;
            label12.Text = "Species";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(655, 123);
            label8.Name = "label8";
            label8.Size = new Size(18, 15);
            label8.TabIndex = 23;
            label8.Text = "M";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(655, 154);
            label14.Name = "label14";
            label14.Size = new Size(21, 15);
            label14.TabIndex = 22;
            label14.Text = "KG";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(label14);
            Controls.Add(Label_Species);
            Controls.Add(label12);
            Controls.Add(Label_height);
            Controls.Add(Label_Weight);
            Controls.Add(label13);
            Controls.Add(label10);
            Controls.Add(Poke_name);
            Controls.Add(Poke_type);
            Controls.Add(groupBox1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(LableType);
            Controls.Add(Label_name);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label Label_name;
        private Label LableType;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private GroupBox groupBox1;
        private Label Poke_type;
        private Label Poke_name;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label Hp;
        private Label Attack;
        private Label Defense;
        private Label SpAtk;
        private Label SpDef;
        private Label Speed;
        private Label Total;
        private Label Species;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label Label_Weight;
        private Label label13;
        private Label Label_height;
        private Label Label_Species;
        private Label label12;
        private Label label8;
        private Label label14;
    }
}
