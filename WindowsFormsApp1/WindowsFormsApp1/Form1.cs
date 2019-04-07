using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.Windows.Controls;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeComponent();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void Form1_Leave(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void ToolTip1_Popup(object sender, PopupEventArgs e)
        {
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Circuit.CircuitChanged();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
           
                Circuit.CircuitChanged();
            
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
           
                Circuit.CircuitChanged();
            
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
                Circuit.CircuitChanged();   
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
            List<IElement> ElementList = Circuit.GetElementList();
            try
            {
                ElementList[0].ValueChanged(Convert.ToDouble(textBox4.Text));
            }
            catch
            {
                ElementList[0].ValueChanged(0);
            }
            Circuit.CircuitChanged();
        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {
            List<IElement> ElementList = Circuit.GetElementList();
            try
            {
                ElementList[1].ValueChanged(Convert.ToDouble(textBox5.Text));
            }
            catch
            {
                ElementList[1].ValueChanged(0);
            }
            Circuit.CircuitChanged();

        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {
            List<IElement> ElementList = Circuit.GetElementList();
            try
            {
                ElementList[2].ValueChanged(Convert.ToDouble(textBox6.Text));
            }
            catch
            {
                ElementList[2].ValueChanged(0);
            }
            Circuit.CircuitChanged();

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text=="Circuit 1") {
                List<IElement> ElementList = new List<IElement>();
                ElementList.Add(new Resistor("resistor1", 1));
                ElementList.Add(new Inductor("inductor1", 1));
                ElementList.Add(new Capacitor("capacitor1", 1));
                ElementList.Add(new Resistor("resistor2", 1));
                Circuit.SetElementList(ElementList);
                textBox4.Text = "1";
                textBox5.Text = "1";
                textBox6.Text = "1";
                textBox7.Text = "1";
                textBox8.Text = "";
                label5.Text = "R1";
                label6.Text = "L1";
                label7.Text = "C1";
                label10.Text = "R2";
                label9.Text = "";
                label11.Text = "-----  R1  ----  L1  ----  C1  ----  R2  -----";
                Circuit.CircuitChanged();
            }
            else if (comboBox1.Text == "Circuit 2")
            {
                List<IElement> ElementList = new List<IElement>();
                ElementList.Add(new Resistor("resistor1", 1));
                ElementList.Add(new Resistor("resistor2", 1));
                ElementList.Add(new Resistor("resistor3", 1));
                ElementList.Add(new Resistor("resistor4", 1));
                ElementList.Add(new Resistor("resistor5", 1));
                Circuit.SetElementList(ElementList);
                textBox4.Text = "1";
                textBox5.Text = "1";
                textBox6.Text = "1";
                textBox7.Text = "1";
                textBox8.Text = "1";
                label5.Text = "R1";
                label6.Text = "R2";
                label7.Text = "R3";
                label10.Text = "R4";
                label9.Text = "R5";
                label11.Text = "-----  R1  ----  R2  ----  R3  ----  R4  ----  R5  -----";
                Circuit.CircuitChanged();
            }
            else if (comboBox1.Text == "Circuit 3")
            {
                List<IElement> ElementList = new List<IElement>();
                ElementList.Add(new Inductor("inductor1", 1));
                ElementList.Add(new Inductor("inductor2", 1));
                ElementList.Add(new Inductor("inductor3", 1));
                ElementList.Add(new Inductor("inductor4", 1));
                ElementList.Add(new Inductor("inductor5", 1));
                Circuit.SetElementList(ElementList);
                textBox4.Text = "1";
                textBox5.Text = "1";
                textBox6.Text = "1";
                textBox7.Text = "1";
                textBox8.Text = "1";
                label5.Text = "L1";
                label6.Text = "L2";
                label7.Text = "L3";
                label10.Text = "L4";
                label9.Text = "L5";
                label11.Text = "-----  L1  ----  L2  ----  L3  ----  L4  ----  L5  -----";
                Circuit.CircuitChanged();
            }
            else if (comboBox1.Text == "Circuit 4")
            {
                List<IElement> ElementList = new List<IElement>();
                ElementList.Add(new Capacitor("capacitor1", 1));
                ElementList.Add(new Capacitor("capacitor2", 1));
                ElementList.Add(new Capacitor("capacitor3", 1));
                ElementList.Add(new Capacitor("capacitor4", 1));
                ElementList.Add(new Capacitor("capacitor5", 1));
                Circuit.SetElementList(ElementList);
                textBox4.Text = "1";
                textBox5.Text = "1";
                textBox6.Text = "1";
                textBox7.Text = "1";
                textBox8.Text = "1";
                label5.Text = "C1";
                label6.Text = "C2";
                label7.Text = "C3";
                label9.Text = "C5";
                label10.Text = "C4";
                label11.Text = "-----  C1  ----  C2  ----  C3  ----  C4  ----  C5  -----";
                Circuit.CircuitChanged();
            }
            else if (comboBox1.Text == "Circuit 5")
            {
                List<IElement> ElementList = new List<IElement>();
                ElementList.Add(new Resistor("resistor1", 1));
                ElementList.Add(new Capacitor("capacitor1", 1));
                ElementList.Add(new Resistor("resistor2", 1));
                Circuit.SetElementList(ElementList);
                textBox4.Text = "1";
                textBox5.Text = "1";
                textBox6.Text = "1";
                textBox7.Text = "";
                textBox8.Text = "";
                label5.Text = "R1";
                label6.Text = "C1";
                label7.Text = "R2";
                label9.Text = "";
                label10.Text = "";
                label11.Text = "-----  R1  ----  C1  ----  R2  -----";
                Circuit.CircuitChanged();
            }
        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {
            List<IElement> ElementList = Circuit.GetElementList();
            try
            {
                try
                {
                    ElementList[3].ValueChanged(Convert.ToDouble(textBox7.Text));
                }
                catch
                {
                    ElementList[3].ValueChanged(0);
                }
            }
            catch
            {

            }
            Circuit.CircuitChanged();
        }

        private void TextBox8_TextChanged(object sender, EventArgs e)
        {
            List<IElement> ElementList = Circuit.GetElementList();
            try
            {
                try
                {
                    ElementList[4].ValueChanged(Convert.ToDouble(textBox8.Text));
                }
                catch
                {
                    ElementList[4].ValueChanged(0);
                }
            }
            catch
            {

            }
           
            Circuit.CircuitChanged();
        }
    }
}
