using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocjena
{
    class Brojevi
    {
        double Broj;

        public double broj { get => Broj; set => Broj = value; }

        public virtual double apsVrijednost()
        {
            return 0; 
        }

    }
    class Cijeli : Brojevi
    {
        public override double apsVrijednost()
        {
            return Math.Abs(broj);
        }
    }
    class Decimalni : Brojevi
    {
        public override double apsVrijednost()
        {
            return Math.Abs(broj);
        }

    }
    class Pozitivni : Cijeli
    {
        public override double apsVrijednost()
        {
            return Math.Abs(broj);
        }

    }
    class Negativni : Cijeli
    {
        public override double apsVrijednost()
        {
            return Math.Abs(broj);
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Pozitivni x = new Pozitivni();
            Negativni y = new Negativni();
            Decimalni z = new Decimalni();

            x.broj = 100;
            y.broj = -100;
            z.broj = 100.45;

            Console.WriteLine(x.apsVrijednost());
            Console.WriteLine(y.apsVrijednost());
            Console.WriteLine(z.apsVrijednost());

            Console.ReadKey();

        }
    }
}
