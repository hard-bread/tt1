using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaussNumbersLibrary
{
    public struct GaussNumber
    {
        private double _re;
        private double _im;

        public double Re
        {
            get => _re;
            set
            {
                if (double.IsNaN(value)) throw new ArgumentException("Invalid value for Re");
                _re = value;
            }
        }

        public double Im
        {
            get => _im;
            set
            {
                if (double.IsNaN(value)) throw new ArgumentException("Invalid value for Im");
                _im = value;
            }
        }

        public double Norm => _re * _re + _im * _im;

        public GaussNumber(double re, double im)
        {
            if (double.IsNaN(re) || double.IsNaN(im))
                throw new ArgumentException("Invalid values for GaussNumber");
            _re = re;
            _im = im;
        }

        public override string ToString()
        {
            if (_re == 0 && _im == 0) return "0";
            if (_im == 0) return _re.ToString();
            if (_re == 0) return $"{_im}i";
            if (_im == 1) return $"{_re}+i";
            if (_im == -1) return $"{_re}-i";
            return $"{_re}{(_im > 0 ? "+" : "")}{_im}i";
        }

        public override bool Equals(object obj)
        {
            if (obj is GaussNumber other)
            {
                return Math.Abs(Re - other.Re) < 1e-13 && Math.Abs(Im - other.Im) < 1e-13;
            }
            return false;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + Re.GetHashCode();
                hash = hash * 23 + Im.GetHashCode();
                return hash;
            }
        }

        public static GaussNumber operator ~(GaussNumber g)
        {
            return new GaussNumber(g.Re, -g.Im);
        }

        public static GaussNumber operator +(GaussNumber g1, GaussNumber g2)
        {
            return new GaussNumber(g1.Re + g2.Re, g1.Im + g2.Im);
        }

        public static GaussNumber operator *(GaussNumber g1, GaussNumber g2)
        {
            return new GaussNumber(
                g1.Re * g2.Re - g1.Im * g2.Im,
                g1.Re * g2.Im + g1.Im * g2.Re);
        }
    }
}
