using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;


namespace laba4._1_OOP
{
    class CCircle
    {
        public int x, y, r = 15;
        public bool selected;

        public CCircle(MouseEventArgs a)
        {
            x = a.X;
            y = a.Y;
        }
        public void Paint()
        {

        }
        public void Check()
        {

        }
        public bool isSelected()
        {
            return selected;
        }
    }
}
