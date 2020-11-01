using System;

namespace DefiningClasses
{
    public class DateModifier
    {

        public int CalcDatesDiff(string date1, string date2)
        {
            DateTime startDate = DateTime.Parse(date1);
            DateTime endDate = DateTime.Parse(date2);

            int totalDays = (int)(endDate - startDate).TotalDays;

            return totalDays;
        }
    }
}
