using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trtpo_fractal_lab1
{
    public class Complex
    {
        private double re;
        private double im;

        public double Re { get => re; set => re = value; }
        public double Im { get => im; set => im = value; }

        public Complex(double rl, double ig)
        {
            Re = rl;
            Im = ig;
        }
        public static Complex operator +(Complex a, Complex b) => new Complex(a.Re + b.Re, a.Im + b.Im);
        public static Complex operator -(Complex a, Complex b) => new Complex(a.Re - b.Re, a.Im - b.Im);
        public static Complex operator *(Complex a, Complex b) => new Complex(a.Re * b.Re - a.Im * b.Im, 2 * a.Re * b.Im);
        public double getAbs() => Re * Re + Im * Im;
        public Complex sqr() => new Complex(Re * Re - Im * Im, 2 * Re * Im);
        
    }
}
