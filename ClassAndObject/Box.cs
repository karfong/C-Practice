using System;
using System.Collections.Generic;
using System.Text;

namespace ClassAndObject
{
    class Box
    {
        private int length;
        private int width;
        private int height;

        public Box(int l)
        {
            length = l;
            width = 0;
            height = 0;
            Console.WriteLine("Line created with"+length);
        }

        public Box(int l,int w)
        {
            length =l;
            width = w;
            height = 0;
            Console.WriteLine("Rectangle created with"+length+"and"+width);
        }


        public Box(int l,int w,int h)
        {
            length = l;
            width = w;
            height = h;
            Console.WriteLine("Box created with"+length+"and"+width+"and"+height);
        }
        
    }
}
