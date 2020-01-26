using System;
using System.Threading.Tasks;
using System.Threading;
using System.Linq;

namespace ConsoleApp1
{
    class AsyncExample2
    {
        public async Task<string> GetTodayInfo(){
            string str = "Today is : " + DateTime.Today + " " + DateTime.Now.TimeOfDay + " " + "Today hours of leisture : " + await GetListureHours();
            return str;
        }
        static async Task<int> GetListureHours()
        {
            var date = await Task.FromResult<string>(DateTime.Now.DayOfWeek.ToString());
            int hours;
            if (date.First() == 1)
            {
                hours = 16;
            }
            else
                hours = 5;
            return hours;
        }   
    }
}
