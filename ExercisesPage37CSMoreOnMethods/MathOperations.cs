using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesPage37CSMoreOnMethods
{
    public class MathOperations
    {
        public int Calculate (int IntegerOperation)
        {
            return IntegerOperation * IntegerOperation;
        }

        public decimal Calculate (decimal DecimalOperation)
        {
            return DecimalOperation / 2;
        }

        public double Calculate (string StringToIntOperation)
        {
            Int32.TryParse(StringToIntOperation, out int stringToInt);
            return stringToInt * 1111;
        }

        //The following method was an extra method I created just for fun to do a more complex math operation involving doubles
        //public double Calculate(string StringToIntOperation)
        //{
        //    Int32.TryParse(StringToIntOperation, out int stringToInt);
        //    double IntToThirdPower = Convert.ToDouble(stringToInt);
        //    double getDouble = Math.Pow(IntToThirdPower, 3);
        //    return getDouble;
        //}
    }
}
