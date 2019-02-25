using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVP.Models;
using MVP.Views;

namespace MVP.Presenters
{
    public class RectanglePresenter
    {
        IRectangle rectangleView;

        public RectanglePresenter(IRectangle view)
        {
            rectangleView = view;
        }
        public void Calc()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.A = double.Parse(rectangleView.Atext);
            rectangle.B = double.Parse(rectangleView.Btext);

            rectangleView.Restext = rectangle.calc().ToString();
        }
    }
}
