using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPair
{/// <summary>
/// Класс, производящий умножение пары четных чисел
/// </summary>
    public class Pair
    {
        int[] _result;
        public int Value1 { get; set; }
        public int Value2 { get; set; }
        public int[] Result { get {return _result; } }
        public Pair(int value1, int value2)
        {
            Value1 = value1;
            Value2 = value2;
        }/// <summary>
        /// Происходит проверка значений на четность
        /// </summary>
        /// <param name="twopair">Объект, хранящий в себе 2 числа</param>
        /// <returns>true - в случае, когда все числа четные и false - в случае, когда не все числа четные</returns>
        private bool ProveValues(in Pair twopair)
        {
            if (Value1 % 2 == 0 && Value2 % 2 == 0 && twopair.Value1 % 2 == 0 && twopair.Value2 % 2 == 0) return true;
            return false;
        }/// <summary>
         /// Выполнение умножения пар четных чисел
         /// </summary>
         /// <param name="twopair">Объект, хранящий в себе 2 числа</param>
        public void PairCalculate(in Pair twopair)
        {
            if (ProveValues(twopair) == true)
            {
                _result = new int[2];
                _result[0] = Value1 * twopair.Value1;
                _result[1] = Value2 * twopair.Value2;
            }                 
        }
    }
}
