using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLibrary
{
    public class CostCalculation
    {


        public decimal CalculateCost(DateTime startTime, int costPerHour)
        {
            TimeSpan totalHours = (DateTime.Now - startTime);

            decimal total = (decimal)Math.Round(totalHours.TotalHours * costPerHour);

            total = Math.Round(total - (costPerHour / 6));

            if (total > 0)

                return total;

            else
                return 0;

        }
    }
}
