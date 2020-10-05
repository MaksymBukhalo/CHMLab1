using System;
using System.Linq.Expressions;
using System.Data;

namespace ChiselniMethodiLab_1
{
	class Program
	{

		static void Main(string[] args)
		{
			Console.WriteLine("Введiть ваше функцiональне рiвняння за правилами вводу рiвнянь:");
			string equation = Console.ReadLine();
			Console.WriteLine("Введiть посаток iнтервалу: ");
			double startInterval = Double.Parse(Console.ReadLine());
			Console.WriteLine("Введiть кiнець iнтервалу: ");
			double endInterval = Double.Parse(Console.ReadLine());
			FindEquationAnswers(startInterval, endInterval, equation);
			Console.ReadKey();
		}

		private static void FindEquationAnswers(double startInterval, double endInterval, string equation)
		{
			Console.WriteLine("{0}		{1}		{2}", "x", "F(x)", "F'(x)");
			double steps = 0.01;
			double i = startInterval;
			while (i <= endInterval)
			{
				string newEquation1 = equation.Replace("x", Convert.ToString(i));
				StringToFormula stf1 = new StringToFormula();
				double Fx = stf1.Eval(newEquation1);
				string newEquation2 = equation.Replace("x", Convert.ToString(i));
				StringToFormula stf2 = new StringToFormula();
				double Fx1 = stf2.Eval(newEquation2);
				Console.WriteLine("{0}		{1}		{2}", i, Fx, Fx1);
				i += steps;
			}
		}
	}
}
