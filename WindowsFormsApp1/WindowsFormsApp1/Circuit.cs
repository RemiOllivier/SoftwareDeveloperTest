using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.Windows.Controls;

namespace WindowsFormsApp1
{
    public class Circuit
    {
        public static List<IElement> ElementList = new List<IElement>();
        static List<double> Frequencies = new List<double> { 1, 2, 3 };
        public static Form1 form1;

        public static List<double> GetFrequencies()
        {
            return Frequencies;
        }

        public static void SetFrequencies(List<double> frequencies)
        {
            Frequencies=frequencies;
        }

        public static List<IElement> GetElementList()
        {
            return ElementList;
        }
        public static void SetElementList(List<IElement> elementList)
        {
            ElementList=elementList;
        }


        static void Main()
        {
            List<IElement> ElementList2 = new List<IElement>();
            ElementList2.Add(new Resistor("resistor1", 1));
            ElementList2.Add(new Resistor("resistor2", 1));
            ElementList2.Add(new Resistor("resistor3", 1));
            ElementList2.Add(new Resistor("resistor4", 1));
            ElementList2.Add(new Resistor("resistor5", 1));
            Circuit.SetElementList(ElementList2);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(form1=new Form1()); 
        }

        public static List<Complex> CalculateZ(List<double> frequencies)
        {
            List<Complex> ZResult = new List<Complex>();
            List<IElement> ElementList = GetElementList();
            foreach (double freq in frequencies)
            {
                Complex Total = new Complex(0, 0);
                foreach (IElement element in ElementList) {
                    Total = Total + element.CalculateZ(freq);
                }
                ZResult.Add(Total);
            }
            return ZResult;
        }

        public static void CircuitChanged()
        {
            List<double> Frequencies = GetFrequencies();
            try
            {
                Frequencies[0] = Convert.ToDouble(form1.textBox3.Text);
            }
            catch
            {
                Frequencies[0] = 0;
            }
            try
            {
                Frequencies[1] = Convert.ToDouble(form1.textBox2.Text);
            }
            catch
            {
                Frequencies[1] = 0;
            }
            try
            {
                Frequencies[2] = Convert.ToDouble(form1.textBox1.Text);
            }
            catch
            {
                Frequencies[2] = 0;
            }
            SetFrequencies(Frequencies);
            //CircuitInitialization();

            List<Complex> ZResult = CalculateZ(GetFrequencies());
            string Text = "";
            foreach (Complex result in ZResult)
            {
                Text = Text + Convert.ToString(result.Real) + " + "+ Convert.ToString(result.Imaginary)+ " j" + "\n\n\n";
            }
            form1.label3.Text = Text;
        }
    }
}
