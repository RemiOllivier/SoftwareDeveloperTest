using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.Windows.Controls;


namespace WindowsFormsApp1
{
    public class Inductor : IElement
    {
        private string name;
        private double value;
        public Inductor(string name, double value)
        {
            this.name = name;
            this.value = value;
        }

        public string Name
        {
            get { return name; }
        }

        public double Value
        {
            get { return value; }
        }

        public void ValueChanged(double a)
        {
            value = a;
        }
        public Complex CalculateZ(double frequencies)
        {
            return new Complex(0, Math.Round(value * 2 * 3.14 * frequencies, 2));
        }
    }

}