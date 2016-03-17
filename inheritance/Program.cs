using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    // program >> normal or single inheritance
    //base class
    class baseClass
    {
        protected float length; // have to make variables protected or public else derived class will not be able to inherit gives protection level error
        protected float width;
        protected float height;
        // setting length
        public void setLength(float len)
        {
            length = len;
        }
        // setting width
        public void setWidth(float wid)
        {
            width = wid;
        }
        // setting height
        public void setHeight(float hei)
        {
            height = hei;
        }
    }

    class derivedClass : baseClass  //derived class inherits variables of base class so i declare area function in derived class which use base class variables
    {
        public float getArea()
        {
            return (length * width * height);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            derivedClass obj = new derivedClass(); // declare object of derived class to know if it inherits
            obj.setLength(2);
            obj.setWidth(2);
            obj.setHeight(2);
            obj.getArea(); // expected output 2*2*2=8
            Console.Out.WriteLine("Area = "+obj.getArea());
            Console.ReadLine();
        }
    }
}
