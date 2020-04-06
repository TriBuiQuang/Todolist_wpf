using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.Models
{
    class Operand
    {
		public Operand()
		{
			IntegerPart = "0";
			DecimalPart = "";
			IsDotted = false;
			IsNegative = false;
		}

		public string IntegerPart { get; set; }

		public string DecimalPart { get; set; }

		public bool IsDotted { get; set; }

		public bool IsNegative { get; set; }

		public string FullPart 
		{ 
			get
			{
				if (IsDotted)
				{
					return $"{(IsNegative ? "-" : "")}" + String.Format("{0:n0}", Convert.ToDecimal(IntegerPart)) + "." + DecimalPart;
				}
				else
				{
					return $"{(IsNegative ? "-" : "")}" + String.Format("{0:n0}", Convert.ToDecimal(IntegerPart));
				}
			} 
		}

		public static Operand operator +(Operand _operand, string _number)
		{
			if (_operand.IsDotted)
			{
				_operand.DecimalPart = String.Concat(_operand.DecimalPart, _number);
				return _operand;
			}
			else
			{
				if (_operand.IntegerPart == "0")
				{
					_operand.IntegerPart = "";
				}

				_operand.IntegerPart = String.Concat(_operand.IntegerPart, _number);
				return _operand;
			}
		}

		public void Equal(decimal _operand)
		{
			if (_operand % 1 == 0)
			{
				IsDotted = false;
				DecimalPart = "";
				if (_operand < 0)
				{
					IsNegative = true;
					IntegerPart = (_operand * -1).ToString();
				}
				else
				{
					IsNegative = false;
					IntegerPart = _operand.ToString();
				}
			}
			else
			{
				string[] arr = _operand.ToString().Split('.');
				IsDotted = true;
				DecimalPart = arr[1];
				if (_operand < 0)
				{
					IsNegative = true;
					IntegerPart =(Convert.ToDecimal(arr[0].ToString()) * -1).ToString();
				}
				else
				{
					IsNegative = false;
					IntegerPart = arr[0];
				}
			}
		}

		public void Del()
		{
			if (IsDotted == true)
			{
				if (DecimalPart.Length <= 0)
				{
					IsDotted = false;
				}
				else
				{
					DecimalPart = DecimalPart.Remove(DecimalPart.Length - 1, 1);
				}
			} 
			else
			{
				if (IntegerPart.Length <= 1)
				{
					IntegerPart = "0";
				}
				else
				{
					IntegerPart = IntegerPart.Remove(IntegerPart.Length - 1, 1);
				}
			}
		}

	}
}
