using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.Windows.Controls;

namespace WindowsFormsApp1
{
    public interface IElement
    {

        string Name { get; }
        double Value { get; }
        void ValueChanged(double a);
        Complex CalculateZ(double freq);
        
    }
}