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
            float totalHours = (DateTime.Now - startTime).Hours;

            decimal total = (decimal)Math.Round(totalHours * costPerHour, 2);

            total = Math.Round(total - (costPerHour / 6), 2);

            if (total > (decimal)0.5)

                return total;

            else
                return 0;

        }
    }
}
