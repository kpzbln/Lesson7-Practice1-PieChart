using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_Practice1_PieChart
{
    internal class PieChartElement
    {
        public string name;
        public float value;

        public PieChartElement()
        {
        }

        public PieChartElement(string _name, float _value)
        {
            name = _name;
            value = _value;
        }
    }
}
