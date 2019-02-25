using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Models
{
    public class Rectangle
    {
        public double  A { get; set; }
    public double B { get; set; }

        public double calc()
        {
            return A * B;
        }
    }
}
