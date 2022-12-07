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

        internal static async Task<double> CalcEmployeeSalary(Employee emp, int[] arr, Func<int,bool> func)
        {
            List<int> list = new List<int>();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            foreach (var item in arr)
            { 
                if (func(item))
                    list.Add(item);
            }
            stopwatch.Stop();
            emp.WorkDuration+=stopwatch.Elapsed.TotalMilliseconds;       

            return emp.GetDailyPrice(emp.WorkDuration);
        }
    }
}
