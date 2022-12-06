using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask_12
{
    internal class Calc
    {
        internal static int[] arr = { 1, 5, 423, 27, 123, 320, 12, 125, 923, 50, 102 };

        internal static async Task<double> CalcEmployeeSalary(Employee emp, int[] arr, Func<int,bool> func)
        {
            List<int> list = new List<int>();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Thread.Sleep(1000);
            foreach (var item in arr)
            { 
                if (func(item))
                    list.Add(item);
            }
            stopwatch.Stop();
            emp.WorkDuration=stopwatch.ElapsedMilliseconds;       

            return emp.GetDailyPrice(Convert.ToInt32(emp.WorkDuration)%1000);
        }
    }
}
