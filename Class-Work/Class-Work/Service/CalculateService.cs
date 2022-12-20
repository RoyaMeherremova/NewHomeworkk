using Class_Work.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Work.Service
{
    internal class CalculateService : ICalculateService
    {
        public void SumNumbers(int num1, int num2)
        {
            int sum = num1 + num2;
            Console.WriteLine(sum);
        }
        public int GetSumNumbersFromArray(int[] arr)
        {
            int sum = 0;
            foreach (var item in arr)
            {
                sum += item;
                
            }
            return sum;
        }
    }
}
