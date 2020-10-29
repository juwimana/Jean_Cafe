using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jean_Cafe
{
    public partial class JeanCafe : Form
    {
        double total;

        public JeanCafe()
        {
            InitializeComponent();
        }

        private void checkBoxTea(object sender, EventArgs e)
        {
            listBox1.Items.Add(checkBox12.Text + "                                  " + "$2.45");
            total += 2.45;
            this.Cost.Text = total.ToString("C");
        }
        private void checkBoxCoffee(object sender, EventArgs e)
        {
            listBox1.Items.Add(checkBox11.Text + "                              " + "$2.00");
            total += 2.00;
            this.Cost.Text = total.ToString("C");
        }
        private void CheckBoxCinnamon(object sender, EventArgs e)
        {
            listBox1.Items.Add(checkBoxCinnamon.Text + "                         " + "$0.50");
            total += 0.50;
            this.Cost.Text = total.ToString("C");
        }

        private void CheckBoxWhipped(object sender, EventArgs e)
        {
            listBox1.Items.Add(checkBoxWhipped.Text + "               " + "$0.75");
            total += 0.75;
            this.Cost.Text = total.ToString("C");
        }

        private void CheckBoxSugar(object sender, EventArgs e)
        {
            listBox1.Items.Add(checkBoxSugar.Text);
        }

        private void CheckBoxCream(object sender, EventArgs e)
        {
            listBox1.Items.Add(checkBoxCream.Text);
        }

        private void CheckBoxCocoa(object sender, EventArgs e)
        {
            listBox1.Items.Add(checkBoxCocoa.Text + "                              " + "$0.75");
            total += 0.75;
            this.Cost.Text = total.ToString("C");
        }
        private void CheckBoxCreamTea(object sender, EventArgs e)
        {
            listBox1.Items.Add(checkBoxCreamTea.Text);
        }

        private void CheckBoxSugarTea(object sender, EventArgs e)
        {
            listBox1.Items.Add(checkBoxSugarTea.Text);
        }

        private void CheckBoxWhippedTea(object sender, EventArgs e)
        {
            listBox1.Items.Add(checkBoxWhippedTea.Text + "               " + "$0.75");
            total += 0.75;
            this.Cost.Text = total.ToString("C");
        }

        private void CheckBox1(object sender, EventArgs e)
        {
            listBox1.Items.Add(checkBox1.Text + "                  " + "$2.95");
            total += 2.95;
            this.Cost.Text = total.ToString("C");
        }

        private void CheckBox2(object sender, EventArgs e)
        {
            listBox1.Items.Add(checkBox2.Text + "                      " + "$3.25");
            total += 3.25;
            this.Cost.Text = total.ToString("C");
        }

        private void CheckBox3(object sender, EventArgs e)
        {
            listBox1.Items.Add(checkBox3.Text + "             " + "$2.95");
            total += 2.95;
            this.Cost.Text = total.ToString("C");
        }

        private void CheckBox4(object sender, EventArgs e)
        {
            listBox1.Items.Add(checkBox4.Text + "                      " + "$1.95");
            total += 1.95;
            this.Cost.Text = total.ToString("C");
        }

        private void CheckBox5(object sender, EventArgs e)
        {
            listBox1.Items.Add(checkBox5.Text + "               " + "$2.95");
            total += 2.95;
            this.Cost.Text = total.ToString("C");
        }

        private void CheckBox6(object sender, EventArgs e)
        {
            listBox1.Items.Add(checkBox6.Text + "                 " + "$2.95");
            total += 2.95;
            this.Cost.Text = total.ToString("C");
        }

        private void CheckBox7(object sender, EventArgs e)
        {
            listBox1.Items.Add(checkBox7.Text + "                " + "$2.75");
            total += 2.75;
            this.Cost.Text = total.ToString("C");
        }

        private void CheckBox8(object sender, EventArgs e)
        {
            listBox1.Items.Add(checkBox8.Text + "     " + "$2.95");
            total += 2.95;
            this.Cost.Text = total.ToString("C");
        }

        private void CheckBox9(object sender, EventArgs e)
        {
            listBox1.Items.Add(checkBox9.Text + "          " + "$3.95");
            total += 3.95;
            this.Cost.Text = total.ToString("C");
        }

        private void CheckBox10(object sender, EventArgs e)
        {
            listBox1.Items.Add(checkBox10.Text + "          " + "$2.95");
            total += 2.95;
            this.Cost.Text = total.ToString("C");
        }
        public void ClearCheckBox()
        {
            this.checkBox11.Checked = false;
            this.checkBoxCream.Checked = false;
            this.checkBoxSugar.Checked = false;
            this.checkBoxWhipped.Checked = false;
            this.checkBoxCinnamon.Checked = false;
            this.checkBoxCocoa.Checked = false;
            this.checkBoxCreamTea.Checked = false;
            this.checkBoxSugarTea.Checked = false;
            this.checkBoxWhippedTea.Checked = false;
            this.checkBox1.Checked = false;
            this.checkBox2.Checked = false;
            this.checkBox3.Checked = false;
            this.checkBox4.Checked = false;
            this.checkBox5.Checked = false;
            this.checkBox6.Checked = false;
            this.checkBox7.Checked = false;
            this.checkBox8.Checked = false;
            this.checkBox9.Checked = false;
            this.checkBox10.Checked = false;
        }

        private void BtnClear(object sender, EventArgs e)
        {
            string a = checkBoxWhipped.Text + "               " + "$0.75",
                   b = checkBox12.Text + "                                  " + "$2.45",
                   c = checkBox11.Text + "                              " + "$2.00",
                   d = checkBoxCinnamon.Text + "                         " + "$0.50",
                   f = checkBoxCocoa.Text + "                              " + "$0.75",
                   g = checkBoxWhippedTea.Text + "               " + "$0.75",
                   h = checkBox1.Text + "                  " + "$2.95",
                   i = checkBox2.Text + "                      " + "$3.25",
                   j = checkBox3.Text + "             " + "$2.95",
                   k = checkBox4.Text + "                      " + "$1.95",
                   l = checkBox5.Text + "               " + "$2.95",
                   m = checkBox6.Text + "                 " + "$2.95",
                   n = checkBox7.Text + "                " + "$2.75",
                   o = checkBox8.Text + "     " + "$2.95",
                   p = checkBox9.Text + "          " + "$3.95",
                   q = checkBox10.Text + "          " + "$2.95";


            switch (listBox1.SelectedItem.ToString())
            {
                case "a":
                    {
                        listBox1.Items.Remove(listBox1.SelectedItem);
                        total -= 0.75;
                        this.Cost.Text = total.ToString("C");
                        ClearCheckBox();
                        break;
                    }
                case "b":
                    {
                        listBox1.Items.Remove(listBox1.SelectedItem);
                        total -= 2.45;
                        this.Cost.Text = total.ToString("C");
                        ClearCheckBox();
                        break;
                    }
                case "c":
                    {
                        listBox1.Items.Remove(listBox1.SelectedItem);
                        total -= 2.00;
                        this.Cost.Text = total.ToString("C");
                        ClearCheckBox();
                        break;
                    }
                case "d":
                    {
                        listBox1.Items.Remove(listBox1.SelectedItem);
                        total -= 0.50;
                        this.Cost.Text = total.ToString("C");
                        ClearCheckBox();
                        break;
                    }
                case "f":
                    {
                        listBox1.Items.Remove(listBox1.SelectedItem);
                        total -= 0.75;
                        this.Cost.Text = total.ToString("C");
                        ClearCheckBox();
                        break;
                    }
                case "g":
                    {
                        listBox1.Items.Remove(listBox1.SelectedItem);
                        total -= 0.75;
                        this.Cost.Text = total.ToString("C");
                        ClearCheckBox();
                        break;
                    }
                case "h":
                    {
                        listBox1.Items.Remove(listBox1.SelectedItem);
                        total -= 2.95;
                        this.Cost.Text = total.ToString("C");
                        ClearCheckBox();
                        break;
                    }
                case "i":
                    {
                        listBox1.Items.Remove(listBox1.SelectedItem);
                        total -= 3.25;
                        this.Cost.Text = total.ToString("C");
                        ClearCheckBox();
                        break;
                    }
                case "j":
                    {
                        listBox1.Items.Remove(listBox1.SelectedItem);
                        total -= 2.95;
                        this.Cost.Text = total.ToString("C");
                        ClearCheckBox();
                        break;
                    }
                case "k":
                    {
                        listBox1.Items.Remove(listBox1.SelectedItem);
                        total -= 1.95;
                        this.Cost.Text = total.ToString("C");
                        ClearCheckBox();
                        break;
                    }
                case "l":
                    {
                        listBox1.Items.Remove(listBox1.SelectedItem);
                        total -= 2.95;
                        this.Cost.Text = total.ToString("C");
                        ClearCheckBox();
                        break;
                    }
                case "m":
                    {
                        listBox1.Items.Remove(listBox1.SelectedItem);
                        total -= 2.95;
                        Cost.Text = total.ToString("C");
                        ClearCheckBox();
                        break;
                    }
                case "n":
                    {
                        listBox1.Items.Remove(listBox1.SelectedItem);
                        total -= 2.75;
                        this.Cost.Text = total.ToString("C");
                        ClearCheckBox();
                        break;
                    }
                case "o":
                    {
                        listBox1.Items.Remove(listBox1.SelectedItem);
                        total -= 2.95;
                        this.Cost.Text = total.ToString("C");
                        ClearCheckBox();
                        break;
                    }
                case "p":
                    {
                        listBox1.Items.Remove(listBox1.SelectedItem);
                        total -= 3.95;
                        this.Cost.Text = total.ToString("C");
                        ClearCheckBox();

                        break;
                    }
                case "q":
                    {
                        listBox1.Items.Remove(listBox1.SelectedItem);
                        total -= 2.95;
                        this.Cost.Text = total.ToString("C");
                        ClearCheckBox();
                        break;
                    }
                default:
                    {
                        listBox1.Items.Remove(listBox1.SelectedItem);
                        this.ClearCheckBox();
                        break;
                    } 
            }
        }
        private void butCheckout_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            ClearCheckBox();
            MessageBox.Show("Total:"+Cost.Text+ "\n\n"+ "THANK YOU FOR SHOPPING AT JEAN CAFE");
        }

    }
}

