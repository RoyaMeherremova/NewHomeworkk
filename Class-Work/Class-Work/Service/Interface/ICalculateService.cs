using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Work.Service.Interface
{
    internal interface ICalculateService
    {
        void SumNumbers(int num1,int num2);
        int GetSumNumbersFromArray(int[] nums);
    }
}
