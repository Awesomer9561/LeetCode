using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ArrayRotation
    {
        public ArrayRotation()
        {
            var input = 2;
            var array = new int[] { 1, 2, 3, 4, 5 };
            var newArr = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                if (i + input < array.Length)
                {
                    newArr[i] = array[i + input];
                }
                else
                {
                    newArr[i] = array[i + input - array.Length];
                }
            }
            _ = newArr;
        }
    }
}
