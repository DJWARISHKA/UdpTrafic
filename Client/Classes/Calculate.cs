using System;
using System.Data;

namespace Client
{
    internal class Calculate
    {
        private int sum = 0;
        private int count = 1;
        private double M = 0.0;
        private double S = 0.0;

        //data processing from table
        public void CalculateTable(ref DataSet dataSet)
        {
            int num;
            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                num = Convert.ToInt32(row.ItemArray[0]);
                sum += num;
                standardDeviation(num);
                count++;
            }
        }

        //calculate average value
        public double AverageValue()
        {
            if (count == 0)
                return 0;

            return sum / count;
        }

        //calculate standard deviation
        private void standardDeviation(int num)
        {
            double tmpM = M;
            M += (num - tmpM) / count;
            S += (num - tmpM) * (num - M);
        }

        //return Standard Deviation
        public double StandardDeviation()
        {
            return Math.Sqrt(S / (count - 1));
        }
    }
}