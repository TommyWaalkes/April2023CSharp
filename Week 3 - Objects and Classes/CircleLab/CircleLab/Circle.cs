using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleLab
{
    class Circle
    {
        //1) Properties 
        //2) Construtor 
        //3) Methods

        public double Radius { get; set; }

        public Circle(double Radius)
        {
            this.Radius = Radius;
        }

        public double CalculateDiameter()
        {
            return Radius * 2;
        }

        public double CalculateCircumference()
        {
            return Math.PI * Radius * 2;
        }

        public double CalculateArea()
        {
            //You could also use Math.Pow() 
            return Math.PI * Radius * Radius;
        }

        public void Grow()
        {
            Radius *= 2;
        }

        public override string ToString()
        {
            string output = "";
            output +="Radius: " + Radius + "\n";
            output += "Diameter: " + CalculateDiameter() +"\n";
            output += "Area: " + CalculateArea() + "\n";
            output += "Circumference: " + CalculateCircumference();

            return output;
        }
    }
}
