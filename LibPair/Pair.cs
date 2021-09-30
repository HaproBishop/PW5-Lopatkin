using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPair
{
    public class Pair
    {        
        public int Value1 { get; set; }
        public int Value2 { get; set; }
        public int Value3 { get; set; }
        public int Value4 { get; set; }
        public int[] Result { get; set; }               
        public Pair(int value1, int value2, int value3, int value4)
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
            Value4 = value4;
        }
        private bool ProveValuesEvenWithObject()
        {            
            if (Value1 % 2 == 0)
                if (Value2 % 2 == 0)
                    if (Value3 % 2 == 0)
                        if (Value4 % 2 == 0) return true;
            return false;
        }
        public int[] PairCalculateWithObject()
        {            
            if (ProveValuesEvenWithObject() == true)
            {
                Result = new int[2];
                Result[0] = Value1 * Value3;
                Result[1] = Value2 * Value4;
                return Result;
            }
            else return null;
        }
        public static bool ProveValuesEvenWithoutObject(int value1, int value2, int value3, int value4)
        {
            if (value1 % 2 == 0)
                if (value2 % 2 == 0)
                    if (value3 % 2 == 0)
                        if (value4 % 2 == 0) return true;
            return false;
        }
        public static int[] PairCalculateWithoutObject(int value1, int value2, int value3, int value4)
        {
            if (ProveValuesEvenWithoutObject(value1, value2, value3, value4) == true)
            {
                int[] mas = new int[2];
                mas[0] = value1 * value3;
                mas[1] = value2 * value4;
                return mas;
            }
            else return null;
        }
        
    }
}
