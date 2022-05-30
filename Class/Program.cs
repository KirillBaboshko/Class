using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
	class Fraction
	{
		private int numerator;
		private int denumerator;

		public Fraction(int numerator = 0, int denumerator = 1)
		{
			this.numerator = numerator;
			if (denumerator != 0)
			{
				this.denumerator = denumerator;
			}
			else
				this.denumerator = 1;

		}
		public void setdernumerator(int denumerator)
		{
			if (denumerator != 0)
			{
				this.denumerator = denumerator;
			}
			else
				this.denumerator = 1;
		}
		public void setnumerator(int numerator)
		{
			this.numerator = numerator;

		}
		public int getnumerator() { return numerator; }
		public int getdernumerator() { return denumerator; }
		public void print()
		{
			WriteLine($"{numerator} / {denumerator} \n");
		}

		public static Fraction add(Fraction fodj1, Fraction fodj2)
		{
			Fraction f = new Fraction(fodj1.numerator * fodj2.denumerator + fodj2.numerator * fodj1.denumerator, fodj1.denumerator * fodj2.denumerator);
			return f;
		}

		public static Fraction sub(Fraction fodj1, Fraction fodj2)
		{
			Fraction f = new Fraction((fodj1.numerator * fodj2.denumerator) - (fodj2.numerator * fodj1.denumerator), fodj1.denumerator * fodj2.denumerator);
			return f;
		}

		public static Fraction mult(Fraction fodj1, Fraction fodj2)
		{
			Fraction f = new Fraction(fodj1.numerator * fodj2.numerator, fodj1.denumerator * fodj2.denumerator);
			return f;
		}

		public static Fraction div(Fraction fodj1, Fraction fodj2)
		{
			Fraction f = new Fraction(fodj1.numerator * fodj2.denumerator, fodj2.numerator * fodj1.denumerator);
			return f;
		}

		public static bool ravni(Fraction fodj1, Fraction fodj2)
		{
			if ((fodj1.denumerator * fodj2.denumerator) == (fodj1.numerator * fodj2.numerator))
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public static bool bolse(Fraction fodj1, Fraction fodj2)
		{
			if ((fodj1.denumerator * fodj2.denumerator) > (fodj1.numerator * fodj2.numerator))
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public static bool menche(Fraction fodj1, Fraction fodj2)
		{
			if ((fodj1.denumerator * fodj2.denumerator) < (fodj1.numerator * fodj2.numerator))
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public bool bolseiliravni(Fraction fodj1, Fraction fodj2)
		{
			if ((fodj1.denumerator * fodj2.denumerator) >= (fodj1.numerator * fodj2.numerator))
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public bool mencheiliravni(Fraction fodj1, Fraction fodj2)
		{
			if ((fodj1.denumerator * fodj2.denumerator) <= (fodj1.numerator * fodj2.numerator))
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public static Fraction plusplus(Fraction fodj1)
		{
			fodj1.numerator = fodj1.numerator + fodj1.denumerator;
			return fodj1;
		}

		public static Fraction minysminys(Fraction fodj1)
		{
			fodj1.numerator = fodj1.numerator - fodj1.denumerator;
			return fodj1;
		}

		public static Fraction pow(Fraction fodj1,int n)
		{
			Fraction f = new Fraction();
			f = fodj1;
			for (int i = 1; i < n; i++)
			{
				f = mult(f,f);
			}
			return f;
		}
		public static Fraction sqrt1(Fraction fodj1)
		{
			Fraction f = new Fraction(Convert.ToInt32(Math.Sqrt(fodj1.numerator)), Convert.ToInt32(Math.Sqrt(fodj1.denumerator)));
			return f;
		}
		public static Fraction Ne(Fraction fodj1)
		{
			if (fodj1.numerator > 0)
			{
				Fraction f = new Fraction(fodj1.denumerator, fodj1.numerator);
				return f;
			}
			else
			{
				Fraction f = new Fraction(fodj1.numerator, fodj1.denumerator);
				return f;
			}
		}
		public static Fraction operator +(Fraction fraction1, Fraction fraction2)
		{
			return add(fraction1, fraction2);
		}
		public static Fraction operator -(Fraction fraction1, Fraction fraction2)
		{
			return sub(fraction1, fraction2);
		}
		public static Fraction operator *(Fraction fraction1, Fraction fraction2)
		{
			return mult(fraction1, fraction2);
		}
		public static Fraction operator /(Fraction fraction1, Fraction fraction2)
		{
			return div(fraction1, fraction2);
		}
		public static bool operator >(Fraction fraction1, Fraction fraction2)
		{
			return bolse(fraction1, fraction2);
		}
		public static bool operator <(Fraction fraction1, Fraction fraction2)
		{
			return menche(fraction1, fraction2);
		}
		public static bool operator ==(Fraction fraction1, Fraction fraction2)
		{
			return ravni(fraction1, fraction2);
		}
		public static bool operator !=(Fraction fraction1, Fraction fraction2)
		{
			return !ravni(fraction1, fraction2);
		}
		public static Fraction operator --(Fraction fraction1)
		{
			return minysminys(fraction1);
		}
		public static Fraction operator ++(Fraction fraction1)
		{
			return plusplus(fraction1);
		}
		public static Fraction operator ^(Fraction fraction1,int n)
		{
			return pow(fraction1,n);
		}
		public static Fraction operator ~(Fraction fraction1)
		{
			return sqrt1(fraction1);
		}
		public static Fraction operator !(Fraction fraction1)
		{
			return Ne(fraction1);
		}


}
	class Student
	{
		int id;
		string fname = "Jonh";
		string lname = "Doe";
		string group;
		public void Print()
		{
			WriteLine($"Студент {fname}{lname}");
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			//Student s;
			//s = new Student();
			//s.Print();
			//Student s1;
			//s1 = new Student();
			//s1.Print();
			Fraction f1;
			Fraction f2;
			WriteLine($"Введите числитель");
			int n = Convert.ToInt32(ReadLine());
			WriteLine($"Введите знаменатель");
			int t = Convert.ToInt32(ReadLine());
			f1 = new Fraction(n, t);
			f2 = new Fraction(1, 8);
			Fraction f3 = f1 + f2;
			WriteLine($"Сложение:");
			f3.print();
			WriteLine($"Вычитание:");
			f3 = f1-f2;
			f3.print();
			WriteLine($"Умножение:");
			f3 = f1 * f2;
			f3.print();
			WriteLine($"Деление:");
			f3 = f1 / f2;
			f3.print();

			if (f1 == f2)
			{
				WriteLine($"Равны");
			}
			if (f1 > f2)
			{
				WriteLine($"Больше \n");
			}
			if (f1 < f2)
			{
				WriteLine($"Меньше ");
			}
			WriteLine($"++:");
			f1 = f1++;
			f1.print();

			WriteLine($"--:");
			f1 = f1--;
			f1.print();

			WriteLine($"В квадрате:");
			f1 = f1^2;
			f1.print();

			WriteLine($"Корень:");
			f1 = ~f1;
			f1.print();

			WriteLine($"!:");
			f1 = !f1;
			f1.print();
		}
	}
}
