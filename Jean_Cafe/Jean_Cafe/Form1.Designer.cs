namespace Jean_Cafe
{
    partial class JeanCafe
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Cost = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.butClear = new System.Windows.Forms.Button();
            this.butPlaceOrder = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.Welcome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Addons = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxCocoa = new System.Windows.Forms.CheckBox();
            this.checkBoxCinnamon = new System.Windows.Forms.CheckBox();
            this.checkBoxSugar = new System.Windows.Forms.CheckBox();
            this.checkBoxWhipped = new System.Windows.Forms.CheckBox();
            this.checkBoxCream = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBoxWhippedTea = new System.Windows.Forms.CheckBox();
            this.checkBoxSugarTea = new System.Windows.Forms.CheckBox();
            this.checkBoxCreamTea = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.Addons.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.Cost);
            this.groupBox1.Controls.Add(this.labelTotal);
            this.groupBox1.Controls.Add(this.butClear);
            this.groupBox1.Controls.Add(this.butPlaceOrder);
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(969, 951);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // Cost
            // 
            this.Cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cost.ForeColor = System.Drawing.Color.White;
            this.Cost.Location = new System.Drawing.Point(820, 705);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(149, 55);
            this.Cost.TabIndex = 5;
            // 
            // labelTotal
            // 
            this.labelTotal.ForeColor = System.Drawing.Color.White;
            this.labelTotal.Location = new System.Drawing.Point(529, 720);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(131, 40);
            this.labelTotal.TabIndex = 4;
            this.labelTotal.Text = "Total:";
            // 
            // butClear
            // 
            this.butClear.BackColor = System.Drawing.Color.Red;
            this.butClear.Location = new System.Drawing.Point(519, 774);
            this.butClear.Name = "butClear";
            this.butClear.Size = new System.Drawing.Size(450, 64);
            this.butClear.TabIndex = 3;
            this.butClear.Text = "Clear";
            this.butClear.UseVisualStyleBackColor = false;
            this.butClear.Click += new System.EventHandler(this.BtnClear);
            // 
            // butPlaceOrder
            // 
            this.butPlaceOrder.BackColor = System.Drawing.Color.Green;
            this.butPlaceOrder.Location = new System.Drawing.Point(519, 844);
            this.butPlaceOrder.Name = "butPlaceOrder";
            this.butPlaceOrder.Size = new System.Drawing.Size(450, 100);
            this.butPlaceOrder.TabIndex = 2;
            this.butPlaceOrder.Text = "Checkout";
            this.butPlaceOrder.UseVisualStyleBackColor = false;
            this.butPlaceOrder.Click += new System.EventHandler(this.butCheckout_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(6, 15);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(517, 929);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.checkBox11);
            this.tabPage1.Controls.Add(this.Welcome);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.Addons);
            this.tabPage1.Location = new System.Drawing.Point(10, 48);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(497, 871);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Coffee";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox11.Location = new System.Drawing.Point(13, 47);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(274, 50);
            this.checkBox11.TabIndex = 5;
            this.checkBox11.Text = "Coffee";
            this.checkBox11.UseVisualStyleBackColor = true;
            this.checkBox11.Click += new System.EventHandler(this.checkBoxCoffee);
            // 
            // Welcome
            // 
            this.Welcome.BackColor = System.Drawing.Color.SeaGreen;
            this.Welcome.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Welcome.Location = new System.Drawing.Point(39, 592);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(413, 152);
            this.Welcome.TabIndex = 4;
            this.Welcome.Text = "Welcome to Jean Cafe";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(347, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 42);
            this.label2.TabIndex = 3;
            this.label2.Text = "$2,00";
            // 
            // Addons
            // 
            this.Addons.Controls.Add(this.label7);
            this.Addons.Controls.Add(this.label6);
            this.Addons.Controls.Add(this.label5);
            this.Addons.Controls.Add(this.checkBoxCocoa);
            this.Addons.Controls.Add(this.checkBoxCinnamon);
            this.Addons.Controls.Add(this.checkBoxSugar);
            this.Addons.Controls.Add(this.checkBoxWhipped);
            this.Addons.Controls.Add(this.checkBoxCream);
            this.Addons.Location = new System.Drawing.Point(6, 148);
            this.Addons.Name = "Addons";
            this.Addons.Size = new System.Drawing.Size(485, 311);
            this.Addons.TabIndex = 1;
            this.Addons.TabStop = false;
            this.Addons.Text = "Addons";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(367, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 33);
            this.label7.TabIndex = 7;
            this.label7.Text = "$0.75";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(367, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 38);
            this.label6.TabIndex = 6;
            this.label6.Text = "$0.50";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(367, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 33);
            this.label5.TabIndex = 5;
            this.label5.Text = "$0.75";
            // 
            // checkBoxCocoa
            // 
            this.checkBoxCocoa.AutoSize = true;
            this.checkBoxCocoa.Location = new System.Drawing.Point(7, 219);
            this.checkBoxCocoa.Name = "checkBoxCocoa";
            this.checkBoxCocoa.Size = new System.Drawing.Size(135, 36);
            this.checkBoxCocoa.TabIndex = 4;
            this.checkBoxCocoa.Text = "Cocoa";
            this.checkBoxCocoa.UseVisualStyleBackColor = true;
            this.checkBoxCocoa.Click += new System.EventHandler(this.CheckBoxCocoa);
            // 
            // checkBoxCinnamon
            // 
            this.checkBoxCinnamon.AutoSize = true;
            this.checkBoxCinnamon.Location = new System.Drawing.Point(7, 177);
            this.checkBoxCinnamon.Name = "checkBoxCinnamon";
            this.checkBoxCinnamon.Size = new System.Drawing.Size(183, 36);
            this.checkBoxCinnamon.TabIndex = 3;
            this.checkBoxCinnamon.Text = "Cinnamon";
            this.checkBoxCinnamon.UseVisualStyleBackColor = true;
            this.checkBoxCinnamon.Click += new System.EventHandler(this.CheckBoxCinnamon);
            // 
            // checkBoxSugar
            // 
            this.checkBoxSugar.AutoSize = true;
            this.checkBoxSugar.Location = new System.Drawing.Point(7, 93);
            this.checkBoxSugar.Name = "checkBoxSugar";
            this.checkBoxSugar.Size = new System.Drawing.Size(129, 36);
            this.checkBoxSugar.TabIndex = 2;
            this.checkBoxSugar.Text = "Sugar";
            this.checkBoxSugar.UseVisualStyleBackColor = true;
            this.checkBoxSugar.Click += new System.EventHandler(this.CheckBoxSugar);
            // 
            // checkBoxWhipped
            // 
            this.checkBoxWhipped.AutoSize = true;
            this.checkBoxWhipped.Location = new System.Drawing.Point(7, 135);
            this.checkBoxWhipped.Name = "checkBoxWhipped";
            this.checkBoxWhipped.Size = new System.Drawing.Size(257, 36);
            this.checkBoxWhipped.TabIndex = 1;
            this.checkBoxWhipped.Text = "Whipped Cream";
            this.checkBoxWhipped.UseVisualStyleBackColor = true;
            this.checkBoxWhipped.Click += new System.EventHandler(this.CheckBoxWhipped);
            // 
            // checkBoxCream
            // 
            this.checkBoxCream.AutoSize = true;
            this.checkBoxCream.Location = new System.Drawing.Point(7, 51);
            this.checkBoxCream.Name = "checkBoxCream";
            this.checkBoxCream.Size = new System.Drawing.Size(137, 36);
            this.checkBoxCream.TabIndex = 0;
            this.checkBoxCream.Text = "Cream";
            this.checkBoxCream.UseVisualStyleBackColor = true;
            this.checkBoxCream.Click += new System.EventHandler(this.CheckBoxCream);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkBox12);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(10, 48);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(497, 871);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tea";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox12.Location = new System.Drawing.Point(48, 48);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(129, 50);
            this.checkBox12.TabIndex = 6;
            this.checkBox12.Text = "Tea";
            this.checkBox12.UseVisualStyleBackColor = true;
            this.checkBox12.Click += new System.EventHandler(this.checkBoxTea);
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.SeaGreen;
            this.label21.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label21.Location = new System.Drawing.Point(36, 545);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(413, 152);
            this.label21.TabIndex = 5;
            this.label21.Text = "Welcome to Jean Cafe";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.checkBoxWhippedTea);
            this.groupBox3.Controls.Add(this.checkBoxSugarTea);
            this.groupBox3.Controls.Add(this.checkBoxCreamTea);
            this.groupBox3.Location = new System.Drawing.Point(41, 140);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(423, 226);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Addons";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(296, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 33);
            this.label8.TabIndex = 3;
            this.label8.Text = "$0.75";
            // 
            // checkBoxWhippedTea
            // 
            this.checkBoxWhippedTea.AutoSize = true;
            this.checkBoxWhippedTea.Location = new System.Drawing.Point(7, 124);
            this.checkBoxWhippedTea.Name = "checkBoxWhippedTea";
            this.checkBoxWhippedTea.Size = new System.Drawing.Size(257, 36);
            this.checkBoxWhippedTea.TabIndex = 2;
            this.checkBoxWhippedTea.Text = "Whipped Cream";
            this.checkBoxWhippedTea.UseVisualStyleBackColor = true;
            this.checkBoxWhippedTea.Click += new System.EventHandler(this.CheckBoxWhippedTea);
            // 
            // checkBoxSugarTea
            // 
            this.checkBoxSugarTea.AutoSize = true;
            this.checkBoxSugarTea.Location = new System.Drawing.Point(7, 81);
            this.checkBoxSugarTea.Name = "checkBoxSugarTea";
            this.checkBoxSugarTea.Size = new System.Drawing.Size(129, 36);
            this.checkBoxSugarTea.TabIndex = 1;
            this.checkBoxSugarTea.Text = "Sugar";
            this.checkBoxSugarTea.UseVisualStyleBackColor = true;
            this.checkBoxSugarTea.Click += new System.EventHandler(this.CheckBoxSugarTea);
            // 
            // checkBoxCreamTea
            // 
            this.checkBoxCreamTea.AutoSize = true;
            this.checkBoxCreamTea.Location = new System.Drawing.Point(7, 38);
            this.checkBoxCreamTea.Name = "checkBoxCreamTea";
            this.checkBoxCreamTea.Size = new System.Drawing.Size(137, 36);
            this.checkBoxCreamTea.TabIndex = 0;
            this.checkBoxCreamTea.Text = "Cream";
            this.checkBoxCreamTea.UseVisualStyleBackColor = true;
            this.checkBoxCreamTea.Click += new System.EventHandler(this.CheckBoxCreamTea);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(313, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 49);
            this.label4.TabIndex = 1;
            this.label4.Text = "$2.45";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label22);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Location = new System.Drawing.Point(10, 48);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(497, 871);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Pastries";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.SeaGreen;
            this.label22.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label22.Location = new System.Drawing.Point(36, 614);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(413, 152);
            this.label22.TabIndex = 5;
            this.label22.Text = "Welcome to Jean Cafe";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.checkBox10);
            this.groupBox4.Controls.Add(this.checkBox9);
            this.groupBox4.Controls.Add(this.checkBox8);
            this.groupBox4.Controls.Add(this.checkBox7);
            this.groupBox4.Controls.Add(this.checkBox6);
            this.groupBox4.Controls.Add(this.checkBox5);
            this.groupBox4.Controls.Add(this.checkBox4);
            this.groupBox4.Controls.Add(this.checkBox3);
            this.groupBox4.Controls.Add(this.checkBox2);
            this.groupBox4.Controls.Add(this.checkBox1);
            this.groupBox4.Location = new System.Drawing.Point(6, 43);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(466, 492);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Menu";
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(343, 425);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 34);
            this.label18.TabIndex = 18;
            this.label18.Text = "$2.95";
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(343, 384);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 34);
            this.label17.TabIndex = 17;
            this.label17.Text = "$3.95";
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(343, 341);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 34);
            this.label16.TabIndex = 16;
            this.label16.Text = "$2.95";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(343, 296);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 34);
            this.label15.TabIndex = 11;
            this.label15.Text = "$2.75";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(343, 255);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 34);
            this.label14.TabIndex = 15;
            this.label14.Text = "$2.95";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(343, 210);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 34);
            this.label13.TabIndex = 14;
            this.label13.Text = "$2.95";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(343, 169);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 34);
            this.label12.TabIndex = 13;
            this.label12.Text = "$1.95";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(343, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 34);
            this.label11.TabIndex = 12;
            this.label11.Text = "$2.95";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(343, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 34);
            this.label10.TabIndex = 11;
            this.label10.Text = "$3.25";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(343, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 34);
            this.label9.TabIndex = 10;
            this.label9.Text = "$2.95";
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(7, 425);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(309, 36);
            this.checkBox10.TabIndex = 9;
            this.checkBox10.Text = "Classic Coffee Cake";
            this.checkBox10.UseVisualStyleBackColor = true;
            this.checkBox10.Click += new System.EventHandler(this.CheckBox10);
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(7, 382);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(309, 36);
            this.checkBox9.TabIndex = 8;
            this.checkBox9.Text = "Chocolate Croissant";
            this.checkBox9.UseVisualStyleBackColor = true;
            this.checkBox9.Click += new System.EventHandler(this.CheckBox9);
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(7, 339);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(344, 36);
            this.checkBox8.TabIndex = 7;
            this.checkBox8.Text = "Chocolate Chip Cookie";
            this.checkBox8.UseVisualStyleBackColor = true;
            this.checkBox8.Click += new System.EventHandler(this.CheckBox8);
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(7, 296);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(256, 36);
            this.checkBox7.TabIndex = 6;
            this.checkBox7.Text = "Butter Croissant";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.Click += new System.EventHandler(this.CheckBox7);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(7, 253);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(247, 36);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Text = "Cheese Danish";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.Click += new System.EventHandler(this.CheckBox6);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(7, 210);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(263, 36);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "Blueberry Scone";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.Click += new System.EventHandler(this.CheckBox5);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(7, 167);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(208, 36);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Apple Fritter";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.Click += new System.EventHandler(this.CheckBox4);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(7, 124);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(284, 36);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Almoind Croissant";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.Click += new System.EventHandler(this.CheckBox3);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(7, 81);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(205, 36);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "8-Grain Roll";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Click += new System.EventHandler(this.CheckBox2);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 38);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(234, 36);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Chonga Bagel";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Click += new System.EventHandler(this.CheckBox1);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Location = new System.Drawing.Point(529, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(434, 639);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 31;
            this.listBox1.Location = new System.Drawing.Point(0, 48);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(434, 589);
            this.listBox1.TabIndex = 3;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("MS Office Symbol Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(323, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(111, 48);
            this.label20.TabIndex = 2;
            this.label20.Text = "Price";
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("MS Office Symbol Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(0, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(246, 48);
            this.label19.TabIndex = 1;
            this.label19.Text = "ltem";
            // 
            // JeanCafe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(984, 968);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "JeanCafe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jean Cafe";
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.Addons.ResumeLayout(false);
            this.Addons.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button butClear;
        private System.Windows.Forms.Button butPlaceOrder;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label Cost;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox Addons;
        private System.Windows.Forms.CheckBox checkBoxCocoa;
        private System.Windows.Forms.CheckBox checkBoxCinnamon;
        private System.Windows.Forms.CheckBox checkBoxSugar;
        private System.Windows.Forms.CheckBox checkBoxWhipped;
        private System.Windows.Forms.CheckBox checkBoxCream;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBoxWhippedTea;
        private System.Windows.Forms.CheckBox checkBoxSugarTea;
        private System.Windows.Forms.CheckBox checkBoxCreamTea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox12;
    }
}

