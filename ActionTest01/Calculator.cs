using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ActionTest01
{
	public class Calculator
	{

		public int Add(int a, int b)
		{
			int value = 0;
			try
			{
				value = a + b;
			}
			catch (Exception)
			{

				throw;
			}
			return value;
		}


		public int Sub(int a, int b)
		{
			int value = 0;
			try
			{
				value = a - b;
			}
			catch (Exception)
			{

				throw;
			}
			return value;
		}




	}
}
